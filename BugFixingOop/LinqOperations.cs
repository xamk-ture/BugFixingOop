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

        //Assignment 3: You are given a list of Order objects, each with a CustomerId and Amount.
        //The task is to group orders by CustomerId and sum the amounts for each customer.
        //However, the current implementation incorrectly sums the total amount of all orders, not grouping them by customer.

        public Dictionary<int, decimal> SumOrdersByCustomer(List<Order> orders)
        {
            // Buggy implementation: It sums the amounts of all orders without grouping by CustomerId.
            return orders
                .GroupBy(order => order.CustomerId)
                .ToDictionary(group => group.Key, group => orders.Sum(order => order.Amount)); // Bug here
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

    public class Order
    {
        public int CustomerId { get; set; }
        public decimal Amount { get; set; }
    }
}
