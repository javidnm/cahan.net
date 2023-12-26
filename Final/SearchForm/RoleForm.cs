using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SearchForm.Extensions;
using SearchForm.Model;
using System.IO;
namespace SearchForm
{
    public partial class RoleForm : Form
    {
        FinalEntities1 db;
        Role role;
        const string folder = "error folder";
        public RoleForm()
        {
            InitializeComponent();
            db = new FinalEntities1();
            Directory.CreateDirectory(folder);
        }
        string path = Path.Combine(folder, "error.txt");
        private void RoleForm_Load(object sender, EventArgs e)
        {
            try
            {
                updateDataGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Zehmet olmasa bir az sinra yeniden cehd edin");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;
            }

        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtRole.Text))
                {
                    errorProvider1.SetError(txtRole, "Elave etmek istediyiniz useri daxil edin");
                    return;
                }
                string name = txtRole.Text.Trim();
                Role role = new Role()
                {

                    Name = name,

                };
                db.Roles.Add(role);
                db.SaveChanges();
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
                dgvRole.DataSource = db.Roles.Where(w => w.DeletedDate == null).Select(s => new
                {
                    s.Id,
                    s.Name,
                    
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

        private void btnEditRole_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtRole.Text))
                {
                    errorProvider1.SetError(txtRole, "Redakte etmek istediyiniz useri daxil edin");
                    return;
                }
                string roleName = txtRole.Text.Trim();
                role.Name = roleName;
                db.SaveChanges();
                updateDataGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Zehmet olmasa bir az sinra yeniden cehd edin");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;
            }
        }

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtRole.Text))
                {
                    errorProvider1.SetError(txtRole, "Silmek istediyiniz useri daxil edin");
                    return;
                }
                role.DeletedDate = DateTime.Now;
                db.SaveChanges();
                updateDataGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Zehmet olmasa bir az sinra yeniden cehd edin");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;
            }
        }

        private void dgvRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = (int)dgvRole.Rows[e.RowIndex].Cells[0].Value;
                role = db.Roles.Where(w => w.Id == id).FirstOrDefault();
                txtRole.Text = role.Name;
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
