using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalIdVerification.Binary
{
	public static class BinarySerchTreeV2
	{
		private static List<int> InOrderList = new List<int>();
		private static List<int> PreOrderList = new List<int>();
		private static List<int> PostOrderList = new List<int>();
		public static List<int> InOrderTraverse(BST tree, List<int> array)
		{
			// Write your code here.
			return new List<int>();
		}

		public static List<int> PreOrderTraverse(BST tree, List<int> array)
		{
			// Write your code here.
			return new List<int>();
		}

		private static void InOrder(BST tree)
        {
			if(tree != null)
            {
				InOrder(tree.left);
				InOrderList.Add(tree.value);
				InOrder(tree.right);
            }
        }

		public static List<int> PostOrderTraverse(BST tree, List<int> array)
		{
			// Write your code here.
			return new List<int>();
		}

		public class BST
		{
			public int value;
			public BST left;
			public BST right;

			public BST(int value)
			{
				this.value = value;
			}

		}
	}
}
