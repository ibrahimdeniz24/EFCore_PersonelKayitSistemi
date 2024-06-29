namespace Ödev_20240505
{
    partial class Form4
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
            label9 = new Label();
            cbxDepartman = new ComboBox();
            txtStudentFirstName = new TextBox();
            label1 = new Label();
            txtPhoneNumber = new TextBox();
            cbxGender = new ComboBox();
            dtpBirthDate = new DateTimePicker();
            btnGeri = new Button();
            btnKaydet = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblStudentName = new Label();
            txtMail = new TextBox();
            txtStudentTCNO = new TextBox();
            txtStudentLastName = new TextBox();
            lblID = new Label();
            txtStudentID = new TextBox();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(32, 9);
            label9.Name = "label9";
            label9.Size = new Size(416, 39);
            label9.TabIndex = 31;
            label9.Text = "STUDENT UPDATE TABLE";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // cbxDepartman
            // 
            cbxDepartman.FormattingEnabled = true;
            cbxDepartman.Location = new Point(195, 553);
            cbxDepartman.Name = "cbxDepartman";
            cbxDepartman.Size = new Size(220, 28);
            cbxDepartman.TabIndex = 28;
            // 
            // txtStudentFirstName
            // 
            txtStudentFirstName.Location = new Point(200, 102);
            txtStudentFirstName.Name = "txtStudentFirstName";
            txtStudentFirstName.Size = new Size(216, 27);
            txtStudentFirstName.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 427);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 27;
            label1.Text = "Phone Number :";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(200, 420);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(216, 27);
            txtPhoneNumber.TabIndex = 26;
            // 
            // cbxGender
            // 
            cbxGender.FormattingEnabled = true;
            cbxGender.Location = new Point(195, 486);
            cbxGender.MaxDropDownItems = 7;
            cbxGender.Name = "cbxGender";
            cbxGender.Size = new Size(220, 28);
            cbxGender.TabIndex = 24;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(199, 285);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(244, 27);
            dtpBirthDate.TabIndex = 23;
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(346, 609);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(97, 72);
            btnGeri.TabIndex = 30;
            btnGeri.Text = "BACK";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(37, 609);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(269, 72);
            btnKaydet.TabIndex = 29;
            btnKaydet.Text = "SAVE";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 559);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 13;
            label6.Text = "Departman :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 489);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 20;
            label5.Text = "Gender :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 290);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 19;
            label4.Text = "BirthDate :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 358);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 18;
            label7.Text = "E-Mail :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 222);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 17;
            label3.Text = "TCKNO :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 158);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 16;
            label2.Text = "Student LastName :";
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Location = new Point(37, 105);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(138, 20);
            lblStudentName.TabIndex = 14;
            lblStudentName.Text = "Student FirstName :";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(200, 351);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(216, 27);
            txtMail.TabIndex = 25;
            // 
            // txtStudentTCNO
            // 
            txtStudentTCNO.Location = new Point(199, 215);
            txtStudentTCNO.Name = "txtStudentTCNO";
            txtStudentTCNO.Size = new Size(216, 27);
            txtStudentTCNO.TabIndex = 22;
            // 
            // txtStudentLastName
            // 
            txtStudentLastName.Location = new Point(199, 151);
            txtStudentLastName.Name = "txtStudentLastName";
            txtStudentLastName.Size = new Size(216, 27);
            txtStudentLastName.TabIndex = 21;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 162);
            lblID.Location = new Point(37, 58);
            lblID.Name = "lblID";
            lblID.Size = new Size(98, 23);
            lblID.TabIndex = 32;
            lblID.Text = "StudentID :";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(200, 57);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(216, 27);
            txtStudentID.TabIndex = 33;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 738);
            Controls.Add(txtStudentID);
            Controls.Add(lblID);
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
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private ComboBox cbxDepartman;
        private TextBox txtStudentFirstName;
        private Label label1;
        private TextBox txtPhoneNumber;
        private ComboBox cbxGender;
        public DateTimePicker dtpBirthDate;
        private Button btnGeri;
        private Button btnKaydet;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label3;
        private Label label2;
        private Label lblStudentName;
        private TextBox txtMail;
        private TextBox txtStudentTCNO;
        private TextBox txtStudentLastName;
        private Label lblID;
        private TextBox txtStudentID;
    }
}