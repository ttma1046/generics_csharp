interface IPair<T>
{
    T Right { get; set}

    T Left { get; set; }
}

public struct Pair<T>: IPair<T>
{
    public Pair(T right, T left)
    {
        right = right;
        left = left;    
    }

    public T Right
    {
        get
        {
            return right;
        }
        set
        {
            right = value;
        }
    }

    private T right;

    public T Left
    {
        get
        {
            return left;
        }
        set
        {
            left = value;
        }
    }

    private T left;
}

/*
public struct Pair<T>: IPair<T>
{
  // ERROR:  Field 'Pair<T>._second' must be fully assigned
  //         before control leaves the constructor
  public Pair(T first)
  {
     _First = first;
  }
}
*/

public struct Pair<T>: IPair<T>
{
    // ERROR:  Field 'Pair<T>._second' must be fully assigned
    //         before control leaves the constructor
    public Pair(T left)
    {
        left = left;
        right = default(T);
    }

    public T Right
    {
        get
        {
            return right;
        }
        set
        {
            right = value;
        }
    }

    private T right;

    public T Left
    {
        get
        {
            return left;
        }
        set
        {
            left = value;
        }
    }

    private T left;
}