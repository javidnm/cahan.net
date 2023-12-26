namespace SearchForm
{
    partial class MilitarysStatusForm
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
            this.txtMilitaryStatus = new System.Windows.Forms.TextBox();
            this.lblMartialSTatus = new System.Windows.Forms.Label();
            this.btnDeleteMilitaryStatus = new System.Windows.Forms.Button();
            this.btnEditMilitaryStatus = new System.Windows.Forms.Button();
            this.btnAddMilitaryStatus = new System.Windows.Forms.Button();
            this.dgvMilitaryStatus = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMilitaryStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMilitaryStatus
            // 
            this.txtMilitaryStatus.Location = new System.Drawing.Point(376, 39);
            this.txtMilitaryStatus.Name = "txtMilitaryStatus";
            this.txtMilitaryStatus.Size = new System.Drawing.Size(517, 31);
            this.txtMilitaryStatus.TabIndex = 15;
            // 
            // lblMartialSTatus
            // 
            this.lblMartialSTatus.AutoSize = true;
            this.lblMartialSTatus.Location = new System.Drawing.Point(132, 45);
            this.lblMartialSTatus.Name = "lblMartialSTatus";
            this.lblMartialSTatus.Size = new System.Drawing.Size(200, 25);
            this.lblMartialSTatus.TabIndex = 14;
            this.lblMartialSTatus.Text = "Herbi mukellefiyyet:";
            // 
            // btnDeleteMilitaryStatus
            // 
            this.btnDeleteMilitaryStatus.Location = new System.Drawing.Point(672, 528);
            this.btnDeleteMilitaryStatus.Name = "btnDeleteMilitaryStatus";
            this.btnDeleteMilitaryStatus.Size = new System.Drawing.Size(237, 67);
            this.btnDeleteMilitaryStatus.TabIndex = 11;
            this.btnDeleteMilitaryStatus.Text = "Sil";
            this.btnDeleteMilitaryStatus.UseVisualStyleBackColor = true;
            this.btnDeleteMilitaryStatus.Click += new System.EventHandler(this.btnDeleteMilitaryStatus_Click);
            // 
            // btnEditMilitaryStatus
            // 
            this.btnEditMilitaryStatus.Location = new System.Drawing.Point(343, 528);
            this.btnEditMilitaryStatus.Name = "btnEditMilitaryStatus";
            this.btnEditMilitaryStatus.Size = new System.Drawing.Size(276, 67);
            this.btnEditMilitaryStatus.TabIndex = 12;
            this.btnEditMilitaryStatus.Text = "Redakte et";
            this.btnEditMilitaryStatus.UseVisualStyleBackColor = true;
            this.btnEditMilitaryStatus.Click += new System.EventHandler(this.btnEditMilitaryStatus_Click);
            // 
            // btnAddMilitaryStatus
            // 
            this.btnAddMilitaryStatus.Location = new System.Drawing.Point(85, 528);
            this.btnAddMilitaryStatus.Name = "btnAddMilitaryStatus";
            this.btnAddMilitaryStatus.Size = new System.Drawing.Size(200, 67);
            this.btnAddMilitaryStatus.TabIndex = 13;
            this.btnAddMilitaryStatus.Text = "Elave et";
            this.btnAddMilitaryStatus.UseVisualStyleBackColor = true;
            this.btnAddMilitaryStatus.Click += new System.EventHandler(this.btnAddMilitaryStatus_Click);
            // 
            // dgvMilitaryStatus
            // 
            this.dgvMilitaryStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMilitaryStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMilitaryStatus.Location = new System.Drawing.Point(66, 113);
            this.dgvMilitaryStatus.Name = "dgvMilitaryStatus";
            this.dgvMilitaryStatus.RowTemplate.Height = 33;
            this.dgvMilitaryStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMilitaryStatus.Size = new System.Drawing.Size(843, 357);
            this.dgvMilitaryStatus.TabIndex = 10;
            this.dgvMilitaryStatus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMilitaryStatus_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MilitarysStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 685);
            this.Controls.Add(this.txtMilitaryStatus);
            this.Controls.Add(this.lblMartialSTatus);
            this.Controls.Add(this.btnDeleteMilitaryStatus);
            this.Controls.Add(this.btnEditMilitaryStatus);
            this.Controls.Add(this.btnAddMilitaryStatus);
            this.Controls.Add(this.dgvMilitaryStatus);
            this.Name = "MilitarysStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Herbi mukellefiyyet:";
            this.Load += new System.EventHandler(this.MilitarysStatusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMilitaryStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMilitaryStatus;
        private System.Windows.Forms.Label lblMartialSTatus;
        private System.Windows.Forms.Button btnDeleteMilitaryStatus;
        private System.Windows.Forms.Button btnEditMilitaryStatus;
        private System.Windows.Forms.Button btnAddMilitaryStatus;
        private System.Windows.Forms.DataGridView dgvMilitaryStatus;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}