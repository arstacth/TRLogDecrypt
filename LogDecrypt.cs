using System;
using System.IO;
using System.Text;

namespace TRLogDecrypt
{
	public static class LogDecrypt
	{
		private static readonly byte[] Key = Encoding.ASCII.GetBytes("76CF7AFF26F1568863EF972FE4DFAD30");
		public const string HeaderMagic = "TALESRUNNER-B5389169-5DAD-412E-9:<";

		public static void DecryptFile(string inputPath, string outputPath)
		{
			byte[] data = File.ReadAllBytes(inputPath);
			int n = DecryptBuffer(data);
			int header = HeaderMagic.Length;
			byte[] plain = new byte[n - header];
			Buffer.BlockCopy(data, header, plain, 0, plain.Length);
			File.WriteAllBytes(outputPath, plain);
		}

		public static int DecryptBuffer(byte[] data)
		{
			if (data == null)
				throw new ArgumentNullException("data");

			int header = HeaderMagic.Length;
			if (data.Length < header)
				throw new InvalidDataException("File is too small to be a TalesRunner log.");

			for (int i = 0; i < header; i++)
				data[i] = (byte)(data[i] ^ Key[i % Key.Length]);

			if (Encoding.ASCII.GetString(data, 0, header) != HeaderMagic)
				throw new InvalidDataException("Not a TalesRunner encrypted log.");

			int keyIndex = 0;
			for (int i = header; i < data.Length; i++)
			{
				byte b = (byte)(data[i] ^ Key[keyIndex % Key.Length]);
				data[i] = b;
				keyIndex++;
				if (b == (byte)'\n')
					keyIndex = 0;
			}
			return data.Length;
		}
	}
}
