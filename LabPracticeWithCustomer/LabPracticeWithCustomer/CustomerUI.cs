using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabPracticeWithCustomer.Manager;
using LabPracticeWithCustomer.Model;

namespace LabPracticeWithCustomer
{
    public partial class CustomerUI : Form
    {
        public CustomerUI()
        {
            InitializeComponent();
        }
        Customer _customer = new Customer();
        CustomerManager _customerManager = new CustomerManager(); 
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ValidCustomer()) return;
            _customer.Code = codeTextBox.Text;
            _customer.Id = Convert.ToInt16(idLabel.Text);
            if (_customerManager.ExistCode(_customer))
            {
                MessageBox.Show("This customer's code " + codeTextBox.Text+ " already exists");
                return;
            }
            _customer.Contact = contactTextBox.Text;
            if(_customerManager.ExistContact(_customer))
            {
                MessageBox.Show("This customer's contact number " + contactTextBox.Text + " already used");
                return;
            }
            _customer.Name = nameTextBox.Text;
            _customer.Address = addressTextBox.Text;
            _customer.District = districtComboBox.Text;
            if (saveButton.Text == "Save")
            {
                MessageBox.Show(_customerManager.InsertCustomer(_customer));
                customerDataGridView.DataSource = _customerManager.ShowCustomer();
            }
            else
            {
                MessageBox.Show(_customerManager.UpdateCustomer(_customer)
                    ? "Customer is updated"
                    : "Customer is not updated");
                saveButton.Text = "Save";
                customerDataGridView.DataSource = _customerManager.ShowCustomer();
            }
           
            ClearInput();
        }

        private void ClearInput()
        {
            codeTextBox.Clear();
            nameTextBox.Clear();
            addressTextBox.Clear();
            contactTextBox.Clear();
            districtComboBox.SelectedIndex = -1;
            districtComboBox.SelectedText = "--Select--";
            saveButton.Text = "Save";
        }

        private bool ValidCustomer()
        {
            if (String.IsNullOrEmpty(codeTextBox.Text))
            {
                codeValidLabel.Text = "*Please enter a code";
                return true;
            }
            if (codeTextBox.Text.Length!= 4)
            {
                codeValidLabel.Text = "*Code should be 4 characters";
                return true;
            }
            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                nameValidLabel.Text = "Please enter a customer name";
                return true;
            }
            if (String.IsNullOrEmpty(addressTextBox.Text))
            {
                addressValidLabel.Text = "Please enter address";
                return true;
            }
            if (String.IsNullOrEmpty(contactTextBox.Text))
            {
                addressValidLabel.Text = "Please enter contact number";
                return true;
            }
            if (contactTextBox.Text.Length != 11)
            {
                contactValidLabel.Text = "Contact number should be in 11 digits";
                return true;
            }
            if (String.IsNullOrEmpty(districtComboBox.Text)||districtComboBox.Text == "--Select--")
            {
                districtValidLabel.Text = "Please select your district";
                return true;
            }
            codeValidLabel.Text = "";
            nameValidLabel.Text = "";
            addressValidLabel.Text = "";
            contactValidLabel.Text = "";
            districtValidLabel.Text = "";
            return false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            _customer.Code = codeTextBox.Text;
            _customer.Name = nameTextBox.Text;
            _customer.Address = addressTextBox.Text;
            _customer.Contact = addressTextBox.Text;
            _customer.District = districtComboBox.Text;
            customerDataGridView.DataSource = _customerManager.SearchCustomer(_customer);
            if (_customerManager.SearchCustomer(_customer).Count<0)
                MessageBox.Show("No data found");
            
        }

        private void CustomerUI_Load(object sender, EventArgs e)
        {
            districtComboBox.DataSource = _customerManager.GetAllDistrict();
            districtComboBox.SelectedIndex = -1;
            districtComboBox.SelectedText = "--Select--";
            customerDataGridView.DataSource = _customerManager.ShowCustomer();
        }

      

        private void customerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            searchButton.Visible = true;
            saveButton.Text = "Update";
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.customerDataGridView.Rows[e.RowIndex];
                idLabel.Text = row.Cells[0].Value.ToString();
                codeTextBox.Text = row.Cells[1].Value.ToString();
                nameTextBox.Text = row.Cells[2].Value.ToString();
                addressTextBox.Text = row.Cells[3].Value.ToString();
                contactTextBox.Text = row.Cells[4].Value.ToString();
                districtComboBox.Text = row.Cells[5].Value.ToString();
            }
        }

        private void customerDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            customerDataGridView.Columns[0].HeaderText = "Sl No";
            if (e.RowIndex < 0 || e.RowIndex == this.customerDataGridView.NewRowIndex)
                return;

           
            if (e.ColumnIndex == this.customerDataGridView.Columns["Id"].Index)
            {
                e.Value = e.RowIndex + 1;
            }
        }
    }
}
