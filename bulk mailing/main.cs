using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;

namespace Bulk_Mailing
{
    public partial class mail : MetroFramework.Forms.MetroForm
    {
        public mail()
        {
            InitializeComponent();
        }

        public static string TersCevir(string metin)
        {
            string sonuc = "";
            for (int i = metin.Length - 1; i >= 0; i--)
                sonuc += metin[i];
            return sonuc;
        }
        void sendcode()
        {
            try
            {
                if (lbl_validatingpeoplecount.Text == Localization.number)
                {
                    MessageBox.Show(Localization.mberrornodataentry, Localization.mb_hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SmtpClient sc = new SmtpClient
                    {
                        Port = 587,
                        Timeout = 3600000,
                        Host = Localization.smtp,
                        EnableSsl = true,
                        Credentials = new NetworkCredential(Settings.Default.mail_yeni, Settings.Default.sifre_yeni)
                    };
                    MailMessage mail = new MailMessage
                    {
                        From = new MailAddress(Settings.Default.mail_yeni, Localization.hupt_title)
                    };
                    mail.To.Add(txt_email.Text.ToString());
                    mail.Subject = txttitle.Text; mail.IsBodyHtml = true; mail.Body = txtappeal.Text + " " + txt_isim.Text.ToString() + "," + "<br/> <br/>" + txt_icerik2.Text;
                    mail.Attachments.Clear();
                    if (checkedListBox1.Items.Count != 0)
                    {
                        for (int i = 0; i < checkedListBox1.Items.Count; i++)
                        {
                            if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked)
                            {
                                mail.Attachments.Add(new Attachment(checkedListBox2.Items[i].ToString()));
                            }
                        }
                    }

                    sc.Send(mail);
                }
            }
            catch (SmtpException ex)
            {
                if (lang.Default.language == Localization.turkce)
                {
                    MessageBox.Show("Hata:\n\n" + ex.ToString() + "\n\nAlternatif Öneriler\n\n1. Yüklemeye çalıştığınız dosyaları .rar haline getirip öyle yüklemeyi deneyebilirsiniz. \n\n2. Google, maillerde gönderilebilecek dosya boyutunu azaltmış olabilir. Daha az boyutlu bir biçimde dosyalarınızı yeniden yükleyebilirsiniz.", Localization.mb_hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (lang.Default.language == Localization.english)
                {
                    MessageBox.Show("Error:\n\n" + ex.ToString() + "\n\nAlternative Suggestions\n\n1. You can try to convert the files you are trying to upload to .rar and upload them that way. \n\n2. Google may have reduced the file size that can be sent in emails. You can re-upload your files in a smaller size.", Localization.mb_hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } 
        void filesizecheck()
        {
            if (listBox5.Items.Count == 0)
            {
                lblsize.Text = "0.00 MB";
            }
            else
            {
                double bayt = 0;
                for (int i = 0; i < listBox5.Items.Count; i++)
                {
                    bayt += Convert.ToInt32(listBox5.Items[i].ToString());
                }
                double x = 0.00000095367432;
                double mb = bayt * x;
                mb = Math.Round(mb, 2);

                lblsize.Text = mb + " MB";
            }
        }
        void check1()
        {
            string metin;
            int x = 0;

            for (int i = 0; i < checkedListBox1.Items.Count; i++) 
            {
                if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked)
                {
                    x++;
                    metin = x + Localization.currentcondition2;

                    txt_filecontrol.Text = metin;
                }
                if (checkedListBox1.GetItemCheckState(i) == CheckState.Unchecked)
                {
                    listBox5.Items.RemoveAt(i);
                    checkedListBox2.Items.RemoveAt(i);
                    checkedListBox1.Items.RemoveAt(i);
                    filesizecheck();
                }
            }
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                metin = Localization.currentcondition;

                txt_filecontrol.Text = metin;
            }

            txt_taslak.Text = txt_font_title.Text + txttitle.Text + Environment.NewLine + Environment.NewLine + txt_font_appeal.Text + txtappeal.Text + Localization.symbol2 + Environment.NewLine + Environment.NewLine + txt_font_content.Text + txtcontent.Text + Environment.NewLine + Environment.NewLine + txt_attachedfile.Text + txt_filecontrol.Text;
        }
        void check2()
        {
            string[] bakalim = new string[checkedListBox1.Items.Count];
            for (int f = 0; f < checkedListBox1.Items.Count; f++)
            {
                bakalim[f] = checkedListBox1.Items[f].ToString();
            }
            for (int k = 0; k < checkedListBox1.Items.Count; k++)
            {
                for (int l = 0; l < checkedListBox1.Items.Count; l++)
                {
                    if (bakalim[k] == bakalim[l])
                    {
                        if (k != l) //
                        {
                            MessageBox.Show(Localization.mberrorsameexcelfile + bakalim[k].ToString(), Localization.mb_hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            string[] kontrol3 = new string[checkedListBox1.Items.Count];
                            string[] kontrol4 = new string[checkedListBox2.Items.Count];
                            int[] değer2 = new int[listBox5.Items.Count];
                            for (int h = 0; h < checkedListBox1.Items.Count; h++)
                            {
                                kontrol3[h] = checkedListBox1.Items[h].ToString();
                                kontrol4[h] = checkedListBox2.Items[h].ToString();
                                değer2[h] = Convert.ToInt32(listBox5.Items[h].ToString());
                            }

                            string[] kontrol = kontrol3.Distinct().ToArray();
                            string[] kontrol2 = kontrol4.Distinct().ToArray();
                            int[] değer = değer2.Distinct().ToArray();

                            checkedListBox1.Items.Clear();
                            checkedListBox2.Items.Clear();
                            listBox5.Items.Clear();

                            for (int g = 0; g < kontrol.Length; g++)
                            {
                                checkedListBox1.Items.Add(kontrol[g]);
                                checkedListBox2.Items.Add(kontrol2[g]);
                                listBox5.Items.Add(değer[g]);
                            }

                            filesizecheck();
                        }
                    }
                }
            }

            for (int b = 0; b < checkedListBox1.Items.Count; b++)
            {
                checkedListBox1.SetItemChecked(b, true);
            }
        }
        void checkexcelfile()
        {
            OleDbCommand komut;
            OleDbCommand komut2;
            string vtyolu = Localization.oledbconveri;
            OleDbConnection baglanti = new OleDbConnection(vtyolu);

            for (int a = 0; a < metroGrid1.Rows.Count; a++)
            {
                string isim = metroGrid1.Rows[a].Cells[0].Value.ToString();
                string e_mail = metroGrid1.Rows[a].Cells[1].Value.ToString();


                baglanti.Open();
                string ekle = Localization.addveri;
                komut = new OleDbCommand(ekle, baglanti);
                komut.Parameters.AddWithValue(Localization.name_, isim.ToString());
                komut.Parameters.AddWithValue(Localization.mail_, e_mail.ToString());
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
            }

            for (int b = 0; b < lst_errorlist.Items.Count; b++)
            {
                string h = lst_errorlist.Items[b].ToString();

                baglanti.Open();
                string sil = Localization.deletemail;
                komut2 = new OleDbCommand(sil, baglanti);
                komut2.Parameters.AddWithValue(Localization.mail_, h);
                komut2.ExecuteNonQuery();
                komut2.Dispose();
                baglanti.Close();
            }

            string pathconn = Localization.oledbconveri;
            OleDbConnection conn = new OleDbConnection(pathconn);
            OleDbDataAdapter MyDataAdapter = new OleDbDataAdapter(Localization.selectveri, conn);
            DataTable dt = new DataTable();
            MyDataAdapter.Fill(dt);
            metroGrid1.DataSource = dt;
            designgrid();
            lbl_validatingpeoplecount.Text = metroGrid1.Rows.Count.ToString();

            metroGrid1.ClearSelection();

            baglanti.Open();
            string sil2 = Localization.deleteveri;
            komut2 = new OleDbCommand(sil2, baglanti);
            komut2.ExecuteNonQuery();
            komut2.Dispose();
            baglanti.Close();

            int x = lst_errorlist.Items.Count;

            if (lst_errorlist.Items.Count == 0)
            {
                lst_errorlist.Items.Add(Localization.lst_errorlist1);
            }
            else if (lst_errorlist.Items.Count == 1)
            {
                lst_errorlist.Items.Add(Localization.symbol);
                lst_errorlist.Items.Add(Localization.lst_errorlist2);
            }
            else
            {
                lst_errorlist.Items.Add(Localization.symbol);
                lst_errorlist.Items.Add(x.ToString() + Localization.lst_errorlist3);
            }

            lbl_validatingpeoplecount.Visible = true;

            if (lbl_validatingpeoplecount.Text == Localization.number)
            {
                btn_addfolder.Enabled = false;
                btn_sendmail.Enabled = false;
                MessageBox.Show(Localization.mberrorwrongexcelfile, Localization.mb_hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (lbl_validatingpeoplecount.Text != Localization.number)
            {
                btn_addfolder.Enabled = true;
                btn_sendmail.Enabled = true;
            }
        }
        void addline()
        {
            listBox1.Items.Clear();
            string[] satirlar = new string[txtcontent.Lines.Count()];
            for (int i = 0; i < txtcontent.Lines.Count(); i++)
            {
                satirlar[i] = txtcontent.Lines[i].ToString() + "<br>";
                listBox1.Items.Add(satirlar[i]);
            }
        }
        void designgrid()
        {
            metroGrid1.Columns[0].HeaderText = Localization.headernameandsurname;
            metroGrid1.Columns[1].HeaderText = Localization.headeremail;
            metroGrid1.Columns[0].Width = 137;
            metroGrid1.Columns[1].Width = 180;
        }
        void designcheckbox()
        {
            if (checkedListBox1.Items.Count == 0)
            {
                checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
            else
            {
                checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
        }
        void view()
        {
            btn_getmaillist.Text = Localization.btn_getmaillist;
            lbl_errormail.Text = Localization.lbl_errormail;
            lbl_errormailshow.Text = Localization.lbl_errormailshow;
            lbl_showerrorlist.Text = Localization.lbl_showerrorlist;
            btn_addfolder.Text = Localization.btn_addfolder;
            lbl_currentfolder.Text = Localization.lbl_currentfolder;
            lbl_sendcodeinfo.Text = Localization.lbl_sendcodeinfo;
            btn_sendmail.Text = Localization.btn_sendmail;
            lbl_programinfo.Text = Localization.lbl_programinfo;
            lbl_editingaddress.Text = Localization.lbl_editingaddress;
            lbltotalpeople.Text = Localization.lbltotalpeople;
            lbltotalfile.Text = Localization.lbltotalfile;
            lblwarningaboutsize.Text = Localization.lblwarningaboutsize;
            txttitle.WaterMark = Localization.txttitle;
            txtappeal.WaterMark = Localization.txtappeal;
            txtcontent.WaterMark = Localization.txtcontent;
            txt_font_content.Text = Localization.txt_font_content;
            txt_font_appeal.Text = Localization.txt_font_appeal;
            txt_font_title.Text = Localization.txt_font_title;
            txt_attachedfile.Text = Localization.txt_attachedfile;
            txt_filecontrol.Text = Localization.txt_filecontrol;
            this.Text = Localization._maintext;
            this.Refresh(); //that's work

            txt_taslak.Text = txt_font_title.Text + txttitle.Text + Environment.NewLine + Environment.NewLine + txt_font_appeal.Text + txtappeal.Text + Localization.symbol2 + Environment.NewLine + Environment.NewLine + txt_font_content.Text + txtcontent.Text + Environment.NewLine + Environment.NewLine + txt_attachedfile.Text + txt_filecontrol.Text;
            txt_huptgmail.Text = Settings.Default.mail_yeni;
        }
        void trform()
        {
            lbl_errormail.Size = new Size(127, 19);
            lbl_errormail.Location = new Point(65, 276);

            lblunderlined1.Size = new Size(135, 19);
            lblunderlined1.Location = new Point(61, 279);
            lblunderlined1.Text = "_____________________";

            lbltotalpeople.Size = new Size(221, 19);
            lbltotalpeople.Location = new Point(239, 547);

            lbl_validatingpeoplecount.Size = new Size(16, 19);
            lbl_validatingpeoplecount.Location = new Point(454, 548);

            lbltotalfile.Size = new Size(209, 19);
            lbltotalfile.Location = new Point(579, 547);

            lblsize.Size = new Size(57, 19);
            lblsize.Location = new Point(782, 548);

            lbl_currentfolder.Size = new Size(144, 19);
            lbl_currentfolder.Location = new Point(688, 473);

            lblunderlined2.Size = new Size(151, 13);
            lblunderlined2.Location = new Point(685, 480);
            lblunderlined2.Text = "________________________";
        }
        void enform()
        {
            lbl_errormail.Size = new Size(152, 19);
            lbl_errormail.Location = new Point(52, 276);

            lblunderlined1.Size = new Size(159, 19);
            lblunderlined1.Location = new Point(49, 279);
            lblunderlined1.Text = "_________________________";

            lbltotalpeople.Size = new Size(230, 19);
            lbltotalpeople.Location = new Point(239, 547);

            lbl_validatingpeoplecount.Size = new Size(16, 19);
            lbl_validatingpeoplecount.Location = new Point(463, 548);

            lbltotalfile.Size = new Size(168, 19);
            lbltotalfile.Location = new Point(579, 547);

            lblsize.Size = new Size(57, 19);
            lblsize.Location = new Point(741, 548);

            lbl_currentfolder.Size = new Size(123, 19);
            lbl_currentfolder.Location = new Point(699, 473);

            lblunderlined2.Size = new Size(133, 13);
            lblunderlined2.Location = new Point(694, 480);
            lblunderlined2.Text = "_____________________";
        }

        private void btn_getmaillist_Click(object sender, EventArgs e)
        {
            try
            {
                lst_errorlist.Items.Clear();
                OpenFileDialog openfile1 = new OpenFileDialog
                {
                    Filter = Localization.excelfilter,
                    Title = Localization.exceltitle
                };
                if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.textBox1.Text = openfile1.FileName;
                }

                Excel.Application oXL = new Excel.Application();
                if (textBox1.Text == string.Empty)
                {
                    return;
                }
                else
                {
                    Excel.Workbook oWB = oXL.Workbooks.Open(textBox1.Text);

                    List<string> liste = new List<string>();
                    foreach (Excel.Worksheet oSheet in oWB.Worksheets)
                    {
                        liste.Add(oSheet.Name);
                    }
                    oWB.Close();
                    oXL.Quit();
                    oWB = null;
                    oXL = null;
                    metroGrid2.DataSource = liste.Select(x => new { SayfaAdi = x }).ToList();
                    textBox2.Text = metroGrid2.Rows[0].Cells[0].Value.ToString();

                    OleDbCommand komut = new OleDbCommand();
                    string pathconn = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source=" + textBox1.Text + ";Extended Properties=\"Excel 8.0;HDR= yes;\";";
                    OleDbConnection conn = new OleDbConnection(pathconn);
                    OleDbDataAdapter MyDataAdapter = new OleDbDataAdapter("Select * from [" + textBox2.Text + "$]", conn);
                    DataTable dt = new DataTable();
                    MyDataAdapter.Fill(dt);
                    metroGrid1.DataSource = dt;
                    designgrid();
                    lbl_validatingpeoplecount.Text = metroGrid1.Rows.Count.ToString();

                    metroGrid1.ClearSelection();

                    Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

                    string[] email = new string[metroGrid1.Rows.Count];
                    for (int i = 0; i < metroGrid1.Rows.Count; i++)
                    {
                        email[i] = metroGrid1.Rows[i].Cells[1].Value.ToString();
                        string y = email[i].Trim();
                        email[i] = y.ToString();

                        bool İsValidEmail = regex.IsMatch(email[i]);

                        if (!İsValidEmail)
                        {
                            lst_errorlist.Items.Add(email[i].ToString());
                        }
                    }

                    if (lbl_showerrorlist.Text == Localization.hideerrorlist)
                    {
                        lst_errorlist.Visible = true;
                    }
                    else if (lbl_showerrorlist.Text == Localization.lbl_showerrorlist)
                    {
                        lst_errorlist.Visible = false;
                    }

                    metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
                }

                checkexcelfile();
            }
            catch (Exception)
            {
                MessageBox.Show(Localization.mberroropenexcel, Localization.mb_hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void lbl_showerrorlist_Click(object sender, EventArgs e)
        {
            if (lst3_kutucuk.Items.Count == 0)
            {
                int butonabasissayisi = 0;
                butonabasissayisi++;
                lst3_kutucuk.Items.Add(butonabasissayisi.ToString());

                if (butonabasissayisi % 2 == 0)
                {
                    lbl_showerrorlist.Text = Localization.lbl_showerrorlist;
                    lst_errorlist.Visible = false;
                }
                else
                {
                    lbl_showerrorlist.Text = Localization.hideerrorlist;
                    lst_errorlist.Visible = true;
                    if (lst_errorlist.Items.Count == 0)
                    {
                        lst_errorlist.Items.Add(Localization.lst_errorlist1);
                    }
                }
            }
            else
            {
                int yeni = Convert.ToInt32(lst3_kutucuk.Items.Count.ToString());
                yeni++;
                lst3_kutucuk.Items.Add(yeni.ToString());

                if (yeni % 2 == 0)
                {
                    lbl_showerrorlist.Text = Localization.lbl_showerrorlist;
                    lst_errorlist.Visible = false;
                }
                else
                {
                    lbl_showerrorlist.Text = Localization.hideerrorlist;
                    lst_errorlist.Visible = true;
                    if (lst_errorlist.Items.Count == 0)
                    {
                        lst_errorlist.Items.Add(Localization.lst_errorlist1);
                    }
                }
            }
        }
        private void txttitle_TextChanged(object sender, EventArgs e)
        {
            txt_taslak.Text = txt_font_title.Text + txttitle.Text + Environment.NewLine + Environment.NewLine + txt_font_appeal.Text + txtappeal.Text + Localization.symbol2 + Environment.NewLine + Environment.NewLine + txt_font_content.Text + txtcontent.Text + Environment.NewLine + Environment.NewLine + txt_attachedfile.Text + txt_filecontrol.Text;
        }
        private void txtappeal_TextChanged(object sender, EventArgs e)
        {
            txt_taslak.Text = txt_font_title.Text + txttitle.Text + Environment.NewLine + Environment.NewLine + txt_font_appeal.Text + txtappeal.Text + Localization.symbol2 + Environment.NewLine + Environment.NewLine + txt_font_content.Text + txtcontent.Text + Environment.NewLine + Environment.NewLine + txt_attachedfile.Text + txt_filecontrol.Text;
        }
        private void txtcontent_TextChanged(object sender, EventArgs e)
        {
            addline();
            txt_icerik2.Text = "";
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                txt_icerik2.Text += listBox1.Items[i].ToString();
            }

            txt_taslak.Text = txt_font_title.Text + txttitle.Text + Environment.NewLine + Environment.NewLine + txt_font_appeal.Text + txtappeal.Text + Localization.symbol2 + Environment.NewLine + Environment.NewLine + txt_font_content.Text + txtcontent.Text + Environment.NewLine + Environment.NewLine + txt_attachedfile.Text + txt_filecontrol.Text;
        }
        private void btn_addfolder_Click(object sender, EventArgs e)
        {
            OpenFileDialog myFileDialog = new OpenFileDialog();
            DialogResult dr;
            myFileDialog.Title = Localization.btn_addfolder;
            myFileDialog.InitialDirectory = @"C:";
            myFileDialog.Multiselect = true;
            dr = myFileDialog.ShowDialog();
            string[] fileNames = myFileDialog.FileNames;

            long[] boyut = new long[fileNames.Length];
            for (int i = 0; i < fileNames.Length; i++)
            {
                FileInfo bilgi = new FileInfo(fileNames[i].ToString());
                long boyut2 = bilgi.Length;
                boyut[i] = boyut2;

                listBox5.Items.Add(boyut[i]);
            }

            myFileDialog.CheckFileExists = true;
            myFileDialog.CheckPathExists = true;

            long sinir = 20000000;

            if (dr == DialogResult.OK)
            {
                long toplam = 0;
                long[] dizi2 = new long[listBox5.Items.Count];
                for (int i = 0; i < listBox5.Items.Count; i++)
                {
                    toplam += Convert.ToInt32(listBox5.Items[i].ToString());
                    dizi2[i] = Convert.ToInt32(listBox5.Items[i].ToString());
                }

                if (toplam >= sinir)
                {
                    listBox5.Items.Clear();
                    for (int i = 0; i < dizi2.Length - 1; i++)
                    {
                        listBox5.Items.Add(dizi2[i].ToString());
                    }

                    MessageBox.Show(Localization.mbfilesizeerror, Localization.mberrorsize, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    designcheckbox();
                }
                else
                {
                    string[] dosya = fileNames;

                    for (int i = 0; i < fileNames.Length; i++)
                    {
                        checkedListBox1.Items.Add(dosya[i]);
                        checkedListBox2.Items.Add(dosya[i]);
                    }

                    string[] isimler = new string[checkedListBox1.Items.Count];
                    string[] dosyaadi = new string[checkedListBox1.Items.Count];
                    for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    {
                        isimler[i] = checkedListBox2.Items[i].ToString();
                        string m = TersCevir(isimler[i]);
                        int dur = m.IndexOf(@"\");
                        string ters = m.Substring(0, dur);
                        string düzelt = TersCevir(ters);
                        dosyaadi[i] = düzelt;
                    }

                    checkedListBox1.Items.Clear();
                    checkedListBox2.Items.Clear();

                    for (int i = 0; i < dosyaadi.Length; i++)
                    {
                        checkedListBox1.Items.Add(dosyaadi[i]);
                        checkedListBox2.Items.Add(isimler[i]);
                    }

                    designcheckbox();
                }
            }

            for (int b = 0; b < checkedListBox1.Items.Count; b++)
            {
                checkedListBox1.SetItemChecked(b, true);
            }

            check1();
            check2();
            filesizecheck();
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            check1();
        }
        private void checkedListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            designcheckbox();
        }
        private void btn_sendmail_Click(object sender, EventArgs e)
        {
            if (txtcontent.Text == "" | txtappeal.Text == "" || txttitle.Text == "")
            {
                string[] dizi = { txtcontent.Text, txtappeal.Text, txttitle.Text };
                for (int i = 0; i < 3; i++)
                {
                    if (dizi[i] == "")
                    {
                        if (i == 0)
                        {
                            txtcontent.WaterMark = Localization.txtcontent;
                        }
                        else if (i == 1)
                        {
                            txtappeal.WaterMark = Localization.txtappeal;
                        }
                        else if (i == 2)
                        {
                            txttitle.WaterMark = Localization.txttitle;
                        }
                    }
                }

                MessageBox.Show(Localization.mbfill, Localization.mb_hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialog;
                dialog = MessageBox.Show(Localization.mbbulkmail, Localization.mbcontroltitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    metroLabel8.Visible = true;
                    metroProgressBar1.Visible = true;
                    lbl_sendcodeinfo.Visible = true;

                    if (metroGrid1.Rows.Count == 1)
                    {
                        metroProgressBar1.Value = 10;
                        metroLabel8.Text = Localization.tenpercentage;
                    }
                    this.Refresh();

                    for (int i = 0; i <= metroGrid1.Rows.Count; i++)
                    {
                        if (i == metroGrid1.Rows.Count)
                        {
                            decimal yuzde = ((decimal)(i) / (decimal)metroGrid1.Rows.Count) * 100;
                            Application.DoEvents();
                            metroProgressBar1.Value = (int)yuzde;
                            yuzde = Math.Round(yuzde, 2);
                            metroLabel8.Text = "%" + yuzde.ToString();
                        }
                        else
                        {
                            txt_isim.Text = metroGrid1.Rows[i].Cells[0].Value.ToString();
                            txt_email.Text = metroGrid1.Rows[i].Cells[1].Value.ToString();
                            sendcode();

                            decimal yuzde = ((decimal)(i + 1) / (decimal)metroGrid1.Rows.Count) * 100;
                            Application.DoEvents();
                            metroProgressBar1.Value = (int)yuzde;
                            yuzde = Math.Round(yuzde, 2);
                            metroLabel8.Text = "%" + yuzde.ToString();
                        }
                    }

                    lbl_sendcodeinfo.Visible = false;

                    loading x = new loading();
                    x.Show();
                }

                else
                {
                    MessageBox.Show(Localization.mbnotstart, Localization.errorprocess, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void mail_Load(object sender, EventArgs e)
        {
            if (lang.Default.language == Localization.turkce)
            {
                pict_changelang.Image = Properties.Resources.tr;
                Localization.Culture = new System.Globalization.CultureInfo(Localization.tr);
                lang.Default.language = Localization.turkce;
                lang.Default.Save();
                view();
                trform();
            }
            else if (lang.Default.language == Localization.english)
            {
                pict_changelang.Image = Properties.Resources.en;
                Localization.Culture = new System.Globalization.CultureInfo(Localization.en);
                lang.Default.language = Localization.english;
                lang.Default.Save();
                view();
                enform();
            }
        }
        private void pict_changelang_Click(object sender, EventArgs e)
        {
            if (lang.Default.language == Localization.turkce)
            {
                pict_changelang.Image = Properties.Resources.en;
                Localization.Culture = new System.Globalization.CultureInfo(Localization.en);
                lang.Default.language = Localization.english;
                lang.Default.Save();
                enform();
                view();
            }
            else if (lang.Default.language == Localization.english)
            {
                pict_changelang.Image = Properties.Resources.tr;
                Localization.Culture = new System.Globalization.CultureInfo(Localization.tr);
                lang.Default.language = Localization.turkce;
                lang.Default.Save();
                trform();
                view();
            }
        }
        private void lbl_programinfo_Click(object sender, EventArgs e)
        {
            programinfo x = new programinfo();
            x.Show();
        }
        private void lbl_editingaddress_Click(object sender, EventArgs e)
        {
            changingaddress x = new changingaddress();
            x.Show();
        }
    }
}
