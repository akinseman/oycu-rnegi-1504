using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oyun2
{
    public partial class Form1 : Form
    {
        Oyuncu oyuncu1;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnOlustur_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            string rId = random.Next(1000, 10000).ToString();

            //kurucu metotlar new anahtarı ile oluşturma aşamasında çalışır.
            oyuncu1 = new Oyuncu(rId, txtAd.Text, txtSoyad.Text ,txtPosta.Text ,100 ,DateTime.Now ,false);
           


        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            MessageBox.Show(  oyuncu1.BilgiYaz()  );
        }
    }
}
