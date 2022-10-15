class Library
{
    private List<string> library = new List<string>
    {
        "Actor",
        "Advertisement",
        "Afternoon",
        "Airport",
        "Ambulance",
        "Animal",
        "Answer",
        "Apple",
        "Army",
        "Australia",
    };

    private string randomWord(List<string> library)
    {
        var rand = new Random();
        string word = library[rand.Next(library.Count)];
        return word;
    }

    public string getWord(string difficulty) // Difficulty requires a string of either "easy", "medium", or "hard"
    {
        string word = "";
        if (difficulty == "easy")
        {
            while (word == "")
            {
                string word0 = randomWord(library);
                if (word0.Length < 5)
                {
                    word = word0;
                }
                else
                {
                    word = "";
                }
            }
        }
        else if (difficulty == "medium")
        {
            while (word == "")
            {
                string word0 = randomWord(library);
                if (5 <= word0.Length && word0.Length < 7)
                {
                    word = word0;
                }
                else
                {
                    word = "";
                }
            }
        }
        else if (difficulty == "hard")
        {
            while (word == "")
            {
                string word0 = randomWord(library);
                if (7 <= word0.Length)
                {
                    word = word0;
                }
                else
                {
                    word = "";
                }
            }
        }
        return word;
    }
}