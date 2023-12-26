namespace SearchForm
{
    partial class MartialStatusForm
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
            this.txtMartialStatus = new System.Windows.Forms.TextBox();
            this.lblMartialSTatus = new System.Windows.Forms.Label();
            this.btnDeleteMartialStatus = new System.Windows.Forms.Button();
            this.btnEditMartialStatus = new System.Windows.Forms.Button();
            this.btnAddMartialStatus = new System.Windows.Forms.Button();
            this.dgvMartialStatus = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMartialStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMartialStatus
            // 
            this.txtMartialStatus.Location = new System.Drawing.Point(358, 46);
            this.txtMartialStatus.Name = "txtMartialStatus";
            this.txtMartialStatus.Size = new System.Drawing.Size(517, 31);
            this.txtMartialStatus.TabIndex = 9;
            // 
            // lblMartialSTatus
            // 
            this.lblMartialSTatus.AutoSize = true;
            this.lblMartialSTatus.Location = new System.Drawing.Point(174, 46);
            this.lblMartialSTatus.Name = "lblMartialSTatus";
            this.lblMartialSTatus.Size = new System.Drawing.Size(144, 25);
            this.lblMartialSTatus.TabIndex = 8;
            this.lblMartialSTatus.Text = "Aile veziyyeti:";
            // 
            // btnDeleteMartialStatus
            // 
            this.btnDeleteMartialStatus.Location = new System.Drawing.Point(741, 524);
            this.btnDeleteMartialStatus.Name = "btnDeleteMartialStatus";
            this.btnDeleteMartialStatus.Size = new System.Drawing.Size(237, 67);
            this.btnDeleteMartialStatus.TabIndex = 5;
            this.btnDeleteMartialStatus.Text = "Sil";
            this.btnDeleteMartialStatus.UseVisualStyleBackColor = true;
            this.btnDeleteMartialStatus.Click += new System.EventHandler(this.btnDeleteMartialStatus_Click);
            // 
            // btnEditMartialStatus
            // 
            this.btnEditMartialStatus.Location = new System.Drawing.Point(412, 524);
            this.btnEditMartialStatus.Name = "btnEditMartialStatus";
            this.btnEditMartialStatus.Size = new System.Drawing.Size(276, 67);
            this.btnEditMartialStatus.TabIndex = 6;
            this.btnEditMartialStatus.Text = "Redakte et";
            this.btnEditMartialStatus.UseVisualStyleBackColor = true;
            this.btnEditMartialStatus.Click += new System.EventHandler(this.btnEditMartialStatus_Click);
            // 
            // btnAddMartialStatus
            // 
            this.btnAddMartialStatus.Location = new System.Drawing.Point(154, 524);
            this.btnAddMartialStatus.Name = "btnAddMartialStatus";
            this.btnAddMartialStatus.Size = new System.Drawing.Size(200, 67);
            this.btnAddMartialStatus.TabIndex = 7;
            this.btnAddMartialStatus.Text = "Elave et";
            this.btnAddMartialStatus.UseVisualStyleBackColor = true;
            this.btnAddMartialStatus.Click += new System.EventHandler(this.btnAddMartialStatus_Click);
            // 
            // dgvMartialStatus
            // 
            this.dgvMartialStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMartialStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMartialStatus.Location = new System.Drawing.Point(135, 140);
            this.dgvMartialStatus.Name = "dgvMartialStatus";
            this.dgvMartialStatus.RowTemplate.Height = 33;
            this.dgvMartialStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMartialStatus.Size = new System.Drawing.Size(843, 357);
            this.dgvMartialStatus.TabIndex = 4;
            this.dgvMartialStatus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMartialStatus_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MartialStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 637);
            this.Controls.Add(this.txtMartialStatus);
            this.Controls.Add(this.lblMartialSTatus);
            this.Controls.Add(this.btnDeleteMartialStatus);
            this.Controls.Add(this.btnEditMartialStatus);
            this.Controls.Add(this.btnAddMartialStatus);
            this.Controls.Add(this.dgvMartialStatus);
            this.Name = "MartialStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aile veziyyeti";
            this.Load += new System.EventHandler(this.MartialStatusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMartialStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMartialStatus;
        private System.Windows.Forms.Label lblMartialSTatus;
        private System.Windows.Forms.Button btnDeleteMartialStatus;
        private System.Windows.Forms.Button btnEditMartialStatus;
        private System.Windows.Forms.Button btnAddMartialStatus;
        private System.Windows.Forms.DataGridView dgvMartialStatus;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}