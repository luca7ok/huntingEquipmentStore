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
            this.signupPage = new System.Windows.Forms.TabPage();
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
            this.tabControl1.Controls.Add(this.loginPage);
            this.tabControl1.Controls.Add(this.signupPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1490, 796);
            this.tabControl1.TabIndex = 0;
            // 
            // loginPage
            // 
            this.loginPage.Location = new System.Drawing.Point(4, 22);
            this.loginPage.Name = "loginPage";
            this.loginPage.Padding = new System.Windows.Forms.Padding(3);
            this.loginPage.Size = new System.Drawing.Size(1482, 614);
            this.loginPage.TabIndex = 0;
            this.loginPage.Text = "loginPage";
            this.loginPage.UseVisualStyleBackColor = true;
            // 
            // signupPage
            // 
            this.signupPage.Location = new System.Drawing.Point(4, 22);
            this.signupPage.Name = "signupPage";
            this.signupPage.Padding = new System.Windows.Forms.Padding(3);
            this.signupPage.Size = new System.Drawing.Size(1482, 770);
            this.signupPage.TabIndex = 1;
            this.signupPage.Text = "signupPage";
            this.signupPage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 797);
            this.Controls.Add(this.tabControl1);
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

    }
}

