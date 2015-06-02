using System;
using System.Collections;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Presentation;
using Microsoft.SPOT.Presentation.Controls;
using Microsoft.SPOT.Presentation.Media;
using Microsoft.SPOT.Presentation.Shapes;
using Microsoft.SPOT.Touch;

using Gadgeteer.Networking;
using GT = Gadgeteer;
using GTM = Gadgeteer.Modules;
using Gadgeteer.Modules.GHIElectronics;

namespace TripWireModule_Tester
{
    public partial class Program
    {
        // This method is run when the mainboard is powered up or reset.   
        void ProgramStarted()
        {
            /*******************************************************************************************
            Modules added in the Program.gadgeteer designer view are used by typing 
            their name followed by a period, e.g.  button.  or  camera.
            
            Many modules generate useful events. Type +=<tab><tab> to add a handler to an event, e.g.:
                button.ButtonPressed +=<tab><tab>
            
            If you want to do something periodically, use a GT.Timer and handle its Tick event, e.g.:
                GT.Timer timer = new GT.Timer(1000); // every second (1000ms)
                timer.Tick +=<tab><tab>
                timer.Start();
            *******************************************************************************************/


            // Use Debug.Print to show messages in Visual Studio's "Output" window during debugging.
            Debug.Print("Program Started");

            var timer = new GT.Timer(250);
            timer.Tick += timer1 =>
            {
                if (!tripWire.TripWire1.Read()) Debug.Print("TripWire1");
                if (!tripWire.TripWire2.Read()) Debug.Print("TripWire2");
                if (!tripWire.TripWire3.Read()) Debug.Print("TripWire3");
                if (!tripWire.TripWire4.Read()) Debug.Print("TripWire4");
                if (!tripWire.TripWire5.Read()) Debug.Print("TripWire5");
                if (!tripWire.TripWire6.Read()) Debug.Print("TripWire6");
                if (!tripWire.TripWire7.Read()) Debug.Print("TripWire7");
            };
            timer.Start();
        }
    }
}
