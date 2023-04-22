using System.Collections.Generic;

namespace GeneticAlgorithmTool
{
    public static class GameActions
    {
        public static IEnumerable<IEnumerable<Buttons>> RightOnly = new [] { 
            new []{Buttons.None},
            new []{Buttons.Right},
            new []{Buttons.Right, Buttons.A },
            new []{Buttons.Right, Buttons.B },
            new []{Buttons.Right, Buttons.A, Buttons.B },
        };

        public static IEnumerable<IEnumerable<Buttons>> SimpleMovement = new[] {
            new[] { Buttons.None }, 
            new[] { Buttons.Right }, 
            new[] { Buttons.Right, Buttons.A }, 
            new[] { Buttons.Right, Buttons.B }, 
            new[] { Buttons.Right, Buttons.A, Buttons.B },
            new[] { Buttons.Left }};

        public static IEnumerable<IEnumerable<Buttons>> ComplexMovement = new[] {
            new []{Buttons.None},
            new []{Buttons.Right},
            new []{Buttons.Right, Buttons.A },
            new []{Buttons.Right, Buttons.B },
            new []{Buttons.Right, Buttons.A, Buttons.B },
            new []{Buttons.Left },
            new []{Buttons.Left, Buttons.A },
            new []{Buttons.Left, Buttons.B },
            new []{Buttons.Left, Buttons.A, Buttons.B },
            new []{Buttons.Up},
            new []{Buttons.Down},
        };
    }
    public enum Buttons
    {
        None = -1,
        Up = 0,
        Down = 1,
        Left = 2,
        Right = 3,
        Start = 4,
        Select = 5,
        B = 6,
        A = 7,
        Reset = 8,
        Power = 9
    }
}
