using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondSemester
{
    public partial class AddOrModifyForm : Form
    {
        public BindingSource personBindingSource = new BindingSource();
        bool hasADD;
        public AddOrModifyForm()
        {
            InitializeComponent();
        }

        private void AddOrModifyForm_Load(object sender, EventArgs e)
        {
            var current = personBindingSource.Current as Person;
            if (hasADD)
            {
                lbltitle.Text = "Add New Item ...!";
            }
            else
            {
                lbltitle.Text = $"";
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (hasADD)
            {
                personBindingSource.AddNew();
                var item = personBindingSource.Current as Person;
                item.FirstName = txtFName.Text;
                item.LastName = txtFName.Text;
                item.Gender = cbGender.Text;
                item.Phone = txtPhone.Text;
                personBindingSource.EndEdit();
                Clear();
            }
            else
            {
                var item = (Person)personBindingSource.Current;
                item.FirstName = txtFName.Text;
                item.LastName = txtLName.Text;
                item.Gender = cbGender.Text;
                item.Phone = txtPhone.Text;
                personBindingSource.EndEdit();
                personBindingSource.ResetCurrentItem();
                this.Close();


            }
        }
        void Clear()
        {
            txtFName.Clear();
            txtLName.Clear();
            txtPhone.Clear();
            cbGender.SelectedIndex = 0;
            txtFName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

