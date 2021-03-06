﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game8.Emulator
{
    class Gameboy
    {
        internal Clock Clock;
        internal CPU CPU;
        internal MMU MMU;
        internal Screen Screen;
        internal Buttons Buttons;

        internal Gameboy(MainWindow DisplayWindow)
        {
            Clock = new Clock();

            CPU = new CPU(this);
            MMU = new MMU(this);
            Buttons = new Buttons(this);
            Screen = new Screen(this, DisplayWindow);

            CPU.SetupClocks();
            Screen.SetupClocks();

            MMU.LoadRom("ROM.ch8");
        }


        internal void Run()
        {
            Clock.RunClock();
        }
    }
}
