using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SearchForm.Model;
using SearchForm.Extensions;
using System.IO;

namespace SearchForm
{
    public partial class Login : Form
    {
        const string folder = "error folder";
        private readonly FinalEntities1 db;
        public User user;
        public Login()
        {

            InitializeComponent();
            db = new FinalEntities1();
            Directory.CreateDirectory(folder);
        }
        string path = Path.Combine(folder, "error.txt");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUserName.Text))
                {
                    errorProvider1.SetError(txtUserName, "E-mail daxil edin");
                    return;

                }

                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    errorProvider1.SetError(txtPassword, "Shifre daxil edin");
                    return;
                }

                string userName = txtUserName.Text.Trim();
                string password = txtPassword.Text.Trim();
                string myPass = Extension.HashPassword(password);
                user = db.Users.Where(w => w.Email == userName && w.Password == myPass).FirstOrDefault();




                MainForm mainForm = new MainForm(user);
                mainForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Zehmet olmasa bir az sinra yeniden cehd edin");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;
            }
           



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Zehmet olmasa bir az sinra yeniden cehd edin");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

    }
}
