using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class Program
    {
        static List<Books> bookList = new List<Books>();
        static List<Member> memberList = new List<Member>();
        static List<Staff> staffList = new List<Staff>();
        static List<Books> borrowedBook = new List<Books>();
        static void ManageBook()
        {
            int option = 0;
            string bookName;
            while(option != -1)
            {
                Console.WriteLine("\t\t\t###########################################################################");
                Console.WriteLine("\n\t\t\t############                                                   ############");
                Console.WriteLine("\n\t\t\t############              All function of Book                 ############");
                Console.WriteLine("\n\t\t\t############                                                   ############");
                Console.WriteLine("\n\t\t\t###########################################################################");
                Console.WriteLine("\n\t\t\t---------------------------------------------------------------------------\n");
                Console.WriteLine("\n\t\t\t----------------------------------------------------------------------------");
                foreach (Books book in bookList)
                {
                    book.showInfo();
                }
                Console.WriteLine("\t\t\t\t1.Add New Book");
                Console.WriteLine("\t\t\t\t2.Delete Book");
                Console.WriteLine("\t\t\t\t3.Borrow Book");
                Console.WriteLine("\t\t\t\t4.Return Book");
                Console.WriteLine("\t\t\t\t5.Show Borrowed Book");
                Console.WriteLine("\t\t\t\t6.Back");
                Console.Write("\t\t\t\tInput choice: ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Input book's name");
                        bookName = Console.ReadLine();
                        Books newBook = new Books();
                        newBook.setId(bookList.Count);
                        newBook.setName(bookName);
                        bookList.Add(newBook);
                        Console.Clear();
                        Console.WriteLine("Add Success");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Input book's name");
                        bookName = Console.ReadLine();
                        for(int i = 0; i < bookList.Count; i++)
                        {
                            if(bookList[i].getName().ToLower() == bookName.ToLower())
                            {
                                bookList.RemoveAt(i);
                                Console.Clear();
                                Console.WriteLine("Delete Success");
                            }
                        }
                        Console.Clear();
                        Console.WriteLine("Don't have this book");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Input Book Name:");
                        bookName = Console.ReadLine();
                        for(int i = 0; i < bookList.Count; i++)
                        {
                            if(bookList[i].getName().ToLower() == bookName.ToLower())
                            {
                                borrowedBook.Add(bookList[i]);
                                Console.Clear();
                                Console.WriteLine("Borrow Success");
                                return;
                            }
                        }
                        Console.Clear();
                        Console.WriteLine("Don't have this book");
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("-------All Borrow Books-------");
                        for(int i = 0; i < borrowedBook.Count; i++)
                        {
                            borrowedBook[i].showInfo();
                        }
                        Console.WriteLine("Input Book Name: ");
                        bookName = Console.ReadLine();
                        for (int i = 0; i < borrowedBook.Count; i++)
                        {
                            if(borrowedBook[i].getName().ToLower() == bookName.ToLower())
                            {
                                borrowedBook.RemoveAt(i);
                                Console.Clear();
                                Console.WriteLine("Return Success");
                                return;
                            }
                        }
                        Console.Clear();
                        Console.WriteLine("Don't have this book");
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("-------All Borrow Books-------");
                        for (int i = 0; i < borrowedBook.Count; i++)
                        {
                            borrowedBook[i].showInfo();
                        }
                        break;
                    case 6:
                        Console.Clear();
                        option = -1;
                        break;
                }
            }
        }

        static void ManageStaff()
        {
            int option = 0;
            string staffName;
            int staffAge;
            string staffGender;
            string staffPhoneNumber;
            int staffSalary;
            while (option != -1)
            {
                Console.WriteLine("\t\t\t###########################################################################");
                Console.WriteLine("\n\t\t\t############                                                   ############");
                Console.WriteLine("\n\t\t\t############                      All Staff                    ############");
                Console.WriteLine("\n\t\t\t############                                                   ############");
                Console.WriteLine("\n\t\t\t###########################################################################");
                Console.WriteLine("\n\t\t\t---------------------------------------------------------------------------\n");
                Console.WriteLine("\n\t\t\t----------------------------------------------------------------------------");
                foreach (Staff staff in staffList)
                {
                    staff.showInfo();
                }
                Console.WriteLine("\t\t\t\t1.Add New Staff");
                Console.WriteLine("\t\t\t\t2.Delete Staff");
                Console.WriteLine("\t\t\t\t3.Back");
                Console.Write("\t\t\t\tInput choice: ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Input staff's name:");
                        staffName = Console.ReadLine();
                        Console.WriteLine("Input staff's age:");
                        staffAge = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Input staff's gender:");
                        staffGender = Console.ReadLine();
                        Console.WriteLine("Input staff's Phone Number:");
                        staffPhoneNumber = Console.ReadLine();
                        Console.WriteLine("Input staff's Salary:");
                        staffSalary = Convert.ToInt32(Console.ReadLine());
                        Staff newStaff = new Staff();
                        newStaff.setId(staffList.Count);
                        newStaff.setName(staffName);
                        newStaff.setAge(staffAge);
                        newStaff.setGender(staffGender);
                        newStaff.setPhone(staffPhoneNumber);
                        newStaff.setSalary(staffSalary);
                        staffList.Add(newStaff);
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Input staff's name that you want delete");
                        staffName = Console.ReadLine();
                        for (int i = 0; i < staffList.Count; i++)
                        {
                            if (staffList[i].getName().ToLower() == staffName.ToLower())
                            {
                                staffList.RemoveAt(i);
                                Console.Clear();
                                Console.WriteLine("Delete Success");
                            }
                        }
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        option = -1;
                        break;
                }
            }
        }

        static void ManageMember()
        {
            int option = 0;
            string memberName;
            int memberAge;
            string memberGender;
            string memberPhoneNumber;

            while (option != -1)
            {
                Console.WriteLine("\t\t\t###########################################################################");
                Console.WriteLine("\n\t\t\t############                                                   ############");
                Console.WriteLine("\n\t\t\t############                      All Member                   ############");
                Console.WriteLine("\n\t\t\t############                                                   ############");
                Console.WriteLine("\n\t\t\t###########################################################################");
                Console.WriteLine("\n\t\t\t---------------------------------------------------------------------------\n");
                Console.WriteLine("\n\t\t\t----------------------------------------------------------------------------");
                foreach (Member member in memberList)
                {
                    member.showInfo();
                }
                Console.WriteLine("\t\t\t\t1.Add New Member");
                Console.WriteLine("\t\t\t\t2.Delete Member");
                Console.WriteLine("\t\t\t\t3.Back");
                Console.Write("\t\t\t\tInput choice: ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Input member's name:");
                        memberName = Console.ReadLine();
                        Console.WriteLine("Input member's age:");
                        memberAge = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Input member's gender:");
                        memberGender = Console.ReadLine();
                        Console.WriteLine("Input member's Phone Number:");
                        memberPhoneNumber = Console.ReadLine();
                        Member newMember = new Member();
                        newMember.setId(memberList.Count);
                        newMember.setName(memberName);
                        newMember.setAge(memberAge);
                        newMember.setGender(memberGender);
                        newMember.setPhone(memberPhoneNumber);
                        memberList.Add(newMember);
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Input book's name");
                        memberName = Console.ReadLine();
                        for (int i = 0; i < memberList.Count; i++)
                        {
                            if (memberList[i].getName().ToLower() == memberName.ToLower())
                            {
                                memberList.RemoveAt(i);
                                Console.Clear();
                                Console.WriteLine("Delet Success");
                            }
                        }
                        Console.Clear();
                        Console.WriteLine("Don't have this member");
                        break;
                    case 3:
                        Console.Clear();
                        option = -1;
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            int option = 0;
            while(option != -1)
            {
                Console.WriteLine("\t\t\t###########################################################################");
                Console.WriteLine("\n\t\t\t############                                                   ############");
                Console.WriteLine("\n\t\t\t############      Library management System Project in C#      ############");
                Console.WriteLine("\n\t\t\t############                                                   ############");
                Console.WriteLine("\n\t\t\t###########################################################################");
                Console.WriteLine("\n\t\t\t---------------------------------------------------------------------------\n");
                Console.WriteLine("\n\t\t\t----------------------------------------------------------------------------");
                Console.WriteLine("\t\t\t\t\t1.Manage Book");
                Console.WriteLine("\t\t\t\t\t2.Manage Staff");
                Console.WriteLine("\t\t\t\t\t3.Manage Member");
                Console.WriteLine("\t\t\t\t\t4.Exit\n");
                Console.Write("\t\t\t\t\tInput choice: ");
                option = Convert.ToInt32(Console.ReadLine());D
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        ManageBook();
                        break;
                    case 2:
                        Console.Clear();
                        ManageStaff();
                        break;
                    case 3:
                        Console.Clear();
                        ManageMember();
                        break;
                    case 4:
                        Console.Clear();
                        option = -1;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
