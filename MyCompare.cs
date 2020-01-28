using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 集合
{
    class MyCompare:IComparer
    {
        public int Compare(object x,object y)//比较方法，先将对象类型转换成字符串
        {
            string str1 = x.ToString();
            string str2 = y.ToString();
            return str1.CompareTo(str2);
        }
    }
}
