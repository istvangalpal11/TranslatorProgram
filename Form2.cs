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
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        static IFirebaseConfig ifc = new FirebaseConfig //database insert
        {
            AuthSecret = "9SUI6IxbgA2JbeaoZE4FWaWVVhGorBqVDHBvB7qk",
            BasePath = "https://gptranslator-d97ce-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        IFirebaseClient client= new FireSharp.FirebaseClient(ifc);

        private async void registration()   //registration process
        {
            
            FirebaseResponse resp = await client.GetAsync("Counter/");  //what is the counter now, how many user do we have
            Counter_class get = resp.ResultAs<Counter_class>();


            var adat = new Data()                                       //creating a new user, like data
            {
                id = (Convert.ToInt32(get.cnt) + 1).ToString(),
                u = txUsername.Text.ToString(),
                p = txPassword.Text.ToString(),
                bada = 0.ToString(),
                gooda = 0.ToString(),
                helpa = 0.ToString()
            };

            SetResponse response = await client.SetAsync("Information/"+adat.id,adat);
            Data result1 = response.ResultAs<Data>();
            
            
            var obj = new Counter_class
            {
                cnt = adat.id
            };

            SetResponse response1 = await client.SetAsync("Counter/", obj);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(client!=null)                //is someting went worng
            {
                MessageBox.Show("Connection is established", "Established");
            }
            else
            {
                MessageBox.Show("!!Connection is NOT established", " NOT Established");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btRegist_Click(object sender, EventArgs e)
        {
            if (txPassword.Text == "" || txUsername.Text == "" || txCPassword.Text == "")  //if one of the fields is empty
                MessageBox.Show("The Username, Password or the Confirm Password field is empty", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if(txCPassword.Text == txPassword.Text)
                {
                    registration(); //everything is fine

                    MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    new frmLogin().Show();      //close this form, coming the li
                    this.Close();
                }
                else     //if someting went worng
                {
                    MessageBox.Show("Passwords does not match, Please Re-enter", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txPassword.Text = "";
                    txCPassword.Text = "";
                    txPassword.Focus();
                }
            }
            

        }

        private void cbSPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSPassword.Checked)       //password caracters
            {
                txPassword.PasswordChar = '\0';
                txCPassword.PasswordChar = '\0';
            }
                
            else
            {
                txPassword.PasswordChar = '*';
                txCPassword.PasswordChar = '*';
            }
                
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txPassword.Text = ""; 
            txUsername.Text = "";
            txCPassword.Text = "";
            txUsername.Focus();
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();  //we have an account, we want to login
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();   //close the app
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            if (client != null)
            {
                MessageBox.Show("Connection is established", "Established");
            }
        }
    }
}
