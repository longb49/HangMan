class Loop
{
    private void Main()
    {
        IsOver gameOver = new IsOver();
        Word word = new Word();

        string? choice = Console.ReadLine() ?? "";
    }
    
    string? userGuess = Console.ReadLine();

   private int compareToArray(string userGuess, string choice, int health)
   {
        Word word = new Word();
        
        int index = Array.IndexOf(word.getWordToArray(choice), userGuess);  

        if( index > -1)
        {
            return index;
        }
        else
        {
            return health - 1;
        }
   }

   private void replaceUnArray()
   {
    
   }


}