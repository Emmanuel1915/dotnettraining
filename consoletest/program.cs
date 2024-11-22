using System.Xml.Serialization;
using System;

namespace consoletest
{
    class program
    {
        static void Main(string[] args)
        {
            //Using Direct ReadLine To calcuate age

            //DateOnly today = DateOnly.FromDateTime(DateTime.Now);

            //Console.WriteLine("Enter Your Date Of year To calculate you age :");
            //string getuserYear = Console.ReadLine();
            //Console.WriteLine("Enter Your Date Of Month To calculate you age :");
            //string getuserMonth = Console.ReadLine();
            //Console.WriteLine("Enter Your Date Of Day To calculate you age :");
            //string getuserDay = Console.ReadLine();

            //string resultY = getuserYear.Replace(" ", "");
            //string resultM = getuserMonth.Replace(" ", "");
            //string resultD = getuserDay.Replace(" ", "");

            //int curday = today.Day;
            //int curmonth = today.Month;
            //int curyear = today.Year;

            //int AgeYear = curyear - int.Parse(resultY);
            //int AgeMonth = curmonth - int.Parse(resultM);
            //int AgeDay = curday - int.Parse(resultD);

            //Console.WriteLine("Your Exact age is "+AgeYear+" Years, " + AgeMonth + " Months, "+ AgeDay+" Days....");

            //Using Date Time Object

            Console.Write("Enter your birthdate (yyyy-mm-dd): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());
            DateTime today = DateTime.Today;

            int age = today.Year - birthdate.Year;
            Console.WriteLine("the calculated age is:"+age);
            if (birthdate > today.AddYears(-age)) age--;

            Console.WriteLine($"Your age is: {age} years");

        }

    }
  
}
