using System.Threading;

namespace WindowsFormsApplication2
{
    partial class FormMatrixGrid
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMatrixGrid));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPlay = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPause = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.x2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.playMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrixGridMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem2x2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem3x3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem4x4 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem5x5 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem6x6 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem7x7 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem8x8 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPlay,
            this.toolStripButtonPause,
            this.toolStripButtonStop,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 38);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1176, 42);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonPlay
            // 
            this.toolStripButtonPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPlay.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPlay.Image")));
            this.toolStripButtonPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPlay.Name = "toolStripButtonPlay";
            this.toolStripButtonPlay.Size = new System.Drawing.Size(39, 39);
            this.toolStripButtonPlay.Text = "toolStripButton1";
            this.toolStripButtonPlay.Click += new System.EventHandler(this.toolStripButtonPlay_Click);
            this.toolStripButtonPlay.MouseLeave += new System.EventHandler(this.toolStripButtonPlay_MouseLeave);
            this.toolStripButtonPlay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripButtonPlay_MouseMove);
            // 
            // toolStripButtonPause
            // 
            this.toolStripButtonPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPause.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPause.Image")));
            this.toolStripButtonPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPause.Name = "toolStripButtonPause";
            this.toolStripButtonPause.Size = new System.Drawing.Size(39, 39);
            this.toolStripButtonPause.Text = "toolStripButton2";
            this.toolStripButtonPause.Click += new System.EventHandler(this.toolStripButtonPause_Click);
            this.toolStripButtonPause.MouseLeave += new System.EventHandler(this.toolStripButtonPause_MouseLeave);
            this.toolStripButtonPause.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripButtonPause_MouseMove);
            // 
            // toolStripButtonStop
            // 
            this.toolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStop.Image")));
            this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStop.Name = "toolStripButtonStop";
            this.toolStripButtonStop.Size = new System.Drawing.Size(39, 39);
            this.toolStripButtonStop.Text = "toolStripButton1";
            this.toolStripButtonStop.Click += new System.EventHandler(this.toolStripButtonStop_Click);
            this.toolStripButtonStop.MouseLeave += new System.EventHandler(this.toolStripButtonStop_MouseLeave);
            this.toolStripButtonStop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripButtonStop_MouseMove);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x2ToolStripMenuItem,
            this.x3ToolStripMenuItem,
            this.x4ToolStripMenuItem,
            this.x5ToolStripMenuItem,
            this.x6ToolStripMenuItem,
            this.x7ToolStripMenuItem,
            this.x8ToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(56, 39);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.MouseLeave += new System.EventHandler(this.toolStripDropDownButton1_MouseLeave);
            this.toolStripDropDownButton1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripDropDownButton1_MouseMove);
            // 
            // x2ToolStripMenuItem
            // 
            this.x2ToolStripMenuItem.Name = "x2ToolStripMenuItem";
            this.x2ToolStripMenuItem.Size = new System.Drawing.Size(148, 34);
            this.x2ToolStripMenuItem.Text = "2 x 2";
            this.x2ToolStripMenuItem.Click += new System.EventHandler(this.x2ToolStripMenuItem_Click);
            this.x2ToolStripMenuItem.MouseLeave += new System.EventHandler(this.x2ToolStripMenuItem_MouseLeave);
            this.x2ToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.x2ToolStripMenuItem_MouseMove);
            // 
            // x3ToolStripMenuItem
            // 
            this.x3ToolStripMenuItem.Name = "x3ToolStripMenuItem";
            this.x3ToolStripMenuItem.Size = new System.Drawing.Size(148, 34);
            this.x3ToolStripMenuItem.Text = "3 x 3";
            this.x3ToolStripMenuItem.Click += new System.EventHandler(this.x3ToolStripMenuItem_Click);
            this.x3ToolStripMenuItem.MouseLeave += new System.EventHandler(this.x3ToolStripMenuItem_MouseLeave);
            this.x3ToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.x3ToolStripMenuItem_MouseMove);
            // 
            // x4ToolStripMenuItem
            // 
            this.x4ToolStripMenuItem.Name = "x4ToolStripMenuItem";
            this.x4ToolStripMenuItem.Size = new System.Drawing.Size(148, 34);
            this.x4ToolStripMenuItem.Text = "4 x 4";
            this.x4ToolStripMenuItem.Click += new System.EventHandler(this.x4ToolStripMenuItem_Click);
            this.x4ToolStripMenuItem.MouseLeave += new System.EventHandler(this.x4ToolStripMenuItem_MouseLeave);
            this.x4ToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.x4ToolStripMenuItem_MouseMove);
            // 
            // x5ToolStripMenuItem
            // 
            this.x5ToolStripMenuItem.Name = "x5ToolStripMenuItem";
            this.x5ToolStripMenuItem.Size = new System.Drawing.Size(148, 34);
            this.x5ToolStripMenuItem.Text = "5 x 5";
            this.x5ToolStripMenuItem.Click += new System.EventHandler(this.x5ToolStripMenuItem_Click);
            this.x5ToolStripMenuItem.MouseLeave += new System.EventHandler(this.x5ToolStripMenuItem_MouseLeave);
            this.x5ToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.x5ToolStripMenuItem_MouseMove);
            // 
            // x6ToolStripMenuItem
            // 
            this.x6ToolStripMenuItem.Name = "x6ToolStripMenuItem";
            this.x6ToolStripMenuItem.Size = new System.Drawing.Size(148, 34);
            this.x6ToolStripMenuItem.Text = "6 x 6";
            this.x6ToolStripMenuItem.Click += new System.EventHandler(this.x6ToolStripMenuItem_Click);
            this.x6ToolStripMenuItem.MouseLeave += new System.EventHandler(this.x6ToolStripMenuItem_MouseLeave);
            this.x6ToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.x6ToolStripMenuItem_MouseMove);
            // 
            // x7ToolStripMenuItem
            // 
            this.x7ToolStripMenuItem.Name = "x7ToolStripMenuItem";
            this.x7ToolStripMenuItem.Size = new System.Drawing.Size(148, 34);
            this.x7ToolStripMenuItem.Text = "7 x 7";
            this.x7ToolStripMenuItem.Click += new System.EventHandler(this.x7ToolStripMenuItem_Click);
            this.x7ToolStripMenuItem.MouseLeave += new System.EventHandler(this.x7ToolStripMenuItem_MouseLeave);
            this.x7ToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.x7ToolStripMenuItem_MouseMove);
            // 
            // x8ToolStripMenuItem
            // 
            this.x8ToolStripMenuItem.Name = "x8ToolStripMenuItem";
            this.x8ToolStripMenuItem.Size = new System.Drawing.Size(148, 34);
            this.x8ToolStripMenuItem.Text = "8 x 8";
            this.x8ToolStripMenuItem.Click += new System.EventHandler(this.x8ToolStripMenuItem_Click);
            this.x8ToolStripMenuItem.MouseLeave += new System.EventHandler(this.x8ToolStripMenuItem_MouseLeave);
            this.x8ToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.x8ToolStripMenuItem_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsMenu,
            this.matrixGridMenu,
            this.helpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1176, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionsMenu
            // 
            this.actionsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playMenuItem,
            this.pauseMenuItem,
            this.stopMenuItem,
            this.toolStripMenuItem1,
            this.exitApplicationToolStripMenuItem});
            this.actionsMenu.Name = "actionsMenu";
            this.actionsMenu.Size = new System.Drawing.Size(118, 34);
            this.actionsMenu.Text = "Operation";
            this.actionsMenu.MouseLeave += new System.EventHandler(this.actionsMenu_MouseLeave);
            this.actionsMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.actionsMenu_MouseMove);
            // 
            // playMenuItem
            // 
            this.playMenuItem.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_play_94;
            this.playMenuItem.Name = "playMenuItem";
            this.playMenuItem.Size = new System.Drawing.Size(248, 34);
            this.playMenuItem.Text = "Play";
            this.playMenuItem.Click += new System.EventHandler(this.playMenuItem_Click);
            this.playMenuItem.MouseLeave += new System.EventHandler(this.playMenuItem_MouseLeave);
            this.playMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.playMenuItem_MouseMove);
            // 
            // pauseMenuItem
            // 
            this.pauseMenuItem.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_pause_48;
            this.pauseMenuItem.Name = "pauseMenuItem";
            this.pauseMenuItem.Size = new System.Drawing.Size(248, 34);
            this.pauseMenuItem.Text = "Pause";
            this.pauseMenuItem.Click += new System.EventHandler(this.pauseMenuItem_Click);
            this.pauseMenuItem.MouseLeave += new System.EventHandler(this.pauseMenuItem_MouseLeave);
            this.pauseMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pauseMenuItem_MouseMove);
            // 
            // stopMenuItem
            // 
            this.stopMenuItem.Image = global::WindowsFormsApplication2.Properties.Resources.icons8_stop_48;
            this.stopMenuItem.Name = "stopMenuItem";
            this.stopMenuItem.Size = new System.Drawing.Size(248, 34);
            this.stopMenuItem.Text = "Stop";
            this.stopMenuItem.Click += new System.EventHandler(this.stopMenuItem_Click);
            this.stopMenuItem.MouseLeave += new System.EventHandler(this.stopMenuItem_MouseLeave);
            this.stopMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.stopMenuItem_MouseMove);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(245, 6);
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Image = global::WindowsFormsApplication2.Properties.Resources.blue_shutdown_poweroff__12422;
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
            this.exitApplicationToolStripMenuItem.Text = "Exit Application";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
            this.exitApplicationToolStripMenuItem.MouseLeave += new System.EventHandler(this.exitApplicationToolStripMenuItem_MouseLeave);
            this.exitApplicationToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.exitApplicationToolStripMenuItem_MouseMove);
            // 
            // matrixGridMenu
            // 
            this.matrixGridMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem2x2,
            this.MenuItem3x3,
            this.MenuItem4x4,
            this.MenuItem5x5,
            this.MenuItem6x6,
            this.MenuItem7x7,
            this.MenuItem8x8});
            this.matrixGridMenu.Name = "matrixGridMenu";
            this.matrixGridMenu.Size = new System.Drawing.Size(128, 34);
            this.matrixGridMenu.Text = "Matrix Grid";
            this.matrixGridMenu.MouseLeave += new System.EventHandler(this.matrixGridMenu_MouseLeave);
            this.matrixGridMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.matrixGridMenu_MouseMove);
            // 
            // MenuItem2x2
            // 
            this.MenuItem2x2.Image = global::WindowsFormsApplication2.Properties.Resources._2_x_2__1_;
            this.MenuItem2x2.Name = "MenuItem2x2";
            this.MenuItem2x2.Size = new System.Drawing.Size(148, 34);
            this.MenuItem2x2.Text = "2 x 2";
            this.MenuItem2x2.Click += new System.EventHandler(this.MenuItem2x2_Click);
            this.MenuItem2x2.MouseLeave += new System.EventHandler(this.MenuItem2x2_MouseLeave);
            this.MenuItem2x2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuItem2x2_MouseMove);
            // 
            // MenuItem3x3
            // 
            this.MenuItem3x3.Image = global::WindowsFormsApplication2.Properties.Resources._3_x_3;
            this.MenuItem3x3.Name = "MenuItem3x3";
            this.MenuItem3x3.Size = new System.Drawing.Size(148, 34);
            this.MenuItem3x3.Text = "3 x 3";
            this.MenuItem3x3.Click += new System.EventHandler(this.MenuItem3x3_Click);
            this.MenuItem3x3.MouseLeave += new System.EventHandler(this.MenuItem3x3_MouseLeave);
            this.MenuItem3x3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuItem3x3_MouseMove);
            // 
            // MenuItem4x4
            // 
            this.MenuItem4x4.Image = global::WindowsFormsApplication2.Properties.Resources._4_x_4;
            this.MenuItem4x4.Name = "MenuItem4x4";
            this.MenuItem4x4.Size = new System.Drawing.Size(148, 34);
            this.MenuItem4x4.Text = "4 x 4";
            this.MenuItem4x4.Click += new System.EventHandler(this.MenuItem4x4_Click);
            this.MenuItem4x4.MouseLeave += new System.EventHandler(this.MenuItem4x4_MouseLeave);
            this.MenuItem4x4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuItem4x4_MouseMove);
            // 
            // MenuItem5x5
            // 
            this.MenuItem5x5.Image = global::WindowsFormsApplication2.Properties.Resources._5_x_5;
            this.MenuItem5x5.Name = "MenuItem5x5";
            this.MenuItem5x5.Size = new System.Drawing.Size(148, 34);
            this.MenuItem5x5.Text = "5 x 5";
            this.MenuItem5x5.Click += new System.EventHandler(this.MenuItem5x5_Click);
            this.MenuItem5x5.MouseLeave += new System.EventHandler(this.MenuItem5x5_MouseLeave);
            this.MenuItem5x5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuItem5x5_MouseMove);
            // 
            // MenuItem6x6
            // 
            this.MenuItem6x6.Image = global::WindowsFormsApplication2.Properties.Resources._6_x_6;
            this.MenuItem6x6.Name = "MenuItem6x6";
            this.MenuItem6x6.Size = new System.Drawing.Size(148, 34);
            this.MenuItem6x6.Text = "6 x 6";
            this.MenuItem6x6.Click += new System.EventHandler(this.MenuItem6x6_Click);
            this.MenuItem6x6.MouseLeave += new System.EventHandler(this.MenuItem6x6_MouseLeave);
            this.MenuItem6x6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuItem6x6_MouseMove);
            // 
            // MenuItem7x7
            // 
            this.MenuItem7x7.Image = global::WindowsFormsApplication2.Properties.Resources._7_x_7;
            this.MenuItem7x7.Name = "MenuItem7x7";
            this.MenuItem7x7.Size = new System.Drawing.Size(148, 34);
            this.MenuItem7x7.Text = "7 x 7";
            this.MenuItem7x7.Click += new System.EventHandler(this.MenuItem7x7_Click);
            this.MenuItem7x7.MouseLeave += new System.EventHandler(this.MenuItem7x7_MouseLeave);
            this.MenuItem7x7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuItem7x7_MouseMove);
            // 
            // MenuItem8x8
            // 
            this.MenuItem8x8.Image = global::WindowsFormsApplication2.Properties.Resources._8_x_8;
            this.MenuItem8x8.Name = "MenuItem8x8";
            this.MenuItem8x8.Size = new System.Drawing.Size(148, 34);
            this.MenuItem8x8.Text = "8 x 8";
            this.MenuItem8x8.Click += new System.EventHandler(this.MenuItem8x8_Click);
            this.MenuItem8x8.MouseLeave += new System.EventHandler(this.MenuItem8x8_MouseLeave);
            this.MenuItem8x8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuItem8x8_MouseMove);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(68, 34);
            this.helpMenu.Text = "Help";
            this.helpMenu.MouseLeave += new System.EventHandler(this.helpMenu_MouseLeave);
            this.helpMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.helpMenu_MouseMove);
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationMenuItem,
            this.developerMenuItem});
            this.aboutMenuItem.Image = global::WindowsFormsApplication2.Properties.Resources.group_12099581;
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(161, 34);
            this.aboutMenuItem.Text = "About";
            this.aboutMenuItem.MouseLeave += new System.EventHandler(this.aboutMenuItem_MouseLeave);
            this.aboutMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.aboutMenuItem_MouseMove);
            // 
            // applicationMenuItem
            // 
            this.applicationMenuItem.Image = global::WindowsFormsApplication2.Properties.Resources.App_Store_Logo;
            this.applicationMenuItem.Name = "applicationMenuItem";
            this.applicationMenuItem.Size = new System.Drawing.Size(209, 34);
            this.applicationMenuItem.Text = "Application";
            this.applicationMenuItem.Click += new System.EventHandler(this.applicationMenuItem_Click);
            this.applicationMenuItem.MouseLeave += new System.EventHandler(this.applicationMenuItem_MouseLeave);
            this.applicationMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.applicationMenuItem_MouseMove);
            // 
            // developerMenuItem
            // 
            this.developerMenuItem.Image = global::WindowsFormsApplication2.Properties.Resources.developer_10329496;
            this.developerMenuItem.Name = "developerMenuItem";
            this.developerMenuItem.Size = new System.Drawing.Size(209, 34);
            this.developerMenuItem.Text = "Developer";
            this.developerMenuItem.Click += new System.EventHandler(this.developerMenuItem_Click);
            this.developerMenuItem.MouseLeave += new System.EventHandler(this.developerMenuItem_MouseLeave);
            this.developerMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.developerMenuItem_MouseMove);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1114);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1176, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // FormMatrixGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1176, 1136);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMatrixGrid";
            this.Text = "Matrix Grid";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Thread MatrixGrid;
        public bool bThreadStatus;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonPlay;
        private System.Windows.Forms.ToolStripButton toolStripButtonPause;
        private System.Windows.Forms.ToolStripButton toolStripButtonStop;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem x2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem x7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x8ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionsMenu;
        private System.Windows.Forms.ToolStripMenuItem playMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrixGridMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuItem2x2;
        private System.Windows.Forms.ToolStripMenuItem MenuItem3x3;
        private System.Windows.Forms.ToolStripMenuItem MenuItem4x4;
        private System.Windows.Forms.ToolStripMenuItem MenuItem5x5;
        private System.Windows.Forms.ToolStripMenuItem MenuItem6x6;
        private System.Windows.Forms.ToolStripMenuItem MenuItem7x7;
        private System.Windows.Forms.ToolStripMenuItem MenuItem8x8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developerMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
    }
}

