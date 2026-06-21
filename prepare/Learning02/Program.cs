using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Space X";
        job1._jobTitle = "Moon Cheese Taster";
        job1._startYear = 2042;
        job1._endYear = 2050;
        // job1.Display();
        
        Job job2 = new Job();
        job2._company = "U.S. Government";
        job2._jobTitle = "Alien Mice Exterminator";
        job2._startYear = 2050;
        job2._endYear = 2060;
        // job2.Display();

        Resume joe_joseph = new Resume();
        joe_joseph._name = "Joe Joseph";
        joe_joseph._jobs.Add(job1);
        joe_joseph._jobs.Add(job2);
        joe_joseph.Display();

        // Console.WriteLine(joe_joseph._jobs[0]._jobTitle);
    }
}