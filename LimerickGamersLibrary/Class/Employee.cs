
using System;

namespace LimerickGamersLibrary.Class
{
    [Serializable]
    public class Employee : Person
    {
        public string EmployeeId { set; get; }
        public string EmployeePswd { set; get; }

        public Employee(string name, string surname, string id)
            : base(name, surname)
        {
            EmployeeId = id;
            // Default password is set to 'name'
            EmployeePswd = name;
        }

        public Employee(string name, string surname) : base(name, surname)
        {
            EmployeeId = Model.GenerateEmployeeId();
        }

        public Employee(string name, string surname, string address, string phoneNum, string email)
            : base(name, surname, address, phoneNum, email)
        {
            EmployeeId = Model.GenerateEmployeeId();
            EmployeePswd = name;
        }

        public override string showDetails()
        {
            return string.Format("{0} {1} {2} ", this.Name, this.Surname, this.EmployeeId);
        }

       
    }
}
