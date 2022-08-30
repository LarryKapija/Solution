using System;
using System.Collections.Generic;
using Solution.Repos;
using Solution.Repos.Interfaces;
using Solution.Services;
using Solution.Services.Interfaces;
using Solution.Model;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubtypeRepository subtypes = new SubtypeRepository();
            IStatusService service = new StatusService(new TransitionRepository(), new StatusRepository(), subtypes);

            //Getting all the subtypes, to be able to ask for their related states.
            var subtypesCollection = subtypes.GetAll();
            
            //Grouping the subtypes with their states
            var subGroups = new Dictionary<Subtype,IEnumerable<Status>>();

            foreach (var subtype in subtypesCollection)
                subGroups[subtype] = service.GetInitialStatuses(subtype);

            //
            foreach (var subGroup in subGroups)
            {
                Console.WriteLine($"------ Initial {subGroup.Key.Name} Statuses ------");
                Console.WriteLine(String.Join("\n",subGroup.Value));
            }
            Console.ReadLine();
        }
    }
}

