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
        DataRow currentCustomer;
        double totalPrice = 0;

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
            backProductButton.Location = new Point((int)(this.ClientSize.Width * 0.02), (int)(this.ClientSize.Height * 0.86));

            backOrderDetailsButton.Size = new Size((int)(this.ClientSize.Width * 0.08), (int)(this.ClientSize.Height * 0.08));
            backOrderDetailsButton.Location = new Point((int)(this.ClientSize.Width * 0.02), (int)(this.ClientSize.Height * 0.86));

            backCategoryButton.Size = new Size((int)(this.ClientSize.Width * 0.08), (int)(this.ClientSize.Height * 0.08));
            backCategoryButton.Location = new Point((int)(this.ClientSize.Width * 0.02), (int)(this.ClientSize.Height * 0.86));

            backReviewsButton.Size = new Size((int)(this.ClientSize.Width * 0.08), (int)(this.ClientSize.Height * 0.08));
            backReviewsButton.Location = new Point((int)(this.ClientSize.Width * 0.02), (int)(this.ClientSize.Height * 0.86));

            flowLayoutPanel1.Location = new Point((this.ClientSize.Width - flowLayoutPanel1.Width) / 2, (int)(this.ClientSize.Height * 0.15));
            flowLayoutPanel1.Size = new Size((int)(Screen.PrimaryScreen.Bounds.Width * 0.9 * 0.7), (int)(Screen.PrimaryScreen.Bounds.Height * 0.75 * 0.7));

            flowLayoutPanel2.Size = new Size((int)(this.Size.Width * 0.6), (int)(this.Size.Height * 0.7));
            flowLayoutPanel2.Location = new Point((int)(this.Size.Width * 0.05), (int)(this.Size.Height * 0.2));

            totalItemsLabel.Location = new Point((int)(this.Size.Width * 0.75), (int)(this.Size.Height * 0.2));
            totalPriceLabel.Location = new Point((int)(this.Size.Width * 0.75), (int)(this.Size.Height * 0.3));
            totalItemsNumberLabel.Location = new Point((int)(this.Size.Width * 0.9), (int)(this.Size.Height * 0.2));
            totalPriceNumberLabel.Location = new Point((int)(this.Size.Width * 0.9), (int)(this.Size.Height * 0.3));

            clearCartButton.Location = new Point((int)(this.Size.Width * 0.75), (int)(this.Size.Height * 0.4));
            checkoutButton.Location = new Point((int)(this.Size.Width * 0.75), (int)(this.Size.Height * 0.5));

            flowLayoutPanel3.Size = new Size((int)(this.Size.Width * 0.4), (int)(this.Size.Height * 0.7));
            flowLayoutPanel3.Location = new Point((int)(this.Size.Width - flowLayoutPanel3.Width)/2, (int)(this.Size.Height * 0.2));

            yourOrdersLabel.Location = new Point((this.ClientSize.Width - yourOrdersLabel.Width) / 2, (int)(this.ClientSize.Height * 0.07));

            categoriesLabel.Location = new Point((this.ClientSize.Width - categoriesLabel.Width) / 2, (int)(this.ClientSize.Height * 0.07));

            shoppingCartLabel.Location = new Point((this.ClientSize.Width - shoppingCartLabel.Width) / 2, (int)(this.ClientSize.Height * 0.07));

            tabControl.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            flowLayoutPanel4.Size = new Size((int)(this.Size.Width * 0.5), (int)(this.Size.Height * 0.7));
            flowLayoutPanel4.Location = new Point((int)(this.Size.Width - flowLayoutPanel4.Width) / 2, (int)(this.Size.Height * 0.2));

            flowLayoutPanel5.Size = new Size((int)(this.Size.Width * 0.5), (int)(this.Size.Height * 0.7));
            flowLayoutPanel5.Location = new Point((int)(this.Size.Width - flowLayoutPanel5.Width) / 2, (int)(this.Size.Height * 0.2));

            flowLayoutPanel6.Size = new Size((int)(this.Size.Width * 0.5), (int)(this.Size.Height * 0.7));
            flowLayoutPanel6.Location = new Point((int)(this.Size.Width - flowLayoutPanel6.Width) / 2, (int)(this.Size.Height * 0.2));

            richTextBox1.Location = new Point((int)(this.Size.Width * 0.8), (int)(this.Size.Height * 0.2));

            totalItemsLabel2.Location = new Point((int)(this.Size.Width * 0.78), (int)(this.Size.Height * 0.2));
            totalPriceLabel2.Location = new Point((int)(this.Size.Width * 0.78), (int)(this.Size.Height * 0.3));
            totalItemsNumberLabel2.Location = new Point((int)(this.Size.Width * 0.9), (int)(this.Size.Height * 0.2));
            totalPriceNumberLabel2.Location = new Point((int)(this.Size.Width * 0.9), (int)(this.Size.Height * 0.3));

            pictureBoxCategories1.Location = new Point((int)(this.Size.Width * 0.2), (int)(this.Size.Height * 0.2));
            pictureBoxCategories1.Click += (s, f) => categoryProducts(2);
            pictureBoxCategories2.Location = new Point((int)(this.Size.Width - pictureBoxCategories2.Width - 0.2 * this.Size.Width), (int)(this.Size.Height * 0.2));
            pictureBoxCategories2.Click += (s, f) => categoryProducts(3);
            pictureBoxCategories3.Location = new Point((int)(this.Size.Width * 0.2), (int)(this.Size.Height * 0.55));
            pictureBoxCategories3.Click += (s, f) => categoryProducts(1);
            pictureBoxCategories4.Location = new Point((int)(this.Size.Width - pictureBoxCategories4.Width - 0.2 * this.Size.Width), (int)(this.Size.Height * 0.55));
            pictureBoxCategories4.Click += (s, f) => categoryProducts(4);


            categoryLabel1.Location = new Point((int)(pictureBoxCategories1.Location.X + (pictureBoxCategories1.Width - categoryLabel1.Width) / 2), (int)(this.Size.Height * 0.4));
            categoryLabel1.Click += (s, f) => categoryProducts(2);
            categoryLabel2.Location = new Point((int)(pictureBoxCategories2.Location.X + (pictureBoxCategories2.Width - categoryLabel2.Width) / 2), (int)(this.Size.Height * 0.4));
            categoryLabel2.Click += (s, f) => categoryProducts(3);
            categoryLabel3.Location = new Point((int)(pictureBoxCategories3.Location.X + (pictureBoxCategories3.Width - categoryLabel3.Width) / 2), (int)(this.Size.Height * 0.75));
            categoryLabel3.Click += (s, f) => categoryProducts(1);
            categoryLabel4.Location = new Point((int)(pictureBoxCategories4.Location.X + (pictureBoxCategories4.Width - categoryLabel4.Width) / 2), (int)(this.Size.Height * 0.75));
            categoryLabel4.Click += (s, f) => categoryProducts(4);

            sortByPriceButton.Location = new Point((int)(flowLayoutPanel1.Location.X + Screen.PrimaryScreen.Bounds.Width * 0.2 * 3 + 22 - sortByPriceButton.Width), (int)(this.ClientSize.Height * 0.07));
            sortByNameButton.Location = new Point((int)(sortByPriceButton.Location.X - sortByNameButton.Width - 25), (int)(this.ClientSize.Height * 0.07));

            viewReviewButton.Location = new Point((int)(this.ClientSize.Width - viewReviewButton.Width) / 2, (int)(this.ClientSize.Height * 0.75));
            addReviewButton.Location = new Point((int)(this.ClientSize.Width * 0.8), (int)(this.ClientSize.Height * 0.75));
            richTextBox1.Location = new Point((int)(this.ClientSize.Width * 0.8), (int)(this.ClientSize.Height * 0.6));
            ratingLabel.Location = new Point((int)(this.ClientSize.Width * 0.8), (int)(this.ClientSize.Height * 0.55));
            ratingNumericUpDown.Location = new Point(richTextBox1.Location.X + richTextBox1.Width - ratingNumericUpDown.Width, (int)(this.ClientSize.Height * 0.55));
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.orderDetailsTableAdapter.Fill(this.hunting_equipment_storeDataSet.OrderDetails);
            this.categoriesTableAdapter.Fill(this.hunting_equipment_storeDataSet.Categories);
            this.productsTableAdapter.Fill(this.hunting_equipment_storeDataSet.Products);
            this.customersTableAdapter.Fill(this.hunting_equipment_storeDataSet.Customers);
            this.ordersTableAdapter.Fill(this.hunting_equipment_storeDataSet.Orders);
            this.reviewsTableAdapter.Fill(this.hunting_equipment_storeDataSet.Reviews);

            PositionControlsRelative();

            tabControl.SelectedTab = loginPage;
            TabPage lastPage = loginPage;

        }

        private void createFlowLayoutPanel()
        {
            flowLayoutPanel1.Controls.Clear();

            DataTable products = hunting_equipment_storeDataSet.Products;

            foreach (DataRow product in products.Rows)
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

            int productID = int.Parse(product["product_id"].ToString().Trim());

            PictureBox productImage = createProductImage(product, card);
            productImage.Click += (s, e) => productDetails(productID);
            card.Controls.Add(productImage);

            Label productName = createProductNameLabel(product, card);
            productName.Click += (s, e) => productDetails(productID);
            card.Controls.Add(productName);

            Label productPrice = createProductPriceLabel(product, card);
            card.Controls.Add(productPrice);  

            NumericUpDown quantityNumeric = createQuantityNumeric( card);          
            card.Controls.Add(quantityNumeric);

            Button cartButton = createCartButton(card);
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

        private NumericUpDown createQuantityNumeric(Panel card)
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

        private Button createCartButton(Panel card)
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

        private void productDetails(int productID)
        {
            hunting_equipment_storeDataSet.Products.Clear();
            productsTableAdapter.getProductByID(hunting_equipment_storeDataSet.Products, productID);
            DataRow product = hunting_equipment_storeDataSet.Products.Rows[0];

            richTextBox1.Clear();
            ratingNumericUpDown.Value = 5;

            lastPage = tabControl.SelectedTab;
            tabControl.SelectedTab = productPage;

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

            viewReviewButton.Click += viewReviews;
            viewReviewButton.Tag = productID;

            addReviewButton.Click += addReview;
            addReviewButton.Tag = productID;   
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
            if (tabControl.SelectedTab == loginPage)
            {
                usernameLoginTextBox.Clear();
                passwordLoginTextBox.Clear();
            }
            else if (tabControl.SelectedTab == signupPage)
            {
                fullnameSignupTextBox.Clear();
                usernameSignupTextBox.Clear();
                passwordSignupTextBox.Clear();
            }
            else if (tabControl.SelectedTab == shopPage)
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
                        tabControl.SelectedTab = shopPage;

                        hunting_equipment_storeDataSet.Products.Clear();
                        productsTableAdapter.getAllProducts(hunting_equipment_storeDataSet.Products);

                        createFlowLayoutPanel();
                        menuStrip1.Visible = true;
                        currentCustomer = hunting_equipment_storeDataSet.Customers.Rows[0];
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
            tabControl.SelectedTab = signupPage;
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
                    tabControl.SelectedTab = loginPage;
                }
            }


        }

        private void backToLoginButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = loginPage;
        }


        private void shoppingCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = cartPage;
            fillShoppingCart();
           
        }

        private void fillShoppingCart()
        {
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
                totalPrice = 0;
                int totalItems = 0;
                hunting_equipment_storeDataSet.ProductsDataTable tempProductsTable = new hunting_equipment_storeDataSet.ProductsDataTable();
                foreach (Tuple<int, int> cartItem in shoppingCart)
                {
                    int productID = cartItem.Item1;
                    int quantity = cartItem.Item2;

                    tempProductsTable.Clear();
                    productsTableAdapter.getProductByID(tempProductsTable, productID);
                    DataRow product = tempProductsTable.Rows[0];
                    
                    totalPrice += double.Parse(product["price"].ToString().Trim()) * quantity;
                    totalItems += quantity;

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
                    picture.Click += (s, e) => productDetails(productID);

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
                    nameLabel.Click += (s, e) => productDetails(productID);

                    Label amountUnitPriceLabel = new Label()
                    {
                        Text = quantity.ToString().Trim() + " x " + product["price"].ToString().Trim() + " $",
                        Size = new Size((int)(card.Width * 0.15), (int)(card.Height * 0.24)),
                        Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold),
                        Location = new Point((int)(card.Width * 0.60), (int)(card.Height - card.Height * 0.2) / 2),
                        ForeColor = Color.Beige,
                        TextAlign = ContentAlignment.MiddleCenter,
                        AutoSize = true,
                    };

                    Label totalPriceLabel = new Label()
                    {
                        Text = (double.Parse(product["price"].ToString().Trim()) * quantity).ToString().Trim() + " $",
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
                totalPriceNumberLabel.Text = totalPrice.ToString().Trim();
                totalItemsNumberLabel.Text = totalItems.ToString().Trim();
            }
        }

        private void orderDetails(int orderID, float totalPrice)
        {
            flowLayoutPanel4.Controls.Clear();

            hunting_equipment_storeDataSet.Orders.Clear();
            ordersTableAdapter.getOrderByID(hunting_equipment_storeDataSet.Orders, orderID);
            DataRow order = hunting_equipment_storeDataSet.Orders.Rows[0];

            tabControl.SelectedTab = orderDetailsPage;
            orderLabel.Text = "Order " + order["order_id"].ToString().Trim() + ", " + order["date"].ToString().Trim().Split(' ')[0];
            orderLabel.Location = new Point((this.ClientSize.Width - orderLabel.Width) / 2, (int)(this.ClientSize.Height * 0.07));

            hunting_equipment_storeDataSet.OrderDetails.Clear();
            orderDetailsTableAdapter.getDetailsByOrderID(hunting_equipment_storeDataSet.OrderDetails, orderID);
            DataTable details = hunting_equipment_storeDataSet.OrderDetails;

            int totalQuantity = 0;
            hunting_equipment_storeDataSet.ProductsDataTable tempProductsTable = new hunting_equipment_storeDataSet.ProductsDataTable();
            foreach (DataRow detail in details.Rows)
            {
                int productID = int.Parse(detail["product_id"].ToString().Trim());
                int quantity = int.Parse(detail["quantity"].ToString().Trim());

                totalQuantity += quantity;

                tempProductsTable.Clear();
                productsTableAdapter.getProductByID(tempProductsTable, productID);
                DataRow product = tempProductsTable.Rows[0];

                Panel card = new Panel()
                {
                    Size = new Size((int)(flowLayoutPanel4.Width * 0.95), (int)(Screen.PrimaryScreen.Bounds.Height * 0.1)),
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
                picture.Click += (s, e) => productDetails(productID);

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
                nameLabel.Click += (s, e) => productDetails(productID);

                Label amountUnitPriceLabel = new Label()
                {
                    Text = quantity.ToString().Trim() + " x " + product["price"].ToString().Trim() + " $",
                    Size = new Size((int)(card.Width * 0.15), (int)(card.Height * 0.24)),
                    Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold),
                    Location = new Point((int)(card.Width * 0.60), (int)(card.Height - card.Height * 0.2) / 2),
                    ForeColor = Color.Beige,
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = true,
                };

                Label totalPriceLabel = new Label()
                {
                    Text = (double.Parse(product["price"].ToString().Trim()) * quantity).ToString().Trim() + " $",
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

                flowLayoutPanel4.Controls.Add(card); 

                      
            }

            totalPriceNumberLabel2.Text = totalPrice.ToString()+ "$";
            totalItemsNumberLabel2.Text = totalQuantity.ToString();
        }

        private void shopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = shopPage;
            hunting_equipment_storeDataSet.Products.Clear();
            productsTableAdapter.getAllProducts(hunting_equipment_storeDataSet.Products);
            createFlowLayoutPanel();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = categoriesPage;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = loginPage;
            shoppingCart.Clear();
            menuStrip1.Visible = false;
        }

        private void backProductButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = lastPage;
        }

        private void clearCartButton_Click(object sender, EventArgs e)
        {
            shoppingCart.Clear();
            fillShoppingCart();
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            if (shoppingCart.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Shopping cart is empty");
            }
            else
            {
                ordersTableAdapter.addOrder(int.Parse(currentCustomer["customer_id"].ToString().Trim()), DateTime.Now.ToString("dd/MM/yyyy"), totalPrice);
                ordersTableAdapter.Update(hunting_equipment_storeDataSet);
                ordersTableAdapter.Fill(hunting_equipment_storeDataSet.Orders);

                DataTable orders = hunting_equipment_storeDataSet.Orders;
                int newOrderID = int.Parse(orders.Rows[orders.Rows.Count - 1]["order_id"].ToString().Trim());
                
                foreach (Tuple<int, int> cartItem in shoppingCart)
                {
                    orderDetailsTableAdapter.addOrderDetail(newOrderID, cartItem.Item1, cartItem.Item2);
                }
                shoppingCart.Clear();
                fillShoppingCart(); 
            }
        }

        private void yourOrdersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            tabControl.SelectedTab = yourOrdersPage;
            flowLayoutPanel3.Controls.Clear();

            hunting_equipment_storeDataSet.Orders.Clear();
            ordersTableAdapter.getAllOrdersByCustomerID(hunting_equipment_storeDataSet.Orders, int.Parse(currentCustomer["customer_id"].ToString().Trim()));
            DataTable orders = hunting_equipment_storeDataSet.Orders;

            if (orders.Rows.Count == 0)
            {
                Panel card = new Panel()
                {
                    Size = new Size((int)(flowLayoutPanel3.Width * 0.95), (int)(Screen.PrimaryScreen.Bounds.Height * 0.05)),
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(5),
                    Padding = new Padding(10)
                };

                Label noOrdersLabel = new Label()
                {
                    Text = "No orders yet",
                    Font = new Font("Microsoft Sans Serif", 26, FontStyle.Bold),
                    ForeColor = Color.Beige,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Cursor = Cursors.Hand,
                    AutoSize = true
                };
                card.Controls.Add(noOrdersLabel);
                noOrdersLabel.Location = new Point((card.Width - noOrdersLabel.Width) / 2, (card.Height - noOrdersLabel.Height) / 2);

                flowLayoutPanel3.Controls.Add(card);    
            }
            else
            {
                foreach (DataRow order in orders.Rows)
                {
                    int orderID = int.Parse(order["order_id"].ToString().Trim());
                    float totalPrice = float.Parse(order["total_price"].ToString().Trim());

                    Panel card = new Panel()
                    {
                        Size = new Size((int)(flowLayoutPanel3.Width * 0.95), (int)(Screen.PrimaryScreen.Bounds.Height * 0.05)),
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(5),
                        Padding = new Padding(10)
                    };

                    Label orderLabel = new Label()
                    {
                        Text = "Order " + order["order_id"].ToString().Trim() + ", " + order["date"].ToString().Trim().Split(' ')[0] + ", " + order["total_price"].ToString().Trim() + "$",
                        Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold),
                        ForeColor = Color.Beige,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Cursor = Cursors.Hand,
                        AutoSize = true
                    };
                    orderLabel.Click += (s, f) => orderDetails(orderID, totalPrice);

                    card.Controls.Add(orderLabel);
                    orderLabel.Location = new Point((card.Width - orderLabel.Width) / 2, (card.Height - orderLabel.Height) / 2);

                    flowLayoutPanel3.Controls.Add(card);
                }
            }
        }

        private void categoryProducts(int categoryID)
        {
            flowLayoutPanel5.Controls.Clear();

            tabControl.SelectedTab = categoryPage;
            hunting_equipment_storeDataSet.Categories.Clear();
            categoriesTableAdapter.getCategoryByID(hunting_equipment_storeDataSet.Categories, categoryID);
            DataRow category = hunting_equipment_storeDataSet.Categories.Rows[0];

            categoryLabel.Text = category["name"].ToString().Trim();
            categoryLabel.Location = new Point((this.ClientSize.Width - categoryLabel.Width) / 2, (int)(this.ClientSize.Height * 0.07));

            hunting_equipment_storeDataSet.Products.Clear();
            productsTableAdapter.getProductsByCategory(hunting_equipment_storeDataSet.Products, categoryID);
            DataTable products = hunting_equipment_storeDataSet.Products;

            foreach (DataRow product in products.Rows)
            {
                int productID = int.Parse(product["product_id"].ToString().Trim());

                Panel card = new Panel()
                {
                    Size = new Size((int)(flowLayoutPanel4.Width * 0.95), (int)(Screen.PrimaryScreen.Bounds.Height * 0.1)),
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

                Label priceLabel = new Label()
                {
                    Text = product["price"].ToString().Trim() + " $",
                    Size = new Size((int)(card.Width * 0.15), (int)(card.Height * 0.24)),
                    Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold),
                    Location = new Point((int)(card.Width * 0.8), (int)(card.Height - card.Height * 0.2) / 2),
                    ForeColor = Color.Beige,
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = true,
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
                picture.Click += (s, e) => productDetails(productID);

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
                nameLabel.Click += (s, e) => productDetails(productID);

                card.Controls.Add(picture);
                card.Controls.Add(nameLabel);
                card.Controls.Add(priceLabel);

                nameLabel.Location = new Point((int)(card.Width * 0.25), (int)(card.Height - nameLabel.Height) / 2);

                flowLayoutPanel5.Controls.Add(card);
            }
        }

        private void backOrderDetailsButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = yourOrdersPage;
        }

        private void backCategoryButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = categoriesPage;
        }

        private void sortByPriceButton_Click(object sender, EventArgs e)
        {
            hunting_equipment_storeDataSet.Products.Clear();
            productsTableAdapter.getProductsOrderedByPrice(hunting_equipment_storeDataSet.Products);
            createFlowLayoutPanel();
        }

        private void sortByNameButton_Click(object sender, EventArgs e)
        {
            hunting_equipment_storeDataSet.Products.Clear();
            productsTableAdapter.getProductsOrderedByName(hunting_equipment_storeDataSet.Products);
            createFlowLayoutPanel();
        }

        private void viewReviews(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int productID = (int)button.Tag;

            hunting_equipment_storeDataSet.Products.Clear();
            productsTableAdapter.getProductByID(hunting_equipment_storeDataSet.Products, productID);
            DataRow product = hunting_equipment_storeDataSet.Products.Rows[0];

            tabControl.SelectedTab = reviewsPage;
            flowLayoutPanel6.Controls.Clear();
            reviewsLabel.Text = product["name"].ToString().Trim() + " reviews";
            reviewsLabel.Location = new Point((this.ClientSize.Width - reviewsLabel.Width)/ 2, (int)(this.ClientSize.Height * 0.07));

            hunting_equipment_storeDataSet.Reviews.Clear();
            reviewsTableAdapter.getReviewsByProductID(hunting_equipment_storeDataSet.Reviews, productID);
            DataTable reviews = hunting_equipment_storeDataSet.Reviews;

            if (reviews.Rows.Count == 0)
            {
                Panel card = new Panel()
                {
                    Size = new Size((int)(flowLayoutPanel6.Width * 0.95), (int)(Screen.PrimaryScreen.Bounds.Height * 0.05)),
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(5),
                    Padding = new Padding(10)
                };

                Label noReviewsLabel = new Label()
                {
                    Text = "No reviews yet",
                    Font = new Font("Microsoft Sans Serif", 26, FontStyle.Bold),
                    ForeColor = Color.Beige,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Cursor = Cursors.Hand,
                    AutoSize = true
                };
                card.Controls.Add(noReviewsLabel);
                noReviewsLabel.Location = new Point((card.Width - noReviewsLabel.Width) / 2, (card.Height - noReviewsLabel.Height) / 2);

                flowLayoutPanel6.Controls.Add(card);
            }
            else
            {
                hunting_equipment_storeDataSet.CustomersDataTable tempCustomersTable = new hunting_equipment_storeDataSet.CustomersDataTable();
                foreach(DataRow review in reviews.Rows)
                {
                    tempCustomersTable.Clear();
                    customersTableAdapter.getCustomerByID(tempCustomersTable, int.Parse(review["customer_id"].ToString().Trim()));
                    DataRow reviewCustomer = tempCustomersTable.Rows[0];

                    Panel card = new Panel()
                    {
                        Size = new Size((int)(flowLayoutPanel6.Width * 0.95), (int)(Screen.PrimaryScreen.Bounds.Height * 0.05)),
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(5),
                        Padding = new Padding(10)
                    };

                    Label userLabel = new Label()
                    {
                        Text = reviewCustomer["username"].ToString().Trim() + ", " + review["rating"].ToString().Trim() + "/10, ",
                        Font = new Font("Microsoft Sans Serif", 26, FontStyle.Bold),
                        ForeColor = Color.Beige,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Cursor = Cursors.Hand,
                        AutoSize = true
                    };

                    Label dateLabel = new Label()
                    {
                        Text = review["date"].ToString().Trim(),
                        Font = new Font("Microsoft Sans Serif", 26, FontStyle.Bold),
                        ForeColor = Color.Beige,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Cursor = Cursors.Hand,
                        AutoSize = true
                    };
                    card.Controls.Add(userLabel);
                    card.Controls.Add(dateLabel);
                    dateLabel.Location = new Point((card.Location.X + card.Width - dateLabel.Width), dateLabel.Location.Y);

                    flowLayoutPanel6.Controls.Add(card);
                }
                
            }
        }

        private void backReviewsButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = productPage;
           
        }

        private void addReview(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int productID = (int)button.Tag;
            
            if (richTextBox1.Text.Length == 0)
            {
                MessageBox.Show("Review description cannot be empty");
            }
            else
            {
                reviewsTableAdapter.addReview(int.Parse(currentCustomer["customer_id"].ToString().Trim()), productID, int.Parse(ratingNumericUpDown.Value.ToString().Trim()), richTextBox1.Text, DateTime.Now);
                richTextBox1.Clear();
                ratingNumericUpDown.Value = 5;
            } 
        }

    }
}
