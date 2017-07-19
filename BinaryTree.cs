public class BinaryTree<T> where T: System.IComparable<T>
{
    public BinaryTree(T item)
    {
        Item = item;
    }

    public T Item
    {
        get{ return _Item; }
        set{ _Item = value; }
    }

    private T _Item;

    public Pair<BinaryTree<T>> SubItems
    {
        get { return subItems; }
        set 
        { 
            IComparable<T> left;
            // ERROR: Cannot implicitly convert type...
            // left = value.Left.Item;  // Explicit cast required


            // Execution-time error: InvalidCastException if T does not implement the IComparable inferface.
            // left = (IComparable<T>)value.Left.Item;

            left = value.Left.Item;

            if (left.CompareTo(value.Right.Item) < 0)
            {
                // left is less than right.
                // ...
            }
            else
            {
                // left and right are the same or
                // right is less than left.
                // ...
            }

            subItems = value;
        }
    }

    private Pair<BinaryTree<T>> subItems;
}
