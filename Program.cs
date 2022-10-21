class Loop
{
    static void Main()
    {
        IsOver gameOver = new IsOver();
        Word word = new Word();
        Man status = new Man();

        List<string> playerstate = status.getPlayerStates();

        int health = 4;

        string choice = Console.ReadLine() ?? "";

        string gameWord = word.getGenWord(choice);

        List<string> blankWord = word.getWordToUnderscore(choice);

        bool isFinished = gameOver.isFinished(blankWord);
        
        while(isFinished != true)
        {
           Console.WriteLine(status.getManState(playerstate, health));

           string userGuess = Console.ReadLine() ?? ""; 

           if(guessRight(gameWord, userGuess) == true)
           {
                replaceUnArray(gameWord, userGuess);
           }
           else
           {
                status.health = status.health - 1;
           }
        }
    }
    
    

//    public int wasRight(List<int> unList)
//    {
//         if (unList.Count == 0)
//         {
//             // REMIND BEN TO FINISH THIS
//         }

//    }
    private bool guessRight(string gameWord, string userGuess)
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

   private void replaceUnArray(string gameWord, string userGuess)
   {
        Word word = new Word();
        var unList = word.getWordToUnderscore(gameWord);
        foreach(int i in word.findIdx(gameWord, userGuess))
        {
            unList[i] = userGuess;
        }
   }


}