namespace P.I.DeploymentHelper
{
    partial class Form_Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Welcome));
            this.ListBox_Pipelines = new System.Windows.Forms.ListBox();
            this.ListBox_Portables = new System.Windows.Forms.ListBox();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.FilterBox_Pipelines = new System.Windows.Forms.TextBox();
            this.FilterBox_Portables = new System.Windows.Forms.TextBox();
            this.BttnClose = new System.Windows.Forms.Button();
            this.BttnMinimize = new System.Windows.Forms.Button();
            this.LabelWindowTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fetchPipelinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LoadingBar = new System.Windows.Forms.PictureBox();
            this.loadingButton = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingButton)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBox_Pipelines
            // 
            this.ListBox_Pipelines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListBox_Pipelines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(162)))));
            this.ListBox_Pipelines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBox_Pipelines.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox_Pipelines.ForeColor = System.Drawing.Color.White;
            this.ListBox_Pipelines.FormattingEnabled = true;
            this.ListBox_Pipelines.ItemHeight = 15;
            this.ListBox_Pipelines.Location = new System.Drawing.Point(0, 44);
            this.ListBox_Pipelines.Name = "ListBox_Pipelines";
            this.ListBox_Pipelines.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBox_Pipelines.Size = new System.Drawing.Size(413, 480);
            this.ListBox_Pipelines.TabIndex = 0;
            // 
            // ListBox_Portables
            // 
            this.ListBox_Portables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBox_Portables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(162)))));
            this.ListBox_Portables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBox_Portables.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox_Portables.ForeColor = System.Drawing.Color.White;
            this.ListBox_Portables.FormattingEnabled = true;
            this.ListBox_Portables.ItemHeight = 15;
            this.ListBox_Portables.Location = new System.Drawing.Point(413, 44);
            this.ListBox_Portables.Name = "ListBox_Portables";
            this.ListBox_Portables.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBox_Portables.Size = new System.Drawing.Size(398, 480);
            this.ListBox_Portables.TabIndex = 1;
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.ButtonSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonSubmit.FlatAppearance.BorderSize = 0;
            this.ButtonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSubmit.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSubmit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonSubmit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSubmit.Image")));
            this.ButtonSubmit.Location = new System.Drawing.Point(818, 495);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(50, 50);
            this.ButtonSubmit.TabIndex = 2;
            this.ButtonSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSubmit.UseMnemonic = false;
            this.ButtonSubmit.UseVisualStyleBackColor = false;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // FilterBox_Pipelines
            // 
            this.FilterBox_Pipelines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(162)))));
            this.FilterBox_Pipelines.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterBox_Pipelines.ForeColor = System.Drawing.Color.White;
            this.FilterBox_Pipelines.Location = new System.Drawing.Point(0, 524);
            this.FilterBox_Pipelines.Name = "FilterBox_Pipelines";
            this.FilterBox_Pipelines.Size = new System.Drawing.Size(413, 23);
            this.FilterBox_Pipelines.TabIndex = 3;
            this.FilterBox_Pipelines.TextChanged += new System.EventHandler(this.TextBox_Pipelines_TextChanged);
            // 
            // FilterBox_Portables
            // 
            this.FilterBox_Portables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(162)))));
            this.FilterBox_Portables.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterBox_Portables.ForeColor = System.Drawing.Color.White;
            this.FilterBox_Portables.Location = new System.Drawing.Point(413, 524);
            this.FilterBox_Portables.Name = "FilterBox_Portables";
            this.FilterBox_Portables.Size = new System.Drawing.Size(399, 23);
            this.FilterBox_Portables.TabIndex = 4;
            this.FilterBox_Portables.TextChanged += new System.EventHandler(this.TextBox_Portables_TextChanged);
            // 
            // BttnClose
            // 
            this.BttnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BttnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(72)))));
            this.BttnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BttnClose.BackgroundImage")));
            this.BttnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BttnClose.FlatAppearance.BorderSize = 0;
            this.BttnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnClose.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnClose.ForeColor = System.Drawing.Color.Transparent;
            this.BttnClose.Location = new System.Drawing.Point(826, 4);
            this.BttnClose.Name = "BttnClose";
            this.BttnClose.Size = new System.Drawing.Size(36, 36);
            this.BttnClose.TabIndex = 5;
            this.BttnClose.UseVisualStyleBackColor = false;
            this.BttnClose.Click += new System.EventHandler(this.BttnClose_Click);
            // 
            // BttnMinimize
            // 
            this.BttnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BttnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(72)))));
            this.BttnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BttnMinimize.BackgroundImage")));
            this.BttnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BttnMinimize.FlatAppearance.BorderSize = 0;
            this.BttnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnMinimize.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnMinimize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BttnMinimize.Location = new System.Drawing.Point(788, 4);
            this.BttnMinimize.Name = "BttnMinimize";
            this.BttnMinimize.Size = new System.Drawing.Size(36, 36);
            this.BttnMinimize.TabIndex = 6;
            this.BttnMinimize.UseVisualStyleBackColor = false;
            this.BttnMinimize.Click += new System.EventHandler(this.BttnMinimize_Click);
            // 
            // LabelWindowTitle
            // 
            this.LabelWindowTitle.AutoSize = true;
            this.LabelWindowTitle.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWindowTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelWindowTitle.Location = new System.Drawing.Point(37, 10);
            this.LabelWindowTitle.Name = "LabelWindowTitle";
            this.LabelWindowTitle.Size = new System.Drawing.Size(203, 22);
            this.LabelWindowTitle.TabIndex = 7;
            this.LabelWindowTitle.Text = "Deployment Helper";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(42, 42);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(811, 48);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(60, 60);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.settingsToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.settingsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fetchPipelinesToolStripMenuItem,
            this.remoteSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(54, 56);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // fetchPipelinesToolStripMenuItem
            // 
            this.fetchPipelinesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.fetchPipelinesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fetchPipelinesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fetchPipelinesToolStripMenuItem.Name = "fetchPipelinesToolStripMenuItem";
            this.fetchPipelinesToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fetchPipelinesToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.fetchPipelinesToolStripMenuItem.Text = "Fetch Pipelines";
            this.fetchPipelinesToolStripMenuItem.Click += new System.EventHandler(this.FetchPipelinesToolStripMenuItem_Click);
            // 
            // remoteSettingsToolStripMenuItem
            // 
            this.remoteSettingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.remoteSettingsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.remoteSettingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.remoteSettingsToolStripMenuItem.Name = "remoteSettingsToolStripMenuItem";
            this.remoteSettingsToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.remoteSettingsToolStripMenuItem.Text = "Portable Softwares";
            this.remoteSettingsToolStripMenuItem.Click += new System.EventHandler(this.RemoteSettingsToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.pictureBox1.Location = new System.Drawing.Point(799, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 508);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 29);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // LoadingBar
            // 
            this.LoadingBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.LoadingBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LoadingBar.Image = ((System.Drawing.Image)(resources.GetObject("LoadingBar.Image")));
            this.LoadingBar.Location = new System.Drawing.Point(0, 44);
            this.LoadingBar.Name = "LoadingBar";
            this.LoadingBar.Size = new System.Drawing.Size(413, 508);
            this.LoadingBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LoadingBar.TabIndex = 12;
            this.LoadingBar.TabStop = false;
            this.LoadingBar.UseWaitCursor = true;
            this.LoadingBar.Visible = false;
            // 
            // loadingButton
            // 
            this.loadingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.loadingButton.Image = ((System.Drawing.Image)(resources.GetObject("loadingButton.Image")));
            this.loadingButton.Location = new System.Drawing.Point(818, 495);
            this.loadingButton.Name = "loadingButton";
            this.loadingButton.Size = new System.Drawing.Size(50, 50);
            this.loadingButton.TabIndex = 13;
            this.loadingButton.TabStop = false;
            // 
            // Form_Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(876, 547);
            this.Controls.Add(this.FilterBox_Portables);
            this.Controls.Add(this.ListBox_Portables);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BttnClose);
            this.Controls.Add(this.LabelWindowTitle);
            this.Controls.Add(this.BttnMinimize);
            this.Controls.Add(this.FilterBox_Pipelines);
            this.Controls.Add(this.ListBox_Pipelines);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loadingButton);
            this.Controls.Add(this.LoadingBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P.I. Deployment Helper";
            this.Activated += new System.EventHandler(this.Form_Welcome_Activated);
            this.Deactivate += new System.EventHandler(this.Form_Welcome_Deactivate);
            this.Load += new System.EventHandler(this.Form_Welcome_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_welcome_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_welcome_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_welcome_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox_Pipelines;
        private System.Windows.Forms.ListBox ListBox_Portables;
        private System.Windows.Forms.Button ButtonSubmit;
        private System.Windows.Forms.TextBox FilterBox_Pipelines;
        private System.Windows.Forms.TextBox FilterBox_Portables;
        private System.Windows.Forms.Button BttnClose;
        private System.Windows.Forms.Button BttnMinimize;
        private System.Windows.Forms.Label LabelWindowTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fetchPipelinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remoteSettingsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox LoadingBar;
        private System.Windows.Forms.PictureBox loadingButton;
    }
}

