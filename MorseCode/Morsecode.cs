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
            ConvertToMorse Morse = new ConvertToMorse();
            Morse.ShowDialog();
        }

        private void ConvertToText_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConvertToText Text = new ConvertToText();            
            Text.ShowDialog();            
        }

        private void Morsecode_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
