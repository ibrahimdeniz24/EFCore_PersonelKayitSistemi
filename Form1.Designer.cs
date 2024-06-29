namespace Ödev_20240505
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            StudentID = new ColumnHeader();
            FirstName = new ColumnHeader();
            LastName = new ColumnHeader();
            EMail = new ColumnHeader();
            BirthDate = new ColumnHeader();
            PhoneNumber = new ColumnHeader();
            TCKNO = new ColumnHeader();
            DepartmanID = new ColumnHeader();
            GenderID = new ColumnHeader();
            btnVerileriGetir = new Button();
            btnOgrenciKaydet = new Button();
            btnSil = new Button();
            btnGüncelle = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { StudentID, FirstName, LastName, EMail, BirthDate, PhoneNumber, TCKNO, DepartmanID, GenderID });
            listView1.Location = new Point(22, 85);
            listView1.Name = "listView1";
            listView1.Size = new Size(1024, 286);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // StudentID
            // 
            StudentID.Text = "StudentID";
            StudentID.Width = 90;
            // 
            // FirstName
            // 
            FirstName.Text = "FirstName";
            FirstName.Width = 100;
            // 
            // LastName
            // 
            LastName.Text = "LastName";
            LastName.Width = 100;
            // 
            // EMail
            // 
            EMail.Text = "E-Mail";
            EMail.Width = 150;
            // 
            // BirthDate
            // 
            BirthDate.Text = "BirthDate";
            BirthDate.Width = 120;
            // 
            // PhoneNumber
            // 
            PhoneNumber.Text = "PhoneNumber";
            PhoneNumber.Width = 130;
            // 
            // TCKNO
            // 
            TCKNO.Text = "TCKNO";
            TCKNO.Width = 110;
            // 
            // DepartmanID
            // 
            DepartmanID.Text = "DepartmanID";
            DepartmanID.Width = 120;
            // 
            // GenderID
            // 
            GenderID.Text = "GenderID";
            GenderID.Width = 100;
            // 
            // btnVerileriGetir
            // 
            btnVerileriGetir.Location = new Point(116, 405);
            btnVerileriGetir.Name = "btnVerileriGetir";
            btnVerileriGetir.Size = new Size(191, 73);
            btnVerileriGetir.TabIndex = 1;
            btnVerileriGetir.Text = "Verileri Getir";
            btnVerileriGetir.UseVisualStyleBackColor = true;
            btnVerileriGetir.Click += btnVerileriGetir_Click;
            // 
            // btnOgrenciKaydet
            // 
            btnOgrenciKaydet.Location = new Point(340, 405);
            btnOgrenciKaydet.Name = "btnOgrenciKaydet";
            btnOgrenciKaydet.Size = new Size(151, 73);
            btnOgrenciKaydet.TabIndex = 2;
            btnOgrenciKaydet.Text = "Ogrenci Kaydet";
            btnOgrenciKaydet.UseVisualStyleBackColor = true;
            btnOgrenciKaydet.Click += btnOgrenciKaydet_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(524, 405);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(163, 73);
            btnSil.TabIndex = 3;
            btnSil.Text = "Ogrenci Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(728, 405);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(164, 73);
            btnGüncelle.TabIndex = 4;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // label1
            // 
            label1.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(150, 18);
            label1.Name = "label1";
            label1.Size = new Size(726, 38);
            label1.TabIndex = 5;
            label1.Text = "ÖĞRENCİ LİSTESİ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 512);
            Controls.Add(label1);
            Controls.Add(btnGüncelle);
            Controls.Add(btnSil);
            Controls.Add(btnOgrenciKaydet);
            Controls.Add(btnVerileriGetir);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button btnVerileriGetir;
        private Button btnOgrenciKaydet;
        private Button btnSil;
        private Button btnGüncelle;
        private ColumnHeader StudentID;
        private ColumnHeader FirstName;
        private ColumnHeader LastName;
        private ColumnHeader EMail;
        private ColumnHeader BirthDate;
        private ColumnHeader PhoneNumber;
        private ColumnHeader TCKNO;
        private ColumnHeader DepartmanID;
        private ColumnHeader GenderID;
        private Label label1;
    }
}
