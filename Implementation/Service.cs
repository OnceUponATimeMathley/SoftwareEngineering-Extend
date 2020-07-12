﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation
{
    public static class Service
    {
        public static string ToDisplay(this List<string> list, string separator = ", ")
        {
            if (list.Count == 0)
                return string.Empty;
            StringBuilder sb = new StringBuilder();
            sb.Append(list[0]);
            for (int i = 1; i < list.Count; i++)
            {
                sb.Append(string.Format("{0}{1}", separator, list[i]));
            }
            return sb.ToString();
        }

        public static string ToDisplay(this List<string> list, string exclude, string separator = ", ")
        {
            List<string> dump = new List<string>();
            foreach (var item in list)
            {
                if (item == exclude) continue;
                dump.Add(item.ToString());
            }
            return dump.ToDisplay();
        }
    }
}
