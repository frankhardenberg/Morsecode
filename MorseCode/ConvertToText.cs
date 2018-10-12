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
            {". _", 'A'},
            {"_ . . .", 'B'},
            {"_ . _ .", 'C'},
            {"_ . .", 'D'},
            {".", 'E'},
            {". . _ .", 'F'},
            {"_ _ .", 'G'},
            {". . . .", 'H'},
            {". .", 'I'},
            {". _ _ _", 'J'},
            {"_ . _", 'K'},
            {". _ . .", 'L'},
            {"_ _", 'M'},
            {"_ .", 'N'},
            {"_ _ _", 'O'},
            {". _ _ .", 'P'},
            {"_ _ . _", 'Q'},
            {". _ .", 'R'},
            {". . .", 'S'},
            {"_", 'T'},
            {". . _", 'U'},
            {". . . _", 'V'},
            {". _ _", 'W'},
            {"_ . . _", 'X'},
            {"_ . _ _", 'Y'},
            {"_ _ . .", 'Z'},
            {"_ _ _ _ _", '0'},
            {". _ _ _ _", '1'},
            {". . _ _ _", '2'},
            {". . . _ _", '3'},
            {". . . . _", '4'},
            {". . . . .", '5'},
            {"_ . . . .", '6'},
            {"_ _ . . .", '7'},
            {"_ _ _ . .", '8'},
            {"_ _ _ _ .", '9'},
            {". _ . _ . _", '.'},
            {"_ _ . . _ _", ','},
            {". . _ _ . .", '?'},
            {"_ . _ . _ _", '!'},
            {"_ . . . . _", '-'},
            {"_ . . _ .", '/'},
            {"_ _ _ . . .", ':'},
            {". _ _ _ _ .", '\''},
            {"_ . _ _ . _", '}'},
            {"_ . _ . _", ';'}, 
            {"_ . _ _ .", '{'},
            {"_ . . . _", '='},
            {". _ _ . _ .", '@'},
            {". _ . . .", '&'}
        };
        //Dictionary<string, Char> text = ToMorse.ToDictionary(e => e.Value, e => e.Key);
        string TextResult = string.Empty;

        public ConvertToText()
        {
            InitializeComponent();
        }

        private char ConvToText(string X)
        {
            if (ToMorse.ContainsKey(X))
            {
                return ToMorse[X];
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
            string[] inputArray = InputString.Split(' ');

            foreach (string word in inputArray)
            {
                TextResult += ConvToText(word);
            }

            Output.Text = TextResult;
        }

        private void Output_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConvertToText_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
