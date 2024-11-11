namespace BinaryTrees
{
	public class Node<T>
	{
        public T Value { get; set; }
        public Node<T> Left { get; set; } = null;
		public Node<T> Right { get; set; } = null;
		public Node(T inputValue)
        {
            Value = inputValue;
        }
    }
}


