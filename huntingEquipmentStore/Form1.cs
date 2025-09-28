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

        private Size formSize = new Size((int)(Screen.PrimaryScreen.Bounds.Width * 0.7), (int)(Screen.PrimaryScreen.Bounds.Height * 0.7));
        private TabPage lastPage;
        private List<Tuple<int, int>> shoppingCart = new List<Tuple<int, int>>();

        private void PositionControlsRelative()
        {
            this.Size = formSize;

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
            
            productPicture.Size = new Size((int)(this.ClientSize.Width * 0.4), (int)(this.ClientSize.Height * 0.4));
            productDescriptionLabel.MaximumSize = new Size(productPicture.Size.Width, 0);

            backProductButton.Size = new Size((int)(this.ClientSize.Width * 0.08), (int)(this.ClientSize.Height * 0.08));
            backProductButton.Location = new Point((int)(this.ClientSize.Width * 0.02), (int)(this.ClientSize.Height * 0.85));

            flowLayoutPanel1.Location = new Point((this.ClientSize.Width - flowLayoutPanel1.Width) / 2, (int)(this.ClientSize.Height * 0.1));
            flowLayoutPanel1.Size = new Size((int)(Screen.PrimaryScreen.Bounds.Width * 0.9 * 0.7), (int)(Screen.PrimaryScreen.Bounds.Height * 0.75 * 0.7));

            flowLayoutPanel2.Size = new Size((int)(this.Size.Width * 0.6), (int)(this.Size.Height * 0.7));
            flowLayoutPanel2.Location = new Point((int)(this.Size.Width * 0.05), (int)(this.Size.Height * 0.15));

            totalItemsLabel.Location = new Point((int)(this.Size.Width * 0.75), (int)(this.Size.Height * 0.15));
            totalPriceLabel.Location = new Point((int)(this.Size.Width * 0.75), (int)(this.Size.Height * 0.25));
            totalItemsNumberLabel.Location = new Point((int)(this.Size.Width * 0.9), (int)(this.Size.Height * 0.15));
            totalPriceNumberLabel.Location = new Point((int)(this.Size.Width * 0.9), (int)(this.Size.Height * 0.25));

            tabControl1.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.categoriesTableAdapter.Fill(this.hunting_equipment_storeDataSet.Categories);
            this.productsTableAdapter.Fill(this.hunting_equipment_storeDataSet.Products);
            this.customersTableAdapter.Fill(this.hunting_equipment_storeDataSet.Customers);
            this.ordersTableAdapter.Fill(this.hunting_equipment_storeDataSet.Orders);
            this.reviewsTableAdapter.Fill(this.hunting_equipment_storeDataSet.Reviews);

            PositionControlsRelative();

            tabControl1.SelectedTab = loginPage;
            TabPage lastPage = loginPage;

        }

        private void createFlowLayoutPanel()
        {
            flowLayoutPanel1.Controls.Clear();

            hunting_equipment_storeDataSet.Products.Clear();
            productsTableAdapter.getAllProducts(hunting_equipment_storeDataSet.Products);

            foreach (DataRow product in hunting_equipment_storeDataSet.Products.Rows)
            {
                Panel productCard = createProductPanel(product);
                flowLayoutPanel1.Controls.Add(productCard);
            }
           
        }

        private Panel createProductPanel(DataRow product)
        {
            Panel card = new Panel()
            {
                Size = new Size((int)(Screen.PrimaryScreen.Bounds.Width * 0.2), (int)(Screen.PrimaryScreen.Bounds.Height * 0.2)),
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(5),
                Padding = new Padding(10),
            };

            PictureBox productImage = createProductImage(product, card);
            productImage.Click += (s, e) => productDetails(product);
            card.Controls.Add(productImage);

            Label productName = createProductNameLabel(product, card);
            productName.Click += (s, e) => productDetails(product);
            card.Controls.Add(productName);

            Label productPrice = createProductPriceLabel(product, card);
            card.Controls.Add(productPrice);  

            NumericUpDown quantityNumeric = createQuantityNumeric(product, card);          
            card.Controls.Add(quantityNumeric);

            Button cartButton = createCartButton(product, card);
            cartButton.Click += (s, e) => addToCart(product, quantityNumeric);
            card.Controls.Add(cartButton);

            return card;
        }

        private PictureBox createProductImage(DataRow product, Panel card)
        {
            PictureBox picture = new PictureBox()
            {
                Size = new Size((int)(card.Width / 2), (int)(card.Height * 0.6)),
                Location = new Point((card.Width - card.Width / 2) / 2, 0),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.FromArgb(245, 245, 245),
                BorderStyle = BorderStyle.FixedSingle,
                Cursor = Cursors.Hand
            };

            string image = product["image"].ToString().Trim();

            if (!string.IsNullOrEmpty(image))
            {
                picture.Image = Image.FromFile(@"..\\..\\Resources\" + image);
            }
            else
            {
                picture.Image = Image.FromFile(@"..\\..\\Resources\placeholder.jpg");
            }

            return picture;
        }

        private Label createProductNameLabel(DataRow product, Panel card)
        {
            Label label = new Label()
            {  
                Text = product["name"].ToString().Trim(),
                Size = new Size(card.Width, (int)(card.Height * 0.1)),
                Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold),
                Location = new Point(0, (int)(card.Height * 0.6)),
                ForeColor = Color.Beige,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Cursor = Cursors.Hand
            };

            return label;
        }

        private Label createProductPriceLabel(DataRow product, Panel card)
        {
            Label label = new Label()
            {
                Text = product["price"].ToString().Trim() + " $",
                Size = new Size(card.Width, (int)(card.Height * 0.2)),
                Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold),
                Location = new Point( 0, (int)(card.Height * 0.65)),
                ForeColor = Color.Beige,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false
            };
            return label;
        }

        private NumericUpDown createQuantityNumeric(DataRow product, Panel card)
        {
            NumericUpDown numeric = new NumericUpDown()
            {
                Location = new Point((int)(card.Width - card.Width * 0.1) / 2, (int)(card.Height * 0.85)),
                Size = new Size((int)(card.Width * 0.1), (int)(card.Height * 0.4)),
                Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold),
                Minimum = 1,
                Maximum = 10,
                Value = 1,
                Cursor = Cursors.Hand
            };
            return numeric;
        }

        private Button createCartButton(DataRow product, Panel card)
        {
            Button button = new Button()
            {
                Text = "Add to cart",
                Location = new Point((int)(card.Width - card.Width * 0.3), (int)(card.Height * 0.7)),
                Size = new Size((int)(card.Width * 0.3), (int)(card.Height * 0.4)),
                BackColor = Color.FromArgb(46, 46, 46),
                ForeColor = Color.Beige,
                Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            return button;
        }

        private void productDetails(DataRow product)
        {
            lastPage = tabControl1.SelectedTab;
            tabControl1.SelectedTab = productPage;

            string image = product["image"].ToString().Trim();

            if (!string.IsNullOrEmpty(image))
            {
                productPicture.Image = Image.FromFile(@"..\\..\\Resources\" + image);
            }
            else
            {
                productPicture.Image = Image.FromFile(@"..\\..\\Resources\placeholder.jpg");
            }

            productNameLabel.Text = product["name"].ToString().Trim();
            productPriceLabel.Text = product["price"].ToString().Trim() + " $";
            productDescriptionLabel.Text = product["description"].ToString().Trim();

            productPicture.Location = new Point((this.ClientSize.Width - productPicture.Width) / 2, (int)(this.ClientSize.Height * 0.1));
            productNameLabel.Location = new Point((this.ClientSize.Width - productNameLabel.Width) / 2, (int)(this.ClientSize.Height * 0.55));
            productPriceLabel.Location = new Point((this.ClientSize.Width - productPriceLabel.Width) / 2, (int)(this.ClientSize.Height * 0.6));
            productDescriptionLabel.Location = new Point((this.ClientSize.Width - productDescriptionLabel.Width) / 2, (int)(this.ClientSize.Height * 0.65));
             
        }

        private void addToCart(DataRow product, NumericUpDown numericQuantity)
        {
            int productID = int.Parse(product["product_id"].ToString().Trim());
            int quantity = int.Parse(numericQuantity.Value.ToString().Trim());

            var existingItem = shoppingCart.FirstOrDefault(item => item.Item1 == productID);

            if (existingItem != null)
            {
                shoppingCart.Remove(existingItem);
                shoppingCart.Add(Tuple.Create(productID, existingItem.Item2 + quantity));
            }
            else
            {
                shoppingCart.Add(Tuple.Create(productID, quantity));
            }
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
            else if (tabControl1.SelectedTab == shopPage)
            {
                foreach (Panel panel in flowLayoutPanel1.Controls)
                {
                    NumericUpDown numericQuantity = panel.Controls.OfType<NumericUpDown>().FirstOrDefault();
                    numericQuantity.Value = 1;
                }
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
                        tabControl1.SelectedTab = shopPage;
                        createFlowLayoutPanel();
                        menuStrip1.Visible = true;
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


        private void shoppingCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = cartPage;
            flowLayoutPanel2.Controls.Clear();
            if (shoppingCart.Count == 0)
            {
                totalPriceNumberLabel.Text = "0.00 $";
                totalItemsNumberLabel.Text = "0";

                Panel card = new Panel()
                {
                    Size = new Size((int)(flowLayoutPanel2.Width * 0.95), (int)(Screen.PrimaryScreen.Bounds.Height * 0.1)),
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(5),
                    Padding = new Padding(10),
                };
                
                Label emptyLabel = new Label()
                {
                    Text = "Shopping cart is empty",
                    Font = new Font("Microsoft Sans Serif", 24, FontStyle.Bold),
                    ForeColor = Color.Beige,
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = true            
                };
                card.Controls.Add(emptyLabel);
                emptyLabel.Location = new Point((card.Width - emptyLabel.Width) / 2, (card.Height - emptyLabel.Height) / 2);

                flowLayoutPanel2.Controls.Add(card);
                
            }
            else
            {
                double totalPrice = 0;
                int totalItems = 0;
                foreach (Tuple<int, int> cartItem in shoppingCart)
                {
                    hunting_equipment_storeDataSet.Products.Clear();
                    productsTableAdapter.getProductByID(hunting_equipment_storeDataSet.Products, cartItem.Item1);
                    DataRow product = hunting_equipment_storeDataSet.Products.Rows[0];

                    totalPrice += double.Parse(product["price"].ToString().Trim()) * cartItem.Item2;
                    totalItems += cartItem.Item2;

                    totalPriceNumberLabel.Text = totalPrice.ToString().Trim();
                    totalItemsNumberLabel.Text = totalItems.ToString().Trim();

                    Panel card = new Panel()
                    {
                        Size = new Size((int)(flowLayoutPanel2.Width * 0.95), (int)(Screen.PrimaryScreen.Bounds.Height * 0.1)),
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(5),
                        Padding = new Padding(10),
                    };

                    PictureBox picture = new PictureBox()
                    {
                        Size = new Size((int)(card.Width * 0.2), (int)(card.Height * 0.8)),
                        Location = new Point((int)(card.Width * 0.03), (int)(card.Height - card.Height * 0.8) / 2),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        BackColor = Color.FromArgb(245, 245, 245),
                        BorderStyle = BorderStyle.FixedSingle,
                        Cursor = Cursors.Hand
                    };

                    string image = product["image"].ToString().Trim();

                    if (!string.IsNullOrEmpty(image))
                    {
                        picture.Image = Image.FromFile(@"..\\..\\Resources\" + image);
                    }
                    else
                    {
                        picture.Image = Image.FromFile(@"..\\..\\Resources\placeholder.jpg");
                    }
                    picture.Click += (s, f) => productDetails(product);

                    Label nameLabel = new Label()
                    {
                        Text = product["name"].ToString().Trim(),
                        MaximumSize = new Size((int)(card.Width * 0.3), 0),
                        Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold),
                        ForeColor = Color.Beige,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Cursor = Cursors.Hand,
                        AutoSize = true
                    };
                    nameLabel.Click += (s, f) => productDetails(product);

                    Label amountUnitPriceLabel = new Label()
                    {
                        Text = cartItem.Item2.ToString().Trim() + " x " + product["price"].ToString().Trim() + " $" ,
                        Size = new Size((int)(card.Width * 0.15), (int)(card.Height * 0.24)),
                        Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold),
                        Location = new Point((int)(card.Width * 0.60), (int)(card.Height - card.Height * 0.2) / 2),
                        ForeColor = Color.Beige,
                        TextAlign = ContentAlignment.MiddleCenter,
                        AutoSize = true,
                    };

                    Label totalPriceLabel = new Label()
                    {
                        Text = (double.Parse(product["price"].ToString().Trim()) * cartItem.Item2).ToString().Trim() + " $",
                        Size = new Size((int)(card.Width * 0.15), (int)(card.Height * 0.24)),
                        Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold),
                        Location = new Point((int)(card.Width * 0.85), (int)(card.Height - card.Height * 0.2) / 2),
                        ForeColor = Color.Beige,
                        TextAlign = ContentAlignment.MiddleCenter,
                        AutoSize = true,
                    };

                    card.Controls.Add(picture);
                    card.Controls.Add(nameLabel);
                    card.Controls.Add(amountUnitPriceLabel);
                    card.Controls.Add(totalPriceLabel);

                    nameLabel.Location = new Point((int)(card.Width * 0.25), (int)(card.Height - nameLabel.Height) / 2);

                    flowLayoutPanel2.Controls.Add(card);
                }
            }
        }

        private void yourAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = ordersPage;
        }

        private void shopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = shopPage;
            createFlowLayoutPanel();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = categoriesPage;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = loginPage;
            shoppingCart.Clear();
            menuStrip1.Visible = false;
        }

        private void backProductButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = lastPage;
        }


  
    }
}
