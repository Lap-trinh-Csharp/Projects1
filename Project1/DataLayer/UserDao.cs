using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginScreen.DataLayer
{
    public class UserDao
    {
        private List<User> listUser;

        public List<User> ListUser { 
            get { return listUser; } 
            set { listUser = value; } 
        }
        DocGhiFile Docghi;
        public UserDao()
        {
            listUser=new List<User>()
            {
                new User()
                {ID=1,Taikhoan="admin",MatKhau="admin",HovaTen="nhathuynh",NhoMatKhau=false},
                new User()
                {ID=2,Taikhoan="admin",MatKhau="123456",HovaTen="khang",NhoMatKhau=false}
            };
        }

        public UserDao(string path)
        {
            listUser = new List<User>();
            Docghi = new DocGhiFile(path);
            listUser = Docghi.DocUser();
        }





        //Thuc hien cac phuong thuc
        //them

        //sua

        //xoa

    }
}
