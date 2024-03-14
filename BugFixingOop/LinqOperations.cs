using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugFixingOop
{
    public class LinqOperations
    {
        // Assignment: Incorrect `Where` Usage
        public IEnumerable<int> FilterGreaterThanTen(List<int> numbers)
        {
            return numbers.Where(n => n < 10); // Bug: Should filter numbers greater than 10
        }

        // Assignment: Misuse of `Select`
        public IEnumerable<int> DoubleNumbers(List<int> numbers)
        {
            return numbers.Select(n => n); // Bug: Should multiply each number by 2
        }

        //Assignment: You are given a list of Order objects, each with a CustomerId and Amount.
        //The task is to group orders by CustomerId and sum the amounts for each customer.
        //However, the current implementation incorrectly sums the total amount of all orders, not grouping them by customer.

        public Dictionary<int, decimal> SumOrdersByCustomer(List<Order> orders)
        {
            // Buggy implementation: It sums the amounts of all orders without grouping by CustomerId.
            return orders
                .GroupBy(order => order.CustomerId)
                .ToDictionary(group => group.Key, group => orders.Sum(order => order.Amount)); // Bug here
        }

        // Buggy implementation: It incorrectly filters products. It only should return
        // products with a price more than 100
        public IEnumerable<Product> FilterExpensiveProducts(List<Product> products)
        {
            return products.Where(p => p.Price <= 100); 
        }

        // Buggy implementation: Incorrectly extracts properties. It should return the names of employees.
        public IEnumerable<string> ExtractEmployeeNames(List<Employee> employees)
        {
            
            return employees.Select(e => e.Age.ToString()); 
        }

        // Assignment: Misuse of `FirstOrDefault`
        public int? FirstNumberGreaterThanTen(List<int> numbers)
        {
            return numbers.FirstOrDefault(); // Bug: Should return the first number greater than 10 or null
        }

        // Assignment: Incorrect `SingleOrDefault` Usage
        public int? UniqueNumberIsFive(List<int> numbers)
        {
            return numbers.SingleOrDefault(); // Bug: Should return the number if it's exactly 5 and unique
        }
    }

    public class Order
    {
        public int CustomerId { get; set; }
        public decimal Amount { get; set; }
    }

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
