using System;
using System.Collections;
using System.Threading;
using Gadgeteer.Interfaces;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using Microsoft.SPOT.Presentation;
using Microsoft.SPOT.Presentation.Controls;
using Microsoft.SPOT.Presentation.Media;
using Microsoft.SPOT.Touch;

using Gadgeteer.Networking;
using GT = Gadgeteer;
using GTM = Gadgeteer.Modules;
using Gadgeteer.Modules.GHIElectronics;

namespace TripWireTester
{
    public partial class Program
    {
        public static GT.Interfaces.DigitalInput P1;
        public static GT.Interfaces.DigitalInput P2;
        public static GT.Interfaces.DigitalInput P3;
        public static GT.Interfaces.DigitalInput P4;
        public static GT.Interfaces.DigitalInput P5;
        public static GT.Interfaces.DigitalInput P6;
        public static GT.Interfaces.DigitalInput P7;

        // This method is run when the mainboard is powered up or reset.   
        void ProgramStarted()
        {           
            Debug.Print("Program Started");

            P1 = extender.SetupDigitalInput(GT.Socket.Pin.Three, GlitchFilterMode.Off, ResistorMode.Disabled);
            P2 = extender.SetupDigitalInput(GT.Socket.Pin.Four, GlitchFilterMode.Off, ResistorMode.Disabled);
            P3 = extender.SetupDigitalInput(GT.Socket.Pin.Five, GlitchFilterMode.Off, ResistorMode.Disabled);
            P4 = extender.SetupDigitalInput(GT.Socket.Pin.Six, GlitchFilterMode.Off, ResistorMode.Disabled);
            P5 = extender.SetupDigitalInput(GT.Socket.Pin.Seven, GlitchFilterMode.Off, ResistorMode.Disabled);
            P6 = extender.SetupDigitalInput(GT.Socket.Pin.Eight, GlitchFilterMode.Off, ResistorMode.Disabled);
            P7 = extender.SetupDigitalInput(GT.Socket.Pin.Nine, GlitchFilterMode.Off, ResistorMode.Disabled);

            var timer = new GT.Timer(250);
            timer.Tick += timer1 =>
                {
                    var p = "";
                    if (!P1.Read()) Debug.Print( "P1");
                    if (!P2.Read())  Debug.Print( "P2");
                    if (!P3.Read())  Debug.Print( "P3");
                    if (!P4.Read())  Debug.Print( "P4");
                    if (!P5.Read())  Debug.Print( "P5");
                    if (!P6.Read())  Debug.Print( "P6");
                    if (!P7.Read())  Debug.Print( "P7");

                    Debug.Print(p);
                };
            timer.Start();
        }
    }
}
