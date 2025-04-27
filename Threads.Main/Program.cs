using Threads;

Random rand = new Random();
RecentNumbers recentNumbers = new RecentNumbers{ RecentNum1 = -1, RecentNum2 = -2 };
Thread generation = new Thread(loopForever);
generation.Start(recentNumbers);


while(true)
{
    Console.ReadKey(false);

    bool isDuplicate;
    lock(recentNumbers)
    {
        isDuplicate = recentNumbers.RecentNum1 == recentNumbers.RecentNum2;
    }
    if(isDuplicate)
    {
        Console.WriteLine("You found a duplicate!");
    }else
    {
        Console.WriteLine("That is not a duplicate.");
    }
}


void loopForever(object? o)
{
    if(o == null || o is not RecentNumbers) return;

    RecentNumbers recentNumbers = (RecentNumbers)o;
    while(true)
    {
        int nextNumber = rand.Next(0, 10);

        lock (recentNumbers)
        {
            recentNumbers.RecentNum2 = recentNumbers.RecentNum1;
            recentNumbers.RecentNum1 = nextNumber;
        }
        Console.WriteLine(nextNumber);
        Thread.Sleep(1000);
    }
}

