using System;

public class Job
{
    public string JobTitle { get; private set; }
    public string Company { get; private set; }
    public int StartYear { get; private set; }
    public int EndYear { get; private set; }

    // Constructor
    public Job(string jobTitle, string company, int startYear, int endYear)
    {
        JobTitle = jobTitle;
        StartYear = startYear;
        EndYear = endYear;
    }

    // Display method
    public void Display()
    {
        Console.WriteLine($"{JobTitle} ({Company}) {StartYear}-{EndYear}");
    }
}
