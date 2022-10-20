class Man
{
    private List<string> player_states = new List<string>();
    public int health = 4;

    private Man()
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

    public string getMan(List<string> player_states, int health)
    {
        return player_states[health];
    }
}