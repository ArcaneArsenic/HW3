/*
 * T.C. Levi
 * July, 4th
 * Homework #3
*/

using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using KansasStateUniversity.TreeViewer2;

//public Color color { }

public class RBTreeNode : ITree
{
	//main properties
	public enum Color {Red, Black};
	public RBTreeNode<T> LeftChild { }
	public RBTreeNode RightChild { }
	public RBTreeNode Parent { }
	public T Data { }
	public object Root { get ; set; }//return root
	public ITree Children 
	{ 
		get => new RBTreeNode<T>[2]; 

		set; 
	}

	public bool IsEmpty 
	{ 
		get => Data.Equals(T); 
		set; 
	}


	public RBTreeNode(ThreadStaticAttribute data, RBTreeNode<T> left, RBTreeNodeR<T> right)
	{
		Data = data;
		LeftChild = left;
		RightChild = right;

		//color = Black;
		Root = this;
		Children.set(left);
		Children.set(right);


	}

	/// <summary>
    /// sets color prop to black
    /// </summary>
	public RBTreeNode()
	{
		color = Black; //change to use enumerator
	}

    public override string ToString()
    {
		string newStr = Data.ToString();
        return newStr + " : " + color; //format Color: Data
    }

}