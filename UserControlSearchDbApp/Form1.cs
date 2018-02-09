using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;
using UserControlDbLib;


namespace UserControlSearchDbApp
{
    public partial class Form1 : Form
    {
        List<Student> m_students = new List<Student>();
        public Form1()
        {
            InitializeComponent();

            InitDb();

            AddStudents(m_students);
        }

        void InitDb()
        {

            Student n = new Student
            {
                firstName = "Eli",
                lastName = "Arad",
                age = 40,
                likeSports = true,
                male = true
            };
            m_students.Add(n);
             
            n = new Student
            {
                firstName = "Yo",
                lastName = "Bo",
                age = 30,
                likeSports = true,
                male = true
            };
            m_students.Add(n);


            n = new Student
            {
                firstName = "Ami",
                lastName = "Rabon",
                age = 30,
                likeSports = true,
                male = true
            };
            m_students.Add(n);


            n = new Student
            {
                firstName = "Joe",
                lastName = "Stample",
                age = 19,
                likeSports = true,
                male = true
            };
            m_students.Add(n);

            n = new Student
            {
                firstName = "David",
                lastName = "Tony",
                age = 52,
                likeSports = true,
                male = true
            };
            m_students.Add(n);
             
            n = new Student
            {
                firstName = "Yariv",
                lastName = "Logasi",
                age = 52,
                likeSports = true,
                male = true
            };
            m_students.Add(n);

        }

        void AddStudents(List<Student> list)
        {
            int y = 0;
            int i = 0;
            foreach (Student s in list)
            {

                UserControlDb u = new UserControlDb();
                u.BackColor = System.Drawing.Color.Khaki;
                u.Location = new System.Drawing.Point(1, -1 + y);
                u.Name = "userControlDb " + u;
                u.Size = new System.Drawing.Size(527, 55);
                u.TabIndex = i++;
                u.AddStudent(s);
                panel1.Controls.Add(u);
                y += u.Height;
            }
            panel1.Height = y;
            this.Height = y + 80;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int ageToSearch;
            bool b = int.TryParse(textBox1.Text, out ageToSearch);
            if (b)
            {
                var filteredOrders = (from s in m_students
                                      where s.age > ageToSearch
                                      select s).ToList();


                panel1.Controls.Clear();
                AddStudents(filteredOrders);
            } else
            {
                AddStudents(m_students);
            }
        }
    }
}
