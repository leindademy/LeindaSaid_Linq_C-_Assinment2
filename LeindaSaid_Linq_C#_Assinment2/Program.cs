using System.Collections;
using System.Collections.Generic;
using System.Threading;
using static LeindaSaid_Linq_C__Assinment2.ListGenerator;
namespace LeindaSaid_Linq_C__Assinment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region( LINQ - Element Operators ) 1
            #region ques_1 
            // 1. Get first Product out of Stock 
            //var FirstProductOutOfStock = ProductList.FirstOrDefault (product => product.UnitsInStock == 0);

            //if (FirstProductOutOfStock != null)
            //    {
            //        Console.WriteLine($"First product out of stock: {FirstProductOutOfStock.ProductName}");
            //    }
            //else
            //    {
            //        Console.WriteLine("No products are out of stock.");
            //    }


            #endregion

            #region ques_2
            // 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var FirstProductPriceGreaterThan1000 = ProductList.FirstOrDefault(product => product.UnitPrice >1000);

            // if (FirstProductPriceGreaterThan1000 != null)
            //    {
            //        Console.WriteLine($"First product price greater than 1000: {FirstProductPriceGreaterThan1000.ProductName}");
            //    }
            //else
            //    {
            //        Console.WriteLine("Not greater than 1000.");
            //    }

            #endregion

            #region ques_3
            // 3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var SecondnumberGreaterThan5 = Arr.Where(number => number > 5);
            // if (SecondnumberGreaterThan5 != null)
            // {
            //     Console.WriteLine($"Second number greater than 5: {SecondnumberGreaterThan5}");
            // }
            // else
            // {
            //     Console.WriteLine("Not number greater than 5.");
            // }



            #endregion
            #endregion

            #region (LINQ - Aggregate Operators) 2

            #region ques_1
            // 1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var CountOfOddNumbers = Arr.Count(number => number % 2 == 1);
            //Console.WriteLine($"Count of odd numbers: {CountOfOddNumbers}");

            //if (CountOfOddNumbers > 0)
            //    {
            //        Console.WriteLine("There are odd numbers");
            //    }
            //else
            //    {
            //        Console.WriteLine("There are not odd numbers!");
            //    }
            #endregion

            #region ques_2
            // 2. Return a list of customers and how many orders each has.
            //var result = CustomerList.Select(C => new { CustomerName = C.CustomerName, customerOrder = C.Orders.Count() }).GroupBy(C => C.CustomerName).ToList();
            //if (result != null)
            //{
            //    foreach (var item in result)
            //    {
            //        foreach (var group in item)
            //        {
            //            {
            //                Console.WriteLine($"{group.CustomerName} : {group.customerOrder}");
            //            }

            //        }
            //    }
            #endregion

            #region ques_3
            // 3. Return a list of categories and how many products each has

            //var result = ProductList.Select(P => new { CategoryName = P.Category, ProductCount = P.ProductName }).GroupBy(C => C.CategoryName).ToList();
            //if (result != null)
            //{
            //    foreach (var item in result)
            //    {
            //        foreach (var group in item)
            //        {
            //            {
            //                Console.WriteLine($"{group.CategoryName},{group.ProductCount}");
            //            }
            //        }
            //    }

            //}
            #endregion

            #region ques_4
            // 4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var TotalOfTheNumbers = Arr.Sum();
            //Console.WriteLine($"Sum of numbers: {TotalOfTheNumbers}");

            #endregion

            #region ques_5
            // 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var TotalNumberOfcharacters = File.ReadAllText("dictionary_english.txt").Split("\n").Count();

            //Console.WriteLine($"Total number of characters: {TotalNumberOfcharacters}");

            #endregion

            #region Ques_6
            // 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var ShortestWordInDictionary = File.ReadAllText("dictionary_english.txt").Split("\n").Min();

            // Console.WriteLine($"ShortestWordInDictionary: {ShortestWordInDictionary}");

            #endregion

            #region ques_7
            // 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //var LongestWord = File.ReadAllText("dictionary_english.txt").Split("\n").Max(); //longest word in dictionary

            //Console.WriteLine($"LongestWord: {LongestWord}");

            #endregion

            #region ques_8
            // 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var wordByLengths = File.ReadLines("dictionary_english.txt").Select(word => word.Length);
            //var averageWordLength = wordByLengths.Average();

            //    Console.WriteLine($"Average word length: {averageWordLength}");


            #endregion

            #region ques_9
            // 9. Get the total units in stock for each product category.
            //var result = ProductList.Select(P => new { CategoryName = P.Category, ProductCount = P.UnitsInStock }).GroupBy (C => C.CategoryName).ToList();

            //foreach (var item in result)
            //{
            //    foreach (var group in item )
            //    {
            //        {
            //            Console.WriteLine($"{group.CategoryName},{group.ProductCount} ,");
            //        }
            //    }
            //}

            #endregion


            #endregion

            #region  (LINQ - Set Operators) 3
            #region ques_1
            //1. Find the unique Category names from Product List
            //var productOfList = ProductList.Select( P => P.ProductName).Distinct(); //using Distinct (Unique)

            //foreach (var product in productOfList)
            //    {
            //        Console.WriteLine(product);
            //    }

            #endregion

            #region ques_2
            // 2. Produce a Sequence containing the unique first letter from both product and customer names.
            //var result = ProductList.Select(P => P.ProductName).Union(CustomerList.Select(C => C.CustomerName)).ToList();

            //foreach (var items in result)
            //    {
            //        Console.WriteLine(items);
            //    }       

            #endregion

            #region ques_3
            // 3.Create one sequence that contains the common first letter from both product and customer names.
            #endregion

            #region ques_4
            //  4.Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var FirstLetterOfProduct = ProductList.Select(product => product.ProductName[0]);

            //var FirstLetterOfCustomer = CustomerList.Select(customer => customer.CustomerName[0]);

            //var result = FirstLetterOfProduct.Except(FirstLetterOfProduct).ToList();
            //var results = FirstLetterOfProduct.Except(FirstLetterOfCustomer).ToList();

            //Console.WriteLine("sequence that contains the first letters of product names that are not also first letters of customer names."); //FirstLetterOfProduct
            //foreach (var FirstLetters in result)
            //{
            //    Console.WriteLine(FirstLetters);
            //}

            //Console.WriteLine("First letter in products and not first letter in customer names:"); //FirstLetterOfCustomer
            //foreach (var letter in results)
            //{
            //    Console.WriteLine(letter);

            //}
            #endregion

            #region ques_5
            // 5.
            // 5.Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var LastThreeCharsCustomers = CustomerList.Select(C => C.CustomerName.Substring(C.CustomerName.Length - 3)); // TheLastThreeCharsCustomers
            //var LastThreeCharsProducts = ProductList.Select(P => P.ProductName.Substring(P.ProductName.Length - 3)); // TheLastThreeCharsProducts
            //Console.WriteLine(" the last Three Characters in each name of all customers and products");
            //foreach (var item in LastThreeCharsCustomers.Concat(LastThreeCharsProducts))
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

            #region ( LINQ - Quantifiers ) 4
            #region ques_1
            //1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

            #endregion
            #region ques_2
            // 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var ProductByCategory = ProductList.Where(P => P.UnitsInStock == 1).GroupBy(P => P.Category).ToList();

            //foreach (var Category in ProductByCategory)
            //{
            //    Console.WriteLine($"Category: {Category.Key}");
            //    foreach (var P in Category)
            //    {
            //        Console.WriteLine($"Product: {P.ProductID} {P.ProductName}");
            //    }
            //}
            #endregion
            #region ques_3
            // 3. Return a grouped a list of products only for categories that have all of their products in stock.

            //var productsInStock = ProductList.Where(p => p.UnitsInStock > 0).GroupBy (p => p.Category);

            //foreach (var group in productsInStock.Where(g => g.All(p => p.UnitsInStock > 0)))
            //{
            //    Console.WriteLine($"Category: {group.Key}");
            //    foreach (var product in group)
            //    {
            //        Console.WriteLine($"Product: {product.ProductID} {product.ProductName}");
            //    }
            //}

            #endregion
            #endregion

            #region ( LINQ – Grouping Operators) 5
            // 1. Use group by to partition a list of numbers by their remainder when divided by 5

            // List<int> numbers = new list<int> {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};


            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var PartitionByReminderFor5 = numbers.GroupBy(number => number % 5);

            //foreach (var group in PartitionByReminderFor5)
            //{

            //    {
            //        Console.WriteLine($"Number: {group}");
            //    }
            //}
            #endregion 
        }
    }
}
