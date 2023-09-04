using PatientRegistration.Db;
using PatientRegistration.Db.Entities;
using PatientRegistration.Repositories;
using System.ComponentModel;

namespace PatientRegistration
{
    public partial class PatientForm : Form
    {
        private readonly AppDbContext _context;
        private readonly PatientRepository _repository;

        public PatientForm(
            AppDbContext dbContext,
            PatientRepository repository)
        {
            InitializeComponent();
            _repository = repository;
            _context = dbContext;

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "მონიშნეთ პაციენტი";
            checkBoxColumn.Name = "MarkPatient";
            dataGridView1.Columns.Add(checkBoxColumn);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPatientForm addPatientForm = new AddPatientForm(_repository!);
            DialogResult result = addPatientForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                dataGridView1.DataSource = _repository.GetAllPatients();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isChecked = Convert.ToBoolean(row.Cells["MarkPatient"].Value);

                if (isChecked)
                {
                    id = Convert.ToInt32(row.Cells[0].Value);

                    EditPatientForm editPatient = new EditPatientForm(_repository!, id);
                    DialogResult result = editPatient.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        dataGridView1.DataSource = _repository.GetAllPatients();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isChecked = Convert.ToBoolean(row.Cells["MarkPatient"].Value);

                if (isChecked)
                {
                    int patientId = Convert.ToInt32(row.Cells[0].Value);

                    bool removedSuccessfully = _repository.RemovePatient(patientId);

                    if (removedSuccessfully)
                    {
                        dataGridView1.Rows.RemoveAt(row.Index);
                    }
                }
            }
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            BindingList<PatientEntity> patientBindingList = new BindingList<PatientEntity>(_repository.GetAllPatients());

            dataGridView1.DataSource = patientBindingList;
        }
    }
}