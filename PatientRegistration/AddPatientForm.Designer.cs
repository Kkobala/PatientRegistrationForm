namespace PatientRegistration
{
    partial class AddPatientForm
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
            textBoxName = new TextBox();
            txtName = new Label();
            txtLastName = new Label();
            textBoxLastName = new TextBox();
            txtBirthDate = new Label();
            textBoxBirthDate = new TextBox();
            txtGender = new Label();
            txtPhoneNumber = new Label();
            textBoxPhoneNumber = new TextBox();
            txtAddres = new Label();
            textBoxAddress = new TextBox();
            btnAdd = new Button();
            comboBoxGender = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            textBoxPersonalNumber = new TextBox();
            textBoxEmail = new TextBox();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(194, 28);
            textBoxName.Margin = new Padding(4, 5, 4, 5);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(170, 31);
            textBoxName.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Location = new Point(20, 33);
            txtName.Margin = new Padding(4, 0, 4, 0);
            txtName.Name = "txtName";
            txtName.Size = new Size(82, 25);
            txtName.TabIndex = 1;
            txtName.Text = "სახელი";
            // 
            // txtLastName
            // 
            txtLastName.AutoSize = true;
            txtLastName.Location = new Point(20, 85);
            txtLastName.Margin = new Padding(4, 0, 4, 0);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(67, 25);
            txtLastName.TabIndex = 2;
            txtLastName.Text = "გვარი";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(194, 80);
            textBoxLastName.Margin = new Padding(4, 5, 4, 5);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(170, 31);
            textBoxLastName.TabIndex = 3;
            // 
            // txtBirthDate
            // 
            txtBirthDate.AutoSize = true;
            txtBirthDate.Location = new Point(17, 142);
            txtBirthDate.Margin = new Padding(4, 0, 4, 0);
            txtBirthDate.Name = "txtBirthDate";
            txtBirthDate.Size = new Size(128, 25);
            txtBirthDate.TabIndex = 4;
            txtBirthDate.Text = "დაბ თარიღი";
            // 
            // textBoxBirthDate
            // 
            textBoxBirthDate.Location = new Point(194, 137);
            textBoxBirthDate.Margin = new Padding(4, 5, 4, 5);
            textBoxBirthDate.Name = "textBoxBirthDate";
            textBoxBirthDate.Size = new Size(170, 31);
            textBoxBirthDate.TabIndex = 5;
            // 
            // txtGender
            // 
            txtGender.AutoSize = true;
            txtGender.Location = new Point(23, 202);
            txtGender.Margin = new Padding(4, 0, 4, 0);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(63, 25);
            txtGender.TabIndex = 6;
            txtGender.Text = "სქესი";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.AutoSize = true;
            txtPhoneNumber.Location = new Point(17, 270);
            txtPhoneNumber.Margin = new Padding(4, 0, 4, 0);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(121, 25);
            txtPhoneNumber.TabIndex = 8;
            txtPhoneNumber.Text = "მობ ნომერი";
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(193, 257);
            textBoxPhoneNumber.Margin = new Padding(4, 5, 4, 5);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(171, 31);
            textBoxPhoneNumber.TabIndex = 9;
            // 
            // txtAddres
            // 
            txtAddres.AutoSize = true;
            txtAddres.Location = new Point(20, 322);
            txtAddres.Margin = new Padding(4, 0, 4, 0);
            txtAddres.Name = "txtAddres";
            txtAddres.Size = new Size(112, 25);
            txtAddres.TabIndex = 10;
            txtAddres.Text = "მისამართი";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(193, 318);
            textBoxAddress.Margin = new Padding(4, 5, 4, 5);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(171, 31);
            textBoxAddress.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(964, 635);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 38);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "დამატება";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // comboBoxGender
            // 
            comboBoxGender.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "მამრობითი", "მდედრობითი" });
            comboBoxGender.Location = new Point(193, 197);
            comboBoxGender.Margin = new Padding(4, 5, 4, 5);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(171, 33);
            comboBoxGender.TabIndex = 13;
            comboBoxGender.Text = "-აირჩიეთ-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 380);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(157, 25);
            label1.TabIndex = 14;
            label1.Text = "პირადი ნომერი";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 440);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 15;
            label2.Text = "Email";
            // 
            // textBoxPersonalNumber
            // 
            textBoxPersonalNumber.Location = new Point(194, 375);
            textBoxPersonalNumber.Margin = new Padding(4, 5, 4, 5);
            textBoxPersonalNumber.Name = "textBoxPersonalNumber";
            textBoxPersonalNumber.Size = new Size(170, 31);
            textBoxPersonalNumber.TabIndex = 16;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(194, 427);
            textBoxEmail.Margin = new Padding(4, 5, 4, 5);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(170, 31);
            textBoxEmail.TabIndex = 17;
            // 
            // AddPatientForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPersonalNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxGender);
            Controls.Add(btnAdd);
            Controls.Add(textBoxAddress);
            Controls.Add(txtAddres);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtGender);
            Controls.Add(textBoxBirthDate);
            Controls.Add(txtBirthDate);
            Controls.Add(textBoxLastName);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(textBoxName);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AddPatientForm";
            Text = "AddPatientForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private Label txtName;
        private Label txtLastName;
        private TextBox textBoxLastName;
        private Label txtBirthDate;
        private TextBox textBoxBirthDate;
        private Label txtGender;
        private Label txtPhoneNumber;
        private TextBox textBoxPhoneNumber;
        private Label txtAddres;
        private TextBox textBoxAddress;
        private Button btnAdd;
        private ComboBox comboBoxGender;
        private Label label1;
        private Label label2;
        private TextBox textBoxPersonalNumber;
        private TextBox textBoxEmail;
    }
}