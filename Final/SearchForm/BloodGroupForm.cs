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
    public partial class BloodGroupForm : Form
    {
        const string folder = "error folder";
        FinalEntities1 db;
        BloodGroup BloodGroup;
        public BloodGroupForm()
        {
            db = new FinalEntities1();
            InitializeComponent();
            Directory.CreateDirectory(folder);
        }
        string path = Path.Combine(folder, "error.txt");
        private void dgvBloodGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BloodGroupForm_Load(object sender, EventArgs e)
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

        private void btnAddBloodGroup_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBloodGroup.Text))
                {
                    errorProvider1.SetError(txtBloodGroup, "Elave etmek istediyiniz qan qrupunu daxil edin");
                    return;
                }
                string name = txtBloodGroup.Text.Trim();
                BloodGroup bloodGroup = new BloodGroup
                {

                    Value = name,

                };
                db.BloodGroups.Add(bloodGroup);
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

        private void btnEditBloodGroup_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBloodGroup.Text))
                {
                    errorProvider1.SetError(txtBloodGroup, "Redakte etmek istediyiniz qan qrupunu daxil edin");
                    return;
                }
                string bloodGroupName = txtBloodGroup.Text.Trim();
                BloodGroup.Value = bloodGroupName;
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

        private void btnDeleteBloodGroup_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBloodGroup.Text))
                {
                    errorProvider1.SetError(txtBloodGroup, "Silmek istediyiniz qan qrupunu daxil edin");
                    return;
                }
                BloodGroup.DeletedDate = DateTime.Now;
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
                dgvBloodGroup.DataSource = db.BloodGroups.Where(w => w.DeletedDate == null).Select(s => new
                {
                    s.Id,
                    s.Value,
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
    }
}
