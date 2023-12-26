namespace SearchForm
{
    partial class BloodGroupForm
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
            this.txtBloodGroup = new System.Windows.Forms.TextBox();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.btnDeleteBloodGroup = new System.Windows.Forms.Button();
            this.btnEditBloodGroup = new System.Windows.Forms.Button();
            this.btnAddBloodGroup = new System.Windows.Forms.Button();
            this.dgvBloodGroup = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBloodGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBloodGroup
            // 
            this.txtBloodGroup.Location = new System.Drawing.Point(138, 25);
            this.txtBloodGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBloodGroup.Name = "txtBloodGroup";
            this.txtBloodGroup.Size = new System.Drawing.Size(260, 20);
            this.txtBloodGroup.TabIndex = 27;
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.AutoSize = true;
            this.lblBloodGroup.Location = new System.Drawing.Point(58, 28);
            this.lblBloodGroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(60, 13);
            this.lblBloodGroup.TabIndex = 26;
            this.lblBloodGroup.Text = "Qan qrupu:";
            // 
            // btnDeleteBloodGroup
            // 
            this.btnDeleteBloodGroup.Location = new System.Drawing.Point(328, 279);
            this.btnDeleteBloodGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteBloodGroup.Name = "btnDeleteBloodGroup";
            this.btnDeleteBloodGroup.Size = new System.Drawing.Size(118, 35);
            this.btnDeleteBloodGroup.TabIndex = 23;
            this.btnDeleteBloodGroup.Text = "Sil";
            this.btnDeleteBloodGroup.UseVisualStyleBackColor = true;
            this.btnDeleteBloodGroup.Click += new System.EventHandler(this.btnDeleteBloodGroup_Click);
            // 
            // btnEditBloodGroup
            // 
            this.btnEditBloodGroup.Location = new System.Drawing.Point(164, 279);
            this.btnEditBloodGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditBloodGroup.Name = "btnEditBloodGroup";
            this.btnEditBloodGroup.Size = new System.Drawing.Size(138, 35);
            this.btnEditBloodGroup.TabIndex = 24;
            this.btnEditBloodGroup.Text = "Redaktə et";
            this.btnEditBloodGroup.UseVisualStyleBackColor = true;
            this.btnEditBloodGroup.Click += new System.EventHandler(this.btnEditBloodGroup_Click);
            // 
            // btnAddBloodGroup
            // 
            this.btnAddBloodGroup.Location = new System.Drawing.Point(35, 279);
            this.btnAddBloodGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddBloodGroup.Name = "btnAddBloodGroup";
            this.btnAddBloodGroup.Size = new System.Drawing.Size(100, 35);
            this.btnAddBloodGroup.TabIndex = 25;
            this.btnAddBloodGroup.Text = "Əlavə et";
            this.btnAddBloodGroup.UseVisualStyleBackColor = true;
            this.btnAddBloodGroup.Click += new System.EventHandler(this.btnAddBloodGroup_Click);
            // 
            // dgvBloodGroup
            // 
            this.dgvBloodGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBloodGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBloodGroup.Location = new System.Drawing.Point(26, 63);
            this.dgvBloodGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvBloodGroup.Name = "dgvBloodGroup";
            this.dgvBloodGroup.RowTemplate.Height = 33;
            this.dgvBloodGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBloodGroup.Size = new System.Drawing.Size(422, 186);
            this.dgvBloodGroup.TabIndex = 22;
            this.dgvBloodGroup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBloodGroup_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BloodGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 335);
            this.Controls.Add(this.txtBloodGroup);
            this.Controls.Add(this.lblBloodGroup);
            this.Controls.Add(this.btnDeleteBloodGroup);
            this.Controls.Add(this.btnEditBloodGroup);
            this.Controls.Add(this.btnAddBloodGroup);
            this.Controls.Add(this.dgvBloodGroup);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BloodGroupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qan qrupu";
            this.Load += new System.EventHandler(this.BloodGroupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBloodGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBloodGroup;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.Button btnDeleteBloodGroup;
        private System.Windows.Forms.Button btnEditBloodGroup;
        private System.Windows.Forms.Button btnAddBloodGroup;
        private System.Windows.Forms.DataGridView dgvBloodGroup;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}