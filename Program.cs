//Objective, take a first name and a last name, and return the full name in a specified format

using static WhateverIWant.Program;

namespace WhateverIWant
{
    internal class Program
    {
        public enum NameFormat
        {
            FirstCommaLast,
            LastCommaFirst,
            FirstLast,
            LastFirst
        }

        //method declaration syntax
        //   [accessibility_level] [static] return_type MethodName([parameter1_datatype] [parameter1_name], [parameter2_datatype] [parameter2_name] ...)
        //
        // [] means the argument is optional
        // return_type can be a data type, e.g. int, double, a reference type e.g. string
        // or an object type e.g. DateTime
        // If it doesn't return, then the return_type is void

        //We're going to use static methods only for now... until otherwise stated
        //We're going to use public accessibility level for now... until otherwise stated

        //Main() is a special method. It's the entry point to our program
        //The purpose of a method is to execute code (i.e. logic)
        //Assume a class can have more than one method (can have any number)
        static void Main(string[] args)
        {
            Console.ReadLine();

            string firstName = GetFirstName();
            string lastName = GetLastName();
            NameFormat userDefinedNameFormat = GetNameFormat();
            string fullName = CombineFirstAndLastName(firstName, lastName, userDefinedNameFormat);

            OutputFormattedFullName(fullName);
        }

        //GetFirstName()
        //The purpose of this method is to ask and obtain the user's first name using the console.
        public static string GetFirstName()
        {
            Console.Write("What is your first name?: ");
            return Console.ReadLine();
        }

        //GetLastName()
        //The purpose of this method is to ask and obtain the user's last name using the console.
        public static string GetLastName()
        {
            Console.Write("What is your last name?: ");
            return Console.ReadLine();
        }

        //GetNameFormat
        //The purpose of this method is to obtain the user's preference in the display of their name.
        public static NameFormat GetNameFormat()
        {
            Console.WriteLine();

            string[] names = Enum.GetNames(typeof(NameFormat));

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(i + 1 + ": " + names[i]);
            }

            Console.Write("Please select a name format from the list above: ");
            string userSelection = Console.ReadLine();
            Console.WriteLine();

            bool result = int.TryParse(userSelection, out int intUserSelection);

            if (result == true && intUserSelection >= 1 && intUserSelection <= names.Length)
            {
                return (NameFormat)(intUserSelection - 1);
            }
            else
            {
                return NameFormat.LastCommaFirst;
            }
        }

        //CombineFirstAndLastName()
        //The purpose of this method is to combine a first and last name in Last, First format
        public static string CombineFirstAndLastName(string firstName, string lastName, NameFormat nameFormat)
        {
            string fullName = "";

            if (nameFormat == NameFormat.FirstCommaLast) fullName = firstName + ", " + lastName;
            if (nameFormat == NameFormat.LastCommaFirst) fullName = lastName + ", " + firstName;
            if (nameFormat == NameFormat.FirstLast) fullName = firstName + " " + lastName;
            if (nameFormat == NameFormat.LastFirst) fullName = lastName + " " + firstName;

            return fullName;
        }

        //OutputFormattedFullName()
        //The purpose of this method is to output to the console the formatted full name
        public static void OutputFormattedFullName(string fullName)
        {
            Console.WriteLine("");

            Console.WriteLine("Your full name is: " + fullName);
        }
    }
}