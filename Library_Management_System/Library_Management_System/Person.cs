using System;
namespace Library_Management_System
{
    public class Person
    {
        private int id;
        private string name;
        private int age;
        private string gender;
        private string phoneNumber;

        public Person()
        {

        }
        public Person(int id, string name, int age, string gender, string phoneNumber)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.phoneNumber = phoneNumber;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return this.id;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public int getAge()
        {
            return this.age;
        }

        public void setGender(string gender)
        {
            this.gender = gender;
        }

        public string getGender()
        {
            return this.gender;
        }

        public void setPhone(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public string getPhoneNumber()
        {
            return this.phoneNumber;
        }

        public void showInfo()
        {
            Console.WriteLine("Id: " + this.id);
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Age: " + this.age);
            Console.WriteLine("Gender: " + this.gender);
            Console.WriteLine("PhoneNumber: " + this.phoneNumber);
        }
    }
}
