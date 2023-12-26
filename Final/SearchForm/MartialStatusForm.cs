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
    public partial class MartialStatusForm : Form
    {
        const string folder = "error folder";
        FinalEntities1 db;
        MartialStatu martialStatu;
        public MartialStatusForm()
        {
            db = new FinalEntities1();
            InitializeComponent();
            Directory.CreateDirectory(folder);
        }
        string path = Path.Combine(folder, "error.txt");
        private void MartialStatusForm_Load(object sender, EventArgs e)
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

        private void btnAddMartialStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMartialStatus.Text))
                {
                    errorProvider1.SetError(txtMartialStatus, "Elave etmek istediyiniz aile veziyyeti daxil edin");
                    return;
                }
                string name = txtMartialStatus.Text.Trim();
                MartialStatu martialStatu = new MartialStatu()
                {

                    Name = name,

                };
                db.MartialStatus.Add(martialStatu);
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
                dgvMartialStatus.DataSource = db.MartialStatus.Where(w => w.DeletedDate == null).Select(s => new
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

        private void btnEditMartialStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMartialStatus.Text))
                {
                    errorProvider1.SetError(txtMartialStatus, "Redakte etmek istediyiniz aile veziyyeti daxil edin");
                    return;
                }
                string martialStatusName = txtMartialStatus.Text.Trim();
                martialStatu.Name = martialStatusName;
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

        private void btnDeleteMartialStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMartialStatus.Text))
                {
                    errorProvider1.SetError(txtMartialStatus, "Silmek istediyiniz aile veziyyeti daxil edin");
                    return;
                }
                martialStatu.DeletedDate = DateTime.Now;
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

        private void dgvMartialStatus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = (int)dgvMartialStatus.Rows[e.RowIndex].Cells[0].Value;
                martialStatu = db.MartialStatus.Where(w => w.Id == id).FirstOrDefault();
                txtMartialStatus.Text = martialStatu.Name;
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
