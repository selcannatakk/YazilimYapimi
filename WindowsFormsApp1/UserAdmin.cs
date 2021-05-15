using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class UserAdmin
    {
        
        private string adminUserName;
        private string adminPassword;
        public string AdminPassword {
            get { return adminPassword; }
            set { adminPassword ="0000"; }  
        }
        public string AdminUserName
        {
            get { return adminUserName; }
            set { adminUserName ="demet"; }
        }

    }
}
