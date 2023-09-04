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
            textBoxName.Location = new Point(136, 17);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(120, 23);
            textBoxName.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Location = new Point(14, 20);
            txtName.Name = "txtName";
            txtName.Size = new Size(53, 15);
            txtName.TabIndex = 1;
            txtName.Text = "სახელი";
            // 
            // txtLastName
            // 
            txtLastName.AutoSize = true;
            txtLastName.Location = new Point(14, 51);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(42, 15);
            txtLastName.TabIndex = 2;
            txtLastName.Text = "გვარი";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(136, 48);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(120, 23);
            textBoxLastName.TabIndex = 3;
            // 
            // txtBirthDate
            // 
            txtBirthDate.AutoSize = true;
            txtBirthDate.Location = new Point(12, 85);
            txtBirthDate.Name = "txtBirthDate";
            txtBirthDate.Size = new Size(83, 15);
            txtBirthDate.TabIndex = 4;
            txtBirthDate.Text = "დაბ თარიღი";
            // 
            // textBoxBirthDate
            // 
            textBoxBirthDate.Location = new Point(136, 82);
            textBoxBirthDate.Name = "textBoxBirthDate";
            textBoxBirthDate.Size = new Size(120, 23);
            textBoxBirthDate.TabIndex = 5;
            // 
            // txtGender
            // 
            txtGender.AutoSize = true;
            txtGender.Location = new Point(16, 121);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(40, 15);
            txtGender.TabIndex = 6;
            txtGender.Text = "სქესი";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.AutoSize = true;
            txtPhoneNumber.Location = new Point(12, 162);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(78, 15);
            txtPhoneNumber.TabIndex = 8;
            txtPhoneNumber.Text = "მობ ნომერი";
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(135, 154);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(121, 23);
            textBoxPhoneNumber.TabIndex = 9;
            // 
            // txtAddres
            // 
            txtAddres.AutoSize = true;
            txtAddres.Location = new Point(14, 193);
            txtAddres.Name = "txtAddres";
            txtAddres.Size = new Size(74, 15);
            txtAddres.TabIndex = 10;
            txtAddres.Text = "მისამართი";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(135, 191);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(121, 23);
            textBoxAddress.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(675, 381);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
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
            comboBoxGender.Location = new Point(135, 118);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(121, 23);
            comboBoxGender.TabIndex = 13;
            comboBoxGender.Text = "-აირჩიეთ-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 228);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 14;
            label1.Text = "პირადი ნომერი";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 264);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 15;
            label2.Text = "Email";
            // 
            // textBoxPersonalNumber
            // 
            textBoxPersonalNumber.Location = new Point(136, 225);
            textBoxPersonalNumber.Name = "textBoxPersonalNumber";
            textBoxPersonalNumber.Size = new Size(120, 23);
            textBoxPersonalNumber.TabIndex = 16;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(136, 256);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(120, 23);
            textBoxEmail.TabIndex = 17;
            // 
            // AddPatientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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