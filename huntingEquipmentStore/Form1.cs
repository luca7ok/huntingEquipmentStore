using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace huntingEquipmentStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Size formSize = new Size((int)(Screen.PrimaryScreen.Bounds.Width * 0.7), (int)(Screen.PrimaryScreen.Bounds.Height * 0.7));

        private void PositionControlsRelative()
        {
            loginPageLabel.Location = new Point((this.ClientSize.Width - loginPageLabel.Width) / 2, (int)(this.ClientSize.Height * 0.15));
            signupPageLabel.Location = new Point((this.ClientSize.Width - signupPageLabel.Width) / 2, (int)(this.ClientSize.Height * 0.15));

            usernameLoginLabel.Location = new Point((this.ClientSize.Width - usernameLoginLabel.Width) / 2, (int)(this.ClientSize.Height * 0.3));
            usernameLoginTextBox.Location = new Point((this.ClientSize.Width - usernameLoginTextBox.Width) / 2, (int)(this.ClientSize.Height * 0.35));
            usernameSignupLabel.Location = new Point((this.ClientSize.Width - usernameSignupLabel.Width) / 2, (int)(this.ClientSize.Height * 0.4));
            usernameSignupTextBox.Location = new Point((this.ClientSize.Width - usernameSignupTextBox.Width) / 2, (int)(this.ClientSize.Height * 0.45));

            passwordLoginLabel.Location = new Point((this.ClientSize.Width - passwordLoginLabel.Width) / 2, (int)(this.ClientSize.Height * 0.4));
            passwordLoginTextBox.Location = new Point((this.ClientSize.Width - passwordLoginTextBox.Width) / 2, (int)(this.ClientSize.Height * 0.45));
            passwordSignupLabel.Location = new Point((this.ClientSize.Width - passwordSignupLabel.Width) / 2, (int)(this.ClientSize.Height * 0.5));
            passwordSignupTextBox.Location = new Point((this.ClientSize.Width - passwordSignupTextBox.Width) / 2, (int)(this.ClientSize.Height * 0.55));

            fullnameSignupLabel.Location = new Point((this.ClientSize.Width - fullnameSignupLabel.Width) / 2, (int)(this.ClientSize.Height * 0.3));
            fullnameSignupTextBox.Location = new Point((this.ClientSize.Width - fullnameSignupTextBox.Width) / 2, (int)(this.ClientSize.Height * 0.35));

            loginButton.Location = new Point((this.ClientSize.Width - loginButton.Width) / 2, (int)(this.ClientSize.Height * 0.5));
            createAccountLabel.Location = new Point((this.ClientSize.Width - createAccountLabel.Width) / 2, (int)(this.ClientSize.Height * 0.65));
            createAccountButton.Location = new Point((this.ClientSize.Width - createAccountButton.Width) / 2, (int)(this.ClientSize.Height * 0.7));
            signupButton.Location = new Point((this.ClientSize.Width - signupButton.Width) / 2, (int)(this.ClientSize.Height * 0.6));
            backToLoginButton.Location = new Point((this.ClientSize.Width - backToLoginButton.Width) / 2, (int)(this.ClientSize.Height * 0.68));
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.categoriesTableAdapter.Fill(this.hunting_equipment_storeDataSet.Categories);
            this.productsTableAdapter.Fill(this.hunting_equipment_storeDataSet.Products);
            this.customersTableAdapter.Fill(this.hunting_equipment_storeDataSet.Customers);
            this.ordersTableAdapter.Fill(this.hunting_equipment_storeDataSet.Orders);
            this.reviewsTableAdapter.Fill(this.hunting_equipment_storeDataSet.Reviews);


            this.Size = formSize;
            PositionControlsRelative();

            tabControl1.Size = formSize;
            tabControl1.SelectedTab = loginPage;

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == loginPage)
            {
                usernameLoginTextBox.Clear();
                passwordLoginTextBox.Clear();
            }
            else if (tabControl1.SelectedTab == signupPage)
            {
                fullnameSignupTextBox.Clear();
                usernameSignupTextBox.Clear();
                passwordSignupTextBox.Clear();
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameLoginTextBox.Text.Trim();
            string password = passwordLoginTextBox.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                System.Windows.Forms.MessageBox.Show("Please enter a username");
            }
            else if (string.IsNullOrEmpty(password))
            {
                System.Windows.Forms.MessageBox.Show("Please enter a password");
            }
            else
            {
                hunting_equipment_storeDataSet.Customers.Clear();
                customersTableAdapter.getCustomerByUsername(hunting_equipment_storeDataSet.Customers, username);
                DataTable usernameTable = hunting_equipment_storeDataSet.Customers;

                if (usernameTable.Rows.Count == 0)
                {
                    System.Windows.Forms.MessageBox.Show("User doesn't exist");
                }
                else
                {
                    hunting_equipment_storeDataSet.Customers.Clear();
                    customersTableAdapter.getCustomerByUsernameAndPassword(hunting_equipment_storeDataSet.Customers, username, password);
                    DataTable customerTable = hunting_equipment_storeDataSet.Customers;
                    if (customerTable.Rows.Count > 0)
                    {
                        System.Windows.Forms.MessageBox.Show("Succesfully logged in");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Password doesn't match");
                    }

                }



            }
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = signupPage;
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            string fullname = fullnameSignupTextBox.Text.Trim();
            string username = usernameSignupTextBox.Text.Trim();
            string password = passwordSignupTextBox.Text.Trim();

            if (string.IsNullOrEmpty(fullname))
            {
                System.Windows.Forms.MessageBox.Show("Please enter your full name");
            }
            else if (string.IsNullOrEmpty(username))
            {
                System.Windows.Forms.MessageBox.Show("Please enter a username");
            }
            else if (string.IsNullOrEmpty(password))
            {
                System.Windows.Forms.MessageBox.Show("Please enter a password");
            }
            else
            {
                hunting_equipment_storeDataSet.Customers.Clear();
                customersTableAdapter.getCustomerByUsername(hunting_equipment_storeDataSet.Customers, username);
                DataTable usernameTable = hunting_equipment_storeDataSet.Customers;

                if (usernameTable.Rows.Count > 0)
                {
                    System.Windows.Forms.MessageBox.Show("Username already exists");
                }
                else
                {
                    customersTableAdapter.addCustomer(username, password, fullname);
                    tabControl1.SelectedTab = loginPage;
                }
            }


        }

        private void backToLoginButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = loginPage;
        }


    }
}
