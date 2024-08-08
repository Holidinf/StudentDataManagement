namespace StudentDataManagement
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.TextBox txtJurusan;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.PictureBox picStudent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label NAMA;
        private System.Windows.Forms.Label NIM;
        private System.Windows.Forms.Label MAJOR;
        private System.Windows.Forms.TextBox textsearchdelete;
        private System.Windows.Forms.Button exit;

        private void InitializeComponent()
        {
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.txtJurusan = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.picStudent = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.NAMA = new System.Windows.Forms.Label();
            this.NIM = new System.Windows.Forms.Label();
            this.MAJOR = new System.Windows.Forms.Label();
            this.textsearchdelete = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(78, 15);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(193, 20);
            this.txtNama.TabIndex = 0;
            // 
            // txtNIM
            // 
            this.txtNIM.Location = new System.Drawing.Point(78, 45);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(193, 20);
            this.txtNIM.TabIndex = 1;
            // 
            // txtJurusan
            // 
            this.txtJurusan.Location = new System.Drawing.Point(78, 75);
            this.txtJurusan.Name = "txtJurusan";
            this.txtJurusan.Size = new System.Drawing.Size(193, 20);
            this.txtJurusan.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(15, 132);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(103, 132);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(196, 132);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(301, 132);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 6;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // picStudent
            // 
            this.picStudent.Location = new System.Drawing.Point(290, 15);
            this.picStudent.Name = "picStudent";
            this.picStudent.Size = new System.Drawing.Size(100, 111);
            this.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStudent.TabIndex = 7;
            this.picStudent.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 200);
            this.dataGridView1.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NAMA
            // 
            this.NAMA.AutoSize = true;
            this.NAMA.Location = new System.Drawing.Point(15, 18);
            this.NAMA.Name = "NAMA";
            this.NAMA.Size = new System.Drawing.Size(38, 13);
            this.NAMA.TabIndex = 9;
            this.NAMA.Text = "Name:";
            // 
            // NIM
            // 
            this.NIM.AutoSize = true;
            this.NIM.Location = new System.Drawing.Point(15, 48);
            this.NIM.Name = "NIM";
            this.NIM.Size = new System.Drawing.Size(30, 13);
            this.NIM.TabIndex = 10;
            this.NIM.Text = "NIM:";
            // 
            // MAJOR
            // 
            this.MAJOR.AutoSize = true;
            this.MAJOR.Location = new System.Drawing.Point(15, 78);
            this.MAJOR.Name = "MAJOR";
            this.MAJOR.Size = new System.Drawing.Size(36, 13);
            this.MAJOR.TabIndex = 11;
            this.MAJOR.Text = "Major:";
            // 
            // textsearchdelete
            // 
            this.textsearchdelete.Location = new System.Drawing.Point(18, 106);
            this.textsearchdelete.Name = "textsearchdelete";
            this.textsearchdelete.Size = new System.Drawing.Size(172, 20);
            this.textsearchdelete.TabIndex = 12;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(196, 106);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 13;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click_1);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(536, 382);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.textsearchdelete);
            this.Controls.Add(this.MAJOR);
            this.Controls.Add(this.NIM);
            this.Controls.Add(this.NAMA);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.picStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtJurusan);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.txtNama);
            this.Name = "Form1";
            this.Text = "Student Data Management";
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
