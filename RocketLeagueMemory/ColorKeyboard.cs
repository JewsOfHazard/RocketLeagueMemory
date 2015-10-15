using CUE.NET.Devices.Keyboard;
using CUE.NET.Devices.Keyboard.Keys;
using CUE.NET.Devices.Keyboard.Enums;
using System.Collections;
using System.Drawing;

namespace RocketLeagueMemory.Corsair

{
    class ColorKeyboard
    {
        


        static ArrayList rowOne = new ArrayList();
        static ArrayList rowTwo = new ArrayList();
        static ArrayList rowThree = new ArrayList();
        static ArrayList rowFour = new ArrayList();
        static ArrayList rowFive = new ArrayList();
        static ArrayList rowSix = new ArrayList();
        static ArrayList rowSeven = new ArrayList();
        static ArrayList rowEight = new ArrayList();
        static ArrayList rowNine = new ArrayList();
        static ArrayList rowTen = new ArrayList();
        static ArrayList rowEleven = new ArrayList();
        static ArrayList rowTwelve = new ArrayList();
        static ArrayList rowThirteen = new ArrayList();
        static ArrayList rowFourteen = new ArrayList();
        static ArrayList rowFifteen = new ArrayList();
        static ArrayList rowSixteen = new ArrayList();
        static ArrayList rowSeventeen = new ArrayList();
        static ArrayList rowEighteen = new ArrayList();
        static ArrayList rowNineteen = new ArrayList();
        static ArrayList rowT = new ArrayList();
        static ArrayList rowTOne = new ArrayList();
        static ArrayList rowTTwo = new ArrayList();
        static ArrayList rowTThree = new ArrayList();
        static ArrayList rowTFour = new ArrayList();


        public static void colorBoard(int percentage, CorsairKeyboard keyboard, int setup)
        {
            if (setup == 0)
            {


            

                rowOne.Add(CorsairKeyboardKeyId.G1);
                rowOne.Add(CorsairKeyboardKeyId.G4);
                rowOne.Add(CorsairKeyboardKeyId.G7);
                rowOne.Add(CorsairKeyboardKeyId.G10);
                rowOne.Add(CorsairKeyboardKeyId.G13);
                rowOne.Add(CorsairKeyboardKeyId.G16);

                rowTwo.Add(CorsairKeyboardKeyId.G2);
                rowTwo.Add(CorsairKeyboardKeyId.G5);
                rowTwo.Add(CorsairKeyboardKeyId.G8);
                rowTwo.Add(CorsairKeyboardKeyId.G11);
                rowTwo.Add(CorsairKeyboardKeyId.G14);
                rowTwo.Add(CorsairKeyboardKeyId.G17);

                rowThree.Add(CorsairKeyboardKeyId.G3);
                rowThree.Add(CorsairKeyboardKeyId.G6);
                rowThree.Add(CorsairKeyboardKeyId.G9);
                rowThree.Add(CorsairKeyboardKeyId.G12);
                rowThree.Add(CorsairKeyboardKeyId.G15);
                rowThree.Add(CorsairKeyboardKeyId.G18);

                rowFour.Add(CorsairKeyboardKeyId.Escape);
                rowFour.Add(CorsairKeyboardKeyId.GraveAccentAndTilde);
                rowFour.Add(CorsairKeyboardKeyId.Tab);
                rowFour.Add(CorsairKeyboardKeyId.CapsLock);
                rowFour.Add(CorsairKeyboardKeyId.LeftShift);
                rowFour.Add(CorsairKeyboardKeyId.LeftCtrl);
                rowFour.Add(CorsairKeyboardKeyId.D1);

                rowFive.Add(CorsairKeyboardKeyId.D2);
                rowFive.Add(CorsairKeyboardKeyId.Q);
                rowFive.Add(CorsairKeyboardKeyId.A);
                rowFive.Add(CorsairKeyboardKeyId.LeftGui);
                rowFive.Add(CorsairKeyboardKeyId.F1);

                rowSix.Add(CorsairKeyboardKeyId.D3);
                rowSix.Add(CorsairKeyboardKeyId.W);
                rowSix.Add(CorsairKeyboardKeyId.S);
                rowSix.Add(CorsairKeyboardKeyId.Z);
                rowSix.Add(CorsairKeyboardKeyId.X);
                rowSix.Add(CorsairKeyboardKeyId.LeftAlt);
                rowSix.Add(CorsairKeyboardKeyId.F2);

                rowSeven.Add(CorsairKeyboardKeyId.D4);
                rowSeven.Add(CorsairKeyboardKeyId.F3);
                rowSeven.Add(CorsairKeyboardKeyId.E);
                rowSeven.Add(CorsairKeyboardKeyId.R);
                rowSeven.Add(CorsairKeyboardKeyId.D);
                rowSeven.Add(CorsairKeyboardKeyId.F);
                rowSeven.Add(CorsairKeyboardKeyId.C);

                rowEight.Add(CorsairKeyboardKeyId.F4);
                rowEight.Add(CorsairKeyboardKeyId.D5);
                rowEight.Add(CorsairKeyboardKeyId.T);
                rowEight.Add(CorsairKeyboardKeyId.V);

                rowNine.Add(CorsairKeyboardKeyId.F5);
                rowNine.Add(CorsairKeyboardKeyId.D6);
                rowNine.Add(CorsairKeyboardKeyId.G);
                rowNine.Add(CorsairKeyboardKeyId.H);
                rowNine.Add(CorsairKeyboardKeyId.B);
                rowNine.Add(CorsairKeyboardKeyId.Y);

                rowTen.Add(CorsairKeyboardKeyId.F6);
                rowTen.Add(CorsairKeyboardKeyId.D7);
                rowTen.Add(CorsairKeyboardKeyId.Space);

                rowEleven.Add(CorsairKeyboardKeyId.D8);
                rowEleven.Add(CorsairKeyboardKeyId.F7);
                rowEleven.Add(CorsairKeyboardKeyId.U);
                rowEleven.Add(CorsairKeyboardKeyId.J);
                rowEleven.Add(CorsairKeyboardKeyId.N);

                rowTwelve.Add(CorsairKeyboardKeyId.D9);
                rowTwelve.Add(CorsairKeyboardKeyId.F8);
                rowTwelve.Add(CorsairKeyboardKeyId.I);
                rowTwelve.Add(CorsairKeyboardKeyId.K);
                rowTwelve.Add(CorsairKeyboardKeyId.M);

                rowThirteen.Add(CorsairKeyboardKeyId.D0);
                rowThirteen.Add(CorsairKeyboardKeyId.O);
                rowThirteen.Add(CorsairKeyboardKeyId.L);
                rowThirteen.Add(CorsairKeyboardKeyId.CommaAndLessThan);

                rowFourteen.Add(CorsairKeyboardKeyId.MinusAndUnderscore);
                rowFourteen.Add(CorsairKeyboardKeyId.F9);
                rowFourteen.Add(CorsairKeyboardKeyId.P);
                rowFourteen.Add(CorsairKeyboardKeyId.SemicolonAndColon);
                rowFourteen.Add(CorsairKeyboardKeyId.PeriodAndBiggerThan);
                rowFourteen.Add(CorsairKeyboardKeyId.RightAlt);

                rowFifteen.Add(CorsairKeyboardKeyId.RightGui);
                rowFifteen.Add(CorsairKeyboardKeyId.SlashAndQuestionMark);
                rowFifteen.Add(CorsairKeyboardKeyId.ApostropheAndDoubleQuote);
                rowFifteen.Add(CorsairKeyboardKeyId.BracketLeft);
                rowFifteen.Add(CorsairKeyboardKeyId.EqualsAndPlus);
                rowFifteen.Add(CorsairKeyboardKeyId.F10);
                rowFifteen.Add(CorsairKeyboardKeyId.SlashAndQuestionMark);

                rowSixteen.Add(CorsairKeyboardKeyId.F11);
                rowSixteen.Add(CorsairKeyboardKeyId.BracketRight);
                rowSixteen.Add(CorsairKeyboardKeyId.RightShift);
                rowSixteen.Add(CorsairKeyboardKeyId.Application);
                rowSixteen.Add(CorsairKeyboardKeyId.Backspace);
                rowSixteen.Add(CorsairKeyboardKeyId.Enter);

                rowSeventeen.Add(CorsairKeyboardKeyId.F12);
                rowSeventeen.Add(CorsairKeyboardKeyId.RightCtrl);
                rowSeventeen.Add(CorsairKeyboardKeyId.Backslash);

                rowEighteen.Add(CorsairKeyboardKeyId.PrintScreen);
                rowEighteen.Add(CorsairKeyboardKeyId.Insert);
                rowEighteen.Add(CorsairKeyboardKeyId.Delete);
                rowEighteen.Add(CorsairKeyboardKeyId.LeftArrow);
                rowEighteen.Add(CorsairKeyboardKeyId.Brightness);

                rowNineteen.Add(CorsairKeyboardKeyId.ScrollLock);
                rowNineteen.Add(CorsairKeyboardKeyId.Home);
                rowNineteen.Add(CorsairKeyboardKeyId.End);
                rowNineteen.Add(CorsairKeyboardKeyId.UpArrow);
                rowNineteen.Add(CorsairKeyboardKeyId.DownArrow);
                rowNineteen.Add(CorsairKeyboardKeyId.WinLock);

                rowT.Add(CorsairKeyboardKeyId.PauseBreak);
                rowT.Add(CorsairKeyboardKeyId.PageUp);
                rowT.Add(CorsairKeyboardKeyId.PageDown);
                rowT.Add(CorsairKeyboardKeyId.RightArrow);

                rowTOne.Add(CorsairKeyboardKeyId.NumLock);
                rowTOne.Add(CorsairKeyboardKeyId.Keypad7);
                rowTOne.Add(CorsairKeyboardKeyId.Keypad4);
                rowTOne.Add(CorsairKeyboardKeyId.Keypad1);
                rowTOne.Add(CorsairKeyboardKeyId.Keypad0);
                rowTOne.Add(CorsairKeyboardKeyId.Stop);

                rowTTwo.Add(CorsairKeyboardKeyId.KeypadSlash);
                rowTTwo.Add(CorsairKeyboardKeyId.Keypad8);
                rowTTwo.Add(CorsairKeyboardKeyId.Keypad5);
                rowTTwo.Add(CorsairKeyboardKeyId.Keypad2);
                rowTTwo.Add(CorsairKeyboardKeyId.Keypad0);
                rowTTwo.Add(CorsairKeyboardKeyId.ScanPreviousTrack);
                rowTTwo.Add(CorsairKeyboardKeyId.Mute);

                rowTThree.Add(CorsairKeyboardKeyId.PlayPause);
                rowTThree.Add(CorsairKeyboardKeyId.KeypadAsterisk);
                rowTThree.Add(CorsairKeyboardKeyId.Keypad9);
                rowTThree.Add(CorsairKeyboardKeyId.Keypad6);
                rowTThree.Add(CorsairKeyboardKeyId.Keypad3);
                rowTThree.Add(CorsairKeyboardKeyId.KeypadPeriodAndDelete);

                rowTFour.Add(CorsairKeyboardKeyId.ScanNextTrack);
                rowTFour.Add(CorsairKeyboardKeyId.KeypadMinus);
                rowTFour.Add(CorsairKeyboardKeyId.KeypadPlus);
                rowTFour.Add(CorsairKeyboardKeyId.KeypadEnter);

                

            }





            if (percentage > 0 && percentage < 4) { 
            
                foreach (CorsairKeyboardKeyId id in rowOne){
                    keyboard[id].Led.Color = Color.Red;
                }

            }
            else if (percentage >= 4 && percentage < 8)
            {

                foreach (CorsairKeyboardKeyId id in rowOne)
                    keyboard[id].Led.Color = Color.Red;
                foreach (CorsairKeyboardKeyId id in rowTwo)
                    keyboard[id].Led.Color = Color.Red;
            }
            else if (percentage >= 8 && percentage < 12)
            {

                foreach (CorsairKeyboardKeyId id in rowOne)
                    keyboard[id].Led.Color = Color.Red;
                foreach (CorsairKeyboardKeyId id in rowTwo)
                    keyboard[id].Led.Color = Color.Red;
                foreach (CorsairKeyboardKeyId id in rowThree)
                    keyboard[id].Led.Color = Color.Red;
            }
            else if (percentage >= 12 && percentage < 16)
            {

                foreach (CorsairKeyboardKeyId id in rowOne)
                    keyboard[id].Led.Color = Color.Red;
                foreach (CorsairKeyboardKeyId id in rowTwo)
                    keyboard[id].Led.Color = Color.Red;
                foreach (CorsairKeyboardKeyId id in rowThree)
                    keyboard[id].Led.Color = Color.Red;
                foreach (CorsairKeyboardKeyId id in rowFour)
                    keyboard[id].Led.Color = Color.Red;
            }
            else if (percentage >= 16 && percentage < 20)
            {

                foreach (CorsairKeyboardKeyId id in rowOne)
                    keyboard[id].Led.Color = Color.Red;
                foreach (CorsairKeyboardKeyId id in rowTwo)
                    keyboard[id].Led.Color = Color.Red;
                foreach (CorsairKeyboardKeyId id in rowThree)
                    keyboard[id].Led.Color = Color.Red;
                foreach (CorsairKeyboardKeyId id in rowFour)
                    keyboard[id].Led.Color = Color.Red;
                foreach (CorsairKeyboardKeyId id in rowFive)
                    keyboard[id].Led.Color = Color.Red;
            }
            else if (percentage >= 20 && percentage < 24)
            {

                foreach (CorsairKeyboardKeyId id in rowOne)
                    keyboard[id].Led.Color = Color.Red;
                foreach (CorsairKeyboardKeyId id in rowTwo)
                    keyboard[id].Led.Color = Color.Red;
                foreach (CorsairKeyboardKeyId id in rowThree)
                    keyboard[id].Led.Color = Color.Red;
                foreach (CorsairKeyboardKeyId id in rowFour)
                    keyboard[id].Led.Color = Color.Red;
                foreach (CorsairKeyboardKeyId id in rowFive)
                    keyboard[id].Led.Color = Color.Red;
                foreach (CorsairKeyboardKeyId id in rowSix)
                    keyboard[id].Led.Color = Color.Red;
            }
            else if (percentage >= 24 && percentage < 28)
            {

                foreach (CorsairKeyboardKeyId id in rowOne)
                    keyboard[id].Led.Color = Color.Red;
                foreach (CorsairKeyboardKeyId id in rowTwo)
                    keyboard[id].Led.Color = Color.Red;
                foreach (CorsairKeyboardKeyId id in rowThree)
                    keyboard[id].Led.Color = Color.Red;
                foreach (CorsairKeyboardKeyId id in rowFour)
                    keyboard[id].Led.Color = Color.Red;
                foreach (CorsairKeyboardKeyId id in rowFive)
                    keyboard[id].Led.Color = Color.Red;
                foreach (CorsairKeyboardKeyId id in rowSix)
                    keyboard[id].Led.Color = Color.Red;
                foreach (CorsairKeyboardKeyId id in rowSeven)
                    keyboard[id].Led.Color = Color.Red;
            }
            else if (percentage >= 28 && percentage < 32)
            {

                foreach (CorsairKeyboardKeyId id in rowOne)
                    keyboard[id].Led.Color = Color.Red;
                foreach (CorsairKeyboardKeyId id in rowTwo)
                    keyboard[id].Led.Color = Color.Red;
                foreach (CorsairKeyboardKeyId id in rowThree)
                    keyboard[id].Led.Color = Color.Red;
                foreach (CorsairKeyboardKeyId id in rowFour)
                    keyboard[id].Led.Color = Color.Red;
                foreach (CorsairKeyboardKeyId id in rowFive)
                    keyboard[id].Led.Color = Color.Red;
                foreach (CorsairKeyboardKeyId id in rowSix)
                    keyboard[id].Led.Color = Color.Red;
                foreach (CorsairKeyboardKeyId id in rowSeven)
                    keyboard[id].Led.Color = Color.Red;
                foreach (CorsairKeyboardKeyId id in rowEight)
                    keyboard[id].Led.Color = Color.Red;
            }
            else if (percentage >= 32 && percentage < 36)
            {

                foreach (CorsairKeyboardKeyId id in rowOne)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowTwo)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowThree)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowFour)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowFive)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowSix)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowSeven)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowEight)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowNine)
                    keyboard[id].Led.Color = Color.Yellow;
            }
            else if (percentage >= 36 && percentage < 40)
            {

                foreach (CorsairKeyboardKeyId id in rowOne)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowTwo)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowThree)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowFour)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowFive)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowSix)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowSeven)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowEight)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowNine)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowTen)
                    keyboard[id].Led.Color = Color.Yellow;
            }
            else if (percentage >= 40 && percentage < 44)
            {

                foreach (CorsairKeyboardKeyId id in rowOne)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowTwo)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowThree)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowFour)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowFive)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowSix)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowSeven)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowEight)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowNine)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowTen)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowEleven)
                    keyboard[id].Led.Color = Color.Yellow;

            }
            else if (percentage >= 44 && percentage < 48)
            {

                foreach (CorsairKeyboardKeyId id in rowOne)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowTwo)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowThree)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowFour)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowFive)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowSix)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowSeven)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowEight)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowNine)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowTen)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowEleven)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowTwelve)
                    keyboard[id].Led.Color = Color.Yellow;
            }
            else if (percentage >= 48 && percentage < 52)
            {

                foreach (CorsairKeyboardKeyId id in rowOne)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowTwo)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowThree)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowFour)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowFive)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowSix)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowSeven)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowEight)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowNine)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowTen)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowEleven)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowTwelve)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowThirteen)
                    keyboard[id].Led.Color = Color.Yellow;

            }
            else if (percentage >= 52 && percentage < 56)
            {

                foreach (CorsairKeyboardKeyId id in rowOne)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowTwo)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowThree)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowFour)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowFive)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowSix)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowSeven)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowEight)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowNine)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowTen)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowEleven)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowTwelve)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowThirteen)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowFourteen)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowFifteen)
                    keyboard[id].Led.Color = Color.Yellow;
            }
            else if (percentage >= 56 && percentage < 60)
            {

                foreach (CorsairKeyboardKeyId id in rowOne)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowTwo)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowThree)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowFour)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowFive)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowSix)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowSeven)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowEight)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowNine)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowTen)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowEleven)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowTwelve)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowThirteen)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowFourteen)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowFifteen)
                    keyboard[id].Led.Color = Color.Yellow;
                foreach (CorsairKeyboardKeyId id in rowSixteen)
                    keyboard[id].Led.Color = Color.Yellow;
            }
            else if (percentage >= 60 && percentage < 64)
            {

                foreach (CorsairKeyboardKeyId id in rowOne)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTwo)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowThree)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFour)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFive)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSix)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSeven)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowEight)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowNine)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowEleven)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTwelve)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowThirteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFourteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFifteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSixteen)
                    keyboard[id].Led.Color = Color.Green;
            }
            else if (percentage >= 64 && percentage < 68)
            {

                foreach (CorsairKeyboardKeyId id in rowOne)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTwo)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowThree)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFour)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFive)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSix)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSeven)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowEight)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowNine)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowEleven)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTwelve)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowThirteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFourteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFifteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSixteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSeventeen)
                    keyboard[id].Led.Color = Color.Green;
            }
            else if (percentage >= 68 && percentage < 72)
            {

                foreach (CorsairKeyboardKeyId id in rowOne)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTwo)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowThree)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFour)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFive)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSix)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSeven)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowEight)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowNine)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowEleven)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTwelve)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowThirteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFourteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFifteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSixteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSeventeen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowEighteen)
                    keyboard[id].Led.Color = Color.Green;
            }
            else if (percentage >= 72 && percentage < 76)
            {

                foreach (CorsairKeyboardKeyId id in rowOne)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTwo)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowThree)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFour)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFive)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSix)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSeven)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowEight)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowNine)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowEleven)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTwelve)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowThirteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFourteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFifteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSixteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSeventeen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowEighteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowNineteen)
                    keyboard[id].Led.Color = Color.Green;
            }
            else if (percentage >= 76 && percentage < 80)
            {

                foreach (CorsairKeyboardKeyId id in rowOne)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTwo)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowThree)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFour)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFive)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSix)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSeven)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowEight)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowNine)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowEleven)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTwelve)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowThirteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFourteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFifteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSixteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSeventeen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowEighteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowNineteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowT)
                    keyboard[id].Led.Color = Color.Green;
            }
            else if (percentage >= 76 && percentage < 80)
            {

                foreach (CorsairKeyboardKeyId id in rowOne)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTwo)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowThree)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFour)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFive)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSix)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSeven)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowEight)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowNine)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowEleven)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTwelve)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowThirteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFourteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFifteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSixteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSeventeen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowEighteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowNineteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowT)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTOne)
                    keyboard[id].Led.Color = Color.Green;
            }
            else if (percentage >= 80 && percentage < 84)
            {

                foreach (CorsairKeyboardKeyId id in rowOne)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTwo)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowThree)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFour)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFive)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSix)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSeven)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowEight)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowNine)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowEleven)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTwelve)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowThirteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFourteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFifteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSixteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSeventeen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowEighteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowNineteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowT)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTOne)
                    keyboard[id].Led.Color = Color.Green;
            }
            else if (percentage >= 84 && percentage < 88)
            {

                foreach (CorsairKeyboardKeyId id in rowOne)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTwo)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowThree)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFour)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFive)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSix)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSeven)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowEight)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowNine)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowEleven)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTwelve)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowThirteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFourteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFifteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSixteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSeventeen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowEighteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowNineteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowT)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTOne)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTTwo)
                    keyboard[id].Led.Color = Color.Green;
            }
            else if (percentage >= 88 && percentage < 92)
            {

                foreach (CorsairKeyboardKeyId id in rowOne)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTwo)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowThree)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFour)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFive)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSix)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSeven)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowEight)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowNine)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowEleven)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTwelve)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowThirteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFourteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFifteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSixteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSeventeen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowEighteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowNineteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowT)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTOne)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTTwo)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTThree)
                    keyboard[id].Led.Color = Color.Green;
            }
            else if(percentage >= 92)
            {

                foreach (CorsairKeyboardKeyId id in rowOne)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTwo)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowThree)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFour)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFive)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSix)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSeven)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowEight)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowNine)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowEleven)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTwelve)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowThirteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFourteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowFifteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSixteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowSeventeen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowEighteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowNineteen)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowT)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTOne)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTTwo)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTThree)
                    keyboard[id].Led.Color = Color.Green;
                foreach (CorsairKeyboardKeyId id in rowTFour)
                    keyboard[id].Led.Color = Color.Green;
            }



            

           // Console.WriteLine("Coloring Keyboard");
            keyboard.UpdateLeds();        
        }


    }
}
