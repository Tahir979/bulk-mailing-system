using System;

namespace Bulk_Mailing
{
    public partial class programinfo : MetroFramework.Forms.MetroForm
    {
        public programinfo()
        {
            InitializeComponent();
        }

        private void programinfo_Load(object sender, EventArgs e)
        {
            if (lang.Default.language == Localization.turkce)
            {
                Localization.Culture = new System.Globalization.CultureInfo(Localization.tr);
                lblprograminfo.Text = Localization.lblprograminfo;
                lblprograminfo2.Text = Localization.figure;
                this.Text = Localization._programmeinfo;
                this.Refresh();
            }
            else if (lang.Default.language == Localization.english)
            {
                Localization.Culture = new System.Globalization.CultureInfo(Localization.en);
                lblprograminfo.Text = Localization.lblprograminfo;
                lblprograminfo2.Text = Localization.figure;
                this.Text = Localization._programmeinfo;
                this.Refresh();
            }
        }
    }
}
