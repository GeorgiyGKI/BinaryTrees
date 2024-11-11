using BinaryTrees;

namespace Tests.BinaryTreesTest
{
	public class MaxPathRecursionTests
	{
		[Fact]
		public void MaxPathRecursion_SingleNode_ReturnsNodeValue()
		{
			var root = new Node<int>(10);

			var result = BinaryTreeMethods.MaxPathRecursion(root);

			Assert.Equal(10, result);
		}

		[Fact]
		public void MaxPathRecursion_MultipleNodes_ReturnsMaxPathSum()
		{
			var root = new Node<int>(10);
			root.Left = new Node<int>(5);
			root.Right = new Node<int>(15);
			root.Left.Left = new Node<int>(2);
			root.Left.Right = new Node<int>(8);
			root.Right.Left = new Node<int>(12);
			root.Right.Right = new Node<int>(20);

			var result = BinaryTreeMethods.MaxPathRecursion(root);

			Assert.Equal(45, result); // 10 + 15 + 20
		}

		[Fact]
		public void MaxPathRecursion_NullTree_ReturnsMinValue()
		{
			var result = BinaryTreeMethods.MaxPathRecursion(null);

			Assert.Equal(int.MinValue, result);
		}

		[Fact]
		public void MaxPathRecursion_AllNegativeNodes_ReturnsMaxPathSum()
		{
			var root = new Node<int>(-10);
			root.Left = new Node<int>(-5);
			root.Right = new Node<int>(-15);
			root.Left.Left = new Node<int>(-2);
			root.Left.Right = new Node<int>(-8);
			root.Right.Left = new Node<int>(-12);
			root.Right.Right = new Node<int>(-20);

			var result = BinaryTreeMethods.MaxPathRecursion(root);

			Assert.Equal(-17, result); // -10 + (-5) + (-2)
		}

		[Fact]
		public void MaxPathRecursion_UnbalancedTree_ReturnsMaxPathSum()
		{
			var root = new Node<int>(10);
			root.Left = new Node<int>(5);
			root.Left.Left = new Node<int>(2);
			root.Left.Left.Left = new Node<int>(1);

			var result = BinaryTreeMethods.MaxPathRecursion(root);

			Assert.Equal(18, result); // 10 + 5 + 2 + 1
		}

		[Fact]
		public void MaxPathRecursion_RightSkewedTree_ReturnsMaxPathSum()
		{
			var root = new Node<int>(10);
			root.Right = new Node<int>(20);
			root.Right.Right = new Node<int>(30);

			var result = BinaryTreeMethods.MaxPathRecursion(root);

			Assert.Equal(60, result); // 10 + 20 + 30
		}

		[Fact]
		public void MaxPathRecursion_LeftSkewedTree_ReturnsMaxPathSum()
		{
			var root = new Node<int>(10);
			root.Left = new Node<int>(20);
			root.Left.Left = new Node<int>(30);

			var result = BinaryTreeMethods.MaxPathRecursion(root);

			Assert.Equal(60, result); // 10 + 20 + 30
		}
	}
}