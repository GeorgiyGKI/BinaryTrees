// See https://aka.ms/new-console-template for more information
using BinaryTrees;

Node<int> root = new Node<int>(10);

// Adding children to the root node
root.Left = new Node<int>(9);
root.Right = new Node<int>(31);

// Adding children to the left node
root.Left.Left = new Node<int>(40);

// Adding children to the right node
root.Right.Left = new Node<int>(6);
root.Right.Right = new Node<int>(7);

Console.WriteLine(BinaryTreeMethods.BreadthFirstMinValue(root));
static void DisplayTree(Node<int> node, string indent = "", bool last = true)
{
	if (node != null)
	{
		Console.WriteLine(indent + "+- " + node.Value);
		indent += last ? "   " : "|  ";

		DisplayTree(node.Left, indent, false);
		DisplayTree(node.Right, indent, true);
	}
}