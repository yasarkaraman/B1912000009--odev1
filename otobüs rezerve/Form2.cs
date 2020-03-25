/****************************************************************************
**                                   SAKARYA ÜNİVERSİTESİ
**                           BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                            BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**                             NESNEYE DAYALI PROGRAMLAMA DERSİ
**                                   2019-2020 BAHAR DÖNEMİ
**
**                               ÖDEV NUMARASI..........:1
**                               ÖĞRENCİ ADI............:Yaşar ozan KARAMAN
**                               ÖĞRENCİ NUMARASI.......:B191200009   
**                               DERSİN ALINDIĞI GRUP...:A
****************************************************************************/
using System;
using System.Drawing;
using System.Windows.Forms;

namespace otobüs_rezerve
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
        }   
         
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 satıs = new Form1();
            satıs.Show();
            this.Hide();
        }

        private void button28_Click(object sender, EventArgs e)
        {
// Aşağıdaki kodlar sayesinde butona basıldığında her ilin enlem ve boylam değerleri comboBoxlardaki seçilen illerin enlem ve boylam bilgileri değişkenlere atanır.

            double tutar,km;
            double enlem1 = 0;
            double boylam1 = 0;
            double enlem2 = 0;
            double boylam2 = 0;
            string secim1 = comboBox1.Text;
            string secim2 = comboBox2.Text;

            if (comboBox1.Text == "Adana")
            {
                enlem1 = 37.00000000;
                boylam1 = 35.32133330;

            }
            else if (comboBox1.Text == "Ankara")
            {
                enlem1 = 39.92077000;
                boylam1 = 32.85411000;
            }

            else if (comboBox1.Text == "Adana")
            {
                enlem1 = 37.00000000;
                boylam1 = 35.32133330;
            }
            else if (comboBox1.Text == "Ankara")
            {
                enlem1 = 39.92077000;
                boylam1 = 32.85411000;
            }
            else if (comboBox1.Text == "Antalya")
            {
                enlem1 = 36.88414000;
                boylam1 = 30.70563000;
            }
            else if (comboBox1.Text == "Aydın")
            {
                enlem1 = 37.84440000;
                boylam1 = 27.84580000;
            }
            else if (comboBox1.Text == "Balıkesir")
            {
                enlem1 = 39.64836900;
                boylam1 = 27.88261000;
            }
            else if (comboBox1.Text == "Bursa")
            {
                enlem1 = 40.18257000;
                boylam1 = 29.06687000;
            }
            else if (comboBox1.Text == "Denizli")
            {
                enlem1 = 37.77652000;
                boylam1 = 29.08639000;
            }
            else if (comboBox1.Text == "Diyarbakır")
            {
                enlem1 = 37.91441000;
                boylam1 = 40.23062900;
            }
            else if (comboBox1.Text == "Erzurum")
            {
                enlem1 = 39.90431890;
                boylam1 = 41.26788530;
            }
            else if (comboBox1.Text == "Eskişehir")
            {
                enlem1 = 39.78430200;
                boylam1 = 30.51922000;
            }
            else if (comboBox1.Text == "Gaziantep")
            {
                enlem1 = 37.06622000;
                boylam1 = 37.38332000;
            }
            else if (comboBox1.Text == "Hatay")
            {
                enlem1 = 36.40184880;
                boylam1 = 36.34980970;
            }
            else if (comboBox1.Text == "İstanbul")
            {
                enlem1 = 41.00527000;
                boylam1 = 28.97696000;
            }
            else if (comboBox1.Text == "İzmir")
            {
                enlem1 = 38.41885000;
                boylam1 = 27.12872000;
            }
            else if (comboBox1.Text == "Kahramanmaraş")
            {
                enlem1 = 37.58333330;
                boylam1 = 36.93333330;
            }
            else if (comboBox1.Text == "Kayseri")
            {
                enlem1 = 38.73333330;
                boylam1 = 35.48333330;
            }
            else if (comboBox1.Text == "Kocaeli")
            {
                enlem1 = 40.85327040;
                boylam1 = 29.88152030;
            }
            else if (comboBox1.Text == "Konya")
            {
                enlem1 = 37.86666670;
                boylam1 = 32.48333330;
            }
            else if (comboBox1.Text == "Malatya")
            {
                enlem1 = 38.35519000;
                boylam1 = 38.30946000;
            }
            else if (comboBox1.Text == "Manisa")
            {
                enlem1 = 38.61909900;
                boylam1 = 27.42892100;
            }
            else if (comboBox1.Text == "Mardin")
            {
                enlem1 = 37.31223610;
                boylam1 = 40.73511200;
            }
            else if (comboBox1.Text == "Mersin")
            {
                enlem1 = 36.80000000;
                boylam1 = 34.63333330;
            }
            else if (comboBox1.Text == "Muğla")
            {
                enlem1 = 37.21527780;
                boylam1 = 28.36361110;
            }
            else if (comboBox1.Text == "Ordu")
            {
                enlem1 = 40.98333330;
                boylam1 = 37.88333330;
            }
            else if (comboBox1.Text == "Sakarya")
            {
                enlem1 = 40.75687930;
                boylam1 = 30.37813800;
            }
            else if (comboBox1.Text == "Samsun")
            {
                enlem1 = 41.29278200;
                boylam1 = 36.33128000;
            }
            else if (comboBox1.Text == "Şanlıurfa")
            {
                enlem1 = 37.15000000;
                boylam1 = 38.80000000;
            }
            else if (comboBox1.Text == "Tekirdağ")
            {
                enlem1 = 40.98333330;
                boylam1 = 27.51666670;
            }
            else if (comboBox1.Text == "Trabzon")
            {
                enlem1 = 41.00000000;
                boylam1 = 39.73333330;
            }
            else if (comboBox1.Text == "Van")
            {
                enlem1 = 39.73333330;
                boylam1 = 43.38000000;
            }
            if (comboBox2.Text == "Adana")
            {
                enlem2 = 37.00000000;
                boylam2 = 35.32133330;

            }
            else if (comboBox2.Text == "Ankara")
            {
                enlem2 = 39.92077000;
                boylam2 = 32.85411000;
            }

            else if (comboBox2.Text == "Adana")
            {
                enlem2 = 37.00000000;
                boylam2 = 35.32133330;
            }
            else if (comboBox2.Text == "Ankara")
            {
                enlem2 = 39.92077000;
                boylam2 = 32.85411000;
            }
            else if (comboBox2.Text == "Antalya")
            {
                enlem2 = 36.88414000;
                boylam2 = 30.70563000;
            }
            else if (comboBox2.Text == "Aydın")
            {
                enlem2 = 37.84440000;
                boylam2 = 27.84580000;
            }
            else if (comboBox2.Text == "Balıkesir")
            {
                enlem2 = 39.64836900;
                boylam2 = 27.88261000;
            }
            else if (comboBox2.Text == "Bursa")
            {
                enlem2 = 40.18257000;
                boylam2 = 29.06687000;
            }
            else if (comboBox2.Text == "Denizli")
            {
                enlem2 = 37.77652000;
                boylam2 = 29.08639000;
            }
            else if (comboBox2.Text == "Diyarbakır")
            {
                enlem2 = 37.91441000;
                boylam2 = 40.23062900;
            }
            else if (comboBox2.Text == "Erzurum")
            {
                enlem2 = 39.90431890;
                boylam2 = 41.26788530;
            }
            else if (comboBox2.Text == "Eskişehir")
            {
                enlem2 = 39.78430200;
                boylam2 = 30.51922000;
            }
            else if (comboBox2.Text == "Gaziantep")
            {
                enlem2 = 37.06622000;
                boylam2 = 37.38332000;
            }
            else if (comboBox2.Text == "Hatay")
            {
                enlem2 = 36.40184880;
                boylam2 = 36.34980970;
            }
            else if (comboBox2.Text == "İstanbul")
            {
                enlem2 = 41.00527000;
                boylam2 = 28.97696000;
            }
            else if (comboBox2.Text == "İzmir")
            {
                enlem2 = 38.41885000;
                boylam2 = 27.12872000;
            }
            else if (comboBox2.Text == "Kahramanmaraş")
            {
                enlem2 = 37.58333330;
                boylam2 = 36.93333330;
            }
            else if (comboBox2.Text == "Kayseri")
            {
                enlem2 = 38.73333330;
                boylam2 = 35.48333330;
            }
            else if (comboBox2.Text == "Kocaeli")
            {
                enlem2 = 40.85327040;
                boylam2 = 29.88152030;
            }
            else if (comboBox2.Text == "Konya")
            {
                enlem2 = 37.86666670;
                boylam2 = 32.48333330;
            }
            else if (comboBox2.Text == "Malatya")
            {
                enlem2 = 38.35519000;
                boylam2 = 38.30946000;
            }
            else if (comboBox2.Text == "Manisa")
            {
                enlem2 = 38.61909900;
                boylam2 = 27.42892100;
            }
            else if (comboBox2.Text == "Mardin")
            {
                enlem2 = 37.31223610;
                boylam2 = 40.73511200;
            }
            else if (comboBox2.Text == "Mersin")
            {
                enlem2 = 36.80000000;
                boylam2 = 34.63333330;
            }
            else if (comboBox2.Text == "Muğla")
            {
                enlem2 = 37.21527780;
                boylam2 = 28.36361110;
            }
            else if (comboBox2.Text == "Ordu")
            {
                enlem2 = 40.98333330;
                boylam2 = 37.88333330;
            }
            else if (comboBox2.Text == "Sakarya")
            {
                enlem2 = 40.75687930;
                boylam2 = 30.37813800;
            }
            else if (comboBox2.Text == "Samsun")
            {
                enlem2 = 41.29278200;
                boylam2 = 36.33128000;
            }
            else if (comboBox2.Text == "Şanlıurfa")
            {
                enlem2 = 37.15000000;
                boylam2 = 38.80000000;
            }
            else if (comboBox2.Text == "Tekirdağ")
            {
                enlem2 = 40.98333330;
                boylam2 = 27.51666670;
            }
            else if (comboBox2.Text == "Trabzon")
            {
                enlem2 = 41.00000000;
                boylam2 = 39.73333330;
            }
            else if (comboBox2.Text == "Van")
            {
                enlem2 = 39.73333330;
                boylam2 = 43.38000000;
            }
            //Aşağıdaki kodlar sayesinde kilometreye bağlı olarak tutar bulunur ve küsüratı atılır.
            km = Kmhesap(enlem1, boylam1, enlem2, boylam2);
            tutar = km/ 7;
            tutar = Math.Round(tutar, 0);
            //Aşağıdaki kodlarda tutar kısmına radiobuttonlarda tekyön seçildiğinde tutarın kendisi gidiş-dönüş seçildiğinde tutarın 2 katının yazılması sağlanmıştır.
            if (radioButton1.Checked == true)
            {
                label6.Text =tutar.ToString();
            }
            if (radioButton2.Checked == true)
            {
                tutar = tutar * 2;
                label6.Text = tutar.ToString();
            }

        }
        // Aşağıdaki fonksiyon sayesinde atanan değerler ile kilometre hesabı yapılıyor
            static Double Kmhesap(double firstLat, double firstLng, double secondLat, double secondLng)
            {
            
            int Rk = 6373;

            double lat1, lon1, lat2, lon2, dlat, dlon, a, c,  dk, km;

                lat1 = firstLat * Math.PI / 180;
                lon1 = firstLng * Math.PI / 180;
                lat2 = secondLat * Math.PI / 180;
                lon2 = secondLng * Math.PI / 180;

                dlat = lat2 - lat1;
                dlon = lon2 - lon1;

                a = Math.Pow(Math.Sin(dlat / 2), 2) + Math.Cos(lat1) * Math.Cos(lat2) * Math.Pow(Math.Sin(dlon / 2), 2);
                c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
                dk = c * Rk;
                km = Math.Round(dk, 3);
                Console.WriteLine(km.ToString());
            return km;
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
               
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            

            
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
          
        }
        private void label6_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_2(object sender, EventArgs e)
        {  //Aşağıdaki kodda ad,soyad ve telefon bilgileri listboxda yer alır.
            listBox1.Items.Add(textBox1.Text + " " + textBox2.Text+" "+textBox3.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Form1 satıs = new Form1();
            satıs.Show();
            this.Hide();
        }

      
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        //Aşağıdaki kodlarda herbir koltuk butonuna cinsiyetine göre renk almasını sağlayan kodlar yazılmıştır.
        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button6.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button6.BackColor = Color.Red;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button10.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button10.BackColor = Color.Red;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button14.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button14.BackColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button3.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button3.BackColor = Color.Red;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button2.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button2.BackColor = Color.Red;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button5.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button5.BackColor = Color.Red;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button4.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button4.BackColor = Color.Red;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button7.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button7.BackColor = Color.Red;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button8.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button8.BackColor = Color.Red;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button9.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button9.BackColor = Color.Red;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button12.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button12.BackColor = Color.Red;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button13.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button13.BackColor = Color.Red;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button16.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button16.BackColor = Color.Red;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button17.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button17.BackColor = Color.Red;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button11.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button11.BackColor = Color.Red;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button15.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button15.BackColor = Color.Red;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button20.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button20.BackColor = Color.Red;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button21.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button21.BackColor = Color.Red;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button24.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button24.BackColor = Color.Red;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button25.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button25.BackColor = Color.Red;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.BackColor = Color.Blue; if (radioButton4.Checked == true)
            {
                button18.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button18.BackColor = Color.Red;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button19.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button19.BackColor = Color.Red;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button22.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button22.BackColor = Color.Red;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button23.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button23.BackColor = Color.Red;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button26.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button26.BackColor = Color.Red;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button27.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button27.BackColor = Color.Red;
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }
    }
}
