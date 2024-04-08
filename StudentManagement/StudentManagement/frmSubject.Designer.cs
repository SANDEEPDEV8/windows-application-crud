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
            this.studentDataSet1 = new StudentManagement.StudentDataSet();
            this.getStudentSubjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getStudentSubjectTableAdapter1 = new StudentManagement.StudentDataSetTableAdapters.GetStudentSubjectTableAdapter();
            this.studentDataSet11 = new StudentManagement.StudentDataSet1();
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectsTableAdapter = new StudentManagement.StudentDataSet1TableAdapters.SubjectsTableAdapter();
            this.subjectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnremove = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudentSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getStudentSubjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
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
            this.dataGridViewTextBoxColumn1,
            this.subjectCodeDataGridViewTextBoxColumn,
            this.subjectTypeDataGridViewTextBoxColumn,
            this.creditDataGridViewTextBoxColumn});
            this.DGVStudentSubject.DataSource = this.getStudentSubjectBindingSource;
            this.DGVStudentSubject.Location = new System.Drawing.Point(12, 82);
            this.DGVStudentSubject.MultiSelect = false;
            this.DGVStudentSubject.Name = "DGVStudentSubject";
            this.DGVStudentSubject.ReadOnly = true;
            this.DGVStudentSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVStudentSubject.Size = new System.Drawing.Size(523, 150);
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
            this.dataGridViewTextBoxColumn3,
            this.subjectCodeDataGridViewTextBoxColumn1,
            this.subjectTypeDataGridViewTextBoxColumn1,
            this.creditDataGridViewTextBoxColumn1});
            this.DGVSubject.DataSource = this.subjectsBindingSource;
            this.DGVSubject.Location = new System.Drawing.Point(13, 312);
            this.DGVSubject.MultiSelect = false;
            this.DGVSubject.Name = "DGVSubject";
            this.DGVSubject.ReadOnly = true;
            this.DGVSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSubject.Size = new System.Drawing.Size(522, 150);
            this.DGVSubject.TabIndex = 1;
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(391, 276);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(133, 26);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Add Selected";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enrolled Subjects";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Available Subjects";
            // 
            // studentDataSet1
            // 
            this.studentDataSet1.DataSetName = "StudentDataSet";
            this.studentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getStudentSubjectBindingSource
            // 
            this.getStudentSubjectBindingSource.DataMember = "GetStudentSubject";
            this.getStudentSubjectBindingSource.DataSource = this.studentDataSet1;
            // 
            // getStudentSubjectTableAdapter1
            // 
            this.getStudentSubjectTableAdapter1.ClearBeforeFill = true;
            // 
            // studentDataSet11
            // 
            this.studentDataSet11.DataSetName = "StudentDataSet1";
            this.studentDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectsBindingSource
            // 
            this.subjectsBindingSource.DataMember = "Subjects";
            this.subjectsBindingSource.DataSource = this.studentDataSet11;
            // 
            // subjectsTableAdapter
            // 
            this.subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // subjectIDDataGridViewTextBoxColumn
            // 
            this.subjectIDDataGridViewTextBoxColumn.DataPropertyName = "SubjectID";
            this.subjectIDDataGridViewTextBoxColumn.HeaderText = "SubjectID";
            this.subjectIDDataGridViewTextBoxColumn.Name = "subjectIDDataGridViewTextBoxColumn";
            this.subjectIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.subjectIDDataGridViewTextBoxColumn.Visible = false;
            this.subjectIDDataGridViewTextBoxColumn.Width = 10;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SubjectName";
            this.dataGridViewTextBoxColumn3.HeaderText = "SubjectName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // subjectCodeDataGridViewTextBoxColumn1
            // 
            this.subjectCodeDataGridViewTextBoxColumn1.DataPropertyName = "SubjectCode";
            this.subjectCodeDataGridViewTextBoxColumn1.HeaderText = "SubjectCode";
            this.subjectCodeDataGridViewTextBoxColumn1.Name = "subjectCodeDataGridViewTextBoxColumn1";
            this.subjectCodeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // subjectTypeDataGridViewTextBoxColumn1
            // 
            this.subjectTypeDataGridViewTextBoxColumn1.DataPropertyName = "SubjectType";
            this.subjectTypeDataGridViewTextBoxColumn1.HeaderText = "SubjectType";
            this.subjectTypeDataGridViewTextBoxColumn1.Name = "subjectTypeDataGridViewTextBoxColumn1";
            this.subjectTypeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // creditDataGridViewTextBoxColumn1
            // 
            this.creditDataGridViewTextBoxColumn1.DataPropertyName = "Credit";
            this.creditDataGridViewTextBoxColumn1.HeaderText = "Credit";
            this.creditDataGridViewTextBoxColumn1.Name = "creditDataGridViewTextBoxColumn1";
            this.creditDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // btnremove
            // 
            this.btnremove.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.Location = new System.Drawing.Point(368, 50);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(156, 26);
            this.btnremove.TabIndex = 6;
            this.btnremove.Text = "Remove Selected";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click_1);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StudentSubjectID";
            this.dataGridViewTextBoxColumn2.HeaderText = "StudentSubjectID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SubjectName";
            this.dataGridViewTextBoxColumn1.HeaderText = "SubjectName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // subjectCodeDataGridViewTextBoxColumn
            // 
            this.subjectCodeDataGridViewTextBoxColumn.DataPropertyName = "SubjectCode";
            this.subjectCodeDataGridViewTextBoxColumn.HeaderText = "SubjectCode";
            this.subjectCodeDataGridViewTextBoxColumn.Name = "subjectCodeDataGridViewTextBoxColumn";
            this.subjectCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.subjectCodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // subjectTypeDataGridViewTextBoxColumn
            // 
            this.subjectTypeDataGridViewTextBoxColumn.DataPropertyName = "SubjectType";
            this.subjectTypeDataGridViewTextBoxColumn.HeaderText = "SubjectType";
            this.subjectTypeDataGridViewTextBoxColumn.Name = "subjectTypeDataGridViewTextBoxColumn";
            this.subjectTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.subjectTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // creditDataGridViewTextBoxColumn
            // 
            this.creditDataGridViewTextBoxColumn.DataPropertyName = "Credit";
            this.creditDataGridViewTextBoxColumn.HeaderText = "Credit";
            this.creditDataGridViewTextBoxColumn.Name = "creditDataGridViewTextBoxColumn";
            this.creditDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(473, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 517);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.DGVSubject);
            this.Controls.Add(this.DGVStudentSubject);
            this.Name = "frmSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrolled Subjects";
            this.Load += new System.EventHandler(this.frmSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudentSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getStudentSubjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVStudentSubject;
        private System.Windows.Forms.DataGridView DGVSubject;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private StudentDataSet studentDataSet;
        private StudentDataSetTableAdapters.GetStudentSubjectTableAdapter getStudentSubjectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSubjectIDDataGridViewTextBoxColumn;
        private StudentDataSet studentDataSet1;
        private System.Windows.Forms.BindingSource getStudentSubjectBindingSource;
        private StudentDataSetTableAdapters.GetStudentSubjectTableAdapter getStudentSubjectTableAdapter1;
        private StudentDataSet1 studentDataSet11;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
        private StudentDataSet1TableAdapters.SubjectsTableAdapter subjectsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}