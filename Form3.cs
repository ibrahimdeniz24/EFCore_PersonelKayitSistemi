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

namespace Ödev_20240505
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection bagla = new SqlConnection(@"Data Source = DENIZ\SQL; Initial Catalog = HS-15StudyStudents; Integrated Security = True; TrustServerCertificate = True");

        SqlCommand komut = new SqlCommand();
        SqlDataReader Reader;

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                bagla.Open();
                string sorgu = ("select * from Students");

                SqlCommand komut = new SqlCommand();
                komut.CommandText = sorgu;
                komut.Connection = bagla;
                Reader = komut.ExecuteReader();

                int ıd = Convert.ToInt32(textBox1.Text);

                OgrenciSil(ıd);

                bagla.Close();

                MessageBox.Show("Öğrenci Silinmiştir.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           


        }


        private void OgrenciSil(int ıd)
        {
            using (var context = new AppDBContext())
            {

                Student st = context.Students.Find(ıd);

                context.Students.Remove(st);
                context.SaveChanges();

            }

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
