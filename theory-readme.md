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
