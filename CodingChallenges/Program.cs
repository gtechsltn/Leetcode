﻿// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

Console.WriteLine("LEETCODE CODING CHALLENGES");
Console.WriteLine("__________________________");

Console.WriteLine("September 19, 2023");
Console.WriteLine("Answer > " + DailyLeetcode.FindDuplicate(new int[] { 1, 3, 4, 2, 2 }));

Console.WriteLine("September 24, 2023 - 799. Champagne Tower");
Console.WriteLine("Failed");

Console.WriteLine("September 25, 2023 - 389. Find the Difference");
Console.WriteLine("Answer > " + DailyLeetcode.FindTheDifference("abcd","abcde"));

Console.WriteLine("September 26, 2023 - RemoveDuplicateLetters");
Console.WriteLine("Answer > " + DailyLeetcode.RemoveDuplicateLetters("cbacdcbc"));

Console.WriteLine("September 27, 2023 - 880. Decoded String at Index");
Console.WriteLine("Answer > " + DailyLeetcode.DecodeAtIndex("a2345678999999999999999",1));

Console.WriteLine("September 29, 2023 - 896. Monotonic Array");
Console.WriteLine(DailyLeetcode.IsMonotonic(new int[]{6,5,4,4}));

Console.WriteLine("September 30,2023 - 557. Reverse Words in a String III");
Console.WriteLine(DailyLeetcode.ReverseWords("Let's take LeetCode contest"));