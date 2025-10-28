using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace ForditoProgram3
{
    public partial class frmLogin : Form
    {
        bool talalt = false;

        public frmLogin()
        {
            InitializeComponent();
        }

        static IFirebaseConfig ifc = new FirebaseConfig
        {
            AuthSecret = "9SUI6IxbgA2JbeaoZE4FWaWVVhGorBqVDHBvB7qk",
            BasePath = "https://gptranslator-d97ce-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        IFirebaseClient client;

        private async void login()
        {
            client = new FireSharp.FirebaseClient(ifc);

            var data = new Data();

            data.u = txUsername.Text;
            data.p = txPassword.Text;

            FirebaseResponse resp = await client.GetAsync("Counter/");
            Counter_class get = resp.ResultAs<Counter_class>();

            for (int i = 17; i <= Convert.ToInt32(get.cnt); i++)
            {
                FirebaseResponse response = await client.GetAsync("Information/"+i+"/");
                Data result = response.ResultAs<Data>();

                if(result.u == data.u && result.p == data.p)
                {
                    talalt = true;

                    SetResponse responset = await client.SetAsync("Current/id/", i);

                    Form1 f1 = new Form1();

                    f1.Show();
                    this.Hide();              
                }  
            }
            if(talalt==false)
            {
                MessageBox.Show("Invalid Username or Password", "Please try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (client != null)
            {
                MessageBox.Show("Connection is established", "Established");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void login2()
        {
            if (txUsername.Text == "" || txPassword.Text == "")
                MessageBox.Show("The Username or the Password field is empty", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                login();
                {
                    txPassword.Text = "";
                    txUsername.Text = "";
                }
            }
        }

        private void btRegist_Click(object sender, EventArgs e)
        {
            login2();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new frmRegistration().Show();
            this.Hide();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txPassword.Text = "";
            txUsername.Text = "";
            txUsername.Focus();
        }

        private void cbSPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSPassword.Checked)
                txPassword.PasswordChar = '\0';
            else
                txPassword.PasswordChar = '*';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txPassword.Text = "szia";
            txUsername.Text = "Istvangalpal11";
            login();
        }

        private void enterle(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                login2();
        }

        private void enterle2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                login2();
        }

        private void enterle3(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                login2();
        }
    }
}
