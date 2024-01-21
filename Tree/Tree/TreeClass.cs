using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class TreeClass<T>
    {
        public T Value { get; set; }
        public TreeClass<T> Parent { get; set; }
        public List<TreeClass <T>> Children { get; set;}

        public TreeClass(T value, params TreeClass<T>[] children)
        {
           this.Value = value;
            if (children == null)
            {
                this.Children = new List<TreeClass<T>>();
            }
            else
            {
                foreach (var child in children)
                {
                    this.Parent = this;
                }
            }
        } 
        public void AddChild(TreeClass<T> newChild)
        {
            this.Children.Add(newChild);
        }
        public void SetParent(TreeClass<T> parent)
        {
            this.Parent = parent;
        }
        public static void PrintTree(TreeClass<T> node,int offset)
        {
            Console.WriteLine("{0}{1}",new string (' ',offset*2),node.Value);
            foreach (var child in node.Children)
            {
                PrintTree(child, offset + 1);
            }    
        }

    }
}
