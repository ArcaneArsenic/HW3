using System;
using KSU.CIS300.RBTrees;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KansasStateUniversity.TreeViewer2;
using System.Windows.Forms;

namespace KSU.CIS300.RBTrees
{
   

    class RBTree<T> : ITree //IComparable: //edit
    {
        public static readonly RBTreeNode<T> NIL;
        public RBTreeNode<T> Root { get; private set; }
        object ITree.Root { get; }//return this?
        public ITree[] children { get; } //return children
        public bool IsEmpty { get; }//return null bool

        public ITree[] Children => throw new NotImplementedException();

        //implements ITree?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public RBTreeNode<T> FindMin(RBTreeNode<T> node)
        {
            
            while (node != null)
            {
                if (node.LeftChild == null) { return node; }
                else { node = (RBTreeNode<T>)node.LeftChild;}
                node = FindMin(node);

            }
            return node;
        
        }

        /// <summary>
        /// return true if found
        /// if false, result = null
        /// recall "CompareTo"
        /// stop search if NIL is reached
        /// </summary>
        /// <param name="search"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        private bool Find(T search, out RBTreeNode<T> result)
        {
            RBTree<T> x = new RBTrees.RBTree<T>();
            x = search.Data;
            //if(x.Contains(search))
            //review binary search methods
        }

        /// <summary>
        /// out is a val. of T
        /// </summary>
        /// <param name="search"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public bool Find(T search, out T result)
        { 
            //uses find above
        }

        /// <summary>
        /// single left rotation
        /// see ABL Trees from Lab 20
        /// 
        /// </summary>
        /// <param name="pivot"></param>
        public void RotateLeft(RBTreeNodea<T> pivot)
        { 
        
        }

        /// <summary>
        /// single right rotation
        /// see ABL Trees from Lab 20
        /// 
        /// </summary>
        /// <param name="pivot"></param>
        public void RotateRight(RBTreeNodea<T> pivot)
        {


        }

        /// <summary>
        /// Builds the result of performing a single rotate right on the binary tree
        /// described by the given root, left child, and right child.
        /// </summary>
        /// <param name="root">The data stored in the root of the original tree.</param>
        /// <param name="left">The left child of the root of the original tree.</param>
        /// <param name="right">The right child of the root of the original tree.</param>
        /// <returns>The result of performing a single rotate right on the tree described
        /// by the parameters.</returns>
        private static RBTreeNode<T> SingleRotateRight(T root, RBTreeNode<T> left, RBTreeNode<T> right)
        {
            RBTreeNode<T> newRight = new RBTreeNode<T>(root, left.RightChild, right);
            return new RBTreeNode<T>(left.Data, left.LeftChild, newRight);
        }

        /// <summary>
        /// check for null root
        /// create new tree with NIL children, and set new roots to black
        /// ident input = InvalidOperationException
        /// overloaded or recursive?
        /// </summary>
        /// <param name="data"></param>
        public void Insert(T data)
        { 
        
        }

        /// <summary>
        /// moves pointers instead of recreating tree
        /// link to new nodes "parent" property
        /// calls FixInsert method
        /// </summary>
        /// <param name="newNode"></param>
        private void Insert(RBTreeNode<T> newNode)
        { 
        
        }

        /// <summary>
        ///checks tree rules for color distribution
        ///see hw instructions, lot of stuff here
        /// </summary>
        /// <param name="node"></param>
        private void FixInsert(RBTree<T> node)
        { 
        
        }

        /// <summary>
        /// replaces node a with b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private void Replace(RBTreeNode<T> a, RBTreeNode<T> b)
        { 
        
        }

        /// <summary>
        /// calls find method
        /// see instructions
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Remove(T item)
        { 
        
        }

        /// <summary>
        /// corrects rule violations from deletion
        /// </summary>
        /// <param name="current"></param>
        private void FixDelete(RBTreeNode<T> current)
        { 
        
        }
    }

    internal class RBTreeNode<T> : IComparable<T>
    {
        private T root;
        private RBTreeNode<T> right;

        public RBTreeNode(T root, object rightChild, RBTreeNode<T> right)
        {
            this.root = root;
            RightChild = rightChild;
            this.right = right;
        }

        public object LeftChild { get; internal set; }
        public object RightChild { get; internal set; }
        public T Data { get; internal set; }

        public int CompareTo(T other)
        {
            throw new NotImplementedException();
        }
    }
}




