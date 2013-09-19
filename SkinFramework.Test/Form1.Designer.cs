namespace SkinFramework.Test
{
    partial class Form1
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radLuna = new System.Windows.Forms.RadioButton();
            this.radSilver = new System.Windows.Forms.RadioButton();
            this.radObsidian = new System.Windows.Forms.RadioButton();
            this.skinningManager1 = new SkinFramework.SkinningManager();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.radLuna);
            this.flowLayoutPanel1.Controls.Add(this.radSilver);
            this.flowLayoutPanel1.Controls.Add(this.radObsidian);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(334, 95);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // radLuna
            // 
            this.radLuna.Appearance = System.Windows.Forms.Appearance.Button;
            this.radLuna.Checked = true;
            this.radLuna.Image = global::SkinFramework.Test.Properties.Resources.Office07Blue;
            this.radLuna.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radLuna.Location = new System.Drawing.Point(3, 3);
            this.radLuna.Name = "radLuna";
            this.radLuna.Size = new System.Drawing.Size(104, 89);
            this.radLuna.TabIndex = 0;
            this.radLuna.TabStop = true;
            this.radLuna.Text = "Office 2007 \r\nLuna";
            this.radLuna.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radLuna.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radLuna.UseVisualStyleBackColor = true;
            this.radLuna.CheckedChanged += new System.EventHandler(this.radSilver_CheckedChanged);
            // 
            // radSilver
            // 
            this.radSilver.Appearance = System.Windows.Forms.Appearance.Button;
            this.radSilver.Image = global::SkinFramework.Test.Properties.Resources.Office07Blue;
            this.radSilver.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radSilver.Location = new System.Drawing.Point(113, 3);
            this.radSilver.Name = "radSilver";
            this.radSilver.Size = new System.Drawing.Size(104, 89);
            this.radSilver.TabIndex = 0;
            this.radSilver.Text = "Office 2007 \r\nSilver";
            this.radSilver.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radSilver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radSilver.UseVisualStyleBackColor = true;
            this.radSilver.CheckedChanged += new System.EventHandler(this.radSilver_CheckedChanged);
            // 
            // radObsidian
            // 
            this.radObsidian.Appearance = System.Windows.Forms.Appearance.Button;
            this.radObsidian.Image = global::SkinFramework.Test.Properties.Resources.Office07Blue;
            this.radObsidian.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radObsidian.Location = new System.Drawing.Point(223, 3);
            this.radObsidian.Name = "radObsidian";
            this.radObsidian.Size = new System.Drawing.Size(104, 89);
            this.radObsidian.TabIndex = 0;
            this.radObsidian.Text = "Office 2007 \r\nObsidian";
            this.radObsidian.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radObsidian.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radObsidian.UseVisualStyleBackColor = true;
            this.radObsidian.CheckedChanged += new System.EventHandler(this.radSilver_CheckedChanged);
            // 
            // skinningManager1
            // 
            this.skinningManager1.DefaultSkin = SkinFramework.DefaultSkin.Office2007Luna;
            this.skinningManager1.ParentForm = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 109);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "DemoForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SkinFramework.SkinningManager skinningManager1;
        private System.Windows.Forms.RadioButton radLuna;
        private System.Windows.Forms.RadioButton radObsidian;
        private System.Windows.Forms.RadioButton radSilver;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}