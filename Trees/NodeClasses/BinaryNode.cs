namespace NodeClasses;

public class BinaryNode<T>
{
    private T Value { get; }
    private BinaryNode<T>? LeftChild { get; set; }
    private BinaryNode<T>? RightChild { get; set; }

    public BinaryNode(T value)
    {
        Value = value;
        LeftChild = null;
        RightChild = null;
    }
    
    public void AddLeft(BinaryNode<T> leftChild) =>
        LeftChild = leftChild;

    public void AddRight(BinaryNode<T> rightChild) =>
        RightChild = rightChild;

    public override string ToString() =>
        $@"{Value}: {(LeftChild == null ? "null" : LeftChild.Value)} {(RightChild == null ? "null" : RightChild.Value)}";
}