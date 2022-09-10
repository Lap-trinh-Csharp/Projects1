using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginScreen.DataLayer;

namespace LoginScreen.BusinessLayer
{
    public class BLLUser
    {
        UserDao userDao;
        
        public BLLUser()
        {
            userDao = new UserDao();

        }

        public BLLUser(string path)
        {
            // TODO: Complete member initialization
            userDao=new UserDao(path);
        }
        public bool KiemTraTaiKhoan(string taikhoan, string matkhau)
        {
            foreach ( User item in userDao.ListUser)
            {
                if (item.Taikhoan.Equals(taikhoan)
                    && item.MatKhau.Equals(matkhau))
                    return true;    
            }
            return false;
        }

    }
}
