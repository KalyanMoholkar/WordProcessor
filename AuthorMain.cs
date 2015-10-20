using System;


namespace Author
{
    class AuthorMain
    {
        
        static void Main()
        {
            ILogger logger;
            
            //Relocate this dependency to some factory or get it's instance from repository/MEF/UNITY
            logger = new Author.Logger(); 

            try
            {
                
                Console.WriteLine  ("Enter a sentence and press enter to count occurences of word");
                Console.WriteLine("Input:\n--------------------");
                //Enter the sentence
                var line = Console.ReadLine();

                //Check if the sentence is blank
                if (line.Trim().Length <= 0)
                {
                    Console.WriteLine("You have entered blank sentence. Please try again..!");
                    Console.WriteLine("Input:\n--------------------");
                    line = Console.ReadLine();
                }

                //Relocate this dependency to some factory or get it's instance from repository/MEF/UNITY
                IWordProcessor wordProcessor = new WordProcessor();

                //Calculate wordcount
                var dictionary = wordProcessor.CalculateWordCount(line);
  
                //Display wordcount
                wordProcessor.DisplayWordCount(dictionary);

                Console.WriteLine("\nPress enter to exit..");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                logger.WriteLog("Error occured :" + ex.Message);
            }
        }
    }
}
