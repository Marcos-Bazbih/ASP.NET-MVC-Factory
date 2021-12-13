using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcFactory.Models
{
    public class Supervisor
    {
        public string firstName;
        public string lastName;
        public int birthYear;
        public int workExperience;

        public Supervisor() { }
        public Supervisor(string _firstName, string _lastName, int _birthYear, int _workExperience)
        {
            this.firstName = _firstName;
            this.lastName = _lastName;
            this.birthYear = _birthYear;
            this.workExperience = _workExperience;
        }
    }
}