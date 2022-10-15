class Library
{
    private List<string> library = new List<string>
    {
        "Apple",
        "Cat",
        "Dragon",
        "Hero",
        "King"
    };

    public string randomWord(List<string> library)
    {
        var rand = new Random();
        string word = library[rand.Next(library.Count)];
        return word;
    }
}