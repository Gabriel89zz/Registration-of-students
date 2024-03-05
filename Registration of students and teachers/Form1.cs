using Registration_of_students;

namespace Registration_of_students_and_teachers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Students student1 = new Students();
            student1.FullName=txtName.Text;
            student1.Age = txtAge.Text;
            student1.Number=txtNumber.Text;
            student1.Id=txtId.Text;
            student1.GetInfo();
        }
    }
}
