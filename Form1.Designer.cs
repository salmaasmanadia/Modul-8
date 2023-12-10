namespace Modul_9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbNama = new Label();
            lbAlamat = new Label();
            lbHp = new Label();
            tbNama = new TextBox();
            tbAlamat = new TextBox();
            tbHp = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnQR = new Button();
            dgv = new DataGridView();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // lbNama
            // 
            lbNama.AutoSize = true;
            lbNama.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbNama.Location = new Point(29, 42);
            lbNama.Name = "lbNama";
            lbNama.Size = new Size(39, 15);
            lbNama.TabIndex = 0;
            lbNama.Text = "Nama";
            // 
            // lbAlamat
            // 
            lbAlamat.AutoSize = true;
            lbAlamat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbAlamat.Location = new Point(29, 78);
            lbAlamat.Name = "lbAlamat";
            lbAlamat.Size = new Size(46, 15);
            lbAlamat.TabIndex = 1;
            lbAlamat.Text = "Alamat";
            // 
            // lbHp
            // 
            lbHp.AutoSize = true;
            lbHp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbHp.Location = new Point(29, 115);
            lbHp.Name = "lbHp";
            lbHp.Size = new Size(93, 15);
            lbHp.TabIndex = 2;
            lbHp.Text = "No. Handphone";
            // 
            // tbNama
            // 
            tbNama.Location = new Point(142, 34);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(155, 23);
            tbNama.TabIndex = 3;
            // 
            // tbAlamat
            // 
            tbAlamat.Location = new Point(142, 70);
            tbAlamat.Name = "tbAlamat";
            tbAlamat.Size = new Size(155, 23);
            tbAlamat.TabIndex = 4;
            // 
            // tbHp
            // 
            tbHp.Location = new Point(142, 107);
            tbHp.Name = "tbHp";
            tbHp.Size = new Size(155, 23);
            tbHp.TabIndex = 5;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.ScrollBar;
            btnInsert.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.ForeColor = SystemColors.ActiveCaptionText;
            btnInsert.Location = new Point(320, 37);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(97, 84);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ScrollBar;
            btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.ActiveCaptionText;
            btnUpdate.Location = new Point(433, 37);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(97, 84);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ScrollBar;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnDelete.Location = new Point(546, 37);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(97, 84);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnQR
            // 
            btnQR.BackColor = SystemColors.ScrollBar;
            btnQR.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnQR.ForeColor = SystemColors.ActiveCaptionText;
            btnQR.Location = new Point(664, 37);
            btnQR.Name = "btnQR";
            btnQR.Size = new Size(97, 84);
            btnQR.TabIndex = 9;
            btnQR.Text = "Generate QR";
            btnQR.UseVisualStyleBackColor = false;
            btnQR.Click += btnQR_Click;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(29, 178);
            dgv.Name = "dgv";
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(732, 191);
            dgv.TabIndex = 10;
            dgv.CellContentClick += dgv_CellContentClick;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = SystemColors.ScrollBar;
            btnLoad.Location = new Point(664, 396);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(97, 31);
            btnLoad.TabIndex = 11;
            btnLoad.Text = "Load Data";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoad);
            Controls.Add(dgv);
            Controls.Add(btnQR);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(tbHp);
            Controls.Add(tbAlamat);
            Controls.Add(tbNama);
            Controls.Add(lbHp);
            Controls.Add(lbAlamat);
            Controls.Add(lbNama);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNama;
        private Label lbAlamat;
        private Label lbHp;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnQR;
        private DataGridView dgv;
        private Button btnLoad;
        public TextBox tbNama;
        public TextBox tbAlamat;
        public TextBox tbHp;
    }
}