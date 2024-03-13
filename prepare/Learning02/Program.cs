using System;
using System.Runtime;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Learning02 World!");
//     }
// }


class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._companyName = "Aguia Cyber";
        job1._jobTitle = "Maneger";
        job1._startYear = 2011;
        job1._endYear = 2012;


        Job job2 = new Job();
        job2._companyName = "GOL";
        job2._jobTitle = "Attendent";
        job2._startYear = 2014;
        job2._endYear = 2015;

        Resume myResume = new Resume();
        myResume._name = "Douglas Santos";

        myResume._jobList.Add(job1);
        myResume._jobList.Add(job2);

        myResume.Display();
    }
}