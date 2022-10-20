public class Word
{
   // Gets a word from the library and creates a dash for each letter// 
   Library wordlist = new Library();
   
   // Gets a word from the word list based on the difficulty choice //
   private string genWord(string choice)
   {
      string word = wordlist.getWord(choice);

      return word;
   }

   // Makes a public reference to genWord //
   public string getGenWord(string choice)
   {
      return genWord(choice);
   }

   // Gets the length of the word as an integer //
   private int wordLength(string choice)
   {
      return getGenWord(choice).Length;
   }
   
   // Makes a public reference to wordLength //
   public int getWordLength(string choice)
   {
      return wordLength(choice);
   }

   //BELOW ARE THE PREVIOUS METHODS
   // Turns the word into an array //
   // private char[] wordToArray(string choice)
   // {
   //    char[] wArray = new char[getWordLength(choice)];

   //    for (int i = 0; i < getWordLength(choice); i++) 
   //    { 
   //          wArray[i] = getGenWord(choice)[i]; 
   //    } 

   //    return wArray; 
   // }

   // // Makes a public reference to wordToArray //
   // public char[] getWordToArray(string choice)
   // {
   //    return wordToArray(choice);
   // }
   // BEFORE IS THE PREVIOUS METHODS

   // Creates an array of underscores the length of the word //
   private List<string> wordToUnderscore(string choice)
   {
      List<string> unArray = new List<string>();

      for (int i = 0; i < getWordLength(choice); i++) 
      { 
            unArray[i] = "_"; 
      } 

      return unArray;
   }

   // Makes a public reference to wordToUnderscore //
   public List<string> getWordToUnderscore(string choice)
   {
      return wordToUnderscore(choice);
   }

   public List<int> findIdx(string word, string guess)
   {
      var foundIdx = new List<int>();
      for (int i = word.IndexOf(guess); i > -1; i = word.IndexOf(guess, i++))
      {
         foundIdx.Add(i);
      }
      return foundIdx;
   }






}