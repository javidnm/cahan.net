using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SearchForm.Extensions;
using SearchForm.Model;
namespace SearchForm
{
    public partial class UserForm : Form
    {
        const string folder = "error folder";
        FinalEntities1 db;
        User user;
        public UserForm()
        {
            InitializeComponent();
            db = new FinalEntities1();
            Directory.CreateDirectory(folder);
        }
        string path = Path.Combine(folder, "error.txt");
        private void UserForm_Load(object sender, EventArgs e)
        {
            try
            {
                cmbRoles.DataSource = db.Roles.Select(s => new ComboItem
                {
                    Name = s.Name,
                    Value = s.Id
                }).Distinct().ToList();
                updateDataGrid();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Zehmet olmasa bir az sinra yeniden cehd edin");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;
            }
        }
        public void updateDataGrid()
        {
            try
            {
                dgvUser.DataSource = db.Users.Where(w => w.DeletedDate == null).Select(s => new
                {
                    s.Id,
                    s.Email,
                    s.DeletedDate,
                }).ToList();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Zehmet olmasa bir az sinra yeniden cehd edin");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    errorProvider1.SetError(txtEmail, "Elave etmek istediyiniz userin emailini daxil edin");
                    return;
                }
                if (string.IsNullOrEmpty(txtPass.Text))
                {
                    errorProvider1.SetError(txtPass, "Elave etmek istediyiniz userin parolunu daxil edin");
                    return;
                }
                else
                {
                    string password = txtPass.Text;
                    string myPass = Extensions.Extension.HashPassword(password);
                    ComboItem roleId = cmbRoles.SelectedItem as ComboItem;
                    User user = new User
                    {

                        Email = txtEmail.Text,
                        Password = myPass,
                        RoleId = roleId.Value
                    };
                    db.Users.Add(user);
                    db.SaveChanges();
                    updateDataGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Zehmet olmasa bir az sinra yeniden cehd edin");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    errorProvider1.SetError(txtEmail, "User secin");
                    return;
                }
                if (string.IsNullOrEmpty(txtPass.Text))
                {
                    errorProvider1.SetError(txtPass, "User secin");
                    return;
                }
                else
                {
                    string password = txtPass.Text;
                    string myPass = Extensions.Extension.HashPassword(password);
                    ComboItem roleId = cmbRoles.SelectedItem as ComboItem;
                    user.Email = txtEmail.Text;
                    user.Password = myPass;
                    user.RoleId = roleId.Value;
                    db.SaveChanges();
                    updateDataGrid();
                    btnAdd.Enabled = false;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Zehmet olmasa bir az sinra yeniden cehd edin");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    errorProvider1.SetError(txtEmail, "User secin");
                    return;
                }
                if (string.IsNullOrEmpty(txtPass.Text))
                {
                    errorProvider1.SetError(txtPass, "User secin");
                    return;
                }
                else
                {
                    user.DeletedDate = DateTime.Now;
                    db.SaveChanges();
                    updateDataGrid();
                    btnAdd.Enabled = true;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Zehmet olmasa bir az sinra yeniden cehd edin");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;

            }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = (int)dgvUser.Rows[e.RowIndex].Cells[0].Value;
                user = db.Users.Where(w => w.Id == id).FirstOrDefault();
                txtEmail.Text = user.Email;
                txtPass.Text = user.Password;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Zehmet olmasa bir az sinra yeniden cehd edin");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;
            }
        }
    }
}
