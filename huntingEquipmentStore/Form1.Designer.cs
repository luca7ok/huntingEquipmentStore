namespace huntingEquipmentStore
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.loginPage = new System.Windows.Forms.TabPage();
            this.createAccountLabel = new System.Windows.Forms.Label();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordLoginLabel = new System.Windows.Forms.Label();
            this.passwordLoginTextBox = new System.Windows.Forms.TextBox();
            this.usernameLoginLabel = new System.Windows.Forms.Label();
            this.usernameLoginTextBox = new System.Windows.Forms.TextBox();
            this.loginPageLabel = new System.Windows.Forms.Label();
            this.signupPage = new System.Windows.Forms.TabPage();
            this.backToLoginButton = new System.Windows.Forms.Button();
            this.signupButton = new System.Windows.Forms.Button();
            this.passwordSignupLabel = new System.Windows.Forms.Label();
            this.passwordSignupTextBox = new System.Windows.Forms.TextBox();
            this.usernameSignupLabel = new System.Windows.Forms.Label();
            this.usernameSignupTextBox = new System.Windows.Forms.TextBox();
            this.fullnameSignupLabel = new System.Windows.Forms.Label();
            this.fullnameSignupTextBox = new System.Windows.Forms.TextBox();
            this.signupPageLabel = new System.Windows.Forms.Label();
            this.shopPage = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.categoriesPage = new System.Windows.Forms.TabPage();
            this.cartPage = new System.Windows.Forms.TabPage();
            this.ordersPage = new System.Windows.Forms.TabPage();
            this.productPage = new System.Windows.Forms.TabPage();
            this.backProductButton = new System.Windows.Forms.Button();
            this.productDescriptionLabel = new System.Windows.Forms.Label();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productPicture = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.shopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shoppingCartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yourAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shoppingCartLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.totalItemsLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.totalItemsNumberLabel = new System.Windows.Forms.Label();
            this.totalPriceNumberLabel = new System.Windows.Forms.Label();
            this.hunting_equipment_storeDataSet = new huntingEquipmentStore.hunting_equipment_storeDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new huntingEquipmentStore.hunting_equipment_storeDataSetTableAdapters.CategoriesTableAdapter();
            this.tableAdapterManager = new huntingEquipmentStore.hunting_equipment_storeDataSetTableAdapters.TableAdapterManager();
            this.customersTableAdapter = new huntingEquipmentStore.hunting_equipment_storeDataSetTableAdapters.CustomersTableAdapter();
            this.ordersTableAdapter = new huntingEquipmentStore.hunting_equipment_storeDataSetTableAdapters.OrdersTableAdapter();
            this.productsTableAdapter = new huntingEquipmentStore.hunting_equipment_storeDataSetTableAdapters.ProductsTableAdapter();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reviewsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reviewsTableAdapter = new huntingEquipmentStore.hunting_equipment_storeDataSetTableAdapters.ReviewsTableAdapter();
            this.categoriesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.loginPage.SuspendLayout();
            this.signupPage.SuspendLayout();
            this.shopPage.SuspendLayout();
            this.cartPage.SuspendLayout();
            this.productPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hunting_equipment_storeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.loginPage);
            this.tabControl1.Controls.Add(this.signupPage);
            this.tabControl1.Controls.Add(this.shopPage);
            this.tabControl1.Controls.Add(this.categoriesPage);
            this.tabControl1.Controls.Add(this.cartPage);
            this.tabControl1.Controls.Add(this.ordersPage);
            this.tabControl1.Controls.Add(this.productPage);
            this.tabControl1.Location = new System.Drawing.Point(-10, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1533, 751);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // loginPage
            // 
            this.loginPage.BackColor = System.Drawing.Color.DarkSlateGray;
            this.loginPage.Controls.Add(this.createAccountLabel);
            this.loginPage.Controls.Add(this.createAccountButton);
            this.loginPage.Controls.Add(this.loginButton);
            this.loginPage.Controls.Add(this.passwordLoginLabel);
            this.loginPage.Controls.Add(this.passwordLoginTextBox);
            this.loginPage.Controls.Add(this.usernameLoginLabel);
            this.loginPage.Controls.Add(this.usernameLoginTextBox);
            this.loginPage.Controls.Add(this.loginPageLabel);
            this.loginPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(69)))), ((int)(((byte)(10)))));
            this.loginPage.Location = new System.Drawing.Point(4, 22);
            this.loginPage.Name = "loginPage";
            this.loginPage.Padding = new System.Windows.Forms.Padding(3);
            this.loginPage.Size = new System.Drawing.Size(1525, 725);
            this.loginPage.TabIndex = 0;
            this.loginPage.Text = "loginPage";
            // 
            // createAccountLabel
            // 
            this.createAccountLabel.AutoSize = true;
            this.createAccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountLabel.ForeColor = System.Drawing.Color.Beige;
            this.createAccountLabel.Location = new System.Drawing.Point(540, 564);
            this.createAccountLabel.Name = "createAccountLabel";
            this.createAccountLabel.Size = new System.Drawing.Size(319, 33);
            this.createAccountLabel.TabIndex = 7;
            this.createAccountLabel.Text = "Don\'t have an account?";
            this.createAccountLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // createAccountButton
            // 
            this.createAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.createAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountButton.ForeColor = System.Drawing.Color.Beige;
            this.createAccountButton.Location = new System.Drawing.Point(534, 616);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(337, 67);
            this.createAccountButton.TabIndex = 6;
            this.createAccountButton.Text = "Create account";
            this.createAccountButton.UseVisualStyleBackColor = false;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.Beige;
            this.loginButton.Location = new System.Drawing.Point(534, 449);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(337, 67);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordLoginLabel
            // 
            this.passwordLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLoginLabel.ForeColor = System.Drawing.Color.Beige;
            this.passwordLoginLabel.Location = new System.Drawing.Point(528, 321);
            this.passwordLoginLabel.Name = "passwordLoginLabel";
            this.passwordLoginLabel.Size = new System.Drawing.Size(343, 33);
            this.passwordLoginLabel.TabIndex = 4;
            this.passwordLoginLabel.Text = "Password";
            this.passwordLoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // passwordLoginTextBox
            // 
            this.passwordLoginTextBox.BackColor = System.Drawing.Color.Beige;
            this.passwordLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLoginTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.passwordLoginTextBox.Location = new System.Drawing.Point(534, 369);
            this.passwordLoginTextBox.MaxLength = 20;
            this.passwordLoginTextBox.Multiline = true;
            this.passwordLoginTextBox.Name = "passwordLoginTextBox";
            this.passwordLoginTextBox.PasswordChar = '*';
            this.passwordLoginTextBox.Size = new System.Drawing.Size(337, 34);
            this.passwordLoginTextBox.TabIndex = 3;
            // 
            // usernameLoginLabel
            // 
            this.usernameLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLoginLabel.ForeColor = System.Drawing.Color.Beige;
            this.usernameLoginLabel.Location = new System.Drawing.Point(528, 199);
            this.usernameLoginLabel.Name = "usernameLoginLabel";
            this.usernameLoginLabel.Size = new System.Drawing.Size(343, 33);
            this.usernameLoginLabel.TabIndex = 2;
            this.usernameLoginLabel.Text = "Username";
            this.usernameLoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // usernameLoginTextBox
            // 
            this.usernameLoginTextBox.BackColor = System.Drawing.Color.Beige;
            this.usernameLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLoginTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.usernameLoginTextBox.Location = new System.Drawing.Point(534, 247);
            this.usernameLoginTextBox.MaxLength = 20;
            this.usernameLoginTextBox.Multiline = true;
            this.usernameLoginTextBox.Name = "usernameLoginTextBox";
            this.usernameLoginTextBox.Size = new System.Drawing.Size(337, 34);
            this.usernameLoginTextBox.TabIndex = 1;
            // 
            // loginPageLabel
            // 
            this.loginPageLabel.AutoSize = true;
            this.loginPageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPageLabel.ForeColor = System.Drawing.Color.Beige;
            this.loginPageLabel.Location = new System.Drawing.Point(521, 85);
            this.loginPageLabel.Name = "loginPageLabel";
            this.loginPageLabel.Size = new System.Drawing.Size(358, 73);
            this.loginPageLabel.TabIndex = 0;
            this.loginPageLabel.Text = "Login Page";
            this.loginPageLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // signupPage
            // 
            this.signupPage.BackColor = System.Drawing.Color.DarkSlateGray;
            this.signupPage.Controls.Add(this.backToLoginButton);
            this.signupPage.Controls.Add(this.signupButton);
            this.signupPage.Controls.Add(this.passwordSignupLabel);
            this.signupPage.Controls.Add(this.passwordSignupTextBox);
            this.signupPage.Controls.Add(this.usernameSignupLabel);
            this.signupPage.Controls.Add(this.usernameSignupTextBox);
            this.signupPage.Controls.Add(this.fullnameSignupLabel);
            this.signupPage.Controls.Add(this.fullnameSignupTextBox);
            this.signupPage.Controls.Add(this.signupPageLabel);
            this.signupPage.Location = new System.Drawing.Point(4, 22);
            this.signupPage.Name = "signupPage";
            this.signupPage.Padding = new System.Windows.Forms.Padding(3);
            this.signupPage.Size = new System.Drawing.Size(1525, 725);
            this.signupPage.TabIndex = 1;
            this.signupPage.Text = "signupPage";
            // 
            // backToLoginButton
            // 
            this.backToLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.backToLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backToLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToLoginButton.ForeColor = System.Drawing.Color.Beige;
            this.backToLoginButton.Location = new System.Drawing.Point(511, 649);
            this.backToLoginButton.Name = "backToLoginButton";
            this.backToLoginButton.Size = new System.Drawing.Size(337, 45);
            this.backToLoginButton.TabIndex = 12;
            this.backToLoginButton.Text = "Back to Login Page";
            this.backToLoginButton.UseVisualStyleBackColor = false;
            this.backToLoginButton.Click += new System.EventHandler(this.backToLoginButton_Click);
            // 
            // signupButton
            // 
            this.signupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.signupButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupButton.ForeColor = System.Drawing.Color.Beige;
            this.signupButton.Location = new System.Drawing.Point(511, 556);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(337, 67);
            this.signupButton.TabIndex = 11;
            this.signupButton.Text = "Signup";
            this.signupButton.UseVisualStyleBackColor = false;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // passwordSignupLabel
            // 
            this.passwordSignupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordSignupLabel.ForeColor = System.Drawing.Color.Beige;
            this.passwordSignupLabel.Location = new System.Drawing.Point(505, 431);
            this.passwordSignupLabel.Name = "passwordSignupLabel";
            this.passwordSignupLabel.Size = new System.Drawing.Size(343, 33);
            this.passwordSignupLabel.TabIndex = 10;
            this.passwordSignupLabel.Text = "Password";
            this.passwordSignupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // passwordSignupTextBox
            // 
            this.passwordSignupTextBox.BackColor = System.Drawing.Color.Beige;
            this.passwordSignupTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordSignupTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.passwordSignupTextBox.Location = new System.Drawing.Point(511, 479);
            this.passwordSignupTextBox.MaxLength = 20;
            this.passwordSignupTextBox.Multiline = true;
            this.passwordSignupTextBox.Name = "passwordSignupTextBox";
            this.passwordSignupTextBox.Size = new System.Drawing.Size(337, 34);
            this.passwordSignupTextBox.TabIndex = 9;
            // 
            // usernameSignupLabel
            // 
            this.usernameSignupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameSignupLabel.ForeColor = System.Drawing.Color.Beige;
            this.usernameSignupLabel.Location = new System.Drawing.Point(505, 303);
            this.usernameSignupLabel.Name = "usernameSignupLabel";
            this.usernameSignupLabel.Size = new System.Drawing.Size(343, 33);
            this.usernameSignupLabel.TabIndex = 8;
            this.usernameSignupLabel.Text = "Username";
            this.usernameSignupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // usernameSignupTextBox
            // 
            this.usernameSignupTextBox.BackColor = System.Drawing.Color.Beige;
            this.usernameSignupTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameSignupTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.usernameSignupTextBox.Location = new System.Drawing.Point(511, 351);
            this.usernameSignupTextBox.MaxLength = 20;
            this.usernameSignupTextBox.Multiline = true;
            this.usernameSignupTextBox.Name = "usernameSignupTextBox";
            this.usernameSignupTextBox.Size = new System.Drawing.Size(337, 34);
            this.usernameSignupTextBox.TabIndex = 7;
            // 
            // fullnameSignupLabel
            // 
            this.fullnameSignupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameSignupLabel.ForeColor = System.Drawing.Color.Beige;
            this.fullnameSignupLabel.Location = new System.Drawing.Point(505, 181);
            this.fullnameSignupLabel.Name = "fullnameSignupLabel";
            this.fullnameSignupLabel.Size = new System.Drawing.Size(343, 33);
            this.fullnameSignupLabel.TabIndex = 6;
            this.fullnameSignupLabel.Text = "Full name";
            this.fullnameSignupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fullnameSignupTextBox
            // 
            this.fullnameSignupTextBox.BackColor = System.Drawing.Color.Beige;
            this.fullnameSignupTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameSignupTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.fullnameSignupTextBox.Location = new System.Drawing.Point(511, 229);
            this.fullnameSignupTextBox.MaxLength = 20;
            this.fullnameSignupTextBox.Multiline = true;
            this.fullnameSignupTextBox.Name = "fullnameSignupTextBox";
            this.fullnameSignupTextBox.Size = new System.Drawing.Size(337, 34);
            this.fullnameSignupTextBox.TabIndex = 5;
            // 
            // signupPageLabel
            // 
            this.signupPageLabel.AutoSize = true;
            this.signupPageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupPageLabel.ForeColor = System.Drawing.Color.Beige;
            this.signupPageLabel.Location = new System.Drawing.Point(477, 51);
            this.signupPageLabel.Name = "signupPageLabel";
            this.signupPageLabel.Size = new System.Drawing.Size(401, 73);
            this.signupPageLabel.TabIndex = 1;
            this.signupPageLabel.Text = "Signup Page";
            this.signupPageLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // shopPage
            // 
            this.shopPage.BackColor = System.Drawing.Color.DarkSlateGray;
            this.shopPage.Controls.Add(this.flowLayoutPanel1);
            this.shopPage.Location = new System.Drawing.Point(4, 22);
            this.shopPage.Name = "shopPage";
            this.shopPage.Padding = new System.Windows.Forms.Padding(3);
            this.shopPage.Size = new System.Drawing.Size(1525, 725);
            this.shopPage.TabIndex = 2;
            this.shopPage.Text = "shopPage";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 106);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1513, 659);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // categoriesPage
            // 
            this.categoriesPage.BackColor = System.Drawing.Color.DarkSlateGray;
            this.categoriesPage.Location = new System.Drawing.Point(4, 22);
            this.categoriesPage.Name = "categoriesPage";
            this.categoriesPage.Padding = new System.Windows.Forms.Padding(3);
            this.categoriesPage.Size = new System.Drawing.Size(1525, 725);
            this.categoriesPage.TabIndex = 3;
            this.categoriesPage.Text = "categoriesPage";
            // 
            // cartPage
            // 
            this.cartPage.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cartPage.Controls.Add(this.totalPriceNumberLabel);
            this.cartPage.Controls.Add(this.totalItemsNumberLabel);
            this.cartPage.Controls.Add(this.totalPriceLabel);
            this.cartPage.Controls.Add(this.totalItemsLabel);
            this.cartPage.Controls.Add(this.flowLayoutPanel2);
            this.cartPage.Controls.Add(this.shoppingCartLabel);
            this.cartPage.Location = new System.Drawing.Point(4, 22);
            this.cartPage.Name = "cartPage";
            this.cartPage.Padding = new System.Windows.Forms.Padding(3);
            this.cartPage.Size = new System.Drawing.Size(1525, 725);
            this.cartPage.TabIndex = 4;
            this.cartPage.Text = "cartPage";
            // 
            // ordersPage
            // 
            this.ordersPage.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ordersPage.Location = new System.Drawing.Point(4, 22);
            this.ordersPage.Name = "ordersPage";
            this.ordersPage.Padding = new System.Windows.Forms.Padding(3);
            this.ordersPage.Size = new System.Drawing.Size(1525, 725);
            this.ordersPage.TabIndex = 5;
            this.ordersPage.Text = "ordersPage";
            // 
            // productPage
            // 
            this.productPage.BackColor = System.Drawing.Color.DarkSlateGray;
            this.productPage.Controls.Add(this.backProductButton);
            this.productPage.Controls.Add(this.productDescriptionLabel);
            this.productPage.Controls.Add(this.productPriceLabel);
            this.productPage.Controls.Add(this.productNameLabel);
            this.productPage.Controls.Add(this.productPicture);
            this.productPage.Location = new System.Drawing.Point(4, 22);
            this.productPage.Name = "productPage";
            this.productPage.Padding = new System.Windows.Forms.Padding(3);
            this.productPage.Size = new System.Drawing.Size(1525, 725);
            this.productPage.TabIndex = 6;
            this.productPage.Text = "productPage";
            // 
            // backProductButton
            // 
            this.backProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.backProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backProductButton.ForeColor = System.Drawing.Color.Beige;
            this.backProductButton.Location = new System.Drawing.Point(38, 629);
            this.backProductButton.Name = "backProductButton";
            this.backProductButton.Size = new System.Drawing.Size(158, 68);
            this.backProductButton.TabIndex = 4;
            this.backProductButton.Text = "Back";
            this.backProductButton.UseVisualStyleBackColor = false;
            this.backProductButton.Click += new System.EventHandler(this.backProductButton_Click);
            // 
            // productDescriptionLabel
            // 
            this.productDescriptionLabel.AutoSize = true;
            this.productDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDescriptionLabel.ForeColor = System.Drawing.Color.Beige;
            this.productDescriptionLabel.Location = new System.Drawing.Point(665, 508);
            this.productDescriptionLabel.Name = "productDescriptionLabel";
            this.productDescriptionLabel.Size = new System.Drawing.Size(99, 33);
            this.productDescriptionLabel.TabIndex = 3;
            this.productDescriptionLabel.Text = "label1";
            this.productDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPriceLabel.ForeColor = System.Drawing.Color.Beige;
            this.productPriceLabel.Location = new System.Drawing.Point(665, 419);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(99, 33);
            this.productPriceLabel.TabIndex = 2;
            this.productPriceLabel.Text = "label1";
            this.productPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.ForeColor = System.Drawing.Color.Beige;
            this.productNameLabel.Location = new System.Drawing.Point(665, 359);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(99, 33);
            this.productNameLabel.TabIndex = 1;
            this.productNameLabel.Text = "label1";
            this.productNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productPicture
            // 
            this.productPicture.BackColor = System.Drawing.Color.WhiteSmoke;
            this.productPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productPicture.Location = new System.Drawing.Point(498, 41);
            this.productPicture.Name = "productPicture";
            this.productPicture.Size = new System.Drawing.Size(475, 280);
            this.productPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productPicture.TabIndex = 0;
            this.productPicture.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shopToolStripMenuItem,
            this.categoriesToolStripMenuItem,
            this.shoppingCartToolStripMenuItem,
            this.yourAccountToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1517, 45);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // shopToolStripMenuItem
            // 
            this.shopToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopToolStripMenuItem.ForeColor = System.Drawing.Color.Beige;
            this.shopToolStripMenuItem.Name = "shopToolStripMenuItem";
            this.shopToolStripMenuItem.Size = new System.Drawing.Size(90, 41);
            this.shopToolStripMenuItem.Text = "Shop";
            this.shopToolStripMenuItem.Click += new System.EventHandler(this.shopToolStripMenuItem_Click);
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesToolStripMenuItem.ForeColor = System.Drawing.Color.Beige;
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(156, 41);
            this.categoriesToolStripMenuItem.Text = "Categories";
            this.categoriesToolStripMenuItem.Click += new System.EventHandler(this.categoriesToolStripMenuItem_Click);
            // 
            // shoppingCartToolStripMenuItem
            // 
            this.shoppingCartToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartToolStripMenuItem.ForeColor = System.Drawing.Color.Beige;
            this.shoppingCartToolStripMenuItem.Name = "shoppingCartToolStripMenuItem";
            this.shoppingCartToolStripMenuItem.Size = new System.Drawing.Size(200, 41);
            this.shoppingCartToolStripMenuItem.Text = "Shopping Cart";
            this.shoppingCartToolStripMenuItem.Click += new System.EventHandler(this.shoppingCartToolStripMenuItem_Click);
            // 
            // yourAccountToolStripMenuItem
            // 
            this.yourAccountToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourAccountToolStripMenuItem.ForeColor = System.Drawing.Color.Beige;
            this.yourAccountToolStripMenuItem.Name = "yourAccountToolStripMenuItem";
            this.yourAccountToolStripMenuItem.Size = new System.Drawing.Size(164, 41);
            this.yourAccountToolStripMenuItem.Text = "Your orders";
            this.yourAccountToolStripMenuItem.Click += new System.EventHandler(this.yourAccountToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.Beige;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(114, 41);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // shoppingCartLabel
            // 
            this.shoppingCartLabel.AutoSize = true;
            this.shoppingCartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartLabel.ForeColor = System.Drawing.Color.Beige;
            this.shoppingCartLabel.Location = new System.Drawing.Point(469, 12);
            this.shoppingCartLabel.Name = "shoppingCartLabel";
            this.shoppingCartLabel.Size = new System.Drawing.Size(443, 73);
            this.shoppingCartLabel.TabIndex = 1;
            this.shoppingCartLabel.Text = "Shopping Cart";
            this.shoppingCartLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(102, 174);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(611, 436);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // totalItemsLabel
            // 
            this.totalItemsLabel.AutoSize = true;
            this.totalItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalItemsLabel.ForeColor = System.Drawing.Color.Beige;
            this.totalItemsLabel.Location = new System.Drawing.Point(1085, 174);
            this.totalItemsLabel.Name = "totalItemsLabel";
            this.totalItemsLabel.Size = new System.Drawing.Size(171, 33);
            this.totalItemsLabel.TabIndex = 3;
            this.totalItemsLabel.Text = "Total Items";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.ForeColor = System.Drawing.Color.Beige;
            this.totalPriceLabel.Location = new System.Drawing.Point(1085, 237);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(166, 33);
            this.totalPriceLabel.TabIndex = 4;
            this.totalPriceLabel.Text = "Total Price";
            // 
            // totalItemsNumberLabel
            // 
            this.totalItemsNumberLabel.AutoSize = true;
            this.totalItemsNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalItemsNumberLabel.ForeColor = System.Drawing.Color.Beige;
            this.totalItemsNumberLabel.Location = new System.Drawing.Point(1293, 174);
            this.totalItemsNumberLabel.Name = "totalItemsNumberLabel";
            this.totalItemsNumberLabel.Size = new System.Drawing.Size(32, 33);
            this.totalItemsNumberLabel.TabIndex = 5;
            this.totalItemsNumberLabel.Text = "0";
            // 
            // totalPriceNumberLabel
            // 
            this.totalPriceNumberLabel.AutoSize = true;
            this.totalPriceNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceNumberLabel.ForeColor = System.Drawing.Color.Beige;
            this.totalPriceNumberLabel.Location = new System.Drawing.Point(1293, 237);
            this.totalPriceNumberLabel.Name = "totalPriceNumberLabel";
            this.totalPriceNumberLabel.Size = new System.Drawing.Size(101, 33);
            this.totalPriceNumberLabel.TabIndex = 6;
            this.totalPriceNumberLabel.Text = "0.00 $";
            // 
            // hunting_equipment_storeDataSet
            // 
            this.hunting_equipment_storeDataSet.DataSetName = "hunting_equipment_storeDataSet";
            this.hunting_equipment_storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.hunting_equipment_storeDataSet;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataSource = this.hunting_equipment_storeDataSet;
            this.categoriesBindingSource.Position = 0;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = this.categoriesTableAdapter;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.ReviewsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = huntingEquipmentStore.hunting_equipment_storeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = this.hunting_equipment_storeDataSet;
            this.productsBindingSource.Position = 0;
            // 
            // categoriesBindingSource1
            // 
            this.categoriesBindingSource1.DataSource = this.hunting_equipment_storeDataSet;
            this.categoriesBindingSource1.Position = 0;
            // 
            // categoriesBindingSource2
            // 
            this.categoriesBindingSource2.DataSource = this.hunting_equipment_storeDataSet;
            this.categoriesBindingSource2.Position = 0;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataSource = this.hunting_equipment_storeDataSet;
            this.ordersBindingSource.Position = 0;
            // 
            // reviewsBindingSource
            // 
            this.reviewsBindingSource.DataMember = "Reviews";
            this.reviewsBindingSource.DataSource = this.hunting_equipment_storeDataSet;
            // 
            // reviewsTableAdapter
            // 
            this.reviewsTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesBindingSource3
            // 
            this.categoriesBindingSource3.DataMember = "Categories";
            this.categoriesBindingSource3.DataSource = this.hunting_equipment_storeDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 797);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Hunting Equipment Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.loginPage.ResumeLayout(false);
            this.loginPage.PerformLayout();
            this.signupPage.ResumeLayout(false);
            this.signupPage.PerformLayout();
            this.shopPage.ResumeLayout(false);
            this.cartPage.ResumeLayout(false);
            this.cartPage.PerformLayout();
            this.productPage.ResumeLayout(false);
            this.productPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hunting_equipment_storeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private hunting_equipment_storeDataSet hunting_equipment_storeDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private hunting_equipment_storeDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private hunting_equipment_storeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private hunting_equipment_storeDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private hunting_equipment_storeDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private hunting_equipment_storeDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource categoriesBindingSource1;
        private System.Windows.Forms.BindingSource categoriesBindingSource2;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.BindingSource reviewsBindingSource;
        private hunting_equipment_storeDataSetTableAdapters.ReviewsTableAdapter reviewsTableAdapter;
        private System.Windows.Forms.BindingSource categoriesBindingSource3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage loginPage;
        private System.Windows.Forms.TabPage signupPage;
        private System.Windows.Forms.Label loginPageLabel;
        private System.Windows.Forms.Label passwordLoginLabel;
        private System.Windows.Forms.TextBox passwordLoginTextBox;
        private System.Windows.Forms.Label usernameLoginLabel;
        private System.Windows.Forms.TextBox usernameLoginTextBox;
        private System.Windows.Forms.Label createAccountLabel;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label signupPageLabel;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.Label passwordSignupLabel;
        private System.Windows.Forms.TextBox passwordSignupTextBox;
        private System.Windows.Forms.Label usernameSignupLabel;
        private System.Windows.Forms.TextBox usernameSignupTextBox;
        private System.Windows.Forms.Label fullnameSignupLabel;
        private System.Windows.Forms.TextBox fullnameSignupTextBox;
        private System.Windows.Forms.Button backToLoginButton;
        private System.Windows.Forms.TabPage shopPage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabPage categoriesPage;
        private System.Windows.Forms.TabPage cartPage;
        private System.Windows.Forms.TabPage ordersPage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shoppingCartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yourAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.TabPage productPage;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.PictureBox productPicture;
        private System.Windows.Forms.Label productPriceLabel;
        private System.Windows.Forms.Label productDescriptionLabel;
        private System.Windows.Forms.Button backProductButton;
        private System.Windows.Forms.Label shoppingCartLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label totalItemsLabel;
        private System.Windows.Forms.Label totalPriceNumberLabel;
        private System.Windows.Forms.Label totalItemsNumberLabel;
        private System.Windows.Forms.Label totalPriceLabel;

    }
}

