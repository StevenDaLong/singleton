﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
代理模式：

优点：
    代理模式能够将调用用于真正被调用的对象隔离，在一定程度上降低了系统的耦合度；
    代理对象在客户端和目标对象之间起到一个中介的作用，这样可以起到对目标对象的保护。代理对象可以在对目标对象发出请求之前进行一个额外的操作，例如权限检查等。
缺点：
    由于在客户端和真实主题之间增加了一个代理对象，所以会造成请求的处理速度变慢
    实现代理类也需要额外的工作，从而增加了系统的实现复杂度。

*/
namespace DesignModel.DL
{
    public abstract class Person
    {
        public abstract void Buy(string str);
    }
    public class RealPerson:Person
    {
        public override void Buy(string str)
        {
            Console.WriteLine("im sam");
            Console.WriteLine($@"im buy {str}");
        }
    }

    public class Friend:Person
    {
        private RealPerson person;

        public Friend()
        {
            person = new RealPerson();
        }

        public override void Buy(string str)
        {
            Console.WriteLine("通过代理类访问sam");
            person.Buy(str);
        }

        public void SayBefore()
        {
            Console.WriteLine("before buy");
        }

        public void SayAfter()
        {
            Console.WriteLine("after buy");
        }
    }
}
