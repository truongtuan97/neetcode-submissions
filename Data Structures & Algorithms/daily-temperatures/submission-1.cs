public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int size = temperatures.Length;
        int[] result = new int[size];
        for (int i=0; i<size; i++) {
            result[i] = 0;
        }
        
        for (int i=0; i<size; i++) {
            for (int j=i+1; j<=size-1; j++) {
                if (temperatures[j] > temperatures[i]) {
                    result[i] = j-i;                    
                    break;
                }
            }            
        }
        return result;
    }
}
