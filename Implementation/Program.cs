using System;
using System.Collections.Generic;
using System.IO;

namespace Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Apriori apriori = new Apriori();
            List<ItemSet> ItemSets = new List<ItemSet>();

            int k = 1;
            int minSupport = 2;

            var firstCandidateItemSet = apriori.Get_First_Frequent_ItemSet(k, minSupport);

            if (firstCandidateItemSet.Count > 0)
                ItemSets.Add(firstCandidateItemSet);
            else return;

            Console.WriteLine("*************************");
            Console.WriteLine("{0} :", firstCandidateItemSet.Label);
            foreach (var item in firstCandidateItemSet.Keys)
            {
                Console.WriteLine("{0}, {1}", string.Join(" ", item), firstCandidateItemSet[item]);
            }

            var temp = firstCandidateItemSet;

            bool next;
            do
            {
                next = false;
                var frequent = apriori.Get_Frequent_ItemSet(k, temp, minSupport);

                Console.WriteLine("*************************");
                Console.WriteLine("{0} :", frequent.Label);
                foreach (var item in frequent.Keys)
                {
                    Console.WriteLine("{0}, {1}", string.Join(" ", item), frequent[item]);
                }

                if (frequent.Count > 0)
                    ItemSets.Add(frequent);
                else return;
                ++k;
                temp = frequent;
                next = true;

            } while (next);

        }
    }
}
