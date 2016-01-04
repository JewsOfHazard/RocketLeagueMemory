using System;
using System.Drawing;
using CUE.NET.Brushes;
using CUE.NET.Devices.Keyboard;
using CUE.NET.Devices.Keyboard.Enums;
using CUE.NET.Devices.Keyboard.Keys;

namespace RocketLeagueMemory.Corsair

{
    class ColorKeyboard
    {


        public static void ColorTheBoard(double percentage, CorsairKeyboard keyboard)
        {


            RectangleKeyGroup[] rows = new RectangleKeyGroup[23];

            rows[0] = new RectangleKeyGroup(keyboard, CorsairKeyboardKeyId.G1, CorsairKeyboardKeyId.G16) { Brush = new SolidColorBrush(Color.Black) };
            rows[1] = new RectangleKeyGroup(keyboard, CorsairKeyboardKeyId.G2, CorsairKeyboardKeyId.G17) { Brush = new SolidColorBrush(Color.Black) };
            rows[2] = new RectangleKeyGroup(keyboard, CorsairKeyboardKeyId.G3, CorsairKeyboardKeyId.G18) { Brush = new SolidColorBrush(Color.Black) };
            rows[3] = new RectangleKeyGroup(keyboard, CorsairKeyboardKeyId.MR, CorsairKeyboardKeyId.LeftCtrl) { Brush = new SolidColorBrush(Color.Black) };
            rows[4] = new RectangleKeyGroup(keyboard, CorsairKeyboardKeyId.M1, CorsairKeyboardKeyId.LeftGui) { Brush = new SolidColorBrush(Color.Black) };
            rows[5] = new RectangleKeyGroup(keyboard, CorsairKeyboardKeyId.M2, CorsairKeyboardKeyId.Z) { Brush = new SolidColorBrush(Color.Black) };
            rows[6] = new RectangleKeyGroup(keyboard, CorsairKeyboardKeyId.M3, CorsairKeyboardKeyId.X) { Brush = new SolidColorBrush(Color.Black) };
            rows[7] = new RectangleKeyGroup(keyboard, CorsairKeyboardKeyId.F3, CorsairKeyboardKeyId.C) { Brush = new SolidColorBrush(Color.Black) };
            rows[8] = new RectangleKeyGroup(keyboard, CorsairKeyboardKeyId.F4, CorsairKeyboardKeyId.V) { Brush = new SolidColorBrush(Color.Black) };
            rows[9] = new RectangleKeyGroup(keyboard, CorsairKeyboardKeyId.V, CorsairKeyboardKeyId.F5) { Brush = new SolidColorBrush(Color.Black) };
            rows[10] = new RectangleKeyGroup(keyboard, CorsairKeyboardKeyId.F6, CorsairKeyboardKeyId.Space) { Brush = new SolidColorBrush(Color.Black) };
            rows[11] = new RectangleKeyGroup(keyboard, CorsairKeyboardKeyId.N, CorsairKeyboardKeyId.F7) { Brush = new SolidColorBrush(Color.Black) };
            rows[12] = new RectangleKeyGroup(keyboard, CorsairKeyboardKeyId.F7, CorsairKeyboardKeyId.PeriodAndBiggerThan) { Brush = new SolidColorBrush(Color.Black) };
            rows[13] = new RectangleKeyGroup(keyboard, CorsairKeyboardKeyId.RightAlt, CorsairKeyboardKeyId.F9) { Brush = new SolidColorBrush(Color.Black) };
            rows[14] = new RectangleKeyGroup(keyboard, CorsairKeyboardKeyId.RightGui, CorsairKeyboardKeyId.F11) { Brush = new SolidColorBrush(Color.Black) };
            rows[15] = new RectangleKeyGroup(keyboard, CorsairKeyboardKeyId.F11, CorsairKeyboardKeyId.RightCtrl) { Brush = new SolidColorBrush(Color.Black) };
            rows[16] = new RectangleKeyGroup(keyboard, CorsairKeyboardKeyId.Brightness, CorsairKeyboardKeyId.LeftArrow) { Brush = new SolidColorBrush(Color.Black) };
            rows[17] = new RectangleKeyGroup(keyboard, CorsairKeyboardKeyId.WinLock, CorsairKeyboardKeyId.DownArrow) { Brush = new SolidColorBrush(Color.Black) };
            rows[18] = new RectangleKeyGroup(keyboard, CorsairKeyboardKeyId.PauseBreak, CorsairKeyboardKeyId.RightArrow) { Brush = new SolidColorBrush(Color.Black) };
            rows[19] = new RectangleKeyGroup(keyboard, CorsairKeyboardKeyId.Stop, CorsairKeyboardKeyId.Keypad0) { Brush = new SolidColorBrush(Color.Black) };
            rows[20] = new RectangleKeyGroup(keyboard, CorsairKeyboardKeyId.Mute, CorsairKeyboardKeyId.Keypad2) { Brush = new SolidColorBrush(Color.Black) };
            rows[21] = new RectangleKeyGroup(keyboard, CorsairKeyboardKeyId.PlayPause, CorsairKeyboardKeyId.KeypadPeriodAndDelete) { Brush = new SolidColorBrush(Color.Black) };
            rows[22] = new RectangleKeyGroup(keyboard, CorsairKeyboardKeyId.ScanNextTrack, CorsairKeyboardKeyId.KeypadPlus) { Brush = new SolidColorBrush(Color.Black) };


            percentage = percentage / 4.54;
            int newPercentage = (int)percentage;
            //Console.WriteLine(percentage);
            Color toColor = Color.Black;

            if (newPercentage < 7 && newPercentage != 0)
            {
                Console.WriteLine(newPercentage);
                toColor = Color.Red;
            }
            else if (newPercentage >= 7 && newPercentage < 16)
            {
                Console.WriteLine(newPercentage);
                toColor = Color.Yellow;
            }
            else if (newPercentage >= 16)
            {
                Console.WriteLine(newPercentage);
                toColor = Color.Green;
            }
            else
            {
                Console.WriteLine(newPercentage);
                toColor = Color.Black;
            }

            Console.WriteLine(toColor);
            for(int i = 0; i <= newPercentage; i++)
            {
                try
                {
                    rows[i].Brush = new SolidColorBrush(toColor);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
                

            Console.WriteLine("Coloring Keyboard");
            keyboard.Update();


        }

               
    


    }
}
