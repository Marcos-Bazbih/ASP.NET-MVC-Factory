using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcFactory.Models
{
    public class Manager
    {
        public string firstName;
        public string lastName;
        public string department;

        public Manager() { }
        public Manager(string _firstName, string _lastName, string _department)
        {
            this.firstName = _firstName;
            this.lastName = _lastName;
            this.department = _department;
        }
    }
}