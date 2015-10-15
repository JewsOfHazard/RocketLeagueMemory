using System;
using System.Diagnostics;
using System.Drawing;
using CUE.NET.Devices.Keyboard;
using CUE.NET;
using CUE.NET.Exceptions;

namespace RocketLeagueMemory
{
    class Program
    {
       
        static void Main(string[] args)
        {
            var rlProcess = Process.GetProcessesByName("RocketLeague");
            Memory.Memory mem = new Memory.Memory(rlProcess[0]);
            IntPtr boostAddress = mem.GetAddress("\"RocketLeague.exe\"+01570020+94+204+6F4+21C");
            var boostFloat = mem.ReadFloat(boostAddress) / 3 * 100;

            CueSDK.Initialize();
            CorsairKeyboard keyboard = CueSDK.KeyboardSDK;
            if (keyboard == null)
                throw new WrapperException("No keyboard found.");
            keyboard.Color = Color.Black;
            keyboard.UpdateLeds();

            Corsair.ColorKeyboard.colorBoard(100, keyboard,  0);


            while (true)
            {
                boostAddress = mem.GetAddress("\"RocketLeague.exe\"+01570020+94+204+6F4+21C");
                boostFloat = mem.ReadFloat(boostAddress) / 3 * 100;
                Console.WriteLine((int)boostFloat);
                Corsair.ColorKeyboard.colorBoard((int)boostFloat, keyboard,  1);
            }
        }
    }
}
