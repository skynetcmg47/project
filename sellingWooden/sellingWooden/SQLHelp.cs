using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sellingWooden
{
    class SQLHelp
    {
        public static SqlConnection connection;
        public static SqlCommand cmd;
        public static SqlDataAdapter adapter;

        public SQLHelp()
        {
            this.OpenDatabase();
            this.openConnection();
        }

        public SqlConnection OpenDatabase()
        {
            //open datable

            string connectionDTB = @"Data Source=NAM;Initial Catalog=SellingWooden;Integrated Security=True";
            connection = new SqlConnection(connectionDTB);
            return connection;
        }

        public void openConnection()
        {
            string connectionDTB = @"Data Source=NAM;Initial Catalog=SellingWooden;Integrated Security=True";
            try
            {
                connection = new SqlConnection(connectionDTB);
                connection.Open();
            }
            catch (SqlException Ex)
            {

            }
        }

        public static void Disconnect()
        {
            connection.Close();
            connection.Dispose();
            connection = null;
        }

        public static DataTable getDataTable(string sql)
        {
            //this method return datatable contain your sql query data
            cmd = new SqlCommand(sql, connection);
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            cmd.Dispose();
            return table;
        }
        public DataTable getDataTable_excute(string sql)
        {
            return getDataTable(sql);
        }
        public static void Excute(string sql)
        {
            //run the sql query
            cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
        }

        //show data from database to datagridview
        public void fillInDTGV(DataGridView dtgv, string table)
        {
            dtgv.DataSource = getDataTable("SELECT * FROM dbo." + table);
        }

        public DataTable findInSQL(string sColumnName, string sTable, string sConditionColumn, string sCondition)
        {
            //this method return a table contain data of your query
            DataTable dtTemp = getDataTable("SELECT " + sColumnName + " FROM dbo." + sTable + " WHERE " + sConditionColumn + " = " + "'" + sCondition + "'");
            return dtTemp;
        }

        public void addData(string table, string Data)
        {
            //this method will add your data to table
            /*string sData = "('";
            for(int i=0;i<arrData.Length-1;i++)
            {
                sData+= arrData[i]+"','";
            }
            sData += arrData[arrData.Length - 1] + "')";
            MessageBox.Show(sData);
            */
            //  MessageBox.Show(Data);
            Excute("INSERT INTO dbo." + table + " VALUES (" + Data + ")");

        }

               public void deleteData(string sTableName, string sColumnName, string sValue)
        {
            /*
             this method will delete your data base on your condition
                 DELETE FROM tableName
                WHERE column = value
            */
           // Excute("Delete from Product where ProductID = 'SP001'");

            Excute("DELETE FROM dbo." + sTableName + " WHERE " + sColumnName + " = '" + sValue + "'");
        }
        public DataTable getDataCbb(string table)
        {
            return getDataTable("SELECT  * FROM dbo." + table);
        }

        public bool checkID(string table, string id)
        {
            //ham nay tra ve gia tri true false
            //tra ve true neu id khong co trong table
            //tra ve false neu id da ton tai trong table
            DataTable dt = getDataTable("SELECT " + "*" + " FROM dbo." + table);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString() == id) return false;
            }
            return true;

        }
        public void Excute_query(string sql)
        {
            Excute(sql);
        }
        public bool checkIDBillDetail(string BillID,string ProductID)
        {
            DataTable dt = getDataTable("SELECT BillID,ProductID FROM BillDetail");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString().Equals(BillID) && dt.Rows[i][1].ToString().Equals(ProductID)) return false;
            }
            return true;
        }
    }
}
