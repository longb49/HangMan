class Loop
{
    static void Main()
    {
        IsOver gameOver = new IsOver();
        Word word = new Word();
        Man status = new Man();
        Loop loop = new Loop();

        List<string> playerstate = status.getPlayerStates();

        int health = 4;

        Console.WriteLine("Please select your difficulty: [easy/medium/hard]");

        string choice = Console.ReadLine() ?? "";

        string gameWord = word.getGenWord(choice);

        List<string> blankWord = word.getWordToUnderscore(gameWord);

        List<string> misses = new List<string>();

        bool isFinished = false;
        
        while(isFinished != true)
        {
           Console.WriteLine(playerstate[health]);
           Console.WriteLine(string.Join("", blankWord));
           Console.WriteLine(string.Join(", ", misses));

           string userGuess = Console.ReadLine() ?? ""; 
           bool result = loop.guessRight(gameWord, userGuess);

           if(result == true)
           {
                List<int> foundIdx = word.findIdx(gameWord, userGuess);
                blankWord = loop.replaceUnArray(blankWord, userGuess, foundIdx);
           }
           else
           {
                health = health - 1;
                misses.Add(userGuess);
           }
           isFinished = gameOver.isDead(health);
           isFinished = gameOver.isFinished(blankWord);
        }
    }
    
    public bool guessRight(string gameWord, string userGuess)
    {
        Word word = new Word();

        if(gameWord.Contains(userGuess) == true)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

   private List<string> replaceUnArray(List<string> blankWord, string userGuess, List<int> foundIdx)
   {
        Word word = new Word();
        foreach (int i in foundIdx)
        {
            blankWord.RemoveAt(i);
            blankWord.Insert(i, userGuess);
        }
        return blankWord;
   }
}