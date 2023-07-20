
namespace Bulk_Mailing
{
    partial class mail
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mail));
            this.lbl_validatingpeoplecount = new MetroFramework.Controls.MetroLabel();
            this.lbltotalpeople = new MetroFramework.Controls.MetroLabel();
            this.lbl_line5 = new MetroFramework.Controls.MetroLabel();
            this.lbl_editingaddress = new MetroFramework.Controls.MetroLink();
            this.lbl_programinfo = new MetroFramework.Controls.MetroLink();
            this.lst3_kutucuk = new System.Windows.Forms.ListBox();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.lblwarningaboutsize = new MetroFramework.Controls.MetroLabel();
            this.lbl_sendcodeinfo = new MetroFramework.Controls.MetroLabel();
            this.lblsize = new MetroFramework.Controls.MetroLabel();
            this.lbltotalfile = new MetroFramework.Controls.MetroLabel();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.lbl_errormailshow = new MetroFramework.Controls.MetroLabel();
            this.lbl_showerrorlist = new MetroFramework.Controls.MetroLink();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.txt_filecontrol = new System.Windows.Forms.TextBox();
            this.lbl_currentfolder = new MetroFramework.Controls.MetroLabel();
            this.txt_attachedfile = new System.Windows.Forms.TextBox();
            this.txt_huptgmail = new MetroFramework.Controls.MetroTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt_icerik2 = new MetroFramework.Controls.MetroTextBox();
            this.txt_font_appeal = new System.Windows.Forms.TextBox();
            this.txt_font_title = new System.Windows.Forms.TextBox();
            this.txt_font_content = new System.Windows.Forms.TextBox();
            this.txt_email = new MetroFramework.Controls.MetroTextBox();
            this.txt_isim = new MetroFramework.Controls.MetroTextBox();
            this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_addfolder = new MetroFramework.Controls.MetroTile();
            this.txt_taslak = new MetroFramework.Controls.MetroTextBox();
            this.lbl_errormail = new MetroFramework.Controls.MetroLabel();
            this.txtappeal = new MetroFramework.Controls.MetroTextBox();
            this.txttitle = new MetroFramework.Controls.MetroTextBox();
            this.txtcontent = new MetroFramework.Controls.MetroTextBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.btn_sendmail = new MetroFramework.Controls.MetroTile();
            this.lblunderlined1 = new MetroFramework.Controls.MetroLabel();
            this.lblunderlined2 = new System.Windows.Forms.Label();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.lst_errorlist = new System.Windows.Forms.ListBox();
            this.pict_changelang = new System.Windows.Forms.PictureBox();
            this.btn_getmaillist = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_changelang)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_validatingpeoplecount
            // 
            this.lbl_validatingpeoplecount.AutoSize = true;
            this.lbl_validatingpeoplecount.Location = new System.Drawing.Point(463, 548);
            this.lbl_validatingpeoplecount.Name = "lbl_validatingpeoplecount";
            this.lbl_validatingpeoplecount.Size = new System.Drawing.Size(16, 19);
            this.lbl_validatingpeoplecount.TabIndex = 279;
            this.lbl_validatingpeoplecount.Text = "0";
            this.lbl_validatingpeoplecount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbltotalpeople
            // 
            this.lbltotalpeople.AutoSize = true;
            this.lbltotalpeople.Location = new System.Drawing.Point(239, 547);
            this.lbltotalpeople.Name = "lbltotalpeople";
            this.lbltotalpeople.Size = new System.Drawing.Size(230, 19);
            this.lbltotalpeople.TabIndex = 278;
            this.lbltotalpeople.Text = "Total Number of People to Send Mail:";
            this.lbltotalpeople.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_line5
            // 
            this.lbl_line5.AutoSize = true;
            this.lbl_line5.Location = new System.Drawing.Point(290, 5);
            this.lbl_line5.Name = "lbl_line5";
            this.lbl_line5.Size = new System.Drawing.Size(14, 19);
            this.lbl_line5.TabIndex = 276;
            this.lbl_line5.Text = "/";
            // 
            // lbl_editingaddress
            // 
            this.lbl_editingaddress.Location = new System.Drawing.Point(301, 5);
            this.lbl_editingaddress.Name = "lbl_editingaddress";
            this.lbl_editingaddress.Size = new System.Drawing.Size(325, 23);
            this.lbl_editingaddress.TabIndex = 275;
            this.lbl_editingaddress.Text = "Kod Gönderen Mail Adresini Düzenlemek için Tıklayınız";
            this.lbl_editingaddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_editingaddress.UseSelectable = true;
            this.lbl_editingaddress.Click += new System.EventHandler(this.lbl_editingaddress_Click);
            // 
            // lbl_programinfo
            // 
            this.lbl_programinfo.Location = new System.Drawing.Point(0, 5);
            this.lbl_programinfo.Name = "lbl_programinfo";
            this.lbl_programinfo.Size = new System.Drawing.Size(295, 23);
            this.lbl_programinfo.TabIndex = 274;
            this.lbl_programinfo.Text = "Program Hakkında Detaylı Bilgi Almak için Tıklayınız";
            this.lbl_programinfo.UseSelectable = true;
            this.lbl_programinfo.Click += new System.EventHandler(this.lbl_programinfo_Click);
            // 
            // lst3_kutucuk
            // 
            this.lst3_kutucuk.FormattingEnabled = true;
            this.lst3_kutucuk.Location = new System.Drawing.Point(642, 34);
            this.lst3_kutucuk.Name = "lst3_kutucuk";
            this.lst3_kutucuk.Size = new System.Drawing.Size(28, 17);
            this.lst3_kutucuk.TabIndex = 273;
            this.lst3_kutucuk.Visible = false;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(1041, 547);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(210, 23);
            this.metroProgressBar1.Step = 1;
            this.metroProgressBar1.TabIndex = 263;
            this.metroProgressBar1.Visible = false;
            // 
            // lblwarningaboutsize
            // 
            this.lblwarningaboutsize.Location = new System.Drawing.Point(579, 570);
            this.lblwarningaboutsize.Name = "lblwarningaboutsize";
            this.lblwarningaboutsize.Size = new System.Drawing.Size(362, 45);
            this.lblwarningaboutsize.TabIndex = 272;
            this.lblwarningaboutsize.Text = "**Dosya boyut sınırı olarak \"20 MB\" belirlenmiştir, 20 MB\'ı geçmediği sürece bird" +
    "en fazla dosya eklenebilir.**";
            this.lblwarningaboutsize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblwarningaboutsize.WrapToLine = true;
            // 
            // lbl_sendcodeinfo
            // 
            this.lbl_sendcodeinfo.ForeColor = System.Drawing.Color.Black;
            this.lbl_sendcodeinfo.Location = new System.Drawing.Point(1041, 573);
            this.lbl_sendcodeinfo.Name = "lbl_sendcodeinfo";
            this.lbl_sendcodeinfo.Size = new System.Drawing.Size(210, 42);
            this.lbl_sendcodeinfo.TabIndex = 271;
            this.lbl_sendcodeinfo.Text = "Mailler Gönderiliyor... Lütfen Programı Kapatmayınız...";
            this.lbl_sendcodeinfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_sendcodeinfo.Visible = false;
            this.lbl_sendcodeinfo.WrapToLine = true;
            // 
            // lblsize
            // 
            this.lblsize.AutoSize = true;
            this.lblsize.Location = new System.Drawing.Point(741, 548);
            this.lblsize.Name = "lblsize";
            this.lblsize.Size = new System.Drawing.Size(57, 19);
            this.lblsize.TabIndex = 270;
            this.lblsize.Text = "0.00 MB";
            // 
            // lbltotalfile
            // 
            this.lbltotalfile.AutoSize = true;
            this.lbltotalfile.Location = new System.Drawing.Point(579, 547);
            this.lbltotalfile.Name = "lbltotalfile";
            this.lbltotalfile.Size = new System.Drawing.Size(168, 19);
            this.lbltotalfile.TabIndex = 269;
            this.lbltotalfile.Text = "Total Size of Available Files:";
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(634, 11);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(47, 17);
            this.listBox5.TabIndex = 268;
            this.listBox5.Visible = false;
            // 
            // lbl_errormailshow
            // 
            this.lbl_errormailshow.Location = new System.Drawing.Point(23, 298);
            this.lbl_errormailshow.Name = "lbl_errormailshow";
            this.lbl_errormailshow.Size = new System.Drawing.Size(210, 57);
            this.lbl_errormailshow.TabIndex = 267;
            this.lbl_errormailshow.Text = "**Hatalı olan mail adresleri otomatik olarak listeden kaldırılacaktır.**";
            this.lbl_errormailshow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_errormailshow.WrapToLine = true;
            // 
            // lbl_showerrorlist
            // 
            this.lbl_showerrorlist.Location = new System.Drawing.Point(23, 358);
            this.lbl_showerrorlist.Name = "lbl_showerrorlist";
            this.lbl_showerrorlist.Size = new System.Drawing.Size(210, 23);
            this.lbl_showerrorlist.TabIndex = 266;
            this.lbl_showerrorlist.Text = "Hatalı Mail Adreslerini Göster";
            this.lbl_showerrorlist.UseSelectable = true;
            this.lbl_showerrorlist.Click += new System.EventHandler(this.lbl_showerrorlist_Click);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(741, 11);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(37, 19);
            this.checkedListBox2.TabIndex = 262;
            this.checkedListBox2.Visible = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(687, 11);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(47, 17);
            this.listBox2.TabIndex = 261;
            this.listBox2.Visible = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(579, 495);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(362, 49);
            this.checkedListBox1.TabIndex = 260;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            this.checkedListBox1.SelectedValueChanged += new System.EventHandler(this.checkedListBox1_SelectedValueChanged);
            // 
            // txt_filecontrol
            // 
            this.txt_filecontrol.Location = new System.Drawing.Point(368, 30);
            this.txt_filecontrol.Name = "txt_filecontrol";
            this.txt_filecontrol.Size = new System.Drawing.Size(222, 20);
            this.txt_filecontrol.TabIndex = 259;
            this.txt_filecontrol.Text = "Şu an için yüklü bir dosya bulunmamaktadır";
            this.txt_filecontrol.Visible = false;
            // 
            // lbl_currentfolder
            // 
            this.lbl_currentfolder.AutoSize = true;
            this.lbl_currentfolder.Location = new System.Drawing.Point(688, 473);
            this.lbl_currentfolder.Name = "lbl_currentfolder";
            this.lbl_currentfolder.Size = new System.Drawing.Size(144, 19);
            this.lbl_currentfolder.TabIndex = 257;
            this.lbl_currentfolder.Text = "Ekteki Dosya / Dosyalar";
            // 
            // txt_attachedfile
            // 
            this.txt_attachedfile.Location = new System.Drawing.Point(277, 30);
            this.txt_attachedfile.Name = "txt_attachedfile";
            this.txt_attachedfile.Size = new System.Drawing.Size(85, 20);
            this.txt_attachedfile.TabIndex = 256;
            this.txt_attachedfile.Text = "Ekteki Dosyalar: ";
            this.txt_attachedfile.Visible = false;
            // 
            // txt_huptgmail
            // 
            // 
            // 
            // 
            this.txt_huptgmail.CustomButton.Image = null;
            this.txt_huptgmail.CustomButton.Location = new System.Drawing.Point(340, 2);
            this.txt_huptgmail.CustomButton.Name = "";
            this.txt_huptgmail.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txt_huptgmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_huptgmail.CustomButton.TabIndex = 1;
            this.txt_huptgmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_huptgmail.CustomButton.UseSelectable = true;
            this.txt_huptgmail.CustomButton.Visible = false;
            this.txt_huptgmail.Lines = new string[] {
        "huptsecim@gmail.com"};
            this.txt_huptgmail.Location = new System.Drawing.Point(579, 63);
            this.txt_huptgmail.MaxLength = 32767;
            this.txt_huptgmail.Name = "txt_huptgmail";
            this.txt_huptgmail.PasswordChar = '\0';
            this.txt_huptgmail.ReadOnly = true;
            this.txt_huptgmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_huptgmail.SelectedText = "";
            this.txt_huptgmail.SelectionLength = 0;
            this.txt_huptgmail.SelectionStart = 0;
            this.txt_huptgmail.ShortcutsEnabled = true;
            this.txt_huptgmail.Size = new System.Drawing.Size(362, 24);
            this.txt_huptgmail.TabIndex = 255;
            this.txt_huptgmail.Text = "huptsecim@gmail.com";
            this.txt_huptgmail.UseSelectable = true;
            this.txt_huptgmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_huptgmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(837, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(27, 17);
            this.listBox1.TabIndex = 254;
            this.listBox1.Visible = false;
            // 
            // txt_icerik2
            // 
            // 
            // 
            // 
            this.txt_icerik2.CustomButton.Image = null;
            this.txt_icerik2.CustomButton.Location = new System.Drawing.Point(16, 1);
            this.txt_icerik2.CustomButton.Name = "";
            this.txt_icerik2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_icerik2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_icerik2.CustomButton.TabIndex = 1;
            this.txt_icerik2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_icerik2.CustomButton.UseSelectable = true;
            this.txt_icerik2.CustomButton.Visible = false;
            this.txt_icerik2.Lines = new string[0];
            this.txt_icerik2.Location = new System.Drawing.Point(870, 34);
            this.txt_icerik2.MaxLength = 32767;
            this.txt_icerik2.Multiline = true;
            this.txt_icerik2.Name = "txt_icerik2";
            this.txt_icerik2.PasswordChar = '\0';
            this.txt_icerik2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_icerik2.SelectedText = "";
            this.txt_icerik2.SelectionLength = 0;
            this.txt_icerik2.SelectionStart = 0;
            this.txt_icerik2.ShortcutsEnabled = true;
            this.txt_icerik2.Size = new System.Drawing.Size(38, 23);
            this.txt_icerik2.TabIndex = 253;
            this.txt_icerik2.UseSelectable = true;
            this.txt_icerik2.Visible = false;
            this.txt_icerik2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_icerik2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_font_appeal
            // 
            this.txt_font_appeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_font_appeal.Location = new System.Drawing.Point(120, 30);
            this.txt_font_appeal.Name = "txt_font_appeal";
            this.txt_font_appeal.Size = new System.Drawing.Size(64, 20);
            this.txt_font_appeal.TabIndex = 252;
            this.txt_font_appeal.Text = "Hitap: ";
            this.txt_font_appeal.Visible = false;
            // 
            // txt_font_title
            // 
            this.txt_font_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_font_title.Location = new System.Drawing.Point(190, 30);
            this.txt_font_title.Name = "txt_font_title";
            this.txt_font_title.Size = new System.Drawing.Size(81, 20);
            this.txt_font_title.TabIndex = 251;
            this.txt_font_title.Text = "Mail Başlığı: ";
            this.txt_font_title.Visible = false;
            // 
            // txt_font_content
            // 
            this.txt_font_content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_font_content.Location = new System.Drawing.Point(23, 31);
            this.txt_font_content.Name = "txt_font_content";
            this.txt_font_content.Size = new System.Drawing.Size(91, 20);
            this.txt_font_content.TabIndex = 250;
            this.txt_font_content.Text = "Mail İçeriği: ";
            this.txt_font_content.Visible = false;
            // 
            // txt_email
            // 
            // 
            // 
            // 
            this.txt_email.CustomButton.Image = null;
            this.txt_email.CustomButton.Location = new System.Drawing.Point(11, 1);
            this.txt_email.CustomButton.Name = "";
            this.txt_email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_email.CustomButton.TabIndex = 1;
            this.txt_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_email.CustomButton.UseSelectable = true;
            this.txt_email.CustomButton.Visible = false;
            this.txt_email.Lines = new string[0];
            this.txt_email.Location = new System.Drawing.Point(799, 34);
            this.txt_email.MaxLength = 32767;
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_email.SelectedText = "";
            this.txt_email.SelectionLength = 0;
            this.txt_email.SelectionStart = 0;
            this.txt_email.ShortcutsEnabled = true;
            this.txt_email.Size = new System.Drawing.Size(33, 23);
            this.txt_email.TabIndex = 249;
            this.txt_email.UseSelectable = true;
            this.txt_email.Visible = false;
            this.txt_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_isim
            // 
            // 
            // 
            // 
            this.txt_isim.CustomButton.Image = null;
            this.txt_isim.CustomButton.Location = new System.Drawing.Point(13, 1);
            this.txt_isim.CustomButton.Name = "";
            this.txt_isim.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_isim.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_isim.CustomButton.TabIndex = 1;
            this.txt_isim.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_isim.CustomButton.UseSelectable = true;
            this.txt_isim.CustomButton.Visible = false;
            this.txt_isim.Lines = new string[0];
            this.txt_isim.Location = new System.Drawing.Point(753, 34);
            this.txt_isim.MaxLength = 32767;
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.PasswordChar = '\0';
            this.txt_isim.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_isim.SelectedText = "";
            this.txt_isim.SelectionLength = 0;
            this.txt_isim.SelectionStart = 0;
            this.txt_isim.ShortcutsEnabled = true;
            this.txt_isim.Size = new System.Drawing.Size(35, 23);
            this.txt_isim.TabIndex = 248;
            this.txt_isim.UseSelectable = true;
            this.txt_isim.Visible = false;
            this.txt_isim.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_isim.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroGrid2
            // 
            this.metroGrid2.AllowUserToResizeRows = false;
            this.metroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid2.EnableHeadersVisualStyles = false;
            this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.Location = new System.Drawing.Point(194, 575);
            this.metroGrid2.Name = "metroGrid2";
            this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid2.Size = new System.Drawing.Size(38, 32);
            this.metroGrid2.TabIndex = 247;
            this.metroGrid2.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(687, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(27, 20);
            this.textBox2.TabIndex = 246;
            this.textBox2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(720, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(27, 20);
            this.textBox1.TabIndex = 245;
            this.textBox1.Visible = false;
            // 
            // btn_addfolder
            // 
            this.btn_addfolder.ActiveControl = null;
            this.btn_addfolder.Location = new System.Drawing.Point(579, 426);
            this.btn_addfolder.Name = "btn_addfolder";
            this.btn_addfolder.Size = new System.Drawing.Size(362, 44);
            this.btn_addfolder.TabIndex = 244;
            this.btn_addfolder.Text = "Dosya / Dosyalar Ekle";
            this.btn_addfolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_addfolder.UseSelectable = true;
            this.btn_addfolder.Click += new System.EventHandler(this.btn_addfolder_Click);
            // 
            // txt_taslak
            // 
            // 
            // 
            // 
            this.txt_taslak.CustomButton.Image = null;
            this.txt_taslak.CustomButton.Location = new System.Drawing.Point(-122, 2);
            this.txt_taslak.CustomButton.Name = "";
            this.txt_taslak.CustomButton.Size = new System.Drawing.Size(423, 423);
            this.txt_taslak.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_taslak.CustomButton.TabIndex = 1;
            this.txt_taslak.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_taslak.CustomButton.UseSelectable = true;
            this.txt_taslak.CustomButton.Visible = false;
            this.txt_taslak.Lines = new string[0];
            this.txt_taslak.Location = new System.Drawing.Point(947, 63);
            this.txt_taslak.MaxLength = 32767;
            this.txt_taslak.Multiline = true;
            this.txt_taslak.Name = "txt_taslak";
            this.txt_taslak.PasswordChar = '\0';
            this.txt_taslak.ReadOnly = true;
            this.txt_taslak.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_taslak.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_taslak.SelectedText = "";
            this.txt_taslak.SelectionLength = 0;
            this.txt_taslak.SelectionStart = 0;
            this.txt_taslak.ShortcutsEnabled = true;
            this.txt_taslak.Size = new System.Drawing.Size(304, 428);
            this.txt_taslak.TabIndex = 243;
            this.txt_taslak.UseSelectable = true;
            this.txt_taslak.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_taslak.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_errormail
            // 
            this.lbl_errormail.AutoSize = true;
            this.lbl_errormail.Location = new System.Drawing.Point(52, 276);
            this.lbl_errormail.Name = "lbl_errormail";
            this.lbl_errormail.Size = new System.Drawing.Size(152, 19);
            this.lbl_errormail.TabIndex = 241;
            this.lbl_errormail.Text = "Incorrect Mail Addresses";
            // 
            // txtappeal
            // 
            // 
            // 
            // 
            this.txtappeal.CustomButton.Image = null;
            this.txtappeal.CustomButton.Location = new System.Drawing.Point(340, 2);
            this.txtappeal.CustomButton.Name = "";
            this.txtappeal.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtappeal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtappeal.CustomButton.TabIndex = 1;
            this.txtappeal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtappeal.CustomButton.UseSelectable = true;
            this.txtappeal.CustomButton.Visible = false;
            this.txtappeal.Lines = new string[0];
            this.txtappeal.Location = new System.Drawing.Point(579, 123);
            this.txtappeal.MaxLength = 32767;
            this.txtappeal.Name = "txtappeal";
            this.txtappeal.PasswordChar = '\0';
            this.txtappeal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtappeal.SelectedText = "";
            this.txtappeal.SelectionLength = 0;
            this.txtappeal.SelectionStart = 0;
            this.txtappeal.ShortcutsEnabled = true;
            this.txtappeal.Size = new System.Drawing.Size(362, 24);
            this.txtappeal.TabIndex = 240;
            this.txtappeal.UseSelectable = true;
            this.txtappeal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtappeal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtappeal.TextChanged += new System.EventHandler(this.txtappeal_TextChanged);
            // 
            // txttitle
            // 
            this.txttitle.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txttitle.CustomButton.Image = null;
            this.txttitle.CustomButton.Location = new System.Drawing.Point(340, 2);
            this.txttitle.CustomButton.Name = "";
            this.txttitle.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txttitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txttitle.CustomButton.TabIndex = 1;
            this.txttitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txttitle.CustomButton.UseSelectable = true;
            this.txttitle.CustomButton.Visible = false;
            this.txttitle.Lines = new string[0];
            this.txttitle.Location = new System.Drawing.Point(579, 93);
            this.txttitle.MaxLength = 32767;
            this.txttitle.Name = "txttitle";
            this.txttitle.PasswordChar = '\0';
            this.txttitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txttitle.SelectedText = "";
            this.txttitle.SelectionLength = 0;
            this.txttitle.SelectionStart = 0;
            this.txttitle.ShortcutsEnabled = true;
            this.txttitle.Size = new System.Drawing.Size(362, 24);
            this.txttitle.TabIndex = 239;
            this.txttitle.UseSelectable = true;
            this.txttitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txttitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txttitle.TextChanged += new System.EventHandler(this.txttitle_TextChanged);
            // 
            // txtcontent
            // 
            // 
            // 
            // 
            this.txtcontent.CustomButton.Image = null;
            this.txtcontent.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.txtcontent.CustomButton.Name = "";
            this.txtcontent.CustomButton.Size = new System.Drawing.Size(265, 265);
            this.txtcontent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtcontent.CustomButton.TabIndex = 1;
            this.txtcontent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtcontent.CustomButton.UseSelectable = true;
            this.txtcontent.CustomButton.Visible = false;
            this.txtcontent.Lines = new string[0];
            this.txtcontent.Location = new System.Drawing.Point(579, 153);
            this.txtcontent.MaxLength = 32767;
            this.txtcontent.Multiline = true;
            this.txtcontent.Name = "txtcontent";
            this.txtcontent.PasswordChar = '\0';
            this.txtcontent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcontent.SelectedText = "";
            this.txtcontent.SelectionLength = 0;
            this.txtcontent.SelectionStart = 0;
            this.txtcontent.ShortcutsEnabled = true;
            this.txtcontent.Size = new System.Drawing.Size(362, 267);
            this.txtcontent.TabIndex = 238;
            this.txtcontent.UseSelectable = true;
            this.txtcontent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtcontent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtcontent.TextChanged += new System.EventHandler(this.txtcontent_TextChanged);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToOrderColumns = true;
            this.metroGrid1.AllowUserToResizeColumns = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.White;
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(239, 63);
            this.metroGrid1.MultiSelect = false;
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersVisible = false;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(334, 481);
            this.metroGrid1.TabIndex = 237;
            // 
            // btn_sendmail
            // 
            this.btn_sendmail.ActiveControl = null;
            this.btn_sendmail.Location = new System.Drawing.Point(947, 497);
            this.btn_sendmail.Name = "btn_sendmail";
            this.btn_sendmail.Size = new System.Drawing.Size(306, 44);
            this.btn_sendmail.TabIndex = 236;
            this.btn_sendmail.Text = "Kişilere Mail Göndermeyi Başlat";
            this.btn_sendmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_sendmail.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sendmail.UseSelectable = true;
            this.btn_sendmail.UseTileImage = true;
            this.btn_sendmail.Click += new System.EventHandler(this.btn_sendmail_Click);
            // 
            // lblunderlined1
            // 
            this.lblunderlined1.AutoSize = true;
            this.lblunderlined1.Location = new System.Drawing.Point(49, 279);
            this.lblunderlined1.Name = "lblunderlined1";
            this.lblunderlined1.Size = new System.Drawing.Size(159, 19);
            this.lblunderlined1.TabIndex = 242;
            this.lblunderlined1.Text = "_________________________";
            // 
            // lblunderlined2
            // 
            this.lblunderlined2.AutoSize = true;
            this.lblunderlined2.Location = new System.Drawing.Point(694, 480);
            this.lblunderlined2.Name = "lblunderlined2";
            this.lblunderlined2.Size = new System.Drawing.Size(133, 13);
            this.lblunderlined2.TabIndex = 258;
            this.lblunderlined2.Text = "_____________________";
            // 
            // metroLabel8
            // 
            this.metroLabel8.Location = new System.Drawing.Point(947, 547);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(93, 23);
            this.metroLabel8.TabIndex = 264;
            this.metroLabel8.Text = "%0.00";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel8.Visible = false;
            // 
            // lst_errorlist
            // 
            this.lst_errorlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst_errorlist.FormattingEnabled = true;
            this.lst_errorlist.Location = new System.Drawing.Point(23, 381);
            this.lst_errorlist.Name = "lst_errorlist";
            this.lst_errorlist.Size = new System.Drawing.Size(210, 234);
            this.lst_errorlist.TabIndex = 265;
            this.lst_errorlist.Visible = false;
            // 
            // pict_changelang
            // 
            this.pict_changelang.Image = global::Bulk_Mailing.Properties.Resources.tr;
            this.pict_changelang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pict_changelang.Location = new System.Drawing.Point(947, 23);
            this.pict_changelang.Name = "pict_changelang";
            this.pict_changelang.Size = new System.Drawing.Size(32, 28);
            this.pict_changelang.TabIndex = 277;
            this.pict_changelang.TabStop = false;
            this.pict_changelang.Click += new System.EventHandler(this.pict_changelang_Click);
            // 
            // btn_getmaillist
            // 
            this.btn_getmaillist.ActiveControl = null;
            this.btn_getmaillist.ForeColor = System.Drawing.Color.Black;
            this.btn_getmaillist.Location = new System.Drawing.Point(23, 63);
            this.btn_getmaillist.Name = "btn_getmaillist";
            this.btn_getmaillist.Size = new System.Drawing.Size(210, 210);
            this.btn_getmaillist.TabIndex = 235;
            this.btn_getmaillist.Text = "Kişilerin Veri Excel\'ini Seç";
            this.btn_getmaillist.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_getmaillist.TileImage = global::Bulk_Mailing.Properties.Resources.excel;
            this.btn_getmaillist.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_getmaillist.UseSelectable = true;
            this.btn_getmaillist.UseTileImage = true;
            this.btn_getmaillist.Click += new System.EventHandler(this.btn_getmaillist_Click);
            // 
            // mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 627);
            this.Controls.Add(this.lbl_validatingpeoplecount);
            this.Controls.Add(this.lbltotalpeople);
            this.Controls.Add(this.pict_changelang);
            this.Controls.Add(this.lbl_line5);
            this.Controls.Add(this.lbl_editingaddress);
            this.Controls.Add(this.lbl_programinfo);
            this.Controls.Add(this.lst3_kutucuk);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.lblwarningaboutsize);
            this.Controls.Add(this.lbl_sendcodeinfo);
            this.Controls.Add(this.lblsize);
            this.Controls.Add(this.lbltotalfile);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.lbl_errormailshow);
            this.Controls.Add(this.lbl_showerrorlist);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.txt_filecontrol);
            this.Controls.Add(this.lbl_currentfolder);
            this.Controls.Add(this.txt_attachedfile);
            this.Controls.Add(this.txt_huptgmail);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_icerik2);
            this.Controls.Add(this.txt_font_appeal);
            this.Controls.Add(this.txt_font_title);
            this.Controls.Add(this.txt_font_content);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.metroGrid2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_addfolder);
            this.Controls.Add(this.txt_taslak);
            this.Controls.Add(this.lbl_errormail);
            this.Controls.Add(this.txtappeal);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.txtcontent);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.btn_sendmail);
            this.Controls.Add(this.btn_getmaillist);
            this.Controls.Add(this.lblunderlined1);
            this.Controls.Add(this.lblunderlined2);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.lst_errorlist);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mail";
            this.Text = "Toplu Mail Atma Programı";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.Load += new System.EventHandler(this.mail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_changelang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbl_validatingpeoplecount;
        private MetroFramework.Controls.MetroLabel lbltotalpeople;
        private System.Windows.Forms.PictureBox pict_changelang;
        private MetroFramework.Controls.MetroLabel lbl_line5;
        private MetroFramework.Controls.MetroLink lbl_editingaddress;
        private MetroFramework.Controls.MetroLink lbl_programinfo;
        private System.Windows.Forms.ListBox lst3_kutucuk;
        public MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroLabel lblwarningaboutsize;
        private MetroFramework.Controls.MetroLabel lbl_sendcodeinfo;
        private MetroFramework.Controls.MetroLabel lblsize;
        private MetroFramework.Controls.MetroLabel lbltotalfile;
        private System.Windows.Forms.ListBox listBox5;
        private MetroFramework.Controls.MetroLabel lbl_errormailshow;
        private MetroFramework.Controls.MetroLink lbl_showerrorlist;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox txt_filecontrol;
        private MetroFramework.Controls.MetroLabel lbl_currentfolder;
        private System.Windows.Forms.TextBox txt_attachedfile;
        private MetroFramework.Controls.MetroTextBox txt_huptgmail;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroTextBox txt_icerik2;
        private System.Windows.Forms.TextBox txt_font_appeal;
        private System.Windows.Forms.TextBox txt_font_title;
        private System.Windows.Forms.TextBox txt_font_content;
        private MetroFramework.Controls.MetroTextBox txt_email;
        private MetroFramework.Controls.MetroTextBox txt_isim;
        private MetroFramework.Controls.MetroGrid metroGrid2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroTile btn_addfolder;
        private MetroFramework.Controls.MetroTextBox txt_taslak;
        private MetroFramework.Controls.MetroLabel lbl_errormail;
        private MetroFramework.Controls.MetroTextBox txtappeal;
        private MetroFramework.Controls.MetroTextBox txttitle;
        private MetroFramework.Controls.MetroTextBox txtcontent;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroTile btn_sendmail;
        private MetroFramework.Controls.MetroTile btn_getmaillist;
        private MetroFramework.Controls.MetroLabel lblunderlined1;
        private System.Windows.Forms.Label lblunderlined2;
        public MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.ListBox lst_errorlist;
    }
}

