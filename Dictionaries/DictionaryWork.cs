using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    public class DictionaryWork
    {
        List<string> _list = new List<string>();

        Dictionary<int, string> _dictionary = new Dictionary<int, string>();

        Dictionary<int, List<string>> _dictionaryTwo = new Dictionary<int, List<string>>();

        Dictionary<int, List<int>> _dictionaryChallenge = new Dictionary<int, List<int>>();

        public int AddDictionaryEntries(int key, int keyTwo)
        {
            int total = 0;

            foreach (KeyValuePair<int, List<int>> value in _dictionaryChallenge)
            {
                if (value.Key == key || value.Key == keyTwo)
                    total = _dictionaryChallenge[key].Sum() + _dictionaryChallenge[keyTwo].Sum();
            }

            return total;
        }

        public Dictionary<int, List<int>> GetDictionary()
        {
            return _dictionaryChallenge;
        }

        public void AddToDictionary(int key, List<int> list)
        {
            _dictionaryChallenge.Add(key, list);
        }

        public void RemoveFromDictionary(int key)
        {
            _dictionaryChallenge.Remove(key);
        }

        public DictionaryWork()
        {
            List<string> list = new List<string>
            {
                "First", "Second", "Third", "Fourth"
            };

            _list.Add("First String");
            _list.Add("Second String");

            string zeroIndex = _list[0];

            _dictionaryTwo.Add(1, list);

            _dictionary.Add(12, "First Value");

            string zeroIndexDictionary = _dictionary[12];

            _dictionary[12] = "my new value";
            _dictionary.Remove(12);

            _dictionaryChallenge.Add(1, new List<int> { 1, 2, 3, 4, 5, 6, 7, 4});
            _dictionaryChallenge.Add(2, new List<int> { 1, 2, 3, 4, 5, 6, 7 });
            _dictionaryChallenge.Add(3, new List<int> { 1, 2, 3, 4, 5, 6, 7 });
            _dictionaryChallenge.Add(4, new List<int> { 1, 2, 3, 4, 5, 6, 7 });

            int sum = _dictionaryChallenge[1].Sum();
        }
    }
}
