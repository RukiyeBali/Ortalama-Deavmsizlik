using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ortalama_Hesaplama_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            double ortalama, devamsizlik;  // Değişkenler oluşturuldu.
            ortalama = Convert.ToDouble(txtOrtalama.Text);     // Değişkenlere değer verilir.
            devamsizlik = Convert.ToDouble(txtDevamsizlik.Text); // Değişkenlere değer verilir.

            if(ortalama >=50 && devamsizlik <10) // ortalama 50 ve 50 üstü ve devamsızlık 10 dan küçük ise.
            {
                lblSonuc.Text = "Sonuç: Geçti";  // Sonucu yazdırır.
            }
            else // Yukarıdakiler Değilse.
            {
                lblSonuc.Text = "Sonuç: Kaldı"; // Sonucu yazdırır.

            }


            

            

            


            




        }
    }
}
