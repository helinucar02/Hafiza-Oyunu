namespace Hafıza_Oyunu
{
    public partial class Form1 : Form
    {
        List<string> semboller = new List<string>()
        {
           "❤️", "✅", "✨", "🔥",
           "⭐", "🎉", "👍🏻", "🥀",
           "🍒", "🍌", "🍞", "🧀",
           "☕", "🍮", "🍹", "🍽️",
           "🥦", "🍇", "🍉", "🍦"
        };
        Button ilkSecilen = null;
        Button ikinciSecilen = null;

        int sure = 0;
        bool tiklamaEngeli = false;

        System.Windows.Forms.Timer eslesmeKontrolZamani = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
            sembolleriKaristir();
            butonlaraSembolAta();
            eslesmeKontrolZamani.Interval = 750;
            eslesmeKontrolZamani.Tick += eslesmeKontrolZamani_Tick;
            sureSayaci.Interval = 5000;
            sureSayaci.Tick += sureSayaci_Tick;
            sureSayaci.Start();
            
        }
        private void sembolleriKaristir()
        {
            semboller.AddRange(semboller);
            Random rnd = new Random();
            semboller = semboller.OrderBy(x => rnd.Next()).ToList();
        }
        private void butonlaraSembolAta()
        {
            int i = 0;

            foreach (Control kontrol in tableLayoutPanel1.Controls)
            {
                if (kontrol is Button)
                {
                    Button btn = (Button)kontrol;
                    btn.Font = new Font(FontFamily.GenericSansSerif, 24, FontStyle.Bold);
                    btn.Tag = semboller[i];
                    btn.Click += KartTiklandi;
                    i++;
                }
            }
        }
        private void KartTiklandi(object sender, EventArgs e)
        {
            if (tiklamaEngeli)
            {
                return;
            }
            Button tiklanan = sender as Button;

            if (tiklanan == null || tiklanan.Text != "?")
            {
                return;
            }

            tiklanan.Text = tiklanan.Tag.ToString();

            if (ilkSecilen == null)
            {
                ilkSecilen = tiklanan;
            }
            else
            {
                ikinciSecilen = tiklanan;
                tiklamaEngeli= true;
                eslesmeKontrolZamani.Start();
            }
        }
        int skorKagıt=0;
        private void eslesmeKontrolZamani_Tick(object sender, EventArgs e)
        {
            eslesmeKontrolZamani.Stop();

            if (ilkSecilen.Tag.ToString() == ikinciSecilen.Tag.ToString())
            {
                skorKagıt++;
                ilkSecilen.Enabled = false;
                ikinciSecilen.Enabled = false;
            }
            else
            {
                ilkSecilen.Text = "?";
                ikinciSecilen.Text = "?";
            }
            ilkSecilen = null;
            ikinciSecilen = null;

            oyunBitirmeKontrolu();
            tiklamaEngeli = false;
        }
        private void oyunBitirmeKontrolu()
        {
            foreach (Control kontrol in tableLayoutPanel1.Controls)
            {
                if (kontrol is Button && kontrol.Enabled)
                {
                    return;
                }
            }
            MessageBox.Show("Tebrikler tüm eşleşmeleri doğru yaptınız.");
            sureSayaci.Stop();
            btnSkoruKaydet.Enabled = true;
            MessageBox.Show("Tebrikler skorunuz kaydetmek için butona tıklayın !");

        }
        private void sureSayaci_Tick(object sender, EventArgs e)
        {
            sure++;
            lblSure.Text = "Süre : " + sure + "sn";
            if (sure==0)
            {
                MessageBox.Show("Süre bitti! Oyunu yeniden başlatın..");
            }
        }

        private void btnSkoruKaydet_Click(object sender, EventArgs e)
        {
           
            string skor = sure+"sn = " + DateTime.Now.ToShortTimeString()+"Eş Skoru: "+skorKagıt;
            lstSkorlar.Items.Add(skor);
        }

        private void btnYenidenBaslat_Click(object sender, EventArgs e)
        {
            sure = 0;
            lblSure.Text = "Süre : 0sn";
            sureSayaci.Start();

            ilkSecilen = null;
            ikinciSecilen = null;

            sembolleriKaristir();

            //tüm butonları temizle ve yine ata
            int i = 0;
            foreach (Control kontrol in tableLayoutPanel1.Controls)
            {
                if (kontrol is Button)
                {
                    Button btn = (Button)kontrol;
                    btn.Enabled = true;
                    btn.Text = "?";
                    btn.Tag = semboller[i];
                    i++;
                }
            }
        }
        private void btnOyunuKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();//UYgulamayı komple kapatıyor
            //this.Close(); //Sadece bu formu kapatıyor
        }
    }
}

