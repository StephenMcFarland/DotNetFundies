using System;
using System.Collections.Generic;
using System.Linq;
using Dictionaries;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Value_Types
{
    [TestClass]
    public class Dictionary
    {
        [TestMethod]
        public void DictionaryWork_AddSumOfIntList_ShouldBeCorrectValue()
        {
            DictionaryWork dictionaryWork = new DictionaryWork();
            Dictionary<int, List<int>> _dictionaryChallenge = dictionaryWork.GetDictionary();

            int actual = dictionaryWork.;
            int expected = 60;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DictionaryWork_AddToDictionary_ShouldBeCorrectCount()
        {
            DictionaryWork dictionaryWork = new DictionaryWork();
            Dictionary<int, List<int>> _dictionaryChallenge = dictionaryWork.GetDictionary();

            int actual = _dictionaryChallenge.Count;
            int expected = 4;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DictionaryWork_RemoveToDictionary_ShouldBeCorrectCount()
        {
            DictionaryChallenge dictionaryWork = new DictionaryChallenge();
            Dictionary<int, List<int>> _dictionaryChallenge = dictionaryWork.GetDictionary();
             
            int actual = _dictionaryChallenge.Count;
            int expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DictionaryWork_AddTwoDictionaryEntries_ShouldBeCorrectSum()
        {
            DictionaryWork dictionaryWork = new DictionaryWork();
            
            int actual = dictionaryWork.AddDictionaryEntries(1, 3);
            int expected = 60;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DictionaryChallenge_SumOfOneValue_ShouldBeCorrectSum()
        {
            DictionaryChallenge dC = new DictionaryChallenge();
            Dictionary<int, List<int>> dictionary = dC.GetDictionary();

            dictionary.Add(12, new List<int> { 3, 1, 4, 1, 5, 9, 2 });
            int actual = dC.GetPairSum(12);
            int expected = 25;

            Assert.AreEqual(expected, actual);
        }
    }
}
