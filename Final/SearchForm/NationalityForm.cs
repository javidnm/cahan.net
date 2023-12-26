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

    public partial class NationalityForm : Form
    {
        const string folder = "error folder";
        private readonly FinalEntities1 db;
        Nationality nationality;
        public NationalityForm()
        {
            db = new FinalEntities1();

            InitializeComponent();
            Directory.CreateDirectory(folder);
        }
        string path = Path.Combine(folder, "error.txt");
        private void btnAddNationality_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNationality.Text))
                {
                    errorProvider1.SetError(txtNationality, "Elave etmek istediyiniz milliyeti daxil edin");
                    return;
                }
                string name = txtNationality.Text.Trim();
                Nationality nationality = new Nationality
                {

                    Citizenship = name,

                };
                db.Nationalities.Add(nationality);
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

        private void NationalityForm_Load(object sender, EventArgs e)
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

        public void updateDataGrid()
        {
            try
            {
                dgvNationality.DataSource = db.Nationalities.Where(w => w.DeletedDate == null).Select(s => new
                {
                    s.Id,
                    s.Citizenship,
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

        private void btnEditNationality_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNationality.Text))
                {
                    errorProvider1.SetError(txtNationality, "Redakte etmek istediyiniz milliyeti daxil edin");
                    return;
                }
                string nationalityName = txtNationality.Text.Trim();
                nationality.Citizenship = nationalityName;
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

        private void btnDeleteNationality_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNationality.Text))
                {
                    errorProvider1.SetError(txtNationality, "Silmek istediyiniz milliyeti daxil edin");
                    return;
                }
                nationality.DeletedDate = DateTime.Now;
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

        private void dgvNationality_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = (int)dgvNationality.Rows[e.RowIndex].Cells[0].Value;
                nationality = db.Nationalities.Where(w => w.Id == id).FirstOrDefault();
                txtNationality.Text = nationality.Citizenship;

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
