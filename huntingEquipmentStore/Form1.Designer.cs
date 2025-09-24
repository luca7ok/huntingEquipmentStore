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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.loginPage = new System.Windows.Forms.TabPage();
            this.passwordLoginLabel = new System.Windows.Forms.Label();
            this.passwordLoginTextBox = new System.Windows.Forms.TextBox();
            this.usernameLoginLabel = new System.Windows.Forms.Label();
            this.usernameLoginTextBox = new System.Windows.Forms.TextBox();
            this.loginPageLabel = new System.Windows.Forms.Label();
            this.signupPage = new System.Windows.Forms.TabPage();
            this.loginButton = new System.Windows.Forms.Button();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.createAccountLabel = new System.Windows.Forms.Label();
            this.signupPageLabel = new System.Windows.Forms.Label();
            this.usernameSignupLabel = new System.Windows.Forms.Label();
            this.usernameSignupTextBox = new System.Windows.Forms.TextBox();
            this.fullnameSignupLabel = new System.Windows.Forms.Label();
            this.fullnameSignupTextBox = new System.Windows.Forms.TextBox();
            this.passwordSignupLabel = new System.Windows.Forms.Label();
            this.passwordSignupTextBox = new System.Windows.Forms.TextBox();
            this.signupButton = new System.Windows.Forms.Button();
            this.backToLoginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hunting_equipment_storeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource3)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.loginPage.SuspendLayout();
            this.signupPage.SuspendLayout();
            this.SuspendLayout();
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
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.loginPage);
            this.tabControl1.Controls.Add(this.signupPage);
            this.tabControl1.Location = new System.Drawing.Point(-11, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1533, 798);
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
            this.loginPage.Size = new System.Drawing.Size(1525, 772);
            this.loginPage.TabIndex = 0;
            this.loginPage.Text = "loginPage";
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
            this.signupPage.Size = new System.Drawing.Size(1525, 772);
            this.signupPage.TabIndex = 1;
            this.signupPage.Text = "signupPage";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 797);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Hunting Equipment Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hunting_equipment_storeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource3)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.loginPage.ResumeLayout(false);
            this.loginPage.PerformLayout();
            this.signupPage.ResumeLayout(false);
            this.signupPage.PerformLayout();
            this.ResumeLayout(false);

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

    }
}

