using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public interface IClass1
    {
        public int MyProperty { get; set; }
        public void print(string str);
    }
    public class Class1 : IClass1
    {
        public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void print(string str)
        {
            Console.WriteLine(str);
        }
    }

    public class Class2
    {
        private readonly IClass1 class1;

        public Class2(IClass1 class1) : base()
        {
            this.class1 = class1;
        }

        public void print2(string str)
        {
            class1.print(str);
            
        }

        public void print2(string str , int i)
        {
            class1.print(str + i);

        }
    }
}
