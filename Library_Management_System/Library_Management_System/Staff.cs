using Library_Management_System;
using System;
namespace Library_Management_System
{
    public class Staff : Person
    {
        private int salary;

        public Staff()
        {

        }

        public Staff(int id, string name, int age, string gender, string phoneNumber, int salary) : base(id, name, age, gender, phoneNumber)
        {
            this.salary = salary;
        }

        public void setSalary(int salary)
        {
            this.salary = salary;
        }

        public int getSalary()
        {
            return this.salary;
        }

        public void showStaffInfo()
        {
            base.showInfo();
            Console.WriteLine("Salary" + this.salary);
        }
    }
}
