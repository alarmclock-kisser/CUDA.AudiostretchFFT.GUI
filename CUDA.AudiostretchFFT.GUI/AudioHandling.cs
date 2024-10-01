using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUDA.AudiostretchFFT.GUI
{
	public class AudioHandling
	{
		// Attributes
		public string? filePath;
		public string? outputPath;
		public float[]? audioData;
		public int? sampleRate;
		public int? channels;
		public int? bitsPerSample;
		public int? audioLength;
		public float[]? outputData;

		// Constructor
		public AudioHandling()
		{
			// Default Initialization
		}

		// Methods
		public void LoadAudioFile(string path)
		{
			// Validate path
			if (path == null || path == "" || File.Exists(path) == false)
			{
				throw new ArgumentNullException("Invalid file path");
			}

			// Load audio file
			this.filePath = path;
			using var reader = new AudioFileReader(path);
			this.sampleRate = reader.WaveFormat.SampleRate;
			this.channels = reader.WaveFormat.Channels;
			this.bitsPerSample = reader.WaveFormat.BitsPerSample;
			this.audioLength = (int)reader.Length / (reader.WaveFormat.BitsPerSample / 8);
			this.audioData = new float[(int)this.audioLength];
			reader.Read(this.audioData, 0, (int)this.audioLength);

			// Set output path
			this.outputPath = Path.GetDirectoryName(path);

			// Set output data
			this.outputData = new float[(int)this.audioLength];

			// Dispose reader
			reader.Dispose();
		}
	}
}
