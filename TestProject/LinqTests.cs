using BugFixingOop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class LinqOperationsTests
    {
        private readonly LinqOperations _operations = new LinqOperations();

        [Fact]
        public void FilterGreaterThanTen_ReturnsCorrectResults()
        {
            var numbers = new List<int> { 5, 10, 15, 20 };
            var expected = new List<int> { 15, 20 };

            var result = _operations.FilterGreaterThanTen(numbers);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void DoubleNumbers_ReturnsDoubledValues()
        {
            var numbers = new List<int> { 1, 2, 3 };
            var expected = new List<int> { 2, 4, 6 };

            var result = _operations.DoubleNumbers(numbers);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void GroupByFirstLetter_ReturnsGroupsCorrectly()
        {
            var words = new List<string> { "apple", "banana", "apricot", "cherry" };
            // Expected correction will change type to char
            // var expectedGroupCount = 2; // Groups 'a' and 'b'
            // Corrected to reflect expected output after fixing the bug
            var groups = _operations.GroupByFirstLetter(words).ToList();

            // This assertion needs to change to reflect the correct grouping by first letter
            // Assert.Equal(expectedGroupCount, groups.Count(g => g.Key == 'a' || g.Key == 'b'));
            // Placeholder for correct assertion after bug fix
        }

        [Fact]
        public void FirstNumberGreaterThanTen_ReturnsFirstValidNumber()
        {
            var numbers = new List<int> { 5, 10, 15, 20 };
            var expected = 15;

            var result = _operations.FirstNumberGreaterThanTen(numbers);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void UniqueNumberIsFive_ReturnsNumberIfUnique()
        {
            var numbers = new List<int> { 5 };
            var expected = 5;

            var result = _operations.UniqueNumberIsFive(numbers);

            Assert.Equal(expected, result);
        }
    }
}
