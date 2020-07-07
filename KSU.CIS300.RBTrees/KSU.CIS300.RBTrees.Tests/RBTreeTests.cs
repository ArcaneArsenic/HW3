using System;
using NUnit.Framework;
using KSU.CIS300.RBTrees;

namespace KSU.CIS300.RBTrees.Tests
{
    [TestFixture]
    public class RBTreeTests
    {
        [Test]
        [Category("A: Simple Insert")]
        public void TestSimpleInsert()
        {
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(5);
            Assert.AreEqual(5, tree.Root.Data);
            VerifyTree(tree);
        }

        [Test]
        [Category("A: Simple Insert")]
        public void TestSimpleInsertRight()
        {
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(5);
            tree.Insert(6);
            Assert.AreEqual(5, tree.Root.Data);
            Assert.AreEqual(6, tree.Root.RightChild.Data);
            VerifyTree(tree);
        }

        [Test]
        [Category("A: Simple Insert")]
        public void TestSimpleInsertLeft()
        {
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(5);
            tree.Insert(4);
            Assert.AreEqual(5, tree.Root.Data);
            Assert.AreEqual(4, tree.Root.LeftChild.Data);
            VerifyTree(tree);
        }

        [Test]
        [Category("A: Simple Insert")]
        public void TestSimpleInsertLeftRight()
        {
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(5);
            tree.Insert(4);
            tree.Insert(6);
            Assert.AreEqual(4, tree.Root.LeftChild.Data);
            Assert.AreEqual(6, tree.Root.RightChild.Data);
            Assert.AreEqual(5, tree.Root.Data);
            VerifyTree(tree);
        }

        [Test]
        [Category("A: Simple Insert")]
        public void TestSimpleInsertLeftRightDuplicate()
        {
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(5);
            tree.Insert(4);
            tree.Insert(6);
            Assert.Throws<InvalidOperationException>(delegate { tree.Insert(6); });
        }

        [Test]
        [Category("A: Simple Insert")]
        public void TestSimpleInsertDuplicate()
        {
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(5);
            Assert.Throws<InvalidOperationException>(delegate { tree.Insert(5); });
        }

        [Test]
        [Category("B: Single Rotation")]
        public void TestRotateLeft()
        {
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(5);
            tree.Insert(6);
            tree.Insert(7);
            Assert.AreEqual(5, tree.Root.LeftChild.Data);
            Assert.AreEqual(7, tree.Root.RightChild.Data);
            Assert.AreEqual(6, tree.Root.Data);
            VerifyTree(tree);
        }

        [Test]
        [Category("B: Single Rotation")]
        public void TestRotateRight()
        {
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(5);
            tree.Insert(4);
            tree.Insert(3);
            Assert.AreEqual(3, tree.Root.LeftChild.Data);
            Assert.AreEqual(5, tree.Root.RightChild.Data);
            Assert.AreEqual(4, tree.Root.Data);
            VerifyTree(tree);
        }

        [Test]
        [Category("C: Fix Insert: Recolor")]
        public void TestRecolor()
        {
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(5);
            tree.Insert(4);
            tree.Insert(6);
            tree.Insert(8);
            Assert.AreEqual(5, tree.Root.Data);
            Assert.AreEqual(4, tree.Root.LeftChild.Data);
            Assert.AreEqual(6, tree.Root.RightChild.Data);
            Assert.AreEqual(8, tree.Root.RightChild.RightChild.Data);
            Assert.AreEqual(5, tree.Root.Data);
            VerifyTree(tree);
        }

        [Test]
        [Category("C: Fix Insert: Recolor")]
        public void TestRecolorRightLeftRotate()
        {
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(5);
            tree.Insert(4);
            tree.Insert(6);
            tree.Insert(8);
            tree.Insert(7); //else case 2-3 
            Assert.AreEqual(5, tree.Root.Data);
            Assert.AreEqual(4, tree.Root.LeftChild.Data);
            Assert.AreEqual(7, tree.Root.RightChild.Data);
            Assert.AreEqual(8, tree.Root.RightChild.RightChild.Data);
            Assert.AreEqual(6, tree.Root.RightChild.LeftChild.Data);
            VerifyTree(tree);
        }


        [Test]
        [Category("C: Fix Insert: Recolor")]
        public void TestRecolorRotateRight()
        {
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(5);
            tree.Insert(4);
            tree.Insert(6);
            tree.Insert(3);
            tree.Insert(2);
            VerifyTree(tree);
        }
        [Test]
        [Category("C: Fix Insert: Recolor")]
        public void TestRotateRightRecolor()
        {
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(10);
            tree.Insert(5);
            tree.Insert(15);
            tree.Insert(3);
            tree.Insert(2);
            tree.Insert(1);
            VerifyTree(tree);
        }

        [Test]
        [Category("C: Fix Insert: Recolor")]
        public void TestRotateRightLeft()
        {
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(11);
            tree.Insert(2);
            tree.Insert(14);
            tree.Insert(1);
            tree.Insert(7);
            tree.Insert(15);
            tree.Insert(5);
            tree.Insert(8);
            tree.Insert(4);
            VerifyTree(tree);
        }


        [Test]
        [Category("C: Fix Insert: Recolor")]
        public void TestFindRoot()
        {
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(5);
            tree.Insert(4);
            tree.Insert(6);
            int result;
            if (!tree.Find(5, out result) || result != 5)
            {
                Assert.Fail();
            }
        }

        [Test]
        [Category("D: Find")]
        public void TestFindMissing()
        {
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(5);
            tree.Insert(4);
            tree.Insert(6);
            int result;
            if (tree.Find(1, out result) || result != 0)
            {
                Assert.Fail();
            }
        }

        [Test]
        [Category("D: Find")]
        public void TestFindLessThan()
        {
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(5);
            tree.Insert(4);
            tree.Insert(6);
            tree.Insert(3);
            tree.Insert(2);
            int result;
            if (!tree.Find(3, out result) || result != 3)
            {
                Assert.Fail();
            }
        }

        [Test]
        [Category("D: Find")]
        public void TestFindGreaterThan()
        {
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(5);
            tree.Insert(3);
            tree.Insert(6);
            tree.Insert(4);
            tree.Insert(1);
            int result;
            if (!tree.Find(4, out result) || result != 4)
            {
                Assert.Fail();
            }
        }

        [Test]
        [Category("E: Find Min")]
        public void TestFindMin()
        {
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(5);
            tree.Insert(3);
            tree.Insert(6);
            tree.Insert(4);
            tree.Insert(1);
            Assert.AreEqual(1, tree.FindMin(tree.Root.LeftChild).Data);
        }

        [Test]
        [Category("E: Find Min")]
        public void TestFindMinRight()
        {
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(5);
            tree.Insert(3);
            tree.Insert(6);
            tree.Insert(4);
            tree.Insert(1);
            Assert.AreEqual(6, tree.FindMin(tree.Root.RightChild).Data);
        }

        [Test]
        [Category("F: Simple Remove")]
        public void TestSimpleRemoveRight()
        {
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(5);
            tree.Insert(4);
            tree.Insert(6);
            tree.Remove(6);
            int result = 0;
            if (tree.Find(6, out result))
            {
                Assert.Fail();
            }
            VerifyTree(tree);
        }

        [Test]
        [Category("F: Simple Remove")]
        public void TestSimpleRemoveLeft()
        {
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(5);
            tree.Insert(4);
            tree.Insert(6);
            tree.Remove(4);
            int result = 0;
            if (tree.Find(4, out result))
            {
                Assert.Fail();
            }
            VerifyTree(tree);
        }

        [Test]
        [Category("G: Fix Delete")]
        [Category("G2: Remove Parent")]
        public void TestRemoveParentRight()
        {
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(5);
            tree.Insert(4);
            tree.Insert(6);
            tree.Insert(7);
            tree.Remove(6);
            int result = 0;
            if (tree.Find(6, out result))
            {
                Assert.Fail();
            }
            VerifyTree(tree);
        }

        [Test]
        [Category("G: Fix Delete")]
        [Category("G1: Remove Parent")]
        public void TestRemoveParentLeft()
        {
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(5);
            tree.Insert(4);
            tree.Insert(7);
            tree.Insert(6);
            tree.Remove(7);
            int result = 0;
            if (tree.Find(7, out result))
            {
                Assert.Fail();
            }
            VerifyTree(tree);
        }

        [Test]
        [Category("G: Fix Delete")]
        [Category("G1: Remove Parent")]
        public void TestRemoveParentWithOneChild()
        {
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(5);
            tree.Insert(4);
            tree.Insert(8);
            tree.Insert(6);
            tree.Insert(7);
            tree.Remove(7);
            int result = 0;
            if (tree.Find(7, out result))
            {
                Assert.Fail();
            }
            VerifyTree(tree);
        }

        [Test]
        [Category("G: Fix Delete")]
        [Category("G1: Remove Parent")]
        public void TestRemoveParentWithTwoChildren()
        {
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(5);
            tree.Insert(4);
            tree.Insert(8);
            tree.Insert(6);
            tree.Insert(9);
            tree.Remove(8);
            int result = 0;
            if (tree.Find(8, out result))
            {
                Assert.Fail();
            }
            VerifyTree(tree);
        }

        [Test]
        [Category("G: Fix Delete")]
        [Category("G1: Remove Parent")]
        public void TestRemoveParent()
        {
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(5);
            tree.Insert(4);
            tree.Insert(8);
            tree.Insert(6);
            tree.Insert(7);
            tree.Remove(8);
            int result = 0;
            if (tree.Find(8, out result))
            {
                Assert.Fail();
            }
            VerifyTree(tree);
        }

        [Test]
        [Category("G: Fix Delete")]
        [Category("G2: Remove Sibling")]
        public void TestRemoveOneSibling()
        {
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(5);
            tree.Insert(4);
            tree.Insert(8);
            tree.Insert(6);
            tree.Insert(9);
            tree.Remove(9);
            int result = 0;
            if (tree.Find(9, out result))
            {
                Assert.Fail();
            }
            VerifyTree(tree);
        }



        [Test]
        [Category("G: Fix Delete")]
        [Category("G2: Remove Sibling")]
        public void TestRemoveBlackSiblingRedNephew()
        {
            //case 4
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(11);
            tree.Insert(2);
            tree.Insert(14);
            tree.Insert(1);
            tree.Insert(7);
            tree.Insert(15);
            tree.Insert(5);
            tree.Insert(8);
            tree.Insert(4);
            tree.Remove(8);
            int result = 0;
            if (tree.Find(8, out result))
            {
                Assert.Fail();
            }
            VerifyTree(tree);
        }

        [Test]
        [Category("G: Fix Delete")]
        [Category("G2: Remove Sibling")]
        public void TestRemoveBlackSiblingRedBlackNephew()
        {
            //case 3, 4
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(11);
            tree.Insert(2);
            tree.Insert(14);
            tree.Insert(1);
            tree.Insert(7);
            tree.Insert(15);
            tree.Insert(5);
            tree.Insert(8);
            tree.Insert(4);
            tree.Remove(1);
            int result = 0;
            if (tree.Find(1, out result))
            {
                Assert.Fail();
            }
            VerifyTree(tree);
        }

        [Test]
        [Category("G: Fix Delete")]
        [Category("G2: Remove Sibling")]
        public void TestRemoveBlackSiblingNephewRed()
        {
            //case 1
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(11);
            tree.Insert(2);
            tree.Insert(14);
            tree.Insert(1);
            tree.Insert(7);
            tree.Insert(15);
            tree.Insert(5);
            tree.Insert(8);
            tree.Insert(4);
            tree.Remove(2);
            int result = 0;
            if (tree.Find(2, out result))
            {
                Assert.Fail();
            }
            VerifyTree(tree);
        }

        [Test]
        [Category("G: Fix Delete")]
        [Category("G2: Remove Sibling")]
        public void TestRemoveBlackSiblingRed()
        {
            //case 1,2
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(5);
            tree.Insert(3);
            tree.Insert(10);
            tree.Insert(7);
            tree.Insert(13);
            tree.Insert(14);
            tree.Remove(3);
            int result = 0;
            if (tree.Find(3, out result))
            {
                Assert.Fail();
            }
            VerifyTree(tree);
        }

        [Test]
        [Category("G: Fix Delete")]
        [Category("G2: Remove Sibling")]
        public void TestRemoveBlackSiblingRedMirror()
        {
            //case 1-2,2-2
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(5);
            tree.Insert(3);
            tree.Insert(8);
            tree.Insert(2);
            tree.Insert(4);
            tree.Insert(1);
            tree.Remove(8);
            int result = 0;
            if (tree.Find(8, out result))
            {
                Assert.Fail();
            }
            VerifyTree(tree);
        }

        [Test]
        [Category("G: Fix Delete")]
        [Category("G2: Remove Sibling")]
        public void TestRemoveBlackSiblingRedBlackNephewMirror()
        {
            //case 3-2, 4-2
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(10);
            tree.Insert(5);
            tree.Insert(15);
            tree.Insert(3);
            tree.Insert(8);
            tree.Insert(12);
            tree.Insert(18);
            tree.Insert(9);
            tree.Insert(13);
            tree.Remove(18);
            int result = 0;
            if (tree.Find(18, out result))
            {
                Assert.Fail();
            }
            VerifyTree(tree);
        }

        [Test]
        [Category("G: Fix Delete")]
        [Category("G2: Remove Sibling")]
        public void TestRemoveRedLeftSibling()
        {
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(11);
            tree.Insert(2);
            tree.Insert(14);
            tree.Insert(1);
            tree.Insert(7);
            tree.Insert(15);
            tree.Insert(5);
            tree.Insert(8);
            tree.Insert(4);
            tree.Remove(5);
            int result = 0;
            if (tree.Find(5, out result))
            {
                Assert.Fail();
            }
            VerifyTree(tree);
        }
        [Test]
        [Category("G: Fix Delete")]
        [Category("G2: Remove Sibling")]
        public void TestRemoveRedSiblingsRight()
        {
            RBTree<int> tree = new RBTree<int>();
            tree.Insert(11);
            tree.Insert(2);
            tree.Insert(14);
            tree.Insert(1);
            tree.Insert(7);
            tree.Insert(15);
            tree.Insert(5);
            tree.Insert(8);
            tree.Insert(4);
            tree.Insert(13);
            tree.Remove(11);
            int result = 0;
            if (tree.Find(11, out result))
            {
                Assert.Fail();
            }
            VerifyTree(tree);
        }


        private void VerifyTree(RBTree<int> tree)
        {
            if (tree.Root.Color == Color.Red)
                throw new Exception("Root must be black");
            CheckNode(tree, tree.Root);
        }

        private int CheckNode(RBTree<int> tree, RBTreeNode<int> node)
        {
            if (node == RBTree<int>.NIL)
                return 1;

            int left = CheckNode(tree, node.LeftChild);
            int right = CheckNode(tree, node.RightChild);
            if (left != right)
                throw new Exception("All paths to leaves must contain the same number of black nodes");
            if (node.Color == Color.Black)
                return left + 1;
            else
            {
                if ((node.LeftChild != RBTree<int>.NIL && node.LeftChild.Color == Color.Red) ||
                    (node.RightChild != RBTree<int>.NIL && node.RightChild.Color == Color.Red))
                {
                    throw new Exception("A red node can only have black children");
                }
            }
            return left;

        }

    }
}
