using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugFixingOop
{
    public class LinqOperations
    {
        // Assignment 1: Incorrect `Where` Usage
        public IEnumerable<int> FilterGreaterThanTen(List<int> numbers)
        {
            return numbers.Where(n => n < 10); // Bug: Should filter numbers greater than 10
        }

        // Assignment 2: Misuse of `Select`
        public IEnumerable<int> DoubleNumbers(List<int> numbers)
        {
            return numbers.Select(n => n); // Bug: Should multiply each number by 2
        }

        // Assignment 3: Incorrect `GroupBy` Usage
        public IEnumerable<IGrouping<char, string>> GroupByFirstLetter(List<string> words)
        {
            return words.GroupBy(word => word.Length); // Bug: Should group by the first character
        }

        // Assignment 4: Misuse of `FirstOrDefault`
        public int? FirstNumberGreaterThanTen(List<int> numbers)
        {
            return numbers.FirstOrDefault(); // Bug: Should return the first number greater than 10 or null
        }

        // Assignment 5: Incorrect `SingleOrDefault` Usage
        public int? UniqueNumberIsFive(List<int> numbers)
        {
            return numbers.SingleOrDefault(); // Bug: Should return the number if it's exactly 5 and unique
        }
    }
}
