#region task 1
//using System;
//using System.Collections.Generic;
//using System.IO;

//class Solution
//{
//    static void Main(String[] args)
//    {
//        // Declare a variable named 'inputString' to hold our input.
//        String inputString;

//        // Read a full line of input from stdin (cin) and save it to our variable, input_string.
//        inputString = Console.ReadLine();

//        // Print a string literal saying "Hello, World." to stdout using cout.
//        Console.WriteLine("Hello, World.");

//        // TODO: Write a line of code here that prints the contents of input_string to stdout.
//    }
//} 
#endregion

#region task 2

//using System;
//using System.Collections.Generic;
//using System.IO;

//class Solution
//{
//    static void Main(String[] args)
//    {
//        int i = 4;
//        double d = 4.0;
//        string s = "HackerRank ";
//        int x = Convert.ToInt32(Console.ReadLine());
//        double y = Convert.ToDouble(Console.ReadLine());
//        string str = Console.ReadLine();
//        System.Console.WriteLine(x + i);
//        System.Console.WriteLine("{0:.0}", (y + d));
//        System.Console.WriteLine(s + str);
//    }
//} 
#endregion

#region task 3
//using System.CodeDom.Compiler;
//using System.Collections.Generic;
//using System.Collections;
//using System.ComponentModel;
//using System.Diagnostics.CodeAnalysis;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.Serialization;
//using System.Text.RegularExpressions;
//using System.Text;
//using System;
//using static System.Console;
//class Result
//{

//    /*
//     * Complete the 'solve' function below.
//     *
//     * The function accepts following parameters:
//     *  1. DOUBLE meal_cost
//     *  2. INTEGER tip_percent
//     *  3. INTEGER tax_percent
//     */

//    // public static void solve(double meal_cost, int tip_percent, int tax_percent)
//    // {
//    //     double tip;
//    //     tip=tip_percent * meal_cost /100;
//    //     double tax;
//    //     tax=tax_percent * meal_cost /100;
//    //     double total=Math.Round(meal_cost+tax+tip);
//    //     WriteLine(total);
//    // }

//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        //WriteLine("Enter meal_cost ");
//        double meal_cost = Convert.ToDouble(ReadLine());
//        //WriteLine("Enter tip_percent ");
//        int tip_percent = Convert.ToInt32(ReadLine());
//        //WriteLine("Enter tax_percent ");
//        int tax_percent = Convert.ToInt32(ReadLine());

//        double tip;
//        tip = tip_percent * meal_cost / 100;
//        double tax;
//        tax = tax_percent * meal_cost / 100;
//        double total = Math.Round(meal_cost + tax + tip);
//        WriteLine(total);

//    }
//}

#endregion

#region task 4
//using System.CodeDom.Compiler;
//using System.Collections.Generic;
//using System.Collections;
//using System.ComponentModel;
//using System.Diagnostics.CodeAnalysis;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.Serialization;
//using System.Text.RegularExpressions;
//using System.Text;
//using System;
//using static System.Console;



//class Solution
//{
//    public static void Main(string[] args)
//    {
//        int N = Convert.ToInt32(ReadLine());
//        if (N % 2 == 0 && N < 6)
//        {
//            WriteLine("Not Weird");
//        }
//        else if (N % 2 == 0 && N < 20)
//        {
//            WriteLine("Weird");
//        }
//        else if (N % 2 == 0 && N > 20)
//        {
//            WriteLine("Not Weird");
//        }
//        else
//        {
//            WriteLine("Weird");
//        }
//    }
//}

#endregion

#region task 5
//using System;
//using System.Collections.Generic;
//using System.IO;
//using static System.Console;
//class Person
//{
//    public int age;
//    public Person(int initialAge)
//    {
//        // Add some more code to run some checks on initialAge
//        if (initialAge >= 0)
//            this.age = initialAge;
//        else
//        {
//            this.age = 0;
//            WriteLine("Age is not valid, setting age to 0.");
//        }
//    }
//    public void amIOld()
//    {
//        if (age < 13)
//            WriteLine("You are young.");
//        else if (age >= 13 && age < 18)
//            WriteLine("You are a teenager.");
//        else
//            WriteLine("You are old.");

//    }

//    public void yearPasses()
//    {
//        age++;
//    }
//    static void Main(String[] args)
//    {
//        int T = int.Parse(Console.In.ReadLine());
//        for (int i = 0; i < T; i++)
//        {
//            int age = int.Parse(Console.In.ReadLine());
//            Person p = new Person(age);
//            p.amIOld();
//            for (int j = 0; j < 3; j++)
//            {
//                p.yearPasses();
//            }
//            p.amIOld();
//            Console.WriteLine();
//        }
//    }
//} 
#endregion

#region task 6
//using System.CodeDom.Compiler;
//using System.Collections.Generic;
//using System.Collections;
//using System.ComponentModel;
//using System.Diagnostics.CodeAnalysis;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.Serialization;
//using System.Text.RegularExpressions;
//using System.Text;
//using System;
//using static System.Console;


//class Solution
//{
//    public static void Main(string[] args)
//    {
//        int n = Convert.ToInt32(ReadLine());
//        for (int i = 1; i <= 10; i++)
//        {
//            WriteLine($"{n} x {i} = " + n * i);

//        }
//    }
//}

#endregion

#region task 7
//using System;
//using static System.Console;
//class Solution
//{
//    static void Main(String[] args)
//    {
//        int N = int.Parse(ReadLine());

//        for (int i = 0; i < N; i++)
//        {
//            string str = ReadLine();

//            for (int j = 0; j < str.Length; j++)
//            {
//                if (j % 2 == 0)
//                    Write(str[j]);
//            }

//            Write(" ");

//            for (int j = 0; j < str.Length; j++)
//            {
//                if (j % 2 != 0)
//                    Write(str[j]);
//            }

//            Console.Write(Environment.NewLine);
//        }
//    }
//}
#endregion

#region task 8
//using System.CodeDom.Compiler;
//using System.Collections.Generic;
//using System.Collections;
//using System.ComponentModel;
//using System.Diagnostics.CodeAnalysis;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.Serialization;
//using System.Text.RegularExpressions;
//using System.Text;
//using System;
//using static System.Console;


//class Solution
//{
//    public static void Main(string[] args)
//    {
//        int n = Convert.ToInt32(ReadLine());
//        int[] a =new int[n];
//        for(int i=0; i < a.Length; i++)
//        {
//            a[i] = Convert.ToInt32(ReadLine());
//            Array.Reverse(a);
//        }
//        for (int i = 0; i < a.Length ; i++)
//        {
//            Console.ForegroundColor = ConsoleColor.Cyan;
//            Console.Write(a[i]);
//        }

//    }
//}
////////////////////////////////////////
///the best solution
///using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//class Solution
//{

//    static void Main(String[] args)
//    {
//        int n = Convert.ToInt32(Console.ReadLine());
//        string[] temp = Console.ReadLine().Split(' ');
//        int[] a = Array.ConvertAll(temp, Int32.Parse);

//        for (var i = n - 1; i > -1; i--)
//        {
//            Console.Write(a[i] + " ");
//        }
//    }
//}
#endregion

#region taks 9 
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using static System.Console;
//class Solution
//{
//    static void Main()
//    {
//        int N = Int32.Parse(ReadLine());
//        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
//        for (int i = 0; i < N; i++)
//        {
//            string[] L = ReadLine().Split(' ');
//            phoneBook[L[0]] = L[1];
//        }

//        string Query;
//        while ((Query = ReadLine()) != null)
//        {
//            if (phoneBook.ContainsKey(Query))
//            {
//                WriteLine(Query + "=" + phoneBook[Query]);
//            }
//            else
//            {
//                WriteLine("Not found");
//            }
//        }
//    }
//}
#endregion

#region Task 10
//using System.CodeDom.Compiler;
//using System.Collections.Generic;
//using System.Collections;
//using System.ComponentModel;
//using System.Diagnostics.CodeAnalysis;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.Serialization;
//using System.Text.RegularExpressions;
//using System.Text;
//using System;
//using static System.Console;
//class Result
//{
//    static void Main(String[] args)
//    {
//        int num = Int32.Parse(ReadLine());
//        int Temp = factorial(num);
//        WriteLine(Temp);

//    }

//    public static int factorial(int num)
//    {
//        if (num == 1)
//        {
//            return 1;
//        }
//        else
//        {
//            return (num * factorial(num - 1));
//        }
//    }
//}

#endregion

#region task 11
//using System.CodeDom.Compiler;
//using System.Collections.Generic;
//using System.Collections;
//using System.ComponentModel;
//using System.Diagnostics.CodeAnalysis;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.Serialization;
//using System.Text.RegularExpressions;
//using System.Text;
//using System;



//class Solution
//{
//    public static void Main(string[] args)
//    {
//        int n = Convert.ToInt32(Console.ReadLine().Trim());
//        var Max = 0;
//        var Count = 0;
//        while (n > 0)
//        {
//            if (n % 2 == 1)
//            {
//                Count++;

//                if (Count > Max)
//                {
//                    Max = Count;
//                }
//            }
//            else
//            {
//                Count = 0;
//            }
//            n = n / 2;
//        }
//        Console.WriteLine(Max);
//    }
//}

#endregion

#region task 12
//using System.CodeDom.Compiler;
//using System.Collections.Generic;
//using System.Collections;
//using System.ComponentModel;
//using System.Diagnostics.CodeAnalysis;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.Serialization;
//using System.Text.RegularExpressions;
//using System.Text;
//using System;



//class Solution
//{
//    public static void Main(string[] args)
//    {

//        int[][] arr = new int[6][];

//        for (int i = 0; i < 6; i++)
//        {
//            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
//        }

//        int[] sum = new int[16];
//        int hourglass = 0;
//        for (int i = 0; i < 4; i++)
//        {
//            for (int j = 0; j < 4; j++)
//            {
//                sum[hourglass] =
//                          arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
//                        + arr[i + 1][j + 1]
//                        + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
//                hourglass++;
//            }
//        }
//        Array.Sort(sum);
//        Console.WriteLine(sum[15]);
//    }
//}

#endregion //this isn't my code 
