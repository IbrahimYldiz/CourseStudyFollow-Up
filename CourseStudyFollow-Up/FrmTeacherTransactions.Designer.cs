
namespace CourseStudyFollow_Up
{
    partial class FrmTeacherTransactions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.RchTeacherAdress = new System.Windows.Forms.RichTextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.CmbTeacherLesson = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.TxtTeacherName = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.lblid = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._DBCourseStudyFollow_UpDataSet = new CourseStudyFollow_Up._DBCourseStudyFollow_UpDataSet();
            this.tblTeacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblTeacherTableAdapter = new CourseStudyFollow_Up._DBCourseStudyFollow_UpDataSetTableAdapters.TblTeacherTableAdapter();
            this.panel1.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DBCourseStudyFollow_UpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTeacherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnUpdate);
            this.panel1.Controls.Add(this.panel16);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 470);
            this.panel1.TabIndex = 0;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.BtnUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnUpdate.Location = new System.Drawing.Point(179, 394);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(199, 54);
            this.BtnUpdate.TabIndex = 10;
            this.BtnUpdate.Text = "Güncelle";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // panel16
            // 
            this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel16.Location = new System.Drawing.Point(179, 384);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(199, 10);
            this.panel16.TabIndex = 9;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSave.Location = new System.Drawing.Point(179, 330);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(199, 54);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.RchTeacherAdress);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(179, 207);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(199, 123);
            this.panel14.TabIndex = 7;
            // 
            // RchTeacherAdress
            // 
            this.RchTeacherAdress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RchTeacherAdress.Location = new System.Drawing.Point(0, 0);
            this.RchTeacherAdress.Name = "RchTeacherAdress";
            this.RchTeacherAdress.Size = new System.Drawing.Size(199, 123);
            this.RchTeacherAdress.TabIndex = 0;
            this.RchTeacherAdress.Text = "";
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(179, 192);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(199, 15);
            this.panel12.TabIndex = 6;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.maskedTextBox1);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(179, 141);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(199, 51);
            this.panel13.TabIndex = 5;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.maskedTextBox1.Location = new System.Drawing.Point(0, 21);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(199, 30);
            this.maskedTextBox1.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.CmbTeacherLesson);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(179, 88);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(199, 53);
            this.panel8.TabIndex = 4;
            // 
            // CmbTeacherLesson
            // 
            this.CmbTeacherLesson.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CmbTeacherLesson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTeacherLesson.FormattingEnabled = true;
            this.CmbTeacherLesson.Location = new System.Drawing.Point(0, 20);
            this.CmbTeacherLesson.Name = "CmbTeacherLesson";
            this.CmbTeacherLesson.Size = new System.Drawing.Size(199, 33);
            this.CmbTeacherLesson.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.TxtTeacherName);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(179, 47);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(199, 41);
            this.panel7.TabIndex = 2;
            // 
            // TxtTeacherName
            // 
            this.TxtTeacherName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TxtTeacherName.Location = new System.Drawing.Point(0, 11);
            this.TxtTeacherName.Name = "TxtTeacherName";
            this.TxtTeacherName.Size = new System.Drawing.Size(199, 30);
            this.TxtTeacherName.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(179, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(199, 47);
            this.panel5.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnDelete);
            this.panel3.Controls.Add(this.panel15);
            this.panel3.Controls.Add(this.panel11);
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 470);
            this.panel3.TabIndex = 0;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDelete.Location = new System.Drawing.Point(0, 330);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(179, 54);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.lblid);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 250);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(179, 80);
            this.panel15.TabIndex = 5;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(48, 22);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(23, 25);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "0";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label5);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 200);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(179, 50);
            this.panel11.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 50);
            this.label5.TabIndex = 1;
            this.label5.Text = "Adresi";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label4);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 150);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(179, 50);
            this.panel10.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 50);
            this.label4.TabIndex = 1;
            this.label4.Text = "Telefon Numarası";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label3);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 100);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(179, 50);
            this.panel9.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 50);
            this.label3.TabIndex = 1;
            this.label3.Text = "Branşı";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 50);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(179, 50);
            this.panel6.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı Soyadı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(179, 50);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğretmenin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(378, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1038, 470);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1038, 470);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // _DBCourseStudyFollow_UpDataSet
            // 
            this._DBCourseStudyFollow_UpDataSet.DataSetName = "_DBCourseStudyFollow_UpDataSet";
            this._DBCourseStudyFollow_UpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTeacherBindingSource
            // 
            this.tblTeacherBindingSource.DataMember = "TblTeacher";
            this.tblTeacherBindingSource.DataSource = this._DBCourseStudyFollow_UpDataSet;
            // 
            // tblTeacherTableAdapter
            // 
            this.tblTeacherTableAdapter.ClearBeforeFill = true;
            // 
            // FrmTeacherTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1416, 470);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmTeacherTransactions";
            this.Text = "Öğretmen İşlemleri";
            this.Load += new System.EventHandler(this.FrmLessonProcedures_Load);
            this.panel1.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DBCourseStudyFollow_UpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTeacherBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.RichTextBox RchTeacherAdress;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox CmbTeacherLesson;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox TxtTeacherName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private _DBCourseStudyFollow_UpDataSet _DBCourseStudyFollow_UpDataSet;
        private System.Windows.Forms.BindingSource tblTeacherBindingSource;
        private _DBCourseStudyFollow_UpDataSetTableAdapters.TblTeacherTableAdapter tblTeacherTableAdapter;
    }
}