namespace Bulk_Mailing
{
    class notes
    {
        //using Excel = Microsoft.Office.Interop.Excel; //microsoft office.14.object library, sonra nugetten microsoft office interop'u ekleyip yapacağız
        //bu aynı isimlere ikinci kez mail göndermemeyi ve ayıklatmayı bu programa da aktarayım ya

        //mevcut mail sistemde kalmaya devam ediyor doğrulama kodu hüpt gmail hesabına gönderilmedi (mükemmel olacak bu varya ya; o mail adresi ve şifre değişebilir onu ayarlamak lazım)(ama o kısımda bu kutucukları boş doldurmalarına asla izin verme yoksa kötü olur valla)
        //hatalı mail illaki olacaktır onlara nasıl bir çare bulmak lazım hadi atarken gitti insanlar bilemez ki o durumda ne yapacaklarını
        //klasör gönderebileck mi acaba; her dosya türünden yollayabilecek mi
        //splashscreen yapsam mı ki lan acaba gsgsf
        //yok abi bulamadım valla o progress bar marquee değeri neden öyle oluyor, sanırsam splash screen multithread filan ögrenmem lazım


        //diyelim dosyayı yükledi ve sonra dosyanın ismini değiştirdi, o zaman program hata verecektir yolu bulamadığı için dosyanın dikkat etmek lazım bu tarz programın hata verebileceği ince durumlara(ufak tefek ince detaylar kısmına ekleyelim bunu)

        //Mail İmzası(bunu nasıl ekletebiliriz ki acaba ya bi düşünmek lazım üstüne (acaba otomatik olarak en alta ekleyebilir miyim ki onu bir şekilde

        //Void kodlarının açıklaması aşağıdaki "region" yapısının içinde anlatılmıştır, kafanıza takılan yer olursa oradan faydalanabilirsiniz

        #region
        //A
        /*
         A kısmında dosya yolları alınan metinleri tersten alma ihtiyacı hissettim çünkü insanlar dosya isimlerini uzun uzun yollarıyla değil normal şekillerde görsünler
        diye bu metotu kullandım. Kendim tasarlamadım internetten hazır aldım
         */

        //B
        /*
         B kısmı klasik e mail gönderme kodları ufak tefek eklemelerle; toplu bir şekilde kişilere özel mailler attığımız için bir defa bir void yapısının içinde olması kod yazımı
        için çok daha rahat olacaktır, ekstra olarak dosya gönderimleri için alınan dosya sayısı kadar döndürme yaparak tek mailde birden fazla ek yollayabilme imkanı oluşturmuş
        olduk; ayrıca, timeout özelliğini yazmamız şart çünkü bazen mail gönderimleri eklerin boyutuna bağlı olarak ya da internetin yavaş olabilme durumundan kaynaklı olarak
        uzun sürebilme ihtimali olduğu için bunu 30 dk ya da 300 dk olarak ayarladım sıfırlardan tam emin olamadım ama en az 30 dk her bir mail için garanti ayrılan süre var ki bu süre
        tost makinesinden internete bağlanabilen bir şey için bile yeterli bir süre dsgadsgd

        "Hata Ayıkla > Pencereler > Özel Durum Ayarları > Managed Debugging Assistants" kısmından "ContextSwitchDeadlock" ayarını kapatmayı asla unutmayın çünkü o ayar sayesinde kafamıza
        göre timeout ayarlayabiliyoruz, yoksa gmail bizim göndermeye çalıştığımız maili zaman aşımına uğramış kabul edip hata veriyor kodda hiç bir hata olmamasına rağmen aman dikkat
         */

        //C
        /*
         C kısmı baytı mb'a dönüştürmeye yarayan klasik kodumuz. Dosyaları alırken biz bayt cinsinden alırız e bayt olarak programda kullanıcıya direkt göstermek hoş olmaz
        ondan dolayı bu dönüştürücüye ihtiyaç duydum
         */

        //Ç
        /*
         Ç kısmı tamamen taslak metnimizin daha eşzamanlı gözükmesi adına koydum. Eklediğin çıkardığın her dosya bu kısım sayesinde taslak kısmında ekte şu kadar dosya mevcut
        şeklinde yansıtmaya yarıyor
         */

        //D
        /*
         D kısmı ise aynı eğer eklenirse yanlışlıkla eklerde 2 kere gitmesin diye var. Aynı dosyayı yüklediysen algılıyor ve onu eklere dahil edemeyeceğini çünkü zaten halihazırda eklerde
        bu dosyanın var olduğunu söylüyor
         */

        //E
        /*
         E kısmında Hatalı Mail Adreslerini çıkarmak için veritabanlarından faydalandım; ham halde excelden gride aktarılan her türlü mail burada kontrol edilerek rafine bir şekilde
        geri aynı gridde gözükmesini sağlıyor ve üstelik hatalı maillerin ne olduğunu hangi maillerin çıkartıldığını görüyorsun bu sayede çok çok çok büyük ölçüde mail gönderimi sırasında
        mail formatına aykırı olan maillerin mail gönderimi baltalamasına programın hata vermesinin önüne geçiyorsun

        Programın kilit kısımlarından biridir
         */

        //F
        /*
         F kısmı da programın kilit kısımlarından biridir. Normalde mail gönderirken sen mesajını html textboxlarına yazarsın ve onlar sayfada otomatik olarak satır atlatmayı <br> kodunu
        göstermeden yapabilir ama c# da html textbox olmadığı için program üstünden mail gönderimi yaparken nerede boşluk koyacaksın bunu c# otomatik olarak yapmıyor; bu yüzden enterla alta geçilen
        her satırı bir diziye aktardım ve diziye aktarırken de <br> takısını ekledim bu sayede tıpkı sanki taslak hazırlarken olduğu gibi o <br> taglarını sen yazarken görmüyorsun ama program otomatik olarak
        arkaplanda her satırın sonuna o br takısını ekliyor ve bu sayede mailimiz tam olarak taslak metinde nasıl görüyorsak aynı şekilde aktarılmış oluyor
         */

        //G
        /*
         Anlatılacak bir şey yok ya sadece datagrid(ya da bu metroframework kapsamında metrogrid) sütun başlıkları düzgün gözüksün diye ekledim
         */

        //Ğ
        /*
         * Anlatılacak bir şey yok ya sadece taslak metin için gereken kutucukları birleştirdim
         */

        //H
        /*
         İki tane H bıraktım bilerek çünkü o ikisi birbiriyle gövdeden bağlı, çok basit bir şekilde şifrenin açılıp kapanmasını sağlıyor ama sonradan farkettim ki şifre gözükmemeli
        çünkü topluluğun şifresi gözükmüş olur o şekilde :D o yüzden burayı daha sonra kaldırmak zorunda kaldım ama silmeye de kıyamadım :D

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;

            txt_sifre.PasswordChar = '*';
        }  //H
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;

            txt_sifre.PasswordChar = '\0';
        } //H

         */

        //I
        /*
         Kilit Kısım. Veriler Gride aktarılır ve daha sonrada hatalı olanlar ayıklanır üstteki voidlerin yardımıyla
         */

        //İ
        /*
         Kilit Kısım. Dosyaların eklenmesi/çıkarılması 5 MB geçip geçmediği gibi vb. dosyalarla alakalı tüm kontroller burada üstteki voidlerin yardımıyla
         */

        //J
        /*
         Çok basit şekilde dosyayı çıkarma yöntemi olarak dosyanın üstüne basarsa çıkartırsın şeklinde düşündüm o kadar öteki türlü çok hızlı bakarsa tiksiz kalma ihtimali var
        ona ayrı kod yazmak yerine tek tıklama ile dosyayı kaldırmayı seçtim tıpkı gmail taslaklarında da tek tıkla silindiği gibi
         */

        //K
        /*
         üçü de aynı işlevde, taslak görünüşünü nasıl olur diye ayarlamalarını yaptığım kısımlar
         */

        //L
        /*
         Mail gönderme tuşu, mail gönderimi ile alakalı tüm kontroller burada üstteki voidlerin yardımıyla
         */

        //M
        /*
         Hatalı maillerin görünüp görünmeyeceğini belirten link, eğer görmez istersen tıklarsın eğer görmek istemiyorsan da kapatırsın
         */

        //N
        /*
         Program Kullanım Klavuzunu açan kısım
         */

        /*catch (SmtpFailedRecipientsException)
{
    return;
}
catch (SmtpFailedRecipientException)
{
    return;
}
catch (SmtpException)
{
    MessageBox.Show("Bu hatayı almanızın büyük ihtimalle üç sebebi vardır: \n\n1. Lütfen toplu mail gönderimini gerçekleştireceğiniz gmail hesabının" + @" ""Less Secure Apps"" " + "özelliğinin açık olduğundan emin olunuz(özelliğin linki programın içinde mevcuttur, oraya tıklamanızın ardından otomatik olarak yönlendirileceksiniz).\n(%90) \n\n2. Lütfen toplu mail gönderimini gerçekleştireceğiniz gmail hesabının mail adresini ve şifresini doğru girdiğinizden emin olunuz.\n(%8) \n\nBu ikisini kontrol etmenizin ve doğruluğundan emin olmanızın ardından lütfen mailleri göndermeyi tekrardan deneyiniz. \n\n3. Pek zannetmiyorum ama google ücretsiz mail servis sağlayıcısı desteğini filan kesmişse ya da ayarlarında değişikliğe gitmişse eğer program tost olmuş demektir, yeni bir ücretsiz mail servis sağlayıcısı ayarlamak gerekir programa eğer öyle bir şey söz konusu ise.\n(%2) \n\nBu üçünü kontrol etmenize ve herhangi bir sorun olmadığına emin olmanıza rağmen hala bu hatayı alıyorsanız bulunduğunuz yerde ufak çaplı bir teknolojik kıyamet filan yaşandı herhalde ve siz buna rağmen toplu mail gönderme derdine düştünüz, elektrik ve internet bağlantısı mevcutken 1 maili 1 saatte gönderemeyecek kadar tost değildir internetiniz diye düşünmek istiyorum.\n(≈%0,00....1) \n\nGözümden kaçan başka bir hata durumu da oluşmuş olabilir. Eğer sorun çözülemezse bana" + @" ""muhammettahirtekatli@gmail.com"" " + "mail adresinden lütfen ulaşın.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
catch (Exception)
{
    //hmm bak gmail bile öyle bir mail adresi yok diyor ama yine de gönderildi diyor(doğru, return dedik ya abi onları görürsen takılma diye e programda onları takmadı ve tüm maillerini gönderdiğini söyledi; sonuçta program da kendi içinde haklı çünkü bizim "gönder" dediğimiz tüm mail adreslerine o göndermiş oldu aslında, gönderme dediğimize göndermedi program da haliyle, aferin uslu çocuk :)))
    return;
}
//hmmm try catch hatalarını böyle böyle tanıtmak çok iyi ya, çok lazım oluyor onlar gerçekten çünkü çok işlevseller*/
        #endregion


        //satır sildirme olayına dikkat etmek lazım, yoksa hafızada kalıyor kod

        //her bir mail için yarım saat timeout olmuş oldu böylece, ama try catch ekleyelim yine de bakalım o timeout hatasını ne ile yakalıyorsa artık
        //gönderilen mailler yüzde 99 olarak geri alınamayacaktır bu yüzden işleminizden kesim emin olduktan sonra toplu maili gönderme işleminizi başlatın


        //Yok abi sağlıksız oluyor eğer otomatik olarak program almaya kalkışırsa, hadi iki tane e mail ve isim kısmı oldu filan
        //son seçili kalan tab değerini de silelim herhangi bir tuş üstünde seçili kalmasın
        //abi gerçekten çok saçma; nasıl dizi değer tutamıyor da listbox değer tutabiliyor bu ne sikim iş lan çok aşırı saçma
        //access setupu da kurması gerektiğini söyleyelim programı başka bilgisayara kuracak olanlara, o kurulmadan program çalışmaz çünkü

        //neden less secure app özelliği açık olmak zorunda
        //setupta kaynak dosyaları da yükleyim ve metrogrid temasının yüklenmesi gerektiğinden filan bahsedeyim yoksa tasarım kısmının açılmayacağından filan
        //zip dosyaları kabul edilmiyor sanırım herhalde tüm dosya türlerini denemek lazım hangisine geçiş veriyor diye
        //hmm yani excel başlığı da önemli değil yani önemli olan 1.sütunda isim 2.sütunda ise e mail olması
        #region
        /*f++;

        long toplam2 = 0;
        foreach (long sayi in boyut)
        {
            toplam2 += sayi;
        }

        long[] dizi = new long[f];
        dizi[f - 1] = toplam2;//demek burası tutamıyor degeri
        listBox4.Items.Add(dizi[f - 1]);

        long toplam = 0;
        long[] dizi2 = new long[listBox4.Items.Count];
        for (int i = 0; i < listBox4.Items.Count; i++)
        {
            toplam += Convert.ToInt32(listBox4.Items[i].ToString());
            dizi2[i] = Convert.ToInt32(listBox4.Items[i].ToString());
        }

        if (toplam >= sinir)
        {
            listBox4.Items.Clear();
            for (int i = 0; i < dizi2.Length - 1; i++)
            {
                listBox4.Items.Add(dizi2[i].ToString());
            }

            MessageBox.Show("Toplam dosya boyutu 10 MB'ı aşıyor. Lütfen seçtiğiniz dosyaların toplam 10 MB'ı aşmadığından emin olunuz.", "Dosya Boyutu Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }*/

        #endregion
    }
}
