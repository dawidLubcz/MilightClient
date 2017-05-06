using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilightCLient
{
    public partial class Form1 : Form
    {
        public int m_iBrightnessVal = 0;

        public Form1()
        {
            InitializeComponent();
            FuncList.Initialize();

            var myControl = new MilightCLient.ColorPicker();
            myControl.Dock = DockStyle.Fill;
            panelWorkArea.Controls.Add(myControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            FuncList.sendTurnOnReq((int)FuncList.eGroup.E_GROUP_ALL);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FuncList.sendTurnOffReq((int)FuncList.eGroup.E_GROUP_ALL);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelWorkArea.Controls.Clear();

            var myControl = new BrightnessForm(this);
            myControl.Dock = DockStyle.Fill;
            panelWorkArea.Controls.Add(myControl);
        }

        private void menuColor_Click(object sender, EventArgs e)
        {
            panelWorkArea.Controls.Clear();

            var myControl = new MilightCLient.ColorPicker();
            myControl.Dock = DockStyle.Fill;
            panelWorkArea.Controls.Add(myControl);
        }

        private void menuWheather_Click(object sender, EventArgs e)
        {
            panelWorkArea.Controls.Clear();
        }
    }

    public class FuncList
    {
        /////////////////////////////////////
        /// \brief The eColors enum
        ///
        public enum eColours
        {
            E_COLOUR_MIN = 0x00,
            E_COLOUR_VIOLET = 0x00, // Violet
            E_COLOUR_R_BLUE = 0x10, // Royal_Blue
            E_COLOUR_B_BLUE = 0x20, // Baby_Blue
            E_COLOUR_AQUA = 0x30, // Aqua
            E_COLOUR_MINT = 0x40, // Mint
            E_COLOUR_S_GREEN = 0x50, // Seafoam_Green
            E_COLOUR_GREEN = 0x60, //Green
            E_COLOUR_L_GREEN = 0x70, // Lime_Green
            E_COLOUR_YELLOW = 0x80, //Yellow
            E_COLOUR_Y_ORANGE = 0x90, // Yellow_Orange
            E_COLOUR_ORANGE = 0xA0, // Orange
            E_COLOUR_RED = 0xB0, //Red
            E_COLOUR_PINK = 0xC0, // Pink
            E_COLOUR_FUSIA = 0xD0, // Fusia
            E_COLOUR_LILAC = 0xE0, // Lilac
            E_COLOUR_LAVENDAR = 0xF0, // Lavendar
            E_COLOUR_MAX = 0xFF,
        };

        ////////////////////////////////////
        /// \brief The eGroup enum
        ///
        public enum eGroup
        {
            E_GROUP_ALL = 0,
            E_GROUP_1 = 1,
            E_GROUP_2 = 2,
            E_GROUP_3 = 3,
            E_GROUP_4 = 4,
            E_GROUP_MAX = 4
        };


        [DllImport("MilightDLL.dll", EntryPoint = "turnOn", CallingConvention = CallingConvention.StdCall)]
        public static extern bool sendTurnOnReq(int group);

        [DllImport("MilightDLL.dll", EntryPoint = "turnOff", CallingConvention = CallingConvention.StdCall)]
        public static extern bool sendTurnOffReq(int group);

        [DllImport("MilightDLL.dll", EntryPoint = "Initialize", CallingConvention = CallingConvention.StdCall)]
        public static extern bool Initialize();

        [DllImport("MilightDLL.dll", EntryPoint = "setWhite", CallingConvention = CallingConvention.StdCall)]
        public static extern bool setWhite(int group);

        [DllImport("MilightDLL.dll", EntryPoint = "setBrightness", CallingConvention = CallingConvention.StdCall)]
        public static extern bool setBrightness(int group, int proc);

        [DllImport("MilightDLL.dll", EntryPoint = "setColor", CallingConvention = CallingConvention.StdCall)]
        public static extern bool setColor(int group, int color);
    }
}


