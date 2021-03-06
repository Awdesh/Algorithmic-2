using System;
using System.Collections.Generic;

namespace Tree
{
	public class InOrderTraversal
	{
		public InOrderTraversal ()
		{
		}

		/// <summary>
		/// LNR
		/// </summary>
		/// <param name="root">Root.</param>
		public void RecursiveTraversal(TreeNode root)
		{
			// base case.
			if (root == null) {
				return;
			}
			RecursiveTraversal (root.getLeft ());
			Console.WriteLine (root.getData());
			RecursiveTraversal (root.getRight ());
		}

		/// <summary>
		/// Nons the recursive traversal.
		/// </summary>
		/// <param name="root">Root.</param>
		public List<int> NonRecursiveTraversal(TreeNode root)
		{
			List<int> nodesData = new List<int> ();

			if (root == null) {
				return null;
			}
			Stack<TreeNode> s = new Stack<TreeNode> ();
			bool done = false;
			TreeNode temp = root;
			while (!done) {
				if (temp != null) {
					s.Push (temp);
					temp = temp.getLeft ();
				}
				else {
					if (s.Count > 0) {
						temp = s.Pop ();
						if (temp == null) {
							break;
						}
						Console.WriteLine (temp.getData ());
						nodesData.Add (temp.getData ());
						temp = temp.getRight ();
					} else {
						done = true;
					}
				}
			}
			return nodesData;
		}
	}
}

