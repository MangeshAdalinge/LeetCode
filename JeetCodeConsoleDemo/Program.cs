using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeetCodeConsoleDemo
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] resTwoSum = { -1, -1 };

            Dictionary<int, int> check = new Dictionary<int, int> { };

            for (int index = 0; index < nums.Length; index++)
            {
                if (check.ContainsKey(target - nums[index]))
                {
                    int value = 0;
                    check.TryGetValue(target - nums[index], out value);
                    resTwoSum[0] = value;
                    resTwoSum[1] = index;
                    break;
                }
                else
                {

                    try
                    {
                        check.Add(nums[index], index);
                    }
                    catch (ArgumentException)
                    {
                        continue;
                    }
                    
                }                
            }

            return resTwoSum;

        }
    }




        public class TwoSumSolution
        {
            public int[] TwoSum(int[] nums, int target)
            {
                int[] resTwoSum = { -1, -1 };
                Console.WriteLine("Element 0: " + resTwoSum[0]);
                // Console.ReadKey();
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (target == nums[i] + nums[j])
                        {

                            int m = 0;
                            if (resTwoSum[0] == -1)
                            {
                                m = 0;
                            }
                            else
                            {
                                m = resTwoSum.Max();
                            }


                            resTwoSum[m] = i;
                            resTwoSum[m + 1] = j;
                            break;
                        }
                    }
                    if (resTwoSum[0] != -1)
                    {
                        break;
                    }
                }

                return resTwoSum;

            }


        }
        class Program
        {
            static void Main(string[] args)
            {
                Solution obj = new Solution();
                int[] nums = { 3, 2, 4 };
                int target = 6;

                int[] resTwoSum = obj.TwoSum(nums, target);
                Console.WriteLine("Result:: ");
                for (int i = 0; i < resTwoSum.Length; i++)
                {
                    Console.WriteLine(resTwoSum[i] + ", " + resTwoSum[i + 1]);
                    i++;
                }

                Console.ReadLine();
            }
        }
    }

