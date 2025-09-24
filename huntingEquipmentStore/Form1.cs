using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace huntingEquipmentStore{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
        }
        Size size = new Size(Convert.ToInt32(Screen.PrimaryScreen.Bounds.Width * 0.7), Convert.ToInt32(Screen.PrimaryScreen.Bounds.Height * 0.7));

        private void Form1_Load(object sender, EventArgs e){
            this.categoriesTableAdapter.Fill(this.hunting_equipment_storeDataSet.Categories);
            this.productsTableAdapter.Fill(this.hunting_equipment_storeDataSet.Products);
            this.customersTableAdapter.Fill(this.hunting_equipment_storeDataSet.Customers);
            this.ordersTableAdapter.Fill(this.hunting_equipment_storeDataSet.Orders);
            this.reviewsTableAdapter.Fill(this.hunting_equipment_storeDataSet.Reviews);
            

            this.Size = size;

            tabControl1.Size = size;
            tabControl1.SelectedTab = loginPage;
            
        }

        
    }
}
