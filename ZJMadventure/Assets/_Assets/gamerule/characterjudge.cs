using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

    public class gamerule //1：定义一个public的类 
    {
        private static gamerule instance;
        //2：定义一个私有的静态变量来保持类的实例 
        private static readonly object locker = new object(); //3：定义一个标示确保线程同步 
        private gamerule() { } //4：定义一个私有的静态构造函数，使外界不能创建该类实例 
        public static gamerule g() //5：定义一个public静态的方法，提供一个全局访问点，同时也可以定义共有属性来提供全局访问点 
        {
            if (instance == null) //6：第一次判断类的实例是否存在，或者为空 
            { //7：当第一个程序运行到这里时，此时会对locker对象“加锁” // ·当第二个线程运行该方法时，首先检测locker对象为“加锁”状态，该线程就会挂起等待第一个线程“解锁” // ·lock语句运行完之后（即线程运行完之后）会对该对象“解锁” // ·双重锁定只需要一句判断就可以了
                lock (locker)
                {
                    if (instance == null) //8：第二次判断类的实例是否存在，或者为空
                    {
                        instance = new gamerule(); //9：如果类的实例不存在则创建一个 
                    }
                }
            }
            return instance; //10：如果类的实例存在，直接返回 
        }
    public int green=0;
        
    }

