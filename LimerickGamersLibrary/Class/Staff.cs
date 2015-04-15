
using System;

namespace LimerickGamersLibrary.Class
{
    [Serializable]
    class Staff : Employee
    {
        public Staff(string name, string surname, string id) : base(name, surname, id) { }

        public Staff(string name, string surname) : base(name, surname)
        {
        }

        public Staff(string name, string surname, string address, string phone, string email)
            : base(name, surname, address, phone, email)
        {
        }
    }

}
