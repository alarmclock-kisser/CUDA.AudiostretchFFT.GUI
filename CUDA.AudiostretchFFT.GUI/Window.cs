using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;

namespace CUDA.AudiostretchFFT.GUI
{
	public partial class Window_Main : Form
	{
		// Attributes  
		private CudaHandling CuH;
		private FileHandling FiH;

		// Constructor  
		public Window_Main()
		{
			// Default Initialization  
			InitializeComponent();

			// Initialize CudaHandling Object and its Context
			CuH = new CudaHandling();

			// Initialize FileHandling Object
			FiH = new FileHandling();

			// Custom Initialization + set text_Boxes Input / Output to This PC's Desktop
			this.textBox_Input.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
			this.textBox_Output.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			this.FiH.InputPath = this.textBox_Input.Text;
			this.FiH.OutputPath = this.textBox_Output.Text;
			this.ToggleGuiElements();

			// Load Devices
			this.LoadDevices();
		}

		// Methods  
		private void ToggleGuiElements(string arg = "auto")
		{
			// args can be "off" or "on", default "auto" (check logic & state)  
			if (arg == "auto")
			{
				// Check per GUI element depending on the state  
			}

			if (arg == "off")
			{
				// Disable all GUI elements  
			}

			if (arg == "on")
			{
				// Enable all GUI elements  
			}

			// End  
			return;
		}

		private void LoadDevices()
		{
			// Clear listBox_Devices  
			this.listBox_Devices.Items.Clear();

			// Get names of all available CUDA devices  
			for (int i = 0; i < CuH?.GetDeviceCount(); i++)
			{
				if (CuH != null)
				{
					// Get full device name and its id is i
					string name = CuH.GetDeviceName(i);

					// Remove first part of the name til ' '("NVIDIA ")
					name = name.Substring(name.IndexOf(' ') + 1);

					// Add device name to listBox_Devices
					this.listBox_Devices.Items.Add(i + ": " + name);
				}
			}
		}

		private void label_Devices_Click(object sender, EventArgs e)
		{
			// Toggle: Check if the context is already initialized -> Dispose it
			if (CuH.Context != null)
			{
				// Dispose the context
				CuH.DisposeContext(CuH.Context);

				// Toggle GUI elements (label_Devices to underline, "Hot Track", "Initialize selected device...")
				this.label_Devices.Text = "Initialize selected device...";
				this.label_Devices.ForeColor = Color.FromName("HotTrack");
				this.label_Devices.Font = new Font(this.label_Devices.Font, FontStyle.Underline);

				// Reload devices
				this.LoadDevices();

				// Unlock listBox_Devices
				this.listBox_Devices.SelectionMode = SelectionMode.One;

				// Abort
				return;
			}

			// Abort if no device is selected from listBox_Devices
			if (this.listBox_Devices.SelectedIndex == -1)
			{
				return;
			}

			// Get selected device id from listBox_Devices
			int id = this.listBox_Devices.SelectedIndex;

			// Initialize the context with the selected device
			CuH.InitializeContext(CuH.GetContextById(id));

			// Toggle GUI elements (label_Devices to bold, green, device name (bold, GreenYellow, device name if name unavailable))
			string name = CuH.GetDeviceName(id);

			// Only take first word of the name
			name = name.Split(' ')[0];

			// If name is unavailable, set it to its id (GreenYellow)
			if (name == null)
			{
				this.label_Devices.Text = "[" + id + "] initialized!";
				this.label_Devices.ForeColor = Color.GreenYellow;
				this.label_Devices.Font = new Font(this.label_Devices.Font, FontStyle.Bold);
			}
			else
			{
				this.label_Devices.Text = name + " initialized!";
				this.label_Devices.ForeColor = Color.Green;
				this.label_Devices.Font = new Font(this.label_Devices.Font, FontStyle.Bold);
			}

			// Place '* ' before the selected entry value in listBox_Devices
			this.listBox_Devices.Items[id] = "⭐ " + this.listBox_Devices.Items[id];

			// Change color & font of the selected entry in listBox_Devices (Green, Bold)
			this.listBox_Devices.ForeColor = Color.Green;
			this.listBox_Devices.Font = new Font(this.listBox_Devices.Font, FontStyle.Bold);

			// Lock listBox_Devices
			this.listBox_Devices.SelectionMode = SelectionMode.None;
		}

		private void textBox_Input_TextChanged(object sender, EventArgs e)
		{
			// ValidateInputPath(Text)
			this.FiH.ValidateInputPath(this.textBox_Input.Text);

			// GetInputFiles(Text) if FiH.InputFiles.Count != 0
			if (this.FiH.InputFiles.Count != 0)
			{
				this.FiH.GetInputFiles(this.textBox_Input.Text);
			}

			// Update listBox_InputFiles
			this.listBox_FilesList.Items.Clear();
			foreach (string file in this.FiH.InputFiles)
			{
				// Add first 20 characters of the file name to listBox_FilesList
				this.listBox_FilesList.Items.Add(file.Substring(file.LastIndexOf('\\') + 1, 20));
			}
		}

		private void textBox_Output_TextChanged(object sender, EventArgs e)
		{
			// ValidateOutputPath(Text)
			this.FiH.ValidateOutputPath(this.textBox_Output.Text);
		}

		private void button_InputBrowse_Click(object sender, EventArgs e)
		{
			// Open FolderBrowserDialog at textBox_Input
			FolderBrowserDialog fbd = new();
			fbd.InitialDirectory = this.textBox_Input.Text;

			// Set the selected path to textBox_Input if OK is pressed and DialogResult is OK
			if (fbd.ShowDialog() == DialogResult.OK)
			{
				this.textBox_Input.Text = fbd.SelectedPath;
			}

			// ValidateInputPath(Text)
			this.FiH.ValidateInputPath(this.textBox_Input.Text);

			// GetInputFiles(Text) if FiH.InputFiles.Count != 0
			if (this.FiH.InputFiles.Count != 0)
			{
				this.FiH.GetInputFiles(this.textBox_Input.Text);
			}

			// Update listBox_InputFiles
			this.listBox_FilesList.Items.Clear();
			foreach (string file in this.FiH.InputFiles)
			{
				// Add first 20 characters of the file name to listBox_FilesList
				this.listBox_FilesList.Items.Add(file.Substring(file.LastIndexOf('\\') + 1, 20));
			}
		}

		private void button_OutputBrowse_Click(object sender, EventArgs e)
		{
			// Open FolderBrowserDialog at textBox_Output
			FolderBrowserDialog fbd = new();
			fbd.InitialDirectory = this.textBox_Output.Text;

			// Set the selected path to textBox_Output if OK is pressed and DialogResult is OK
			if (fbd.ShowDialog() == DialogResult.OK)
			{
				this.textBox_Output.Text = fbd.SelectedPath;
			}

			// ValidateOutputPath(Text)
			this.FiH.ValidateOutputPath(this.textBox_Output.Text);
		}

		private void button_Open_Click(object sender, EventArgs e)
		{
			// Open explorer.exe at FiH.OutputPath if it's valid
			if (this.FiH.OutputPath != null)
			{
				Process.Start("explorer.exe", this.FiH.OutputPath);
			}
		}

		private void label_FilesList_Click(object sender, EventArgs e)
		{
			// Toggle GUI & FiH's Data depending on the state of label_FilesList
			if (this.label_FilesList.Text.StartsWith("Load"))
			{
				// ValidateInputPath(Text)
				if (this.FiH.ValidateInputPath(this.textBox_Input.Text) == false)
				{
					return;
				}

				// Get InputFiles
				this.FiH.GetInputFiles(this.textBox_Input.Text);

				// Update listBox_FilesList
				this.listBox_FilesList.Items.Clear();
				foreach (string file in this.FiH.InputFiles)
				{
					// Add file name to listBox_FilesList
					this.listBox_FilesList.Items.Add(file.Substring(file.LastIndexOf('\\') + 1));
				}

				// Update label_FilesList
				if (this.FiH.InputFiles.Count == 0)
				{
					// 0 files found
					this.label_FilesList.Text = "No files found!";
					this.label_FilesList.ForeColor = Color.Red;
				}
				else
				{
					// x files found
					this.label_FilesList.Text = FiH.InputFiles.Count + " files found!";
					this.label_FilesList.ForeColor = Color.Green;
				}
			}
			if (this.label_FilesList.Text.StartsWith("No"))
			{
				// Reset listBox_FilesList
				this.listBox_FilesList.Items.Clear();

				// Reset label_FilesList
				this.label_FilesList.Text = "Load input files...";
				this.label_FilesList.ForeColor = Color.FromName("HotTrack");
			}
			if (this.label_FilesList.Text[0].GetType() == typeof(int))
			{
				// if (int) x files found -> Unload files & reset label_FilesList & listBox_FilesList
				this.FiH.InputFiles.Clear();
				this.label_FilesList.Text = "Load input files...";
				this.label_FilesList.ForeColor = Color.FromName("HotTrack");
				this.listBox_FilesList.Items.Clear();
			}
		}
	}
}
