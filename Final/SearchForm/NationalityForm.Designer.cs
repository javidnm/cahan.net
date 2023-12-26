namespace SearchForm
{
    partial class NationalityForm
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
            this.dgvNationality = new System.Windows.Forms.DataGridView();
            this.btnAddNationality = new System.Windows.Forms.Button();
            this.btnEditNationality = new System.Windows.Forms.Button();
            this.btnDeleteNationality = new System.Windows.Forms.Button();
            this.lblNationality = new System.Windows.Forms.Label();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNationality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNationality
            // 
            this.dgvNationality.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNationality.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNationality.Location = new System.Drawing.Point(12, 133);
            this.dgvNationality.Name = "dgvNationality";
            this.dgvNationality.RowTemplate.Height = 33;
            this.dgvNationality.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNationality.Size = new System.Drawing.Size(843, 357);
            this.dgvNationality.TabIndex = 0;
            this.dgvNationality.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNationality_CellClick);
            // 
            // btnAddNationality
            // 
            this.btnAddNationality.Location = new System.Drawing.Point(31, 517);
            this.btnAddNationality.Name = "btnAddNationality";
            this.btnAddNationality.Size = new System.Drawing.Size(200, 67);
            this.btnAddNationality.TabIndex = 1;
            this.btnAddNationality.Text = "Elave et";
            this.btnAddNationality.UseVisualStyleBackColor = true;
            this.btnAddNationality.Click += new System.EventHandler(this.btnAddNationality_Click);
            // 
            // btnEditNationality
            // 
            this.btnEditNationality.Location = new System.Drawing.Point(289, 517);
            this.btnEditNationality.Name = "btnEditNationality";
            this.btnEditNationality.Size = new System.Drawing.Size(276, 67);
            this.btnEditNationality.TabIndex = 1;
            this.btnEditNationality.Text = "Redakte et";
            this.btnEditNationality.UseVisualStyleBackColor = true;
            this.btnEditNationality.Click += new System.EventHandler(this.btnEditNationality_Click);
            // 
            // btnDeleteNationality
            // 
            this.btnDeleteNationality.Location = new System.Drawing.Point(618, 517);
            this.btnDeleteNationality.Name = "btnDeleteNationality";
            this.btnDeleteNationality.Size = new System.Drawing.Size(237, 67);
            this.btnDeleteNationality.TabIndex = 1;
            this.btnDeleteNationality.Text = "Sil";
            this.btnDeleteNationality.UseVisualStyleBackColor = true;
            this.btnDeleteNationality.Click += new System.EventHandler(this.btnDeleteNationality_Click);
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(144, 39);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(85, 25);
            this.lblNationality.TabIndex = 2;
            this.lblNationality.Text = "Milliyet:";
            // 
            // txtNationality
            // 
            this.txtNationality.Location = new System.Drawing.Point(235, 39);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(517, 31);
            this.txtNationality.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NationalityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 615);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.lblNationality);
            this.Controls.Add(this.btnDeleteNationality);
            this.Controls.Add(this.btnEditNationality);
            this.Controls.Add(this.btnAddNationality);
            this.Controls.Add(this.dgvNationality);
            this.Name = "NationalityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vetendasliq";
            this.Load += new System.EventHandler(this.NationalityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNationality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNationality;
        private System.Windows.Forms.Button btnAddNationality;
        private System.Windows.Forms.Button btnEditNationality;
        private System.Windows.Forms.Button btnDeleteNationality;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}