using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUDA.AudiostretchFFT.GUI
{
	public class FileHandling
	{
		// Attributes
		public string? InputPath;
		public string? OutputPath;
		public List<string> InputFiles = [];
		public List<string> OutputFiles = [];
		public List<string> Extensions = [".wav", ".mp3", ".flac"];

		// Constructor
		public FileHandling()
		{
			// Default Initialization
		}

		// Methods
		public static string GetRepositoryRoot()
		{
			// Get the repository root path
			return Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\"));
		}

		public string[] GetInputFiles(string path)
		{
			// Validate path
			if (ValidateInputPath(path) == false)
			{
				// Return empty list + entry "None"
				this.InputFiles.Clear();
				this.InputFiles.Add("None");
				return [.. this.InputFiles];
			}

			// Clear InputFiles
			this.InputFiles.Clear();

			// Get all files in the directory with supported extensions
			foreach (string file in Directory.GetFiles(path))
			{
				if (this.Extensions.Contains(Path.GetExtension(file)))
				{
					this.InputFiles.Add(file);
				}
			}

			// Return InputFiles
			return [.. this.InputFiles];
		}

		public bool ValidateOutputPath(string path)
		{
			// Validate path and return false if it's empty
			if (path == null || path == "")
			{
				return false;
			}

			// Check if the directory exists, create it if it doesn't
			if (Directory.Exists(path) == false)
			{
				// Try to create the directory, catch create Output directory in repository-root
				try
				{
					Directory.CreateDirectory(path);
				}
				catch
				{
					Directory.CreateDirectory(Path.Combine(GetRepositoryRoot(), "Output"));
				}

				// return false if the directory still doesn't exist
				if (Directory.Exists(path) == false)
				{
					return false;
				}

				// Set OutputPath
				this.OutputPath = path;

				// Return true
				return true;
			}

			// Default return false
			return false;
		}

		public bool ValidateInputPath(string path)
		{
			// Validate path and return false if it's empty
			if (path == null || path == "")
			{
				return false;
			}

			// Check if the directory exists
			if (Directory.Exists(path) == false)
			{
				return false;
			}

			// Set InputPath
			this.InputPath = path;

			// Return true if not aborted before
			return true;
		}
	}
}
