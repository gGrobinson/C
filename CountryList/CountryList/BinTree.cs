using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryList
{
    class BinTree<T> where T : IComparable
    {
        protected Node<T> node;

        public BinTree()
        {
            node = null;
        }

        public BinTree(Node<T> node)
        {
            this.node = node;
        }

        public void InOrder(ref string buffer)
        {
            inOrder(node, ref buffer);
        }

        private void inOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                inOrder(tree.Left, ref buffer);
                buffer += tree.Data.ToString() + " ";
                inOrder(tree.Right, ref buffer);
            }
        }


        public void PreOrder(ref string buffer)
        {
            preOrder(node, ref buffer);
        }

        private void preOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                buffer += tree.Data.ToString() + "";
                preOrder(tree.Left, ref buffer);
                preOrder(tree.Right, ref buffer);
            }
        }

        public void PostOrder(ref string buffer)
        {
            postOrder(node, ref buffer);
        }

        private void postOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                postOrder(tree.Left, ref buffer);
                postOrder(tree.Right, ref buffer);
                buffer += tree.Data.ToString() + "";
            }
        }
    }
}
