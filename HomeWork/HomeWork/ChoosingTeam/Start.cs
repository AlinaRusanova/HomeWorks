using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.ChoosingTeam
{
    class Start
    {

        public static void StartBuildingTeams()
        {
            Console.Write("Enter the total number of people: ");

            int numberOfMembers = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of teams: ");

            int numberOfTeams = int.Parse(Console.ReadLine());

            decimal maxNumberOfMembersInTeam = Math.Ceiling((decimal)numberOfMembers / (decimal)numberOfTeams);



            var listOfNames = ListOfMembers.GetListOfMembers((int)numberOfMembers);

            var finalTeams = ListOfMembers.GetListOfTeams(listOfNames, numberOfTeams, (int)maxNumberOfMembersInTeam);

            Console.WriteLine();

            for (int i = 0; i < numberOfTeams; i++)
            {
                Console.WriteLine($"On the team № {i + 1}:");

                for (int p = 0; p < finalTeams.Count; p++)
                {
                    if (finalTeams[p]._teamNumber == (i + 1))
                    { Console.WriteLine($"\t {finalTeams[p]._nameMember}"); }
                }
            }
        }
    }
}

