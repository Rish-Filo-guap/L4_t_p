using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace L4_t_p
{
    public class BNode
    {
        public int Value { get; set; }
        public BNode left;
        public BNode right;
        public Point coords;
        public BNode(int value) { 
         Value = value;
        }
        public BNode? Find(int value) { 
            if (Value == value) {
                return this;
            }

                if (value > Value && right!=null) { 
                    return right.Find(value);
                }

                if (value < Value && left!=null) { 
                    return left.Find(value);
                }
            return null;

        } 
        
    }
    public class BTree {
        public BNode? tree;
        public BTree() {
            Random rnd = new Random();
            int[] sequence = new int[rnd.Next(3, 22)];
            int k = 0;
            while (k < sequence.Length) {
                var n = rnd.Next(1, 100);
                if (!sequence.Contains(n)) {

                    sequence[k] = n;
                    k++;
                }
                
            }
            

            // Строим сбалансированное бинарное дерево
            //BNode root = null;
            foreach (int value in sequence)
            {
                tree = Insert(tree, value);
            }
        }
        public BNode Insert(BNode? root, int value)
        {
            if (root == null)
            {
                return new BNode(value);
            }

            if (value < root.Value)
            {
                root.left = Insert(root.left, value);
            }
            else
            {
                root.right = Insert(root.right, value);
            }

            // Балансируем дерево после вставки
            int balanceFactor = GetBalanceFactor(root);
            if (balanceFactor > 1)
            {
                if (GetBalanceFactor(root.left) < 0)
                {
                    root.left = leftRotate(root.left);
                }
                root = rightRotate(root);
            }
            else if (balanceFactor < -1)
            {
                if (GetBalanceFactor(root.right) > 0)
                {
                    root.right = rightRotate(root.right);
                }
                root = leftRotate(root);
            }

            return root;
        }

        // Вычисление фактора баланса узла
        public int GetBalanceFactor(BNode node)
        {
            if (node == null)
            {
                return 0;
            }

            return GetHeight(node.left) - GetHeight(node.right);
        }

        // Вычисление высоты дерева
        public int GetHeight(BNode node)
        {
            if (node == null)
            {
                return 0;
            }

            return 1 + Math.Max(GetHeight(node.left), GetHeight(node.right));
        }

        // Левый поворот
        public BNode leftRotate(BNode node)
        {
            BNode newRoot = node.right;
            node.right = newRoot.left;
            newRoot.left = node;

            return newRoot;
        }

        // Правый поворот
        public BNode rightRotate(BNode node)
        {
            BNode newRoot = node.left;
            node.left = newRoot.right;
            newRoot.right = node;

            return newRoot;
        }


    }
}
