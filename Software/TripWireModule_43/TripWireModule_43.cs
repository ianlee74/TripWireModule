﻿using System;
using Microsoft.SPOT;

using GT = Gadgeteer;
using GTM = Gadgeteer.Modules;
using GTI = Gadgeteer.SocketInterfaces;

namespace Gadgeteer.Modules.IanLee
{
    /// <summary>
    /// A TripWireModule module for Microsoft .NET Gadgeteer
    /// </summary>
    public class TripWireModule : GTM.Module
    {
        private Socket socketA;
        private Socket socketB;

        // This example implements a driver in managed code for a simple Gadgeteer module.  This module uses a 
        // single GTI.InterruptInput to interact with a button that can be in either of two states: pressed or released.
        // The example code shows the recommended code pattern for exposing a property (IsPressed). 
        // The example also uses the recommended code pattern for exposing two events: Pressed and Released. 
        // The triple-slash "///" comments shown will be used in the build process to create an XML file named
        // GTM.IanLee.TripWireModule. This file will provide IntelliSense and documentation for the
        // interface and make it easier for developers to use the TripWireModule module.        

        // -- CHANGE FOR MICRO FRAMEWORK 4.2 and higher --
        // If you want to use Serial, SPI, or DaisyLink (which includes GTI.SoftwareI2C), you must do a few more steps
        // since these have been moved to separate assemblies for NETMF 4.2 (to reduce the minimum memory footprint of Gadgeteer)
        // 1) add a reference to the assembly (named Gadgeteer.[interfacename])
        // 2) in GadgeteerHardware.xml, uncomment the lines under <Assemblies> so that end user apps using this module also add a reference.

        public Gadgeteer.SocketInterfaces.DigitalInput TripWire1;
        public Gadgeteer.SocketInterfaces.DigitalInput TripWire2;
        public Gadgeteer.SocketInterfaces.DigitalInput TripWire3;
        public Gadgeteer.SocketInterfaces.DigitalInput TripWire4;
        public Gadgeteer.SocketInterfaces.DigitalInput TripWire5;
        public Gadgeteer.SocketInterfaces.DigitalInput TripWire6;
        public Gadgeteer.SocketInterfaces.DigitalInput TripWire7;

        // Note: A constructor summary is auto-generated by the doc builder.
        /// <summary></summary>
        /// <param name="socketNumber">The socket that this module is plugged in to.</param>
        /// <param name="socketNumberTwo">The second socket that this module is plugged in to.</param>
        public TripWireModule(int socketNumber)
        {
            // This finds the Socket instance from the user-specified socket number.  
            // This will generate user-friendly error messages if the socket is invalid.
            // If there is more than one socket on this module, then instead of "null" for the last parameter, 
            // put text that identifies the socket to the user (e.g. "S" if there is a socket type S)
            this.socketA = Socket.GetSocket(socketNumber, true, this, null);

            this.socketB = Socket.SocketInterfaces.CreateUnnumberedSocket(socketNumber.ToString() + "-" + " Extender");
            this.socketB.SupportedTypes = this.socketA.SupportedTypes;

            for (int i = 3; i < 10; i++)
                this.socketB.CpuPins[i] = this.socketA.CpuPins[i];

            this.socketB.SerialPortName = this.socketA.SerialPortName;
            this.socketB.SPIModule = this.socketA.SPIModule;
            this.socketB.AnalogOutput5 = this.socketA.AnalogOutput5;
            this.socketB.AnalogInput3 = this.socketA.AnalogInput3;
            this.socketB.AnalogInput4 = this.socketA.AnalogInput4;
            this.socketB.AnalogInput5 = this.socketA.AnalogInput5;
            this.socketB.PWM7 = this.socketA.PWM7;
            this.socketB.PWM8 = this.socketA.PWM8;
            this.socketB.PWM9 = this.socketA.PWM9;
            this.socketB.AnalogInputIndirector = this.socketA.AnalogInputIndirector;
            this.socketB.AnalogOutputIndirector = this.socketA.AnalogOutputIndirector;
            this.socketB.DigitalInputIndirector = this.socketA.DigitalInputIndirector;
            this.socketB.DigitalIOIndirector = this.socketA.DigitalIOIndirector;
            this.socketB.DigitalOutputIndirector = this.socketA.DigitalOutputIndirector;
            this.socketB.I2CBusIndirector = this.socketA.I2CBusIndirector;
            this.socketB.InterruptIndirector = this.socketA.InterruptIndirector;
            this.socketB.PwmOutputIndirector = this.socketA.PwmOutputIndirector;
            this.socketB.SpiIndirector = this.socketA.SpiIndirector;
            this.socketB.SerialIndirector = this.socketA.SerialIndirector;

            TripWire1 = GTI.DigitalInputFactory.Create(socketA, Socket.Pin.Three, GTI.GlitchFilterMode.Off, GTI.ResistorMode.Disabled, this);
            TripWire2 = GTI.DigitalInputFactory.Create(socketA, Socket.Pin.Four, GTI.GlitchFilterMode.Off, GTI.ResistorMode.Disabled, this);
            TripWire3 = GTI.DigitalInputFactory.Create(socketA, Socket.Pin.Five, GTI.GlitchFilterMode.Off, GTI.ResistorMode.Disabled, this);
            TripWire4 = GTI.DigitalInputFactory.Create(socketA, Socket.Pin.Six, GTI.GlitchFilterMode.Off, GTI.ResistorMode.Disabled, this);
            TripWire5 = GTI.DigitalInputFactory.Create(socketA, Socket.Pin.Seven, GTI.GlitchFilterMode.Off, GTI.ResistorMode.Disabled, this);
            TripWire6 = GTI.DigitalInputFactory.Create(socketA, Socket.Pin.Eight, GTI.GlitchFilterMode.Off, GTI.ResistorMode.Disabled, this);
            TripWire7 = GTI.DigitalInputFactory.Create(socketA, Socket.Pin.Nine, GTI.GlitchFilterMode.Off, GTI.ResistorMode.Disabled, this);
        }
    }
}
