using System;
using System.Collections.Generic;
using System.Text;

namespace ControlEmployees {
    class Employee {

        public int id { get; set; }
        public string name { get; set; }
        public double salary { get; set; }

        public void increaseSalary(double percentage) {
            salary += salary * percentage / 100.00;
        }

    }
}
