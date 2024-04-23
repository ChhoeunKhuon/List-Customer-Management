using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondSemester
{
    public partial class Form1 : Form
    {
        List<Person> people;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            people = getPeople();
            personBindingSource.DataSource = people;
        }
        List<Person> getPeople()
        {
            return new List<Person> {
            new Person { FirstName = "Bona", LastName = "PHEN",
                        Gender= "Male", Phone = "012333444" },
            new Person { FirstName = "Tola", LastName = "PRUM",
                        Gender= "Male", Phone = "016666444" },
            new Person { FirstName = "Phannha", LastName = "PHAL",
                        Gender= "Male", Phone = "017777444" },
            new Person { FirstName = "Theary", LastName = "HENG",
                        Gender= "Female", Phone = "011111444" },
            new Person { FirstName = "Bophan", LastName = "CHAN",
                        Gender= "Female", Phone = "012999444" },
             };

        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            AddOrModifyForm frm = new AddOrModifyForm();
            frm.personBindingSource = this.personBindingSource;
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            personBindingSource.RemoveCurrent();
            personBindingSource.EndEdit();
            personBindingSource.ResetCurrentItem();

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            AddOrModifyForm frm = new AddOrModifyForm();
            frm.personBindingSource = this.personBindingSource;
            frm.ShowDialog();

        }
    }
}
