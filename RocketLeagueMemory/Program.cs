using System;
using System.Diagnostics;
using System.Drawing;
using CUE.NET.Devices.Keyboard;
using CUE.NET.Brushes;
using CUE.NET;
using CUE.NET.Exceptions;

namespace RocketLeagueMemory
{
    class Program
    {
       
        static void Main(string[] args)
        {

            string memAddress = "\"RocketLeague.exe\"+014FA9C4+58+5AC+6F4+21C";
            var rlProcess = Process.GetProcessesByName("RocketLeague");
            Memory.Memory mem = new Memory.Memory(rlProcess[0]);
            IntPtr boostAddress = mem.GetAddress(memAddress);
            var boostFloat = mem.ReadFloat(boostAddress) / 3 * 100;

            CueSDK.Initialize();
            CorsairKeyboard keyboard = CueSDK.KeyboardSDK;
            if (keyboard == null)
                throw new WrapperException("No keyboard found.");
            keyboard.Brush = new SolidColorBrush(Color.Black);
            keyboard.Update();

            Corsair.ColorKeyboard.ColorTheBoard(0, keyboard);


            while (true)
            {
                boostAddress = mem.GetAddress(memAddress);    
                boostFloat = mem.ReadFloat(boostAddress) / 3 * 100;
                Console.WriteLine(boostFloat);
                Corsair.ColorKeyboard.ColorTheBoard(boostFloat, keyboard);
            }
        }
    }
}
