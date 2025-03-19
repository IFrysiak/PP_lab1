using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_lab1
{
    class Problem
    {
        public int ItemCount { get; set; }
        public Item[] Items { get; set; }
        public Problem(int n, int seed)
        {
            ItemCount = n;
            Items = new Item[n];

            Random random = new Random(seed);
            for (int i = 0 ; i < n ; i++)
            {
                Items[i] = new Item(random.Next(1, 11), random.Next(1, 11), i + 1);
            }
        }

        public Result Solve(int capacity)
        {
            var sortedItems = Items.OrderByDescending(i => (double)i.Value / (double)i.Weight).ToArray();
            int totalValue = 0, totalWeight = 0;
            int[] selectedItems = new int[ItemCount];
            int count = 0;

            for (int i = 0 ; i < sortedItems.Length ; i++)
            {
                if (totalWeight + sortedItems[i].Weight <= capacity)
                {
                    selectedItems[count++] = sortedItems[i].OriginalIndex;
                    totalWeight += sortedItems[i].Weight;
                    totalValue += sortedItems[i].Value;
                }
            }

            return new Result(selectedItems.Take(count).ToArray(), totalValue, totalWeight);
        }

        public override string ToString()
        {
            return string.Join("\n", Items.Select((item, index) => $"{index + 1}: Value={item.Value} \tWeight={item.Weight} \tRatio={(double)item.Value / item.Weight:F2}"));
        }
    }
}
