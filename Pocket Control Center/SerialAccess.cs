/***************************************************************
 * Name:      MainForm.cs
 * Purpose:   Code for Pocket Control Center serial port handling routines
 * Author:    Salvatore Faro (info@mtx-electronics.com)
 * Created:   2009-09-26
 * Copyright: MTX Electronics (www.mtx-electronics.com)
 * License:   GNU General Public License (GPL version 2)
 *            http://www.fsf.org/licenses/gpl.html
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 * See the GNU General Public License for more details.
 **************************************************************/

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;

namespace Pocket_Control_Center
{
    class SerialAccess
    {
        public string[] availablePorts = SerialPort.GetPortNames();
        private SerialPort comPort = new SerialPort();
        public Boolean connected = false;

        public void OpenPort(string portName)
        {
            if (comPort.IsOpen) comPort.Close();

            connected = false;

            comPort.BaudRate = 2400;
            comPort.DataBits = 8;
            comPort.StopBits = StopBits.One;
            comPort.Parity = Parity.None;
            comPort.PortName = portName;
            comPort.ReadTimeout = 1000;
            comPort.WriteTimeout = 1000;

            try
            {
                comPort.Open();
                connected = true;
            }
            catch
            { } 
        }

        public void ClosePort()
        {
            comPort.Close();
            connected = false;
        }
        
        public int BytesAvailable()
        {
            if (!connected) return(0);
            return(comPort.BytesToRead);
        }
        
        public int ReadData(ref byte[] data, int length)
        {
            int loop=0;

            try
            {
                for (; loop < length; loop++)
                    data[loop] = (byte)comPort.ReadByte();
            }
            catch
            { }

            return (loop);
        }

        public int WriteData(byte[] data, int length)
        {
            try
            {
                comPort.Write(data, 0, length);
            }
            catch
            { }

            return (length);
        }
    }
}
