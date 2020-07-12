using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Implementation
{
    public class Apriori
    {
        private string filePath = @"E:\HK IV\Công nghệ phần mềm\HPMR\SoftwareEngineering\Implementation\demo.txt";
        private List<string> list;
        private List<string> DistinctValues;
        private List<ItemSet> ItemSets;

        public Apriori()
        {
            if (File.Exists(filePath))
            {
                list = File.ReadAllLines(filePath).ToList().Where(a => !string.IsNullOrWhiteSpace(a)).ToList();
            }
            else Console.WriteLine("File doesn't exist");
            ItemSets = new List<ItemSet>();

            SetDistinctValues(list);

            //List<List<string>> test = new List<List<string>>();
            //test.Add(new List<string>() { "A", "B" });
            //test.Add(new List<string>() { "A", "C" });
            //test.Add(new List<string>() { "A", "D" });
            //test.Add(new List<string>() { "A", "E" });
            //test.Add(new List<string>() { "B", "C" });
            //test.Add(new List<string>() { "B", "D" });
            //test.Add(new List<string>() { "B", "E" });
            //test.Add(new List<string>() { "C", "D" });
            //test.Add(new List<string>() { "C", "E" });
            //test.Add(new List<string>() { "D", "E" });
            //test.Add(new List<string>() { "1", "2","3" });
            //test.Add(new List<string>() { "1", "2", "4" });
            //test.Add(new List<string>() { "1", "3", "4" });
            //test.Add(new List<string>() { "1", "3", "5" });
            //test.Add(new List<string>() { "2", "3", "4" });

            //int k = 3;
            //int minSupport = 2;
            //List<List<string>> itemSet = new List<List<string>>();
            //itemSet = Apriori_Gen(test, k, minSupport);
            //foreach (var key in itemSet)
            //{
            //    Console.WriteLine(string.Join(" ", key));
            //}

            //Remove_Invalid_SetItem(ref itemSet, test);
            //Console.WriteLine("Removed");
            //foreach (var key in itemSet)
            //{
            //    Console.WriteLine(string.Join(" ", key));
            //}
        }

        

        private void Remove_Invalid_SetItem(ref List<List<string>> itemSet, List<List<string>> test)
        {
            List<List<string>> copy = new List<List<string>>();
            foreach (var variable in itemSet)
            {
                copy.Add(variable);
            }

            foreach (var item in copy)
            {
                for (int i = 0; i < item.Count; i++)
                {
                    List<string> temp = new List<string>();
                    temp.AddRange(item);
                    temp.RemoveAt(i);
                    bool isContain = false;
                    foreach (var t in test)
                    {
                        //var check = t.Except(temp).ToList();
                        if (t.Except(temp).ToList().Any()) continue;
                        else
                        {
                            isContain = true;
                            break;
                        }
                    }

                    if (!isContain)
                    {
                        itemSet.Remove(item);
                    }
                }
            }
        }

        private ItemSet Apriori_Gen(List<List<string>> input, int k, int minSupport)
        {
            List<List<string>> result = new List<List<string>>();

            for (int i = 0; i < input.Count - 1; i++)
            {
                for (int j = i + 1; j < input.Count; j++)
                {
                    bool isValid = true;
                    for (int t = 0; t < k - 1; t++)
                    {
                        if(input[i][t] == input[j][t]) continue;
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid == true)
                    {
                        List<string> temp = new List<string>();
                        temp.AddRange(input[i]);
                        temp.Add(input[j][k-1]);
                        result.Add(temp);
                    }
                    else continue;
                }
            }

            Remove_Invalid_SetItem(ref result, input);
            ItemSet itemSet = new ItemSet();

            foreach (var item in result)
            {
                int count = 0;
                foreach (var variable in list)
                {
                    var temp = variable.Trim().Split(" ");
                    bool isValid = true;
                    foreach (var t in item)
                    {
                        if(temp.Contains(t)) continue;
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid)
                        count++;
                }
                if(count>=minSupport)
                    itemSet.Add(item, count);
            }

            return itemSet;
        }

        private ItemSet Get_First_Candidate_ItemSet(int k)
        {
            ItemSet itemSet = new ItemSet();
            foreach (var item in DistinctValues)
            {
                List<string> data = new List<string>();
                data.Add(item);
                itemSet.Add(data, 0);

            }
            return itemSet;
        }

        private void SetDistinctValues(List<string> values)
        {
            List<string> data = new List<string>();
            foreach (var item in values)
            {
                var row = item.Split(' ');
                foreach (var item2 in row)
                {
                    if (string.IsNullOrWhiteSpace(item2)) continue;
                    if (!data.Contains(item2))
                        data.Add(item2);
                }
            }
            DistinctValues = new List<string>();
            DistinctValues.AddRange(data.OrderBy(a => a).ToList());
        }

        internal ItemSet Get_First_Frequent_ItemSet(int k, int minSupport)
        {
            ItemSet itemSet = Get_First_Candidate_ItemSet(k:1);
            foreach (var item in itemSet.Keys.ToList())
            {
                int count = 0;
                foreach (var item2 in list)
                {
                    var temp = item2.Trim().Split(" ");
                    if (temp.Contains(item[0]))
                        count++;
                }

                if (count >= minSupport)
                    itemSet[item] = count;
                else itemSet.Remove(item);
            }

            itemSet.Label = "L" + k.ToString();
            itemSet.Support = minSupport;
            return itemSet;
        }

        internal ItemSet Get_Frequent_ItemSet(int k, ItemSet itemSet, int minSupport)
        {
            ItemSet result = new ItemSet();
            result = Apriori_Gen(itemSet.Keys.ToList(), k, minSupport);
            result.Label = "L" + (k + 1).ToString();
            result.Support = minSupport;
            return result;
        }
    }
}
