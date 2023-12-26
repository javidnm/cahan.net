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
namespace SearchForm
{
    public partial class PersonSearch : Form
    {
        FinalEntities1 db;
        Person person;
        public PersonSearch()
        {
            db = new FinalEntities1();
            InitializeComponent();
        }

        public void updateDataGrid()
        {
            dgvMain.DataSource = db.People.Where(s => s.DeletedDate == null).Select(s => new
            {
                s.Id,
                s.FirstName,
                s.LastName,
                s.FatherName,  
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
                s.IssuingAuthority,
                s.DeletedDate
            }).ToList();
        }
        public void UpdateComboBoxes()
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
        private void SearchForm_Load(object sender, EventArgs e)
        {
            
            UpdateComboBoxes();

        }
        IQueryable<Person> People;

        private void txtName_TextChanged_1(object sender, EventArgs e)
        {
            People = db.People;
            if (!string.IsNullOrWhiteSpace(txtName.Text)) 
            {
             
                People=People.Where(w => w.FirstName.Contains(txtName.Text));
            }
                
                dgvMain.DataSource = People.Where(w=>w.DeletedDate==null).Select(s => new
                {

                    ID= s.Id,
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

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            People = db.People;
            if (!string.IsNullOrWhiteSpace(txtSurname.Text))
            {

                People = People.Where(w => w.LastName.Contains(txtSurname.Text));
            }

            dgvMain.DataSource = People.Where(w => w.DeletedDate == null).Select(s => new
            {

                ID = s.Id,
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

        private void txtFather_TextChanged(object sender, EventArgs e)
        {
            People = db.People;
            if (!string.IsNullOrWhiteSpace(txtFather.Text))
            {

                People = People.Where(w => w.FatherName.Contains(txtFather.Text));
            }

            dgvMain.DataSource = People.Where(w => w.DeletedDate == null).Select(s => new
            {

                ID = s.Id,
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

        private void txtBorn_TextChanged(object sender, EventArgs e)
        {
            People = db.People;
            if (!string.IsNullOrWhiteSpace(txtBorn.Text))
            {

                People = People.Where(w => w.BirthPlace.Contains(txtBorn.Text));
            }

            dgvMain.DataSource = People.Where(w => w.DeletedDate == null).Select(s => new
            {

                ID = s.Id,
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

        private void dtpBorn_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dtpBorn.Value.Date;
            People = db.People;
            if (!string.IsNullOrWhiteSpace(dtpBorn.Text))
            {

                People = People.Where(w => w.BirthOfDate.Value==date);
            }

            dgvMain.DataSource = People.Where(w => w.DeletedDate == null).Select(s => new
            {

                ID = s.Id,
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

       

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            People = db.People;
            if (!string.IsNullOrWhiteSpace(txtLocation.Text))
            {

                People = People.Where(w => w.LivingPlace.Contains(txtLocation.Text));
            }

            dgvMain.DataSource = People.Where(w => w.DeletedDate == null).Select(s => new
            {

                ID = s.Id,
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

        private void txtSeria_TextChanged(object sender, EventArgs e)
        {
            People = db.People;
            if (!string.IsNullOrWhiteSpace(txtSeria.Text))
            {

                People = People.Where(w => w.Series.Contains(txtSeria.Text));
            }

            dgvMain.DataSource = People.Where(w => w.DeletedDate == null).Select(s => new
            {

                ID = s.Id,
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

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            People = db.People;
            if (!string.IsNullOrWhiteSpace(txtNumber.Text))
            {

                People = People.Where(w => w.Number.Contains(txtNumber.Text));
            }

            dgvMain.DataSource = People.Where(w => w.DeletedDate == null).Select(s => new
            {

                ID = s.Id,
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

        private void txtAuthority_TextChanged(object sender, EventArgs e)
        {
            People = db.People;
            if (!string.IsNullOrWhiteSpace(txtAuthority.Text))
            {

                People = People.Where(w => w.IssuingAuthority.Contains(txtAuthority.Text));
            }

            dgvMain.DataSource = People.Where(w => w.DeletedDate == null).Select(s => new
            {

                ID = s.Id,
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

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboItem gender = cmbGender.SelectedItem as ComboItem;
            People = db.People;
            if (!string.IsNullOrWhiteSpace(cmbGender.Text))
            {
                People = db.People.Where(w => w.Gender.Name==gender.Name);
            }

            dgvMain.DataSource = People.Where(w => w.DeletedDate == null&&w.GenderId==gender.Value).Select(s => new
            {

                ID = s.Id,
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

        private void cmbNational_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboItem national = cmbNational.SelectedItem as ComboItem;
            People = db.People;
            if (!string.IsNullOrWhiteSpace(cmbNational.Text))
            {
                People = db.People.Where(w => w.Nationality.Citizenship == national.Name);
            }

            dgvMain.DataSource = People.Where(w => w.DeletedDate == null && w.NationalityId == national.Value).Select(s => new
            {

                ID = s.Id,
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

        private void cmbFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboItem martial = cmbFamily.SelectedItem as ComboItem;
            People = db.People;
            if (!string.IsNullOrWhiteSpace(cmbGender.Text))
            {
                People = db.People.Where(w => w.MartialStatu.Name == martial.Name);
            }

            dgvMain.DataSource = People.Where(w => w.DeletedDate == null && w.MartialStatusId == martial.Value).Select(s => new
            {

                ID = s.Id,
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

        private void cmbWar_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboItem military = cmbWar.SelectedItem as ComboItem;
            People = db.People;
            if (!string.IsNullOrWhiteSpace(cmbWar.Text))
            {
                People = db.People.Where(w => w.MilitaryStatu.Name == military.Name);
            }

            dgvMain.DataSource = People.Where(w => w.DeletedDate == null && w.MilitaryStatusId == military.Value).Select(s => new
            {

                ID = s.Id,
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

        private void cmbEyeColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboItem eyeColor = cmbEyeColor.SelectedItem as ComboItem;
            People = db.People;
            if (!string.IsNullOrWhiteSpace(cmbEyeColor.Text))
            {
                People = db.People.Where(w => w.EyeColor.ColorName == eyeColor.Name);
            }

            dgvMain.DataSource = People.Where(w => w.DeletedDate == null && w.EyeColorId == eyeColor.Value).Select(s => new
            {

                ID = s.Id,
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

        private void cmbBloodGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboItem bloodGroup = cmbBloodGroup.SelectedItem as ComboItem;
            People = db.People;
            if (!string.IsNullOrWhiteSpace(cmbBloodGroup.Text))
            {
                People = db.People.Where(w => w.BloodGroup.Value == bloodGroup.Name);
            }

            dgvMain.DataSource = People.Where(w => w.DeletedDate == null && w.BloodGroupId == bloodGroup.Value).Select(s => new
            {

                ID = s.Id,
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

        private void dtpGivenDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime givenDate = dtpGivenDate.Value.Date;
            People = db.People;
            if (!string.IsNullOrWhiteSpace(dtpGivenDate.Text))
            {

                People = People.Where(w => w.IssueDate.Date == givenDate);
            }

            dgvMain.DataSource = People.Where(w => w.DeletedDate == null).Select(s => new
            {

                ID = s.Id,
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

        private void dtpTrust_ValueChanged(object sender, EventArgs e)
        {
            DateTime expiry = dtpTrust.Value.Date;
            People = db.People;
            if (!string.IsNullOrWhiteSpace(dtpTrust.Text))
            {

                People = People.Where(w => w.ExpiryDate.Value == expiry);
            }

            dgvMain.DataSource = People.Where(w => w.DeletedDate == null).Select(s => new
            {

                ID = s.Id,
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
    }
}
