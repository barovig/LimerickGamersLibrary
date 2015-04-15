
using System;

namespace LimerickGamersLibrary.Class
{
    [Serializable]
    public abstract class Person
    {
        public string Name { set; get; }
        public string Surname { set; get; }
        public string Address { set; get; }
        public string PhoneNum { set; get; }
        public string Email { set; get; }
        protected Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        protected Person(string name, string surname, string address, string phone, string email)
        {
            Name = name;
            Surname = surname;
            Address = address;
            PhoneNum = phone;
            Email = email;
        }
        public abstract string showDetails();
    }
}
