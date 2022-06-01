using System.Text;

namespace NodeClasses;

public class NaryNode<T>
{
    private T Value { get; }
    public IList<NaryNode<T>> Children { get; private set; }

    public NaryNode(T value)
    {
        Value = value;
        Children = new List<NaryNode<T>>();
    }
    
    public void AddChild(NaryNode<T> childNode) => 
        Children.Add(childNode);

    public override string ToString()
    {
        var nodeStructure = new StringBuilder($"{Value}: ");

        foreach (var childNone in Children)
            nodeStructure.Append($" {childNone.Value}");

        return nodeStructure.ToString();
    }
}