public class SpiralMatrix {

    //  Time  Complexity | O(m × n) 
    //  Space Complexity | O(m × n) 

    // We maintain four boundaries (top, bottom, left, right) and repeatedly traverse the matrix in spiral order by moving right, down, left, up.
    // After completing each direction, we shrink the corresponding boundary to avoid revisiting elements.
    // We add checks before the last two traversals to ensure rows or columns still exist, preventing duplicates or out-of-bounds access.

    public IList<int> SpiralOrder(int[][] matrix)
    {
        int rowbegin = 0;
        int rowend = matrix.Length - 1;
        int colbegin = 0; int colend = matrix[0].Length - 1;
        List<int> list = new List<int>();
        if (matrix.Length == 0)
        {
            return list;
        }

        while (rowbegin <= rowend && colbegin <= colend)
        {
            for (int i = colbegin; i <= colend; i++)
            {
                list.Add(matrix[rowbegin][i]);
            }
            rowbegin++;
            for (int i = rowbegin; i <= rowend; i++)
            {
                list.Add(matrix[i][colend]);
            }
            colend--;
            if (rowbegin <= rowend)
            {
                for (int i = colend; i >= colbegin; i--)
                {
                    list.Add(matrix[rowend][i]);
                }
            }
            rowend--;
            if (colbegin <= colend)
            {
                for (int j = rowend; j >= rowbegin; j--)
                    list.Add(matrix[j][colbegin]);
            }
            colbegin++;

        }
        return list;
    }
}




