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
    public partial class EyeColorForm : Form
    {
        const string folder = "error folder";
        FinalEntities1 db;
        EyeColor EyeColor;
        public EyeColorForm()
        {
            db = new FinalEntities1();
            InitializeComponent();
            Directory.CreateDirectory(folder);
        }
        string path = Path.Combine(folder, "error.txt");
        private void EyeColorForm_Load(object sender, EventArgs e)
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

        private void btnAddEyeColor_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtEyeColor.Text))
                {
                    errorProvider1.SetError(txtEyeColor, "Elave etmek istediyiniz goz rengini daxil edin");
                    return;
                }
                string name = txtEyeColor.Text.Trim();
                EyeColor eyeColorName = new EyeColor
                {

                    ColorName = name,

                };
                db.EyeColors.Add(eyeColorName);
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

        private void btnEditEyeColor_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtEyeColor.Text))
                {
                    errorProvider1.SetError(txtEyeColor, "Redakte etmek istediyiniz goz rengini daxil edin");
                    return;
                }
                string eyeColor = txtEyeColor.Text.Trim();
                EyeColor.ColorName = eyeColor;
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
                dgvEyeColor.DataSource = db.EyeColors.Where(w => w.DeletedDate == null).Select(s => new
                {
                    s.Id,
                    s.ColorName,
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

        private void btnDeleteEyeColor_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtEyeColor.Text))
                {
                    errorProvider1.SetError(txtEyeColor, "Silmek istediyiniz goz rengini daxil edin");
                    return;
                }
                EyeColor.DeletedDate = DateTime.Now;
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

        private void dgvEyeColor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int id = (int)dgvEyeColor.Rows[e.RowIndex].Cells[0].Value;
                EyeColor = db.EyeColors.Where(w => w.Id == id).FirstOrDefault();
                txtEyeColor.Text = EyeColor.ColorName;
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
