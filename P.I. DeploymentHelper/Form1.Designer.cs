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
            this.lb_source = new System.Windows.Forms.ListBox();
            this.lb_portableSource = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_source = new System.Windows.Forms.TextBox();
            this.tb_portableSource = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_source
            // 
            this.lb_source.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_source.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_source.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_source.FormattingEnabled = true;
            this.lb_source.ItemHeight = 15;
            this.lb_source.Location = new System.Drawing.Point(-1, -2);
            this.lb_source.Name = "lb_source";
            this.lb_source.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lb_source.Size = new System.Drawing.Size(414, 525);
            this.lb_source.TabIndex = 0;
            // 
            // lb_portableSource
            // 
            this.lb_portableSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_portableSource.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_portableSource.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_portableSource.FormattingEnabled = true;
            this.lb_portableSource.ItemHeight = 15;
            this.lb_portableSource.Location = new System.Drawing.Point(411, -2);
            this.lb_portableSource.Name = "lb_portableSource";
            this.lb_portableSource.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lb_portableSource.Size = new System.Drawing.Size(406, 525);
            this.lb_portableSource.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(816, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tb_source
            // 
            this.tb_source.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_source.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_source.Location = new System.Drawing.Point(0, 516);
            this.tb_source.Name = "tb_source";
            this.tb_source.Size = new System.Drawing.Size(413, 23);
            this.tb_source.TabIndex = 3;
            this.tb_source.TextChanged += new System.EventHandler(this.Tb_source_TextChanged);
            // 
            // tb_portableSource
            // 
            this.tb_portableSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_portableSource.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_portableSource.Location = new System.Drawing.Point(411, 516);
            this.tb_portableSource.Name = "tb_portableSource";
            this.tb_portableSource.Size = new System.Drawing.Size(406, 23);
            this.tb_portableSource.TabIndex = 4;
            this.tb_portableSource.TextChanged += new System.EventHandler(this.Tb_portableSource_TextChanged);
            // 
            // form_welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(876, 539);
            this.Controls.Add(this.tb_portableSource);
            this.Controls.Add(this.tb_source);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_portableSource);
            this.Controls.Add(this.lb_source);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P.I. Deployment Helper";
            this.Activated += new System.EventHandler(this.Form_welcome_Activated);
            this.Load += new System.EventHandler(this.Form_welcome_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_welcome_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_welcome_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_welcome_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_source;
        private System.Windows.Forms.ListBox lb_portableSource;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_source;
        private System.Windows.Forms.TextBox tb_portableSource;
    }
}

