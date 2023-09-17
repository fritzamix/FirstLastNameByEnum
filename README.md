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
- The **string firstName** states that **firstName** is the data type variable where it will store a sequence of characters.
    - **firstName** is the name of the variable being declared, it is the name used to identify the value stored.
- The **string lastName** also states that **lastName** is the data type variable where it will also store a sequence of characters.
    - **lastName** is also the name of the variable being declared, it is the name used to identify the value stored.
- The "=" is used to assign a value to the variable on the left side of the "="; the assignment operator.
- The **GetFirstName()** is a method call, which can be called to return the value type *string*.
- The **GetLastName()** is also a method call, which can be called to return its own value type *string*.
- **NameFormat** is the data type of the variable being declared.
- **userDefinedNameFormat** is the name of the variable being declared.
    - This is an identifier that can be used to refer to a value stored in the variable.
- The "=" is used to assign a value to the variable on the left side of the "="; the assignment operator.
- **GetNameFormat()** is also a method call, this method returns a value of the **NameFormat** enumeration type.
- The **string fullName** states that **fullName** is the data type variable where it will store a sequence of characters.
    - **fullName** is the name of the variable being declared, it is the name sued to identify the value stored.
- The "=" is used to assign a value to the variable on the left side of the "="; the assignment operator.
- **CombineFirstAndLastName ...** is a method call, essentially combining the **firstName** and **lastName** while applying a specified format found in **userDefinedNameFormat**.
    - Invoking a method named **CombineFirstAndLastName**
    - Passing three arguements to it, **firstName**, **lastName**, and **userDefinedNameFormat**
        - **firstName** is a variable representing the last name
        - **lastName** is a variable representing the last name
        - **userDefinedNameFormat** is a variable representing a user-defined format via enumeration
- **OutputFormattedFullName()** is a method call that in this instance, takes a string arguement.
    - That string arguement is **fullName**
    - This method, when called, displays the formatted full name
### GetFirstName Code ###
```cs
 public static string GetFirstName()
 {
     Console.Write("What is your first name?: ");
     return Console.ReadLine();
 }
```
The **GetFirstName** method obtains and returns the user's first name.
- **public static string GetFirstName()** is a method declararion
    - **public** method means it can be accessed from outside the class where it is defined
    - **static** method means it can be called without creating an instance of the class, returning a *string* type (in this instance)
- **Console.Write(What is your first name?: ");** writes *What is your first name?* on the console, prompting the user to enter their first name.
- **return Console.ReadLine();** reads what the user enters and returns it as a *string* type
    - in short, capturing the enty of the user and stores it as a value and use as needed within the program

### GetLastName Code ###
```cs
public static string GetLastName()
{
    Console.Write("What is your last name?: ");
    return Console.ReadLine();
}
```
The **GetLastName** method obtains and returns the user's last name.
- **public static string GetLastName()** is a method declararion.
    - **public** method means it can be accessed from outside the class where it is defined
    - **static** method means it can be called without creating an instance of the class, returning a *string* type (in this instance)
- **Console.Write(What is your last name?: ");** writes *What is your last name?* on the console, prompting the user to enter their last name.
- **return Console.ReadLine();** reads what the user enters and returns it as a *string* type 
    - in short, capturing the enty of the user and stores it as a value and use as needed within the program

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
The **GetNameFormat** method allows a user to select a name format from a list of options and returns the chosen format as an enum value of **NameFormat**.  If a user provides an invalid input, the default format is **NameFormat.LastCommaFirst**.
- **public static string GetLastName()** is a method declararion.
    - **public** method means it can be accessed from outside the class where it is defined
    - **static** method means it can be called without creating an instance of the class, returning a *enumeration* type (in this instance)
- **Console.WriteLine();** creates a blank line to the console, providing visual separation form lines of text on the console
- **string[] names = Enum.GetNames(typeof(NameFormat));** retrieves the names of the values in the **NameFormat** enumeration and stores the array call **names**
- **for (int i = 0; i < names.Length; i++) is a *for* loop that repeatedly numbers each format until the list ends
    - **int** specifies the data type of the variable as an *integer*
    - "**i**" is the name of the variable
    - The "=" is used to assign a value to the variable on the left side of the "="; the assignment operator.
    - "**0**" is the value being assigned to the variable "**i**"
        - Note: **i++** is shorthand in *C#* to increment the value of a variable by 1.  This is called a *post increment* operator
            - Outside of the project, a *pre-increment* operator, for example, would be **++i**, if you want to increment the variable before using its current value
- **Console.Write("Please select a name format from the list above: ");** is displayed on the consold to prompt the user to select a *name format*.
- **string userSelection = Console.ReadLine();** reads what the user enters and returns it as a *string* type in the **userSelection** variable
- **bool result = int.TryParse(userSelection, out int intUserSelection);**  attempts to parse the **userSelection** string into an integer and stores the resluts in the **intUsersSelection** variable
    - If the parsing is successful as well as the user entering a format that falls within the valid range of name formats in **result**, it is set to **true**.
        - If **result** is set to **true**, it will return the selected name format by converting the integer back to the corresponding **NameFormat** enum value.
          - Note: **(intUserSelection - 1)** is used to account for that fact arrays are zero-based, while the user's selection is one-based
              - For example, array is 0 = user's selection is 1, array is 1 = user's selection is 2, etc...
    - If the criteria above is false, it will default to the format **LastCommaFirst**
        - The criteria would be false if the user's input is not valied (either not a number or within the valid range)
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
