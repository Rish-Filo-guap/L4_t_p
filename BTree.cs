using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_t_p
{
    public class BTree
    {
        public int value;
        public BTree left;
        public BTree right;
        public BTree(int value) { 
         this.value = value;
        }
        public void AddChild(BTree btree) { 
            if (left == null)
            {
                left = btree;
                return;
            }
            if (left.value > btree.value)
            {
                right = left;
                left = btree;
            }
            else { 
                right = btree;
            }
        }
    }
}
