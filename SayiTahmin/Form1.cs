namespace SayiTahmin
{
    public partial class Form1 : Form
    {

        private int dogruSayi;
        private int hak = 4;
        private Panel[] paneller;

        public Form1()
        {


            InitializeComponent();

            Random rnd = new Random();
            dogruSayi = rnd.Next(1, 101);

            paneller = new Panel[] { panel1, panel2, panel3, panel4 };

            foreach (var p in paneller)
                p.BackColor = Color.Green;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int tahmin;
                if (!int.TryParse(textBox1.Text, out tahmin))
                {
                    MessageBox.Show("Lütfen geçerli bir sayý girin!");
                    return;
                }

                if (tahmin < 1 || tahmin > 100)
                {
                    MessageBox.Show("Sayý 1 ile 100 arasýnda olmalýdýr!");
                    return;
                }

                if (hak > 0)
                {
                    // Hakký kullan
                    hak--;

                    // Paneli kýrmýzý yap
                    paneller[4 - hak - 1].BackColor = Color.Red;

                    if (tahmin == dogruSayi)
                    {
                        label1.Text = "Tebrikler! Doðru sayýyý buldunuz!";
                        
                    }
                    else if (tahmin < dogruSayi)
                    {
                        label1.Text = "Daha yüksek bir sayý söyleyin!";
                    }
                    else
                    {
                        label1.Text = "Daha düþük bir sayý söyleyin!";
                    }

                    if (hak == 0 && tahmin != dogruSayi)
                    {
                        label1.Text = $"Maalesef hakkýnýz bitti! Doðru sayý: {dogruSayi}";
                        
                    }
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Bir hata oluþtu: " + ex.Message);
            }
        }
    }
    }

    

