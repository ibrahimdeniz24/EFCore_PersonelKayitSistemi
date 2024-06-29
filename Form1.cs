using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client.NativeInterop;
using Ödev_20240505.Context;
using Ödev_20240505.Entities;
using System.Data;

namespace Ödev_20240505
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection Connect;
        SqlCommand Command = new SqlCommand();
        SqlDataReader Reader;



        private void btnVerileriGetir_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            #region Adonet
            try
            {
                Connect = new SqlConnection(@"Data Source = DENIZ\SQL; Initial Catalog = HS-15StudyStudents; Integrated Security = True; TrustServerCertificate = True");
                Connect.Open();

                string sql = ("Select *from Students");

                Command.CommandText = sql;
                Command.Connection = Connect;
                Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    ListViewItem lstView = new ListViewItem(Reader["StudentID"].ToString());
                    lstView.SubItems.Add(Reader["FirstName"].ToString());
                    lstView.SubItems.Add(Reader["LastName"].ToString());
                    lstView.SubItems.Add(Reader["Mail"].ToString());
                    lstView.SubItems.Add(Reader["BirthDate"].ToString());
                    lstView.SubItems.Add(Reader["PhoneNumber"].ToString());
                    lstView.SubItems.Add(Reader["TCKNO"].ToString());
                    lstView.SubItems.Add(Reader["DepartmentID"].ToString());
                    lstView.SubItems.Add(Reader["GenderID"].ToString());

                    listView1.Items.Add(lstView);
                }
                Connect.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            #endregion

           

        }

        private void btnOgrenciKaydet_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.GridLines = true;
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }
    }
}

