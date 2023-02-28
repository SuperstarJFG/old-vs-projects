using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vroom
{
    interface ICar
    {
        decimal getMiles();
        decimal getGasLevel();
        decimal getSpeed();
        void STOP();
        decimal getMPG();
        void SetMPG(int m);
        void Refill(int amount);
        decimal getTankCapacity();
        void SetTankCapacity(int c);
        void Drive(int speed);
    }


}
