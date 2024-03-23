namespace Median_of_Two_Sorted_Arrays
{
    public static class FindMedianSortedArrays
    {
        public static double Solve(int[] nums1, int[] nums2)
        {
            var resultCount = nums1.Length + nums2.Length;
            var hasTwoNumersInMiddle = resultCount % 2 == 0;
            var middlePosition = Math.Round(Convert.ToDouble(resultCount) / 2, MidpointRounding.AwayFromZero) - 1;
            var currentPosition = 0;
            var firstArrayPosition = 0;
            var secondArrayPosition = 0;
            var isFirstArrayEnded = firstArrayPosition >= nums1.Length;
            var isSecondArrayEnded = secondArrayPosition >= nums2.Length;

            while (currentPosition < middlePosition)
            {
                isFirstArrayEnded = firstArrayPosition >= nums1.Length;
                isSecondArrayEnded = secondArrayPosition >= nums2.Length;

                if (!isFirstArrayEnded && (isSecondArrayEnded || (!isSecondArrayEnded && nums1[firstArrayPosition] <= nums2[secondArrayPosition])))
                {
                    firstArrayPosition++;
                }
                else if (!isSecondArrayEnded && (isFirstArrayEnded || (!isFirstArrayEnded && nums2[secondArrayPosition] <= nums1[firstArrayPosition])))
                {
                    secondArrayPosition++;

                }
                currentPosition++;
            }

            var firstNumber = 0;
            var secondNumber = 0;
            isFirstArrayEnded = firstArrayPosition >= nums1.Length;
            isSecondArrayEnded = secondArrayPosition >= nums2.Length;

            if (isFirstArrayEnded && !isSecondArrayEnded)
            {
                firstNumber = nums2[secondArrayPosition];
                secondArrayPosition++;
            }
            else if (isSecondArrayEnded && !isFirstArrayEnded)
            {
                firstNumber = nums1[firstArrayPosition];
                firstArrayPosition++;
            }
            else if (!isFirstArrayEnded && !isSecondArrayEnded)
            {

                if (hasTwoNumersInMiddle)
                {
                    if (nums1[firstArrayPosition] <= nums2[secondArrayPosition])
                    {
                        firstNumber = nums1[firstArrayPosition];
                        firstArrayPosition++;
                    }
                    else
                    {
                        firstNumber = nums2[secondArrayPosition];
                        secondArrayPosition++;
                    }
                }
                else
                {
                    firstNumber = nums1[firstArrayPosition] <= nums2[secondArrayPosition] ? nums1[firstArrayPosition] : nums2[secondArrayPosition];
                }
            }

            isFirstArrayEnded = firstArrayPosition >= nums1.Length;
            isSecondArrayEnded = secondArrayPosition >= nums2.Length;

            if (!hasTwoNumersInMiddle)
            {
                return firstNumber;
            }

            if (isFirstArrayEnded && !isSecondArrayEnded)
            {
                secondNumber = nums2[secondArrayPosition];
            }
            else if (isSecondArrayEnded && !isFirstArrayEnded)
            {
                secondNumber = nums1[firstArrayPosition];
            }
            else if (!isFirstArrayEnded && !isSecondArrayEnded)
            {
                secondNumber = nums1[firstArrayPosition] <= nums2[secondArrayPosition] ? nums1[firstArrayPosition] : nums2[secondArrayPosition];
            }

            return Convert.ToDouble(firstNumber + secondNumber) / 2;
        }
    }
}

