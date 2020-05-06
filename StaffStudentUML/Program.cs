using System;

namespace StaffStudentUML
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> peopleList = new List<Person>();
            peopleList.Add(new Staff("Mr. Simmons", "121 Sesame Street", "P.S. 118", 19.00));
            peopleList.Add(new Staff("Principal Warts", "122 Sesame Street", "P.S. 118", 30.30));
            peopleList.Add(new Student("Arnold", "123 Sesame Street", "Math", 1, 3000.00));
            peopleList.Add(new Student("Gerald", "124 Sesame", "Gym", 2, 1500.32));
            peopleList.Add(new Student("Helga G. Patacki", "125 Sesame Streer", "English", 3, 4552.36));
            string input;
            int selection;
            while (true)
            {
               

                try
                {
                    selection = int.Parse(input);
                    if (selection != 1 && selection != 2)
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    Console.WriteLine("Please try again.");
                    continue;
                }
                if (selection == 1)
                {
                    ViewRegistry(peopleList);
                }
                else
                {
                    RegisterPerson(peopleList);
                }
            }
        }

        public static void ViewRegistry(peopleList)
        {
            foreach (Person person in peopleList)
            {
                Console.WriteLine(person.ToString());
            }
        }

        public static void AddPersonToList(peopleList)
        {
            EnterName();

        }
        public static string PromptUser(string message)
        {
            Console.Write(message);
            return Console.ReadLine()
        }

        public static void RegisterPerson(peopleList)
        {
            int number;
            while (true)
            {
                try
                {
                    number = int.Parse(PromptUser("Enter 1 for staff member or 2 for student"));
                    if (number != 1 && number != 2)
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    Console.WriteLine("Please try again.");
                    continue;
                }
                if (number == 1)
                {
                    RegisterStaff(peopleList);
                    break;
                }
                else
                {
                    RegisterStudent(peopleList);
                    break;
                }
            }
        }

        public static void RegisterStaff (peopleList)
        {
            string name = EnterName();
            string address = EnterAddress();
            string school = EnterSchool();
            double pay = EnterPay();

            peopleList.Add(new Staff(name, address, school, pay));
            Console.WriteLine($"Staff member {name} has beed added.");
        }
        public static void RegisterStudent(peopleList)
        {
            string name = EnterName();
            string address = EnterAddress();
            string program = EnterProgram();
            int year = EnterYear();
            double fee = EnterFee();
            peopleList.Add(new Student(name, address, program, year, fee));
            Console.WriteLine($"Student {name} has been added.");
        }

        public static string EnterName()
        {
            string name;
            while (true)
            {
                name = PromptUser("Please enter a name: ");
                if (IsEmpty(name))
                {
                    Console.WriteLine("Enter full name.");
                    continue;
                }
                else
                {
                    break;
                }
            }
            return name;
        }

        public static string EnterAddress()
        {
            string address;
            while (true)
            {
                address = PromptUser("Please enter an address: ");
                if (IsEmpty(address))
                {
                    Console.WriteLine("Enter Address full address");
                }
                else
                {
                    break;
                }
            }
            return address;
        }

        public static string EnterSchool()
        {
            string school;
            while (true)
            {
                school = PromptUser("Please enter a school: ");
                if (IsEmpty(school))
                {
                    Console.WriteLine("enter full school address.");
                    continue;
                }
                else
                {
                    break;
                }
            }
            return school;
        }

        public static double EnterPay()
        {
            double pay;
            while (true)
            {
                try
                {
                    pay = double.Parse(PromptUser("Please enter a pay rate: "));
                    return pay;
                }
                catch
                {
                    Console.WriteLine("using numbers, enter a pay rate");
                    continue;
                }
            }
        }

        public static string EnterProgram()
        {
            string program;
            while (true)
            {
                program = PromptUser("Please enter a program: ");
                if (IsEmpty(program))
                {
                    Console.WriteLine("Invalid..");
                    continue;
                }
                else
                {
                    break;
                }
            }
            return program;
        }

        public static double EnterFee()
        {
            double fee;
            while (true)
            {
                try
                {
                    fee = double.Parse(PromptUser("Please enter a fee: "));
                    return fee;
                }
                catch
                {
                    Console.WriteLine("Invalid..");
                    continue;
                }
            }
        }

        public static int EnterYear()
        {
            int year;
            string holder;
            while (true)
            {
                try
                {
                    holder = PromptUser("Please enter a year: ");
                    if (IsEmpty(holder))
                    {
                        throw new Exception("Input cannot be empty.");
                    }
                    year = int.Parse(holder);
                    if (year < 0)
                    {
                        throw new Exception("Input must be greater than 0.");
                    }
                    return year;
                }
                catch
                {
                    Console.WriteLine("Error: please try again.");
                    continue;
                }
            }
        }

       
    }
}
