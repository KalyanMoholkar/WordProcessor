using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Author
{
    [TestClass]
    public class UnitTestWordProcessor
    {
        
        [TestMethod]
        public void Validate_WordCount_InSentence()
        {
            //Step1: arrange 
            //test input
            var sentence = "This is a statement, and so is this.";

            //expected output            
            var expectedDictionary=new System.Collections.Generic.Dictionary<string, int> 
            {
                {"this",2},
                {"is", 2},
                {"a", 1},
                {"statement", 1},
                {"and", 1},
                {"so",  1 }
            };
            
            //Step2: act
            //Calculate the word count and store in dictionary
            var outputDictionary = WordProcessor.Calculate_WordCount(sentence);
            
            // Step3: assert 
            //compare expected dictionary and actual dictionary derived from sentence
            Assert.IsTrue(expectedDictionary.SequenceEqual(outputDictionary));
              
        }
    }
}
