public class DiagonalTraverse {

    // Time Complexity: O(m × n) — every element is visited exactly once.
    // Space Complexity: O(1) extra space (excluding the output array).

    //Start from the top-left and traverse the matrix diagonally.

    // Flip direction when hitting the matrix boundaries (top, bottom, left, right).

    // Keep updating the result array as you move in up-right or down-left directions.
    public int[] FindDiagonalOrder(int[][] mat)
    {
        int m = mat.Length;
        int n = mat[0].Length;

        int[] result = new int[m * n];
        int r = 0, c = 0;

        bool up = true;
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = mat[r][c];
            if (up)
            {
                if (r == 0 && c != n - 1)
                {
                    c++;
                    up = false;
                }
                else if (c == n - 1)
                {
                    r++;
                    up = false;
                }
                else
                {
                    r--;
                    c++;
                }
            }
            else
            {
                if (c == 0 && r != m - 1)
                {
                    r++;
                    up = true;
                }
                else if (r == m - 1)
                {
                    up = true;
                    c++;
                }
                else
                {
                    c--;
                    r++;
                }
            }
        }

        return result;
    }
}


