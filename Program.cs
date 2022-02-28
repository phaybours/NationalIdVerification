using NationalIdVerification.Binary;
using System;
using System.Collections.Generic;
using System.IO;

namespace NationalIdVerification
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //================== NationalIdValidation ================
            //string nIdPath = "C:\\test\\natids.txt";
            //NationalIdValidation.ReadFileValidateNationalID(nIdPath);

            //=================RoundRobin=============================
            //string plTeamsPath = "C:\\test\\EPLTeams.txt";
            //string plTeamsPathMatched = "C:\\test\\EPLTeamsMapped.txt";
            //RoundRobin.ScheduleTeams(plTeamsPath, plTeamsPathMatched);

            //===============TournamentWinner========================
            //var competition = new List<List<string>>()
            //{
            //    new List<string> { "HTML", "Java" },
            //    new List<string> { "Java", "Python" },
            //    new List<string> { "Python", "HTML" },
            //    new List<string> { "C#", "Python" },
            //    new List<string> { "Java", "C#" },
            //    new List<string> { "C#", "HTML" },
            //    new List<string> { "SQL", "C#" },
            //    new List<string> { "HTML", "SQL" },
            //    new List<string> { "SQL", "Python" },
            //    new List<string> { "SQL", "Java" }
            //};
            //var result = new List<int>() { 0, 1, 1, 1, 0, 1, 0, 1, 1, 0 };
            //var winner = TournamentWinner.GetTournamentWinner(competition, result);
            //Console.WriteLine(winner);

            //==========================NonConstructibleChange============================
            //int[] coins = { 1, 5, 1, 1, 1, 10, 15, 20, 100 };
            //var result = NonConstructibleChange.GetNonConstructibleChange(coins);
            //Console.WriteLine(result);

            //==========================NonConstructibleChange============================
            //int[] array = new int[] { 12, 3, 1, 2, -6, 5, -8, 6 };
            //int targetSum = 0;
            //var result = ThreeNumberSum.SolveThreeNumberSum(array, targetSum);
            //Console.WriteLine("[{0}]", string.Join(", ", result));;

            //==========================SmallestDifference============================
            //var arrayOne = new int[] { -1, 5, 10, 20, 28, 3 };
            //var arrayTwo = new int[] { 26, 134, 135, 15, 17 };
            //var result = SmallestDifference.GetSmallestDifference(arrayOne, arrayTwo);
            //Console.WriteLine("[{0}]", string.Join(", ", result));

            //==========================MoveElementToEnd============================
            //var intput = new List<int> { 2, 1, 2, 2, 2, 3, 4, 2 };
            //var intput = new List<int> { 5, 1, 2, 5, 5, 3, 4, 6, 7, 5, 8, 9, 10, 11, 5, 5, 12 };
            //int target = 5;
            //var result = MoveElementToEnd.DoMoveElementToEnd(intput, target);
            //Console.WriteLine("[{0}]", string.Join(", ", result));

            //==========================MoveElementToEnd============================
            ////int[] array = { -1, -5, -10, -1100, -1100, -1101, -1102, -9001 };
            //int[] array = { -1, -1, -2, -3, -4, -5, -5, -5, -6, -7, -8, -7, -9, -10, -11 };
            ////int[] array = { 1, 1, 2, 3, 4, 5, 5, 5, 6, 7, 8, 8, 9, 10, 11 };
            //var result = MonotonicArray.IsMonotonic2(array);
            //Console.WriteLine(result);

            //==========================SpiralTraverse============================
            //int[,] array = new int[,] 
            //{ 
            //    { 1, 2, 3, 4 }, 
            //    { 12, 13, 14, 5 }, 
            //    { 11, 16, 15, 6 }, 
            //    { 10, 9, 8, 7 } 
            //};
            //int[,] array = new int[,]
            //{
            //    {19, 32, 33, 34, 25, 8},
            //    {16, 15, 14, 13, 12, 11},
            //    {18, 31, 36, 35, 26, 9},
            //    {1, 2, 3, 4, 5, 6},
            //    {20, 21, 22, 23, 24, 7},
            //    {17, 30, 29, 28, 27, 10}
            //};
            //var result = SpiralTraverse.DoSpiralTraverse(array);
            //Console.WriteLine("[{0}]", string.Join(", ", result));

            //==========================LongestPeak============================
            //int[] array = { 1, 2, 3, 3, 4, 0, 10, 6, 5, -1, -3, 2, 3 };
            //var result = LongestPeak.GetLongestPeak(array);
            //Console.WriteLine(result);

            //==========================ArrayOfProducts============================
            //int[] array = { 5, 1, 4, 2 };
            //var result = ArrayOfProducts.GetArrayOfProducts(array);
            //Console.WriteLine("[{0}]", string.Join(", ", result));

            //==========================MergeOverlappingIntervals============================
            //int[][] intervals = new int[][] {
            //        new int[]{1, 2},
            //        new int[]{3, 5},
            //        new int[]{4, 7},
            //        new int[]{6, 8 },
            //        new int[]{ 9, 10 }
            //};
            //var result = MergeOverlappingIntervals.SolveMergeOverlappingIntervals(intervals);
            //var output = new List<string>();
            //foreach(var item in result)
            //{
            //    output.Add($"[{string.Join("," , item)}]");
            //}
            //Console.WriteLine("[{0}]",string.Join(",", output));

            //==========================GetBinaryGap============================
            //int input = 1045;
            //var result = BinaryGap.GetBinaryGap(input);
            //Console.WriteLine(result);

            //string input = "The quick brown fox jumps over the lazy dog";
            //var result = Test.solution(input, 39);
            //Console.WriteLine($"'{result}'", result.Length);
            //Console.WriteLine(result.Length);

            //int[] input = { 3,0, 5 };
            //var result = NoFilters.GetNoFilters(input);
            //Console.WriteLine(result);

            //var result = Factors.GetPairs(7);
            //Console.WriteLine("[{0}]", string.Join(", ", result));

            //var result = ValueX.GetX();
            // int[] input = { 1, 2, 3 };
            // var output = PossibleSubSet.GetPossibleSubSet(input);
            // var outputList = new List<string>();
            // output.ForEach(x =>
            //{
            //    outputList.Add("{"+ string.Join(", ", x) +"}");

            //});
            // Console.WriteLine("[{0}]", string.Join(", ", outputList));

            //var outPut = NoOfCarries.GetNoOfCarries(910111998, 99999999);
            //Console.WriteLine("{0}", string.Join(", ", outPut));

            //string[] input = { "P>E", "E>R", "R>U" };
            //string[] input = { "U>B", "R>U", "B>A", "O>R", "", " ", "Y>O" };
            //Console.WriteLine( DeduceWord.Deduce(input));

            //=========================BST==========================================
            Node root = new Node(30);
            Node n1 = new Node(15);
            Node n2 = new Node(45);
            Node n3 = new Node(6);
            Node n4 = new Node(41);
            Node n5 = new Node(54);

            root.left = n1;
            root.right = n2;
            n1.left = n3;
            n2.left = n4;
            n2.right = n5;
            // Binary Search
            //Node nodeToFind = BinarySearchTree.Search(root, 41);
            //Console.WriteLine(nodeToFind.Value);

            // Binary tree Insert
            Node newRoot = BinarySearchTree.Insert(root, 85);
            //Console.WriteLine(root.right.right.right.Value);

            // BST InOrder Traversal V1
            //BinarySearchTree.InOrderTraversal_V1(root);
            //BinarySearchTree.InOrderTraversal_V2(root);

            //BST PreOrder Traversal
            //BinarySearchTree.PreOrderTraversal_V1(root);
            //BinarySearchTree.PreOrderTraversal_V2(root);

            //BST PostOrder Traversal
            //BinarySearchTree.PostOrderTraversal_V1(root);
            //BinarySearchTree.PostOrderTraversal_V2(root);


            //BST LevelOrder Traversal
            BinarySearchTree.LevelOrderTraversal(root);
        }
    }
}