using BinaryTrees;

namespace Tests.BinaryTreesTest
{

		public class DeepFirstTests
		{
			[Fact]
			public void DeepFirstValues_SingleNode_ReturnsSingleNode()
			{
				var node = new Node<int>(1);
				var result = BinaryTreeMethods.DeepFirstValues(node).ToList();

				Assert.Single(result);
				Assert.Equal(1, result[0]);
			}

			[Fact]
			public void DeepFirstValues_SimpleTree_ReturnsCorrectOrder()
			{
				var root = new Node<int>(1);
				root.Left = new Node<int>(2);
				root.Right = new Node<int>(3);
				root.Left.Left = new Node<int>(4);
				root.Left.Right = new Node<int>(5);
				root.Right.Left = new Node<int>(6);
				root.Right.Right = new Node<int>(7);

				var result = BinaryTreeMethods.DeepFirstValues(root).ToList();

				var expected = new List<int> { 1, 2, 4, 5, 3, 6, 7 };
				Assert.Equal(expected, result);
			}

			[Fact]
			public void DeepFirstValues_EmptyTree_ReturnsEmpty()
			{
				var result = BinaryTreeMethods.DeepFirstValues<int>(null);

				Assert.Empty(result);
			}
		
	}
}