using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassaParola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruNo = 0, dogru = 0, yanlıs = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruNo) 
                {
                    case 1:
                        if (textBox1.Text == "akdeniz")
                        {
                            btnA.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();

                        }
                        else
                        {
                            btnA.BackColor = Color.Red;
                            yanlıs++;
                            lblYanlis.Text = dogru.ToString();

                        }
                        break;

                    case 2:
                        if (textBox1.Text=="bursa")
                        {
                            btnB.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnB.BackColor = Color.Red;
                            yanlıs++;
                            lblYanlis.Text = dogru.ToString();
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            btnC.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnC.BackColor = Color.Red;
                            yanlıs++;
                            lblYanlis.Text = dogru.ToString();
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            btnD.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnD.BackColor = Color.Red;
                            yanlıs++;
                            lblYanlis.Text = dogru.ToString();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            btnE.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnE.BackColor = Color.Red;
                            yanlıs++;
                            lblYanlis.Text = dogru.ToString();
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            btnF.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnF.BackColor = Color.Red;
                            yanlıs++;
                            lblYanlis.Text = dogru.ToString();
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            btnG.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnG.BackColor = Color.Red;
                            yanlıs++;
                            lblYanlis.Text = dogru.ToString();
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "hamal")
                        {
                            btnH.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnH.BackColor = Color.Red;
                            yanlıs++;
                            lblYanlis.Text = dogru.ToString();
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "hamal")
                        {
                            btnH.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnH.BackColor = Color.Red;
                            yanlıs++;
                            lblYanlis.Text = dogru.ToString();
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "imdat")
                        {
                            btniii.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btniii.BackColor = Color.Red;
                            yanlıs++;
                            lblYanlis.Text = dogru.ToString();
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "jandarma")
                        {
                            btnJ.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnJ.BackColor = Color.Red;
                            yanlıs++;
                            lblYanlis.Text = dogru.ToString();
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "kayısı")
                        {
                            btnK.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnK.BackColor = Color.Red;
                            yanlıs++;
                            lblYanlis.Text = dogru.ToString();
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "lale")
                        {
                            btnL.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnL.BackColor = Color.Red;
                            yanlıs++;
                            lblYanlis.Text = dogru.ToString();
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "mart")
                        {
                            btnM.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnM.BackColor = Color.Red;
                            yanlıs++;
                            lblYanlis.Text = dogru.ToString();
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "ney")
                        {
                            btnN.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnN.BackColor = Color.Red;
                            yanlıs++;
                            lblYanlis.Text = dogru.ToString();
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "ozan")
                        {
                            btnO.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnO.BackColor = Color.Red;
                            yanlıs++;
                            lblYanlis.Text = dogru.ToString();
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "parmak")
                        {
                            btnP.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnP.BackColor = Color.Red;
                            yanlıs++;
                            lblYanlis.Text = dogru.ToString();
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "ramazan")
                        {
                            btnR.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnR.BackColor = Color.Red;
                            yanlıs++;
                            lblYanlis.Text = dogru.ToString();
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "snake")
                        {
                            btnS.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnS.BackColor = Color.Red;
                            yanlıs++;
                            lblYanlis.Text = dogru.ToString();
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "tarkan")
                        {
                            btnT.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnT.BackColor = Color.Red;
                            yanlıs++;
                            lblYanlis.Text = dogru.ToString();
                        }
                        break;
                    case 21:
                        if (textBox1.Text == "umut")
                        {
                            btnU.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnU.BackColor = Color.Red;
                            yanlıs++;
                            lblYanlis.Text = dogru.ToString();
                        }
                        break;
                    case 22:
                        if (textBox1.Text == "van")
                        {
                            btnV.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnV.BackColor = Color.Red;
                            yanlıs++;
                            lblYanlis.Text = dogru.ToString();
                        }
                        break;
                    case 23:
                        if (textBox1.Text == "yıldırım")
                        {
                            btnY.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnY.BackColor = Color.Red;
                            yanlıs++;
                            lblYanlis.Text = dogru.ToString();
                        }
                        break;
                    case 24:
                        if (textBox1.Text == "zeytin")
                        {
                            btnZ.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnZ.BackColor = Color.Red;
                            yanlıs++;
                            lblYanlis.Text = dogru.ToString();
                        }
                        break;

                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sıradaki Soru";
            soruNo++;
            this.Text = soruNo.ToString();

            if (soruNo==1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi?";
                btnA.BackColor = Color.Yellow;

            }
            if (soruNo==2)
            {
                richTextBox1.Text = "Yeşilliği ile Ünlü Marmara bölgesi";
                btnB.BackColor = Color.Yellow;

            }
            if (soruNo==3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü";
                btnC.BackColor = Color.Yellow;

            }
            if (soruNo == 4)
            {
                richTextBox1.Text = "Karpuzu İle ünlü ilimiz";
                btnD.BackColor = Color.Yellow;

            }
            if (soruNo == 5)
            {
                richTextBox1.Text = "Yenin zıt anlamlısı";
                btnE.BackColor = Color.Yellow;

            }
            if (soruNo == 6)
            {
                richTextBox1.Text = "Padişahların Emirlerinin yazılı hali";
                btnF.BackColor = Color.Yellow;

            }
            if (soruNo == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı";
                btnG.BackColor = Color.Yellow;

            }
            if (soruNo == 8)
            {
                richTextBox1.Text = "Para Karşılığı yük taşıyan kişi";
                btnH.BackColor = Color.Yellow;

            }
            if (soruNo == 9)
            {
                richTextBox1.Text = "Gülü ile ünlü ilimiz";
                btnI.BackColor = Color.Yellow;

            }
            if (soruNo == 10)
            {
                richTextBox1.Text = "Yardım Kelimesi";
                btniii.BackColor = Color.Yellow;

            }
            if (soruNo == 11)
            {
                richTextBox1.Text = "Akeri bir birim";
                btnJ.BackColor = Color.Yellow;

            }
            if (soruNo == 12)
            {
                richTextBox1.Text = "Malatyanın meşhur meyvesi";
                btnK.BackColor = Color.Yellow;

            }
            if (soruNo == 13)
            {
                richTextBox1.Text = "Her yıl bahar aylarında düzenlenen meşhur çiçek festivali";
                btnL.BackColor = Color.Yellow;

            }
            if (soruNo == 14)
            {
                richTextBox1.Text = "Yılın 3. ayı";
                btnM.BackColor = Color.Yellow;

            }
            if (soruNo == 15)
            {
                richTextBox1.Text = "Üflemeli bir müzik aleti ";
                btnN.BackColor = Color.Yellow;

            }
            if (soruNo == 16)
            {
                richTextBox1.Text = "Halk şairi";
                btnO.BackColor = Color.Yellow;

            }
            if (soruNo == 17)
            {
                richTextBox1.Text = "Vücut uzvu";
                btnP.BackColor = Color.Yellow;

            }
            if (soruNo == 18)
            {
                richTextBox1.Text = "11 ayın sultanı";
                btnR.BackColor = Color.Yellow;

            }
            if (soruNo == 19)
            {
                richTextBox1.Text = "İngilizcede yılan";
                btnS.BackColor = Color.Yellow;

            }
            if (soruNo == 20)
            {
                richTextBox1.Text = "Türkiyenin mega starı";
                btnT.BackColor = Color.Yellow;

            }
            if (soruNo == 21)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı";
                btnU.BackColor = Color.Yellow;

            }
            if (soruNo == 22)
            {
                richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz";
                btnV.BackColor = Color.Yellow;

            }
            if (soruNo == 23)
            {
                richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı";
                btnY.BackColor = Color.Yellow;

            }
            if (soruNo == 24)
            {
                richTextBox1.Text = "Ege bölgesinde en çok çıkan tarım ürünü ";
                btnZ.BackColor = Color.Yellow;

            }
           
            
        }
    }
}
