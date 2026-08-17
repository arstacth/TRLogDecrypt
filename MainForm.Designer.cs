namespace TRLogDecrypt
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
				components.Dispose();
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			this.titleLabel = new System.Windows.Forms.Label();
			this.subtitleLabel = new System.Windows.Forms.Label();
			this.closeButton = new System.Windows.Forms.Button();
			this.pathCaptionLabel = new System.Windows.Forms.Label();
			this.pathBox = new System.Windows.Forms.TextBox();
			this.browseButton = new System.Windows.Forms.Button();
			this.decryptButton = new System.Windows.Forms.Button();
			this.statusLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// titleLabel
			// 
			this.titleLabel.BackColor = System.Drawing.Color.Transparent;
			this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
			this.titleLabel.Location = new System.Drawing.Point(16, 12);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(360, 22);
			this.titleLabel.TabIndex = 0;
			this.titleLabel.Text = "TRLogDecrypt";
			// 
			// subtitleLabel
			// 
			this.subtitleLabel.BackColor = System.Drawing.Color.Transparent;
			this.subtitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(158)))));
			this.subtitleLabel.Location = new System.Drawing.Point(16, 34);
			this.subtitleLabel.Name = "subtitleLabel";
			this.subtitleLabel.Size = new System.Drawing.Size(400, 18);
			this.subtitleLabel.TabIndex = 1;
			this.subtitleLabel.Text = "TalesRunner dbgtrace / patchlog decrypt";
			// 
			// closeButton
			// 
			this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
			this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.closeButton.FlatAppearance.BorderSize = 0;
			this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
			this.closeButton.Location = new System.Drawing.Point(480, 8);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(28, 28);
			this.closeButton.TabIndex = 2;
			this.closeButton.TabStop = false;
			this.closeButton.Text = "×";
			this.closeButton.UseVisualStyleBackColor = false;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// pathCaptionLabel
			// 
			this.pathCaptionLabel.BackColor = System.Drawing.Color.Transparent;
			this.pathCaptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(158)))));
			this.pathCaptionLabel.Location = new System.Drawing.Point(16, 64);
			this.pathCaptionLabel.Name = "pathCaptionLabel";
			this.pathCaptionLabel.Size = new System.Drawing.Size(200, 16);
			this.pathCaptionLabel.TabIndex = 3;
			this.pathCaptionLabel.Text = "Log file";
			// 
			// pathBox
			// 
			this.pathBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
			this.pathBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pathBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
			this.pathBox.Location = new System.Drawing.Point(16, 84);
			this.pathBox.Name = "pathBox";
			this.pathBox.Size = new System.Drawing.Size(390, 26);
			this.pathBox.TabIndex = 4;
			// 
			// browseButton
			// 
			this.browseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
			this.browseButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.browseButton.FlatAppearance.BorderSize = 0;
			this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.browseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
			this.browseButton.Location = new System.Drawing.Point(414, 83);
			this.browseButton.Name = "browseButton";
			this.browseButton.Size = new System.Drawing.Size(90, 28);
			this.browseButton.TabIndex = 5;
			this.browseButton.TabStop = false;
			this.browseButton.Text = "Browse";
			this.browseButton.UseVisualStyleBackColor = false;
			this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
			// 
			// decryptButton
			// 
			this.decryptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
			this.decryptButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.decryptButton.FlatAppearance.BorderSize = 0;
			this.decryptButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
			this.decryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.decryptButton.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.decryptButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
			this.decryptButton.Location = new System.Drawing.Point(16, 124);
			this.decryptButton.Name = "decryptButton";
			this.decryptButton.Size = new System.Drawing.Size(488, 34);
			this.decryptButton.TabIndex = 6;
			this.decryptButton.Text = "Decrypt";
			this.decryptButton.UseVisualStyleBackColor = false;
			this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
			// 
			// statusLabel
			// 
			this.statusLabel.BackColor = System.Drawing.Color.Transparent;
			this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(158)))));
			this.statusLabel.Location = new System.Drawing.Point(16, 166);
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(488, 18);
			this.statusLabel.TabIndex = 7;
			this.statusLabel.Text = "Output is saved next to this program.";
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
			this.ClientSize = new System.Drawing.Size(520, 196);
			this.Controls.Add(this.statusLabel);
			this.Controls.Add(this.decryptButton);
			this.Controls.Add(this.browseButton);
			this.Controls.Add(this.pathBox);
			this.Controls.Add(this.pathCaptionLabel);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.subtitleLabel);
			this.Controls.Add(this.titleLabel);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowInTaskbar = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TRLogDecrypt";
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Label subtitleLabel;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Label pathCaptionLabel;
		private System.Windows.Forms.TextBox pathBox;
		private System.Windows.Forms.Button browseButton;
		private System.Windows.Forms.Button decryptButton;
		private System.Windows.Forms.Label statusLabel;
	}
}
