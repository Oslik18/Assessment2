using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment2
{
    
    class LoginFile
    {
        string user_type = "";

        List<User> users = new List<User>();
        string[] fields;
        bool res_log, res_add;
        int count;

        public void LoadFile(string filename)
        {
            StreamReader loginFile = new StreamReader(filename);
            while (!loginFile.EndOfStream)
            {
                fields = loginFile.ReadLine().Split(',');
                users.Add(new User(fields[0], fields[1], fields[2], fields[3], fields[4], fields[5]));
            }
            loginFile.Close();
        }

        public bool CheckLogin(string log, string pas)
        {
            LoadFile("login.txt");      
            for (int i=0; i < users.Count; i++)
            {
                if (users[i].username == log)
                {
                    if (users[i].password == pas)
                    {
                        res_log = true;
                        break;
                    }
                    else
                    {
                        res_log = false;
                    }
                }
                else
                {
                    res_log = false;
                }
            }
            return res_log;
        }

        public bool NewLogin(string user, string pas, string type, string fName, string lName, string birth)
        {
            count = 0;
            LoadFile("login.txt");
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].username == user)
                {
                    res_add = false;
                    break;
                }
                count++;
            }

            if (count == users.Count)
            {
                res_add = true;
                users.Add(new User(user, pas, type, fName, lName, birth));
                StreamWriter writeFile = new StreamWriter("login.txt");
                for (int j = 0; j < users.Count; j++)
                {
                    writeFile.WriteLine(users[j].username + "," + users[j].password + "," + users[j].userType
                        + "," + users[j].firstName + "," + users[j].lastName + "," + users[j].dateBirth);
                }
                writeFile.Close();
            }
            else
            {
                res_add = false;
            }
                    
            return res_add;
        }

        public string UserRight(string uname)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].username == uname)
                {
                    user_type = users[i].userType;
                    break;
                }
            }
            return user_type;
        }

    }
}
