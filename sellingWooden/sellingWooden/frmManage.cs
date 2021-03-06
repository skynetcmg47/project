﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sellingWooden
{
    public partial class frmManage : Form
    {
        SQLHelp help = new SQLHelp();
        public frmManage()
        {
            //mainForm_tabControl.Size = this.Size;
            InitializeComponent();
            InitTabProduct();
            InitTabCustomer();
            InitTabType();
            InitTabBill();
            InitTabBillDetail();
            InitTabEmployee();
        }


        private void InitTabProduct()
        {
            Product a = new Product { TopLevel = false, Parent = mainForm_tabControl.TabPages[0], Dock = DockStyle.Fill };
            a.Size = mainForm_tabControl.TabPages[0].Size;
            a.Show();
        }
        private void InitTabCustomer()
        {
            Customer a = new Customer { TopLevel = false, Parent = mainForm_tabControl.TabPages[1], Dock = DockStyle.Fill };
            a.Size = mainForm_tabControl.TabPages[1].Size;
            a.Show();
        }
        private void InitTabType()
        {
            Type a = new Type { TopLevel = false, Parent = mainForm_tabControl.TabPages[2], Dock = DockStyle.Fill };
            a.Size = mainForm_tabControl.TabPages[2].Size;
            a.Show();
        }
        private void InitTabBill()
        {
            Bill a = new Bill { TopLevel = false, Parent = mainForm_tabControl.TabPages[3], Dock = DockStyle.Fill };
            a.Size = mainForm_tabControl.TabPages[3].Size;
            a.Show();
        }
        private void InitTabBillDetail()
        {
            BillDetail a = new BillDetail { TopLevel = false, Parent = mainForm_tabControl.TabPages[4], Dock = DockStyle.Fill };
            a.Size = mainForm_tabControl.TabPages[4].Size;
            a.Show();
        }
        private void InitTabEmployee()
        {
            Employee a = new Employee { TopLevel = false, Parent = mainForm_tabControl.TabPages[5], Dock = DockStyle.Fill };
            a.Size = mainForm_tabControl.TabPages[5].Size;
            a.Show();
        }

        private void frmManage_Load(object sender, EventArgs e)
        {

        }
        public void InitComponent()
        {
            InitTabProduct();
            InitTabCustomer();
            InitTabType();
            InitTabBill();
            InitTabBillDetail();
            InitTabEmployee();
        }
    }


}
