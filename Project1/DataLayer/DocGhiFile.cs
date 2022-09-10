using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginScreen.DataLayer
{
   public class DocGhiFile
    {
       
       string path;
       public DocGhiFile(string path)
       {
           this.path = path; 
       }
        // doc file
       public List<User> DocUser()
       { 
           List<User> users=null;
           using(FileStream fileStream=new FileStream(path,FileMode.Open,FileAccess.Read, FileShare.Read))
           {
               using(StreamReader streamReader=new StreamReader(fileStream))
               {
                   string line= string.Empty;
                   User user;
                   users = new List<User>();
                   while ((line=streamReader.ReadLine())!=null)
                   {
                       user=new User();
                       string[] mang=line.Split(',');
                       user.ID=Convert.ToInt32(mang[0]);
                       user.Taikhoan=mang[1];
                       user.MatKhau=mang[2];
                       user.HovaTen=mang[3];
                       user.NhoMatKhau= Convert.ToBoolean(mang[4]);
                       users.Add(user);
                   }
               }
           }
           return users;
       }
       
       // ghi file
    }
}
