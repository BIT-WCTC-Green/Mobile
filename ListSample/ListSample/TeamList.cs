using System;
using System.Collections.ObjectModel;

namespace ListSample
{
    public class TeamList
    {
        public ObservableCollection<Team> Teams = new ObservableCollection<Team>();
        public TeamList()
        {
            Teams.Add(new Team { Mascot = "Rams" });
            Teams.Add(new Team { Mascot = "Seahawks" });
            Teams.Add(new Team { Mascot = "Cardinals" });
            Teams.Add(new Team { Mascot = "49ers" });

        }

        public ObservableCollection<Team> getTeamList() {
            return Teams;
        }

 
    }
}
