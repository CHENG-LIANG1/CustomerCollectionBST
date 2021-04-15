// File: BTree.cs
// An implementation of BTree ADT
// Maolin Tang 
// 24/3/06

using System;
using BSTreeInterface;
using BSTreeADT;
namespace BSTreeClass
{
	public class BTreeNode
	{
		private Customer customer; // value
		private BTreeNode lchild; // reference to its left child 
		private BTreeNode rchild; // reference to its right child

		public BTreeNode(Customer customer)
		{
			this.customer = customer;
			lchild = null;
			rchild = null;
		}

		public Customer Customer
		{
			get { return customer; }
			set { customer = value; }
		}

		public BTreeNode LChild
		{
			get { return lchild; }
			set { lchild = value; }
		}

		public BTreeNode RChild
		{
			get { return rchild; }
			set { rchild = value; }
		}
	}


	public class BSTree : IBSTree
	{
		private BTreeNode root;

		public BSTree()
		{
			root = null;
		}

		public bool IsEmpty()
		{
			return root == null;
		}

		public bool Search(Customer customer)
		{
			return Search(customer, root);
		}

		private bool Search(Customer item, BTreeNode r)
		{
			if(r != null)
			{
				if(item.CompareTo(r.Customer) == 0)
					return true;
				else
					if(item.CompareTo(r.Customer) < 0 )
					return Search(item, r.LChild);
				else
					return Search(item, r.RChild);
			}
			else
				return false;
		}

		public void Insert(Customer customer)
		{
			if(root == null)
				root = new BTreeNode(customer);
			else
				Insert(customer, root);	
		}

		// pre: ptr != null
		// post: item is inserted to the binary search tree rooted at ptr
		private void Insert (Customer customer, BTreeNode ptr)
		{
			if (customer.CompareTo(ptr.Customer) < 0)
			{
				if (ptr.LChild == null)
					ptr.LChild = new BTreeNode(customer);
				else 
					Insert(customer, ptr.LChild);
			}
			else 
			{
				if (ptr.RChild == null)			
					ptr.RChild = new BTreeNode(customer);
				else 
					Insert(customer, ptr.RChild);
			}
		} 
	
		// there are three cases to consider:
		// 1. the node to be deleted is a leaf
		// 2. the node to be deleted has only one child 
		// 3. the node to be deleted has both left and right children
		public void Delete(Customer customer)
		{
			// search for item and its parent
			BTreeNode ptr = root; // search reference
			BTreeNode parent = null; // parent of ptr
			while((ptr!=null)&&(customer.CompareTo(ptr.Customer)!=0))
			{
				parent = ptr;
				if(customer.CompareTo(ptr.Customer) < 0) // move to the left child of ptr
					ptr = ptr.LChild;
				else
					ptr = ptr.RChild;
			}

			if(ptr != null) // if the search was successful
			{
				// case 3: item has two children
				if((ptr.LChild != null)&&(ptr.RChild != null))
				{
					// find the right-most node in left subtree of ptr
					if(ptr.LChild.RChild == null) // a special case: the right subtree of ptr.LChild is empty
					{
						ptr.Customer = ptr.LChild.Customer;
						ptr.LChild = ptr.LChild.LChild;
					}
					else 
					{
						BTreeNode p = ptr.LChild;
						BTreeNode pp = ptr; // parent of p
						while(p.RChild != null)
						{
							pp = p;
							p = p.RChild;
						}
						// copy the item at p to ptr
						ptr.Customer = p.Customer;
						pp.RChild = p.LChild;
					}
				}
				else // cases 1 & 2: item has no or only one child
				{
					BTreeNode c;
					if(ptr.LChild != null)
						c = ptr.LChild;
					else
						c = ptr.RChild;

					// remove node ptr
					if(ptr == root) //need to change root
						root = c;
					else
					{
						if(ptr == parent.LChild)
							parent.LChild = c;
						else
							parent.RChild = c;
					}
				}

			}
		}

		public void PreOrderTraverse()
		{
			Console.WriteLine("PreOrder: ");
			PreOrderTraverse(root);
			Console.WriteLine();
		}

		private void PreOrderTraverse(BTreeNode root)
		{
			if(root != null)
			{
				Console.WriteLine("{0, -10} {1, -10} {2,-30}", root.Customer.lastName, 
														   root.Customer.firstName, 
					                                       root.Customer.phoneNum);
				PreOrderTraverse(root.LChild);
				PreOrderTraverse(root.RChild);
			}
		}

		public void InOrderTraverse()
		{
			Console.WriteLine("InOrder: ");
			InOrderTraverse(root);
			Console.WriteLine();
		}

		private void InOrderTraverse(BTreeNode root)
		{
			if(root != null)
			{
				InOrderTraverse(root.LChild);
				Console.WriteLine("{0,-10} {1, -10} {2,-30}", root.Customer.lastName,
														   root.Customer.firstName,
														   root.Customer.phoneNum);
				InOrderTraverse(root.RChild);
			}
		}

		public void PostOrderTraverse()
		{
			Console.WriteLine("PostOrder: ");
			PostOrderTraverse(root);
			Console.WriteLine();
		}

		private void PostOrderTraverse(BTreeNode root)
		{
			if(root != null)
			{
				PostOrderTraverse(root.LChild);
				PostOrderTraverse(root.RChild);
				Console.WriteLine("{0, -10} {1, -10} {2,-30}", root.Customer.lastName,
														   root.Customer.firstName,
														   root.Customer.phoneNum);
			}
		}

		public void Clear()
		{
			root = null;
		}
	}
}




