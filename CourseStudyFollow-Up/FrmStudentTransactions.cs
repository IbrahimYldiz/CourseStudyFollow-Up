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
    public partial class FrmStudentTransactions : Form
    {
        public FrmStudentTransactions()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-OC5036T\MSSQLSERVER1;Initial Catalog=DBCourseStudyFollow-Up;Integrated Security=True");
        void list()
        {
            SqlDataAdapter da = new SqlDataAdapter("select StudyID as 'Öğrenci Numarası', StudyName as 'Adı',StudySurname as 'Soyadı', StuydPhoneNumber as 'Öğrenci Telefon Numarası', StudyAddress as 'Adres',StudyParentNameSurname as 'Veli Ad Soyad',StudyParentPhoneNumber as 'Veli Telefon Numarası',StudyClassroom as 'Sınıfı' from TblStudy", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmStudentTransactions_Load(object sender, EventArgs e)
        {
            list();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command5 = new SqlCommand("select * from where StudyName=@p1 and StudySurname=@p2 and StuydPhoneNumber=@p3", connection);
            command5.Parameters.AddWithValue("@p1", TxtStudyName.Text);
            command5.Parameters.AddWithValue("@p2", TxtStudySurName.Text);
            command5.Parameters.AddWithValue("@p3", MskStudyPhone.Text);
            SqlDataReader dr = command5.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Öğrenci Daha Önce Kayıt Edilmiş");
            }
            else
            {
                dr.Close();
                if (TxtStudyName.Text.Trim() != "" && TxtStudySurName.Text.Trim() != "" && MskStudyPhone.Text.Trim() != "(   )    -" && TxtStudyAdress.Text.Trim() != "" && TxtStudyParentNameSurname.Text.Trim() != "" && MskStudyParentPhone.Text.Trim() != "(   )    -")
                {

                    SqlCommand command = new SqlCommand("insert into TblStudy (StudyName,StudySurname,StuydPhoneNumber,StudyAddress,StudyParentNameSurname,StudyParentPhoneNumber,StudyClassroom) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", connection);
                    command.Parameters.AddWithValue("@p1", TxtStudyName.Text);
                    command.Parameters.AddWithValue("@p2", TxtStudySurName.Text);
                    command.Parameters.AddWithValue("@p3", MskStudyPhone.Text);
                    command.Parameters.AddWithValue("@p4", TxtStudyAdress.Text);
                    command.Parameters.AddWithValue("@p5", TxtStudyParentNameSurname.Text);
                    command.Parameters.AddWithValue("@p6", MskStudyParentPhone.Text);
                    command.Parameters.AddWithValue("@p7", MskStudyClass.Text);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Kayıt Yapıldı");
                    list();
                }
                else
                {
                    MessageBox.Show("Lütfen bilgileri eksiksiz doldurunuz");
                }
            }

            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            connection.Open();
            SqlCommand command6 = new SqlCommand("select * from where StudyName=@p1 and StudySurname=@p2 and StuydPhoneNumber=@p3 and StudyAddress=@p4,StudyParentNameSurname=@p5,StudyParentPhoneNumber=@p6,StudyClassroom=@p7", connection);
            command6.Parameters.AddWithValue("@p1", TxtStudyName.Text);
            command6.Parameters.AddWithValue("@p2", TxtStudySurName.Text);
            command6.Parameters.AddWithValue("@p3", MskStudyPhone.Text);
            command6.Parameters.AddWithValue("@p4", TxtStudyAdress.Text);
            command6.Parameters.AddWithValue("@p5", TxtStudyParentNameSurname.Text);
            command6.Parameters.AddWithValue("@p6", MskStudyParentPhone.Text);
            command6.Parameters.AddWithValue("@p7", MskStudyClass.Text);
            SqlDataReader dr = command6.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Öğrenci Daha Önce Kayıt Edilmiş");
                dr.Close();
            }

            else
            {
                dr.Close();
                if (TxtStudyName.Text.Trim() != "" && TxtStudySurName.Text.Trim() != "" && MskStudyPhone.Text.Trim() != "(   )    -" && TxtStudyAdress.Text.Trim() != "" && TxtStudyParentNameSurname.Text.Trim() != "" && MskStudyParentPhone.Text.Trim() != "(   )    -")
                {
                    if (label3.Text.Trim() != "0")
                    {

                        SqlCommand command = new SqlCommand("update TblStudy set StudyName=@p1,StudySurname=@p2,StuydPhoneNumber=@p3,StudyAddress=@p4,StudyParentNameSurname=@p5,StudyParentPhoneNumber=@p6,StudyClassroom=@p7 where StudyID=@p8", connection);
                        command.Parameters.AddWithValue("@p1", TxtStudyName.Text);
                        command.Parameters.AddWithValue("@p2", TxtStudySurName.Text);
                        command.Parameters.AddWithValue("@p3", MskStudyPhone.Text);
                        command.Parameters.AddWithValue("@p4", TxtStudyAdress.Text);
                        command.Parameters.AddWithValue("@p5", TxtStudyParentNameSurname.Text);
                        command.Parameters.AddWithValue("@p6", MskStudyParentPhone.Text);
                        command.Parameters.AddWithValue("@p7", MskStudyClass.Text);
                        command.Parameters.AddWithValue("@p8", label3.Text);
                        command.ExecuteNonQuery();


                        MessageBox.Show("Güncelleme Başarılı");
                        list();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Öğrenciyi Seçin");
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen bilgileri eksiksiz doldurunuz");
                }
            }
            connection.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label3.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtStudyName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtStudySurName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            MskStudyPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtStudyAdress.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            TxtStudyParentNameSurname.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            MskStudyParentPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            MskStudyClass.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            connection.Open();
            SqlCommand command6 = new SqlCommand("select * from where StudyID=@p1", connection);
            command6.Parameters.AddWithValue("@p1", label3.Text);

            SqlDataReader dr = command6.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                if (label3.Text.Trim() != "0")
                {
                    DialogResult result = MessageBox.Show("Öğrenciyi Silmek İstediğinize Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {

                        SqlCommand command = new SqlCommand("delete from TblStudy where StudyID=@p1 ", connection);
                        command.Parameters.AddWithValue("@p1", label3.Text);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Öğrenci Silindi");

                        list();
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen Silmek İstediğiniz Öğrenciyi Seçiniz");
                }



            }
            else
            {
                MessageBox.Show("Öğrenci Daha Önce Silinmiş");
            }


            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command6 = new SqlCommand("select * from where StudyID=@p1", connection);
            command6.Parameters.AddWithValue("@p1", TxtStudyName.Text);

            SqlDataReader dr = command6.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                if (TxtStudyName.Text.Trim() != "Silmek İstediğiniz Öğrenci Numarasını Buraya Yazınız")
                {
                    DialogResult result = MessageBox.Show("Öğrenciyi Silmek İstediğinize Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        
                        SqlCommand command = new SqlCommand("delete from TblStudy where StudyID=@p1 ", connection);
                        command.Parameters.AddWithValue("@p1", TxtStudyName.Text);
                        command.ExecuteNonQuery();
                        
                        MessageBox.Show("Öğrenci Silindi");
                        list();
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen Silmek İstediğiniz Öğrencinin Numarasını, Öğrencinin Adı Bölümüne Yazınız");
                }
            }
            else
            {
                MessageBox.Show("Öğrenci Daha Önce Silinmiş");
            }
            connection.Close();

        }
    }
}
