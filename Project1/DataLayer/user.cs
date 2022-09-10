using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginScreen.DataLayer
{
    public class User
    {
            //field
        private int iD;
        private string matkhau;
        private string hovaten;
        private bool nhoMatkhau;
        //Properties
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        public string Taikhoan { get; set; }
        public string MatKhau { get; set; }
        public string HovaTen { get; set; }
        public bool NhoMatKhau { get; set; }
    }

}
