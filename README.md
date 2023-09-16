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
The 
