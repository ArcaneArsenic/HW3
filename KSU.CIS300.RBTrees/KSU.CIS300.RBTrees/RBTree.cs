﻿using System;
using KSU.CIS300.RBTrees;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KansasStateUniversity.TreeViewer2;

namespace KSU.CIS300.RBTrees
{
    public static readonly RBTreeNode<T> NIL;
    public RBTreeNode<T> Root { get; private set; }
    object ITree.Root { get; }//return this?
    public ITree[] children { get; } //return children
    public bool IsEmpty { get; }//return null bool

    class RBTree<T> //IComparable: //edit
    {
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
                else { node = node.LeftChild;}

            }
            
        
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
            //binary search
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

}



