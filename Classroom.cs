namespace knightmoves;

public class Classroom{

    public HashSet<string> CreateTeam(string first, string second, string third){
        HashSet<string> team = new HashSet<string>();
            team.Add(first);
            team.Add(second);
            team.Add(third);
        
        return team;
    }
}
