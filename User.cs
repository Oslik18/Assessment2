using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    struct User
    {
        public string username;
        public string password;
        public string userType;
        public string firstName;
        public string lastName;
        public string dateBirth;

        public string Username { get { return this.username; } set { this.username = value; } }
        public string Password { get { return this.password; } set { this.password = value; } }
        public string UserType { get { return this.userType; } set { this.userType = value; } }
        public string FirstName { get { return this.firstName; } set { this.firstName = value; } }
        public string LastName { get { return this.lastName; } set { this.lastName = value; } }
        public string DateBirth { get { return this.dateBirth; } set { this.dateBirth = value; } }

        public User(string Username, string Password, string UserType, string FirstName, string LastName, string DateBirth)
        {
            this.username = Username;
            this.password = Password;
            this.userType = UserType;
            this.firstName = FirstName;
            this.lastName = LastName;
            this.dateBirth = DateBirth;
        }
        
    }
}
