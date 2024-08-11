using static S1__LINQ.ListGenerator;
namespace S1__LINQ

{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1. Find all products that are out of stock.
            //var result = productsList.Where(P => P.UnitsInStock == 0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            //var result = productsList.Where(P => P.UnitsInStock != 0 && P.UnitPrice > 3);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 3. Returns digits whose name is shorter than their value.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr
            //.Select((name, index) => new { Name = name, Index = index })
            //.Where(x => x.Name.Length < x.Index)
            //.Select(x => x.Index);

            //foreach (var digit in result)
            //{
            //    Console.WriteLine(digit);
            //}

            #endregion

            #region 1. Sort a list of products by name
            //var result = productsList.OrderByDescending(P => P.ProductName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion
            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            ////Array.Sort(Arr ,StringComparer.OrdinalIgnoreCase);
            //var result = Arr.OrderBy(I => I  , StringComparer.OrdinalIgnoreCase);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 3. Sort a list of products by units in stock from highest to lowest.
            //var result = productsList.OrderByDescending(P => P.UnitsInStock);
            ////var result = productsList.OrderBy(P => P.UnitsInStock).Reverse();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.OrderBy(S => S.Length).ThenBy(S => S);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 5. Sort first by word length and then by a case-insensitive sort of the words in an array.
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = words.OrderBy(x => x.Length)
            //                  .ThenBy(x => x, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            //}

            #endregion

            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var result = productsList.OrderBy(P => P.Category)
            //                         .ThenByDescending(P => P.UnitPrice);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 7. Sort first by word length and then by a case-insensitive descending sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(S => S.Length)
            //                .ThenBy(S => S ,StringComparer.OrdinalIgnoreCase);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.Where(S => S.Length > 1 && S[1] == 'i').Reverse();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }
    }
}
