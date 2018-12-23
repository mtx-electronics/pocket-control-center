/***************************************************************
 * Name:      AboutForm.cs
 * Purpose:   Code for Pocket Control Center about application form
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
using System.IO;

namespace Pocket_Control_Center
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            string sValue, path;

            path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);

            try 
            {
                StreamReader rFile = new StreamReader(new FileStream(path + "\\Release.txt", FileMode.Open));

                tBoxReleaseInfo.Text = "";
                while ((sValue = rFile.ReadLine()) != null)
                {
                    tBoxReleaseInfo.Text += sValue;
                }

                rFile.Close();
            }
            catch 
            { }
        }
    }
}