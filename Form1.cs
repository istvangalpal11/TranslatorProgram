namespace ForditoProgram3
{
    public partial class Form1 : Form
    {
        int nyelv, feladat;

        string[] magyar = new string[200];
        string[] idegen = new string[200];
        bool[] magyarb = new bool[200];
        bool[] idegenb = new bool[200];

        int menupont; int szamlalo = 0; int szoszam; int jovalasz, rosszvalasz; int nr; int pnyelv = 0; int pszoszam = -1; int epszoszam;
        bool megvanmagyar; bool megvanidegen;
        public Form1()
        {
            InitializeComponent();
            btFordit.Hide();
            txMegadott.Hide();
            txBeirando.Hide();
            lbMegadott.Hide();
            lbBeirando.Hide();
            lbMitcsinalsz.Hide();
            btMehet2.Hide();
            rb1.Hide();
            rb2.Hide();
            lbEgyenlo.Hide();
            pbCorrect.Hide();
            pbIncorrect.Hide();
            lbElozo.Hide();
            lbEmegadott.Hide();
            lbHElozo.Hide();
            lbHEmegadott.Hide();
            lbEBeirt.Hide();
            lbHEbeirt.Hide();
            lbtxmegadott.Hide();
            txMegadott.Hide();

            elem_rendezes();

            for (int i = 0; i <= szoszam; i++)
                magyarb[i] = false;

            for (int i = 0; i <= szoszam; i++)
                idegenb[i] = false;

        }

        private void Beolvas_szavak(int e)
        {
            if (e == 0)
            {
                StreamReader sr1 = new StreamReader("../../../zAMagyar.txt");
                string m_szoszam_ = sr1.ReadLine();
                int m_szoszam = Convert.ToInt32(m_szoszam_);
                szoszam = m_szoszam;

                for (int i = 0; i < m_szoszam; i++)
                    magyar[i] = sr1.ReadLine();
                sr1.Close();

                StreamReader sr2 = new StreamReader("../../../zAngol.txt");
                string a_szoszam_ = sr2.ReadLine();
                int a_szoszam = Convert.ToInt32(a_szoszam_);

                if (a_szoszam != szoszam)
                    MessageBox.Show("Nem egyenlõ a két állományban a szavak száma");

                for (int i = 0; i < a_szoszam; i++)
                {
                    idegen[i] = sr2.ReadLine();
                }
                sr2.Close();
            }

            else
                if (e == 1)
            {
                StreamReader sr1 = new StreamReader("../../../zRMagyar.txt");
                string m_szoszam_ = sr1.ReadLine();
                int m_szoszam = Convert.ToInt32(m_szoszam_);
                szoszam = m_szoszam;

                for (int i = 0; i < m_szoszam; i++)
                    magyar[i] = sr1.ReadLine();
                sr1.Close();

                StreamReader sr2 = new StreamReader("../../../zRoman.txt");
                string a_szoszam_ = sr2.ReadLine();
                int a_szoszam = Convert.ToInt32(a_szoszam_);

                if (a_szoszam != szoszam)
                    MessageBox.Show("Nem egyenlõ a két állományban a szavak száma");

                for (int i = 0; i < a_szoszam; i++)
                {
                    idegen[i] = sr2.ReadLine();
                }
                sr2.Close();
            }
            else
            {
                StreamReader sr1 = new StreamReader("../../../zNMagyar.txt");
                string m_szoszam_ = sr1.ReadLine();
                int m_szoszam = Convert.ToInt32(m_szoszam_);
                szoszam = m_szoszam;

                for (int i = 0; i < m_szoszam; i++)
                    magyar[i] = sr1.ReadLine();
                sr1.Close();

                StreamReader sr2 = new StreamReader("../../../zNemet.txt");
                string a_szoszam_ = sr2.ReadLine();
                int a_szoszam = Convert.ToInt32(a_szoszam_);

                if (a_szoszam != szoszam)
                    MessageBox.Show("Nem egyenlõ a két állományban a szavak száma");

                for (int i = 0; i < a_szoszam; i++)
                {
                    idegen[i] = sr2.ReadLine();
                }
                sr2.Close();
            }
        }
        private void btFordit_Click(object sender, EventArgs e)
        {
            //Forditas();
        }

        private void Forditas()
        {
            txMegadott.Clear(); txBeirando.Clear();

            if (menupont == 0)
            {
                epszoszam = pszoszam;

                Random random = new Random();
                do
                {
                    pszoszam = random.Next(0, szoszam);

                } while (magyar[pszoszam][0] == '*' || idegen[pszoszam][0] == '*' || pszoszam == epszoszam);

                if (szamlalo % 20 == 0)
                {
                    if (pnyelv == 0)
                        pnyelv = 1;
                    else
                        pnyelv = 0;
                }

                if (pnyelv == 0)
                {
                    lbtxmegadott.Text = magyar[pszoszam];
                    lbNyelvhelp.Text = "HUN";
                }
                else
                {
                    lbtxmegadott.Text = idegen[pszoszam];
                    lbNyelvhelp.Text = "IDG";
                }
                szamlalo++;
            }
            if (menupont == 1)
            {
                megvanmagyar = true;
                for (int i = 0; i <= szoszam; i++)
                    if (magyarb[i] == false)
                    {
                        megvanmagyar = false;
                        break;
                    }

                megvanidegen = true;
                for (int i = 0; i <= szoszam; i++)
                    if (idegenb[i] == false)
                    {
                        megvanidegen = false;
                        break;
                    }


                if (megvanidegen == true && megvanmagyar == true)
                {
                    txMegadott.Text = "Megvagyunk";
                }
                else
                {
                    do
                    {
                        pszoszam++;
                        if (pszoszam == szoszam)
                        {
                            pszoszam = 0;
                            if (pnyelv == 0)
                                pnyelv = 1;
                            else
                                pnyelv = 0;
                        }

                    } while (magyar[pszoszam][0] == '*' || idegen[pszoszam][0] == '*');

                    if (megvanmagyar == false)
                        if (pnyelv == 0)
                            while (magyarb[pszoszam] == true)
                                pszoszam++;

                    if (megvanidegen == false)
                        if (pnyelv == 1)
                            while (idegenb[pszoszam] == true)
                                pszoszam++;

                    if (pnyelv == 0)
                    {
                        lbtxmegadott.Text = magyar[pszoszam];
                        lbNyelvhelp.Text = "HUN";
                    }
                    else
                    {
                        lbtxmegadott.Text = idegen[pszoszam];
                        lbNyelvhelp.Text = "IDG";
                    }
                    szamlalo++;
                }
            }
        }
        private void lenyom(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar = Keys.Enter)
            //forditas();
        }

        private void btMehet_Click(object sender, EventArgs e)
        {
            if (cb1.SelectedIndex == 0)
                Beolvas_szavak(0);
            if (cb1.SelectedIndex == 1)
                Beolvas_szavak(1);
            if (cb1.SelectedIndex == 2)
                Beolvas_szavak(2);

            lbMilyennyelv.Hide();
            btMehet.Hide();
            lbMitcsinalsz.Show();
            rb1.Show();
            rb2.Show();
            cb1.Hide();
            btMehet2.Show();

        }

        private void btFordit_Click_1(object sender, EventArgs e)
        {
            pbIncorrect.Hide();
            pbCorrect.Hide();

            if (pnyelv == 0)
            {
                if (string.Compare(txBeirando.Text, idegen[pszoszam]) == 0)
                {
                    pbCorrect.Show();
                    jovalasz++;
                    lbJovalaszSzam.Text = jovalasz.ToString();
                }
                else
                {
                    pbIncorrect.Show();
                    rosszvalasz++;
                    lbRosszvalaszSzam.Text = rosszvalasz.ToString();
                }
            }
            else
            {
                if (string.Compare(txBeirando.Text, magyar[pszoszam]) == 0)
                {
                    pbCorrect.Show();
                    jovalasz++;
                    lbJovalaszSzam.Text = jovalasz.ToString();
                }
                else
                {
                    pbIncorrect.Show();
                    rosszvalasz++;
                    lbRosszvalaszSzam.Text = rosszvalasz.ToString();
                }
            }

            lbE61.Text = lbE51.Text;
            lbE62.Text = lbE52.Text;
            lbE51.Text = lbE41.Text;
            lbE52.Text = lbE42.Text;
            lbE41.Text = lbE31.Text;
            lbE42.Text = lbE32.Text;
            lbE31.Text = lbE21.Text;
            lbE32.Text = lbE22.Text;
            lbE21.Text = lbE11.Text;
            lbE22.Text = lbE12.Text;
            lbE11.Text = lbHEbeirt.Text;
            lbE12.Text = lbHEmegadott.Text;

            lbEBeirt.Text = txBeirando.Text;
            lbEmegadott.Text = lbtxmegadott.Text;
            lbHEbeirt.Text = idegen[pszoszam];
            lbHEmegadott.Text = magyar[pszoszam];

            lbtxmegadott.Text = "";
            txBeirando.Clear();

            Forditas();
        }

        private void lbEgyenlo_Click(object sender, EventArgs e)
        {

        }

        private void lenyomenter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }

        private void lenyomenter2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pbIncorrect.Hide();
                pbCorrect.Hide();

                if (pnyelv == 0)
                {
                    if (string.Compare(txBeirando.Text, idegen[pszoszam]) == 0)
                    {
                        pbCorrect.Show();
                        jovalasz++;
                        lbJovalaszSzam.Text = jovalasz.ToString();
                        magyarb[pszoszam] = true;
                    }
                    else
                    {
                        pbIncorrect.Show();
                        rosszvalasz++;
                        lbRosszvalaszSzam.Text = rosszvalasz.ToString();
                    }
                }
                else
                {
                    if (string.Compare(txBeirando.Text, magyar[pszoszam]) == 0)
                    {
                        pbCorrect.Show();
                        jovalasz++;
                        lbJovalaszSzam.Text = jovalasz.ToString();
                        idegenb[pszoszam] = true;
                    }
                    else
                    {
                        pbIncorrect.Show();
                        rosszvalasz++;
                        lbRosszvalaszSzam.Text = rosszvalasz.ToString();
                    }
                }
                lbSzamlaloSzam.Text = szamlalo.ToString();

                label_rendezes();

                lbtxmegadott.Text = "";
                txBeirando.Clear();

                Forditas();
            }
        }

        private void label_rendezes()
        {
            lbE61.Text = lbE51.Text;
            lbE62.Text = lbE52.Text;
            lbE51.Text = lbE41.Text;
            lbE52.Text = lbE42.Text;
            lbE41.Text = lbE31.Text;
            lbE42.Text = lbE32.Text;
            lbE31.Text = lbE21.Text;
            lbE32.Text = lbE22.Text;
            lbE21.Text = lbE11.Text;
            lbE22.Text = lbE12.Text;
            lbE11.Text = lbHEbeirt.Text;
            lbE12.Text = "-" + lbHEmegadott.Text;

            lbEBeirt.Text = txBeirando.Text;
            lbEmegadott.Text = lbtxmegadott.Text;
            lbHEbeirt.Text = idegen[pszoszam];
            lbHEmegadott.Text = magyar[pszoszam];
        }

        private void lbEmegadott_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lbE21_Click(object sender, EventArgs e)
        {

        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            menupont = 0;
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            menupont = 1;
        }

        private void elem_rendezes()
        {
            lbMilyennyelv.Left = (Size.Width / 2) - (lbMilyennyelv.Width / 2);
            lbMilyennyelv.Top = (Size.Height / 16);
            lbMitcsinalsz.Left = (Size.Width / 2) - (lbMitcsinalsz.Width / 2);
            lbMitcsinalsz.Top = (Size.Height / 16);

            cb1.Top = (Size.Height / 4);
            cb1.Left = Size.Width / 16;

            rb1.Top = (Size.Height / 4);
            rb1.Left = Size.Width / 16;
            rb2.Top = rb1.Top + 50;
            rb2.Left = Size.Width / 16;

            btMehet.Left = (Size.Width / 2) - (btMehet.Width / 2);
            btMehet.Top = (Size.Height / 2) + (Size.Height / 4);
            btMehet2.Left = (Size.Width / 2) - (btMehet2.Width / 2);
            btMehet2.Top = (Size.Height / 2) + (Size.Height / 4);

            lbtxmegadott.Left = (Size.Width / 8);
            lbtxmegadott.Top = (Size.Height / 4);

            txBeirando.Left = (Size.Width / 8);
            txBeirando.Top = (Size.Height / 2) + (Size.Height / 4);

            lbEgyenlo.Top = (lbBeirando.Top + lbtxmegadott.Top) / 2;
            lbEgyenlo.Left = txBeirando.Left;

            lbBeirando.Top = (lbEgyenlo.Top + txBeirando.Top) / 2;
            lbMegadott.Top = lbtxmegadott.Top - (lbBeirando.Top - lbEgyenlo.Top);
            lbBeirando.Left = txBeirando.Left;
            lbMegadott.Left = txBeirando.Left;

            btFordit.Top = lbEgyenlo.Top;
            btFordit.Left = lbEgyenlo.Left + 50;

            lbJovalasz.Top = 15;
            lbRosszvalasz.Top = 45;
            lbSzamlalo.Top = 75;

            lbJovalasz.Left = Size.Width - 130;
            lbRosszvalasz.Left = lbJovalasz.Left;
            lbSzamlalo.Left = lbJovalasz.Left;

            lbJovalaszSzam.Top = lbJovalasz.Top;
            lbRosszvalaszSzam.Top = lbRosszvalasz.Top;
            lbSzamlaloSzam.Top = lbSzamlalo.Top;

            lbJovalaszSzam.Left = Size.Width - 60;
            lbRosszvalaszSzam.Left = lbJovalaszSzam.Left;
            lbSzamlaloSzam.Left = lbJovalaszSzam.Left;

            lbNyelvhelp.Left = lbEgyenlo.Left;
            lbNyelvhelp.Top = (lbMegadott.Top + lbtxmegadott.Top) / 2;

            lbE12.Left = lbSzamlaloSzam.Left - 20;
            lbE22.Left = lbE12.Left;
            lbE32.Left = lbE12.Left;
            lbE42.Left = lbE12.Left;
            lbE52.Left = lbE12.Left;
            lbE62.Left = lbE12.Left;

            lbE11.Left = lbE12.Left - 100;
            lbE21.Left = lbE22.Left - 100;
            lbE31.Left = lbE32.Left - 100;
            lbE41.Left = lbE42.Left - 100;
            lbE51.Left = lbE52.Left - 100;
            lbE61.Left = lbE62.Left - 100;


            lbE62.Top = Size.Height - 30;
            lbE52.Top = lbE62.Top - 30;
            lbE42.Top = lbE52.Top - 30;
            lbE32.Top = lbE42.Top - 30;
            lbE22.Top = lbE32.Top - 30;
            lbE12.Top = lbE22.Top - 30;

            lbE11.Top = lbE12.Top;
            lbE21.Top = lbE22.Top;
            lbE31.Top = lbE32.Top;
            lbE41.Top = lbE42.Top;
            lbE51.Top = lbE52.Top;
            lbE61.Top = lbE62.Top;

            
            if (Size.Width > 900)
            {
                lbElozo.Show();
                lbEmegadott.Show();
                lbEBeirt.Show();
                lbHElozo.Show();
                lbHEbeirt.Show(); ;
                lbHEmegadott.Show();

                lbElozo.Top=lbNyelvhelp.Top;
                lbElozo.Left=txBeirando.Left+txBeirando.Width;
                lbEmegadott.Top=lbElozo.Top+40;
                lbEmegadott.Left = lbElozo.Left;
                lbEBeirt.Top = lbEmegadott.Top;
                lbEBeirt.Left = lbEmegadott.Left + lbEmegadott.Width + 150;

                lbHElozo.Left=lbElozo.Left;
                lbHElozo.Top=lbEmegadott.Top+70;
                lbHEmegadott.Left=lbElozo.Left;
                lbHEmegadott.Top = lbHElozo.Top + 40;
                lbHEbeirt.Left=lbHEmegadott.Left+lbHEmegadott.Width+150;
                lbHEbeirt.Top = lbHEmegadott.Top;
                
            }
            else
            {
                lbElozo.Hide();
                lbEmegadott.Hide();
                lbEBeirt.Hide();
                lbHElozo.Hide();
                lbHEbeirt.Hide(); ;
                lbHEmegadott.Hide();
            }

            pbCorrect.Left = lbElozo.Left;
            pbCorrect.Top = txBeirando.Top-30;
            pbIncorrect.Top = pbCorrect.Top;
            pbIncorrect.Left = pbCorrect.Left;

        }
        private void Meretezes(object sender, EventArgs e)
        {
            elem_rendezes();
        }

        private void btMehet_Click_1(object sender, EventArgs e)
        {
            if (cb1.SelectedIndex == 0)
                Beolvas_szavak(0);
            if (cb1.SelectedIndex == 1)
                Beolvas_szavak(1);
            if (cb1.SelectedIndex == 2)
                Beolvas_szavak(2);

            lbMilyennyelv.Hide();
            btMehet.Hide();
            lbMitcsinalsz.Show();
            rb1.Show();
            rb2.Show();
            cb1.Hide();
            btMehet2.Show();
        }

        private void btMehet2_Click_1(object sender, EventArgs e)
        {
            lbEgyenlo.Show();               

            rb1.Hide();
            rb2.Hide();
            txBeirando.Show();
            txMegadott.Hide();
            lbMegadott.Show();
            lbBeirando.Show();
            lbMitcsinalsz.Hide();
            btMehet2.Hide();
            btFordit.Show();
            lbElozo.Show();
            lbEmegadott.Show();
            lbHElozo.Show();
            lbHEmegadott.Show();
            lbEBeirt.Show();
            lbHEbeirt.Show();
            lbtxmegadott.Show();
            jovalasz = 0; rosszvalasz = 0; nr = 0;
            Forditas();          
        }
        
    }
}