# Stone_Red-C-Sharp-Utilities

> Adds useful extentions.

## Install
Currently, only guild members with administrator rights can use this bot.

## Namespaces
### Stone_Red_Utilities.ArrListExtentions
#### Methods:
  * Print
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
    * Parameters: `this T[,] array`, `TableStyle tableStyle`
    * Example usage:
      ```cs
      int[,] your2dArray =
      {
          {1,2,3 },
          {4,5,6 },
          {7,8,9 }
      };
      your2dArray.PrintTable();
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
      
### Stone_Red_Utilities.ColorConsole
#### Methods:
  * Write
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
    * Parameters: `object value`, `ConsoleColor color`
    * Example usage:
      ```cs
      ConsoleExt.WriteLine("text in green", ConsoleColor.Green);
      ```
    * Output:
      ```
      text in red

      ```
      (Imagine that the text is actually green)
      
### Stone_Red_Utilities.BoolExtentions
#### Methods:
  * OneWayTrue
    * Parameters: `this ref bool bol`, `bool bol1`
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
    * Parameters: `this ref bool bol`, `bool bol1`
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
### Stone_Red_Utilities.StringExtentions
#### Methods:
  * EqualsIgnoreCase
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
