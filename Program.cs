using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 集合
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1.
               测试动态数组ArrayList
             */
            ArrayList list1 = new ArrayList() { 1, 2, 3, 4 };
            foreach(var v in list1)
            {
                Console.WriteLine(v);
            }

            /*
             * 2.查找集合中的元素，使用 IndexOf 
             * 或者 LastlndexOf 都可以，代码如下。
             */
            ArrayList list2 = new ArrayList() { "sas", "abc", "bbbb", 5, 6 };
            int index = list2.IndexOf("abc");
            if (index != -1)
            {
                Console.WriteLine("数组中存在abc");
            }
            else
            {
                Console.WriteLine("数组元素中没有abc");
            }



            /*
             3.将集合中下标为偶数的元素添加到另一个集合中;
             由于集合中共有 5 个元素，则所添加元素的下标分别为 0、2、4;
             向集合中添加元素使用Add方法即可。
             */
            ArrayList list3 = new ArrayList() { "aaa", "bbb", "abc", 123, 568 };
            ArrayList NewList = new ArrayList();
            for(int i=0; i < list3.Count; i=i + 2)
            {
                NewList.Add(list3[i]);
            }
            foreach(var v in NewList)
            {
                Console.WriteLine(v);
            }


            /*
             在集合中的第一个元素后面添加元素，使用 Insert 方法每次只能添加一个元素，
             但使用 InsertRange 方法能直接将一个集合插入到另一个集合中。
             */
            ArrayList list4 = new ArrayList() { "aaa","bbb","abc",123,456};
            ArrayList insertRange = new ArrayList() { "插入的内容", 56 };
            list4.InsertRange(1, insertRange);
            foreach(var v in list4)
            {
                Console.WriteLine(v);
            }

            /*
             将集合中的元素使用 Sort 方法排序后输出。
             如果使用 Sort 方法对集合中的元素排序，则需要将集合中的元素转换为同一类型才能比较，
             否则会出现无法比较的异常。
             */
            ArrayList list5 = new ArrayList() { "元素1",  "元素3", "元素2", "元素1" };
            list5.Sort();
           //list5.Reverse();//从大到小排序（相当于倒置）
            foreach(var v in list5)
            {
                Console.WriteLine(v);
            }

            /*
             定义一个 ArrayList 类型的集合，并在其中任意存放 5 个值，使用 Sort 方法完成排序并输岀结果。
             由于没有在集合中指定统一的数据类型，需要用自定义比较器来完成排序，自定义比较器类 MyCompare
             */
            ArrayList list6 = new ArrayList() { "a", "b", "c", 1, 2 };
            MyCompare myCompare = new MyCompare();
            list6.Sort(myCompare);
            foreach (var v in list6)
            {
                Console.WriteLine(v);
            }


            /*
             创建 Queue 类的实例，模拟排队购电影票的操作。
             */
            Queue queue = new Queue();
            //向队列里面存入数据
            queue.Enqueue("小明");
            queue.Enqueue("小张");
            queue.Enqueue("小王");
            Console.WriteLine("开始购票:");
            while (queue.Count != 0)
            {
                Console.WriteLine(queue.Dequeue() + "已购票!");
            }

            Console.WriteLine("购票结束！");

            /*
             向 Queue 类的实例中添加 3 个值，在不移除队列中元素的前提下将队列中的元素依次输出。
             */
            Queue queue1 = new Queue();
            queue1.Enqueue("aaa");
            queue1.Enqueue("bbb");
            queue1.Enqueue("ccc");
            object[] obj = queue1.ToArray();
            foreach(var v in obj)
            {
                Console.WriteLine(v);
            }


            Console.WriteLine("##########################################################");

            /*
             除了使用 ToArray() 方法以外，还可以使用 GetEnumerator() 方法来遍历
             */
            IEnumerator enumerator = queue1.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }



            /*
             创建一个栈（Stack），模拟餐馆盘子的存取。
             先在栈中按顺序放置 5 个盘子，再将所有盘子取出，取盘子时应先取最上面的盘子，与栈的存取原理一致
             */
            Stack stack = new Stack();
            stack.Push("1号盘子");
            stack.Push("2号盘子");
            stack.Push("3号盘子");
            stack.Push("4号盘子");
            stack.Push("5号盘子");
            Console.WriteLine("取出盘子:");
            // 判断栈中是否有元素
            while (stack.Count != 0)
            {
                //取出栈中的元素
               Console.WriteLine( stack.Pop());
            }


            /*
             使用 Hashtable 集合实现图书信息的添加、查找以及遍历的操作。
             */
            Console.WriteLine("**************图书系统*************");
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "《计算机基础》");
            hashtable.Add(2, "《C#编程》");
            hashtable.Add(3, "《数据库原理》");
            Console.WriteLine("请输入图书编号：");
            int id = int.Parse(Console.ReadLine());
            bool flag = hashtable.ContainsKey(id);
            if (flag)
            {
                Console.WriteLine("您查找的图书名称为：{0}", hashtable[id].ToString());
            }
            else
            {
                Console.WriteLine("您查找的图书不存在！");
            }

            Console.WriteLine("所有的图书信息如下：");
            foreach(DictionaryEntry d in hashtable)
            {
                int key = (int)d.Key;
                string value = d.Value.ToString();
                Console.WriteLine("图书编号为：{0}；图书名称为：{1}", key, value);
            }

            /*
             使用 SortedList 实现挂号信息的添加、查找以及遍历操作。
             */
            Console.WriteLine("**************挂号系统*************");
            SortedList sortedList = new SortedList();
            sortedList.Add(1, "小张");
            sortedList.Add(2, "小王");
            sortedList.Add(3, "小李");
            Console.WriteLine("请输入挂号编号：");
            int id1 = int.Parse(Console.ReadLine());
            bool flag1 = sortedList.ContainsKey(id1);
            if (flag1)
            {
                string name = sortedList[id1].ToString();
                Console.WriteLine("您查找的患者姓名为：{0}", name);
            }
            else
            {
                Console.WriteLine("您查找的挂号编号不存在！");
            }
            Console.WriteLine("所有的挂号信息如下："); foreach (DictionaryEntry d in sortedList)
            {
                int key = (int)d.Key;
                string value = d.Value.ToString();
                Console.WriteLine("挂号编号：{0}，姓名：{1}", key, value);
            }


            Console.ReadLine();
        }
    }
}
