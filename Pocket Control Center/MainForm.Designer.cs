namespace Pocket_Control_Center
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu;

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
            this.mainMenu = new System.Windows.Forms.MainMenu();
            this.menuItemFile = new System.Windows.Forms.MenuItem();
            this.menuItemOpen = new System.Windows.Forms.MenuItem();
            this.menuItemSave = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItemSelectPort = new System.Windows.Forms.MenuItem();
            this.menuItemConnect = new System.Windows.Forms.MenuItem();
            this.menuItemDisconnect = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItemTransmit = new System.Windows.Forms.MenuItem();
            this.menuItemReceive = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItemExit = new System.Windows.Forms.MenuItem();
            this.menuItemMaps = new System.Windows.Forms.MenuItem();
            this.menuItemNormalMap = new System.Windows.Forms.MenuItem();
            this.menuItemFAPMap = new System.Windows.Forms.MenuItem();
            this.menuItemOptions = new System.Windows.Forms.MenuItem();
            this.menuItemEnMonitor = new System.Windows.Forms.MenuItem();
            this.menuItemEnTrimmer = new System.Windows.Forms.MenuItem();
            this.menuItemEnTuningBox = new System.Windows.Forms.MenuItem();
            this.menuItemResetTuningBox = new System.Windows.Forms.MenuItem();
            this.menuItemInfo = new System.Windows.Forms.MenuItem();
            this.menuItemAbout = new System.Windows.Forms.MenuItem();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelRailOut = new System.Windows.Forms.Label();
            this.labelRailIn = new System.Windows.Forms.Label();
            this.pBarRailOut = new System.Windows.Forms.ProgressBar();
            this.pBarRailIn = new System.Windows.Forms.ProgressBar();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tBoxRamp = new System.Windows.Forms.TextBox();
            this.tBoxSlopePower = new System.Windows.Forms.TextBox();
            this.tBoxSlopeThreshold = new System.Windows.Forms.TextBox();
            this.tBoxPower = new System.Windows.Forms.TextBox();
            this.labelRamp = new System.Windows.Forms.Label();
            this.labelSlopePower = new System.Windows.Forms.Label();
            this.labelSlopeThreshold = new System.Windows.Forms.Label();
            this.labelPower = new System.Windows.Forms.Label();
            this.tBarRamp = new System.Windows.Forms.TrackBar();
            this.tBarSlopePower = new System.Windows.Forms.TrackBar();
            this.tBarSlopeThreshold = new System.Windows.Forms.TrackBar();
            this.tBarPower = new System.Windows.Forms.TrackBar();
            this.tBoxThreshold = new System.Windows.Forms.TextBox();
            this.labelThreshold = new System.Windows.Forms.Label();
            this.tBarThreshold = new System.Windows.Forms.TrackBar();
            this.timerMonitor = new System.Windows.Forms.Timer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.Add(this.menuItemFile);
            this.mainMenu.MenuItems.Add(this.menuItemMaps);
            this.mainMenu.MenuItems.Add(this.menuItemOptions);
            this.mainMenu.MenuItems.Add(this.menuItemInfo);
            // 
            // menuItemFile
            // 
            this.menuItemFile.MenuItems.Add(this.menuItemOpen);
            this.menuItemFile.MenuItems.Add(this.menuItemSave);
            this.menuItemFile.MenuItems.Add(this.menuItem4);
            this.menuItemFile.MenuItems.Add(this.menuItemSelectPort);
            this.menuItemFile.MenuItems.Add(this.menuItemConnect);
            this.menuItemFile.MenuItems.Add(this.menuItemDisconnect);
            this.menuItemFile.MenuItems.Add(this.menuItem7);
            this.menuItemFile.MenuItems.Add(this.menuItemTransmit);
            this.menuItemFile.MenuItems.Add(this.menuItemReceive);
            this.menuItemFile.MenuItems.Add(this.menuItem10);
            this.menuItemFile.MenuItems.Add(this.menuItemExit);
            this.menuItemFile.Text = "File";
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Text = "Open";
            this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
            // 
            // menuItemSave
            // 
            this.menuItemSave.Text = "Save";
            this.menuItemSave.Click += new System.EventHandler(this.menuItemSave_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Text = "-";
            // 
            // menuItemSelectPort
            // 
            this.menuItemSelectPort.Text = "Select Port";
            // 
            // menuItemConnect
            // 
            this.menuItemConnect.Text = "Connect";
            this.menuItemConnect.Click += new System.EventHandler(this.menuItemConnect_Click);
            // 
            // menuItemDisconnect
            // 
            this.menuItemDisconnect.Text = "Disconnect";
            this.menuItemDisconnect.Click += new System.EventHandler(this.menuItemDisconnect_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Text = "-";
            // 
            // menuItemTransmit
            // 
            this.menuItemTransmit.Text = "Transmit";
            this.menuItemTransmit.Click += new System.EventHandler(this.menuItemTransmit_Click);
            // 
            // menuItemReceive
            // 
            this.menuItemReceive.Text = "Receive";
            this.menuItemReceive.Click += new System.EventHandler(this.menuItemReceive_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Text = "-";
            // 
            // menuItemExit
            // 
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // menuItemMaps
            // 
            this.menuItemMaps.MenuItems.Add(this.menuItemNormalMap);
            this.menuItemMaps.MenuItems.Add(this.menuItemFAPMap);
            this.menuItemMaps.Text = "Maps";
            // 
            // menuItemNormalMap
            // 
            this.menuItemNormalMap.Text = "Normal (Map 1)";
            this.menuItemNormalMap.Click += new System.EventHandler(this.menuItemNormalMap_Click);
            // 
            // menuItemFAPMap
            // 
            this.menuItemFAPMap.Text = "FAP (Map 2)";
            this.menuItemFAPMap.Click += new System.EventHandler(this.menuItemFAPMap_Click);
            // 
            // menuItemOptions
            // 
            this.menuItemOptions.MenuItems.Add(this.menuItemEnMonitor);
            this.menuItemOptions.MenuItems.Add(this.menuItemEnTrimmer);
            this.menuItemOptions.MenuItems.Add(this.menuItemEnTuningBox);
            this.menuItemOptions.MenuItems.Add(this.menuItemResetTuningBox);
            this.menuItemOptions.Text = "Options";
            // 
            // menuItemEnMonitor
            // 
            this.menuItemEnMonitor.Text = "Enable Monitor";
            this.menuItemEnMonitor.Click += new System.EventHandler(this.menuItemEnMonitor_Click);
            // 
            // menuItemEnTrimmer
            // 
            this.menuItemEnTrimmer.Text = "Enable Trimmer";
            this.menuItemEnTrimmer.Click += new System.EventHandler(this.menuItemEnTrimmer_Click);
            // 
            // menuItemEnTuningBox
            // 
            this.menuItemEnTuningBox.Text = "Enable Tuning Box";
            this.menuItemEnTuningBox.Click += new System.EventHandler(this.menuItemEnTuningBox_Click);
            // 
            // menuItemResetTuningBox
            // 
            this.menuItemResetTuningBox.Text = "Reset Tuning Box";
            this.menuItemResetTuningBox.Click += new System.EventHandler(this.menuItemResetTuningBox_Click);
            // 
            // menuItemInfo
            // 
            this.menuItemInfo.MenuItems.Add(this.menuItemAbout);
            this.menuItemInfo.Text = "Info";
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Text = "About...";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 246);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(240, 22);
            this.statusBar.Text = "Not Connected. Ready...";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelRailOut);
            this.panel1.Controls.Add(this.labelRailIn);
            this.panel1.Controls.Add(this.pBarRailOut);
            this.panel1.Controls.Add(this.pBarRailIn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 86);
            // 
            // labelRailOut
            // 
            this.labelRailOut.Location = new System.Drawing.Point(71, 66);
            this.labelRailOut.Name = "labelRailOut";
            this.labelRailOut.Size = new System.Drawing.Size(100, 17);
            this.labelRailOut.Text = "Rail Out: 0V";
            this.labelRailOut.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelRailIn
            // 
            this.labelRailIn.Location = new System.Drawing.Point(71, 26);
            this.labelRailIn.Name = "labelRailIn";
            this.labelRailIn.Size = new System.Drawing.Size(100, 14);
            this.labelRailIn.Text = "Rail In: 0V";
            this.labelRailIn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pBarRailOut
            // 
            this.pBarRailOut.Location = new System.Drawing.Point(38, 43);
            this.pBarRailOut.Maximum = 4095;
            this.pBarRailOut.Name = "pBarRailOut";
            this.pBarRailOut.Size = new System.Drawing.Size(164, 20);
            // 
            // pBarRailIn
            // 
            this.pBarRailIn.Location = new System.Drawing.Point(38, 3);
            this.pBarRailIn.Maximum = 4095;
            this.pBarRailIn.Name = "pBarRailIn";
            this.pBarRailIn.Size = new System.Drawing.Size(164, 20);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 86);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(240, 11);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tBoxRamp);
            this.panel2.Controls.Add(this.tBoxSlopePower);
            this.panel2.Controls.Add(this.tBoxSlopeThreshold);
            this.panel2.Controls.Add(this.tBoxPower);
            this.panel2.Controls.Add(this.labelRamp);
            this.panel2.Controls.Add(this.labelSlopePower);
            this.panel2.Controls.Add(this.labelSlopeThreshold);
            this.panel2.Controls.Add(this.labelPower);
            this.panel2.Controls.Add(this.tBarRamp);
            this.panel2.Controls.Add(this.tBarSlopePower);
            this.panel2.Controls.Add(this.tBarSlopeThreshold);
            this.panel2.Controls.Add(this.tBarPower);
            this.panel2.Controls.Add(this.tBoxThreshold);
            this.panel2.Controls.Add(this.labelThreshold);
            this.panel2.Controls.Add(this.tBarThreshold);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 149);
            // 
            // tBoxRamp
            // 
            this.tBoxRamp.Location = new System.Drawing.Point(196, 118);
            this.tBoxRamp.Name = "tBoxRamp";
            this.tBoxRamp.ReadOnly = true;
            this.tBoxRamp.Size = new System.Drawing.Size(40, 21);
            this.tBoxRamp.TabIndex = 18;
            this.tBoxRamp.Text = "0V";
            // 
            // tBoxSlopePower
            // 
            this.tBoxSlopePower.Location = new System.Drawing.Point(148, 118);
            this.tBoxSlopePower.Name = "tBoxSlopePower";
            this.tBoxSlopePower.ReadOnly = true;
            this.tBoxSlopePower.Size = new System.Drawing.Size(40, 21);
            this.tBoxSlopePower.TabIndex = 17;
            this.tBoxSlopePower.Text = "0%";
            // 
            // tBoxSlopeThreshold
            // 
            this.tBoxSlopeThreshold.Location = new System.Drawing.Point(100, 118);
            this.tBoxSlopeThreshold.Name = "tBoxSlopeThreshold";
            this.tBoxSlopeThreshold.ReadOnly = true;
            this.tBoxSlopeThreshold.Size = new System.Drawing.Size(40, 21);
            this.tBoxSlopeThreshold.TabIndex = 16;
            this.tBoxSlopeThreshold.Text = "0V";
            // 
            // tBoxPower
            // 
            this.tBoxPower.Location = new System.Drawing.Point(52, 118);
            this.tBoxPower.Name = "tBoxPower";
            this.tBoxPower.ReadOnly = true;
            this.tBoxPower.Size = new System.Drawing.Size(40, 21);
            this.tBoxPower.TabIndex = 15;
            this.tBoxPower.Text = "0%";
            // 
            // labelRamp
            // 
            this.labelRamp.Location = new System.Drawing.Point(196, 9);
            this.labelRamp.Name = "labelRamp";
            this.labelRamp.Size = new System.Drawing.Size(40, 20);
            this.labelRamp.Text = "RAMP";
            this.labelRamp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSlopePower
            // 
            this.labelSlopePower.Location = new System.Drawing.Point(148, 9);
            this.labelSlopePower.Name = "labelSlopePower";
            this.labelSlopePower.Size = new System.Drawing.Size(40, 20);
            this.labelSlopePower.Text = "SPWR";
            this.labelSlopePower.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSlopeThreshold
            // 
            this.labelSlopeThreshold.Location = new System.Drawing.Point(100, 9);
            this.labelSlopeThreshold.Name = "labelSlopeThreshold";
            this.labelSlopeThreshold.Size = new System.Drawing.Size(40, 20);
            this.labelSlopeThreshold.Text = "STH";
            this.labelSlopeThreshold.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPower
            // 
            this.labelPower.Location = new System.Drawing.Point(52, 9);
            this.labelPower.Name = "labelPower";
            this.labelPower.Size = new System.Drawing.Size(40, 20);
            this.labelPower.Text = "PWR";
            this.labelPower.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tBarRamp
            // 
            this.tBarRamp.Location = new System.Drawing.Point(195, 32);
            this.tBarRamp.Maximum = 2048;
            this.tBarRamp.Name = "tBarRamp";
            this.tBarRamp.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tBarRamp.Size = new System.Drawing.Size(42, 80);
            this.tBarRamp.TabIndex = 6;
            this.tBarRamp.TickFrequency = 204;
            this.tBarRamp.ValueChanged += new System.EventHandler(this.tBarRamp_ValueChanged);
            // 
            // tBarSlopePower
            // 
            this.tBarSlopePower.Location = new System.Drawing.Point(147, 32);
            this.tBarSlopePower.Maximum = 1024;
            this.tBarSlopePower.Name = "tBarSlopePower";
            this.tBarSlopePower.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tBarSlopePower.Size = new System.Drawing.Size(42, 80);
            this.tBarSlopePower.TabIndex = 5;
            this.tBarSlopePower.TickFrequency = 102;
            this.tBarSlopePower.ValueChanged += new System.EventHandler(this.tBarSlopePower_ValueChanged);
            // 
            // tBarSlopeThreshold
            // 
            this.tBarSlopeThreshold.Location = new System.Drawing.Point(99, 32);
            this.tBarSlopeThreshold.Maximum = 4095;
            this.tBarSlopeThreshold.Name = "tBarSlopeThreshold";
            this.tBarSlopeThreshold.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tBarSlopeThreshold.Size = new System.Drawing.Size(42, 80);
            this.tBarSlopeThreshold.TabIndex = 4;
            this.tBarSlopeThreshold.TickFrequency = 409;
            this.tBarSlopeThreshold.ValueChanged += new System.EventHandler(this.tBarSlopeThreshold_ValueChanged);
            // 
            // tBarPower
            // 
            this.tBarPower.Location = new System.Drawing.Point(51, 32);
            this.tBarPower.Maximum = 1228;
            this.tBarPower.Name = "tBarPower";
            this.tBarPower.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tBarPower.Size = new System.Drawing.Size(42, 80);
            this.tBarPower.TabIndex = 3;
            this.tBarPower.TickFrequency = 122;
            this.tBarPower.ValueChanged += new System.EventHandler(this.tBarPower_ValueChanged);
            // 
            // tBoxThreshold
            // 
            this.tBoxThreshold.Location = new System.Drawing.Point(4, 118);
            this.tBoxThreshold.Name = "tBoxThreshold";
            this.tBoxThreshold.ReadOnly = true;
            this.tBoxThreshold.Size = new System.Drawing.Size(40, 21);
            this.tBoxThreshold.TabIndex = 2;
            this.tBoxThreshold.Text = "0V";
            // 
            // labelThreshold
            // 
            this.labelThreshold.Location = new System.Drawing.Point(4, 9);
            this.labelThreshold.Name = "labelThreshold";
            this.labelThreshold.Size = new System.Drawing.Size(40, 20);
            this.labelThreshold.Text = "TH";
            this.labelThreshold.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tBarThreshold
            // 
            this.tBarThreshold.Location = new System.Drawing.Point(3, 32);
            this.tBarThreshold.Maximum = 4095;
            this.tBarThreshold.Name = "tBarThreshold";
            this.tBarThreshold.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tBarThreshold.Size = new System.Drawing.Size(42, 80);
            this.tBarThreshold.TabIndex = 0;
            this.tBarThreshold.TickFrequency = 409;
            this.tBarThreshold.ValueChanged += new System.EventHandler(this.tBarThreshold_ValueChanged);
            // 
            // timerMonitor
            // 
            this.timerMonitor.Interval = 1000;
            this.timerMonitor.Tick += new System.EventHandler(this.timerMonitor_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusBar);
            this.Menu = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Pocket Control Center";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItemFile;
        private System.Windows.Forms.MenuItem menuItemOpen;
        private System.Windows.Forms.MenuItem menuItemSave;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItemConnect;
        private System.Windows.Forms.MenuItem menuItemDisconnect;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItemReceive;
        private System.Windows.Forms.MenuItem menuItemTransmit;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem menuItemExit;
        private System.Windows.Forms.MenuItem menuItemSelectPort;
        private System.Windows.Forms.MenuItem menuItemMaps;
        private System.Windows.Forms.MenuItem menuItemNormalMap;
        private System.Windows.Forms.MenuItem menuItemFAPMap;
        private System.Windows.Forms.MenuItem menuItemOptions;
        private System.Windows.Forms.MenuItem menuItemEnMonitor;
        private System.Windows.Forms.MenuItem menuItemEnTrimmer;
        private System.Windows.Forms.MenuItem menuItemEnTuningBox;
        private System.Windows.Forms.MenuItem menuItemResetTuningBox;
        private System.Windows.Forms.MenuItem menuItemInfo;
        private System.Windows.Forms.MenuItem menuItemAbout;
        private System.Windows.Forms.StatusBar statusBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelRailOut;
        private System.Windows.Forms.Label labelRailIn;
        private System.Windows.Forms.ProgressBar pBarRailOut;
        private System.Windows.Forms.ProgressBar pBarRailIn;
        private System.Windows.Forms.TrackBar tBarThreshold;
        private System.Windows.Forms.TrackBar tBarRamp;
        private System.Windows.Forms.TrackBar tBarSlopePower;
        private System.Windows.Forms.TrackBar tBarSlopeThreshold;
        private System.Windows.Forms.TrackBar tBarPower;
        private System.Windows.Forms.TextBox tBoxThreshold;
        private System.Windows.Forms.Label labelThreshold;
        private System.Windows.Forms.TextBox tBoxRamp;
        private System.Windows.Forms.TextBox tBoxSlopePower;
        private System.Windows.Forms.TextBox tBoxSlopeThreshold;
        private System.Windows.Forms.TextBox tBoxPower;
        private System.Windows.Forms.Label labelRamp;
        private System.Windows.Forms.Label labelSlopePower;
        private System.Windows.Forms.Label labelSlopeThreshold;
        private System.Windows.Forms.Label labelPower;
        private System.Windows.Forms.Timer timerMonitor;
    }
}

