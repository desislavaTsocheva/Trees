using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Trees<int> tree = new Trees<int>
                (
                7, new Trees<int>(19,
                new Trees<int>(1), 
                new Trees<int>(12), 
                new Trees<int>(31)
                ),
                new Trees<int>(21),
                new Trees<int>
                (
                    14, 
                new Trees<int>(23,
                new Trees<int>(6)
                )
                ));
        }
    }
}
