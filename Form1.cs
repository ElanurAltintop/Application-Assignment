using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemurAtama
{
    public partial class Kayıt : Form
    {
        public Kayıt()
        {
            InitializeComponent();
        }

        private void Kontrol_Click(object sender, EventArgs e)
        {
           
            LblAd.Text = TxtbxAd.Text;
            LblSoyad.Text = TxtbxSoyad.Text;
            LblCnsyt.Text = TxtBxCnsyt.Text;
            LblBranş.Text = TxtbxBrans.Text;
           
        }

        private void Onayla_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sehir = rastgele.Next(1, 82);
            Random değiş = new Random();
            int isim = değiş.Next(1, 10);

            String[] sehirler ={" ","Adana","Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin",
            "Aydın", "Balıkesir","Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale",
            "Çankırı", "Çorum","Denizli","Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum ", "Eskişehir",
            "Gaziantep", "Giresun","Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir",
            "Kars", "Kastamonu", "Kayseri","Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya ", "Malatya",
            "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya",
            "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon  ", "Tunceli", "Şanlıurfa", "Uşak",
            "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt ", "Karaman", "Kırıkkale", "Batman", "Şırnak",
            "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük ", "Kilis", "Osmaniye ", "Düzce"};

            string[] kisiad = new string[10];
            string[] kisisoyad = new string[10];
            for (int i = 1; i < 10; i++)
            {
                LblAd.Text = TxtbxAd.Text;
                LblSoyad.Text = TxtbxSoyad.Text;
                LblCnsyt.Text = TxtBxCnsyt.Text;
                LblBranş.Text = TxtbxBrans.Text;

                kisiad[i] = LblAd.Text;
                kisisoyad[i] = LblSoyad.Text;
            }

            LblAtamaSehir.Text = sehirler[sehir];
            TxtbxAtamaSehir.Text = LblAtamaSehir.Text;
            LblAtamaAd.Text = kisiad[isim];
            TxtbxAtamaAd.Text = LblAtamaAd.Text;
            LblAtamaSoyad.Text = kisisoyad[isim];
            TxtbxAtamaSoyad.Text = LblAtamaSoyad.Text;
            LblAtamaSıra.Text = isim.ToString();
            TxtbxAtamaSıra.Text = LblAtamaSıra.Text;


        }
    }
}
