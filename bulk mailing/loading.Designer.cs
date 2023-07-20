
namespace Bulk_Mailing
{
    partial class loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loading));
            this.lblinfowithload = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblinfowithload
            // 
            this.lblinfowithload.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblinfowithload.Location = new System.Drawing.Point(226, 430);
            this.lblinfowithload.Name = "lblinfowithload";
            this.lblinfowithload.Size = new System.Drawing.Size(336, 24);
            this.lblinfowithload.Style = MetroFramework.MetroColorStyle.Black;
            this.lblinfowithload.TabIndex = 3;
            this.lblinfowithload.Text = "Tüm Mailler Başarı Bir Şekilde Gönderildi :))";
            this.lblinfowithload.UseStyleColors = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bulk_Mailing.Properties.Resources.purplehead;
            this.pictureBox1.Location = new System.Drawing.Point(23, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(742, 395);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 477);
            this.Controls.Add(this.lblinfowithload);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Load += new System.EventHandler(this.loading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblinfowithload;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}