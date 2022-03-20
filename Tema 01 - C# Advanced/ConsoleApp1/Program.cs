using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Set<int> x = new Set<int>();
            x.Insert(1);
            x.Insert(2);
            x.Insert(3);
            x.Insert(4);
            Console.WriteLine($"X: {x}");//Ateleaza automat ToString() pt ca am facut overrride
            Console.Write("Filter X < 3: ");
            Console.WriteLine(x.Filter(f => f < 3));

            Set<int> y = new Set<int>();
            y.Insert(10);
            y.Insert(2);
            y.Insert(53);
            y.Insert(4);
            Console.WriteLine($"Y: {y}");//Ateleaza automat ToString() pt ca am facut overrride
            Console.Write("Filter Y < 8: ");
            Console.WriteLine(y.Filter(z => z < 8));
            Console.Write("Merge y in x: ");
            Console.WriteLine(x.Merge(y));
        }
        public class Set<T>
        {
            public List<T> listData = new List<T>();
            public void Insert(T item)
            {
                listData.Add(item);
            }
            public void Remove(T item)
            {
                listData.Remove(item);
            }
            public bool Contains(T item)
            {
                if (listData.Exists(x => x.Equals(item)))
                    return true;
                else
                    return false;
            }
            public Set<T> Merge(Set<T> other)
            {
                foreach (T item in other.listData)
                {
                    try
                    {

                        if (Contains(item))
                        {
                            throw new Exception($"Item {item} exists!");
                        }
                        else
                        {
                            this.listData.Add(item);
                        }
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }


                return this;
            }

            public Set<T> Filter(Func<T, bool> condition)
            {
                Set<T> result = new Set<T>();
                IEnumerable<T> temp = this.listData.Where(condition);
                foreach (var item in temp)
                {
                    result.listData.Add(item);
                }

                return result;
            }

            public override string ToString()
            {
                string result = "";
                foreach (T item in this.listData)
                    result += item.ToString() + "; ";
                return result;
            }
        }
    }
}