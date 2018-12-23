/***************************************************************
 * Name:      MainForm.cs
 * Purpose:   Code for Pocket Control Center main application form
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace Pocket_Control_Center
{
    public partial class MainForm : Form
    { 
        private xBus mtxDevice = new xBus();
        private string portName="Auto";
        private Boolean connectionStatus=false;

        private int threshold1=0, power1=0, slopeThreshold1=0, slopePower1=0, ramp1=0,
                    threshold2=0, power2=0, slopeThreshold2=0, slopePower2=0, ramp2=0,
                    mapMode=1, trimmerEnabled=0, boxEnabled=0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Add automatic option
            AddMenuItem(portName);
            menuItemSelectPort.MenuItems[0].Checked = true;

            // Add all serial ports found on device
            foreach (string sValue in SerialPort.GetPortNames())
                AddMenuItem(sValue);
        }

        private void AddMenuItem(string menuName)
        {
            try
            {
                MenuItem portMenuItem = new MenuItem();
                portMenuItem.Text = menuName;
                portMenuItem.Click += new EventHandler(menuSerialPortCOM_Click);                   
                menuItemSelectPort.MenuItems.Add(portMenuItem);
            }
            catch
            { }
        }

        // Slider Events ------------------------------------------------------

        private void tBarThreshold_ValueChanged(object sender, EventArgs e)
        {
            if (mapMode == 1)
                threshold1 = tBarThreshold.Value;
            else
                threshold2 = tBarThreshold.Value;

            tBoxThreshold.Text = Convert.ToString(tBarThreshold.Value * 0.00122, System.Globalization.CultureInfo.InvariantCulture) + "V";
        }

        private void tBarPower_ValueChanged(object sender, EventArgs e)
        {
            if (mapMode == 1)
                power1 = tBarPower.Value;
            else
                power2 = tBarPower.Value;

            double dValue = (double)tBarPower.Value / 4095 * 100;

            tBoxPower.Text = Convert.ToString(dValue, System.Globalization.CultureInfo.InvariantCulture) + "%";
        }

        private void tBarSlopeThreshold_ValueChanged(object sender, EventArgs e)
        {
            if (mapMode == 1)
                slopeThreshold1 = tBarSlopeThreshold.Value;
            else
                slopeThreshold2 = tBarSlopeThreshold.Value;
            
            tBoxSlopeThreshold.Text = Convert.ToString(tBarSlopeThreshold.Value * 0.00122, System.Globalization.CultureInfo.InvariantCulture) + "V";
        }

        private void tBarSlopePower_ValueChanged(object sender, EventArgs e)
        {
            if (mapMode == 1)
                slopePower1 = tBarSlopePower.Value;
            else
                slopePower2 = tBarSlopePower.Value;

            double dValue = (double)tBarSlopePower.Value / 4095 * 100;

            tBoxSlopePower.Text = Convert.ToString(dValue, System.Globalization.CultureInfo.InvariantCulture) + "%";
        }

        private void tBarRamp_ValueChanged(object sender, EventArgs e)
        {
            if (mapMode == 1)
                ramp1 = tBarRamp.Value;
            else
                ramp2 = tBarRamp.Value;

            tBoxRamp.Text = Convert.ToString(tBarRamp.Value * 0.00122, System.Globalization.CultureInfo.InvariantCulture) + "V";
        }

        // Menu Events --------------------------------------------------------

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            // TODO: Read from file
            MessageBox.Show("Function not implemented.", "PocketCC");

        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            // TODO: Write to file
            MessageBox.Show("Function not implemented.", "PocketCC");
        }

        private void menuSerialPortCOM_Click(object sender, EventArgs e)
        {
            for (int loop = 0; loop < menuItemSelectPort.MenuItems.Count; loop++)
                menuItemSelectPort.MenuItems[loop].Checked = false;

            MenuItem comItem = (MenuItem)sender;

            portName = comItem.Text;
            statusBar.Text="Port '" + portName + "' selected.";
            comItem.Checked = true;
        }

        private void menuItemConnect_Click(object sender, EventArgs e)
        {
            if (!mtxDevice.FindDevice(portName))
            {
                statusBar.Text="No device found!";
                connectionStatus=false;
            }
            else
            {
                // Get device serial number
                mtxDevice.WritePacket(5,0x01,0);
                if (mtxDevice.ReadPacket()==0)
                {
                    System.Text.Encoding encodeBytes = System.Text.Encoding.ASCII;
                    string sValue = encodeBytes.GetString(mtxDevice.packetData,0,8);

                    statusBar.Text = "Connected with S/N:" + sValue;
                    connectionStatus=true;
                }
                else
                {
                    mtxDevice.CloseDevice();
                    statusBar.Text="Device read S/N error!";
                    connectionStatus=false;
                }
            }
        }

        private void menuItemDisconnect_Click(object sender, EventArgs e)
        {
            mtxDevice.CloseDevice();
            statusBar.Text = "Disconnected.";
            connectionStatus = false;
        }

        private void menuItemTransmit_Click(object sender, EventArgs e)
        {
            int msb, lsb;

            if (!connectionStatus)
            {
                statusBar.Text = "Connect to tuning box first.";
                return;
            }

            if (menuItemEnMonitor.Checked)
            {
                statusBar.Text = "Monitor function must be disabled.";
                return;
            }

            statusBar.Text = "Writing map to tuning box...";

            // MAP 1 (Normal)

            // TX threshold
            msb=threshold1 / 256;
            lsb=threshold1 - (msb * 256);
            mtxDevice.packetData[0]=(byte)msb;
            mtxDevice.packetData[1]=(byte)lsb;

            // TX power
            msb=power1 / 256;
            lsb=power1 - (msb * 256);
            mtxDevice.packetData[2]=(byte)msb;
            mtxDevice.packetData[3]=(byte)lsb;

            // TX SogliaSlop
            msb=slopeThreshold1 / 256;
            lsb=slopeThreshold1 - (msb * 256);
            mtxDevice.packetData[4]=(byte)msb;
            mtxDevice.packetData[5]=(byte)lsb;

            // TX Slop Pot
            msb=slopePower1 / 256;
            lsb=slopePower1 - (msb * 256);
            mtxDevice.packetData[6]=(byte)msb;
            mtxDevice.packetData[7]=(byte)lsb;

            // TX Ramp
            msb=ramp1 / 256;
            lsb=ramp1 - (msb * 256);
            mtxDevice.packetData[8]=(byte)msb;
            mtxDevice.packetData[9]=(byte)lsb;

            // Map 2 (FAP)

            // TX threshold
            msb=threshold2 / 256;
            lsb=threshold2 - (msb * 256);
            mtxDevice.packetData[10]=(byte)msb;
            mtxDevice.packetData[11]=(byte)lsb;

            // TX power
            msb=power2 / 256;
            lsb=power2 - (msb * 256);
            mtxDevice.packetData[12]=(byte)msb;
            mtxDevice.packetData[13]=(byte)lsb;

            // TX SogliaSlop
            msb=slopeThreshold2 / 256;
            lsb=slopeThreshold2 - (msb * 256);
            mtxDevice.packetData[14]=(byte)msb;
            mtxDevice.packetData[15]=(byte)lsb;

            // TX Slop Pot
            msb=slopePower2 / 256;
            lsb=slopePower2 - (msb * 256);
            mtxDevice.packetData[16]=(byte)msb;
            mtxDevice.packetData[17]=(byte)lsb;

            // TX Ramp
            msb=ramp2 / 256;
            lsb=ramp2 - (msb * 256);
            mtxDevice.packetData[18]=(byte)msb;
            mtxDevice.packetData[19]=(byte)lsb;

            // Function Mode
            mtxDevice.packetData[20]=(byte)mapMode;

            // Trimmer Mode
            mtxDevice.packetData[21]=(byte)trimmerEnabled;

            // Enable Box
            mtxDevice.packetData[22]=(byte)boxEnabled;

            // Send write data packet
            mtxDevice.WritePacket(128,0x11,23);

            if (mtxDevice.ReadPacket()==0)
                statusBar.Text = "Ready.";
            else
                statusBar.Text = "Error writing map!";
    }

        private void menuItemReceive_Click(object sender, EventArgs e)
        {
            if (!connectionStatus)
            {
                statusBar.Text = "Connect to tuning box first.";
                return;
            }

            if (menuItemEnMonitor.Checked)
            {
                statusBar.Text = "Monitor function must be disabled.";
                return;
            }

                statusBar.Text = "Reading map from tuning box...";

                mtxDevice.WritePacket(128,0x01,0);
                if (mtxDevice.ReadPacket()==0)
                {
                    threshold1=mtxDevice.packetData[0] * 256 + mtxDevice.packetData[1];
                    power1=mtxDevice.packetData[2] * 256 + mtxDevice.packetData[3];
                    slopeThreshold1=mtxDevice.packetData[4] * 256 + mtxDevice.packetData[5];
                    slopePower1=mtxDevice.packetData[6] * 256 + mtxDevice.packetData[7];
                    ramp1=mtxDevice.packetData[8] * 256 + mtxDevice.packetData[9];

                    threshold2=mtxDevice.packetData[10] * 256 + mtxDevice.packetData[11];
                    power2=mtxDevice.packetData[12] * 256 + mtxDevice.packetData[13];
                    slopeThreshold2=mtxDevice.packetData[14] * 256 + mtxDevice.packetData[15];
                    slopePower2=mtxDevice.packetData[16] * 256 + mtxDevice.packetData[17];
                    ramp2=mtxDevice.packetData[18] * 256 + mtxDevice.packetData[19];

                    mapMode=mtxDevice.packetData[20];
                    trimmerEnabled=mtxDevice.packetData[21];
                    boxEnabled=mtxDevice.packetData[22];

                    if (trimmerEnabled != 0)
                        menuItemEnTrimmer.Checked = true;
                    else
                        menuItemEnTrimmer.Checked = false;

                    if (boxEnabled != 0)
                        menuItemEnTuningBox.Checked = true;
                    else
                        menuItemEnTuningBox.Checked = false;

                    if (mapMode == 1)
                    {
                        tBarThreshold.Value = threshold1;
                        tBarPower.Value = power1;
                        tBarSlopeThreshold.Value = slopeThreshold1;
                        tBarSlopePower.Value = slopePower1;
                        tBarRamp.Value = ramp1;

                        menuItemNormalMap.Checked = true;
                        menuItemFAPMap.Checked = false;
                    }
                    else
                    {
                        tBarThreshold.Value = threshold2;
                        tBarPower.Value = power2;
                        tBarSlopeThreshold.Value = slopeThreshold2;
                        tBarSlopePower.Value = slopePower2;
                        tBarRamp.Value = ramp2;

                        menuItemNormalMap.Checked = false;
                        menuItemFAPMap.Checked = true;
                    }

                    statusBar.Text = "Ready.";
                }
                else
                    statusBar.Text = "Error reading map!";
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuItemNormalMap_Click(object sender, EventArgs e)
        {
            mapMode = 1;

            tBarThreshold.Value = threshold1;
            tBarPower.Value = power1;
            tBarSlopeThreshold.Value = slopeThreshold1;
            tBarSlopePower.Value = slopePower1;
            tBarRamp.Value = ramp1;

            statusBar.Text = "Map 1 (Normal)";

            menuItemNormalMap.Checked = true;
            menuItemFAPMap.Checked = false;
        }

        private void menuItemFAPMap_Click(object sender, EventArgs e)
        {
            mapMode = 2; 
            
            tBarThreshold.Value = threshold2;
            tBarPower.Value = power2;
            tBarSlopeThreshold.Value = slopeThreshold2;
            tBarSlopePower.Value = slopePower2;
            tBarRamp.Value = ramp2;

            statusBar.Text = "Map 2 (FAP)";

            menuItemNormalMap.Checked = false;
            menuItemFAPMap.Checked = true;
        }

        private void menuItemEnMonitor_Click(object sender, EventArgs e)
        {
            if (!menuItemEnMonitor.Checked)
            {
                menuItemEnMonitor.Checked = true;
                timerMonitor.Enabled = true;
                statusBar.Text = "Monitor enabled...";
            }
            else
            {
                menuItemEnMonitor.Checked = false;
                timerMonitor.Enabled = false;

                pBarRailIn.Value = 0;
                pBarRailOut.Value = 0;

                labelRailIn.Text="Rail In: 0V";
                labelRailOut.Text = "Rail Out: 0V";

                statusBar.Text = "Monitor disabled.";
            }
        }

        private void menuItemEnTrimmer_Click(object sender, EventArgs e)
        {
            if (!menuItemEnTrimmer.Checked)
            {
                menuItemEnTrimmer.Checked = true;
                trimmerEnabled = 1;
                statusBar.Text = "Trimmer enabled.";
            }
            else
            {
                menuItemEnTrimmer.Checked = false;
                trimmerEnabled = 0;
                statusBar.Text = "Trimmer disbaled.";
            }
        }

        private void menuItemEnTuningBox_Click(object sender, EventArgs e)
        {
            if (!menuItemEnTuningBox.Checked)
            {
                menuItemEnTuningBox.Checked = true;
                boxEnabled = 1;
                statusBar.Text = "Tuning box enabled.";
            }
            else
            {
                menuItemEnTuningBox.Checked = false;
                boxEnabled = 0;
                statusBar.Text = "Tuning box disabled.";
            }
        }

        private void menuItemResetTuningBox_Click(object sender, EventArgs e)
        {
            if (!connectionStatus)
            {
                statusBar.Text = "Connect to tuning box first.";
                return;
            }

            if (menuItemEnMonitor.Checked)
            {
                statusBar.Text = "Monitor function must be disabled.";
                return;
            }

            statusBar.Text = "Resetting tuning box...";

            threshold1=0;
            power1=0;
            slopeThreshold1=0;
            slopePower1=0;
            ramp1=0;

            threshold2=0;
            power2=0;
            slopeThreshold2=0;
            slopePower2=0;
            ramp2=0;

            tBarThreshold.Value = threshold1;
            tBarPower.Value = power1;
            tBarSlopeThreshold.Value = slopeThreshold1;
            tBarSlopePower.Value = slopePower1;
            tBarRamp.Value = ramp1;

            mapMode = 1;
            trimmerEnabled=0;
            boxEnabled=0;

            menuItemEnTrimmer.Checked = false;
            menuItemEnTuningBox.Checked = false;
            menuItemNormalMap.Checked = true;
            menuItemFAPMap.Checked = false;

            menuItemTransmit_Click(this, e);
        }

        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
            about.Dispose();
        }

        // Timer functions ----------------------------------------------------

        private void timerMonitor_Tick(object sender, EventArgs e)
        {
            if (!connectionStatus)
            {
                menuItemEnMonitor.Checked = false;
                timerMonitor.Enabled = false;
                return;
            }

            mtxDevice.WritePacket(129,0x01,0);
            if (mtxDevice.ReadPacket()==0)
            {

                pBarRailIn.Value = mtxDevice.packetData[0] * 256 + mtxDevice.packetData[1];
                pBarRailOut.Value = mtxDevice.packetData[2] * 256 + mtxDevice.packetData[3];

                labelRailIn.Text="Rail In: " +
                    Convert.ToString(pBarRailIn.Value * 0.00122, System.Globalization.CultureInfo.InvariantCulture) + "V";

                labelRailOut.Text = "Rail Out: " +
                    Convert.ToString(pBarRailOut.Value * 0.00122, System.Globalization.CultureInfo.InvariantCulture) + "V";
            }
            else
                statusBar.Text = "Error reading monitor, retrying...";
        }
    }
}