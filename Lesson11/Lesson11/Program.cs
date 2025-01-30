namespace Lesson11;

class Program
{
    static void Main(string[] args)
    { 
        void DZ_1()
        {
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                if (age < 18 || age > 65)
                {
                    throw new ArgumentOutOfRangeException("invalid age");
                }

                string name = Console.ReadLine();
                int salary = Convert.ToInt32(Console.ReadLine());
                if (salary <= 0)
                {
                    throw new ArgumentException("invalid money");
                }

                Console.WriteLine($"Hello, {name}. You are {age} years old.");
            }
            catch (ArgumentNullException e){
                Console.WriteLine("Null reference exception");
            }
        }

        void DZ_2()
        {
            Worker[] workers =
            [
                new Worker("Alex",21,2345),
            new Worker("Tom",27,1200),
            new Worker("Jack",21,2345),
            new Worker("Jill",20,1345),
            new Worker("James",24,2005),
            new Worker("Jackson",15,1230)
            ];
            List<Worker> trueWorkers = new List<Worker>();
 
            foreach (var worker in workers)
            {
                if (worker.Age < 18)
                {
                     throw new InvalidAgeExeption("invalid age");
                    
                }

                if (worker.Salary<=0)
                {
                    throw new InvalidSalaryExeption("invalid salary");
                }
                trueWorkers.Add(worker);
                
            }

            foreach (var worker in trueWorkers)
            {
                Console.WriteLine($"{worker.Name}, {worker.Age}, {worker.Salary}");
            }
        }
    }
}

class InvalidAgeExeption(string massage) : Exception(massage){}
class InvalidSalaryExeption(string massage) : Exception(massage){}

class Worker(string name, int age, int salary)
{
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;
    public int Salary { get; set; } = salary;
}