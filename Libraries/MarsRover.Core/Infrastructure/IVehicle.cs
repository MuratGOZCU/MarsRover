using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Core.Infrastructure
{
    public interface IVehicle
    {
        void Move();
        void SetDirection(char strRotate);
        string Process(string strControl);
    }
}
