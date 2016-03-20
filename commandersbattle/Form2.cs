using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace commandersbattle
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       public string oynayan;
        public string [] b = new string[46];
        public string[] k = new string[46];
        public int[] arb = new int[57];//45 tanesi kullanılıyor, gerisi bir hatayı gidermek için eklendi.
        public int[] drb = new int[57];//45 tanesi kullanılıyor, gerisi bir hatayı gidermek için eklendi.
        public int sutun = 0,satir=0,basla=0, tur=1;
        public int o1, o2, o3, o4 = 8; //oyuncuların kare sayıları
        public string kazanan="hiçkimse";
        public bool boya = true;

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics cizgi, kare;
            Pen kalem = new Pen(Color.Black, 5);
            SolidBrush kirmizi = new SolidBrush(Color.Red);
            SolidBrush mavi = new SolidBrush(Color.Blue);
            SolidBrush sari = new SolidBrush(Color.Yellow);
            SolidBrush yesil = new SolidBrush(Color.Green);
            SolidBrush beyaz = new SolidBrush(Color.White);

            kare = this.CreateGraphics();

            if (basla == 0)//Oyun basladığında boyanacak sadece
            {
                kare.FillRectangle(kirmizi, 0, 0, 400, 200);
                kare.FillRectangle(sari, 0, 300, 400, 200);
                kare.FillRectangle(mavi, 500, 0, 400, 200);
                kare.FillRectangle(yesil, 500, 300, 400, 200);


                int a = 0; //Çizgiler
                cizgi = this.CreateGraphics();
                for (int i = 1; i < 11; i++)
                {
                    cizgi.DrawLine(kalem, a, 0, a, 500);
                    a += 100;
                }
                a = 0;
                for (int i = 1; i < 7; i++)
                {
                    cizgi.DrawLine(kalem, 0, a, 900, a);
                    a += 100;
                }//Çizgiler son 
            }
            else
            {
                if (boya == true)
                {
                    for (int i = 1; i < 46; i++)//Kareleri tek tek boyayan kodlar
                    {
                        //if (k[i] != b[i])//kare en baştakine göre el değiştirmişse çalışır, oyunu hızlandırıyor
                        {
                            if (b[i] == "o1")//Kırmızı
                            {
                                if (i == 9 || i == 18 || i == 27 || i == 36 || i == 45)//hangi sütun olduğunu bulan kod
                                    sutun = 9;
                                else
                                    sutun = i % 9;

                                if (i <= 9) satir = 1;//hangi satır olduğunu bulan kod
                                else if (i <= 18) satir = 2;
                                else if (i <= 27) satir = 3;
                                else if (i <= 36) satir = 4;
                                else if (i <= 45) satir = 5;

                                kare.FillRectangle(kirmizi, sutun * 100 - 100, satir * 100 - 100, 100, 100); //seçilen satır ve sütunun karesini boyama

                            }
                            if (b[i] == "o2")//Sarı
                            {
                                if (i == 9 || i == 18 || i == 27 || i == 36 || i == 45)
                                    sutun = 9;
                                else
                                    sutun = i % 9;
                                if (i <= 9) satir = 1;
                                else if (i <= 18) satir = 2;
                                else if (i <= 27) satir = 3;
                                else if (i <= 36) satir = 4;
                                else if (i <= 45) satir = 5;

                                kare.FillRectangle(sari, sutun * 100 - 100, satir * 100 - 100, 100, 100);

                            }
                            if (b[i] == "o3")//mavi
                            {
                                if (i == 9 || i == 18 || i == 27 || i == 36 || i == 45)
                                    sutun = 9;
                                else
                                    sutun = i % 9;
                                if (i <= 9) satir = 1;
                                else if (i <= 18) satir = 2;
                                else if (i <= 27) satir = 3;
                                else if (i <= 36) satir = 4;
                                else if (i <= 45) satir = 5;

                                kare.FillRectangle(mavi, sutun * 100 - 100, satir * 100 - 100, 100, 100);

                            }
                            if (b[i] == "o4")//Yeşil
                            {
                                if (i == 9 || i == 18 || i == 27 || i == 36 || i == 45)
                                    sutun = 9;
                                else
                                    sutun = i % 9;
                                if (i <= 9) satir = 1;
                                else if (i <= 18) satir = 2;
                                else if (i <= 27) satir = 3;
                                else if (i <= 36) satir = 4;
                                else if (i <= 45) satir = 5;

                                kare.FillRectangle(yesil, sutun * 100 - 100, satir * 100 - 100, 100, 100);

                            }
                            if (b[i] == "o5")//Beyaz
                            {
                                if (i == 9 || i == 18 || i == 27 || i == 36 || i == 45)
                                    sutun = 9;
                                else
                                    sutun = i % 9;
                                if (i <= 9) satir = 1;
                                else if (i <= 18) satir = 2;
                                else if (i <= 27) satir = 3;
                                else if (i <= 36) satir = 4;
                                else if (i <= 45) satir = 5;

                                kare.FillRectangle(beyaz, sutun * 100 - 100, satir * 100 - 100, 100, 100);
                            }


                            int a = 0; //Çizgiler
                            cizgi = this.CreateGraphics();
                            for (int r = 1; r < 11; r++)
                            {
                                cizgi.DrawLine(kalem, a, 0, a, 500);
                                a += 100;
                            }
                            a = 0;
                            for (int z = 1; z < 7; z++)
                            {
                                cizgi.DrawLine(kalem, 0, a, 900, a);
                                a += 100;
                            }//Çizgiler son
                        }
                    }
                }
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void turson_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            //Saldıracak ordu
                if (checkBox1.Checked == true)arb[ 1] = 1;
                if (checkBox2.Checked == true) arb[ 2] = 2;
                if (checkBox3.Checked == true) arb[3 ] = 3;
                if (checkBox4.Checked == true) arb[ 4] = 4;
                if (checkBox5.Checked == true) arb[5 ] = 5;
                if (checkBox6.Checked == true) arb[ 6] = 6;
                if (checkBox7.Checked == true) arb[ 7] = 7;
                if (checkBox8.Checked == true) arb[ 8] = 8;
                if (checkBox9.Checked == true) arb[ 9] = 9;
                if (checkBox10.Checked == true) arb[10 ] = 10;
                if (checkBox11.Checked == true) arb[ 11] = 11;
                if (checkBox12.Checked == true) arb[ 12] = 12;
                if (checkBox13.Checked == true) arb[ 13] = 13;
                if (checkBox14.Checked == true) arb[ 14] = 14;
                if (checkBox15.Checked == true) arb[ 15] = 15;
                if (checkBox16.Checked == true) arb[ 16] = 16;
                if (checkBox17.Checked == true) arb[ 17] = 17;
                if (checkBox18.Checked == true) arb[ 18] = 18;
                if (checkBox19.Checked == true) arb[ 19] = 19;
                if (checkBox20.Checked == true) arb[ 20] = 20;
                if (checkBox21.Checked == true) arb[ 21] = 21;
                if (checkBox22.Checked == true) arb[ 22] = 22;
                if (checkBox23.Checked == true) arb[ 23] = 23;
                if (checkBox24.Checked == true) arb[ 24] = 24;
                if (checkBox25.Checked == true) arb[ 25] = 25;
                if (checkBox26.Checked == true) arb[ 26] = 26;
                if (checkBox27.Checked == true) arb[ 27] = 27;
                if (checkBox28.Checked == true) arb[ 28] = 28;
                if (checkBox29.Checked == true) arb[ 29] = 29;
                if (checkBox30.Checked == true) arb[ 30] = 30;
                if (checkBox31.Checked == true) arb[ 31] = 31;
                if (checkBox32.Checked == true) arb[ 32] = 32;
                if (checkBox33.Checked == true) arb[ 33] = 33;
                if (checkBox34.Checked == true) arb[ 34] = 34;
                if (checkBox35.Checked == true) arb[ 35] = 35;
                if (checkBox36.Checked == true) arb[ 36] = 36;
                if (checkBox37.Checked == true) arb[ 37] = 37;
                if (checkBox38.Checked == true) arb[ 38] = 38;
                if (checkBox39.Checked == true) arb[ 39] = 39;
                if (checkBox40.Checked == true) arb[ 40] = 40;
                if (checkBox41.Checked == true) arb[ 41] = 41;
                if (checkBox42.Checked == true) arb[ 42] = 42;
                if (checkBox43.Checked == true) arb[ 43] = 43;
                if (checkBox44.Checked == true) arb[ 44] = 44;
                if (checkBox45.Checked == true) arb[ 45] = 45;

                for (int i = 1; i < 46; i++)//Seçilen toprak o1'in mi?
                {
                        if (oynayan == "o1" && b[i] == "o1" && arb[i] == i)//Arb 0 değilse seçilmiş demektir.
                        {
                            button2.Visible = true;
                            button3.Visible = true;
                            turson.Visible = false;
                            break;
                        }
                        else if (oynayan == "o2" && b[i] == "o2" && arb[i] == i)
                        {
                            button2.Visible = true;
                            button3.Visible = true;
                            turson.Visible = false;
                            break;
                        }
                        else if (oynayan == "o3" && b[i] == "o3" && arb[i] == i)
                        {
                            button2.Visible = true;
                            button3.Visible = true;
                            turson.Visible = false;
                            break;
                        }
                        else if (oynayan == "o4" && b[i] == "o4" && arb[i] == i)
                        {
                            button2.Visible = true;
                            button3.Visible = true;
                            turson.Visible = false;
                            break;
                        }
                       else if(i==45)
                        {
                            MessageBox.Show("Ordunuzu sadece kendi topraklarınızdan seçebilirsiniz.");
                            sıfırlama();
                            break;
                        }
                }

                //Kaç checkbox'ın seçili olduğunu gösteren kod
                int sayac = 0;
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    if (Controls[i] is CheckBox)
                    {
                        if (((CheckBox)Controls[i]).Checked) sayac++;
                    }
                    label11.Text = sayac.ToString();
                }

            chechboxsıfırlama();
        }

        public void chechboxsıfırlama()
            {
                         //Chechbox sıfırlama
                        checkBox1.Checked = false;
                        checkBox2.Checked = false;
                        checkBox3.Checked = false;
                        checkBox4.Checked = false;
                        checkBox5.Checked = false;
                        checkBox6.Checked = false;
                        checkBox7.Checked = false;
                        checkBox8.Checked = false;
                        checkBox9.Checked = false;
                        checkBox10.Checked = false;
                        checkBox11.Checked = false;
                        checkBox12.Checked = false;
                        checkBox13.Checked = false;
                        checkBox14.Checked = false;
                        checkBox15.Checked = false;
                        checkBox16.Checked = false;
                        checkBox17.Checked = false;
                        checkBox18.Checked = false;
                        checkBox19.Checked = false;
                        checkBox20.Checked = false;
                        checkBox21.Checked = false;
                        checkBox22.Checked = false;
                        checkBox23.Checked = false;
                        checkBox24.Checked = false;
                        checkBox25.Checked = false;
                        checkBox26.Checked = false;
                        checkBox27.Checked = false;
                        checkBox28.Checked = false;
                        checkBox29.Checked = false;
                        checkBox30.Checked = false;
                        checkBox31.Checked = false;
                        checkBox32.Checked = false;
                        checkBox33.Checked = false;
                        checkBox34.Checked = false;
                        checkBox35.Checked = false;
                        checkBox36.Checked = false;
                        checkBox37.Checked = false;
                        checkBox38.Checked = false;
                        checkBox39.Checked = false;
                        checkBox40.Checked = false;
                        checkBox41.Checked = false;
                        checkBox42.Checked = false;
                        checkBox43.Checked = false;
                        checkBox44.Checked = false;
                        checkBox45.Checked = false;
         }

        private void button3_Click(object sender, EventArgs e)
        {
            sıfırlama();
        }

        public void sıfırlama()
        {
            for (int i = 1; i < 57; i++)
            {
                arb[i] = 0;
                drb[i] = 0;
            }
            saldiransay = 0;
            savunansay = 0;

            turson.Visible = true;
            button3.Visible = false;
            button2.Visible = false;
            button4.Visible = false;
            label8.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            chechboxsıfırlama();
        }

        public void checkboxsil()
        {
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            checkBox5.Visible = false;
            checkBox6.Visible = false;
            checkBox7.Visible = false;
            checkBox8.Visible = false;
            checkBox9.Visible = false;
            checkBox10.Visible = false;
            checkBox11.Visible = false;
            checkBox12.Visible = false;
            checkBox13.Visible = false;
            checkBox14.Visible = false;
            checkBox15.Visible = false;
            checkBox16.Visible = false;
            checkBox17.Visible = false;
            checkBox18.Visible = false;
            checkBox19.Visible = false;
            checkBox20.Visible = false;
            checkBox21.Visible = false;
            checkBox22.Visible = false;
            checkBox23.Visible = false;
            checkBox24.Visible = false;
            checkBox25.Visible = false;
            checkBox26.Visible = false;
            checkBox27.Visible = false;
            checkBox28.Visible = false;
            checkBox29.Visible = false;
            checkBox30.Visible = false;
            checkBox31.Visible = false;
            checkBox32.Visible = false;
            checkBox33.Visible = false;
            checkBox34.Visible = false;
            checkBox35.Visible = false;
            checkBox36.Visible = false;
            checkBox37.Visible = false;
            checkBox38.Visible = false;
            checkBox39.Visible = false;
            checkBox40.Visible = false;
            checkBox41.Visible = false;
            checkBox42.Visible = false;
            checkBox43.Visible = false;
            checkBox44.Visible = false;
            checkBox45.Visible = false;
        }

        public void checkboxgoster()
        {
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            checkBox3.Visible = true;
            checkBox4.Visible = true;
            checkBox5.Visible = true;
            checkBox6.Visible = true;
            checkBox7.Visible = true;
            checkBox8.Visible = true;
            checkBox9.Visible = true;
            checkBox10.Visible = true;
            checkBox11.Visible = true;
            checkBox12.Visible = true;
            checkBox13.Visible = true;
            checkBox14.Visible = true;
            checkBox15.Visible = true;
            checkBox16.Visible = true;
            checkBox17.Visible = true;
            checkBox18.Visible = true;
            checkBox19.Visible = true;
            checkBox20.Visible = true;
            checkBox21.Visible = true;
            checkBox22.Visible = true;
            checkBox23.Visible = true;
            checkBox24.Visible = true;
            checkBox25.Visible = true;
            checkBox26.Visible = true;
            checkBox27.Visible = true;
            checkBox28.Visible = true;
            checkBox29.Visible = true;
            checkBox30.Visible = true;
            checkBox31.Visible = true;
            checkBox32.Visible = true;
            checkBox33.Visible = true;
            checkBox34.Visible = true;
            checkBox35.Visible = true;
            checkBox36.Visible = true;
            checkBox37.Visible = true;
            checkBox38.Visible = true;
            checkBox39.Visible = true;
            checkBox40.Visible = true;
            checkBox41.Visible = true;
            checkBox42.Visible = true;
            checkBox43.Visible = true;
            checkBox44.Visible = true;
            checkBox45.Visible = true;
        }

        public void bitis()
        {
            label7.Visible = true;
            label7.Text = kazanan + "\n KAZANDI";
            button5.Visible = true;
            turson.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            boya = false;
            turson.Visible = true;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            label8.Visible = false;
            checkboxgoster();

            gectusu();
            tur++;
            label6.Text = tur.ToString();

            for (int i = 1; i < 46; i++)
            {
                k[i] = b[i];
            }
            chechboxsıfırlama();
        }

        public void gectusu()
        { 
        for (int i = 1; i < 46; i++)
            {
                arb[i] = 0;
                drb[i] = 0;
            }
               o1=0;//oyuncuların kare sayıları sıfırlanıp yeniden belirleniyor
               o2=0;
               o3=0;
               o4=0;

            for (int i = 0; i < 46; i++)
            {
                if (b[i] == "o1")
                    o1++;
                if (b[i] == "o2")
                    o2++;
                if (b[i] == "o3")
                    o3++;
                if (b[i] == "o4")
                    o4++;
            }
            if (oynayan == "o1" && o1 == 45 || oynayan == "o1" && o2 == 0 && o3 == 0 && o4 == 0)//Oyuncu kazandıysa oyun biter
            {
                kazanan = Form1.ad1;
                checkboxsil();
                bitis();
            }
            else if (oynayan == "o2" && o2 == 45 || oynayan == "o2" && o1 == 0 && o3 == 0 && o4 == 0)
            {
                kazanan = Form1.ad2;
                checkboxsil();
                bitis();
            }
            else if (oynayan == "o3" && o3 == 45 || oynayan == "o3" && o2 == 0 && o1 == 0 && o4 == 0)
            {
                kazanan = Form1.ad3;
                checkboxsil();
                bitis();
            }
            else if (oynayan == "o4" && o4 == 45 || oynayan == "o4" && o2 == 0 && o3 == 0 && o1 == 0)
            {
                kazanan = Form1.ad4;
                checkboxsil();
                bitis();
            }

            else if (oynayan == "o1")//Oyuncu kaybetmediyse oyun sırayla devam eder
            {
                if(o2!=0)
                {
                oynayan = "o2";
                label1.Visible = true;
                oyuncuno.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                }
                else
                {
                oynayan="o3";
                label2.Visible = true;
                label1.Visible = false;
                oyuncuno.Visible = false;
                label3.Visible = false;

                }
            }
            else if (oynayan == "o2")
            {
                if(o3!=0)
                {
                oynayan = "o3";
                label2.Visible = true;
                label1.Visible = false;
                oyuncuno.Visible = false;
                label3.Visible = false;
                }
                else
                {
                oynayan="o4";
                label3.Visible = true;
                label2.Visible = false;
                oyuncuno.Visible = false;
                label1.Visible = false;
                }
            }
            else if (oynayan == "o3")
            {
                if (o4 != 0)
                {
                    oynayan = "o4";
                    label3.Visible = true;
                    label2.Visible = false;
                    oyuncuno.Visible = false;
                    label2.Visible = false;
                    label1.Visible = false;
                }
                else
                {
                    oynayan = "o1";
                    oyuncuno.Visible = true;
                    label3.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                }
            }
            else if (oynayan == "o4")
            {
                if (o1 != 0)
                {
                    oynayan = "o1";
                    oyuncuno.Visible = true;
                    label3.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                }
                else if (o2 != 0)
                {
                    oynayan = "o2";
                    label1.Visible = true;
                    oyuncuno.Visible = false;
                    label3.Visible = false;
                    label2.Visible = false;
                }
                else
                    gectusu();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            oyuncuno.Text = Form1.ad1;
            label1.Text = Form1.ad2;
            label2.Text = Form1.ad3;
            label3.Text = Form1.ad4;
            checkboxgoster();
            pictureBox1.Visible = true;

            oynayan = "o1";

            //hangi karenin kime ait olduğunu gösteren güncel değişken
            b[1] = "o1";
            b[2] = "o1";
            b[3] = "o1";
            b[4] = "o1";
            b[5] = "o5";
            b[6] = "o3";
            b[7] = "o3";
            b[8] = "o3";
            b[9] = "o3";
            b[10] = "o1";
            b[11] = "o1";
            b[12] = "o1";
            b[13] = "o1";
            b[14] = "o5";
            b[15] = "o3";
            b[16] = "o3";
            b[17] = "o3";
            b[18] = "o3";
            b[19] = "o5";
            b[20] = "o5";
            b[21] = "o5";
            b[22] = "o5";
            b[23] = "o5";
            b[24] = "o5";
            b[25] = "o5";
            b[26] = "o5";
            b[27] = "o5";
            b[28] = "o2";
            b[29] = "o2";
            b[30] = "o2";
            b[31] = "o2";
            b[32] = "o5";
            b[33] = "o4";
            b[34] = "o4";
            b[35] = "o4";
            b[36] = "o4";
            b[37] = "o2";
            b[38] = "o2";
            b[39] = "o2";
            b[40] = "o2";
            b[41] = "o5";
            b[42] = "o4";
            b[43] = "o4";
            b[44] = "o4";
            b[45] = "o4";

            //oyun başladığında hangi kare kime ait (Oyunu hızlandırıyor)
            k[1] = "o1";
            k[2] = "o1";
            k[3] = "o1";
            k[4] = "o1";
            k[5] = "o5";
            k[6] = "o3";
            k[7] = "o3";
            k[8] = "o3";
            k[9] = "o3";
            k[10] = "o1";
            k[11] = "o1";
            k[12] = "o1";
            k[13] = "o1";
            k[14] = "o5";
            k[15] = "o3";
            k[16] = "o3";
            k[17] = "o3";
            k[18] = "o3";
            k[19] = "o5";
            k[20] = "o5";
            k[21] = "o5";
            k[22] = "o5";
            k[23] = "o5";
            k[24] = "o5";
            k[25] = "o5";
            k[26] = "o5";
            k[27] = "o5";
            k[28] = "o2";
            k[29] = "o2";
            k[30] = "o2";
            k[31] = "o2";
            k[32] = "o5";
            k[33] = "o4";
            k[34] = "o4";
            k[35] = "o4";
            k[36] = "o4";
            k[37] = "o2";
            k[38] = "o2";
            k[39] = "o2";
            k[40] = "o2";
            k[41] = "o5";
            k[42] = "o4";
            k[43] = "o4";
            k[44] = "o4";
            k[45] = "o4";

            for (int i = 1; i < 57; i++)
            {
                arb[i] = 0;
                drb[i] = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            label10.Visible = false;
            label11.Visible = false;
            //Savunacak seç
            if (checkBox1.Checked == true) drb[1 ] = 1;
            if (checkBox2.Checked == true) drb[ 2] = 2;
            if (checkBox3.Checked == true) drb[3 ] = 3;
            if (checkBox4.Checked == true) drb[4 ] = 4;
            if (checkBox5.Checked == true) drb[5 ] = 5;
            if (checkBox6.Checked == true) drb[6 ] = 6;
            if (checkBox7.Checked == true) drb[7 ] = 7;
            if (checkBox8.Checked == true) drb[8 ] = 8;
            if (checkBox9.Checked == true) drb[9 ] = 9;
            if (checkBox10.Checked == true) drb[10 ] = 10;
            if (checkBox11.Checked == true) drb[ 11] = 11;
            if (checkBox12.Checked == true) drb[ 12] = 12;
            if (checkBox13.Checked == true) drb[13 ] = 13;
            if (checkBox14.Checked == true) drb[ 14] = 14;
            if (checkBox15.Checked == true) drb[ 15] = 15;
            if (checkBox16.Checked == true) drb[ 16] = 16;
            if (checkBox17.Checked == true) drb[ 17] = 17;
            if (checkBox18.Checked == true) drb[ 18] = 18;
            if (checkBox19.Checked == true) drb[ 19] = 19;
            if (checkBox20.Checked == true) drb[ 20] = 20;
            if (checkBox21.Checked == true) drb[ 21] = 21;
            if (checkBox22.Checked == true) drb[22 ] = 22;
            if (checkBox23.Checked == true) drb[23 ] = 23;
            if (checkBox24.Checked == true) drb[24 ] = 24;
            if (checkBox25.Checked == true) drb[25 ] = 25;
            if (checkBox26.Checked == true) drb[26 ] = 26;
            if (checkBox27.Checked == true) drb[27 ] = 27;
            if (checkBox28.Checked == true) drb[28 ] = 28;
            if (checkBox29.Checked == true) drb[29 ] = 29;
            if (checkBox30.Checked == true) drb[30 ] = 30;
            if (checkBox31.Checked == true) drb[31 ] = 31;
            if (checkBox32.Checked == true) drb[32 ] = 32;
            if (checkBox33.Checked == true) drb[33 ] = 33;
            if (checkBox34.Checked == true) drb[34 ] = 34;
            if (checkBox35.Checked == true) drb[ 35] = 35;
            if (checkBox36.Checked == true) drb[ 36] = 36;
            if (checkBox37.Checked == true) drb[37 ] = 37;
            if (checkBox38.Checked == true) drb[38 ] = 38;
            if (checkBox39.Checked == true) drb[39 ] = 39;
            if (checkBox40.Checked == true) drb[40 ] = 40;
            if (checkBox41.Checked == true) drb[41 ] = 41;
            if (checkBox42.Checked == true) drb[42 ] = 42;
            if (checkBox43.Checked == true) drb[43 ] = 43;
            if (checkBox44.Checked == true) drb[44 ] = 44;
            if (checkBox45.Checked == true) drb[45 ] = 45;

            for (int i = 1; i < 46; i++)
            {
                //seçtiğimiz karenin 1-altındaysa, 2-üstündeyse, 3-sağındaysa(en sağ kareler hariç) 4-solundaysa(en sağ kareler hariç) sadece sınırındaki karelere saldırabilmesi için
                if (arb[i] == (drb[i + 9] - 9) || (i>9 && arb[i] == (drb[i - 9] + 9)) ||(arb[i] == (drb[i + 1] - 1) && i != 9 && i != 18 && i != 27 && i != 36) || (arb[i] == (drb[i - 1] + 1) && i != 10 && i != 19 && i != 28 && i != 37))
                {
                    for (int j = 1; j < 46; j++)//Kendi topraklarına saldırmasını engellemek için
                    {
                        if (arb[i] == i && drb[j] == j && b[i] != b[j])
                        {
                            basla++;//Boyama ile ilgili
                            button4.Visible = true;
                            button2.Visible = false;
                            break;
                        }
                    }
                }
            }
            if(button4.Visible==false)
                {
                    MessageBox.Show("Saldırmak istediğin bölgeye sınırınız yok \n veya kendi topraklarınıza saldırıyorsunuz.");
                    sıfırlama();
                }
        }

        public int saldiransay, savunansay;//saldırı için seçilen kare sayısı, savunması için seçilen düşman karesi sayısı

        private void button4_Click(object sender, EventArgs e)//Saldır tuşu
        {
            pictureBox3.Visible = false;

            boya = true;
            for (int i = 1; i < 46; i++)
            {
                if (arb[i] != 0)
                    saldiransay++;
                if (drb[i] != 0)
                    savunansay++;
            }

            if (saldiransay == savunansay)
            {
                turson.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button2.Visible = false;
                saldırı();
                saldiransay = 0;
                savunansay = 0;
            }
            else if(saldiransay!= 0 && savunansay!=0)
            {
                MessageBox.Show("Saldırı için seçtiğiniz kare sayısı ile savunan düşman karesi sayısı aynı olmalıdır");
                sıfırlama();
            }
           }

        public void saldırı()
        {
            int savas;
            Random uret = new Random();
            savas = uret.Next(1, 3);
            label8.Visible = true;

            if (savas == 1)//Kaybetmek
            {
                label8.Text = "Yenilgi";
                pictureBox5.Visible = true;

                for (int i = 1; i < 46; i++)
                {
                    if (arb[i] != 0)
                    {
                        for (int r = 1; r < 46; r++)
                        {
                            if(drb[r] !=0)
                            b[i] = b[r];
                        }
                    }
                }
            }

            if (savas == 2)//Kazanmak
            {
                label8.Text = "Zafer!";
                pictureBox4.Visible = true;
                
                for (int i = 1; i < 46; i++)
                { 
                    if(drb[i] == i)
                    {
                    if (oynayan == "o1")
                        b[i] = "o1";
                    if (oynayan == "o2")
                        b[i] = "o2";
                    if (oynayan == "o3")
                        b[i] = "o3";
                    if (oynayan == "o4")
                        b[i] = "o4";
                    }
                }
            }
            checkboxbackcolor();

            chechboxsıfırlama();
            checkboxsil();
        }

        public string boxadi,boxnum;//checkboxların backcolorını bulabilmek için değişkenler
        public int boxint;

        public void checkboxbackcolor()
        {
            foreach (Control c in this.Controls) //checkboxların backcolorını bulabilmek için.
            {
                if (c is CheckBox)
                {
                    boxadi = c.Name;
                    if (boxadi.Length == 9)
                        boxnum = boxadi.Substring(8, 1);
                    if (boxadi.Length == 10)
                        boxnum = boxadi.Substring(8, 2);

                    boxint = Convert.ToInt32(boxnum);

                    for (int j = 1; j < 46; j++)
                    {
                        if (b[j] == "o1" && boxint == j)
                        {
                            c.BackColor = Color.Red;
                        }
                        if (b[j] == "o2" && boxint == j)
                        {
                            c.BackColor = Color.Yellow;
                        }
                        if (b[j] == "o3" && boxint == j)
                        {
                            c.BackColor = Color.Blue;
                        }
                        if (b[j] == "o4" && boxint == j)
                        {
                            c.BackColor = Color.Green;
                        }
                        if (b[j] == "o5" && boxint == j)
                        {
                            c.BackColor = Color.White;
                        }
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
            sıfırlama();
            chechboxsıfırlama();
        }

        private void checkBox45_MouseMove(object sender, MouseEventArgs e)
        {
            //silince 45 hata veriyor silmekle uğraşamadım
        }
        
        private void checkBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && button4.Visible == true)
            {
                button4.PerformClick();
            }

            if (e.KeyCode == Keys.Enter && button2.Visible == true)
            {
                button2.PerformClick();
            }

            if (e.KeyCode == Keys.Enter && turson.Visible == true)
            {
                turson.PerformClick();
            }
        }
    }
}
