using Ödev_20240505.Context;
using Ödev_20240505.Entities;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Data.SqlClient;

namespace Ödev_20240505
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection bagla = new SqlConnection(@"Data Source = DENIZ\SQL; Initial Catalog = HS-15StudyStudents; Integrated Security = True; TrustServerCertificate = True");

        SqlCommand komut = new SqlCommand();
        SqlDataReader oku;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu = ("insert into Students (FirstName,LastName,Mail,BirthDate,PhoneNumber,TCKNO,DepartmentID,GenderID) values (@FirstName,@LastName,@Mail,@BirthDate,@PhoneNumber,@TCKNO,@DepartmentID,@GenderID)");

                komut = new SqlCommand(sorgu, bagla);

                komut.Parameters.AddWithValue("@FirstName", txtStudentFirstName.Text);
                komut.Parameters.AddWithValue("@LastName", txtStudentLastName.Text);
                komut.Parameters.AddWithValue("@Mail", txtMail.Text);
                komut.Parameters.AddWithValue("@BirthDate", dtpBirthDate.Value.ToString());
                komut.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                komut.Parameters.AddWithValue("@TCKNO", txtStudentTCNO.Text);
                komut.Parameters.AddWithValue("@DepartmentID", cbxDepartman.SelectedIndex);
                komut.Parameters.AddWithValue("@GenderID", cbxGender.SelectedIndex);
                bagla.Open();
                komut.ExecuteNonQuery();
                MessageBox.Show("Kaydedildi");

               

                MessageBox.Show("Öğrenci Eklenmiştir.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                bagla.Close();
            }

            
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GendersGetir(cbxGender);

            DepartmanGetir(cbxDepartman);


        }

        public void GendersGetir(ComboBox cbxgender)
        {
            cbxGender.Items.Clear();


            bagla.Open();

            komut.Connection = bagla;
            komut.CommandText = "select *From Genders";
            oku = komut.ExecuteReader();

            while (oku.Read())
            {
                cbxgender.Items.Add(oku[1].ToString());
            }

            bagla.Close();
        }

        public void DepartmanGetir(ComboBox cbxdepartman)
        {
            cbxDepartman.Items.Clear();


            bagla.Open();

            komut.Connection = bagla;
            komut.CommandText = "select *From Departments";
            oku = komut.ExecuteReader();

            while (oku.Read())
            {
                cbxdepartman.Items.Add(oku[1].ToString());
            }

            bagla.Close();
        }
    }
}
