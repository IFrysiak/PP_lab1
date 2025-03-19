using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_lab1
{
    class Result
    {
        public int[] SelectedItems { get; set; }
        public int TotalValue { get; set; }
        public int TotalWeight { get; set; }

        public Result(int[] selectedItems, int totalValue, int totalWeight)
        {
            SelectedItems = selectedItems;
            TotalValue = totalValue;
            TotalWeight = totalWeight;
        }

        public override string ToString()
        {
            return $"Selected Items: {string.Join(", ", SelectedItems.OrderBy(i => i))} \nTotal Value: {TotalValue} \nTotal Weight: {TotalWeight}";
        }
    }
}
