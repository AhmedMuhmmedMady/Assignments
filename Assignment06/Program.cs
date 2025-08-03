using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Linq;

namespace CompanyApp
{
    #region 1.Design and implement a Class for the employees in a company:
    //Notes:
    //•	Employee is identified by an ID, Name, security level, salary, hire date and Gender.
    //•	We need to restrict the Gender field to be only M or F[Male or Female]
    //•	Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum.
    //•	We want to provide the Employee Class to represent Employee data in a string Form (override ToString ()), display employee salary in a currency format. [Use String.Format() Function].
    [Flags]
    public enum SecurityLevel : byte
    {
        Guest = 1,
        Developer = 2,
        Secretary = 4,
        DBA = 8,
    }

    public class Employee 
    {
        private string gender;

        public int ID { get; set; }
        public string Name { get; set; }
        public SecurityLevel Security { get; set; }
        public decimal Salary { get; set; }
        public HiringDate HireDate { get; set; }

        public string Gender
        {
            get { return gender; }
            set
            {
                if (value.ToUpper() == "M" || value.ToUpper() == "F")
                {
                    gender = value.ToUpper();
                }
                else
                {
                    Console.WriteLine("Gender must be 'M' or 'F'");
                }
            }
        }
        public Employee(int id, string name, SecurityLevel security, decimal salary, HiringDate hireDate, string gender)
        {
            ID = id;
            Name = name;
            Security = security;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }
        public override string ToString()
        {
            return $"ID: {ID}\n" + $"Name: {Name}\n" + $"Security Level: {Security}\n" + $"Salary: {string.Format("{0:C}", Salary)}\n" + $"Hire Date: {HireDate.ToString}\n" + $"Gender: {(Gender == "M" ? "Male" : "Female")}";
        }
    }
    #endregion

    #region 2.Develop a Class to represent the Hiring Date Data : Consisting of fields to hold the day, month and Years.

    public class HiringDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }


        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
    }
    #endregion

    #region 5-Design a program for a library management system where:
    //•	Book is a base class with properties like Title, Author, and ISBN.
    //•	EBook and PrintedBook are derived classes with additional properties like FileSize for EBook and PageCount for PrintedBook.
    //Demonstrate how inheritance simplifies the design.

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nISBN: {ISBN}");
        }
    }

    public class EBook : Book
    {
        public double FileSize { get; set; }

        public EBook(string title, string author, string isbn, double fileSize)
            : base(title, author, isbn)
        {
            FileSize = fileSize;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"File Size: {FileSize} MB\n");
        }
    }

    public class PrintedBook : Book
    {
        public int PageCount { get; set; }

        public PrintedBook(
            string title,
            string author,
            string isbn,
            int pageCount) : base(title, author, isbn)
        {
            PageCount = pageCount;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Page Count : {PageCount} pages\n");
        }
    }


    #endregion

    class Program
    {
        static void Main()
        {
            #region 3.Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)
            //  Notes :
            //•	Implement All the Necessary Member Functions on the Class(Getters, Setters)
            //•	Define all the Necessary Constructors for the Class
            //•	Allow NO RUNTIME errors if the user inputs any data
            //•	Write down all the necessary Properties(Instead of setters and getters)
            Employee[] EmpArr = new Employee[3];

            EmpArr[0] = new Employee(
                id: 1,
                name: "Omar Youssef",
                security: SecurityLevel.DBA,
                salary: 15000m,
                hireDate: new HiringDate(1, 1, 2023),
                gender: "M"
            );
            EmpArr[1] = new Employee(
                id: 2,
                name: "Salma Ali",
                security: SecurityLevel.Guest,
                salary: 7000m,
                hireDate: new HiringDate(15, 2, 2024),
                gender: "F"
            );
            EmpArr[2] = new Employee(
                id: 3,
                name: "Mostafa Khaled",
                security: SecurityLevel.DBA | SecurityLevel.Guest | SecurityLevel.Developer | SecurityLevel.Secretary,
                salary: 20000m,
                hireDate: new HiringDate(3, 8, 2025),
                gender: "M"
            );
            #endregion

            #region 4.Sort the employees based on their hire date then Print the sorted array.•	While sorting(how many times Boxing and Unboxing process has occurred)
            //Array.Sort(EmpArr);
            foreach (Employee e in EmpArr)
            {
                Console.WriteLine(e.ToString());
            }
            #endregion

        }
    }
}