using PatientRegistration.Db.Entities;
using PatientRegistration.Repositories;

namespace PatientRegistration
{
    public partial class AddPatientForm : Form
    {
        private readonly PatientRepository _repository;

        public AddPatientForm(PatientRepository repository)
        {
            InitializeComponent();
            _repository = repository;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _repository.ValidateMandatoryFields(txtName.Text, txtLastName.Text, txtBirthDate.Text, txtGender.Text);
            _repository.ValidatePhoneNumber(txtPhoneNumber.Text);

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

            _repository.AddPatient(patient);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
