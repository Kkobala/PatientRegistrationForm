using PatientRegistration.Db.Entities;
using PatientRegistration.Repositories;
using System.Net;

namespace PatientRegistration
{
    public partial class EditPatientForm : Form
    {
        private readonly PatientRepository _repository;
        private readonly int _patientId;

        public EditPatientForm(PatientRepository repository, int patientId)
        {
            InitializeComponent();
            _repository = repository;
            _patientId = patientId;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var patient = new PatientEntity
            {
                Name = textBoxName.Text,
                LastName = textBoxLastName.Text,
                BirthDate = textBoxBirthDate.Text,
                Gender = comboBoxGender.Text,
                PhoneNumber = textBoxPhoneNumber.Text,
                Address = textBoxAddress.Text,
                PersonalNumber = textBoxPersonalNumber.Text,
                EMail = textBoxEmail.Text
            };

            patient.ID = _patientId;

            bool updateSuccessful = _repository.EditPatient(patient);

            if (updateSuccessful)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update patient information.");
            }
        }

        private void EditPatientForm_Load(object sender, EventArgs e)
        {
            if (_patientId != 0)
            {
                var patient = _repository.GetPatientById(_patientId);

                textBoxName.Text = patient.Name;
                textBoxLastName.Text = patient.LastName;
                textBoxBirthDate.Text = patient.BirthDate;
                comboBoxGender.Text = patient.Gender;
                textBoxPhoneNumber.Text = patient.PhoneNumber;
                textBoxAddress.Text = patient.Address;
                textBoxPersonalNumber.Text = patient.PersonalNumber;
                textBoxEmail.Text = patient.EMail;
            }
        }
    }
}

