using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation
{
    public class ItemSet : Dictionary<List<string>, int>
    {
        public string Label { get; set; }
        public int Support { get; set; }
    }
}
