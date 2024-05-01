using System;
using System.Collections.Generic;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>(); // Initialize the list

    // Constructor with parameter
    public Resume(string name)
    {
        _name = name;
    }

    // Method to add a job to the resume
    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Iterate through each job in the list
        foreach (Job job in _jobs)
        {
            // Call the Display method on each job
            job.Display();
        }
    }
}
