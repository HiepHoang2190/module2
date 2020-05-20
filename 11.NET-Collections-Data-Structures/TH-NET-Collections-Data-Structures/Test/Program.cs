using System;
using System.Collections;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Hashtable hash = new Hashtable();
            //    hash.Add("11", new Product()
            //    {
            //        Id = 1,
            //        Name = "IP6S"
            //    });
            //    hash.Add("22", new Product()
            //    {
            //        Id = 4,
            //        Name = "IP7S"
            //    });
            //    hash.Add("33", new Product()
            //    {
            //        Id = 2,
            //        Name = "IP8S"
            //    });
            //    hash.Add("44", new Product()
            //    {
            //        Id = 3,
            //        Name = "IP9S"
            //    });

            //    //foreach (var key in hash.Keys)
            //    //{
            //    //    Console.WriteLine(hash[key].ToString());
            //    //}
            //    //foreach (DictionaryEntry item in hash)
            //    //{
            //    //    Console.WriteLine($" {item.Value}");
            //    //}
            //    foreach (var key in hash.Keys)
            //    {
            //        Console.WriteLine(hash[key]);
            //    }
            //    foreach (var value in hash.Values)
            //    {
            //        Console.WriteLine(value);
            //    }
            //    hash.Add("55", new Product()
            //    {
            //        Id = 9,
            //        Name = "IPXS"
            //    });
            //    foreach (var key in hash.Keys)
            //    {
            //        Console.WriteLine(hash[key]);
            //    }
            //}
            //public class Product
            //{
            //    public int Id { get; set; }
            //    public string Name { get; set; }

            //    public override string ToString()
            //    {
            //        return $"Id: {Id}, Name: {Name}";
            //    }



            // Tạo 1 Queue rỗng
            //Queue MyQueue4 = new Queue();

            // Thực hiện thêm vài phần tử vào Queue thông qua hàm Enqueue.
            //MyQueue4.Enqueue("HowKteam");
            //MyQueue4.Enqueue("Free");
            //MyQueue4.Enqueue("Education");

            //// Thử sử dụng các phương thức của Queue.
            //Console.WriteLine(" So phan tu hien tai cua Queue la: {0}", MyQueue4.Count);

            //// Lưu ý ở đây ta chỉ muốn xem giá trị mà không muốn nó khỏi Queue thì ta sẽ dùng Peek.
            //Console.WriteLine(" Phan tu dau cua Queue la: {0}", MyQueue4.Peek());

            //// Thử kiểm tra lại số phần tử để chắc chắn rằng hàm Peek không xoá phần tử ra khỏi Queue.
            //Console.WriteLine(" So phan tu cua Queue sau khi goi ham Peek: {0}", MyQueue4.Count);

            //// Thực hiện xoá các phần tử ra khỏi Queue thông qua hàm Dequeue.
            //Console.WriteLine(" Popping...");
            //int Length = MyQueue4.Count;
            //for (int i = 0; i < Length; i++)
            //{
            //    Console.Write(" " + MyQueue4.Dequeue());
            //}
            //Console.WriteLine();

            //// Kiểm tra lại số phần tử của Queue sau khi Pop
            //Console.WriteLine(" So phan tu cua Queue sau khi Pop la: {0}", MyQueue4.Count);

            //Dictionary<string, string> MyHash = new Dictionary<string, string>(5);
            //MyHash.Add("FE", "Free Education");
            //MyHash.Add("K", "Kteam");
            //MyHash.Add("HK", "HowKteam");

            //foreach(KeyValuePair<string, string> item in MyHash)
            //{
            //    Console.WriteLine($"{item.Key}\t {item.Value}");
            //}
            //Console.WriteLine(MyHash["FE"]);
            MyGeneric<int> MyG = new MyGeneric<int>(5);
            MyG.SetItemValue(0, 10);
           
        }

        public class MyGeneric<T>
        {
            private T[] items;
            public T[] Items
            {
                get => items;
            }
            public MyGeneric(int Size)
            {
                items = new T[Size];
            }
            public T GetByIndex(int Index)
            {
                if(Index<0 || Index >= items.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return items[Index];
                }
            }
            public void SetItemValue(int Index, T Value)
            {
                if(Index<0 || Index >= items.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    items[Index] = Value;
                }
            }
        }
    }
}
