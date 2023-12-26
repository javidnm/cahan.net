namespace SearchForm
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gpbEmail = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.gpbPass = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.gpbRole = new System.Windows.Forms.GroupBox();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpbEmail.SuspendLayout();
            this.gpbPass.SuspendLayout();
            this.gpbRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbEmail
            // 
            this.gpbEmail.Controls.Add(this.txtEmail);
            this.gpbEmail.Location = new System.Drawing.Point(52, 70);
            this.gpbEmail.Name = "gpbEmail";
            this.gpbEmail.Size = new System.Drawing.Size(269, 137);
            this.gpbEmail.TabIndex = 0;
            this.gpbEmail.TabStop = false;
            this.gpbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(6, 58);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(219, 31);
            this.txtEmail.TabIndex = 1;
            // 
            // gpbPass
            // 
            this.gpbPass.Controls.Add(this.txtPass);
            this.gpbPass.Location = new System.Drawing.Point(379, 79);
            this.gpbPass.Name = "gpbPass";
            this.gpbPass.Size = new System.Drawing.Size(250, 128);
            this.gpbPass.TabIndex = 0;
            this.gpbPass.TabStop = false;
            this.gpbPass.Text = "Parol";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(6, 49);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(190, 31);
            this.txtPass.TabIndex = 2;
            // 
            // gpbRole
            // 
            this.gpbRole.Controls.Add(this.cmbRoles);
            this.gpbRole.Location = new System.Drawing.Point(675, 79);
            this.gpbRole.Name = "gpbRole";
            this.gpbRole.Size = new System.Drawing.Size(294, 128);
            this.gpbRole.TabIndex = 0;
            this.gpbRole.TabStop = false;
            this.gpbRole.Text = "Rollar";
            // 
            // cmbRoles
            // 
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(7, 46);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(252, 33);
            this.cmbRoles.TabIndex = 3;
            // 
            // dgvUser
            // 
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(52, 269);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowTemplate.Height = 33;
            this.dgvUser.Size = new System.Drawing.Size(917, 226);
            this.dgvUser.TabIndex = 1;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(107, 535);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 63);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Elave et";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(444, 535);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(161, 63);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Redakte et";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(754, 535);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(165, 63);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Silmek";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 626);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.gpbRole);
            this.Controls.Add(this.gpbPass);
            this.Controls.Add(this.gpbEmail);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.gpbEmail.ResumeLayout(false);
            this.gpbEmail.PerformLayout();
            this.gpbPass.ResumeLayout(false);
            this.gpbPass.PerformLayout();
            this.gpbRole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbEmail;
        private System.Windows.Forms.GroupBox gpbPass;
        private System.Windows.Forms.GroupBox gpbRole;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}