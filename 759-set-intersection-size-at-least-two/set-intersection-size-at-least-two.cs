public class Solution {
    public int IntersectionSizeTwo(int[][] intervals) {
        Array.Sort(intervals, (a,b) => { return a[1] - b[1]; });
        int older = -1;
        int newer = -1;
        int count = 0;
        foreach(var i in intervals){
           int inside = 0;
           if (older >= i[0]){
                inside = inside + 1;
           }
           if (newer >= i[0]){
                inside = inside + 1;
           }
           if (inside == 2){
           }
           else if(inside == 1) {
                older = newer;
                newer = i[1];
                if (older == newer){
                    older = newer -1;
                }
                count = count + 1;
           }
           else{
                older = i[1] - 1;
                newer = i[1];
                count = count + 2;
           }
        }
        return count;
    }
}