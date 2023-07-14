namespace CompanyApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO UBTECH COMPANY LIMITED");
            Console.WriteLine("Enter your name");
            var employeeName = Console.ReadLine();

            Console.WriteLine("Enter your age");
            int employeeAge = Convert.ToInt32(Console.ReadLine());  
             
            if(employeeAge < 18) 
            { 
               Console.WriteLine("Sorry we can't employ you at this time");
            }
            else if(employeeAge >65)
            {
                Console.WriteLine("Sorry we can't employ you");
            }
            else
            {
                Console.WriteLine("You have been scheduled for an interview");
            }
            Console.ReadLine();

            Console.WriteLine("Chose what you want to do");
            Console.WriteLine("1. Add employee");
            Console.WriteLine("2. Update employee");
            Console.WriteLine("3. Delete employee");
            var option = Console.ReadLine();

            switch(option) 
            {
                case "1":
                    Console.WriteLine("Add employee");
                    break;

                case "2":
                    Console.WriteLine("Update employee");
                    break;

                case "3":
                    Console.WriteLine("Delete employee");
                    break;
            }

        }
    }
}