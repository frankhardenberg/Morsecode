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
    public partial class ConvertToText : Form
    {
        string InputString = string.Empty;
        List<char> MorseInput = new List<char>();
        static Dictionary<string, char> ToMorse = new Dictionary<string, char>()
        {
            {"._",'A'},
            {"_...",'B'},
            {"_._.",'C'},
            {"_..",'D'},
            {".",'E'},
            {".._.",'F'},
            {"__.",'G'},
            {"....",'H'},
            {"..",'I'},
            {".___",'J'},
            {"_._",'K'},
            {"._..",'L'},
            {"__",'M'},
            {"_.",'N'},
            {"___",'O'},
            {".__.",'P'},
            {"__._",'Q'},
            {"._.",'R'},
            {"...",'S'},
            {"_",'T'},
            {".._",'U'},
            {"..._",'V'},
            {".__",'W'},
            {"_.._",'X'},
            {"_.__",'Y'},
            {"__..",'Z'},
            {"_____",'0'},
            {".____",'1'},
            {"..___",'2'},
            {"...__",'3'},
            {"...._",'4'},
            {".....",'5'},
            {"_....",'6'},
            {"__...",'7'},
            {"___..",'8'},
            {"____.",'9'},
            {"._._._",'.'},
            {"__..__",','},
            {"..__..",'?'},
            {"_._.__",'!'},
            {"_...._",'-'},
            {"_.._.",'/'},
            {"___...",':'},
            {".____.",'\''},
            {"_.__._",'}'},
            {"_._._",';'},
            {"_.__.",'{'},
            {"_..._",'='},
            {".__._.",'@'},
            {"._...",'&'},
            {"/", ' '}
        };
        string TextResult = string.Empty;

        public ConvertToText()
        {
            InitializeComponent();                  
        }

        private char ConvToText(string Y)
        {
            if (ToMorse.ContainsKey(Y))
            {
                return ToMorse[Y];
            }

            else
            {
                return ' ';
            }
        }        

        private void Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConvertText_Click(object sender, EventArgs e)
        {
            InputString = Input.Text;
            string[] InputArray = InputString.Split(' ');

            foreach (string Word in InputArray)
            {
                TextResult += ConvToText(Word);
            }

            Output.Text = TextResult;
            ConvertText.Enabled = false;
        }

        private void Output_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConvertToText_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Input.Text = string.Empty;
            Output.Text = string.Empty;
            InputString = string.Empty;
            TextResult = string.Empty;
            ConvertText.Enabled = true;
        }
    }
}
