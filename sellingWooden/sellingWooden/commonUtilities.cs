﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sellingWooden
{
    class commonUtilities
    {
        public static string userName;
        public static string pass;
        public static string authorities;

        public void setAuthorities(string values)
        {
            authorities = values;
        }
        public string getAuthorities()
        {
            return authorities;
        }
        public void setUserName(string values)
        {
            userName = values;
        }
        public string getUserName()
        {
            return userName;
        }
        public void setPass(string values)
        {
            pass = values;
        }
        public string getPass()
        {
            return pass;
        }
    }

}
