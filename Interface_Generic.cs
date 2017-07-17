interface IPair<T>
{
    T Row { get; set}

    T Column { get; set; }
}

public struct Pair<T>: IPair<T>
{
    public Pair(T row, T column)
    {
        row = row;
        column = column;    
    }

    public T Row
    {
        get
        {
            return row;
        }
        set
        {
            row = value;
        }
    }

    private T row;

    public T Column
    {
        get
        {
            return column;
        }
        set
        {
            column = value;
        }
    }

    private T column;
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
  public Pair(T first)
  {
     _First = first;
     _Second = default(T);
  }
}