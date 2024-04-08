namespace StudentManagement
{
    partial class frmSubject
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
            this.DGVStudentSubject = new System.Windows.Forms.DataGridView();
            this.DGVSubject = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnremove = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet11 = new StudentManagement.SongDataSet1();
            this.subjectsTableAdapter = new StudentManagement.SongDataSet1TableAdapters.SongTableAdapter();
            this.getStudentSubjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet1 = new StudentManagement.SongDataSet();
            this.getStudentSubjectTableAdapter1 = new StudentManagement.SongDataSetTableAdapters.GetStudentSubjectTableAdapter();
            this.subjectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Likes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudentSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getStudentSubjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVStudentSubject
            // 
            this.DGVStudentSubject.AllowUserToAddRows = false;
            this.DGVStudentSubject.AllowUserToDeleteRows = false;
            this.DGVStudentSubject.AutoGenerateColumns = false;
            this.DGVStudentSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStudentSubject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.DGVStudentSubject.DataSource = this.getStudentSubjectBindingSource;
            this.DGVStudentSubject.Location = new System.Drawing.Point(12, 102);
            this.DGVStudentSubject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGVStudentSubject.MultiSelect = false;
            this.DGVStudentSubject.Name = "DGVStudentSubject";
            this.DGVStudentSubject.ReadOnly = true;
            this.DGVStudentSubject.RowHeadersWidth = 51;
            this.DGVStudentSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVStudentSubject.Size = new System.Drawing.Size(697, 185);
            this.DGVStudentSubject.TabIndex = 0;
            // 
            // DGVSubject
            // 
            this.DGVSubject.AllowUserToAddRows = false;
            this.DGVSubject.AllowUserToDeleteRows = false;
            this.DGVSubject.AutoGenerateColumns = false;
            this.DGVSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSubject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectIDDataGridViewTextBoxColumn,
            this.Title,
            this.Artist,
            this.Genre,
            this.Likes});
            this.DGVSubject.DataSource = this.subjectsBindingSource;
            this.DGVSubject.Location = new System.Drawing.Point(13, 380);
            this.DGVSubject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGVSubject.MultiSelect = false;
            this.DGVSubject.Name = "DGVSubject";
            this.DGVSubject.ReadOnly = true;
            this.DGVSubject.RowHeadersWidth = 51;
            this.DGVSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSubject.Size = new System.Drawing.Size(696, 185);
            this.DGVSubject.TabIndex = 1;
            this.DGVSubject.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSubject_CellContentClick);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnadd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(521, 340);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(177, 32);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Add Selected";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Playlist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 345);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Discover new music";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnremove.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.Location = new System.Drawing.Point(491, 62);
            this.btnremove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(208, 32);
            this.btnremove.TabIndex = 6;
            this.btnremove.Text = "Remove Selected";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(631, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // subjectsBindingSource
            // 
            this.subjectsBindingSource.DataMember = "Song";
            this.subjectsBindingSource.DataSource = this.studentDataSet11;
            // 
            // studentDataSet11
            // 
            this.studentDataSet11.DataSetName = "StudentDataSet1";
            this.studentDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectsTableAdapter
            // 
            this.subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // getStudentSubjectBindingSource
            // 
            this.getStudentSubjectBindingSource.DataMember = "GetStudentSubject";
            this.getStudentSubjectBindingSource.DataSource = this.studentDataSet1;
            // 
            // studentDataSet1
            // 
            this.studentDataSet1.DataSetName = "StudentDataSet";
            this.studentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getStudentSubjectTableAdapter1
            // 
            this.getStudentSubjectTableAdapter1.ClearBeforeFill = true;
            // 
            // subjectIDDataGridViewTextBoxColumn
            // 
            this.subjectIDDataGridViewTextBoxColumn.DataPropertyName = "SubjectID";
            this.subjectIDDataGridViewTextBoxColumn.HeaderText = "SubjectID";
            this.subjectIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectIDDataGridViewTextBoxColumn.Name = "subjectIDDataGridViewTextBoxColumn";
            this.subjectIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.subjectIDDataGridViewTextBoxColumn.Visible = false;
            this.subjectIDDataGridViewTextBoxColumn.Width = 10;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 125;
            // 
            // Artist
            // 
            this.Artist.DataPropertyName = "Artist";
            this.Artist.HeaderText = "Artist";
            this.Artist.MinimumWidth = 6;
            this.Artist.Name = "Artist";
            this.Artist.ReadOnly = true;
            this.Artist.Width = 125;
            // 
            // Genre
            // 
            this.Genre.DataPropertyName = "Genre";
            this.Genre.HeaderText = "Genre";
            this.Genre.MinimumWidth = 6;
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            this.Genre.Width = 125;
            // 
            // Likes
            // 
            this.Likes.DataPropertyName = "Likes";
            this.Likes.HeaderText = "Likes";
            this.Likes.MinimumWidth = 6;
            this.Likes.Name = "Likes";
            this.Likes.ReadOnly = true;
            this.Likes.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StudentSubjectID";
            this.dataGridViewTextBoxColumn2.HeaderText = "StudentSubjectID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Artist";
            this.dataGridViewTextBoxColumn4.HeaderText = "Artist";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Likes";
            this.dataGridViewTextBoxColumn5.HeaderText = "Likes";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn6.HeaderText = "Title";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // frmSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(735, 636);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.DGVSubject);
            this.Controls.Add(this.DGVStudentSubject);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrolled Subjects";
            this.Load += new System.EventHandler(this.frmSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudentSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getStudentSubjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVStudentSubject;
        private System.Windows.Forms.DataGridView DGVSubject;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private SongDataSet studentDataSet;
        private SongDataSetTableAdapters.GetStudentSubjectTableAdapter getStudentSubjectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSubjectIDDataGridViewTextBoxColumn;
        private SongDataSet studentDataSet1;
        private System.Windows.Forms.BindingSource getStudentSubjectBindingSource;
        private SongDataSetTableAdapters.GetStudentSubjectTableAdapter getStudentSubjectTableAdapter1;
        private SongDataSet1 studentDataSet11;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
        private SongDataSet1TableAdapters.SongTableAdapter subjectsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Likes;
    }
}