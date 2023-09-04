namespace PatientRegistration
{
    partial class EditPatientForm
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
            lblName = new Label();
            labelLastName = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxBirthDate = new TextBox();
            textBoxPhoneNumber = new TextBox();
            comboBoxGender = new ComboBox();
            label1 = new Label();
            textBoxAddress = new TextBox();
            btnEdit = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label2 = new Label();
            label6 = new Label();
            textBoxEmail = new TextBox();
            textBoxPersonalNumber = new TextBox();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(19, 12);
            lblName.Name = "lblName";
            lblName.Size = new Size(53, 15);
            lblName.TabIndex = 0;
            lblName.Text = "სახელი";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(19, 55);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(42, 15);
            labelLastName.TabIndex = 1;
            labelLastName.Text = "გვარი";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 104);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 2;
            label3.Text = "დაბ თარიღი";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 138);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 3;
            label4.Text = "სქესი";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 181);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 4;
            label5.Text = "მობ ნომერი";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(140, 12);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(121, 23);
            textBoxName.TabIndex = 5;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(140, 55);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(121, 23);
            textBoxLastName.TabIndex = 6;
            // 
            // textBoxBirthDate
            // 
            textBoxBirthDate.Location = new Point(140, 101);
            textBoxBirthDate.Name = "textBoxBirthDate";
            textBoxBirthDate.Size = new Size(121, 23);
            textBoxBirthDate.TabIndex = 7;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(140, 173);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(121, 23);
            textBoxPhoneNumber.TabIndex = 8;
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "მამრობითი", "მდედრობით" });
            comboBoxGender.Location = new Point(140, 135);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(121, 23);
            comboBoxGender.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 215);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 10;
            label1.Text = "მისამართი";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(140, 210);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(121, 23);
            textBoxAddress.TabIndex = 11;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(609, 360);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(104, 23);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "რედაქტირება";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 255);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 13;
            label2.Text = "პირადი ნომერი";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 288);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 14;
            label6.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(140, 285);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(121, 23);
            textBoxEmail.TabIndex = 15;
            // 
            // textBoxPersonalNumber
            // 
            textBoxPersonalNumber.Location = new Point(140, 247);
            textBoxPersonalNumber.Name = "textBoxPersonalNumber";
            textBoxPersonalNumber.Size = new Size(121, 23);
            textBoxPersonalNumber.TabIndex = 16;
            // 
            // EditPatientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxPersonalNumber);
            Controls.Add(textBoxEmail);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(btnEdit);
            Controls.Add(textBoxAddress);
            Controls.Add(label1);
            Controls.Add(comboBoxGender);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxBirthDate);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(labelLastName);
            Controls.Add(lblName);
            Name = "EditPatientForm";
            Text = "EditPatientForm";
            Load += EditPatientForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label labelLastName;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxName;
        private TextBox textBoxLastName;
        private TextBox textBoxBirthDate;
        private TextBox textBoxPhoneNumber;
        private ComboBox comboBoxGender;
        private Label label1;
        private TextBox textBoxAddress;
        private Button btnEdit;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label2;
        private Label label6;
        private TextBox textBoxEmail;
        private TextBox textBoxPersonalNumber;
    }
}