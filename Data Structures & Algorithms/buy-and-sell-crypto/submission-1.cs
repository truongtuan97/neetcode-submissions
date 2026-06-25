public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;

        for (int i=0; i<prices.Length - 1; i++) {
            for (int j=i+1; j<prices.Length; j++) {
                maxProfit = Math.Max(prices[j] - prices[i], maxProfit);
            }
        }
        return maxProfit;
    }
}
