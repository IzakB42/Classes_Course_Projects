using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string name = "Doctor Strange";
        string topic = "Physics";
        Assignment a1 = new Assignment(name, topic);
        Console.WriteLine(a1.GetSummary());

        string section = "9.42";
        string problems = "8_19";
        MathAssignment math1 = new MathAssignment(name, topic, section, problems);
        
        Console.WriteLine();
    }
}