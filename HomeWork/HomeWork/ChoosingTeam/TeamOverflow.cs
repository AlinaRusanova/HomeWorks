using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.ChoosingTeam
{
    class TeamOverflow
    {
        public static int CheckTeamNotOverflow(List<int> _numbers, int tempNumber)
        {
            _numbers.Add(tempNumber);

            int count = 0;
            foreach (var number in _numbers)
            {
                if (number == tempNumber)
                { count++; }
            }

            return count;

        }
    }
}
