
namespace CUDA.AudiostretchFFT.GUI
{
	partial class Window_Main
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			menuStrip = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			exitToolStripMenuItem = new ToolStripMenuItem();
			editToolStripMenuItem = new ToolStripMenuItem();
			deviceToolStripMenuItem = new ToolStripMenuItem();
			cUDAToolStripMenuItem = new ToolStripMenuItem();
			initializeToolStripMenuItem = new ToolStripMenuItem();
			strongestToolStripMenuItem = new ToolStripMenuItem();
			firstToolStripMenuItem = new ToolStripMenuItem();
			nextToolStripMenuItem = new ToolStripMenuItem();
			removeToolStripMenuItem = new ToolStripMenuItem();
			listToolStripMenuItem = new ToolStripMenuItem();
			audioToolStripMenuItem = new ToolStripMenuItem();
			configToolStripMenuItem = new ToolStripMenuItem();
			importToolStripMenuItem = new ToolStripMenuItem();
			exportToolStripMenuItem = new ToolStripMenuItem();
			defaultToolStripMenuItem = new ToolStripMenuItem();
			helpToolStripMenuItem = new ToolStripMenuItem();
			documentationToolStripMenuItem = new ToolStripMenuItem();
			versionInfoToolStripMenuItem = new ToolStripMenuItem();
			listBox_Devices = new ListBox();
			label_Devices = new Label();
			textBox_Output = new TextBox();
			progressBar = new ProgressBar();
			label_Output = new Label();
			label_Input = new Label();
			textBox_Input = new TextBox();
			button_InputBrowse = new Button();
			button_OutputBrowse = new Button();
			label_FilesList = new Label();
			listBox_FilesList = new ListBox();
			button_Open = new Button();
			menuStrip.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip
			// 
			menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, deviceToolStripMenuItem, configToolStripMenuItem, helpToolStripMenuItem });
			menuStrip.Location = new Point(0, 0);
			menuStrip.Name = "menuStrip";
			menuStrip.Size = new Size(700, 24);
			menuStrip.TabIndex = 0;
			menuStrip.Text = "menuStrip";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(37, 20);
			fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			exitToolStripMenuItem.ShortcutKeys =  Keys.Control | Keys.X;
			exitToolStripMenuItem.Size = new Size(180, 22);
			exitToolStripMenuItem.Text = "Exit";
			exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
			// 
			// editToolStripMenuItem
			// 
			editToolStripMenuItem.Name = "editToolStripMenuItem";
			editToolStripMenuItem.Size = new Size(39, 20);
			editToolStripMenuItem.Text = "Edit";
			// 
			// deviceToolStripMenuItem
			// 
			deviceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cUDAToolStripMenuItem, audioToolStripMenuItem });
			deviceToolStripMenuItem.Name = "deviceToolStripMenuItem";
			deviceToolStripMenuItem.Size = new Size(54, 20);
			deviceToolStripMenuItem.Text = "Device";
			// 
			// cUDAToolStripMenuItem
			// 
			cUDAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { initializeToolStripMenuItem, removeToolStripMenuItem, listToolStripMenuItem });
			cUDAToolStripMenuItem.Name = "cUDAToolStripMenuItem";
			cUDAToolStripMenuItem.Size = new Size(106, 22);
			cUDAToolStripMenuItem.Text = "CUDA";
			// 
			// initializeToolStripMenuItem
			// 
			initializeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { strongestToolStripMenuItem, firstToolStripMenuItem, nextToolStripMenuItem });
			initializeToolStripMenuItem.Name = "initializeToolStripMenuItem";
			initializeToolStripMenuItem.Size = new Size(160, 22);
			initializeToolStripMenuItem.Text = "Initialize";
			// 
			// strongestToolStripMenuItem
			// 
			strongestToolStripMenuItem.Name = "strongestToolStripMenuItem";
			strongestToolStripMenuItem.ShortcutKeys =  Keys.Control | Keys.I;
			strongestToolStripMenuItem.Size = new Size(218, 22);
			strongestToolStripMenuItem.Text = "Strongest";
			// 
			// firstToolStripMenuItem
			// 
			firstToolStripMenuItem.Name = "firstToolStripMenuItem";
			firstToolStripMenuItem.ShortcutKeys =  Keys.Control | Keys.Shift | Keys.I;
			firstToolStripMenuItem.Size = new Size(218, 22);
			firstToolStripMenuItem.Text = "First";
			// 
			// nextToolStripMenuItem
			// 
			nextToolStripMenuItem.Name = "nextToolStripMenuItem";
			nextToolStripMenuItem.Size = new Size(218, 22);
			nextToolStripMenuItem.Text = "Next";
			// 
			// removeToolStripMenuItem
			// 
			removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			removeToolStripMenuItem.ShortcutKeys =  Keys.Control | Keys.R;
			removeToolStripMenuItem.Size = new Size(160, 22);
			removeToolStripMenuItem.Text = "Remove";
			// 
			// listToolStripMenuItem
			// 
			listToolStripMenuItem.Name = "listToolStripMenuItem";
			listToolStripMenuItem.ShortcutKeys =  Keys.Control | Keys.L;
			listToolStripMenuItem.Size = new Size(160, 22);
			listToolStripMenuItem.Text = "List...";
			// 
			// audioToolStripMenuItem
			// 
			audioToolStripMenuItem.Name = "audioToolStripMenuItem";
			audioToolStripMenuItem.Size = new Size(106, 22);
			audioToolStripMenuItem.Text = "Audio";
			// 
			// configToolStripMenuItem
			// 
			configToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importToolStripMenuItem, exportToolStripMenuItem, defaultToolStripMenuItem });
			configToolStripMenuItem.Name = "configToolStripMenuItem";
			configToolStripMenuItem.Size = new Size(55, 20);
			configToolStripMenuItem.Text = "Config";
			// 
			// importToolStripMenuItem
			// 
			importToolStripMenuItem.Name = "importToolStripMenuItem";
			importToolStripMenuItem.ShortcutKeys =  Keys.Control | Keys.Shift | Keys.I;
			importToolStripMenuItem.Size = new Size(239, 22);
			importToolStripMenuItem.Text = "Import";
			// 
			// exportToolStripMenuItem
			// 
			exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			exportToolStripMenuItem.ShortcutKeys =  Keys.Control | Keys.Shift | Keys.E;
			exportToolStripMenuItem.Size = new Size(239, 22);
			exportToolStripMenuItem.Text = "Export";
			// 
			// defaultToolStripMenuItem
			// 
			defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
			defaultToolStripMenuItem.ShortcutKeys =  Keys.Control | Keys.Shift | Keys.D;
			defaultToolStripMenuItem.Size = new Size(239, 22);
			defaultToolStripMenuItem.Text = "Default";
			// 
			// helpToolStripMenuItem
			// 
			helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { documentationToolStripMenuItem, versionInfoToolStripMenuItem });
			helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			helpToolStripMenuItem.Size = new Size(44, 20);
			helpToolStripMenuItem.Text = "Help";
			// 
			// documentationToolStripMenuItem
			// 
			documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
			documentationToolStripMenuItem.Size = new Size(157, 22);
			documentationToolStripMenuItem.Text = "Documentation";
			// 
			// versionInfoToolStripMenuItem
			// 
			versionInfoToolStripMenuItem.Name = "versionInfoToolStripMenuItem";
			versionInfoToolStripMenuItem.Size = new Size(157, 22);
			versionInfoToolStripMenuItem.Text = "Version Info";
			// 
			// listBox_Devices
			// 
			listBox_Devices.FormattingEnabled = true;
			listBox_Devices.ItemHeight = 15;
			listBox_Devices.Location = new Point(12, 42);
			listBox_Devices.Name = "listBox_Devices";
			listBox_Devices.Size = new Size(142, 109);
			listBox_Devices.TabIndex = 1;
			// 
			// label_Devices
			// 
			label_Devices.AutoSize = true;
			label_Devices.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point,  0);
			label_Devices.ForeColor = SystemColors.HotTrack;
			label_Devices.Location = new Point(12, 24);
			label_Devices.Name = "label_Devices";
			label_Devices.Size = new Size(142, 15);
			label_Devices.TabIndex = 2;
			label_Devices.Text = "Initialize selected device...";
			label_Devices.Click += label_Devices_Click;
			// 
			// textBox_Output
			// 
			textBox_Output.Location = new Point(12, 338);
			textBox_Output.Name = "textBox_Output";
			textBox_Output.Size = new Size(292, 23);
			textBox_Output.TabIndex = 3;
			textBox_Output.TextChanged += textBox_Output_TextChanged;
			// 
			// progressBar
			// 
			progressBar.Location = new Point(12, 402);
			progressBar.Name = "progressBar";
			progressBar.Size = new Size(676, 23);
			progressBar.Step = 1;
			progressBar.TabIndex = 4;
			// 
			// label_Output
			// 
			label_Output.AutoSize = true;
			label_Output.Location = new Point(12, 320);
			label_Output.Name = "label_Output";
			label_Output.Size = new Size(98, 15);
			label_Output.TabIndex = 5;
			label_Output.Text = "Output directory:";
			// 
			// label_Input
			// 
			label_Input.AutoSize = true;
			label_Input.Location = new Point(12, 276);
			label_Input.Name = "label_Input";
			label_Input.Size = new Size(88, 15);
			label_Input.TabIndex = 7;
			label_Input.Text = "Input directory:";
			// 
			// textBox_Input
			// 
			textBox_Input.Location = new Point(12, 294);
			textBox_Input.Name = "textBox_Input";
			textBox_Input.Size = new Size(292, 23);
			textBox_Input.TabIndex = 6;
			textBox_Input.TextChanged += textBox_Input_TextChanged;
			// 
			// button_InputBrowse
			// 
			button_InputBrowse.Font = new Font("Segoe UI", 8F);
			button_InputBrowse.Location = new Point(310, 294);
			button_InputBrowse.Name = "button_InputBrowse";
			button_InputBrowse.Size = new Size(29, 23);
			button_InputBrowse.TabIndex = 8;
			button_InputBrowse.Text = "...";
			button_InputBrowse.UseVisualStyleBackColor = true;
			button_InputBrowse.Click += button_InputBrowse_Click;
			// 
			// button_OutputBrowse
			// 
			button_OutputBrowse.Font = new Font("Segoe UI", 8F);
			button_OutputBrowse.Location = new Point(310, 338);
			button_OutputBrowse.Name = "button_OutputBrowse";
			button_OutputBrowse.Size = new Size(29, 23);
			button_OutputBrowse.TabIndex = 9;
			button_OutputBrowse.Text = "...";
			button_OutputBrowse.UseVisualStyleBackColor = true;
			button_OutputBrowse.Click += button_OutputBrowse_Click;
			// 
			// label_FilesList
			// 
			label_FilesList.AutoSize = true;
			label_FilesList.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point,  0);
			label_FilesList.ForeColor = SystemColors.HotTrack;
			label_FilesList.Location = new Point(162, 24);
			label_FilesList.Name = "label_FilesList";
			label_FilesList.Size = new Size(97, 15);
			label_FilesList.TabIndex = 10;
			label_FilesList.Text = "Load input files...";
			label_FilesList.Click += label_FilesList_Click;
			// 
			// listBox_FilesList
			// 
			listBox_FilesList.FormattingEnabled = true;
			listBox_FilesList.ItemHeight = 15;
			listBox_FilesList.Location = new Point(162, 42);
			listBox_FilesList.Name = "listBox_FilesList";
			listBox_FilesList.ScrollAlwaysVisible = true;
			listBox_FilesList.Size = new Size(142, 109);
			listBox_FilesList.TabIndex = 11;
			// 
			// button_Open
			// 
			button_Open.Location = new Point(345, 338);
			button_Open.Name = "button_Open";
			button_Open.Size = new Size(64, 23);
			button_Open.TabIndex = 12;
			button_Open.Text = "Open";
			button_Open.UseVisualStyleBackColor = true;
			button_Open.Click += button_Open_Click;
			// 
			// Window_Main
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(700, 437);
			Controls.Add(button_Open);
			Controls.Add(listBox_FilesList);
			Controls.Add(label_FilesList);
			Controls.Add(button_OutputBrowse);
			Controls.Add(button_InputBrowse);
			Controls.Add(label_Input);
			Controls.Add(textBox_Input);
			Controls.Add(label_Output);
			Controls.Add(progressBar);
			Controls.Add(textBox_Output);
			Controls.Add(label_Devices);
			Controls.Add(listBox_Devices);
			Controls.Add(menuStrip);
			FormBorderStyle = FormBorderStyle.Fixed3D;
			MainMenuStrip = menuStrip;
			MaximizeBox = false;
			MaximumSize = new Size(720, 480);
			MinimumSize = new Size(720, 480);
			Name = "Window_Main";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "CUDA Audiostretch GUI";
			menuStrip.ResumeLayout(false);
			menuStrip.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}


		#endregion

		private MenuStrip menuStrip;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem exitToolStripMenuItem;
		private ToolStripMenuItem editToolStripMenuItem;
		private ToolStripMenuItem deviceToolStripMenuItem;
		private ToolStripMenuItem cUDAToolStripMenuItem;
		private ToolStripMenuItem initializeToolStripMenuItem;
		private ToolStripMenuItem removeToolStripMenuItem;
		private ToolStripMenuItem audioToolStripMenuItem;
		private ToolStripMenuItem configToolStripMenuItem;
		private ToolStripMenuItem helpToolStripMenuItem;
		private ToolStripMenuItem strongestToolStripMenuItem;
		private ToolStripMenuItem firstToolStripMenuItem;
		private ToolStripMenuItem nextToolStripMenuItem;
		private ToolStripMenuItem listToolStripMenuItem;
		private ToolStripMenuItem importToolStripMenuItem;
		private ToolStripMenuItem exportToolStripMenuItem;
		private ToolStripMenuItem documentationToolStripMenuItem;
		private ToolStripMenuItem versionInfoToolStripMenuItem;
		private ToolStripMenuItem defaultToolStripMenuItem;
		private ListBox listBox_Devices;
		private Label label_Devices;
		private TextBox textBox_Output;
		private ProgressBar progressBar;
		private Label label_Output;
		private Label label_Input;
		private TextBox textBox_Input;
		private Button button_InputBrowse;
		private Button button_OutputBrowse;
		private Label label_FilesList;
		private ListBox listBox_FilesList;
		private Button button_Open;
		private NAudio.Gui.WaveViewer waveViewer;
	}
}
