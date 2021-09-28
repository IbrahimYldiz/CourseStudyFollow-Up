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
    public partial class FrmLessonProcedures : Form
    {
        public FrmLessonProcedures()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-OC5036T\MSSQLSERVER1;Initial Catalog=DBCourseStudyFollow-Up;Integrated Security=True");
        void lessonlist()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TblLesson",connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void FrmLessonProcedures_Load(object sender, EventArgs e)
        {
            lessonlist();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command4 = new SqlCommand("Select * from TblLesson where LessonName=@p1", connection);
            command4.Parameters.AddWithValue("@p1", TxtLesson.Text);
            SqlDataReader dr = command4.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Bu Ders Daha Önce Kayıt Edilmiş");
                dr.Close();
            }


            else
            {
                dr.Close();
                if (TxtLesson.Text.Trim() != "")
                {
                    
                    SqlCommand command = new SqlCommand("insert into TblLesson (LessonName) values (@p1)", connection);
                    command.Parameters.AddWithValue("@p1", TxtLesson.Text);
                    command.ExecuteNonQuery();
                    
                    MessageBox.Show("Ders Kaydı Yapıldı");
                    lessonlist();

                }
                else
                {
                    MessageBox.Show("Lütfen Eklemek İstediğiniz Dersin Adını Giriniz");
                }

            }
            connection.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command5 = new SqlCommand("Select * from TblLesson where LessonID=@p1", connection);
            command5.Parameters.AddWithValue("@p1", LblLessonID.Text);
            SqlDataReader dr = command5.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                if (LblLessonID.Text.Trim() != "0")
                {
                    
                    SqlCommand command1 = new SqlCommand("delete from TblLesson where LessonID=@p1", connection);
                    command1.Parameters.AddWithValue("@p1", LblLessonID.Text);
                    command1.ExecuteNonQuery();
                    
                    MessageBox.Show("Ders Silindi");
                    lessonlist();
                }
                else
                {
                    MessageBox.Show("Lütfen Silmek İstediğiniz Dersi Seçiniz");
                    
                }
                
            }
            else
            {
                MessageBox.Show("Bu Ders Daha Önce Silinmiş");
                dr.Close();
            }
            connection.Close();


            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LblLessonID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtLesson.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            connection.Open();
            SqlCommand command5 = new SqlCommand("Select * from TblLesson where LessonName=@p1", connection);
            command5.Parameters.AddWithValue("@p1", TxtLesson.Text);
            SqlDataReader dr = command5.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Bu Ders Daha Önce Kayıt Edilmiş");
                dr.Close();
            }
            else
            {
                dr.Close();
                if (LblLessonID.Text.Trim() != "")
                {

                    SqlCommand command2 = new SqlCommand("update TblLesson set LessonName=@p1 where LessonID=@p2", connection);
                    command2.Parameters.AddWithValue("@p2", LblLessonID.Text);
                    command2.Parameters.AddWithValue("@p1", TxtLesson.Text);
                    command2.ExecuteNonQuery();
                    
                    MessageBox.Show("Ders Güncellendi");
                    lessonlist();

                }
                else
                {
                    MessageBox.Show("Lütfen Güncellemek İstediğiniz Ders Seçiniz");
                }
            }
            connection.Close();
        }
    }
}
