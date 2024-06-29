namespace Ödev_20240505
{
    partial class Form2
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
            lblStudentName = new Label();
            txtStudentLastName = new TextBox();
            label2 = new Label();
            txtStudentTCNO = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnKaydet = new Button();
            btnGeri = new Button();
            dtpBirthDate = new DateTimePicker();
            cbxGender = new ComboBox();
            label1 = new Label();
            txtPhoneNumber = new TextBox();
            txtStudentFirstName = new TextBox();
            txtMail = new TextBox();
            label7 = new Label();
            cbxDepartman = new ComboBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Location = new Point(34, 64);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(138, 20);
            lblStudentName.TabIndex = 1;
            lblStudentName.Text = "Student FirstName :";
            // 
            // txtStudentLastName
            // 
            txtStudentLastName.Location = new Point(196, 110);
            txtStudentLastName.Name = "txtStudentLastName";
            txtStudentLastName.Size = new Size(216, 27);
            txtStudentLastName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 117);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 1;
            label2.Text = "Student LastName :";
            // 
            // txtStudentTCNO
            // 
            txtStudentTCNO.Location = new Point(196, 174);
            txtStudentTCNO.Name = "txtStudentTCNO";
            txtStudentTCNO.Size = new Size(216, 27);
            txtStudentTCNO.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 181);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 1;
            label3.Text = "TCKNO :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 249);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 1;
            label4.Text = "BirthDate :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 448);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 1;
            label5.Text = "Gender :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 518);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 1;
            label6.Text = "Departman :";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(34, 568);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(269, 72);
            btnKaydet.TabIndex = 9;
            btnKaydet.Text = "SAVE";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(343, 568);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(97, 72);
            btnGeri.TabIndex = 10;
            btnGeri.Text = "BACK";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(196, 244);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(244, 27);
            dtpBirthDate.TabIndex = 4;
            // 
            // cbxGender
            // 
            cbxGender.FormattingEnabled = true;
            cbxGender.Location = new Point(192, 445);
            cbxGender.MaxDropDownItems = 7;
            cbxGender.Name = "cbxGender";
            cbxGender.Size = new Size(220, 28);
            cbxGender.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 386);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 7;
            label1.Text = "Phone Number :";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(197, 379);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(216, 27);
            txtPhoneNumber.TabIndex = 6;
            // 
            // txtStudentFirstName
            // 
            txtStudentFirstName.Location = new Point(197, 61);
            txtStudentFirstName.Name = "txtStudentFirstName";
            txtStudentFirstName.Size = new Size(216, 27);
            txtStudentFirstName.TabIndex = 1;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(197, 310);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(216, 27);
            txtMail.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 317);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 1;
            label7.Text = "E-Mail :";
            // 
            // cbxDepartman
            // 
            cbxDepartman.FormattingEnabled = true;
            cbxDepartman.Location = new Point(192, 512);
            cbxDepartman.Name = "cbxDepartman";
            cbxDepartman.Size = new Size(220, 28);
            cbxDepartman.TabIndex = 9;
            // 
            // label9
            // 
            label9.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(24, 9);
            label9.Name = "label9";
            label9.Size = new Size(416, 39);
            label9.TabIndex = 12;
            label9.Text = "STUDENT ADDITION TABLE";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 679);
            Controls.Add(label9);
            Controls.Add(cbxDepartman);
            Controls.Add(txtStudentFirstName);
            Controls.Add(label1);
            Controls.Add(txtPhoneNumber);
            Controls.Add(cbxGender);
            Controls.Add(dtpBirthDate);
            Controls.Add(btnGeri);
            Controls.Add(btnKaydet);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblStudentName);
            Controls.Add(txtMail);
            Controls.Add(txtStudentTCNO);
            Controls.Add(txtStudentLastName);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblStudentName;
        private TextBox txtStudentLastName;
        private Label label2;
        private TextBox txtStudentTCNO;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnKaydet;
        private Button btnGeri;
        private ComboBox cbxGender;
        private Label label1;
        private TextBox txtPhoneNumber;
        private TextBox txtStudentFirstName;
        private TextBox txtMail;
        private Label label7;
        private ComboBox cbxDepartman;
        public DateTimePicker dtpBirthDate;
        private Label label9;
    }
}