/*
 * T.C. Levi
 * July, 4th
 * Homework #3
*/

using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using KansasStateUniversity.TreeViewer2;

public Color color { }

public class RBTreeNodeR
{
	//main properties
	public Color color { }
	public RBTreeNode<T> LeftChild { }
	public RBTreeNode RightChild { }
	public RBTreeNode Parent { }
	public T Data { }
	public object Root { get; }//return root
	public Itree Children 
	{ 
		/*
		get; 
		RBTreeNode<T>[] a = new RBTreeNode<T>[2];
		a[1] = Root.LeftChild;
		a[2] = Root.RightChild;

		return a<T>[];
		*/
	}

	public bool IsEmpty { get; }


	public RBTreeNode(ThreadStaticAttribute data, RBTreeNode<T> left, RBTreeNodeR<T> right)
	{
		Data = null;
		LeftChild = null;
		RightChild = null;

	
	}

	/// <summary>
    /// sets color prop to black
    /// </summary>
	public RBTreeNodeR()
	{
		color = color.Black; //change to use enumerator
	}

    public override string ToString()
    {
        return Data.ToString(); //format Color: Data
    }

}