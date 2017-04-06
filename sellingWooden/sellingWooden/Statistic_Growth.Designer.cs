namespace sellingWooden
{
    partial class Statistic_Growth
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_Statistic_type = new System.Windows.Forms.ComboBox();
            this.cbo_Statistic_typedate = new System.Windows.Forms.ComboBox();
            this.lbChooseTime = new System.Windows.Forms.Label();
            this.btn_Statistic = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Product_List = new System.Windows.Forms.ListBox();
            this.pannel_nd = new System.Windows.Forms.Panel();
            this.statistic_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbo_chooseTime = new System.Windows.Forms.ComboBox();
            this.btn_Report = new System.Windows.Forms.Button();
            this.pannel_nd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statistic_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mục cần xem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Xem theo";
            // 
            // cbo_Statistic_type
            // 
            this.cbo_Statistic_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Statistic_type.FormattingEnabled = true;
            this.cbo_Statistic_type.Items.AddRange(new object[] {
            "Doanh số bán hàng theo thời gian",
            "Doanh số bán hàng theo sản phẩm",
            "Doanh số từng sản phẩm"});
            this.cbo_Statistic_type.Location = new System.Drawing.Point(127, 12);
            this.cbo_Statistic_type.Name = "cbo_Statistic_type";
            this.cbo_Statistic_type.Size = new System.Drawing.Size(156, 24);
            this.cbo_Statistic_type.TabIndex = 9;
            this.cbo_Statistic_type.SelectedIndexChanged += new System.EventHandler(this.cbo_Statistic_type_SelectedIndexChanged);
            // 
            // cbo_Statistic_typedate
            // 
            this.cbo_Statistic_typedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Statistic_typedate.FormattingEnabled = true;
            this.cbo_Statistic_typedate.Items.AddRange(new object[] {
            "Ngày",
            "Tháng",
            "Năm"});
            this.cbo_Statistic_typedate.Location = new System.Drawing.Point(127, 47);
            this.cbo_Statistic_typedate.Name = "cbo_Statistic_typedate";
            this.cbo_Statistic_typedate.Size = new System.Drawing.Size(156, 24);
            this.cbo_Statistic_typedate.TabIndex = 11;
            this.cbo_Statistic_typedate.SelectedIndexChanged += new System.EventHandler(this.cbo_Statistic_typedate_SelectedIndexChanged);
            // 
            // lbChooseTime
            // 
            this.lbChooseTime.AutoSize = true;
            this.lbChooseTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChooseTime.Location = new System.Drawing.Point(336, 15);
            this.lbChooseTime.Name = "lbChooseTime";
            this.lbChooseTime.Size = new System.Drawing.Size(30, 16);
            this.lbChooseTime.TabIndex = 26;
            this.lbChooseTime.Text = "Từ:";
            // 
            // btn_Statistic
            // 
            this.btn_Statistic.Location = new System.Drawing.Point(583, 12);
            this.btn_Statistic.Name = "btn_Statistic";
            this.btn_Statistic.Size = new System.Drawing.Size(75, 23);
            this.btn_Statistic.TabIndex = 34;
            this.btn_Statistic.Text = "Thống kê";
            this.btn_Statistic.UseVisualStyleBackColor = true;
            this.btn_Statistic.Click += new System.EventHandler(this.btn_Statistic_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Chọn sản phẩm:";
            // 
            // txt_Product_List
            // 
            this.txt_Product_List.FormattingEnabled = true;
            this.txt_Product_List.Location = new System.Drawing.Point(27, 125);
            this.txt_Product_List.Name = "txt_Product_List";
            this.txt_Product_List.Size = new System.Drawing.Size(155, 316);
            this.txt_Product_List.TabIndex = 36;
            // 
            // pannel_nd
            // 
            this.pannel_nd.Controls.Add(this.statistic_chart);
            this.pannel_nd.Location = new System.Drawing.Point(244, 100);
            this.pannel_nd.Name = "pannel_nd";
            this.pannel_nd.Size = new System.Drawing.Size(600, 323);
            this.pannel_nd.TabIndex = 37;
            // 
            // statistic_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.statistic_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.statistic_chart.Legends.Add(legend1);
            this.statistic_chart.Location = new System.Drawing.Point(0, 0);
            this.statistic_chart.Name = "statistic_chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.statistic_chart.Series.Add(series1);
            this.statistic_chart.Size = new System.Drawing.Size(600, 323);
            this.statistic_chart.TabIndex = 0;
            this.statistic_chart.Text = "statistic_chart";
            // 
            // cbo_chooseTime
            // 
            this.cbo_chooseTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_chooseTime.FormattingEnabled = true;
            this.cbo_chooseTime.Location = new System.Drawing.Point(386, 15);
            this.cbo_chooseTime.Name = "cbo_chooseTime";
            this.cbo_chooseTime.Size = new System.Drawing.Size(116, 24);
            this.cbo_chooseTime.TabIndex = 25;
            // 
            // btn_Report
            // 
            this.btn_Report.Location = new System.Drawing.Point(717, 12);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(75, 23);
            this.btn_Report.TabIndex = 38;
            this.btn_Report.Text = "Báo Cáo";
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // Statistic_Growth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 435);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.pannel_nd);
            this.Controls.Add(this.txt_Product_List);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Statistic);
            this.Controls.Add(this.lbChooseTime);
            this.Controls.Add(this.cbo_chooseTime);
            this.Controls.Add(this.cbo_Statistic_typedate);
            this.Controls.Add(this.cbo_Statistic_type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Statistic_Growth";
            this.Text = "Statistic_Growth";
            this.pannel_nd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statistic_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_Statistic_type;
        private System.Windows.Forms.ComboBox cbo_Statistic_typedate;
        private System.Windows.Forms.Label lbChooseTime;
        private System.Windows.Forms.Button btn_Statistic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox txt_Product_List;
        private System.Windows.Forms.Panel pannel_nd;
        private System.Windows.Forms.ComboBox cbo_chooseTime;
        private System.Windows.Forms.DataVisualization.Charting.Chart statistic_chart;
        private System.Windows.Forms.Button btn_Report;
    }
}