# Stone_Red-C-Sharp-Utilities

> Provides useful C# methods.

## Install

### Package Manager
`Install-Package Stone_Red-C-Sharp-Utilities`

### .NET CLI
`dotnet add package Stone_Red-C-Sharp-Utilities`

### NuGet
https://www.nuget.org/packages/Stone_Red-C-Sharp-Utilities

## Namespaces
### Stone_Red_Utilities.ArrListExtentions
#### Methods:
  * Print
    * Description: Prints items of array
    * Parameters: `this Array array`, `char delimiter`, `bool printToDebugConsole`
    * Example usage:
      ```cs
      string[] yourArray = { "str1", "str2", "str3" };
      yourArray.Print(';');
      ```
    * Output: 
      ```
      str1; str2; str3
      ```
  * Print\<T>
    * Description: Prints items of list
    * Parameters: `this List<T> list`, `char delimiter`, `bool printToDebugConsole`
    * Example usage:
      ```cs
      List<double> yourList = new() { 1.45, 6.24, 4.14 };
      yourList.Print(';');
      ```
    * Output: 
      ```
      1.45; 6.24; 4.14
      ```
  * PrintTable\<T>
    * Description: Creates and prints table from 2D array
    * Parameters: `this T[,] array`, `TableStyle tableStyle`
    * Example usage:
      ```cs
      int[,] your2dArray =
      {
          {1,2,3 },
          {4,5,6 },
          {7,8,9 }
      };
      your2dArray.PrintTable(TableStyle.Default);
      ```
    * Output: 
      ```
      -------------
      | 1 | 2 | 3 |
      -------------
      | 4 | 5 | 6 |
      -------------
      | 7 | 8 | 9 |
      -------------
      ```
      
### Stone_Red_Utilities.ConsoleExtentions
#### Methods:
  * Write
    * Description: Writes the text representation of the specified object to the standard output stream.
    * Parameters: `object value`, `ConsoleColor color`
    * Example usage:
      ```cs
      ConsoleExt.Write("text in red", ConsoleColor.Red);
      ```
    * Output:
      ```
      text in red
      ```
      (Imagine that the text is actually red)
 * WriteLine
    * Description: Writes the text representation of the specified object, followed by the current line terminator, to the standard output stream.
    * Parameters: `object value`, `ConsoleColor color`
    * Example usage:
      ```cs
      ConsoleExt.WriteLine("text in green", ConsoleColor.Green);
      ```
    * Output:
      ```
      text in green
      ```
      (Imagine that the text is actually green)
      
### Stone_Red_Utilities.BoolExtentions
#### Methods:
  * OneWayTrue
    * Description: Sets value to true if input is true. If input is false the value will not change.
    * Parameters: `this ref bool bol`, `bool input`
    * Example usage:
      ```cs
      bool bol = false;
      
      bol.OneWayTrue(false);
      Console.WriteLine(bol);
      
      bol.OneWayTrue(true);
      Console.WriteLine(bol);
      
      bol.OneWayTrue(false);
      Console.WriteLine(bol);
      ```
    * Output:
      ```
      False
      True
      True
      ```
  * OneWayFalse
    * Description: Sets value to false if input is false. If input is true the value will not change.
    * Parameters: `this ref bool bol`, `bool input`
    * Example usage:
      ```cs
      bool bol = true;

      bol.OneWayFalse(true);
      Console.WriteLine(bol);

      bol.OneWayFalse(false);
      Console.WriteLine(bol);

      bol.OneWayFalse(true);
      Console.WriteLine(bol);
      ```
    * Output:
      ```
      True
      False
      False
      ```
* ToInt
    * Description: Converts bool to int.
    * Parameters: `this bool bol`
    * Example usage:
      ```cs
      bool bol1 = false;
      bool bol2 = true;

      int i = bol1.ToInt();
      int j = bol2.ToInt();

      Console.WriteLine(i);
      Console.WriteLine(j);
      ```
    * Output:
      ```
      0
      1
      ```
* FromInt
    * Description: Converts int to bool.
    * Parameters: `this ref bool bol`, `int input`
    * Example usage:
      ```cs
      bool bol1;
      bool bol2;

      bol1.FromInt(0);
      bol2.FromInt(1);

      Console.WriteLine(bol1);
      Console.WriteLine(bol2);
      ```
    * Output:
      ```
      false
      true
      ```
### Stone_Red_Utilities.StringExtentions
#### Methods

  * EqualsIgnoreCase
    * Description: Determines whether this instance and another specified string object have the same value regardless of upper and lower case.
    * Parameters: `this string str`, `string value`
    * Example usage:
      ```cs
      string str1 = "BIG";
      string str2 = "big";

      bool match = str1.EqualsIgnoreCase(str2);

      Console.WriteLine(match);
      ```
    * Output:
      ```
      True
      ```  
  * EqualsIgnoreSpaces
    * Description: Determines whether this instance and another specified string object have the same value regardless of spaces.
    * Parameters: `this string str`, `string value`
    * Example usage:
      ```cs
      string str1 = "space";
      string str2 = " s p a c e ";

      bool match = str1.EqualsIgnoreSpaces(str2);

      Console.WriteLine(match);
      ```
    * Output:
      ```
      True
      ```  
  * EqualsIgnoreSpacesAndCase
    * Description: Determines whether this instance and another specified string object have the same value regardless of upper and lower case and spaces.
    * Parameters: `this string str`, `string value`
    * Example usage:
      ```cs
      string str1 = "BIG space";
      string str2 = "big s p a c e ";

      bool match = str1.EqualsIgnoreSpacesAndCase(str2);

      Console.WriteLine(match);
      ```
    * Output:
      ```
      True
      ```
  * ToFileName
    * Description: Determines whether this instance and another specified string object have the same value regardless of upper and lower case and spaces.
    * Parameters: `this string str`, `string value`
    * Example usage:
      ```cs
      string str = "*n*/ /äme";
      string fileName = str.ToFileName();
      Console.WriteLine(fileName);
      ```
    * Output:
      ```
      name
      ```
  * ToPath
    * Description: Determines whether this instance and another specified string object have the same value regardless of upper and lower case and spaces.
    * Parameters: `this string str`, `string value`
    * Example usage:
      ```cs
      string str = "C://goöd   /päth";
      string fileName = str.ToPath();
      Console.WriteLine(fileName);
      ```
    * Output:
      ```
      C://good/path
      ```
### Stone_Red_Utilities.Logging
#### Constructor:
  * Logger
      * Initializes the logger with the default format and a file path.
    * Parameters: `LogTarget logTarg`, `string file`, `string defaultFormat`
    * Example usage:
      ```cs
      Logger logger = new Logger(LogTarget.ConsoleAndFile, "events.log", "{<dateTime>:HH:mm:ss} | {<level>,-7} | {<source>,-15} | {<message>}");
      ```
#### Methods:
  * Log
    * Description: Log the message to the specified output
    * Parameters: `string message`, `string source`, `LogSeverity logSeverity`
    * Example usage:
      ```cs
      logger.Log("something happend", "Update manager", LogSeverity.Error);
      ```
    * Output (Depends on the specified log format):
      ```
      19:15:14 | Error   | Update manager  | something happend
      ```
  * LogIf
    * Description: Log the message to the specified output if the condition is met
    * Parameters: `bool condition`, `string message`, `string source`, `LogSeverity logSeverity`
    * Example usage:
      ```cs
      logger.Log(IsValid(),"something is invalid", "Update manager", LogSeverity.Error);
      ```
    * Output (Depends on the specified log format):
      ```
      19:15:14 | Error   | Update manager  | something happend
      ```
  * ClearLogFile
    * Description: Clears the log file
    * Example usage:
      ```cs
      logger.ClearLogFile();
      ```
