public class Solution {
    //TC => O(m*n)
    //SC => O(1)
    public int MinimumTotal(IList<IList<int>> triangle) {
        if(triangle == null || triangle.Count == 0){
            return 0;
        }

        int n = triangle.Count;

        for(int i = n - 2; i >= 0; i--){
            for(int j = 0; j < triangle[i].Count; j++){
                triangle[i][j] += Math.Min(triangle[i+1][j], triangle[i+1][j+1]);
            }
        }
        return triangle[0][0];
    }
}