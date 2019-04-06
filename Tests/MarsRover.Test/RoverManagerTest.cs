using MarsRover.Core.Enums;
using MarsRover.Core.Infrastructure;
using MarsRover.Core.Model;

namespace MarsRover.ConsoleApp
{
    public class RoverManagerTest: IVehicle
    {
        #region members
        private int _positionX { get; set; }
        private int _positionY { get; set; }
        private Direction _direction { get; set; }
        Grid _grid { get; set; }
        #endregion

        #region ctor
        public RoverManagerTest(int x, int y, Direction direction, Grid plateau)
        {
            _positionX = x;
            _positionY = y;
            _direction = direction;
            _grid = plateau;
        }
        #endregion

        #region methods
        public void Move()
        {
            if (_direction == Direction.N && _grid.Y > _positionY)
            {
                _positionY++;
            }
            else if (_direction == Direction.E && _grid.X > _positionX)
            {
                _positionX++;
            }
            else if (_direction == Direction.S && _positionY > 0)
            {
                _positionY--;
            }
            else if (_direction == Direction.W && _positionX > 0)
            {
                _positionX--;
            }
        }
        public void SetDirection(char strRotate)
        {
            if (strRotate == 'L')
                _direction = (_direction - 90) < Direction.N ? Direction.W : _direction - 90;
            else if (strRotate == 'R')
                _direction = (_direction + 90) > Direction.W ? Direction.N : _direction + 90;
        }
        public string Process(string strControl)
        {
            foreach (var character in strControl)
            {
                if (character == 'L' || character == 'R')
                    SetDirection(character);
                else if (character == 'M')
                    Move();
            }

            return $"{_positionX} {_positionY} {_direction}";
        }
        #endregion

    }
}
