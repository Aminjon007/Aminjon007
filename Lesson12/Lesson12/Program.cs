using System.Threading.Channels;

namespace Lesson;

internal abstract class Program
{
    private static SemaphoreSlim semaphore = new SemaphoreSlim(1,2);

    static async Task  Main()
    {
        Task task1 = Task.Run(() => PrintNums());
        Task task2 = Task.Run(() => PrintNums());
        Task task3 = Task.Run(() => PrintNums());
        Task task4 = Task.Run(() => PrintNums());
        Task task5 = Task.Run(() => PrintNums());
        await Task.WhenAll(task1, task2, task3, task4, task5);
        Console.WriteLine("Potoc os over.");
    }
    
    // private static async Task Main()
    // {
    //     for (int j = 0; j < 5; j++)
    //     {
    //         int taskId = j;
    //         Task.Run(()=>AccossResourceAsync(taskId));
    //     }
    //     await Task.Delay(5000);
    // }
    

    // static async Task AccossResourceAsync(int taskId)
    // {
    //     Console.WriteLine($"Task {taskId} is waiting for access to complete... ");
    //     await semaphore.WaitAsync();
    //     try
    //     {
    //         Console.WriteLine($"Task {taskId} has got access to task");
    //         await Task.Delay(2000);
    //     }
    //     finally
    //     {
    //         Console.WriteLine($"Task {taskId} make task complete");
    //         semaphore.Release();
    //         
    //     }
    // }

    static  void PrintNums()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }
            
        
    }
    
}