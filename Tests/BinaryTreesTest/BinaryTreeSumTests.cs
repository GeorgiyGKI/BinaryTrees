using BinaryTrees;

namespace Tests.BinaryTreesTest
{
	public class BinaryTreeSumTests
	{
		[Fact]
		public void BreadthFirstTreeSum_SingleNode_ReturnsNodeValue()
		{
			var root = new Node<int>(10);

			var result = BinaryTreeMethods.BreadthFirstTreeSum(root);

			Assert.Equal(10, result);
		}

		[Fact]
		public void BreadthFirstTreeSum_MultipleNodes_ReturnsSum()
		{
			var root = new Node<int>(1);
			root.Left = new Node<int>(2);
			root.Right = new Node<int>(3);
			root.Left.Left = new Node<int>(4);
			root.Left.Right = new Node<int>(5);

			var result = BinaryTreeMethods.BreadthFirstTreeSum(root);

			Assert.Equal(15, result);
		}

		[Fact]
		public void BreadthFirstTreeSum_NullTree_ReturnsDefault()
		{
			var result = BinaryTreeMethods.BreadthFirstTreeSum(null);

			Assert.Equal(0, result);
		}

		[Fact]
		public void TreeSumRecursion_SingleNode_ReturnsNodeValue()
		{
			var root = new Node<int>(10);

			var result = BinaryTreeMethods.TreeSumRecursion(root);

			Assert.Equal(10, result);
		}

		[Fact]
		public void TreeSumRecursion_MultipleNodes_ReturnsSum()
		{
			var root = new Node<int>(1);
			root.Left = new Node<int>(2);
			root.Right = new Node<int>(3);
			root.Left.Left = new Node<int>(4);
			root.Left.Right = new Node<int>(5);

			var result = BinaryTreeMethods.TreeSumRecursion(root);

			Assert.Equal(15, result);
		}

		[Fact]
		public void TreeSumRecursion_NullTree_ReturnsDefault()
		{
			var result = BinaryTreeMethods.TreeSumRecursion(null);

			Assert.Equal(0, result);
		}
	}
}