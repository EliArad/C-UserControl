using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;

namespace UserControlDbLib
{
    public partial class UserControlDb : UserControl
    {
        public UserControlDb()
        {
            InitializeComponent();
        }
        public void AddStudent(Student s)
        {
            lblAge.Text = s.age.ToString();
            lblFirstName.Text = s.firstName;
            lblLastName.Text = s.lastName;
            chkMale.Checked = s.male;
            chkLoveSports.Checked = s.likeSports;
                
        }
    }
}
