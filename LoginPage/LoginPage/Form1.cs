using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace LoginPage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IFirebaseConfig fbc = new FirebaseConfig()
        {
            BasePath = "https://test2-7a7b6-default-rtdb.firebaseio.com/",
            AuthSecret = "pt19h6SXqluVcSdE9n2zomihBcgeXSvMjSm3jBtq",
        };
        IFirebaseClient cln;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                cln = new FireSharp.FirebaseClient(fbc);
            }
            catch (Exception)
            {

                MessageBox.Show("Check your Connection !");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                User u = cln.Get("Users/" + textBox1.Text).ResultAs<User>();
                if (u != null)
                {
                    if (u.password == textBox2.Text && u.email == textBox3.Text)
                    {
                        MessageBox.Show("Welcome");
                    }
                    else MessageBox.Show("Wrong Password or email");
                }
                else MessageBox.Show("There is no such a user with this name ! \n");
                

            }
            catch (Exception)
            {

                MessageBox.Show("Check your counction !");
            }
        }
    }
}
