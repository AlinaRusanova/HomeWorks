using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.ChoosingTeam
{
    class TeamMember
    {
        public int _teamNumber { get; set; }
        public string _nameMember { get; set; }
        public TeamMember(string nameMember, int teamNumber = 0)
        {
            _teamNumber = teamNumber;
            _nameMember = nameMember;
        }
    }
}
