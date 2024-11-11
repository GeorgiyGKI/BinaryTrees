using BinaryTrees;

namespace Tests.BinaryTreesTest
{
	public class BreadthFirstTests
	{
		[Fact]
		public void BreadthFirstValues_SingleNode_ReturnsSingleValue()
		{
			var node = new Node<int>(1);
			var result = BinaryTreeMethods.BreadthFirstValues(node).ToList();

			Assert.Single(result);
			Assert.Equal(1, result[0]);
		}

		[Fact]
		public void BreadthFirstValues_SimpleTree_ReturnsCorrectOrder()
		{
			var root = new Node<int>(1);
			root.Left = new Node<int>(2);
			root.Right = new Node<int>(3);
			root.Left.Left = new Node<int>(4);
			root.Left.Right = new Node<int>(5);
			root.Right.Left = new Node<int>(6);
			root.Right.Right = new Node<int>(7);

			var result = BinaryTreeMethods.BreadthFirstValues(root).ToList();

			var expected = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
			Assert.Equal(expected, result);
		}

		[Fact]
		public void BreadthFirstValues_EmptyTree_ReturnsEmpty()
		{
			var result = BinaryTreeMethods.BreadthFirstValues<int>(null);

			Assert.Empty(result);
		}

		[Fact]
		public void BreadthFirstValues_UnbalancedTree_ReturnsCorrectOrder()
		{
			var root = new Node<int>(1);
			root.Left = new Node<int>(2);
			root.Left.Left = new Node<int>(3);
			root.Left.Left.Left = new Node<int>(4);

			var result = BinaryTreeMethods.BreadthFirstValues(root).ToList();

			var expected = new List<int> { 1, 2, 3, 4 };
			Assert.Equal(expected, result);
		}
	}
}