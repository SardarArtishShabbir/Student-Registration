using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Registration
{
    public partial class EditStudent : Form
    {
        public EditStudent()
        {
            InitializeComponent();
        }

        private void EditStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registerStudentDataSet2.tbl_student' table. You can move, or remove it, as needed.
            this.tbl_studentTableAdapter1.Fill(this.registerStudentDataSet2.tbl_student);
            // TODO: This line of code loads data into the 'registerStudentDataSet1.tbl_student' table. You can move, or remove it, as needed.
            this.tbl_studentTableAdapter.Fill(this.registerStudentDataSet1.tbl_student);

        }
    }
}
