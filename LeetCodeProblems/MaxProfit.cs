namespace LeetCodeProblems;

// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/

public class MaxProfit
{
    public int Solution(int[] prices)
    {
        int maxProfit = 0;
        int profit;
        int buy = 0;
        int sell = 1;
        while (sell < prices.Length)
        {
            if (prices[sell] < prices[buy])
            {
                buy = sell;
                sell++;
            }
            else
            {
                profit = prices[sell] - prices[buy];
                sell++;
                if (profit > maxProfit)
                {
                    maxProfit = profit;
                }
            }
        }

        return maxProfit;
    }
}