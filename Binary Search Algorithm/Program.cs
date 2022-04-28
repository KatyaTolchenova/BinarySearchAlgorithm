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

// Direct solution - O(n)
int[] nums = { 2, 3, 5, 7, 9 };
int target = 17;
bool flag = false;

for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] == target)
    {
        Console.WriteLine("Element is found at index " + i.ToString());
        flag = true;
        break;
    }
}

if (!flag)
    Console.WriteLine("Element is not found");