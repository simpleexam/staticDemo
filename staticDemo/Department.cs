using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticDemo
{
    class Department //отдел (может содержать несколько сотрудников)
    {
        public string Name { get; set; }//автосвойство имя отдела
        List<Employee> employers; //закрытое поле - список сотрудников в отделе

        public List<Employee> Employers //свйоство список сотрудников, доступное только для чтения
        {
            get => employers;
            //блока set нет - соответственно, записать через это свойство в список сотрудников ничего нельзя
        }
        public Department(string name)
        {
            Name = name;
            employers = new List<Employee>();
        }

        public void SetEmployee(Employee emp) //метод добавления сотрудников в отдел
        {
            bool isExists = false; //булевый флажок для проверки существует ли уже такой id в списке отдела
            foreach (Employee employee in employers)  //проверка существования такого же id среди уже доавбелнных сотрудников
            {
                if (employee.Id == emp.Id)
                {
                    isExists = true; //если находит - флажок переключается в true
                    return;
                }
            }
            //если был найден объект то новый сотрудник не записывается
            if (isExists) 
                Console.WriteLine($"сотрудник с ID #{emp.Id} уже существует");
            else//в противном случае объект нового сотрудника записывается в штат отдела ивыводится сообщение
            {
                employers.Add(emp);
                Employee.EmployeeCount++;
                Console.WriteLine($"сотрудник {emp.Name} добавлен в отдел {this.Name}");
            }
        }

        public void PrintInfo() //вывод информации по текущему отделу
        {
            string result = $"\n-------------------------------------------\n" +
                            $"сотрудники отдела {this.Name}" +
                            $"\n-------------------------------------------\n";
            foreach(Employee emp in employers)
            {
                result+=emp+"\n";
            }
            result+= $"количество сотрудников: {Employee.EmployeeCount}"; //получение количества сотрудников через static

            Console.WriteLine(result);
        }
    }
}
