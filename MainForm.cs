using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TRLogDecrypt
{
	public partial class MainForm : Form
	{
		internal static readonly Color Bg = Color.FromArgb(22, 22, 24);
		internal static readonly Color Panel = Color.FromArgb(32, 32, 36);
		internal static readonly Color Border = Color.FromArgb(58, 58, 64);
		internal static readonly Color Fg = Color.FromArgb(232, 232, 236);
		internal static readonly Color Muted = Color.FromArgb(150, 150, 158);
		internal static readonly Color Accent = Color.FromArgb(88, 166, 255);
		internal static readonly Color AccentHover = Color.FromArgb(110, 180, 255);
		internal static readonly Color Ok = Color.FromArgb(110, 200, 140);
		internal static readonly Color Err = Color.FromArgb(232, 110, 110);

		private Point dragOffset;
		private bool dragging;

		public MainForm()
		{
			InitializeComponent();
			DoubleBuffered = true;

			pathBox.Text = DefaultLogPath();
			if (File.Exists(pathBox.Text))
				SetStatus("Default log found. Click Decrypt.", Muted);
			else
				SetStatus("Default log not found. Browse for dbgtrace.txt or patchlog.txt.", Muted);

			MouseDown += OnDragStart;
			titleLabel.MouseDown += OnDragStart;
			subtitleLabel.MouseDown += OnDragStart;
			pathCaptionLabel.MouseDown += OnDragStart;
			statusLabel.MouseDown += OnDragStart;
			MouseMove += OnDragMove;
			titleLabel.MouseMove += OnDragMove;
			subtitleLabel.MouseMove += OnDragMove;
			MouseUp += OnDragEnd;
			titleLabel.MouseUp += OnDragEnd;
			subtitleLabel.MouseUp += OnDragEnd;
		}

		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams cp = base.CreateParams;
				cp.ClassStyle |= 0x20000;
				return cp;
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			using (Pen pen = new Pen(Border))
				e.Graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
		}

		private static string DefaultLogPath()
		{
			return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TalesRunner", "dbgtrace.txt");
		}

		private static string OutputPath(string inputPath)
		{
			string exeDir = AppDomain.CurrentDomain.BaseDirectory;
			string name = Path.GetFileNameWithoutExtension(inputPath);
			if (string.IsNullOrEmpty(name))
				name = "dbgtrace";
			return Path.Combine(exeDir, name + "_de.txt");
		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void browseButton_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog dlg = new OpenFileDialog())
			{
				dlg.Title = "Select TalesRunner log";
				dlg.Filter = "TalesRunner logs|dbgtrace.txt;patchlog.txt;*.txt|All files|*.*";
				dlg.FileName = Path.GetFileName(pathBox.Text);
				string dir = Path.GetDirectoryName(pathBox.Text);
				if (!string.IsNullOrEmpty(dir) && Directory.Exists(dir))
					dlg.InitialDirectory = dir;
				if (dlg.ShowDialog(this) != DialogResult.OK)
					return;
				pathBox.Text = dlg.FileName;
				DecryptCurrent();
			}
		}

		private void decryptButton_Click(object sender, EventArgs e)
		{
			DecryptCurrent();
		}

		private void MainForm_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.Copy;
		}

		private void MainForm_DragDrop(object sender, DragEventArgs e)
		{
			string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
			if (files == null || files.Length == 0)
				return;
			pathBox.Text = files[0];
			DecryptCurrent();
		}

		private void DecryptCurrent()
		{
			string input = (pathBox.Text ?? "").Trim().Trim('"');
			if (input.Length == 0 || !File.Exists(input))
			{
				SetStatus("Log file not found.", Err);
				return;
			}
			try
			{
				string output = OutputPath(input);
				LogDecrypt.DecryptFile(input, output);
				SetStatus("Saved " + output, Ok);
			}
			catch (Exception ex)
			{
				SetStatus(ex.Message, Err);
			}
		}

		private void SetStatus(string text, Color color)
		{
			statusLabel.Text = text;
			statusLabel.ForeColor = color;
		}

		private void OnDragStart(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left)
				return;
			dragging = true;
			dragOffset = e.Location;
			if (sender != this && sender is Control)
			{
				Control c = (Control)sender;
				dragOffset = new Point(e.X + c.Left, e.Y + c.Top);
			}
		}

		private void OnDragMove(object sender, MouseEventArgs e)
		{
			if (!dragging)
				return;
			Point screen = PointToScreen(e.Location);
			if (sender != this && sender is Control)
			{
				Control c = (Control)sender;
				screen = c.PointToScreen(e.Location);
			}
			Location = new Point(screen.X - dragOffset.X, screen.Y - dragOffset.Y);
		}

		private void OnDragEnd(object sender, MouseEventArgs e)
		{
			dragging = false;
		}
	}
}
