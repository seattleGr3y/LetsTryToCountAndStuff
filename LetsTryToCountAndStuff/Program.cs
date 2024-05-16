
#region CODE FROM COPILOT NOT USING
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text.RegularExpressions;


//public class UniqueValueSorter
//{
//    public int[] GetUniqueValuesByFrequency(int[] inputArray)
//    {
//        // Group the numbers and count their frequencies
//        var frequencyMap = inputArray
//            .GroupBy(number => number)
//            .Select(group => new { Value = group.Key, Count = group.Count() })
//            .ToList();

//        // Sort by frequency first, then by value
//        var sortedByFrequency = frequencyMap
//            .OrderBy(item => item.Count)
//            .ThenBy(item => item.Value)
//            .Select(item => item.Value)
//            .ToArray();
//        int[] reversedList = sortedByFrequency.Reverse().ToArray();
//        return reversedList;
//    }
//}

// Example usage:
//class Program
//{
//    public static void Main()
//    {
//var sorter = new UniqueValueSorter();
//int[] inputArray = new int[] { 0, 0, 1, 3, 2, 3, 2, 1, 1, 0 };

//int[] uniqueValuesByFrequency = sorter.GetUniqueValuesByFrequency(inputArray);

//Console.WriteLine("Unique values sorted by frequency (and value):");
//foreach (var value in uniqueValuesByFrequency)
//{
//    Console.WriteLine(value);
//}
//    }
//}
#endregion

using System.Globalization;

class Program
{
    public static void Main()
    {
        string wordList = "the rabbit ate the carrots";
        int[] NewInput = new int[] { 0, 1, 0, 6, 2, 0, 1, 1, 0, 3, 2, 1, 2, 1, 1, 1, 1, 0, 1, 3, 6 };
        string nextSentence = "This is the sentence I will use to test";
        string theInputStr = string.Join(" ", NewInput);
        string nextTestSentance = "try this sentence now and see if it works";
        // this will create an array by getting the elements of the list and reverse each one
        // this calls the : ToElements function below
        string newWords = string.Empty;
        var words = wordList
           .Split()
           .Select(x => string.Concat(x.ToElements().Reverse()));
        foreach (string word in words)
        {
            newWords += $"{word} ";
        }

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("##########################################");
        Console.WriteLine("  THIS METHOD WILL TAKE AN INT ARRAY");
        Console.WriteLine(" AND PRINT TO THE SCREEN A HASHTABLE");
        Console.WriteLine(" OF THE UNIQUE INTEGERS AND THE NUMBER");
        Console.WriteLine("  OF TIMES THEY APPEAR IN THE ARRAY");
        Console.WriteLine("    IN ORDER FROM MOST TO LEAST");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"INPUT: {string.Join("", theInputStr)}");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("##########################################");
        NewQuery.GetNumberOrder(NewInput);
        Console.ForegroundColor = ConsoleColor.White;

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("##########################################");
        Console.WriteLine("  THIS METHOD WILL TAKE A STRING ARRAY");
        Console.WriteLine("  AND USING LINQ WILL CHOOSE EACH WORD");
        Console.WriteLine(" IN THE ARRAY AND REVERSE THE SPELLING OF");
        Console.WriteLine("  THE WORD THEN PRINT THE NEW SENTENCE");
        Console.WriteLine("           TO THE SCREEN");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"INPUT: {string.Join("", wordList)}");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("##########################################");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"   {string.Join("", newWords)}");
        Console.ForegroundColor = ConsoleColor.White;
        ReverseStrings.ReverseNewMethod(nextTestSentance);

        ReverseStrings.AddTheEvens(NewInput);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("##########################################");
        Console.WriteLine("  THIS METHOD WILL TAKE AN STRING");
        Console.WriteLine(" AND TURNS IT INTO A STRING ARRAY");
        Console.WriteLine(" AND THEN REVERSE THE ORDER OF THE WORDS IN THE STRING (STRING ARRAY)");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"INPUT: {string.Join("", nextSentence)}");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("##########################################");
        Console.ForegroundColor = ConsoleColor.Green;
        ReverseStrings.ReverseWordOrder(nextSentence);
        Console.WriteLine(" ");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("##########################################");
        Console.WriteLine("  THIS METHOD WILL TAKE AN STRING");
        Console.WriteLine(" AND TURNS IT INTO A STRING ARRAY");
        Console.WriteLine(" AND THEN REVERSE THE SPELLING OF THE STRING (STRING ARRAY)");
        Console.WriteLine("  THEN COMPARE TO SEE IF THE 2 STRINGS ARE EQUAL");
        Console.WriteLine("    WILL REPORT AS PALINDROME OR NOT PALINDROME");
        Console.WriteLine("##########################################");
        Console.ForegroundColor = ConsoleColor.Green;

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"INPUT: {"tacocat"}");
        ReverseStrings.chkPalindrome("tacocat");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"INPUT: {"palindrome"}");
        ReverseStrings.chkPalindrome("palindrome");
        Console.WriteLine(" ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.ReadLine();
    }
}

public class NewQuery
{
    public static int[] sortedInput = new int[0];

    public static void GetNumberOrder(int[] TheInput)
    {
        var sortTheInput = TheInput.GroupBy(x => x);
        Dictionary<int, int> counting = new Dictionary<int, int>();
        foreach (var y in sortTheInput)
        {
            counting.Add(y.Key, y.Count());
        }
        var sortedDict = from entry in counting orderby entry.Value descending select entry;
        foreach (var item in sortedDict)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"     this is the order {item}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        Console.WriteLine(" ");
    }
}

public static class ReverseStrings
{
    // this is just one way to do this and a way I may or may not remember how to code exactly
    // I was using a lot of IEnumerable and things like that at Premera though but I should look for another way
    //
    public static IEnumerable<string> ToElements(this string source)
    {
        var enumerator = StringInfo.GetTextElementEnumerator(source);
        while (enumerator.MoveNext())
            yield return enumerator.GetTextElement();
    }

    // these are still doing all the words not every other
    // have to make it do every other
    //
    public static string ReverseNewMethod(string sentance)
    {
        Console.WriteLine(" ");
        string[] sepSent = sentance.Split(" ");
        string result = string.Empty;

        for (int i = 0; i < sepSent.Length; i++)
        {
            if (i % 2 == 0)
            {
                result += $"{sepSent[i]} ";
            }
            else
            {
                char[] charArray = sepSent[i].ToCharArray();
                Array.Reverse(charArray);
                string tmp = new string(charArray);
                result += $"{tmp} ";
            }
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("##########################################");
        Console.WriteLine("  THIS METHOD WILL TAKE AN INT ARRAY");
        Console.WriteLine(" AND FIRST USE A FOR LOOP TO CREATE A ");
        Console.WriteLine(" NEW SENTENCE THAT WILL HAVE EVERY OTHER");
        Console.WriteLine("     WORD WRITTEN IN REVERSE");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"INPUT: {string.Join("", sentance)}");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("##########################################");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(result);
        Console.WriteLine(" ");
        Console.ForegroundColor = ConsoleColor.White;
        return result;
    }

    // Given an array of ints, write a method to total all the values that are even numbers
    public static void AddTheEvens(int[] TestInput)
    {
        int tmpResult = 0;
        foreach (var num in TestInput)
        {
            if (num % 2 == 0)
            {
                tmpResult += num;
            }
        }

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("##########################################");
        Console.WriteLine("  THIS METHOD WILL TAKE AN INT ARRAY");
        Console.WriteLine("  AND USING FOR LOOP WILL CHOOSE THE EVEN NUMBERS");
        Console.WriteLine(" AND ADD THOSE NUMBERS PRINTING OUT THE SUM");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"INPUT: {string.Join("", TestInput)}");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("##########################################");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(tmpResult);
        Console.WriteLine(" ");
        Console.ForegroundColor = ConsoleColor.White;
    }

    /*
        Q.2: How to find if the given string is a palindrome or not?
        Ans.: The user will input a string and we need to print “Palindrome” or “Not Palindrome” based on whether the input string is a palindrome or not.
        input: madam, output: Palindrome
        input: step on no pets, output: Palindrome
        input: book, output: Not Palindrome
        if we pass an integer as a string parameter then also this method will give the correct output
        input: 1221, output: Palindrome
    */

    internal static void chkPalindrome(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);

        //bool flag = false;
        //for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
        //{
        //    if (str[i] != str[j])
        //    {
        //        flag = false;
        //        break;
        //    }
        //    else
        //        flag = true;
        //}
        if (reversedString.Equals(str))
        {
            Console.WriteLine("Palindrome");
            Console.WriteLine("");
        }
        else
            Console.WriteLine("Not Palindrome");
            Console.WriteLine("");
    }

    /*
        again in this example the commented out code is what I found online as a reference for myself
        but my code is much smaller and works perfectly I really can't see a reason to do it their way
    */

    internal static void ReverseWordOrder(string sentence)
    {
        string[] sentArray = sentence.Split(' ');
        int sentLength = sentArray.Length;
        string newSentence = string.Empty;

        for (int i = sentLength - 1; i >= 0; i--)
        {
            newSentence += $"{sentArray[i]} ";
        }

        Console.WriteLine($"new sentence here: {newSentence}");

        //int i;
        //StringBuilder reverseSentence = new StringBuilder();

        //int Start = str.Length - 1;
        //int End = str.Length - 1;

        //while (Start > 0)
        //{
        //    if (str[Start] == ' ')
        //    {
        //        i = Start + 1;
        //        while (i <= End)
        //        {
        //            reverseSentence.Append(str[i]);
        //            i++;
        //        }
        //        reverseSentence.Append(' ');
        //        End = Start - 1;
        //    }
        //    Start--;
        //}

        //for (i = 0; i <= End; i++)
        //{
        //    reverseSentence.Append(str[i]);
        //}
        //Console.WriteLine(reverseSentence.ToString());
    }

}
