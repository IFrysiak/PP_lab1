using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_lab1
{
    class Item
    {
        public int Value { get; set; }
        public int Weight { get; set; }
        public int OriginalIndex { get; set; }
        public Item(int value, int weight, int originalIndex)
        {
            Value = value;
            Weight = weight;
            OriginalIndex = originalIndex;
        }
    }
}
