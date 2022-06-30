using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.ChoosingTeam
{
    class ListOfMembers
    {
        public static string[] GetListOfMembers(int numberOfMembers)
        {
            string[] listOfNames = new string[numberOfMembers];

            Console.WriteLine();
            Console.WriteLine("Enter the names of the members: ");
            Console.WriteLine();

            for (int i = 0; i < listOfNames.Length; i++)
            {
                Console.Write($"Enter the {i + 1}th name: ");
                listOfNames[i] = Console.ReadLine();

            }

            return listOfNames;
        }

        public static List<TeamMember> GetListOfTeams(string[] listOfMembers, int numberOfTeams, int maxNumberOfMembersInTeam)
        {
            List<TeamMember> teams = new List<TeamMember>(listOfMembers.Length);
            List<int> numbers = new List<int>();

            for (int i = 0; i < listOfMembers.Length; i++)
            {

                int tempNumberOfTeam;
                int countMembersInTeam;

                do
                {
                    tempNumberOfTeam = new Random().Next(1, numberOfTeams + 1);  // формируем предварительный номер команды

                    countMembersInTeam = TeamOverflow.CheckTeamNotOverflow(numbers, tempNumberOfTeam);
                }
                while (countMembersInTeam > maxNumberOfMembersInTeam);

                teams.Add(new TeamMember(listOfMembers[i], tempNumberOfTeam));
            }

            return teams.OrderBy(m => m._teamNumber).ToList();
        }
    }
}
