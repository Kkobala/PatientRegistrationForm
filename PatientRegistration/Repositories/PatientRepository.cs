using PatientRegistration.Db;
using PatientRegistration.Db.Entities;
using System.Xml.Linq;

namespace PatientRegistration.Repositories
{
    public class PatientRepository
    {
        private readonly AppDbContext _db;

        public PatientRepository(AppDbContext db)
        {
            _db = db;
        }

        public void AddPatient(PatientEntity patient)
        {
            _db.Patients.Add(patient);
            _db.SaveChanges();
        }

        public bool EditPatient(PatientEntity updatedPatient)
        {
            var existingPatient = _db.Patients.FirstOrDefault(p => p.ID == updatedPatient.ID);

            if (existingPatient == null)
            {
                return false;
            }

            existingPatient.Name = updatedPatient.Name;
            existingPatient.LastName = updatedPatient.LastName;
            existingPatient.BirthDate = updatedPatient.BirthDate;
            existingPatient.Gender = updatedPatient.Gender;
            existingPatient.PhoneNumber = updatedPatient.PhoneNumber;
            existingPatient.Address = updatedPatient.Address;
            existingPatient.EMail = updatedPatient.EMail;
            existingPatient.PersonalNumber = updatedPatient.PersonalNumber;

            _db.Patients.Update(existingPatient);
            _db.SaveChanges();

            return true;
        }

        public bool RemovePatient(int patientId)
        {
            var patient = _db.Patients.Find(patientId);

            if (patient != null)
            {
                _db.Patients.Remove(patient);
                _db.SaveChanges();
                return true;
            }

            return false;
        }

        public List<PatientEntity> GetAllPatients()
        {
            return _db.Patients.ToList();
        }

        public PatientEntity GetPatientById(int patientId)
        {
            var patient = _db.Patients.FirstOrDefault(a => a.ID == patientId);

            if (patient == null)
            {
                throw new ArgumentException("Patient not found");
            }

            return patient;
        }

        public void ValidatePhoneNumber(string phoneNumber)
        {
            if (!string.IsNullOrWhiteSpace(phoneNumber))
            {
                string phoneNum = phoneNumber.Trim();

                if (phoneNum.Length != 9 || !phoneNum.StartsWith("5") || !IsNumeric(phoneNum))
                {
                    MessageBox.Show("Phone number should be 9 digits long and start with '5'.");
                }
            }
        }

        public void ValidateMandatoryFields(string name, string lastName, string birthDate, string gender)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(lastName)
                || string.IsNullOrWhiteSpace(birthDate) || string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Please fill in all mandatory fields: Last Name, First Name, Date of Birth, and Gender.");
                return;
            }
        }

        public bool IsNumeric(string text)
        {
            return int.TryParse(text, out _);
        }
    }
}
