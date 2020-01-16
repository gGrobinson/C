using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryList
{
     class AVLTree<T> : BSTree<T> where T : IComparable
    {
        public new void InsertItem(T item)
        {
            insertItem(item, ref node);
        }




        private void rotateLeft(ref Node<T> tree)
        {
            if (tree.Right.BalanceFactor > 0)  //double rotate
                rotateRight(ref tree.Right);
            Node<T> oldroot = tree;
            Node<T> newroot = tree.Right;
            oldroot.Right = newroot.Left;
            newroot.Left = oldroot;
            tree = newroot;

        }



        private void rotateRight(ref Node<T> tree)
        {
            if (tree.Left.BalanceFactor < 0)  //double rotate
                rotateLeft(ref tree.Left);
            Node<T> oldroot = tree;
            Node<T> newroot = tree.Left;
            oldroot.Left = newroot.Right;
            newroot.Right = oldroot;
            tree = newroot;

        }




        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
                tree = new Node<T>(item);
            else if (item.CompareTo(tree.Data) < 0)
                insertItem(item, ref tree.Left);


            else if (item.CompareTo(tree.Data) > 0)
                insertItem(item, ref tree.Right);
            tree.BalanceFactor = Height(ref tree.Left) -
            Height(ref tree.Right);

            if (tree.BalanceFactor <= -2)
                rotateLeft(ref tree);

            if (tree.BalanceFactor >= 2)
                rotateRight(ref tree);

        }

    }
}

