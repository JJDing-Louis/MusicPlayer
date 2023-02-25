
namespace MusicPlayer
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ucEllipseControl1 = new ControlLibrary.CustomContainer.ucEllipseControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Help = new System.Windows.Forms.Button();
            this.panel_Tool = new System.Windows.Forms.Panel();
            this.btn_Tool = new System.Windows.Forms.Button();
            this.panel_Equalizer = new System.Windows.Forms.Panel();
            this.btn_Equalizer = new System.Windows.Forms.Button();
            this.panel_PlayListManagement = new System.Windows.Forms.Panel();
            this.btn_PlayListManagement = new System.Windows.Forms.Button();
            this.panel_Media = new System.Windows.Forms.Panel();
            this.btn_DownloadFolder = new System.Windows.Forms.Button();
            this.btn_MusicLibary = new System.Windows.Forms.Button();
            this.btn_Media = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.ucButton1 = new ControlLibrary.ucButton();
            this.ucButton2 = new ControlLibrary.ucButton();
            this.ucButton3 = new ControlLibrary.ucButton();
            this.ucButton4 = new ControlLibrary.ucButton();
            this.ucButton5 = new ControlLibrary.ucButton();
            this.ucButton6 = new ControlLibrary.ucButton();
            this.ucButton7 = new ControlLibrary.ucButton();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Minimize = new ControlLibrary.ucButton();
            this.btn_FullScreen = new ControlLibrary.ucButton();
            this.btn_Exit = new ControlLibrary.ucButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_Media.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucEllipseControl1
            // 
            this.ucEllipseControl1.CornerRadius = 25;
            this.ucEllipseControl1.TargetControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 690);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.15436F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.84563F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 48);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(894, 639);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(207, 639);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btn_Help);
            this.panel1.Controls.Add(this.panel_Tool);
            this.panel1.Controls.Add(this.btn_Tool);
            this.panel1.Controls.Add(this.panel_Equalizer);
            this.panel1.Controls.Add(this.btn_Equalizer);
            this.panel1.Controls.Add(this.panel_PlayListManagement);
            this.panel1.Controls.Add(this.btn_PlayListManagement);
            this.panel1.Controls.Add(this.panel_Media);
            this.panel1.Controls.Add(this.btn_Media);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 191);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 448);
            this.panel1.TabIndex = 1;
            // 
            // btn_Help
            // 
            this.btn_Help.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Help.Location = new System.Drawing.Point(0, 532);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(186, 33);
            this.btn_Help.TabIndex = 9;
            this.btn_Help.Text = "Help";
            this.btn_Help.UseVisualStyleBackColor = true;
            // 
            // panel_Tool
            // 
            this.panel_Tool.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Tool.Location = new System.Drawing.Point(0, 432);
            this.panel_Tool.Name = "panel_Tool";
            this.panel_Tool.Size = new System.Drawing.Size(186, 100);
            this.panel_Tool.TabIndex = 8;
            // 
            // btn_Tool
            // 
            this.btn_Tool.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Tool.Location = new System.Drawing.Point(0, 399);
            this.btn_Tool.Name = "btn_Tool";
            this.btn_Tool.Size = new System.Drawing.Size(186, 33);
            this.btn_Tool.TabIndex = 7;
            this.btn_Tool.Text = "Tool";
            this.btn_Tool.UseVisualStyleBackColor = true;
            // 
            // panel_Equalizer
            // 
            this.panel_Equalizer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Equalizer.Location = new System.Drawing.Point(0, 299);
            this.panel_Equalizer.Name = "panel_Equalizer";
            this.panel_Equalizer.Size = new System.Drawing.Size(186, 100);
            this.panel_Equalizer.TabIndex = 6;
            // 
            // btn_Equalizer
            // 
            this.btn_Equalizer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Equalizer.Location = new System.Drawing.Point(0, 266);
            this.btn_Equalizer.Name = "btn_Equalizer";
            this.btn_Equalizer.Size = new System.Drawing.Size(186, 33);
            this.btn_Equalizer.TabIndex = 5;
            this.btn_Equalizer.Text = "Equalizer";
            this.btn_Equalizer.UseVisualStyleBackColor = true;
            // 
            // panel_PlayListManagement
            // 
            this.panel_PlayListManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_PlayListManagement.Location = new System.Drawing.Point(0, 166);
            this.panel_PlayListManagement.Name = "panel_PlayListManagement";
            this.panel_PlayListManagement.Size = new System.Drawing.Size(186, 100);
            this.panel_PlayListManagement.TabIndex = 4;
            // 
            // btn_PlayListManagement
            // 
            this.btn_PlayListManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_PlayListManagement.Location = new System.Drawing.Point(0, 133);
            this.btn_PlayListManagement.Name = "btn_PlayListManagement";
            this.btn_PlayListManagement.Size = new System.Drawing.Size(186, 33);
            this.btn_PlayListManagement.TabIndex = 3;
            this.btn_PlayListManagement.Text = "PlayList Management";
            this.btn_PlayListManagement.UseVisualStyleBackColor = true;
            // 
            // panel_Media
            // 
            this.panel_Media.Controls.Add(this.btn_DownloadFolder);
            this.panel_Media.Controls.Add(this.btn_MusicLibary);
            this.panel_Media.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Media.Location = new System.Drawing.Point(0, 33);
            this.panel_Media.Name = "panel_Media";
            this.panel_Media.Size = new System.Drawing.Size(186, 100);
            this.panel_Media.TabIndex = 2;
            // 
            // btn_DownloadFolder
            // 
            this.btn_DownloadFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_DownloadFolder.Location = new System.Drawing.Point(0, 33);
            this.btn_DownloadFolder.Name = "btn_DownloadFolder";
            this.btn_DownloadFolder.Size = new System.Drawing.Size(186, 33);
            this.btn_DownloadFolder.TabIndex = 3;
            this.btn_DownloadFolder.Text = "Download Folder";
            this.btn_DownloadFolder.UseVisualStyleBackColor = true;
            // 
            // btn_MusicLibary
            // 
            this.btn_MusicLibary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_MusicLibary.Location = new System.Drawing.Point(0, 0);
            this.btn_MusicLibary.Name = "btn_MusicLibary";
            this.btn_MusicLibary.Size = new System.Drawing.Size(186, 33);
            this.btn_MusicLibary.TabIndex = 2;
            this.btn_MusicLibary.Text = "Music Libary";
            this.btn_MusicLibary.UseVisualStyleBackColor = true;
            // 
            // btn_Media
            // 
            this.btn_Media.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Media.Location = new System.Drawing.Point(0, 0);
            this.btn_Media.Name = "btn_Media";
            this.btn_Media.Size = new System.Drawing.Size(186, 33);
            this.btn_Media.TabIndex = 1;
            this.btn_Media.Text = "Media";
            this.btn_Media.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(10, 10);
            this.panel6.Margin = new System.Windows.Forms.Padding(10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(187, 171);
            this.panel6.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MusicPlayer.Properties.Resources.Music;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.axWindowsMediaPlayer1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(210, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.25118F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.846762F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.74408F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(681, 633);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 8;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.42886F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.42886F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.42886F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.42886F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.42886F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.998F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.42886F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.42886F));
            this.tableLayoutPanel5.Controls.Add(this.ucButton1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.ucButton2, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.ucButton3, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.ucButton4, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.ucButton5, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.ucButton6, 6, 0);
            this.tableLayoutPanel5.Controls.Add(this.ucButton7, 7, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 548);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(675, 82);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // ucButton1
            // 
            this.ucButton1.BackColor = System.Drawing.Color.White;
            this.ucButton1.BackgroundColor = System.Drawing.Color.White;
            this.ucButton1.BackgroundImage = global::MusicPlayer.Properties.Resources.music_player__2_;
            this.ucButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ucButton1.BorderRadius = 35;
            this.ucButton1.BorderSize = 0;
            this.ucButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucButton1.FlatAppearance.BorderSize = 0;
            this.ucButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucButton1.ForeColor = System.Drawing.Color.White;
            this.ucButton1.Location = new System.Drawing.Point(3, 3);
            this.ucButton1.Name = "ucButton1";
            this.ucButton1.Size = new System.Drawing.Size(71, 76);
            this.ucButton1.TabIndex = 0;
            this.ucButton1.TextColor = System.Drawing.Color.White;
            this.ucButton1.UseVisualStyleBackColor = false;
            this.ucButton1.Click += new System.EventHandler(this.ucButton1_Click);
            // 
            // ucButton2
            // 
            this.ucButton2.BackColor = System.Drawing.Color.White;
            this.ucButton2.BackgroundColor = System.Drawing.Color.White;
            this.ucButton2.BackgroundImage = global::MusicPlayer.Properties.Resources.music_player__3_;
            this.ucButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ucButton2.BorderRadius = 35;
            this.ucButton2.BorderSize = 0;
            this.ucButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucButton2.FlatAppearance.BorderSize = 0;
            this.ucButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucButton2.ForeColor = System.Drawing.Color.White;
            this.ucButton2.Location = new System.Drawing.Point(80, 3);
            this.ucButton2.Name = "ucButton2";
            this.ucButton2.Size = new System.Drawing.Size(71, 76);
            this.ucButton2.TabIndex = 1;
            this.ucButton2.TextColor = System.Drawing.Color.White;
            this.ucButton2.UseVisualStyleBackColor = false;
            // 
            // ucButton3
            // 
            this.ucButton3.BackColor = System.Drawing.Color.White;
            this.ucButton3.BackgroundColor = System.Drawing.Color.White;
            this.ucButton3.BackgroundImage = global::MusicPlayer.Properties.Resources.previous__2_;
            this.ucButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ucButton3.BorderRadius = 35;
            this.ucButton3.BorderSize = 0;
            this.ucButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucButton3.FlatAppearance.BorderSize = 0;
            this.ucButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucButton3.ForeColor = System.Drawing.Color.White;
            this.ucButton3.Location = new System.Drawing.Point(157, 3);
            this.ucButton3.Name = "ucButton3";
            this.ucButton3.Size = new System.Drawing.Size(71, 76);
            this.ucButton3.TabIndex = 2;
            this.ucButton3.TextColor = System.Drawing.Color.White;
            this.ucButton3.UseVisualStyleBackColor = false;
            // 
            // ucButton4
            // 
            this.ucButton4.BackColor = System.Drawing.Color.White;
            this.ucButton4.BackgroundColor = System.Drawing.Color.White;
            this.ucButton4.BackgroundImage = global::MusicPlayer.Properties.Resources.skip;
            this.ucButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ucButton4.BorderRadius = 35;
            this.ucButton4.BorderSize = 0;
            this.ucButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucButton4.FlatAppearance.BorderSize = 0;
            this.ucButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucButton4.ForeColor = System.Drawing.Color.White;
            this.ucButton4.Location = new System.Drawing.Point(234, 3);
            this.ucButton4.Name = "ucButton4";
            this.ucButton4.Size = new System.Drawing.Size(71, 76);
            this.ucButton4.TabIndex = 3;
            this.ucButton4.TextColor = System.Drawing.Color.White;
            this.ucButton4.UseVisualStyleBackColor = false;
            // 
            // ucButton5
            // 
            this.ucButton5.BackColor = System.Drawing.Color.White;
            this.ucButton5.BackgroundColor = System.Drawing.Color.White;
            this.ucButton5.BackgroundImage = global::MusicPlayer.Properties.Resources.equalizer__1_;
            this.ucButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucButton5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ucButton5.BorderRadius = 1;
            this.ucButton5.BorderSize = 0;
            this.ucButton5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucButton5.FlatAppearance.BorderSize = 0;
            this.ucButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucButton5.ForeColor = System.Drawing.Color.White;
            this.ucButton5.Location = new System.Drawing.Point(311, 3);
            this.ucButton5.Name = "ucButton5";
            this.ucButton5.Size = new System.Drawing.Size(71, 76);
            this.ucButton5.TabIndex = 4;
            this.ucButton5.TextColor = System.Drawing.Color.White;
            this.ucButton5.UseVisualStyleBackColor = false;
            // 
            // ucButton6
            // 
            this.ucButton6.BackColor = System.Drawing.Color.White;
            this.ucButton6.BackgroundColor = System.Drawing.Color.White;
            this.ucButton6.BackgroundImage = global::MusicPlayer.Properties.Resources.cogwheel;
            this.ucButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucButton6.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ucButton6.BorderRadius = 35;
            this.ucButton6.BorderSize = 0;
            this.ucButton6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucButton6.FlatAppearance.BorderSize = 0;
            this.ucButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucButton6.ForeColor = System.Drawing.Color.White;
            this.ucButton6.Location = new System.Drawing.Point(522, 3);
            this.ucButton6.Name = "ucButton6";
            this.ucButton6.Size = new System.Drawing.Size(71, 76);
            this.ucButton6.TabIndex = 5;
            this.ucButton6.TextColor = System.Drawing.Color.White;
            this.ucButton6.UseVisualStyleBackColor = false;
            // 
            // ucButton7
            // 
            this.ucButton7.BackColor = System.Drawing.Color.White;
            this.ucButton7.BackgroundColor = System.Drawing.Color.White;
            this.ucButton7.BackgroundImage = global::MusicPlayer.Properties.Resources.playlist;
            this.ucButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucButton7.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ucButton7.BorderRadius = 1;
            this.ucButton7.BorderSize = 0;
            this.ucButton7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucButton7.FlatAppearance.BorderSize = 0;
            this.ucButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucButton7.ForeColor = System.Drawing.Color.White;
            this.ucButton7.Location = new System.Drawing.Point(599, 3);
            this.ucButton7.Name = "ucButton7";
            this.ucButton7.Size = new System.Drawing.Size(73, 76);
            this.ucButton7.TabIndex = 6;
            this.ucButton7.TextColor = System.Drawing.Color.White;
            this.ucButton7.UseVisualStyleBackColor = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(3, 3);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(675, 483);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Minimize);
            this.panel2.Controls.Add(this.btn_FullScreen);
            this.panel2.Controls.Add(this.btn_Exit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(887, 39);
            this.panel2.TabIndex = 1;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.BackColor = System.Drawing.Color.White;
            this.btn_Minimize.BackgroundColor = System.Drawing.Color.White;
            this.btn_Minimize.BackgroundImage = global::MusicPlayer.Properties.Resources.minimize;
            this.btn_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Minimize.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Minimize.BorderRadius = 10;
            this.btn_Minimize.BorderSize = 0;
            this.btn_Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.ForeColor = System.Drawing.Color.White;
            this.btn_Minimize.Location = new System.Drawing.Point(770, 0);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(39, 39);
            this.btn_Minimize.TabIndex = 2;
            this.btn_Minimize.TextColor = System.Drawing.Color.White;
            this.btn_Minimize.UseVisualStyleBackColor = false;
            // 
            // btn_FullScreen
            // 
            this.btn_FullScreen.BackColor = System.Drawing.Color.White;
            this.btn_FullScreen.BackgroundColor = System.Drawing.Color.White;
            this.btn_FullScreen.BackgroundImage = global::MusicPlayer.Properties.Resources.arrows;
            this.btn_FullScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_FullScreen.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_FullScreen.BorderRadius = 10;
            this.btn_FullScreen.BorderSize = 0;
            this.btn_FullScreen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_FullScreen.FlatAppearance.BorderSize = 0;
            this.btn_FullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FullScreen.ForeColor = System.Drawing.Color.White;
            this.btn_FullScreen.Location = new System.Drawing.Point(809, 0);
            this.btn_FullScreen.Name = "btn_FullScreen";
            this.btn_FullScreen.Size = new System.Drawing.Size(39, 39);
            this.btn_FullScreen.TabIndex = 1;
            this.btn_FullScreen.TextColor = System.Drawing.Color.White;
            this.btn_FullScreen.UseVisualStyleBackColor = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.White;
            this.btn_Exit.BackgroundColor = System.Drawing.Color.White;
            this.btn_Exit.BackgroundImage = global::MusicPlayer.Properties.Resources.exit;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Exit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Exit.BorderRadius = 10;
            this.btn_Exit.BorderSize = 0;
            this.btn_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(848, 0);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(39, 39);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.TextColor = System.Drawing.Color.White;
            this.btn_Exit.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(900, 685);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Main";
            this.Text = "Main";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel_Media.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlLibrary.CustomContainer.ucEllipseControl ucEllipseControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Tool;
        private System.Windows.Forms.Button btn_Tool;
        private System.Windows.Forms.Panel panel_Equalizer;
        private System.Windows.Forms.Button btn_Equalizer;
        private System.Windows.Forms.Panel panel_PlayListManagement;
        private System.Windows.Forms.Button btn_PlayListManagement;
        private System.Windows.Forms.Panel panel_Media;
        private System.Windows.Forms.Button btn_Media;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Button btn_DownloadFolder;
        private System.Windows.Forms.Button btn_MusicLibary;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private ControlLibrary.ucButton ucButton1;
        private ControlLibrary.ucButton ucButton2;
        private ControlLibrary.ucButton ucButton3;
        private ControlLibrary.ucButton ucButton4;
        private ControlLibrary.ucButton ucButton5;
        private ControlLibrary.ucButton ucButton6;
        private ControlLibrary.ucButton ucButton7;
        private ControlLibrary.ucButton btn_Minimize;
        private ControlLibrary.ucButton btn_FullScreen;
        private ControlLibrary.ucButton btn_Exit;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}