// File: IBTree.cs
// Binary tree ADT interface
// Maolin Tang
// 24/3/06

using System;
using BSTreeClass;
using BSTreeADT;
namespace BSTreeInterface 
{
	// invariants: every node?s left subtree contains values less than or equal to 
	// the node?s value, and every node?s right subtree contains values 
	// greater than or equal to the node?s value
	public interface IBSTree
	{
		// pre: true
		// post: return true if the binary tree is empty; otherwise, return false.
		bool IsEmpty();

		// pre: true
		// post: item is added to the binary search tree
		void Insert(Customer item);

		// pre: true
		// post: an occurrence of item is removed from the binary search tree 
		//		 if item is in the binary search tree
		void Delete(Customer item);

		// pre: true
		// post: return true if item is in the binary search true;
		//	     otherwise, return false.
		bool Search(Customer item);

		// pre: true
		// post: all the nodes in the binary tree are visited once and only once in pre-order
		void PreOrderTraverse();

		// pre: true
		// post: all the nodes in the binary tree are visited once and only once in in-order
		void InOrderTraverse();

		// pre: true
		// post: all the nodes in the binary tree are visited once and only once in post-order
		void PostOrderTraverse();

		// pre: true
		// post: all the nodes in the binary tree are removed and the binary tree becomes empty
		void Clear();

	}
}
