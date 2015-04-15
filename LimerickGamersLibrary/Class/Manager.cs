
using System;

namespace LimerickGamersLibrary.Class
{
    [Serializable]
    class Manager : Employee
    {
        public Manager(string name, string surname, string id) : base(name, surname, id) { }

        public Manager(string name, string surname, string address, string phone, string email)
            : base(name, surname, address, phone, email)
        {
        }

    }
}
