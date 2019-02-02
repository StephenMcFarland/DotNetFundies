using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    public class DictionaryChallenge
    {
        private Dictionary<int, List<int>> _underscore = new Dictionary<int, List<int>>();

        public int GetPairSum(int key)
        {
            int total = 0;

            //List<int> values = _underscore[key];
                                 //show _underscore[key] == our list values 
            foreach (var value in _underscore[key])
            {
                total += value;
            }

            return total;
        }

        public int GetTotalSum()
        {
            int total = 0;
            foreach (KeyValuePair<int, List<int>> pair in _underscore)
            {
                total += GetPairSum(pair.Key);
            }
            return total;
        }

        public Dictionary<int, List<int>> GetDictionary()
        {
            return _underscore;
        }

        public void AddToDictionary(int key, List<int> list)
        {
            _underscore.Add(key, list);
        }

        public void RemoveFromDictionary(int key)
        {
            _underscore.Remove(key);
        }
    }
}
