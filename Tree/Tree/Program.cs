using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class Program
    {
        private static Dictionary<int, TreeClass<int>> nodeByValue = new Dictionary<int, TreeClass<int>>();
        private static TreeClass<int> GetTreeNodeByValue(int value)
        {
            if(!nodeByValue.ContainsKey(value))
            {
                nodeByValue[value] = new TreeClass<int>(value, null);
            }
            return nodeByValue[value];  
        }
        private static void AddEdge(int parent,int child)
        {
            TreeClass<int>parentNode=GetTreeNodeByValue(parent);
            TreeClass<int>childNode=GetTreeNodeByValue(child);
            parentNode.AddChild(childNode);
            childNode.SetParent(parentNode);
        }
        private static void ReadTree()
        {
            int nodeCount=int.Parse(Console.ReadLine());
            for (int i = 0; i < nodeCount; i++)
            {
                string[] edge = Console.ReadLine().Split(' ').ToArray();
                AddEdge(int.Parse(edge[0]), int.Parse(edge[1]));
            }
        }
        private static TreeClass<int> GetRoot()
        {
            TreeClass<int> root=nodeByValue.Values.Where(x=>x.Parent==null).FirstOrDefault();
            return root;
        }
        static void Main(string[] args)
        {
         ReadTree();
            TreeClass<int>.PrintTree(GetRoot(),0);
        }
    }
}
