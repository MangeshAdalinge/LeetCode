using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedianOfTwoSortedArrays
{
    public class Solution
    {
        public double bruteForceFindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            
            List<int> numsMerged = new List<int>();
            int indexNums1 = 0, indexNums2 = 0;
            while (!indexNums1.Equals(nums1.Length) && !indexNums2.Equals(nums2.Length))
            {
               
                if (nums1[indexNums1].Equals(nums2[indexNums2]))
                {
                    numsMerged.Add(nums1[indexNums1]);
                    numsMerged.Add(nums2[indexNums2]);
                    
                    indexNums1++;
                    indexNums2++;
                }
                else
                {
                    if (nums1[indexNums1] < nums2[indexNums2])
                    {
                        numsMerged.Add(nums1[indexNums1]);                        
                        indexNums1++;
                    }
                    else
                    {
                        if (nums1[indexNums1] > nums2[indexNums2])
                        {
                            numsMerged.Add(nums2[indexNums2]);                            
                            indexNums2++;
                        }
                    }
                }
            }

            while (!indexNums1.Equals(nums1.Length))
            {
                numsMerged.Add(nums1[indexNums1]);
                indexNums1++;
            }

            while (!indexNums2.Equals(nums2.Length))
            {
                numsMerged.Add(nums2[indexNums2]);
                indexNums2++;
            }

            Console.WriteLine("nums Merged:   ");
            for (int i = 0; i < numsMerged.Count; i++)
            {
                Console.WriteLine(numsMerged[i]);
            }

            Console.WriteLine("Median :   ");
            double medianIndexValue = numsMerged.Count / 2;
            double medianValue = 0.0;
            if (numsMerged.Count % 2 == 0)
                medianValue = (double)((double)(numsMerged[Convert.ToInt32(medianIndexValue) - 1] + numsMerged[Convert.ToInt32(medianIndexValue)]) / 2);
            else
                medianValue = numsMerged[Convert.ToInt32(Math.Ceiling(medianIndexValue))];
            return medianValue;
        }

        public double findMedian(int[] nums, int numsStartIndex, int numsEndIndex)
        {
            int len = numsEndIndex - numsStartIndex;
            if (len % 2 == 0)
            {
                return (double)(len / 2);
            }
            else
            {
                return Math.Ceiling((double)(len / 2));
            }            
        }
        
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double m1 = findMedian(nums1,0,nums1.Length);
            double m2 = findMedian(nums2,0,nums2.Length);

            if (nums1[Convert.ToInt32(m1)] > nums2[Convert.ToInt32(m2)])
            {
                
            }

            return 1.1;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Solution obj = new Solution();

            int[] nums1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
            int[] nums2 = { 0,6};
            double medianValue = obj.FindMedianSortedArrays(nums1, nums2);
            Console.WriteLine("Median: "+medianValue);
            Console.ReadLine();
        }
    }
}
