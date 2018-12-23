namespace Pocket_Control_Center
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxReleaseInfo = new System.Windows.Forms.TextBox();
            this.pBoxImage = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.Text = "Pocket Control Center";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(54, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 18);
            this.label2.Text = "Versione 0.1.0.0 [Alfa]";
            // 
            // tBoxReleaseInfo
            // 
            this.tBoxReleaseInfo.Location = new System.Drawing.Point(25, 131);
            this.tBoxReleaseInfo.Multiline = true;
            this.tBoxReleaseInfo.Name = "tBoxReleaseInfo";
            this.tBoxReleaseInfo.ReadOnly = true;
            this.tBoxReleaseInfo.Size = new System.Drawing.Size(190, 87);
            this.tBoxReleaseInfo.TabIndex = 2;
            // 
            // pBoxImage
            // 
            this.pBoxImage.Image = ((System.Drawing.Image)(resources.GetObject("pBoxImage.Image")));
            this.pBoxImage.Location = new System.Drawing.Point(25, 3);
            this.pBoxImage.Name = "pBoxImage";
            this.pBoxImage.Size = new System.Drawing.Size(190, 122);
            this.pBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.pBoxImage);
            this.Controls.Add(this.tBoxReleaseInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AboutForm";
            this.Text = "About...";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxReleaseInfo;
        private System.Windows.Forms.PictureBox pBoxImage;
    }
}