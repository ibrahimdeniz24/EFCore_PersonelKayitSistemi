using Microsoft.Data.SqlClient;
using Ödev_20240505.Context;
using Ödev_20240505.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ödev_20240505
{
    public partial class Form4 : Form
    {
        public Form4()
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
                bagla.Open();

                int id = Convert.ToInt32(txtStudentID.Text);
                OgrenciGuncelle(id);

                bagla.Close();
                MessageBox.Show($"StudentID'si :{id} olan öğrenci Güncellenmiştir");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        private void OgrenciGuncelle(int id)
        {
            using (var context = new AppDBContext())
            {

                Student st = context.Students.Find(id);

                st.FirstName = txtStudentFirstName.Text;
                st.LastName = txtStudentLastName.Text;
                st.Mail = txtMail.Text;
                st.BirthDate = dtpBirthDate.Value;
                st.PhoneNumber = txtPhoneNumber.Text;
                st.TCKNO = txtStudentTCNO.Text;
                st.DepartmentID = cbxDepartman.SelectedIndex;
                st.GenderID = cbxGender.SelectedIndex;


                context.Students.Update(st);
                context.SaveChanges();

            }

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.DepartmanGetir(cbxDepartman);
            form2.GendersGetir(cbxGender);
        }
    }
}

