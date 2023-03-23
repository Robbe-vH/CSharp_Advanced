using System;
using System.IO;
using System.Text;

namespace Oefeningen_Streams
{
    public class Oefening_3
    {
        private static StringBuilder sb = new StringBuilder();
        private static string firstName = string.Empty;
        private static string lastName = string.Empty;
        private static  bool ageIsNumber = false;

        public static void AddName()
        {
            using (StreamWriter sw = new StreamWriter("mensen.txt"))
            {


                Console.WriteLine("First Name");
                firstName = Console.ReadLine();

                if (!firstName.Contains("-")) sb.Append(firstName.ToUpper() + "-");
                else sb.Append("ongeldig");

                Console.WriteLine("Last Name");
                lastName = Console.ReadLine();
                if (!lastName.Contains("-")) sb.Append(lastName.ToUpper() + "-");
                else sb.Append("ongeldig");

                Console.WriteLine("Age");
                ageIsNumber = Int32.TryParse(Console.ReadLine(), out int age);

                if (ageIsNumber) sb.Append(age.ToString());
                else sb.Append("ongeldig");

                sw.WriteLine(sb.ToString());

            }
        }
    }
}