﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface IVehicle
    {
        void Drive(int totalFuel);

        bool Refuel(int gasoline);

    }
}
