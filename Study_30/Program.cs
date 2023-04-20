using System;
using System.Linq;

class Linq
{
    static void Main()
    {
        /*
        int[] numbers = { 1, 2, 3, 3 };

        int sum = numbers.Sum();

        Console.WriteLine(sum);

        int count = numbers.Count();
        Console.WriteLine($"{nameof(count)}, {count}");

        double avg = numbers.Average();
        Console.WriteLine($"{nameof(avg)}, {avg:#,###.##}");

        int max = numbers.Max();
        Console.WriteLine($"{max}");

        var min = numbers.Min();
        Console.WriteLine($"{min:.000}");

        Func<int, bool> isEven = x => x % 2 == 0;
        Console.WriteLine($"{isEven(2)}");

        Action<string> greet = name => { var message = $"Hello {name}"; Console.WriteLine(message); };
        greet("You");
        */

        /*
        int[] numbers = { 1, 2, 3, 4, 5, 6 };
        IEnumerable<int> newNumbers = numbers.Where(number => number > 3);
        foreach ( var n in newNumbers)
        {
            Console.WriteLine(n);
        }

        List<int> newNumbers2 = numbers.Where(number => number > 3).ToList();
        foreach (var n in newNumbers2)
        {
            Console.WriteLine(n);
        }
        */
        //=========================================================
        /*
        var numbers3 = new List<int> { 1, 2, 3 };
        Console.WriteLine(numbers3.Where(number => number % 2 == 0).Sum());
        
        
        int[] numbers = new int[] { 1, 2, 3, 4, 5 };
        var nums = numbers.Where(n => n % 2 == 0 && n > 3);
        foreach ( var i in nums )
        {
            Console.WriteLine(i);
        }
        */

        /*
        bool[] blns = { true, false, true, true, true, true, true };

        Console.WriteLine(blns.Count());
        Console.WriteLine(blns.Count(bln => bln == true));
        Console.WriteLine(blns.Count(bln =>bln == false));

        int[] arr = { 1, 2, 3 };
        bool bin = arr.Any(a => a == 2);
        Console.WriteLine(bin);



        var data = Enumerable.Range(1, 100);
        foreach (var n in data.Take(5))
        {
            Console.WriteLine($"{n}");

        }

        var data2 = Enumerable.Repeat(3, 5);
        var result = data2.Distinct();
   
        foreach (var n in data2.Distinct())
        {
            Console.WriteLine(n);
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();


        string[] colors = { "RED", "BLUE", "YELLOW" };
        IEnumerable<string> soredColors = colors.OrderBy(c => c);
        foreach (var c in soredColors)
        {
            Console.WriteLine(c);
        }

        var sortedColors = colors.OrderByDescending(c => c);
        foreach(var c in sortedColors)
        {
            Console.WriteLine(c);
        }
        */

        /*
        var colors = new List<string> { "Red", "Blue", "Yellow", "Green" };
        var newColors = colors.Where(c => c.Contains("e"));
        foreach (var col in newColors)
        {
            Console.WriteLine(col);
        }


        newColors = colors.Where(c => c.Contains("ee"));
        foreach (var col in newColors)
        {
            Console.WriteLine(col);
        }
        */

        /*
        List<string> colors = new List<string> {"Red", "Blue", "Green" };
        var color = colors.First(c => c == "Red");
        Console.WriteLine(color);
        //var color2 = colors.First(c => c == "Black");
        //Console.WriteLine(color2);

        color = colors.FirstOrDefault(c => c == "Black");
        */

        /*
        var numbers = Enumerable.Range(1, 10);
        foreach ( var n in (from n in numbers where n % 2 == 0 orderby n descending select n).ToList())
        {
            Console.WriteLine(n);
        }
        */

        //=====================================
        /*
        int[] numbers = { 1, 2, 3, 4, 5, 6 };

        
        //메서드 구문
        IEnumerable<int> methodSyntax = numbers.Where(n => n % 2 == 1).OrderBy(n => n);
        foreach ( var n in methodSyntax)
        {
            Console.WriteLine(n);
        }
        //쿼리 구문
        IEnumerable<int> querySyntax = 
            from n in numbers
            where n % 2 == 1
            orderby n
            select n;

        foreach ( var n in querySyntax)
        {
            Console.WriteLine(n);
        }
        */

        var names = new List<string> { "백", "권", "이" };

        var newObjects = names.Select(n => new { Name = n });

        foreach (var name in newObjects)
        {
            Console.WriteLine(name.Name);
        }

        var numbers = new List<int> { 10, 20, 30, 40, 50 };
        numbers.Where(n => n <= 20).ToList().ForEach(n => Console.WriteLine(n));





    }
}