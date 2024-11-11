namespace BinaryTrees
{
	public static class BinaryTreeMethods
	{
		public static IEnumerable<T> DeepFirstValues<T>(Node<T> root)
		{
			if(root == null) return [];

			var result = new List<T>();
			var queue = new Stack<Node<T>>();
			queue.Push(root);
			while (queue.Count > 0)
			{
				var current = queue.Pop();
				result.Add(current.Value);

				if (current.Right != null)
					queue.Push(current.Right);
				if (current.Left != null)
					queue.Push(current.Left);
			}

			return result;
		}

		public static IEnumerable<T> BreadthFirstValues<T>(Node<T> root)
		{
			if (root == null) return [];

			var result = new List<T>();
			var queue = new Queue<Node<T>>();
			queue.Enqueue(root);
			while (queue.Count > 0)
			{
				var current = queue.Dequeue();
				result.Add(current.Value);

				if (current.Left != null)
					queue.Enqueue(current.Left);
				if (current.Right != null)
					queue.Enqueue(current.Right);
				
			}

			return result;
		}

		public static T? BreadthFirstSearchValue<T>(Node<T> root, T value)
		{
			if (root == null) return default;

			var queue = new Queue<Node<T>>();
			queue.Enqueue(root);
			while (queue.Count > 0)
			{
				var current = queue.Dequeue();
				if (current.Value.Equals(value))
				{
					return current.Value;
				}
				

				if (current.Left != null)
					queue.Enqueue(current.Left);
				if (current.Right != null)
					queue.Enqueue(current.Right);

			}

			return default;
		}

		public static int BreadthFirstTreeSum(Node<int> root)
		{
			if (root == null) return default;

			var queue = new Queue<Node<int>>();
			queue.Enqueue(root);
			var sum = 0;
			while (queue.Count > 0)
			{
				var current = queue.Dequeue();
			
				 sum+= current.Value;

				if (current.Left != null)
					queue.Enqueue(current.Left);
				if (current.Right != null)
					queue.Enqueue(current.Right);

			}

			return sum;
		}

		public static int TreeSumRecursion(Node<int> root)
		{
			if (root == null) return 0;
			return root.Value + TreeSumRecursion(root.Left) + TreeSumRecursion(root.Right);
		}

		public static int MaxPathRecursion(Node<int> root)
		{
			if (root == null) return int.MinValue;
            if (root.Left == null && root.Right == null) return root.Value;
			var maxChild = Math.Max(MaxPathRecursion(root.Left), MaxPathRecursion(root.Right));
			return root.Value + maxChild;
		}

		public static int? BreadthFirstMinValue(Node<int> root)
		{
			if (root == null) return null;

			var queue = new Queue<Node<int>>();
			queue.Enqueue(root);
			var minValue = int.MaxValue;
			while (queue.Count > 0)
			{
				var current = queue.Dequeue();

				if(current.Value < minValue)
					minValue = current.Value;

				if (current.Left != null)
					queue.Enqueue(current.Left);
				if (current.Right != null)
					queue.Enqueue(current.Right);

			}

			return minValue != int.MaxValue ? minValue : null;
		}

		
	}
}