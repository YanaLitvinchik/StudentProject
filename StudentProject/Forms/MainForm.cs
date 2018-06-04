using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentProject
{
    public partial class MainForm : Form
    {
        List<Student> student;
        List<Teacher> teacher;
        BindingSource bs = new BindingSource();
        public MainForm()
        {
            student = new List<Student>();
            teacher = new List<Teacher>();
            student.Add(new Student("Vladimir", "Dmitrievich", "Klepach"));
            student.Add(new Student("Yana", "Dmitrievich", "Klepach"));
            student.Add(new Student("Dima", "Dmitrievich", "Klepach"));
            teacher.Add(new Teacher("Li Y.V."));
            teacher.Add(new Teacher("Zulu B.E."));
            teacher.Add(new Teacher("Alpha D.T."));
            InitializeComponent();
            TeacherComboBox.Items.AddRange(teacher.ToArray());
            TeacherComboBox.DisplayMember = "TeachersName";
        }

        private void SMSbutton_Click(object sender, EventArgs e)
        {
            var wnd = new SendSMS();
            wnd.Show();            
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            student.Remove(StudentListBox.SelectedItem as Student);
            bs.ResetBindings(false);
        }

        private void TeacherComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentListBox.Items.Clear();
            foreach (var item in student)
            {
                StudentListBox.Items.Add(item);
            }
        }
    }
}
