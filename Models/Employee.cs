using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcFactory.Models
{
    public class Employee
    {
        public string firstName;
        public string lastName;
        public int birthYear;
        public string phoneNumber;

        public Employee() { }
        public Employee(string _firstName, string _lastName, int _birthYear, string _phoneNumber)
        {
            this.firstName = _firstName;
            this.lastName = _lastName;
            this.birthYear = _birthYear;
            this.phoneNumber = _phoneNumber;
        }
    }
}