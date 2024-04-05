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

        [Fact]
        public void SumOrdersByCustomer_CorrectlySumsAmountsByCustomer()
        {
            // Setup
            var orders = new List<Order>
            {
                new Order { CustomerId = 1, Amount = 100m },
                new Order { CustomerId = 2, Amount = 150m },
                new Order { CustomerId = 1, Amount = 50m },
                new Order { CustomerId = 2, Amount = 100m }
            };
            
            var expectedSums = new Dictionary<int, decimal>
            {
                { 1, 150m },
                { 2, 250m }
            };


            // Act
            var result = _operations.SumOrdersByCustomer(orders);

            // Assert
            Assert.Equal(expectedSums.Count, result.Count);
            foreach (var expectedSum in expectedSums)
            {
                decimal actualSum;
                Assert.True(result.TryGetValue(expectedSum.Key, out actualSum));
                Assert.Equal(expectedSum.Value, actualSum);
            }
        }

        [Fact]
        public void FilterExpensiveProducts_ReturnsCorrectResults()
        {
            var products = new List<Product>
            {
                new Product { Name = "Laptop", Price = 1200m },
                new Product { Name = "Mouse", Price = 25m },
                new Product { Name = "Keyboard", Price = 150m }
            };

            var result = _operations.FilterExpensiveProducts(products);

            Assert.Equal(2, result.Count());
            Assert.DoesNotContain(result, p => p.Price <= 100);
        }

        [Fact]
        public void ExtractEmployeeNames_ReturnsOnlyNames()
        {
            var employees = new List<LinqEmployee>
            {
                new LinqEmployee { Name = "John Doe", Age = 30 },
                new LinqEmployee { Name = "Jane Smith", Age = 25 }
            };

            var result = _operations.ExtractEmployeeNames(employees);

            Assert.Equal(employees.Select(e => e.Name), result);
        }
    }
}
