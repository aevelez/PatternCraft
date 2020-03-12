using System.Collections.Generic;

namespace PatternCraft.Command
{
    public interface ICommand
    {
        void Execute();
        bool CanExecute();
    }

    public interface IUnit
    {
        int Minerals { get; set; }
        Point Position { get; set; }

        void Move(int x, int y);
        void Gather();
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Probe : IUnit
    {
        public Queue<ICommand> Commands { get; set; } = new Queue<ICommand>();

        public int Minerals { get; set; }

        public Point Position { get; set; } = new Point { X = 0, Y = 0 };

        public void Move(int x, int y)
        {
            Commands.Enqueue(new MoveCommand(this, x, y));
        }

        public void Gather()
        {
            Commands.Enqueue(new GatherCommand(this));
        }
    }

    public class MoveCommand : ICommand
    {
        private IUnit _unit;
        private int _x;
        private int _y;

        public MoveCommand(IUnit unit, int x, int y)
        {
            _unit = unit;
            _x = x;
            _y = y;
        }

        public bool CanExecute() => true;

        public void Execute()
        {
            if (CanExecute())
            {
                _unit.Position.X = _x;
                _unit.Position.Y = _y;
            }
        }
    }

    public class GatherCommand : ICommand
    {
        private IUnit _unit;

        public GatherCommand(IUnit unit)
        {
            _unit = unit;
        }

        public bool CanExecute() => _unit.Minerals == 0;

        public void Execute()
        {
            if (CanExecute())
            {
                _unit.Minerals += 5;
            }
        }
    }
}
