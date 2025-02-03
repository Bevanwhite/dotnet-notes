#### section 1.1 - creating console application

```
public class Program
{
    public static void Main()
    {
        // Prints a message to the console.
        System.Console.WriteLine("Hello, World!");

        /* Wait for the user to press a key. This is a common
        way to prevent the console window from terminating
        and disappearing before the programmer can see the contents
        of the window, when the application is run via Start from within VS. */

        System.Console.ReadKey();
    }
}

```

Explanation

- **class**

  - program is a class declaration.
  - the class program contains the data and method definitions that your program uses.
  - Classes generally contain multiple methods.
  - Methods define the behavior of the class
  - however, the program class has only one main method: Main.

- **static void Main()**

  - defines the main method
  - which is the entry point for allC# programs.
  - The main method states what the class does when executed.
  - Only Main method is allowed per class.

- **Console.WriteLine("Hello, World!");**

  - method prints a given data as an output in the console window.

- **Console.ReadKey()**
  - ensures that the program won't close immediately after displaying the message.
  - It does this by waiting for the user to press a key on the keyboard.
  - Any key press from the user will terminate the program.
  - the program terminates when it has finished the last line of code in the main() method.

#### 2 - Verbatim Strings

2.1 Interpolated verbatim strings

- can be combined with the new string interpolation features found in C#6
- the backslash are ignored as escape characters.
- any expression inside curly braces is evaluated before being inserted into the string at that position

```
Console.WriteLine($@"Testing \n 1 2 {5-2}
New line");
```

2.2 Esacaping Double Quotes

- double quotes inside verbatim strings can be escaped bt using 2 sequential
  double quotes "" to represent one double qoute in the resulting string.

```
var str = @"""I don't think so,"" he said.";
Console.WriteLine(str);
```

output comes as

```
"I don't think so," he said.
```

2.3 verbatim strings instruct the compiler to not use character escapes

- In verbatim strings, there are no character escapes.
- To use a verbatim string just prepend a @ before the starting quotes.
- only escape characters in verbatim strings are "" which is turned into a ".

`var filename = @"c:\temp\newfile.txt";`

_output_ - `c:\temp\newfile.txt`

without verbatim strings

- in a normal string, the backslash character is the escape character,
- which instructs the complier to look at the next characters to determine
  the actual characterin the string.

`var filename = "c:\temp\newfile.txt";`

output -

```
c:    emp
ewfile.txt
```

2.4 Multiline strings

- Multiline strings that contain double quotes can also be escaped just as they
  were on a single line, because they are verbatim strings.
- the spaces/tabulations at the start of line 2 and 3 are actually present
  in the value of the variable
