using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;

namespace StockMonitoring.Classes
{
    public static class SerialPortSetting
    {

        public static void Close(SerialPort serialPort)
        {
            if (serialPort != null)
            {
                if (serialPort.IsOpen)
                {
                    serialPort.DiscardOutBuffer();
                    serialPort.DiscardInBuffer();
                    serialPort.Close();
                    serialPort = null;
                }
            }
        }
    }
}
