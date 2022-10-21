class Man
{
    private List<string> player_states = new List<string>();

    public List<string> getPlayerStates()
    {
        return player_states;
    }
    public int health = 4;

    public Man()
    {
        string line0 = @"^^^^^^^^^";
        string line1 = @"   ___   ";
        string line2 = @"  /___\  ";
        string line3 = @"  \   /  ";
        string line4 = @"   \ /   ";
        string head =  @"    o    ";
        string body =  @"   /|\   ";
        string legs =  @"   / \   ";
        string dead =  @"    x    ";

        player_states.Add($"{dead}\n{body}\n{legs}\n{line0}");
        player_states.Add($"{line4}\n{head}\n{body}\n{legs}\n{line0}");
        player_states.Add($"{line3}\n{line4}\n{head}\n{body}\n{legs}\n{line0}");
        player_states.Add($"{line2}\n{line3}\n{line4}\n{head}\n{body}\n{legs}\n{line0}");
        player_states.Add($"{line1}\n{line2}\n{line3}\n{line4}\n{head}\n{body}\n{legs}\n{line0}");
    }

    private string manState(List<string> player_states, int health)
    {
        return player_states[health];
    }

    public string getManState(List<string> player_states, int health)
    {
        return manState(player_states, health);
    }
}