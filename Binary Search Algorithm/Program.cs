/* Given a sorted array of n integers and a target value, 
 * determine if the target exists in the array in logarithmic 
 * time using the binary search algorithm.
 * If target exists in the array, print the index of it.*/

/* Input:
nums[] = [2, 3, 5, 7, 9]
target = 7
Output: Element found at index 3
 
Input:
nums[] = [1, 4, 5, 8, 9]
target = 2
Output: Element not found */

// Binary Search Algorithm
static int binarySearch(int[] nums, int target)
{
    // search space is nums[left…right]
    int min = 0;
    int max = nums.Length - 1;

    // loop till the search space is exhausted
    while (min <= max)
    {
        int mid = (min + max) / 2;

        // target is found
        if (target == nums[mid])
        {
            return mid;
        }
        // discard all elements in the right search space,
        // including the middle element
        else if (target < nums[mid])
        {
            max = mid - 1;
        }
        // discard all elements in the left search space,
        // including the middle element
        else
        {
            min = mid + 1;
        }
    }

    // target doesn't exist in the array
    return -1;
}


int[] nums = { 2, 3, 5, 7, 9 };
int target = 7;

int index = binarySearch(nums, target);

if (index != -1)
    Console.WriteLine("Element found at index " + index);
else
    Console.WriteLine("Element not found in the array");
