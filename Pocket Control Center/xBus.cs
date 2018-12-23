/***************************************************************
 * Name:      xBus.cs
 * Purpose:   Code for Pocket Control Center xBus handling routines
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

namespace Pocket_Control_Center
{
    class xBus
    {
        private SerialAccess sCon = new SerialAccess();
        public byte[] packetData = new byte[256];

		public void CloseDevice()
		{
            if (sCon.connected)
                sCon.ClosePort();
		}
    			
        public Boolean FindDevice(string portName)
        {
            bool found=false;

            if (portName=="Auto")
            {
                for (int loop = 0; loop < sCon.availablePorts.Length; loop++)
                {
                    sCon.OpenPort(sCon.availablePorts[loop]);
                    if (sCon.connected)
                    {
                        WritePacket(0, 0x01, 0);  //ALive
                        if (ReadPacket()==0)
                        {
                            found = true;
                            break;
                        }
                        sCon.ClosePort();
                    }
                }
            }
            else
            {
                sCon.OpenPort(portName);
                if (sCon.connected)
                {
                    WritePacket(0, 0x01, 0);  //ALive
                    if (ReadPacket()==0)
                        found = true;
                    else
                        sCon.ClosePort();
                }
            }

            return(found);
        }
        
        public int ReadPacket()
        {
            byte crc=0;
            int loop;
            byte[] headerData = new byte[4];
            UInt16 timeout = 65535;

            while (sCon.BytesAvailable() < 4)
            {
                timeout--;
                if (timeout == 0)
                    return (3);
            }

            if (sCon.ReadData(ref headerData, 4) < 4)
                return(2);

            for (loop=0; loop < 3; loop++)
                crc=AddByte(crc, headerData[loop]);

            if (crc != headerData[3])
                return(1);

            if (headerData[2] > 0)
            {
                timeout = 65535;
                while (sCon.BytesAvailable() != (headerData[2]+1))
                {
                    timeout--;
                    if (timeout == 0)
                        return (3);
                }

                if (sCon.ReadData(ref packetData, headerData[2]+1) != (headerData[2]+1))
                    return(2);

                crc=0;
                for (loop=0; loop < (int)headerData[2]; loop++)
                  crc=AddByte(crc, packetData[loop]);

                // Check possible packet CRC Error
                if (crc != packetData[loop])
                  return(1);
            }

            return(0);
        }

		public void WritePacket(byte type, byte flags, byte dataLength)
        {
            byte crc=0;
            byte[] headerData = new byte[4];

            crc = AddByte(crc, type);
            crc = AddByte(crc, flags);
            crc = AddByte(crc, dataLength);

            headerData[0]=type;
            headerData[1]=flags;
            headerData[2]=dataLength;
            headerData[3]=crc;
            sCon.WriteData(headerData,4);

            if (dataLength > 0)
            {
                crc=0;
                for (int x=0; x < dataLength; x++)
                  crc= AddByte(crc, packetData[x]);

                packetData[dataLength]=crc;
                sCon.WriteData(packetData,dataLength+1);
            }       	
        }

        private byte AddByte(byte crc, byte bValue)
        {
            int newCrc;

            newCrc = crc + bValue;
            if (newCrc > 255) newCrc -= 255;

            return ((byte)newCrc);
        }
    }
}
