public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1;
        int right = 0;
        foreach (int i in piles) {
            if (i > right)
                right = i;
        }

        int result = right;

        while (left <= right) {
            int mid = left + (right - left) / 2;

            if (CanEatAll(piles, h, mid)) {
                result = mid;
                right = mid - 1;
            } else {
                left = mid + 1;
            }
        }
        return result;
    }

    private bool CanEatAll(int[] piles, int h, int speed) {
        int totalHour = 0;

        foreach (var pile in piles) {
            totalHour += (pile + speed - 1) / speed;

            if (totalHour > h) return false;
        }

        return totalHour <= h;
    }
}
