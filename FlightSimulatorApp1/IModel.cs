using System;
using System.Collections.Generic;
using System.Text;

namespace FlightSimulatorApp1
{
    interface IModel : INotifyPropertyChanged
    {
        //DASHBOARD-לוח מחוונים
        void connect(string ip, int port);
        void disconnect();
        void start();
        double indicatedHeadingDeg { set; get; }
        double gpsIndicatedVerticalSpeed { set; get; }
        double gpsIndicatedGroundSpeed { set; get; }
        double airspeedIndicatorIndicatedSpeed { set; get; }
        double gpsIndicatedAltitude { get; set; }
        double attitudeIndicatorInternalRollDeg { get; set; }
        double attitudeIndicatorInternalpitchDeg { get; set; }
        double altimeterIndicatedAltitude { get; set; }
        //for joistick- לוח ההגאים
        double rudder { get; set; }
        double elevator { get; set; }

        //sliders
        double aileron { get; set; }
        double throttle { get; set; }
    }
}
