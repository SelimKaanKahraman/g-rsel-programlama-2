using System.Windows.Forms;

namespace AdamAsmaca
{
    public partial class Form1 : Form
    {
        private string kelime; // Seçilen kelime
        private string gizliKelime; // Gösterilecek kelime (altý çizili harfler)
        private List<char> yanlisHarfler = new List<char>(); // Yanlýþ harfler
        private int hataSayisi = 0; // Yanlýþ tahmin sayýsý
        private List<string> kelimeler = new List<string> { "yazilim", "programlama", "muhendislik", "komputer", "developer" ,"harun", "elma","araba","kitap","kalem","masa",
    "bilgisayar","telefon","yazilim","program","muhendis",
    "algoritma","veritabani","yapayzeka","kriptografi",
    "cikolata","dondurma","robot","ninja","ejderha"}; // Bellekteki kelimeler

        public Form1()
        {
            InitializeComponent();
        }

        // Form yüklenince kelimeyi seç ve baþla
        private void Form1_Load(object sender, EventArgs e)
        {
            RastgeleKelimeSec();
            GizliKelimeyiGoster();
            lblYanlisHarfler.Text = "Yanlýþ Harfler: ";
            lblHataSayisi.Text = "Hata Sayýsý: 0";
            pictureBox1.Image = Properties.Resources.adam0;
        }

        // Rastgele bir kelime seç
        private void RastgeleKelimeSec()
        {
            Random rnd = new Random();
            int index = rnd.Next(kelimeler.Count);
            kelime = kelimeler[index];
        }

        // Gizli kelimeyi (altý çizili) ekranda göster
        private void GizliKelimeyiGoster()
        {
            gizliKelime = string.Concat(kelime.Select(c => "_"));
            lblKelime.Text = gizliKelime;
        }

        // Kullanýcý harf tahmini yaptýðýnda çalýþacak
        

        // Gizli kelimeyi güncelle
        private void GizliKelimeyiGuncelle(string harf)
        {
            char[] gizliKelimeArray = gizliKelime.ToCharArray();

            for (int i = 0; i < kelime.Length; i++)
            {
                if (kelime[i] == harf[0])
                {
                    gizliKelimeArray[i] = harf[0];
                }
            }

            gizliKelime = new string(gizliKelimeArray);
            lblKelime.Text = gizliKelime;
        }

        // Yanlýþ harfleri ekle
        private void YanlisHarfEkle(string harf)
        {
            if (!yanlisHarfler.Contains(harf[0]))
            {
                yanlisHarfler.Add(harf[0]);
                lblYanlisHarfler.Text = "Yanlýþ Harfler: " + string.Join(", ", yanlisHarfler);
            }
        }

        // Hata sayýsýný güncelle ve adam asmaca görselini deðiþtir
        private void HataSayisiniGuncelle()
        {
            hataSayisi++;
            lblHataSayisi.Text = "Hata Sayýsý: " + hataSayisi;

            // Her yanlýþta adam asmaca figürünü göster
            switch (hataSayisi)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.bas;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.govde;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.kol1;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.kol2;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.bacak1;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.bacak2;
                    break;
            }
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            string harf = txtHarf.Text.ToLower();

            if (string.IsNullOrEmpty(harf) || harf.Length > 1)
            {
                MessageBox.Show("Lütfen geçerli bir harf girin.");
                return;
            }

            // Eðer harf doðruysa
            if (kelime.Contains(harf))
            {
                GizliKelimeyiGuncelle(harf);
            }
            else
            {
                YanlisHarfEkle(harf);
                HataSayisiniGuncelle();
            }

            // Kazanýp kazanmadýðýný kontrol et
            if (gizliKelime == kelime)
            {
                MessageBox.Show("Tebrikler! Kazandýnýz.");
            }
            else if (hataSayisi >= 6)
            {
                MessageBox.Show("Maalesef Kaybettiniz. Doðru Kelime: " + kelime);
            }

            txtHarf.Clear();
            txtHarf.Focus();
        }
    }
}