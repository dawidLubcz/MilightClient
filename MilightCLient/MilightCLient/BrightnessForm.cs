using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MilightCLient
{
    public partial class BrightnessForm : UserControl
    {
        private bool m_fIsWorking = false;
        private Form1 m_oMainWindow;

        public BrightnessForm(Form1 mainCOntext)
        {
            InitializeComponent();

            m_oMainWindow = mainCOntext;

            hScrollBar1.Value = m_oMainWindow.m_iBrightnessVal;
            label1.Text = string.Format("Value: {0}", hScrollBar1.Value);
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            if (m_fIsWorking == false)
            {
                new Thread(() =>
                {
                    m_fIsWorking = true;
                    Thread.Sleep(1000);
                    FuncList.setBrightness(
                        (int)FuncList.eGroup.E_GROUP_ALL, 
                        hScrollBar1.Value);

                    this.label1.Invoke((MethodInvoker)delegate {
                        this.label1.Text = string.Format("Value: {0}", hScrollBar1.Value);
                    });
                    m_oMainWindow.m_iBrightnessVal = hScrollBar1.Value;

                    m_fIsWorking = false;
                }).Start();                
            }

        }

        private void hScrollBar1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
