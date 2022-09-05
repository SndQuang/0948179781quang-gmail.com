using Library_Management_System;
using System;
namespace Library_Management_System
{
    public class Member : Person
    {
        public Member()
        {

        }

        public Member(int id, string name, int age, string gender, string phoneNumber) : base(id, name, age, gender, phoneNumber)
        {

        }

    }
}
