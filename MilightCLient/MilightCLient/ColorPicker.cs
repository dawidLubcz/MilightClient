using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilightCLient
{
    public partial class ColorPicker : UserControl
    {
        public ColorPicker()
        {
            InitializeComponent();
        }

        public ColorPicker(int X, int Y)
        {
            this.Width = X;
            this.Height = Y;
            InitializeComponent();

        }

        private void buttonViolet_Click(object sender, EventArgs e)
        {
            FuncList.setColor(
                (int)FuncList.eGroup.E_GROUP_ALL, 
                (int)FuncList.eColours.E_COLOUR_VIOLET);
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            FuncList.setColor(
                (int)FuncList.eGroup.E_GROUP_ALL,
                (int)FuncList.eColours.E_COLOUR_YELLOW);
        }

        private void buttonYOrange_Click(object sender, EventArgs e)
        {
            FuncList.setColor(
                (int)FuncList.eGroup.E_GROUP_ALL,
                (int)FuncList.eColours.E_COLOUR_Y_ORANGE);
        }

        private void buttonRBlue_Click(object sender, EventArgs e)
        {
            FuncList.setColor(
                (int)FuncList.eGroup.E_GROUP_ALL,
                (int)FuncList.eColours.E_COLOUR_R_BLUE);
        }

        private void buttonBBlue_Click(object sender, EventArgs e)
        {
            FuncList.setColor(
                (int)FuncList.eGroup.E_GROUP_ALL,
                (int)FuncList.eColours.E_COLOUR_B_BLUE);
        }

        private void buttonOrange_Click(object sender, EventArgs e)
        {
            FuncList.setColor(
                (int)FuncList.eGroup.E_GROUP_ALL,
                (int)FuncList.eColours.E_COLOUR_ORANGE);
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            FuncList.setColor(
                (int)FuncList.eGroup.E_GROUP_ALL,
                (int)FuncList.eColours.E_COLOUR_RED);
        }

        private void buttonAqua_Click(object sender, EventArgs e)
        {
            FuncList.setColor(
                (int)FuncList.eGroup.E_GROUP_ALL,
                (int)FuncList.eColours.E_COLOUR_AQUA);
        }

        private void buttonMint_Click(object sender, EventArgs e)
        {
            FuncList.setColor(
                (int)FuncList.eGroup.E_GROUP_ALL,
                (int)FuncList.eColours.E_COLOUR_MINT);
        }

        private void buttonPink_Click(object sender, EventArgs e)
        {
            FuncList.setColor(
                (int)FuncList.eGroup.E_GROUP_ALL,
                (int)FuncList.eColours.E_COLOUR_PINK);
        }

        private void buttonFusia_Click(object sender, EventArgs e)
        {
            FuncList.setColor(
                (int)FuncList.eGroup.E_GROUP_ALL,
                (int)FuncList.eColours.E_COLOUR_FUSIA);
        }

        private void buttonSeaGreen_Click(object sender, EventArgs e)
        {
            FuncList.setColor(
                (int)FuncList.eGroup.E_GROUP_ALL,
                (int)FuncList.eColours.E_COLOUR_S_GREEN);
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            FuncList.setColor(
                (int)FuncList.eGroup.E_GROUP_ALL,
                (int)FuncList.eColours.E_COLOUR_GREEN);
        }

        private void buttonLimeGreen_Click(object sender, EventArgs e)
        {
            FuncList.setColor(
                (int)FuncList.eGroup.E_GROUP_ALL,
                (int)FuncList.eColours.E_COLOUR_L_GREEN);
        }

        private void buttonLavender_Click(object sender, EventArgs e)
        {
            FuncList.setColor(
                (int)FuncList.eGroup.E_GROUP_ALL,
                (int)FuncList.eColours.E_COLOUR_LAVENDAR);
        }

        private void buttonLilac_Click(object sender, EventArgs e)
        {
            FuncList.setColor(
                (int)FuncList.eGroup.E_GROUP_ALL,
                (int)FuncList.eColours.E_COLOUR_LILAC);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FuncList.setWhite((int)FuncList.eGroup.E_GROUP_ALL);
        }
    }
}
