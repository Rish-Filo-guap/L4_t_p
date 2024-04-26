using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace L4_t_p
{
    public class BNode//класс корня
    {
        public int Value { get; set; }
        public BNode left;
        public BNode right;
        public Point coords;
        public BNode(int value) { 
         Value = value;
        }
        public BNode? Find(int value) { //найти корень по значению
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

        public BNode? FindParent(int value, BNode bNode)//найти родителя корня 
        {
            if (Value == value)
            {
                return bNode;
            }

            if (value > Value && right != null)
            {
                return right.FindParent(value, this);
            }

            if (value < Value && left != null)
            {
                return left.FindParent(value, this);
            }
            return null;

        }

    }
    public class BTree {//класс дерева
        public BNode? tree;//главный корень дерева
        private List<int> sequence;//список значений корней
        public BTree() {
            Random rnd = new Random();
            int cnt = rnd.Next(3, 22);
            sequence = new List<int>();
            int k = 0;
            while (k < cnt) {
                var n = rnd.Next(1, 100);
                if (!sequence.Contains(n)) {

                    sequence.Add(n);
                    k++;
                }
                
            }
            BuildTree();

        }
        public void BuildTree() { //построить дерево

            foreach (int value in sequence)
            {
                tree = Insert(tree, value);
            }
        
        }
        public bool AddValue(int value) {//добавить корень
            if (tree == null || tree.Find(value)==null) {
                tree = Insert(tree, value);
                sequence.Add(value);
                return true;
            }else return false;
            
        }
        
        public bool Del(int value) {//удалить выбранную вершину
            if (tree != null)
            {
               if (sequence.Contains(value))
                {
                    sequence.Remove(value);
                    tree = null;
                    BuildTree();
                    return true;
                }
               else return false;

            } else return false;

        }
        public BNode Insert(BNode? root, int value)//вставить корень в дерево
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

            return Balance(root); 
        }
        public BNode Balance(BNode root) {//сбалансировать дерево после вставки значения
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
        
        public int GetBalanceFactor(BNode node) // вычисление фактора баланса узла
        {
            if (node == null)
            {
                return 0;
            }

            return GetHeight(node.left) - GetHeight(node.right);
        }

        
        public int GetHeight(BNode node) // вычисление высоты дерева
        {
            if (node == null)
            {
                return 0;
            }

            return 1 + Math.Max(GetHeight(node.left), GetHeight(node.right));
        }

        
        public BNode leftRotate(BNode node)// Левый поворот
        {
            BNode newRoot = node.right;
            node.right = newRoot.left;
            newRoot.left = node;

            return newRoot;
        }

        
        public BNode rightRotate(BNode node)// Правый поворот
        {
            BNode newRoot = node.left;
            node.left = newRoot.right;
            newRoot.right = node;

            return newRoot;
        }


    }
}
