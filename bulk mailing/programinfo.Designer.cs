
namespace Bulk_Mailing
{
    partial class programinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(programinfo));
            this.lblprograminfo2 = new MetroFramework.Controls.MetroLabel();
            this.lblprograminfo = new MetroFramework.Controls.MetroLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblprograminfo2
            // 
            this.lblprograminfo2.AutoSize = true;
            this.lblprograminfo2.Location = new System.Drawing.Point(707, 334);
            this.lblprograminfo2.Name = "lblprograminfo2";
            this.lblprograminfo2.Size = new System.Drawing.Size(54, 19);
            this.lblprograminfo2.TabIndex = 53;
            this.lblprograminfo2.Text = "Şekil - 1";
            // 
            // lblprograminfo
            // 
            this.lblprograminfo.Location = new System.Drawing.Point(23, 60);
            this.lblprograminfo.Name = "lblprograminfo";
            this.lblprograminfo.Size = new System.Drawing.Size(572, 293);
            this.lblprograminfo.TabIndex = 52;
            this.lblprograminfo.Text = resources.GetString("lblprograminfo.Text");
            this.lblprograminfo.WrapToLine = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Bulk_Mailing.Properties.Resources.figure;
            this.pictureBox4.Location = new System.Drawing.Point(601, 60);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(267, 271);
            this.pictureBox4.TabIndex = 51;
            this.pictureBox4.TabStop = false;
            // 
            // programinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 376);
            this.Controls.Add(this.lblprograminfo2);
            this.Controls.Add(this.lblprograminfo);
            this.Controls.Add(this.pictureBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "programinfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Program Hakkında";
            this.Load += new System.EventHandler(this.programinfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblprograminfo2;
        private MetroFramework.Controls.MetroLabel lblprograminfo;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}