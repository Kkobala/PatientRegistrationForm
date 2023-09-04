namespace PatientRegistration.Db.Entities
{
    public class PatientEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string PersonalNumber { get; set; }
        public string EMail { get; set; }
    }
}
