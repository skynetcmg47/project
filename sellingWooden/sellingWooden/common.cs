using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sellingWooden
{
    class Common
    {
        SQLHelp help = new SQLHelp();
        public string initID(string table,string ID,string st)
        {
            string s, snew;
            int i = 0;
            System.Data.DataTable billIDtable;
            billIDtable = help.getDataTable_excute("select top 1 "+ID+" from "+table+" order by "+ID+" desc");
            s = billIDtable.Rows[0][0].ToString();
            snew = s.Substring(2, 4).ToString();
            i = int.Parse(snew);
            i++;
            if (i < 10)
                return st.ToString() + "000" + i.ToString();
            else if (i >= 10 && i < 100)
                return st.ToString() + "00" + i.ToString();
            else if (i >= 100 && i < 1000)
                return st.ToString() + "0" + i.ToString();
            else
                return st.ToString() + i.ToString();
        }
    }
}
