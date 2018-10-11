using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseCode
{
    public partial class Morsecode : Form
    {
        public Morsecode()
        {
            InitializeComponent();
        }

        private void ConvertToMorse_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConvertToMorse Form = new ConvertToMorse();
            Form.ShowDialog();
        }

        private void ConvertToText_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConvertToText Form = new ConvertToText();
            Form.ShowDialog();
        }
    }
}
