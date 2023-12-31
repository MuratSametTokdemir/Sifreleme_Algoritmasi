using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Sifreleme_Algoritması
{
    public partial class Form1 : Form
    {
        string karakter = "0A1.2B,3C:4D;5E'6F!7G<8H>9I|J^K#L+M$N%O&P/R=S?T-U_V~YÆZsß";//57
        int k;

        public Form1()
        {
            InitializeComponent();
        }

       

        private void button_sifrele_Click_1(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(text_a.Text);
            int b = Convert.ToInt32(text_b.Text);
            int c = Convert.ToInt32(text_c.Text);
            string z;
            string harf = text_sifrelenecekmetin.Text.ToUpper();
            text_sifrelenecekmetin.Text = harf;

            for (int i = 0; i < text_sifrelenecekmetin.TextLength; i++)
            {
                if (karakter.IndexOf(text_sifrelenecekmetin.Text[i]) == -1)
                {
                    text_sifrelimetin.Text += text_sifrelenecekmetin.Text[i].ToString();
                }

                else
                {

                    k = karakter.IndexOf(text_sifrelenecekmetin.Text[i]);
                    z = karakter[(((a*k) + (b*k) + c ) % 57)].ToString();

                    text_sifrelimetin.Text += z;

                }

               
            }
        }

        private void buton_sifrecoz_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(text_a.Text);
            int b = Convert.ToInt32(text_b.Text);
            int c = Convert.ToInt32(text_c.Text);
            string  y;
            string harfkucuk = text_cozumlenecekmetin.Text.ToLower();
            text_sifrelenecekmetin.Text = harfkucuk;

            

            for (int j =0;j< text_cozumlenecekmetin.TextLength;j++)
            {
                if (karakter.IndexOf(text_cozumlenecekmetin.Text[j]) == -1)
                {
                    text_cozumlenmismetin.Text += text_cozumlenecekmetin.Text[j].ToString();
                }

                else
                {
                    
                    k = karakter.IndexOf(text_cozumlenecekmetin.Text[j]);
                    int x;
                    if(k -c < 0)
                    {
                        k = k + 57 ;
                    }
                    x = k - c;
                    
                    y = karakter[(((x)/(a+b))% 57)].ToString();
                    text_cozumlenmismetin.Text += y;
                }
            }

           
        }

        
    }
        
    
}

