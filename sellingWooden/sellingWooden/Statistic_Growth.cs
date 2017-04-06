using System;
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
    public partial class Statistic_Growth : Form
    {
        SQLHelp help = new SQLHelp();
        public Statistic_Growth()
        {
            InitializeComponent();
        }

        private void cbo_Statistic_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbo_Statistic_type.Text =="Doanh số bán hàng theo sản phẩm")
            {
                cbo_Statistic_typedate.Items.Clear();
                cbo_Statistic_typedate.Items.Add("Ngày");
                cbo_Statistic_typedate.Items.Add("Tháng");
                cbo_Statistic_typedate.Items.Add("Năm");
                txt_Product_List.Enabled = false;

            }
            else if(cbo_Statistic_type.Text == "Doanh số bán hàng theo thời gian")
            {
                cbo_Statistic_typedate.Items.Clear();
                cbo_Statistic_typedate.Items.Add("Tháng");
                cbo_Statistic_typedate.Items.Add("Năm");
                txt_Product_List.Enabled = false;
            }
            else if (cbo_Statistic_type.Text == "Doanh số từng sản phẩm")
            {
                cbo_Statistic_typedate.Items.Clear();
                cbo_Statistic_typedate.Items.Add("Tháng");
                cbo_Statistic_typedate.Items.Add("Năm");
                txt_Product_List.Enabled = true;
                load_ProductList();

            }
        }

        private void cbo_Statistic_typedate_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_chooseTime.Items.Clear();

            if (cbo_Statistic_typedate.Text == "Tháng")
            {
                lbChooseTime.Text = "Tháng";
                DataTable tb = help.getDataTable_excute("SELECT * FROM v_sellDate");
                for(int i=0;i<tb.Rows.Count;i++)
                {
                    string iteam = tb.Rows[i][0].ToString();
                    cbo_chooseTime.Items.Add(iteam);
                }
            }
            else if(cbo_Statistic_typedate.Text == "Năm")
            {
                cbo_chooseTime.Items.Clear();
                lbChooseTime.Text = "Năm";
                DataTable tb = help.getDataTable_excute("SELECT * FROM v_sellDate_year");
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    string iteam = tb.Rows[i][0].ToString();
                    cbo_chooseTime.Items.Add(iteam);
                }
            }
            else if(cbo_Statistic_typedate.Text == "Ngày")
            {
                cbo_chooseTime.Items.Clear();
                lbChooseTime.Text = "Ngày";
                DataTable tb = help.getDataTable_excute("SELECT * FROM v_sellDate_date");
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    string iteam = tb.Rows[i][0].ToString();
                    cbo_chooseTime.Items.Add(iteam);
                }
            }
             
        }

        private void load_ProductList()
        {
            string sql = "select Product.ProductID,ProductName,sum(BillDetail.Amount) as SL from Product,BillDetail where Product.ProductID=BillDetail.ProductID group by Product.ProductID,ProductName order by SL desc";
            txt_Product_List.DisplayMember = "ProductName";
            txt_Product_List.ValueMember = "ProductID";
            txt_Product_List.DataSource = help.getDataTable_excute(sql);
        }

        private void btn_Statistic_Click(object sender, EventArgs e)
        {
            if (cbo_Statistic_type.Text == "Doanh số bán hàng theo sản phẩm")
            {
                if (cbo_Statistic_typedate.Text == "Tháng")
                {
                    DataTable tb = help.getDataTable_excute("select Product.ProductName,SUM(BillDetail.Amount) as SellAmount from Product join BillDetail on Product.ProductID = BillDetail.ProductID join Bill on BillDetail.BillID = Bill.BillID where MONTH(Bill.sellDate) = " + cbo_chooseTime.Text + " and Year(Bill.sellDate) = Year(GETDATE()) group by ProductName");
                    statistic_chart.DataSource = tb;

                }
                else if (cbo_Statistic_typedate.Text == "Năm")
                {
                    DataTable tb = help.getDataTable_excute("select Product.ProductName,SUM(BillDetail.Amount) as SellAmount from Product join BillDetail on Product.ProductID = BillDetail.ProductID join Bill on BillDetail.BillID = Bill.BillID where YEAR(Bill.sellDate) = " + cbo_chooseTime.Text + " group by ProductName");
                    statistic_chart.DataSource = tb;

                }
                else
                {
                    DataTable tb = help.getDataTable_excute("select Product.ProductName,SUM(BillDetail.Amount) as SellAmount from Product join BillDetail on Product.ProductID = BillDetail.ProductID join Bill on BillDetail.BillID = Bill.BillID where Bill.sellDate = '" + cbo_chooseTime.Text + "' group by ProductName");
                    statistic_chart.DataSource = tb;
                }
                statistic_chart.ChartAreas["ChartArea1"].AxisX.Title = "Sản Phẩm";
                statistic_chart.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng";
                statistic_chart.Series["Series1"].XValueMember = "ProductName";
                statistic_chart.Series["Series1"].YValueMembers = "SellAmount";
            }
            else if (cbo_Statistic_type.Text == "Doanh số bán hàng theo thời gian")
            {
                if(cbo_Statistic_typedate.Text=="Năm")
                {
                    DataTable tb = help.getDataTable_excute("select Month(Bill.SellDate) as sellMonth ,SUM(BillDetail.Amount) as sellAmount from Product join BillDetail on Product.ProductID = BillDetail.ProductID join Bill on BillDetail.BillID = Bill.BillID where YEAR(Bill.sellDate) = " + cbo_chooseTime.Text + " group by Month(Bill.SellDate)");
                    statistic_chart.DataSource = tb;
                    statistic_chart.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
                    statistic_chart.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng";
                    statistic_chart.Series["Series1"].XValueMember = "sellMonth";
                    statistic_chart.Series["Series1"].YValueMembers = "sellAmount";
                }
                else if(cbo_Statistic_typedate.Text == "Tháng")
                {
                    DataTable tb = help.getDataTable_excute("select DAY(Bill.SellDate) as sellDay ,SUM(BillDetail.Amount) as sellAmount from Product join BillDetail on Product.ProductID = BillDetail.ProductID join Bill on BillDetail.BillID = Bill.BillID where MONTH(Bill.sellDate) = " + cbo_chooseTime.Text + " group by Bill.SellDate");
                    statistic_chart.DataSource = tb;
                    statistic_chart.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
                    statistic_chart.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng";
                    statistic_chart.Series["Series1"].XValueMember = "sellDay";
                    statistic_chart.Series["Series1"].YValueMembers = "sellAmount";
                }

            }
            else if(cbo_Statistic_type.Text == "Doanh số từng sản phẩm")
            {
                string id = txt_Product_List.SelectedValue.ToString();
                if (cbo_Statistic_typedate.Text == "Năm")
                {
                    DataTable tb = help.getDataTable_excute("select Month(Bill.SellDate) as sellMonth ,SUM(BillDetail.Amount) as sellAmount from Product join BillDetail on Product.ProductID = BillDetail.ProductID join Bill on BillDetail.BillID = Bill.BillID where YEAR(Bill.sellDate) = " + cbo_chooseTime.Text + " and Product.ProductID='"+id+"' group by Month(Bill.SellDate)");
                    statistic_chart.DataSource = tb;
                    statistic_chart.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
                    statistic_chart.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng";
                    statistic_chart.Series["Series1"].XValueMember = "sellMonth";
                    statistic_chart.Series["Series1"].YValueMembers = "sellAmount";
                }
                else if (cbo_Statistic_typedate.Text == "Tháng")
                {
                    DataTable tb = help.getDataTable_excute("select DAY(Bill.SellDate) as sellDay ,SUM(BillDetail.Amount) as sellAmount from Product join BillDetail on Product.ProductID = BillDetail.ProductID join Bill on BillDetail.BillID = Bill.BillID where MONTH(Bill.sellDate) = " + cbo_chooseTime.Text + " and Product.ProductID='" + id + "' group by Bill.SellDate");
                    statistic_chart.DataSource = tb;
                    statistic_chart.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
                    statistic_chart.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng";
                    statistic_chart.Series["Series1"].XValueMember = "sellDay";
                    statistic_chart.Series["Series1"].YValueMembers = "sellAmount";
                }
            }
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            frmBillReport f = new frmBillReport();
            f.ShowDialog();
        }
    }
}
