using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {

            List<IBeruf> jobs = new List<IBeruf>();            
            var createTask = CreateJobs(jobs);
            var calcTask = CalculateJobs(jobs);

            Task<string> a = Query();

            Console.WriteLine("Start continuewith ...");

            a.ContinueWith(t => Console.WriteLine("QUERY RESULT: {0}", t.Result));

            Console.WriteLine("doing something else ...");
            Console.ReadLine();            
        }


        public static Task<string> Query() {

            Console.WriteLine("START QUERY TASK...");

            Task.Delay(TimeSpan.FromSeconds(1.0)).Wait();

            return new Task<string>( () => "----------- QUERY READY ------------");
        }

        public static Task<bool> TimeOut()
        {
            return Task.Run(() =>
            {
                for (var i = 0; i < 2; i++)
                {
                    Task.Delay(TimeSpan.FromSeconds(0.5)).Wait();
                }

                return true;

            });
        }

        public static async Task CreateJobs(List<IBeruf> jobs)
        {
            var random = new Random();
            var name = String.Empty;
            var salary = 0;

            for (var i = 0; i < Int16.MaxValue; i++) {

                name = String.Format("Beruf_{0}", i.ToString());
                salary = random.Next(100000, 1000000);
                
                Console.WriteLine("[P] Create new job: {0} Salary: {1}", name, salary.ToString());

                jobs.Add(new Beruf(name, (uint)salary));

                if (await TimeOut()) Console.WriteLine($"[P] New job created");
            }
        }

        public static async Task CalculateJobs(List<IBeruf> jobs)
        {
            for (var i = 0; i < Int16.MaxValue; i++)
            {

                Console.WriteLine($"[T] Calculation jobs");
                
                if (await TimeOut()) Console.WriteLine("[T] {0} jobs found. [jobs: {1}]", (jobs.Count != 0 ? "" : "No ") , jobs.Count);
            }
        }
    }
}
