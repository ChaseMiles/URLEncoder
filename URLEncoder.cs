using System;

namespace URLEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name of the project:");
            string ProjectName = Console.ReadLine();

            System.Web.HttpUtility.UrlEncode(ProjectName);

            Console.WriteLine("Okay, it is {0}", ProjectName);

            Console.WriteLine("What is the name of this activity:");
            string ActivityName = Console.ReadLine();

            Console.WriteLine("Okay, it is {0}", ActivityName);

            String FinalURL = ("https://companyserver.com/content/" + ProjectName + "/files/" + ActivityName + "/" + ActivityName + "Report.pdf");

            Console.WriteLine(FinalURL.Replace(" ", "%20"));

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
