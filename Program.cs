using System.Threading;

namespace HelloWorld_Null_Asher
{
    internal class Program
    {
        

        static void Main(string[] args)
        { // this string holds the first name //
            string firstName;
           // this string holds the last name
            string lastName;
            // this string cimbines the first name and last name strings //
            string fullName;
            // asks your name //
            Console.WriteLine("WHAT IS YOUR NAME!?");
            firstName = Console.ReadLine();
       
            // asks your last name //
            Console.WriteLine("WHAT IS YOUR LAST NAME!?");
            lastName = Console.ReadLine();
           
            // takes the imputs and outputs your full name //
            fullName = ($"Your name is {firstName} {lastName}");


            Console.WriteLine(fullName);
        }
    }
}