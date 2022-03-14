using System;
using System.Collections.Generic;

namespace tema1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }
        public class Set<T>

        {
            public string SetData { get; set; }
            public int DataID { get; set; }
            public List<string> ListData = new List<string>();
            public List<string> ListID = new List<string>();

            public string PrintSet()
            { return "ID" + DataID + " Data:" + SetData; }
            bool Contains(T item)
            {

                if(ListData.Any(x=>x.data.Equals(item.data)))

                //
               int dx = ListData.IndexOf(item);

                if (dx > 0) return true;
                return false;



            }

            void Insert(T item)
            {
                if (Contains(item)) 
                try
                {
                        ListData.Insert(ListData.Count, item.data);
                        ListID.Insert(ListID.Count, item.ID);

                    }
                catch
                { }
                finally
                { }
            }
            void Remove(T item)
            {   var rmv=ListData.Single(r => r.)
            
            
            }
            
            Set<T> Merge(Set<T> other)
            { }
            void Filter()
            { }


        }
    }
}
