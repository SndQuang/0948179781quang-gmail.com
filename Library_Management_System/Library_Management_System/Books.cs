using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Books
    {
        private string name;
        private int id;


        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return this.id;

        }

        public void showInfo()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Id: " + this.id);
        }
    }
}
