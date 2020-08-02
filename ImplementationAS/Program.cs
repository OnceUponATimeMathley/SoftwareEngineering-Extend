using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationAS
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"E:\HK IV\Công nghệ phần mềm\HPMR\SoftwareEngineering\ImplementationAS\demo.txt";
            Apriori apriori = new Apriori(filePath);
            List<ItemSet> ItemSets = new List<ItemSet>();
            List<List<AssociationRule>> AssociationRules = new List<List<AssociationRule>>();

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
                else break;
                ++k;
                temp = frequent;
                List<AssociationRule> rules = new List<AssociationRule>();
                rules = apriori.GetRules(frequent);
                AssociationRules.Add(rules);
                Console.WriteLine("Association Rule L{0}", k);
                Console.WriteLine(string.Format("{0, -10} | {1,-10} | {2,5}", "Rule", "Confidence", "Support"));
                foreach (var variable in rules)
                {
                    Console.WriteLine(string.Format("{0, -10} | {1,-10} | {2,5}", variable.Label, variable.Confidence, variable.Support));
                }
                next = true;

            } while (next);

            Console.ReadLine();
            //Console.WriteLine("***************************");
            //Console.WriteLine("Association Rule");
            //Console.WriteLine("***************************");

            //foreach (var item in AssociationRules)
            //{
            //    foreach (var variable in item)
            //    {
            //        Console.WriteLine(string.Format("{0, -10} | {1,-10} | {2,5}", variable.Label, variable.Confidence, variable.Support));
            //    }
            //}
        }
    }
}
