using System;
using System.Collections;

class Program
{
    public void Sketch()
    {
        Stack path = new Stack();
        
        Cell currentPosition;
        ConsoleKeyInfo key;

        do
        {
          // Etch in the direction indicated by the
          // arrow keys that the user enters.
          key = Move();

          switch (key.Key)
          {
              case ConsoleKey.Z:
                  // Undo the previous Move.
                  if (path.Count >= 1)
                  {
                      currentPosition = (Cell)path.Pop();

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

                  path.Push(currentPosition);

                  break;

              default:
                  Console.Beep();  // Added in C# 2.0
                  break;
          }
        } while (key.Key != ConsoleKey.X);
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

    public class CellStack
    {
        public virtual Cell Pop();

        public virtual Push(Cell cell);
    }

    struct NullableInt
    {
        /// <summary>
        /// Provides the value when HasValue returns true.
        /// </summary>
        public int Value { get; private set; }

        /// <summary>
        /// Indicates whether there is a value or whether
        /// the value is "null"
        /// </summary>
        public bool HasValue{ get; private set; }
    }

    struct NullableGuid
    {
        /// <summary>
        /// Provides the value when HasValue returns true.
        /// </summary>
        public Guid Value { get; private set; }

        /// <summary>
        /// Indicates whether there is a value or whether
        /// the value is "null"
        /// </summary>
        public bool HasValue{ get; private set; }
    }

    struct Nullable
    {
        /// <summary>
        /// Provides the value when HasValue returns true.
        /// </summary>
        public object Value{ get; private set; }

        /// <summary>
        /// Indicates whether there is a value or whether
        /// the value is "null"
        /// </summary>
        public bool HasValue{ get; private set; }
    }
}