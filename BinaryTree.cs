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
        get { return _SubItems; }
        set { 
            IComparable<T> first;
            // ERROR: Cannot implicitly convert type...
            // first = value.First;  // Explicit cast required


            // Execution-time error: InvalidCastException if T does not implement the IComparable inferface.
            // first = (IComparable<T>)value.First;

            first = value.First;

            if (first.CompareTo(value.Second) < 0)
            {
                // first is less than second.
                // ...
            }
            else
            {
                // first and second are the same or
                // second is less than first.
                // ...
            }

            _SubItems = value;
        }
    }

    private Pair<BinaryTree<T>> _SubItems;
}
