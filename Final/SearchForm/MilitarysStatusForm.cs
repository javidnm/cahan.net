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
    public partial class MilitarysStatusForm : Form
    {
        const string folder = "error folder";
        FinalEntities1 db;
        MilitaryStatu MilitaryStatu;
        public MilitarysStatusForm()
        {
            db = new FinalEntities1();
            InitializeComponent();
            Directory.CreateDirectory(folder);
        }
        string path = Path.Combine(folder, "error.txt");
        private void MilitarysStatusForm_Load(object sender, EventArgs e)
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

        private void dgvMilitaryStatus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = (int)dgvMilitaryStatus.Rows[e.RowIndex].Cells[0].Value;
                MilitaryStatu = db.MilitaryStatus.Where(w => w.Id == id).FirstOrDefault();
                txtMilitaryStatus.Text = MilitaryStatu.Name;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Zehmet olmasa bir az sinra yeniden cehd edin");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;
            }

        }

        private void btnAddMilitaryStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMilitaryStatus.Text))
                {
                    errorProvider1.SetError(txtMilitaryStatus, "Elave etmek istediyiniz herbi mukellefiyyeti daxil edin");
                    return;
                }
                string name = txtMilitaryStatus.Text.Trim();
                MilitaryStatu militaryStatu = new MilitaryStatu
                {

                    Name = name,

                };
                db.MilitaryStatus.Add(militaryStatu);
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

        private void btnEditMilitaryStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMilitaryStatus.Text))
                {
                    errorProvider1.SetError(txtMilitaryStatus, "Redakte etmek istediyiniz herbi mukellefiyyeti daxil edin");
                    return;
                }
                string militaryStatusName = txtMilitaryStatus.Text.Trim();
                MilitaryStatu.Name = militaryStatusName;
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
                dgvMilitaryStatus.DataSource = db.MilitaryStatus.Where(w => w.DeletedDate == null).Select(s => new
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

        private void btnDeleteMilitaryStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMilitaryStatus.Text))
                {
                    errorProvider1.SetError(txtMilitaryStatus, "Silmek istediyiniz herbi mukellefiyyeti daxil edin");
                    return;
                }
                MilitaryStatu.DeletedDate = DateTime.Now;
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
    }
}
