using System;

class Program
{
    static void Main(string[] args)
    {
        Job micJob = new Job();
        micJob._jobTitle = "Software Engineer";
        micJob._company = "Microsoft";
        micJob._startYear = 2019;
        micJob._endYear = 2022;

        Job appJob = new Job();
        appJob._jobTitle = "Manager";
        appJob._company = "Apple";
        appJob._startYear = 2022;
        appJob._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(micJob);
        myResume._jobs.Add(appJob);

        myResume.Display();
    }
}