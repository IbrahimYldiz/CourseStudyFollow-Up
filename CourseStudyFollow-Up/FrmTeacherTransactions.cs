using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CourseStudyFollow_Up
{
    public partial class FrmTeacherTransactions : Form
    {
        public FrmTeacherTransactions()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-OC5036T\MSSQLSERVER1;Initial Catalog=DBCourseStudyFollow-Up;Integrated Security=True");
        void Teacherlist()
        {
            SqlDataAdapter da = new SqlDataAdapter("execute TeacherList ", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void LessonList()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("select * from TblLesson", connection);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            CmbTeacherLesson.ValueMember = "LessonID";
            CmbTeacherLesson.DisplayMember = "LessonName";
            CmbTeacherLesson.DataSource = dt1;

        }
        private void FrmLessonProcedures_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_DBCourseStudyFollow_UpDataSet.TblTeacher' table. You can move, or remove it, as needed.
            this.tblTeacherTableAdapter.Fill(this._DBCourseStudyFollow_UpDataSet.TblTeacher);
            Teacherlist();
            LessonList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtTeacherName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            CmbTeacherLesson.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            RchTeacherAdress.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(TxtTeacherName.Text.Trim()!=""&& CmbTeacherLesson.SelectedValue.ToString().Trim() != "0" && maskedTextBox1.Text.Trim()!= "(   )    -" && RchTeacherAdress.Text.Trim() != "")
            {
                DialogResult result = MessageBox.Show("Öğretmen Kaydını Onaylıyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    SqlCommand command = new SqlCommand("insert into TblTeacher (TeacherNameSurname,TeacherLesson,TeacherPhone,TeacherAdress) values (@p1,@p2,@p3,@p4)", connection);
                    connection.Open();
                    command.Parameters.AddWithValue("@p1", TxtTeacherName.Text);
                    command.Parameters.AddWithValue("@p2", CmbTeacherLesson.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@p3", maskedTextBox1.Text);
                    command.Parameters.AddWithValue("@p4", RchTeacherAdress.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Öğretmen Başarılı Şekilde Kayıt Edildi");
                    Teacherlist();
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bilgileri Eksiksiz Doldurunuz");
            }

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TxtTeacherName.Text.Trim() != "" && CmbTeacherLesson.SelectedValue.ToString().Trim() != "0" && maskedTextBox1.Text.Trim() != "(   )    -" && RchTeacherAdress.Text.Trim() != ""&& lblid.Text.Trim() != "0")
            {
                connection.Open();
                SqlCommand command1 = new SqlCommand("update TblTeacher set TeacherNameSurname=@p1,TeacherLesson=@p2,TeacherPhone=@p3,TeacherAdress=@p4 where TeacherID=@p5", connection);
                command1.Parameters.AddWithValue("@p1", TxtTeacherName.Text);
                command1.Parameters.AddWithValue("@p2", CmbTeacherLesson.SelectedValue.ToString());
                command1.Parameters.AddWithValue("@p3", maskedTextBox1.Text);
                command1.Parameters.AddWithValue("@p4", RchTeacherAdress.Text);
                command1.Parameters.AddWithValue("@p5", lblid.Text);
                command1.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Güncelleme Başarılı Şekilde Yapıldı");
                Teacherlist();
            }
            else
            {
                MessageBox.Show("Lütfen Güncelleme Yapılacak Öğretmeni Seçiniz ve Bilgileri Eksiksiz Doldurunuz");

            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (lblid.Text.Trim() != "0")
            {
                connection.Open();
                SqlCommand command2 = new SqlCommand("Delete from TblTeacher where TeacherID=@p1", connection);
                command2.Parameters.AddWithValue("@p1", lblid.Text);
                command2.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Öğretmen Silindi");
                Teacherlist();

            }
            else
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Öğretmeni Seçiniz");
            }
        }
    }
}
