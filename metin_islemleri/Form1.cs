using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metin_islemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //metnin karakter sayısını bulma
            
            string meyve = "      kiraz     ";
           MessageBox.Show( meyve.Trim());
            int sayi = meyve.Length;
            MessageBox.Show(sayi.ToString());

            //seçilen indexleri gösterir ilki kaçıncı indis ikinci kısım kaç tane kelime olacağını belirler

            MessageBox.Show(meyve.Substring(1,2));


            

           

            //karakteri farklı bir karakterle değişitirir

            string replaceDeger= meyve.Replace('i', 'a');
            MessageBox.Show(replaceDeger);




            // belli indexten başlayarak belirtilen sayı kadar karakter silme

            string yeniMeyve = meyve.Remove(3, 2);
            MessageBox.Show(yeniMeyve.ToString());
           

            // bir karakterden istenilen sayı kadar yazdırmak
            

            //string a = new string('a',6);
            //MessageBox.Show(a);

        }

        private void btnTikla_Click(object sender, EventArgs e)
        {
            string alfabe = "A B C Ç D E F G Ğ H I İ J K L M N O Ö P R S Ş T U Ü V Y Z";
            alfabe = alfabe.Replace(" ", "");
            //char[] harfler = alfabe.ToCharArray();
            string[] harfler = new string[28];

            for (int i = 0; i < harfler.Length; i++)
            {
                harfler[i]= alfabe.Substring(i,1);
                lstAlfabe.Items.Add(harfler[i].ToString());
            }

            
        }
    }
}
