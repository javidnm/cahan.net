namespace SearchForm
{
    partial class EyeColorForm
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
            this.txtEyeColor = new System.Windows.Forms.TextBox();
            this.lblEyeColor = new System.Windows.Forms.Label();
            this.btnDeleteEyeColor = new System.Windows.Forms.Button();
            this.btnEditEyeColor = new System.Windows.Forms.Button();
            this.btnAddEyeColor = new System.Windows.Forms.Button();
            this.dgvEyeColor = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEyeColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEyeColor
            // 
            this.txtEyeColor.Location = new System.Drawing.Point(178, 31);
            this.txtEyeColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEyeColor.Name = "txtEyeColor";
            this.txtEyeColor.Size = new System.Drawing.Size(260, 20);
            this.txtEyeColor.TabIndex = 21;
            // 
            // lblEyeColor
            // 
            this.lblEyeColor.AutoSize = true;
            this.lblEyeColor.Location = new System.Drawing.Point(98, 34);
            this.lblEyeColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEyeColor.Name = "lblEyeColor";
            this.lblEyeColor.Size = new System.Drawing.Size(52, 13);
            this.lblEyeColor.TabIndex = 20;
            this.lblEyeColor.Text = "Göz rəngi";
            // 
            // btnDeleteEyeColor
            // 
            this.btnDeleteEyeColor.Location = new System.Drawing.Point(368, 285);
            this.btnDeleteEyeColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteEyeColor.Name = "btnDeleteEyeColor";
            this.btnDeleteEyeColor.Size = new System.Drawing.Size(118, 35);
            this.btnDeleteEyeColor.TabIndex = 17;
            this.btnDeleteEyeColor.Text = "Sil";
            this.btnDeleteEyeColor.UseVisualStyleBackColor = true;
            this.btnDeleteEyeColor.Click += new System.EventHandler(this.btnDeleteEyeColor_Click);
            // 
            // btnEditEyeColor
            // 
            this.btnEditEyeColor.Location = new System.Drawing.Point(204, 285);
            this.btnEditEyeColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditEyeColor.Name = "btnEditEyeColor";
            this.btnEditEyeColor.Size = new System.Drawing.Size(138, 35);
            this.btnEditEyeColor.TabIndex = 18;
            this.btnEditEyeColor.Text = "Redaktə et";
            this.btnEditEyeColor.UseVisualStyleBackColor = true;
            this.btnEditEyeColor.Click += new System.EventHandler(this.btnEditEyeColor_Click);
            // 
            // btnAddEyeColor
            // 
            this.btnAddEyeColor.Location = new System.Drawing.Point(74, 285);
            this.btnAddEyeColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddEyeColor.Name = "btnAddEyeColor";
            this.btnAddEyeColor.Size = new System.Drawing.Size(100, 35);
            this.btnAddEyeColor.TabIndex = 19;
            this.btnAddEyeColor.Text = "Əlavə et";
            this.btnAddEyeColor.UseVisualStyleBackColor = true;
            this.btnAddEyeColor.Click += new System.EventHandler(this.btnAddEyeColor_Click);
            // 
            // dgvEyeColor
            // 
            this.dgvEyeColor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEyeColor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEyeColor.Location = new System.Drawing.Point(65, 69);
            this.dgvEyeColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEyeColor.Name = "dgvEyeColor";
            this.dgvEyeColor.RowTemplate.Height = 33;
            this.dgvEyeColor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEyeColor.Size = new System.Drawing.Size(422, 186);
            this.dgvEyeColor.TabIndex = 16;
            this.dgvEyeColor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEyeColor_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EyeColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 351);
            this.Controls.Add(this.txtEyeColor);
            this.Controls.Add(this.lblEyeColor);
            this.Controls.Add(this.btnDeleteEyeColor);
            this.Controls.Add(this.btnEditEyeColor);
            this.Controls.Add(this.btnAddEyeColor);
            this.Controls.Add(this.dgvEyeColor);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EyeColorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Goz rengi";
            this.Load += new System.EventHandler(this.EyeColorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEyeColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEyeColor;
        private System.Windows.Forms.Label lblEyeColor;
        private System.Windows.Forms.Button btnDeleteEyeColor;
        private System.Windows.Forms.Button btnEditEyeColor;
        private System.Windows.Forms.Button btnAddEyeColor;
        private System.Windows.Forms.DataGridView dgvEyeColor;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}