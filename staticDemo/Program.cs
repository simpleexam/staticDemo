namespace staticDemo
{
    internal class Program
    {
        /*
         * в данном примере есть проблема - не выводится соответствующее сообщение
         * о персечении id объекта тутуева.
         * кто найдет причину и внятно ее объяснит - 5
         */
        static void Main(string[] args)
        {
            Department department = new Department ("IT отдел" );
            
            department.SetEmployee(new Employee("Morozov",  855));
            department.SetEmployee(new Employee("Ivanov",   100));
            department.SetEmployee(new Employee("Sidorov",  655));
            department.SetEmployee(new Employee("Kykyev",   755));
            department.SetEmployee(new Employee("Tytytev",  855));

            department.PrintInfo();

            
        }
    }
}