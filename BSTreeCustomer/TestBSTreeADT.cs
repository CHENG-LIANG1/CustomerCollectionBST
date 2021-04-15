// File: TestBSTreeADT.cs
// Test the BTree ADT
// Maolin Tang
// 25 March 2006

using System;
using BSTreeInterface;
using BSTreeClass;
using BSTreeADT;
public class TestBSTreeADT
{
	static public void Main()
	{
		// build a binary search tree
		Console.WriteLine("Initially, an empty BST is created");
		IBSTree aBSTree = new BSTree();
		Customer customer01 = new Customer("Huanyi", "Qian", 17701449052);
		Customer customer02 = new Customer("Dick", "Pussy", 12345678910);
		Customer customer03 = new Customer("Stop", "it", 17701449052);
		Customer customer04 = new Customer("Ass", "Fuck", 12345678910);
		Customer customer05 = new Customer("Idiot", "Freeman", 17701449052);
		Customer customer06 = new Customer("Saul", "Goodman", 12345678910);
		Customer customer07 = new Customer("Shabi", "ZhuXinhu", 12345678910);


		aBSTree.Insert(customer01);
		aBSTree.Insert(customer02);
		aBSTree.Insert(customer03);
		aBSTree.Insert(customer04);
		aBSTree.Insert(customer05);
		aBSTree.Insert(customer06);
		aBSTree.Insert(customer07);
		Console.WriteLine();
		Console.WriteLine();

		// pre-order traversal
		aBSTree.PreOrderTraverse();
		// in-order traversal

		aBSTree.InOrderTraverse();
		// post-order traversal
	
		aBSTree.PostOrderTraverse();

		Console.WriteLine();
		Console.WriteLine();

		// delete a leaf A

		aBSTree.Delete(customer07);
		Console.WriteLine("Zhuxinhu has been deleted from the BST");
		Console.WriteLine();
		Console.WriteLine();

		// pre-order traversal
	
		aBSTree.PreOrderTraverse();
		// in-order traversal
	
		aBSTree.InOrderTraverse();
		// post-order traversal

		aBSTree.PostOrderTraverse();

		Console.WriteLine();
		Console.WriteLine();

		// put A back aBStree
		aBSTree.Insert(customer07);
		Console.WriteLine("Zhuxinhu has been added back to the BST");
		// delete a node W, which has only one child

		aBSTree.Delete(customer06);
		Console.WriteLine("Goodman has been deleted from the BST");
		Console.WriteLine();
		Console.WriteLine();

		// pre-order traversal
	
		aBSTree.PreOrderTraverse();
		// in-order traversal

		aBSTree.InOrderTraverse();
		// post-order traversal
	
		aBSTree.PostOrderTraverse();

		Console.WriteLine();
		Console.WriteLine();

		// clear the binary tree
		aBSTree.Clear();
		Console.WriteLine("The BST has been cleard");
		Console.WriteLine();
		Console.WriteLine();

		// pre-order traversal

		aBSTree.PreOrderTraverse();
		// in-order traversal

		aBSTree.InOrderTraverse();
		// post-order traversal

		aBSTree.PostOrderTraverse();

		Console.WriteLine();
		Console.WriteLine();
		Console.ReadKey();

	}
}

        















