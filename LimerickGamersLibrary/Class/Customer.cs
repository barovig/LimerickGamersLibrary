
using System;

namespace LimerickGamersLibrary.Class
{
    [Serializable]
    class Customer : Person
    {

        public string CustomerId { set; get; }
        public Customer(string name, string surname, string id) : base(name, surname)
        {
            CustomerId = id;
        }

        public Customer(string name, string surname, string id, string address, string phone, string  email)
            : base(name, surname, address, phone, email)
        {
            CustomerId = Model.GenerateCustomerId();
        }

        public Customer(string name, string surname, string address, string phone, string email)
            : base(name, surname, address, phone, email)
        {
            CustomerId = Model.GenerateCustomerId();
        }

        public Customer(string name, string surname) : base(name,surname)
        {
            CustomerId = Model.GenerateCustomerId();
        }

        public override string showDetails()
        {
            return string.Format("{0} {1} {2}  ", this.Name, this.Surname, this.CustomerId);
        }
    }
}
