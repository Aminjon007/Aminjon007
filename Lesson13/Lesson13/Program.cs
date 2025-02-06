using System;
namespace Lesson13;

class Program
{
    static void Main(string[] args)
    {

        List<Person> people = new List<Person>()
        {
            new Person { Name = "Tom", Age = 18 },
            new Person { Name = "Bob", Age = 19 },
            new Person { Name = "Jill", Age = 20 },
            new Person { Name = "Mary", Age = 21 },
            new Person { Name = "Sam", Age = 22 },
            new Person { Name = "James", Age = 23 },
            new Person { Name = "Jackson", Age = 24 },
            new Person { Name = "Bill", Age = 25 },
        };
        
        var personNameB= people.Where(p => p.Name.StartsWith("B"));
        Console.WriteLine("Names starting with 'B':");
        foreach (var person in personNameB)
        {
            Console.WriteLine(person.Name);
        }
        var personNameFive= people.LastOrDefault(p=>p.Name.Length>5);
        Console.WriteLine("Names char > 5:");
        Console.WriteLine(personNameFive.Name);

        List<Order> orders = new List<Order>()
        {
            new Order{OrderId = 1,CutomerName = "Tom",Amount = 200},
            new Order{OrderId = 2,CutomerName = "Bob",Amount = 300},
            new Order{OrderId = 3,CutomerName = "Jill",Amount = 400},
            new Order{OrderId = 4,CutomerName = "Mary",Amount = 500},
            new Order{OrderId = 5,CutomerName = "Sam",Amount = 600},
            new Order{OrderId = 6,CutomerName = "James",Amount = 700},
            new Order{OrderId = 7,CutomerName = "Jackson",Amount = 800}
            
        };

        int sum = 0;
        foreach (var or in orders)
        {
            sum+=or.Amount;
        }

        Console.WriteLine("Sum is: "+sum);
        
        var OrderFive= orders.Where(o=>o.Amount>500);
        Console.WriteLine("Orders Amount>500");
        foreach (var or in OrderFive)
        {
            Console.WriteLine($"{or.CutomerName}, {or.Amount}, {or.OrderId}");
        }


    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Order
{
    public int OrderId { get; set; }
    public string CutomerName { get; set; }
    public int Amount { get; set; }     
}