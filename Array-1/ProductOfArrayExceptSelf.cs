public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        //Time Complexity:
        // O(n)
        // Space Complexity:
        // O(1)
        
//         First, we build the prefix product array where each index stores the product of all elements to its left.
// Then, we traverse from the right while maintaining a running product of elements to the right and multiply it with the prefix value.
// This gives the product of all elements except the current one in linear time using constant extra space.

        int length =nums.Length;
        int[] answer = new int[length];

        answer[0]=1;
        for(int i=1;i<length;i++)
        {
            answer[i]=answer[i-1]* nums[i-1];
        }

        int rp =1;
        for(int i=length-2;i>=0;i--)
        {
              rp =rp* nums[i+1];
             answer[i] = answer[i] * rp;
        }
       return answer;
    }
}
