public class Solution {
    public int MaxProfit(int[] prices) {
        int size = prices.Length;
        int minPrice = prices[0];
        int maxProfit = 0;

        for (int i=1; i<size; i++) {
            if (minPrice >= prices[i]) {
                minPrice = prices[i];
            }
            maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
        }
        return maxProfit;
    }
}
