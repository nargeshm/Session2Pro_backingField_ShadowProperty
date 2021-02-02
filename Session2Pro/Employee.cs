using ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Text;

namespace Session2Pro
{
     public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        private string _Bfield;
        public string BirthDate
        {
            get {return _Bfield; }
            
            set { _Bfield = DateTime.Parse(value).GetPersianDate(); }
        }
    }
}
