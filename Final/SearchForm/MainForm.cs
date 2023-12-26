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
    public partial class MainForm : Form
    {
        const string folder = "error folder";
        const string folder2 = "image";
        private readonly FinalEntities1 db;
        User myUser;
        Person person;
        int count = 0;
        public MainForm(User user)
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            db = new FinalEntities1();
            myUser = user;
            dgvMain.AutoGenerateColumns = false;
            Directory.CreateDirectory(folder);
            Directory.CreateDirectory(folder2);

        }
        string path = Path.Combine(folder, "error.txt");
        private void MainForm_Load(object sender, EventArgs e)
        {
           
            try
            {
                if (myUser.RoleId == 2)
                {
                    btnDelete.Enabled = false;
                    this.dgvMain.Columns["DeletedDateTime"].Visible = false;
                    kataloqlarToolStripMenuItem.Enabled = false;
                    silmekToolStripMenuItem.Enabled = false;
                    selahiyyetlerToolStripMenuItem.Enabled = false;

                }
                this.dgvMain.Columns["Id"].Visible = false;

                UpdateComboBoxes();
                updateDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Zəhmət olmasa biraz sonra yenidən cəhd edin");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;
            }

        }
        public void UpdateComboBoxes()
        {
            try
            {
                cmbGender.DataSource = db.Genders.Select(s => new ComboItem
                {
                    Name = s.Name,
                    Value = s.Id
                }).Distinct().ToList();
                cmbFamily.DataSource = db.MilitaryStatus.Select(s => new ComboItem
                {
                    Name = s.Name,
                    Value = s.Id
                }).Distinct().ToList();
                cmbWar.DataSource = db.MartialStatus.Select(s => new ComboItem
                {
                    Name = s.Name,
                    Value = s.Id,
                }).Distinct().ToList();
                cmbBloodGroup.DataSource = db.BloodGroups.Select(s => new ComboItem
                {
                    Name = s.Value,
                    Value = s.Id
                }).Distinct().ToList();
                cmbEyeColor.DataSource = db.EyeColors.Select(s => new ComboItem
                {
                    Name = s.ColorName,
                    Value = s.Id
                }).Distinct().ToList();
                cmbNational.DataSource = db.Nationalities.Select(s => new ComboItem
                {
                    Name = s.Citizenship,
                    Value = s.Id
                }).Distinct().ToList();
            }
            catch (Exception ex)
            {

                 MessageBox.Show("Zəhmət olmasa biraz sonra yenidən cəhd edin");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;
            }

            
        }
        public void updateDataGrid()
        {
            try
            {
                dgvMain.DataSource = db.People.Where(s => s.DeletedDate == null).Select(s => new
                {
                    s.Id,
                    FLF = s.FirstName + " " + s.LastName + " " + s.FatherName,
                    s.BirthPlace,
                    s.BirthOfDate,
                    GenderName = s.Gender.Name,
                    s.Nationality.Citizenship,
                    MartialStatusName = s.MartialStatu.Name,
                    s.Height,
                    MilitaryStatusName = s.MilitaryStatu.Name,
                    EyeColorName = s.EyeColor.ColorName,
                    BloodGroupName = s.BloodGroup.Value,
                    s.LivingPlace,
                    s.IssueDate,
                    s.ExpiryDate,
                    s.Series,
                    s.Number,
                    s.IssuingAuthority,
                    s.DeletedDate
                }).ToList();
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Zəhmət olmasa biraz sonra yenidən cəhd edin");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtName.Text))
                {
                    errorProvider1.SetError(txtName, "Silmek istediyiniz Ad secin");
                    return;

                }
                if (string.IsNullOrEmpty(txtSurname.Text))
                {
                    errorProvider1.SetError(txtSurname, "Silmek istediyiniz soyad secin");
                    return;

                }
                if (string.IsNullOrEmpty(txtFather.Text))
                {
                    errorProvider1.SetError(txtFather, "Silmek istediyiniz ata adi secin");
                    return;

                }
                if (string.IsNullOrEmpty(txtBorn.Text))
                {
                    errorProvider1.SetError(txtBorn, "Silmek istediyiniz dogum yeri secin");
                    return;

                }

                if (string.IsNullOrEmpty(txtLocation.Text))
                {
                    errorProvider1.SetError(txtLocation, "Silmek istediyiniz yasayis yeri secin");
                    return;

                }
                if (string.IsNullOrEmpty(txtSeria.Text))
                {
                    errorProvider1.SetError(txtSeria, "Silmek istediyiniz Seria secin");
                    return;

                }
                if (string.IsNullOrEmpty(txtNumber.Text))
                {
                    errorProvider1.SetError(txtNumber, "Silmek istediyiniz nomre secin");
                    return;

                }
                if (string.IsNullOrEmpty(txtAuthority.Text))
                {
                    errorProvider1.SetError(txtAuthority, "Silmek istediyiniz Vesiqe veren orqanin adini");
                    return;
                }
                person.DeletedDate = DateTime.Now;
                db.SaveChanges();
                updateDataGrid();
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Zəhmət olmasa biraz sonra yenidən cəhd edin");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;
            }


        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txtName.Text.Trim();
                string lastName = txtSurname.Text.Trim();
                string fatherName = txtFather.Text.Trim();
                string birthPlace = txtBorn.Text;
                DateTime birthOfDate = dtpBorn.Value;
                ComboItem gender = cmbGender.SelectedItem as ComboItem;
                ComboItem nationality = cmbNational.SelectedItem as ComboItem;
                ComboItem martialStatus = cmbFamily.SelectedItem as ComboItem;
                int height = (int)nudHeight.Value;
                ComboItem militaryStatus = cmbWar.SelectedItem as ComboItem;
                ComboItem eyeColor = cmbEyeColor.SelectedItem as ComboItem;
                ComboItem bloodGroup = cmbBloodGroup.SelectedItem as ComboItem;
                string livingPlace = txtLocation.Text;
                DateTime issueDate = dtpGivenDate.Value;
                DateTime expiryDate = dtpTrust.Value;
                string series = txtSeria.Text;
                string number = txtNumber.Text;
                string issuingAuthority = txtAuthority.Text;
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    errorProvider1.SetError(txtName, "Ad daxil edin");
                    //errorProvider1.Clear();

                    return;

                }
                if (string.IsNullOrEmpty(txtSurname.Text))
                {
                    errorProvider1.SetError(txtSurname, "Soyad daxil edin");
                    return;

                }
                if (string.IsNullOrEmpty(txtFather.Text))
                {
                    errorProvider1.SetError(txtFather, "Ata adı daxil edin");
                    return;

                }
                if (string.IsNullOrEmpty(txtBorn.Text))
                {
                    errorProvider1.SetError(txtBorn, "Doğum yeri daxil edin");
                    return;

                }

                if (string.IsNullOrEmpty(txtLocation.Text))
                {
                    errorProvider1.SetError(txtLocation, "Yaşayış yeri daxil edin");
                    return;

                }
                if (string.IsNullOrEmpty(txtSeria.Text))
                {
                    errorProvider1.SetError(txtSeria, "Seriya daxil edin");
                    return;

                }
                if (string.IsNullOrEmpty(txtNumber.Text))
                {
                    errorProvider1.SetError(txtNumber, "Nömrə daxil edin");
                    return;

                }
                if (string.IsNullOrEmpty(txtAuthority.Text))
                {
                    errorProvider1.SetError(txtAuthority, "Vəsiqə verən orqan daxil edin");
                    return;
                }
                else
                {
                    Person newPerson = new Person
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        FatherName = fatherName,
                        BirthPlace = birthPlace,
                        BirthOfDate = birthOfDate,
                        GenderId = gender.Value,
                        NationalityId = nationality.Value,
                        MartialStatusId = martialStatus.Value,
                        Height = (byte)height,
                        MilitaryStatusId = militaryStatus.Value,
                        EyeColorId = eyeColor.Value,
                        BloodGroupId = bloodGroup.Value,
                        LivingPlace = livingPlace,
                        IssueDate = issueDate,
                        ExpiryDate = expiryDate,
                        Series = series,
                        Number = number,
                        IssuingAuthority = issuingAuthority,


                    };

                    db.People.Add(newPerson);
                    db.SaveChanges();
                    string path2 = Path.Combine(folder2, person.Id + ".jpg");
                    pictureBox1.Image = Image.FromFile(path2);
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
        public void deletedDate()
        {
            try
            {
                dgvMain.DataSource = db.People.Select(s => new
                {

                }).ToList();
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Zehmet olmasa bir az sinra yeniden cehd edin");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;
            }
           
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = (int)dgvMain.Rows[e.RowIndex].Cells[0].Value;
                person = db.People.Where(w => w.Id == id).FirstOrDefault();
                txtName.Text = person.FirstName;
                txtSurname.Text = person.LastName;
                txtFather.Text = person.FatherName;
                txtBorn.Text = person.BirthPlace;
                dtpBorn.Value = person.BirthOfDate.Value;
                cmbGender.SelectedValue = person.GenderId;
                cmbNational.SelectedValue = person.NationalityId;
                cmbFamily.SelectedValue = person.MartialStatusId;
                nudHeight.Value = (byte)person.Height;
                cmbWar.SelectedValue = person.MilitaryStatusId;
                cmbEyeColor.SelectedValue = person.EyeColorId;
                cmbBloodGroup.SelectedValue = person.BloodGroupId;
                txtLocation.Text = person.LivingPlace;
                dtpGivenDate.Value = person.IssueDate;
                dtpTrust.Value = person.ExpiryDate.Value;
                txtSeria.Text = person.Series;
                txtNumber.Text = person.Number;
                txtAuthority.Text = person.IssuingAuthority;
                string path2 = Path.Combine(folder2, person.Id + ".jpg");
                //pictureBox1.Image = Image.FromFile(path2);

                btnAdd.Enabled = false;
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
                string firstName = txtName.Text.Trim();
                string lastName = txtSurname.Text.Trim();
                string fatherName = txtFather.Text.Trim();
                string birthPlace = txtBorn.Text;
                DateTime birthOfDate = dtpBorn.Value;
                ComboItem gender = cmbGender.SelectedItem as ComboItem;
                ComboItem nationality = cmbNational.SelectedItem as ComboItem;
                ComboItem martialStatus = cmbFamily.SelectedItem as ComboItem;
                int height = (int)nudHeight.Value;
                ComboItem militaryStatus = cmbWar.SelectedItem as ComboItem;
                ComboItem eyeColor = cmbEyeColor.SelectedItem as ComboItem;
                ComboItem bloodGroup = cmbBloodGroup.SelectedItem as ComboItem;
                string livingPlace = txtLocation.Text;
                DateTime issueDate = dtpGivenDate.Value;
                DateTime expiryDate = dtpTrust.Value;
                string series = txtSeria.Text;
                string number = txtNumber.Text;
                string issuingAuthority = txtAuthority.Text;
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    errorProvider1.SetError(txtName, "Deyismek istediyiniz adi secin");
                    return;

                }
                if (string.IsNullOrEmpty(txtSurname.Text))
                {
                    errorProvider1.SetError(txtSurname, "Deyismek istediyiniz Soyad secin");
                    return;

                }
                if (string.IsNullOrEmpty(txtSeria.Text))
                {
                    errorProvider1.SetError(txtSeria, "Deyismek istediyiniz Seriya secin");
                    return;

                }
                if (string.IsNullOrEmpty(txtNumber.Text))
                {
                    errorProvider1.SetError(txtNumber, "Deyismek istediyiniz Nomre secin");
                    return;

                }
                if (string.IsNullOrEmpty(txtAuthority.Text))
                {
                    errorProvider1.SetError(txtAuthority, "Deyismek istediyiniz Vesiqe veren orqanin adini secin");
                    return;
                }
                person.FirstName = firstName;
                person.LastName = lastName;
                person.FatherName = fatherName;
                person.BirthPlace = birthPlace;
                person.BirthOfDate = birthOfDate;
                person.GenderId = gender.Value;
                person.NationalityId = nationality.Value;
                person.MartialStatusId = martialStatus.Value;
                person.Height = (byte)height;
                person.MilitaryStatusId = militaryStatus.Value;
                person.EyeColorId = eyeColor.Value;
                person.BloodGroupId = bloodGroup.Value;
                person.LivingPlace = livingPlace;
                person.IssueDate = issueDate;
                person.ExpiryDate = expiryDate;
                person.Series = series;
                person.Number = number;
                person.IssuingAuthority = issuingAuthority;

                db.SaveChanges();
                updateDataGrid();
                btnAdd.Enabled = true;
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Zehmet olmasa bir az sinra yeniden cehd edin");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;
            }
           
        }

        private void cixmaqToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void silmekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                btnDelete_Click(null, null);
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Zehmet olmasa bir az sinra yeniden cehd edin");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;
            }
        }

        private void elaveEtmekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                btnAdd_Click(null, null);
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Zehmet olmasa bir az sinra yeniden cehd edin");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;
            }
        }

        private void vetendasliqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NationalityForm nationalityForm = new NationalityForm();
                nationalityForm.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Zehmet olmasa bir az sinra yeniden cehd edin");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;
            }
            
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                PersonSearch personSearch = new PersonSearch();
                personSearch.Show();
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Zehmet olmasa bir az sinra yeniden cehd edin");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;
            }
           
        }

        private void aileVeziyyetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MartialStatusForm martialStatusForm = new MartialStatusForm();
                martialStatusForm.Show();
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Zehmet olmasa bir az sinra yeniden cehd edin");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;
            }
           

        }

        private void herbiMukellefiyyetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MilitarysStatusForm militarysStatusForm = new MilitarysStatusForm();
                militarysStatusForm.Show();
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Zehmet olmasa bir az sinra yeniden cehd edin");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;
            }
           
        }

        private void gozRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                EyeColorForm eyeColorForm = new EyeColorForm();
                eyeColorForm.Show();
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Zehmet olmasa bir az sinra yeniden cehd edin");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;
            }
            
        }

        private void qanQrupuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                BloodGroupForm bloodGroupForm = new BloodGroupForm();
                bloodGroupForm.Show();
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Zehmet olmasa bir az sinra yeniden cehd edin");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            try
            {
                count++;
                if (count > dgvMain.Rows.Count - 1)
                {
                    MessageBox.Show("Cedvel bitdi");
                    return;
                }
                else
                {
                    dgvMain.CurrentCell = dgvMain.Rows[count].Cells[1];
                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Zehmet olmasa bir az sinra yeniden cehd edin");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;
            }
           
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            try
            {
                if (count == 0)
                {
                    MessageBox.Show("Cedvel bitdi");
                    return;
                }
                if (count > dgvMain.Rows.Count - 1)
                {
                    count = dgvMain.Rows.Count - 1;

                }
                else
                {
                    count--;
                    dgvMain.CurrentCell = dgvMain.Rows[count].Cells[1];
                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Zehmet olmasa bir az sinra yeniden cehd edin");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;
            }
           
        }

        private void axtarmaqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PersonSearch personSearch = new PersonSearch();
                personSearch.Show();
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Zehmet olmasa bir az sinra yeniden cehd edin");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;
            }
        }

        private void redakteEtmekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                btnEdit_Click(null, null);
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Zehmet olmasa bir az sinra yeniden cehd edin");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;
            }
        }

        

        private void btnMinus_Click(object sender, EventArgs e)
        {
            pictureBox1 = null;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            //Task.Run(() =>
            //{
            //    var result = openFileDialog1.ShowDialog();
            //    if (result == DialogResult.OK)
            //    {
            //        pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            //    }
            //});

            using (OpenFileDialog ofd=new OpenFileDialog())
            {
                if (ofd.ShowDialog()==DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void istifadecilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoleForm roleForm = new RoleForm();
            roleForm.Show();
        }

        private void dgvMain_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
               
            
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.Show();
        }
    }
}





