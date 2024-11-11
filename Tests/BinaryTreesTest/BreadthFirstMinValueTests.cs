using BinaryTrees;

namespace Tests.BinaryTreesTest
{
	public class BreadthFirstMinValueTests
	{
		[Fact]
		public void BreadthFirstMinValue_SingleNode_ReturnsNodeValue()
		{
			var root = new Node<int>(10);

			var result = BinaryTreeMethods.BreadthFirstMinValue(root);

			Assert.Equal(10, result);
		}

		[Fact]
		public void BreadthFirstMinValue_MultipleNodes_ReturnsMinValue()
		{
			var root = new Node<int>(10);
			root.Left = new Node<int>(5);
			root.Right = new Node<int>(15);
			root.Left.Left = new Node<int>(2);
			root.Left.Right = new Node<int>(8);
			root.Right.Left = new Node<int>(12);
			root.Right.Right = new Node<int>(20);

			var result = BinaryTreeMethods.BreadthFirstMinValue(root);

			Assert.Equal(2, result);
		}

		[Fact]
		public void BreadthFirstMinValue_NullTree_ReturnsNull()
		{
			var result = BinaryTreeMethods.BreadthFirstMinValue(null);

			Assert.Null(result);
		}

		[Fact]
		public void BreadthFirstMinValue_AllEqualNodes_ReturnsNodeValue()
		{
			var root = new Node<int>(10);
			root.Left = new Node<int>(10);
			root.Right = new Node<int>(10);
			root.Left.Left = new Node<int>(10);
			root.Left.Right = new Node<int>(10);
			root.Right.Left = new Node<int>(10);
			root.Right.Right = new Node<int>(10);

			var result = BinaryTreeMethods.BreadthFirstMinValue(root);

			Assert.Equal(10, result);
		}

		[Fact]
		public void BreadthFirstMinValue_UnbalancedTree_ReturnsMinValue()
		{
			var root = new Node<int>(10);
			root.Left = new Node<int>(5);
			root.Left.Left = new Node<int>(2);
			root.Left.Left.Left = new Node<int>(1);

			var result = BinaryTreeMethods.BreadthFirstMinValue(root);

			Assert.Equal(1, result);
		}
	}
}