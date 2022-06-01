namespace NodeClasses;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Create a binary node structure: ");
        CreateBinaryNode();
        
        Console.WriteLine("\nCreate a nary node structure: ");
        CreateNaryNode();
    }

    static void CreateBinaryNode()
    {
        var root = new BinaryNode<string>("Root");
        var nodeA = new BinaryNode<string>("A");
        var nodeB = new BinaryNode<string>("B");
        var nodeC = new BinaryNode<string>("C");
        var nodeD = new BinaryNode<string>("D");
        var nodeE = new BinaryNode<string>("E");
        var nodeF = new BinaryNode<string>("F");

        root.AddLeft(nodeA);
        nodeA.AddLeft(nodeC);
        nodeA.AddRight(nodeD);
        root.AddRight(nodeB);
        nodeB.AddRight(nodeE);
        nodeE.AddLeft(nodeF);

        Console.WriteLine(root.ToString());
        Console.WriteLine(nodeA.ToString());
        Console.WriteLine(nodeB.ToString());
        Console.WriteLine(nodeC.ToString());
        Console.WriteLine(nodeD.ToString());
        Console.WriteLine(nodeE.ToString());
        Console.WriteLine(nodeF.ToString());
    }

    static void CreateNaryNode()
    {
        var root = new NaryNode<string>("Root");
        var childNodeA = new NaryNode<string>("A");
        var childNodeB = new NaryNode<string>("B");
        var childNodeC = new NaryNode<string>("C");
        var childNodeD = new NaryNode<string>("D");
        var childNodeE = new NaryNode<string>("E");
        var childNodeF = new NaryNode<string>("F");
        var childNodeG = new NaryNode<string>("G");
        var childNodeH = new NaryNode<string>("H");
        var childNodeI = new NaryNode<string>("I");

        root.AddChild(childNodeA);
        root.AddChild(childNodeB);
        root.AddChild(childNodeC);
        childNodeA.AddChild(childNodeD);
        childNodeA.AddChild(childNodeE);
        childNodeD.AddChild(childNodeG);
        childNodeC.AddChild(childNodeF);
        childNodeF.AddChild(childNodeH);
        childNodeF.AddChild(childNodeI);

        Console.WriteLine(root.ToString());
        Console.WriteLine(childNodeA.ToString());
        Console.WriteLine(childNodeB.ToString());
        Console.WriteLine(childNodeC.ToString());
        Console.WriteLine(childNodeD.ToString());
        Console.WriteLine(childNodeE.ToString());
        Console.WriteLine(childNodeF.ToString());
        Console.WriteLine(childNodeG.ToString());
        Console.WriteLine(childNodeH.ToString());
        Console.WriteLine(childNodeI.ToString());
    }
}
