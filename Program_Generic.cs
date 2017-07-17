using System;
// using System.Collections.Generic;

public class Stack<T>
{
    private T[] _Items;

    public void Push(T data)
    {
        ...
    }

    public T Pop()
    {
        
    }
}

class Program
{
    public void Sketch()
    {
        Stack<Cell> path = new Stack<Cell>(); //Generic variable declaration
        
        Cell currentPosition;
        ConsoleKeyInfor key;

        do
        {
            // Etch in the direction indicated by the
            // arrow keys entered by the user.
            key = Move();

            switch (key.Key)
            {
              case ConsoleKey.Z:
                  // Undo the previous Move.
                  if (path.Count >= 1)
                  {
                      currentPosition = path.Pop(); // No cast required.

                      Console.SetCursorPosition(
                          currentPosition.X, currentPosition.Y);

                      Undo();
                  }

                  break;

              case ConsoleKey.DownArrow:
              case ConsoleKey.UpArrow:
              case ConsoleKey.LeftArrow:
              case ConsoleKey.RightArrow:
                  // SaveState()
                  currentPosition = new Cell(
                      Console.CursorLeft, Console.CursorTop);
                  // Only type Cell allowed in call to Push().
                  path.Push(currentPosition);

                  break;

              default:
                Console.Beep();
                break;
            }
        } while (key.Key != ConsoleKey.X); // Use X to quit.
    }

    public struct Cell
    {
        readonly public int X;
        readonly public int Y;
        
        public Cell(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}