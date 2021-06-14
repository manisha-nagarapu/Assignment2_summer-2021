using System;
using System.Collections.Generic;
using System.Linq;

namespace Programming_Assignment_2_Summer_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:
            Console.WriteLine("Question 1");
            int[] nums1 = { 2, 5, 1, 3, 4, 7 };
            int[] nums2 = { 2, 1, 4, 7 };
            Intersection(nums1, nums2);
            Console.WriteLine("");

            //Question 2 
            Console.WriteLine("Question 2");
            int[] nums = { 0, 1, 0, 3, 12 };
            Console.WriteLine("Enter the target number:");
            int target = Int32.Parse(Console.ReadLine());
            int pos = SearchInsert(nums, target);
            Console.WriteLine("Insert Position of the target is : {0}", pos);
            Console.WriteLine("");

            //Question3
            Console.WriteLine("Question 3");
            int[] ar3 = { 1, 2, 3, 1, 1, 3 };
            int Lnum = LuckyNumber(ar3);
            if (Lnum == -1)
                Console.WriteLine("Given Array doesn't have any lucky Integer");
            else
                Console.WriteLine("Lucky Integer for given array {0}", Lnum);

            Console.WriteLine();

            //Question 4
            Console.WriteLine("Question 4");
            Console.WriteLine("Enter the value for n:");
            int n = Int32.Parse(Console.ReadLine());
            int Ma = GenerateNums(n);
            Console.WriteLine("Maximun Element in the Generated Array is {0}", Ma);
            Console.WriteLine();

            //Question 5

            Console.WriteLine("Question 5");
            List<List<string>> cities = new List<List<string>>();
            cities.Add(new List<string>() { "London", "New York" });
            cities.Add(new List<string>() { "New York", "Tampa" });
            cities.Add(new List<string>() { "Delhi", "London" });
            string Dcity = DestCity(cities);
            Console.WriteLine("Destination City for Given Route is : {0}", Dcity);

            Console.WriteLine();

            //Question 6
            Console.WriteLine("Question 6");
            int[] Nums = { 2, 7, 11, 15 };
            int target_sum = 9;
            targetSum(Nums, target_sum);
            Console.WriteLine();

            //Question 7
            Console.WriteLine("Question 7");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            HighFive(scores);
            Console.WriteLine();

            //Question 8
            Console.WriteLine("Question 8");
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int K = 3;
            RotateArray(arr, K);

            Console.WriteLine();

            //Question 9
            Console.WriteLine("Question 9");
            int[] arr9 = { 7, 1, 5, 3, 6, 4 };
            int Ms = MaximumSum(arr9);
            Console.WriteLine("Maximun Sum contiguous subarray {0}", Ma);
            Console.WriteLine();

            //Question 10
            Console.WriteLine("Question 10");
            int[] costs = { 10, 15, 20 };
            int minCost = MinCostToClimb(costs);
            Console.WriteLine("Minium cost to climb the top stair {0}", minCost);
            Console.WriteLine();
        }

        //Question 1
        /// <summary>
        //Given two integer arrays nums1 and nums2, return an array of their intersection.
        //Each element in the result must be unique and you may return the result in any order.
        //Example 1:
        //Input: nums1 = [1,2,2,1], nums2 = [2,2]
        //Output: [2]
        //Example 2:
        //Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
        //Output: [9,4]
        //
        /// </summary>

        public static void Intersection(int[] nums1, int[] nums2)
        {
            try
            {
                int i, j;
                List<int> l = new List<int>();
                for (i = 0; i < nums1.Length; i++)
                { 
                    for( j=0; j<nums2.Length;j++)
                    {
                        if (nums1[i]==nums2[j])
                        {
                            l.Add(nums1[i]);
                        }
                        
                    }
                }
                //converts the list into the array and returns the array sol.
                int[] sol = new int[l.Count];
                for (var k = 0; k < l.Count; k++)
                {
                    sol[k] = l[k];
                }
                Console.Write("[");
                for (int m = 0; m < sol.Length - 1; m++)
                {
                    Console.Write(sol[m]);
                    Console.Write(",");
                }
                if (sol.Length != 0)
                    Console.Write(sol[sol.Length - 1]);
                Console.WriteLine("]");
            }
            catch (Exception)
            {

                throw;
            }
        }
        //the time complexity is O(m*n), where m is the length of the nums1 and n is the length of the nums2.
        //here,it returns the intersection of two arrays num1&num2.

        //Question 2:
        /// <summary>
        //Given a sorted array of distinct integers and a target value, return the index if the target is found.If not, return the index where it would be if it were inserted in order.
        //Note: You must write an algorithm with O(log n) runtime complexity.
        //Example 1:
        //Input: nums = [1, 3, 5, 6], target = 5
        //Output: 2
        //Example 2:
        //Input: nums = [1, 3, 5, 6], target = 2
        //Output: 1
        //Example 3:
        //Input: nums = [1, 3, 5, 6], target = 7
        //Output: 4
        //Example 4:
        //Input: nums = [1, 3, 5, 6], target = 0
        //Output: 0
        /// </summary>

        public static int SearchInsert(int[] nums, int target)
        {
            try
            {
                int higher, middle_value, target_index = 0;
                int lower = 0;
                higher = nums.Length - 1;

                while (lower <= higher)
                {
                    /*calculating the middle_value of the array..*/
                    middle_value = (lower + higher) / 2;

                    /*if the array middle_value index equal to the target, returning the index of that value..*/
                    if (nums[middle_value] == target)
                    {
                        return middle_value;
                    }

                    /*if target value is less than the middle_value then changing the higher index*/
                    if (target < nums[middle_value])
                    {
                        higher = middle_value - 1;
                        if ((nums[middle_value] - 1) == target)
                            target_index = middle_value;
                    }
                    else
                    {
                        /*if target value is greater than the middle_value value then changing the lower index*/
                        lower = middle_value + 1;

                        if ((nums[middle_value] + 1) == target)
                            target_index = (middle_value + 1);
                    }
                    
                }
                return target_index;
            }
            catch (Exception)
            {
                throw;
            }
        }
        //time complexity = O(logn), where n is the size of array.

        //Question 3
        /// <summary>
        //Given an array of integers arr, a lucky integer is an integer which has a frequency in the array equal to its value.
        //Return a lucky integer in the array. If there are multiple lucky integers return the largest of them. If there is no lucky integer return -1.
        //Example 1:
        //Input: arr = [2, 2, 3, 4]
        //Output: 2
        //Explanation: The only lucky number in the array is 2 because frequency[2] == 2.
        /// </summary>

        private static int LuckyNumber(int[] nums)
        {
            try
            {
                IDictionary<int, int> num_frequency = new Dictionary<int, int>();
                foreach (var each_num in nums)

                {

                    if (!num_frequency.ContainsKey(each_num))
                    {
                        num_frequency[each_num] = 0;
                    }


                    num_frequency[each_num]++;


                }
                if (num_frequency.Count == 0)
                {


                    return -1;

                }
                int lucky_integer = -1;

                foreach (var k in num_frequency)
                {
                    if (k.Key == k.Value)
                    {
                        lucky_integer = Math.Max(lucky_integer, k.Value);
                    }
                }
                return lucky_integer;
            }

            catch (Exception)
            {

                throw;
            }
        }
        //here,the time complexity is O(N),where N is the length of the array.here,we are creating the dictionary to store the key value pair.
        //Here,we will return the lucky integer in the array and if there is no lucky integer,then we will return -1.
        //Question 4:
        /// <summary>
        //You are given an integer n.An array nums of length n + 1 is generated in the following way:
        //•	nums[0] = 0
        //•	nums[1] = 1
        //•	nums[2 * i] = nums[i]  when 2 <= 2 * i <= n
        //•	nums[2 * i + 1] = nums[i] + nums[i + 1] when 2 <= 2 * i + 1 <= n
        // Return the maximum integer in the array nums.

        //Example 1:
        //Input: n = 7
        //Output: 3
        //Explanation: According to the given rules:
        //nums[0] = 0
        //nums[1] = 1
        //nums[(1 * 2) = 2] = nums[1] = 1
        //nums[(1 * 2) + 1 = 3] = nums[1] + nums[2] = 1 + 1 = 2
        //nums[(2 * 2) = 4] = nums[2] = 1
        //nums[(2 * 2) + 1 = 5] = nums[2] + nums[3] = 1 + 2 = 3
        //nums[(3 * 2) = 6] = nums[3] = 2
        //nums[(3 * 2) + 1 = 7] = nums[3] + nums[4] = 2 + 1 = 3
        //Hence, nums = [0, 1, 1, 2, 1, 3, 2, 3], and the maximum is 3.

        /// </summary>
        private static int GenerateNums(int n)
        {
            try
            {
                int[] largest = new int[n + 1];

                if (n < 2)
                {
                    return n;
                }

                largest[1] = 1;

                for (int i = 1; 2 * i <= n; i++)
                {
                    int next_element = 2 * i;
                    largest[next_element] = largest[i];

                    if (next_element + 1 <= n)
                    {
                        largest[next_element + 1] = largest[i] + largest[i + 1];
                    }
                }

                return largest.Max();
            }
            catch (Exception)
            {

                throw;
            }

        }
        //Here,the run time complexity is O(n) i.e linear.
        //here,we create an array nums of size n+1.If n is equal to 1 or 2 then return 1.


        //Question 5
        /// <summary>
        //You are given the array paths, where paths[i] = [cityAi, cityBi] means there exists a direct path going from cityAi to cityBi.Return the destination city, that is, the city without any path outgoing to another city.
        //It is guaranteed that the graph of paths forms a line without any loop, therefore, there will be exactly one destination city.
        //Example 1:
        //Input: paths = [["London", "New York"], ["New York","Lima"], ["Lima","Sao Paulo"]]
        //Output: "Sao Paulo" 
        //Explanation: Starting at "London" city you will reach "Sao Paulo" city which is the destination city.Your trip consist of: "London" -> "New York" -> "Lima" -> "Sao Paulo".
        /// </summary>
        public static string DestCity(List<List<string>> paths)
        {
            try
            {

                var city_dict = new Dictionary<string, int>();
                foreach (var city in paths)
                {
                    string s = city[0], d = city[1];
                    if (!city_dict.ContainsKey(s)) city_dict[s] = 0;
                    if (!city_dict.ContainsKey(d)) city_dict[d] = 0;
                    city_dict[s]++;
                    city_dict[d]--;
                }

                return city_dict.Where(i => i.Value == -1).First().Key;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //

        //Question 6:
        /// <summary>
        //Given an array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they add up to a specific target number.
        //Print the indices of the two numbers (1-indexed) as an integer array answer of size 2, where 1 <= answer[0] < answer[1] <= numbers.Length.
        //You may not use the same element twice, there will be only one solution for a given array
        //Example 1:
        //Input: numbers = [2,7,11,15], target = 9
        //Output: [1,2]
        //Explanation: The sum of 2 and 7 is 9. Therefore index1 = 1, index2 = 2.

        /// </summary>
        private static int[] targetSum(int[] nums, int target)
        {
            try
            {
                var dict = new Dictionary<int, int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    if (dict.ContainsKey(target - nums[i]))
                        return new int[] { dict[target - nums[i]], i };
                    dict[nums[i]] = i;
                }

                return null;
            }

            catch (Exception)
            {

                throw;
            }
        }
        // Here,we will iterate through the whole array and see the difference between target and the element in the array that matches.
        //If,it matches with the other elements in the array,we will return the indexes of those elements.

        //Question 7
        /// <summary>
        /// Given a list of the scores of different students, items, where items[i] = [IDi, scorei] represents one score from a student with IDi, calculate each student's top five average.
        /// Print the answer as an array of pairs result, where result[j] = [IDj, topFiveAveragej] represents the student with IDj and their top five average.Sort result by IDj in increasing order.
        /// A student's top five average is calculated by taking the sum of their top five scores and dividing it by 5 using integer division.
        /// Example 1:
        /// Input: items = [[1, 91], [1,92], [2,93], [2,97], [1,60], [2,77], [1,65], [1,87], [1,100], [2,100], [2,76]]
        /// Output: [[1,87],[2,88]]
        /// Explanation: 
        /// The student with ID = 1 got scores 91, 92, 60, 65, 87, and 100. Their top five average is (100 + 92 + 91 + 87 + 65) / 5 = 87.
        /// The student with ID = 2 got scores 93, 97, 77, 100, and 76. Their top five average is (100 + 97 + 93 + 77 + 76) / 5 = 88.6, but with integer division their average converts to 88.
        /// Example 2:
        /// Input: items = [[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100]]
        /// Output: [[1,100],[7,100]]
        /// Constraints:
        /// 1 <= items.length <= 1000
        /// items[i].length == 2
        /// 1 <= IDi <= 1000
        /// 0 <= scorei <= 100
        /// For each IDi, there will be at least five scores.
        /// </summary>
        private static void HighFive(int[,] items)
        {
            try
            {
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 8
        /// <summary>
        //Given an array, rotate the array to the right by k steps, where k is non-negative.
        //Print the Final array after rotation.
        //Example 1:
        //Input: nums = [1, 2, 3, 4, 5, 6, 7], k = 3
        //Output: [5,6,7,1,2,3,4]
        //Explanation:
        //rotate 1 steps to the right: [7,1,2,3,4,5,6]
        //rotate 2 steps to the right: [6,7,1,2,3,4,5]
        //rotate 3 steps to the right: [5,6,7,1,2,3,4]
        //Example 2:
        //Input: nums = [-1,-100,3,99], k = 2
        //Output: [3,99,-1,-100]
        //Explanation: 
        //rotate 1 steps to the right: [99,-1,-100,3]
        //rotate 2 steps to the right: [3,99,-1,-100]
        /// </summary>

        private static void RotateArray(int[] arr, int n)
        {
            try
            {
                int[] final_output = new int[arr.Length];
                int new_length = arr.Length;
                for (int k = 0; k < arr.Length; k++)
                { 
                    final_output[(k + n) % new_length] = arr[k]; 

                }
                for (int k = 0; k < arr.Length; k++)
                {
                    arr[k] = final_output[k];
                }
                Console.WriteLine(final_output);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 9
        /// <summary>
        //Given an integer array nums, find the contiguous subarray(containing at least one number) which has the largest sum and return its sum
        //Example 1:
        //Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
        //Output: 6
        //Explanation: [4,-1,2,1] has the largest sum = 6.
        //Example 2:
        //Input: nums = [1]
        //Output: 1
        // Example 3:
        // Input: nums = [5,4,-1,7,8]
        //Output: 23
        /// </summary>

        private static int MaximumSum(int[] arr)
        {
            try
            {
                int res = 0;
                int largest_Sum = arr[0];

                for (int k = 0; k < arr.Length; k++)
                {
                    res += arr[k];
                    if (arr[k] > res)
                    {
                        res = arr[k];
                    }
                    if (res > largest_Sum)
                    {
                        largest_Sum = res;
                    }
                  
                }
                return largest_Sum;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 10
        /// <summary>
        //You are given an integer array cost where cost[i] is the cost of ith step on a staircase.Once you pay the cost, you can either climb one or two steps.
        //You can either start from the step with index 0, or the step with index 1.
        //Return the minimum cost to reach the top of the floor.
        //Example 1:
        //Input: cost = [10, 15, 20]
        //Output: 15
        //Explanation: Cheapest is: start on cost[1], pay that cost, and go to the top.

        /// </summary>

        private static int MinCostToClimb(int[] costs)
        {
            try
            {
                int first_cost = costs[0];
                int second_cost = costs[1];
                int normal_Cost = 0;
                for (int k = 2; k < costs.Length; k++)
                {
                    normal_Cost = costs[k] + Math.Min(first_cost, second_cost);
                    first_cost = second_cost;
                    second_cost = normal_Cost;
                }
                return Math.Min(first_cost, second_cost);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
