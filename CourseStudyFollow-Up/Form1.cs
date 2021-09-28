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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-OC5036T\MSSQLSERVER1;Initial Catalog=DBCourseStudyFollow-Up;Integrated Security=True");
        void TblPrivateLesson()
        {
            SqlDataAdapter da = new SqlDataAdapter("execute PrivateLesson", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        void study()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("Select StudyID, StudyName+' '+StudySurname as StudyName from TblStudy", connection);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            CmbStudy.DisplayMember = "StudyName";
            CmbStudy.ValueMember = "StudyID";
            CmbStudy.DataSource = dt3;
        }
        void Lesson()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("select * from TblLesson", connection);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            CmbLesson.ValueMember = "LessonID";
            CmbLesson.DisplayMember = "LessonName";
            CmbLesson.DataSource = dt1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Lesson();
            TblPrivateLesson();
            study();
        }
        //"select LessonName as 'Ders',TeacherNameSurname as 'Öğretmen', (StudyName+' '+StudySurname) as 'Öğrenci',Date as 'Tarih',Hour as 'Saat' From TblPrivateLesson INNER JOIN TblLesson on TblLesson.LessonID=TblPrivateLesson.Lesson INNER JOIN TblTeacher on TblTeacher.TeacherID=TblPrivateLesson.Teacher Inner Join TblStudy on TblStudy.StudyID=TblPrivateLesson.Study where Teacher="+CmbLesson.SelectedValue.ToString(), connection
        private void CmbLesson_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da2 = new SqlDataAdapter("select * from TblTeacher where TeacherLesson=" + CmbLesson.SelectedValue.ToString(), connection);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            CmbTeacher.ValueMember = "TeacherID";
            CmbTeacher.DisplayMember = "TeacherNameSurname";
            CmbTeacher.DataSource = dt2;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            //kontrol
            SqlCommand command1 = new SqlCommand("select * from TblPrivateLesson where Lesson=" + CmbLesson.SelectedValue.ToString() + " and Teacher=" + CmbTeacher.SelectedValue.ToString() + " and Date=@p1 and Hour=@p2", connection);
            command1.Parameters.AddWithValue("@p1", MskDate.Text);
            command1.Parameters.AddWithValue("@p2", MskHour.Text);
            SqlDataReader dr = command1.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Bu saat dolu");
                dr.Close();
            }
            else
            {
                dr.Close();
                SqlCommand command2 = new SqlCommand("select * from TblPrivateLesson where Study=" + CmbStudy.SelectedValue.ToString() + " and Date=@p1 and Hour=@p2", connection);
                command2.Parameters.AddWithValue("@p1", MskDate.Text);
                command2.Parameters.AddWithValue("@p2", MskHour.Text);
                SqlDataReader dr2 = command2.ExecuteReader();


                if (dr2.Read())
                {
                    MessageBox.Show("Öğrencinin seçilen saatte özel dersi var");
                    dr2.Close();
                }
                else
                {
                    dr2.Close();
                    SqlCommand command = new SqlCommand("insert into TblPrivateLesson (Lesson,Teacher,Study,Date,Hour) values (@p1,@p2,@p3,@p4,@p5)", connection);
                    command.Parameters.AddWithValue("@p1", CmbLesson.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@p2", CmbTeacher.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@p3", CmbStudy.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@p4", MskDate.Text);
                    command.Parameters.AddWithValue("@p5", MskHour.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Ütüt girişi başarılı şekilde tamamlandı");
                    TblPrivateLesson();
                }
            }
            connection.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
        string date;
        string hour;
        string teacher;
        private void MskDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

            date = MskDate.Text;

        }

        private void BtnControl_Click(object sender, EventArgs e)
        {
            
            SqlDataAdapter da6 = new SqlDataAdapter("select LessonName as 'Ders Adı',TeacherNameSurname as 'Öğretmen Adı Soyadı',(StudyName+' '+StudySurname) as 'Öğrenci Adı Soyadı',Date as 'Tarih',Hour as 'Saati' from TblPrivateLesson Inner JOIN TblLesson on TblLesson.LessonID=TblPrivateLesson.Lesson INNER JOIN TblTeacher on TblTeacher.TeacherID=TblPrivateLesson.Teacher INNER JOIN TblStudy on TblStudy.StudyID=TblPrivateLesson.Study where Lesson=" + CmbLesson.SelectedValue.ToString() + " and Teacher=" + CmbTeacher.SelectedValue.ToString() + "and Date=@p1 and Hour=@p2",connection);
            da6.SelectCommand.Parameters.AddWithValue("@p1", DateTime.Parse(MskDate.Text));
            da6.SelectCommand.Parameters.AddWithValue("@p2", MskHour.Text);
            DataTable dt6 = new DataTable();
            da6.Fill(dt6);

            dataGridView1.DataSource = dt6;
            
            
            //System.Data.SqlClient.SqlException: 'Incorrect syntax near the keyword 'and'.'

        }

        private void MskHour_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            hour = MskHour.Text;
        }

        private void CmbTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            teacher = CmbTeacher.SelectedValue.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            TblPrivateLesson();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmTeacherTransactions fr = new FrmTeacherTransactions();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmStudentTransactions fr = new FrmStudentTransactions();
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            FrmLessonProcedures fr = new FrmLessonProcedures();
            fr.Show();
        }
    }
}
