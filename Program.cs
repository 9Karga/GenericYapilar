using System;
using System.Collections.Generic;

namespace GenericYapilar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> citys = new List<string>();
            citys.Add("İstanbul");
            Console.WriteLine(citys.Count);
            
            
            // "MyList" ile yukarıdaki "List" in nasıl çalıştığının örneğini oluşturduk.

            MyList<string> citys2 = new MyList<string>();
            citys2.Add("Ankara");
            Console.WriteLine(citys2.Count);
            
            Console.ReadLine();
    
        }

        class MyList<T>
        {
            T[] _arry;
            T[] _tempArry;

            public MyList()
            {
                _arry = new T[0];
            }

            public void Add(T item)
            {
                _tempArry = _arry;
                _arry = new T[_arry.Length + 1];
                for (int i = 0; i < _tempArry.Length; i++)
                {
                    _arry[i] = _tempArry[i];
                }

                _arry[_arry.Length - 1] = item;

            }

           
            public int Count
            {
                get { return _arry.Length; }
               
            }


        }


    }
    
    
}
