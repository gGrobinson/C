using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryList
{ 
 class BSTree<T> : BinTree<T> where T : IComparable
{  //root declared as protected in Parent Class – Binary Tree
    public BSTree()
    {
        node = null;
    }
    public BSTree(Node<T> node)
    {
        this.node = node;
    }
    public void InsertItem(T item)
    {
        insertItem(item, ref node);
    }

    private void insertItem(T item, ref Node<T> tree)
    {
        if (tree == null)
        {
            tree = new Node<T>(item);
        }
        else if (item.CompareTo(tree.Data) < 0)
        {
            insertItem(item, ref tree.Left);

        }
        else if (item.CompareTo(tree.Data) > 0)
        {
            insertItem(item, ref tree.Right);
        }

    }

    public int height()
    {
        return Height(ref node);
    }
    protected int Height(ref Node<T> tree)
    {
        if (tree == null)
        {
            return 0;
        }
        else
        {
            return (1 + Math.Max(Height(ref tree.Left), Height(ref tree.Left)));
        }
    }

    public int count()
    {
        return Count(ref node);
    }
    private int Count(ref Node<T> tree)
    {
        if (tree == null)
        {
            return 0;
        }
        int left = Count(ref tree.Left);
        int right = Count(ref tree.Right);
        return left + right + 1;
    }

    public Boolean Contains(T item)
    {
        Boolean isPresent = false;
        Contains(ref node, ref isPresent, item);
        return isPresent;
    }


    public void Contains(ref Node<T> tree, ref Boolean isPresent, T item)
    {
        if (tree != null)
        {
            Contains(ref tree.Left, ref isPresent, item);
            Contains(ref tree.Right, ref isPresent, item);

            if (item.Equals(tree.Data))
            {
                isPresent = true;
            }
        }
    }
    public void RemoveItem(T item)
    {
        RemoveItem(item, ref node);
    }
    protected Node<T> RemoveItem(T item, ref Node<T> tree)
    {
        if (tree == null)
        {
            return null;
        }
        if (tree != null)
        {
            if (item.CompareTo(tree.Data) < 0)
            {
                RemoveItem(item, ref tree.Left); //move left
            }
            else if (item.CompareTo(tree.Data) > 0)
            {
                RemoveItem(item, ref tree.Right);
            }

            {
                if (item.CompareTo(tree.Data) == 0)
                {
                    if (tree.Left == null)
                    {
                        tree = tree.Right;
                    }
                    else if (tree.Right == null)
                    {
                        tree = tree.Left;
                    }
                    else
                    {
                        Node<T> min = Smallest(ref tree.Right);
                        tree.Data = min.Data;
                        tree.Right = RemoveItem(tree.Data, ref min);
                    }
                }


            }
        }
        return tree;
    }


    public T Smallest()
    {
        return Smallest(ref node).Data;
    }

    private Node<T> Smallest(ref Node<T> tree)
    {
        Node<T> Temp = tree;
        if (Temp.Left == null)
        {

            return Temp;
        }
        else
        {
            return Smallest(ref Temp.Left);
        }



    }
}
}
