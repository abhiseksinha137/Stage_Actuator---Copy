using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stage_Actuator
{
    public partial class formBaudrate : Form
    {
        public formBaudrate()
        {
            InitializeComponent();
        }

        public int Baudrate = 0;
        private void formBaudrate_Load(object sender, EventArgs e)
        {
            int[] baudrates = new int[] { 4800, 9600, 14400, 19200, 38400, 57600, 115200, 128000, 256000 };
            foreach (int br in baudrates)
            {
                comboBox1.Items.Add(br.ToString());
            }
        }
    }
}
