using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace L4_t_p
{
    public class BTree
    {
        public int value;
        public BTree left;
        public BTree right;
        public Point coords;
        public BTree(int value) { 
         this.value = value;
        }
        public BTree Find(int value) { 
            if (this.value == value) {
                return this;
            }

                if (value > this.value && right!=null) { 
                    return right.Find(value);
                }

                if (value < this.value && left!=null) { 
                    return left.Find(value);
                }
            return null;

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
