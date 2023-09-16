# FirstLastNameByEnum
This program obtains a users *first* and *last* name and then displays the users name with their desired format by using **enumeration**.
## Summary
The program is designed to ask for the user's *first* name; their *last* name; and then requests the user to choose the format they would like their name displayed.
## Methods
### Enumeration Code ###
```cs
public enum NameFormat`
{
    FirstCommaLast,
    LastCommaFirst,
    FirstLast,
    LastFirst
}
```
In the first **method** we introduce ***public enum*** which is a list of predefined constants defined by integer values.
- The predefined constants are the variations the *first* and *last* name are to be displayed
- The integer value begins at zero and ends at three in this program.  With enumeration, by default, the first predefined constant begins with zero and then counts forward until the predefined constants end.
    - FirstCommaLast is set at zero
    - LastFirst is set at three
### Main Method Code ####
```cs
static void Main(string[] args)
{
    string firstName = GetFirstName();
    string lastName = GetLastName();
    NameFormat userDefinedNameFormat = GetNameFormat();
    string fullName = CombineFirstAndLastName(firstName, lastName, userDefinedNameFormat);

    OutputFormattedFullName(fullName);
}
```
This is the entry point within a C# console application, it serves as the starting point for the program's execution.
- *static* is used to mark the **Main** method as *static* as it does not belong to an instance of a class, but belongs to the class itself.
    - This allows the ability to call the **Main** method without creating an object of the class that contains it.
- *void* allows the method to perform its tasks and does not provide a result.
- *Main* is the name of the method, it is consistently used as the entry point in a C# application.
    - The **capitalization** and **spelling** must match exactly; *Main*
- *(string[] args)* is the method's parameter list, taking an array of strings called **args** as a parameter.
    - The **args** allow to pass command-line arguements as the application runs.
        - Command-line arguments can:
            - Provide Input
            - Configuration to the program
### GetFirstName Code ###
```cs
 public static string GetFirstName()
 {
     Console.Write("What is your first name?: ");
     return Console.ReadLine();
 }
```
[ENTER TEXT HERE]

### GetLastName Code ###
```cs
public static string GetLastName()
{
    Console.Write("What is your last name?: ");
    return Console.ReadLine();
}
```
[ENTER TEXT HERE]

### GetNameFormat Code ###
```cs
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
```
[ENTER TEXT HERE]

### CombineFirstAndLastName Code ###
```cs
public static string CombineFirstAndLastName(string firstName, string lastName, NameFormat nameFormat)
{
    string fullName = "";

    if (nameFormat == NameFormat.FirstCommaLast) fullName = firstName + ", " + lastName;
    if (nameFormat == NameFormat.LastCommaFirst) fullName = lastName + ", " + firstName;
    if (nameFormat == NameFormat.FirstLast) fullName = firstName + " " + lastName;
    if (nameFormat == NameFormat.LastFirst) fullName = lastName + " " + firstName;

    return fullName;
}
```
[ENTER TEXT HERE]

### OutputFormattedFullName ###
```cs
        public static void OutputFormattedFullName(string fullName)
        {
            Console.WriteLine("");

            Console.WriteLine("Your full name is: " + fullName);
        }
    }
}
```
[ENTER TEXT HERE]
## Complete Code ##
```cs
namespace FirstLastNameByEnum
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
                
        static void Main(string[] args)
        {
            string firstName = GetFirstName();
            string lastName = GetLastName();
            NameFormat userDefinedNameFormat = GetNameFormat();
            string fullName = CombineFirstAndLastName(firstName, lastName, userDefinedNameFormat);

            OutputFormattedFullName(fullName);
        }

        public static string GetFirstName()
        {
            Console.Write("What is your first name?: ");
            return Console.ReadLine();
        }

        public static string GetLastName()
        {
            Console.Write("What is your last name?: ");
            return Console.ReadLine();
        }

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

        public static string CombineFirstAndLastName(string firstName, string lastName, NameFormat nameFormat)
        {
            string fullName = "";

            if (nameFormat == NameFormat.FirstCommaLast) fullName = firstName + ", " + lastName;
            if (nameFormat == NameFormat.LastCommaFirst) fullName = lastName + ", " + firstName;
            if (nameFormat == NameFormat.FirstLast) fullName = firstName + " " + lastName;
            if (nameFormat == NameFormat.LastFirst) fullName = lastName + " " + firstName;

            return fullName;
        }

        public static void OutputFormattedFullName(string fullName)
        {
            Console.WriteLine("");

            Console.WriteLine("Your full name is: " + fullName);
        }
    }
}
```
