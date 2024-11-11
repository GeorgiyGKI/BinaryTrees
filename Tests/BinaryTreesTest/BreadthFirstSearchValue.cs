using BinaryTrees;

namespace Tests.BinaryTreesTest
{
	public class BreadthFirstSearchValue
	{
		[Fact]
		public void BreadthFirstSearchValue_Found_ReturnsValue()
		{
			var root = new Node<int>(1);
			root.Left = new Node<int>(2);
			root.Right = new Node<int>(3);
			root.Left.Left = new Node<int>(4);
			root.Left.Right = new Node<int>(5);

			var result = BinaryTreeMethods.BreadthFirstSearchValue(root, 4);

			Assert.Equal(4, result);
		}

		[Fact]
		public void BreadthFirstSearchValue_NotFound_ReturnsDefault()
		{
			var root = new Node<int>(1);
			root.Left = new Node<int>(2);
			root.Right = new Node<int>(3);
			root.Left.Left = new Node<int>(4);
			root.Left.Right = new Node<int>(5);

			var result = BinaryTreeMethods.BreadthFirstSearchValue(root, 6);

			Assert.Equal(default(int), result);
		}

		[Fact]
		public void BreadthFirstSearchValue_EmptyTree_ReturnsDefault()
		{
			var result = BinaryTreeMethods.BreadthFirstSearchValue<int>(null, 1);

			Assert.Equal(default(int), result);
		}

		[Fact]
		public void BreadthFirstSearchValue_RootNode_ReturnsValue()
		{
			var root = new Node<int>(1);

			var result = BinaryTreeMethods.BreadthFirstSearchValue(root, 1);

			Assert.Equal(1, result);
		}

		[Fact]
		public void BreadthFirstSearchValue_UnbalancedTree_ReturnsValue()
		{
			var root = new Node<int>(1);
			root.Left = new Node<int>(2);
			root.Left.Left = new Node<int>(3);
			root.Left.Left.Left = new Node<int>(4);

			var result = BinaryTreeMethods.BreadthFirstSearchValue(root, 4);

			Assert.Equal(4, result);
		}
	}
}