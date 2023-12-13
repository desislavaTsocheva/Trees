using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class Trees<T>
    {
        private T value;
        private IList<Trees<T>> children;
        public Trees(T value, params Trees<T>[] children)
        {
            this.value = value;
            this.children = children;
        }
        public void Print(int indent=0)
        {
            Console.WriteLine(new string(' ',2*indent));
            Console.WriteLine(this.value);
            foreach (var child in this.children)
            {
                child.Print(indent+1);    
            }
        }
    }
}
