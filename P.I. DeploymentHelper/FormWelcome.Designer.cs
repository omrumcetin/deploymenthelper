namespace P.I.DeploymentHelper
{
    partial class form_welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_welcome));
            this.lb_source = new System.Windows.Forms.ListBox();
            this.lb_portableSource = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.tb_source = new System.Windows.Forms.TextBox();
            this.tb_portableSource = new System.Windows.Forms.TextBox();
            this.BttnClose = new System.Windows.Forms.Button();
            this.BttnMinimize = new System.Windows.Forms.Button();
            this.LabelWindowTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fetchPipelinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_source
            // 
            this.lb_source.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_source.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(162)))));
            this.lb_source.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_source.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_source.ForeColor = System.Drawing.Color.White;
            this.lb_source.FormattingEnabled = true;
            this.lb_source.ItemHeight = 15;
            this.lb_source.Location = new System.Drawing.Point(0, 44);
            this.lb_source.Name = "lb_source";
            this.lb_source.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lb_source.Size = new System.Drawing.Size(413, 480);
            this.lb_source.TabIndex = 0;
            // 
            // lb_portableSource
            // 
            this.lb_portableSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_portableSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(162)))));
            this.lb_portableSource.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_portableSource.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_portableSource.ForeColor = System.Drawing.Color.White;
            this.lb_portableSource.FormattingEnabled = true;
            this.lb_portableSource.ItemHeight = 15;
            this.lb_portableSource.Location = new System.Drawing.Point(411, 44);
            this.lb_portableSource.Name = "lb_portableSource";
            this.lb_portableSource.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lb_portableSource.Size = new System.Drawing.Size(398, 480);
            this.lb_portableSource.TabIndex = 1;
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.ButtonSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSubmit.BackgroundImage")));
            this.ButtonSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonSubmit.FlatAppearance.BorderSize = 0;
            this.ButtonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSubmit.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSubmit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonSubmit.Location = new System.Drawing.Point(818, 485);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(50, 50);
            this.ButtonSubmit.TabIndex = 2;
            this.ButtonSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSubmit.UseMnemonic = false;
            this.ButtonSubmit.UseVisualStyleBackColor = false;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // tb_source
            // 
            this.tb_source.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(162)))));
            this.tb_source.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_source.ForeColor = System.Drawing.Color.White;
            this.tb_source.Location = new System.Drawing.Point(0, 516);
            this.tb_source.Name = "tb_source";
            this.tb_source.Size = new System.Drawing.Size(413, 23);
            this.tb_source.TabIndex = 3;
            this.tb_source.TextChanged += new System.EventHandler(this.Tb_source_TextChanged);
            // 
            // tb_portableSource
            // 
            this.tb_portableSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(162)))));
            this.tb_portableSource.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_portableSource.ForeColor = System.Drawing.Color.White;
            this.tb_portableSource.Location = new System.Drawing.Point(411, 516);
            this.tb_portableSource.Name = "tb_portableSource";
            this.tb_portableSource.Size = new System.Drawing.Size(398, 23);
            this.tb_portableSource.TabIndex = 4;
            this.tb_portableSource.TextChanged += new System.EventHandler(this.Tb_portableSource_TextChanged);
            // 
            // BttnClose
            // 
            this.BttnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.BttnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.menuStrip1.Size = new System.Drawing.Size(61, 62);
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
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(54, 58);
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
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(815, 408);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(57, 15);
            this.progressBar.TabIndex = 11;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.ButtonCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonCancel.BackgroundImage")));
            this.ButtonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonCancel.FlatAppearance.BorderSize = 0;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonCancel.Location = new System.Drawing.Point(818, 429);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(50, 50);
            this.ButtonCancel.TabIndex = 12;
            this.ButtonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonCancel.UseMnemonic = false;
            this.ButtonCancel.UseVisualStyleBackColor = false;
            // 
            // form_welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(876, 539);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.tb_portableSource);
            this.Controls.Add(this.lb_portableSource);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BttnClose);
            this.Controls.Add(this.LabelWindowTitle);
            this.Controls.Add(this.BttnMinimize);
            this.Controls.Add(this.tb_source);
            this.Controls.Add(this.lb_source);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P.I. Deployment Helper";
            this.Activated += new System.EventHandler(this.Form_welcome_Activated);
            this.Load += new System.EventHandler(this.Form_welcome_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_welcome_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_welcome_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_welcome_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_source;
        private System.Windows.Forms.ListBox lb_portableSource;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button ButtonSubmit;
        private System.Windows.Forms.TextBox tb_source;
        private System.Windows.Forms.TextBox tb_portableSource;
        private System.Windows.Forms.Button BttnClose;
        private System.Windows.Forms.Button BttnMinimize;
        private System.Windows.Forms.Label LabelWindowTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fetchPipelinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remoteSettingsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button ButtonCancel;
    }
}

