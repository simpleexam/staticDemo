using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticDemo
{
    public class Employee
    {
        public int Id { get; set; } //автосвойство уникального идентификатора сотрудника
        public string Name { get; set; } //автосвойство имени сотрудника
        public Employee()
        {
           
        } 
        public Employee(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }
        public static int EmployeeCount = 0; //количество всех сотрудников

        public override string ToString()
        {
            return $"ID: #{Id}\t{Name}";
        }

    }
}
