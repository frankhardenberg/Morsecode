﻿using System;
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
    public partial class ConvertToMorse : Form
    {
        string InputString = string.Empty;
        List<char> TextInput = new List<char>();
        static Dictionary<char, string> ToMorse = new Dictionary<char, string>()
        {
            {'A', ". _"},
            {'B', "_ . . ."},
            {'C', "_ . _ ."},
            {'D', "_ . ."},
            {'E', "."},
            {'F', ". . _ ."},
            {'G', "_ _ ."},
            {'H', ". . . ."},
            {'I', ". ."},
            {'J', ". _ _ _"},
            {'K', "_ . _"},
            {'L', ". _ . ."},
            {'M', "_ _"},
            {'N', "_ ."},
            {'O', "_ _ _"},
            {'P', ". _ _ ."},
            {'Q', "_ _ . _"},
            {'R', ". _ ."},
            {'S', ". . ."},
            {'T', "_"},
            {'U', ". . _"},
            {'V', ". . . _"},
            {'W', ". _ _"},
            {'X', "_ . . _"},
            {'Y', "_ . _ _"},
            {'Z', "_ _ . ."},
            {'0', "_ _ _ _ _"},
            {'1', ". _ _ _ _"},
            {'2', ". . _ _ _"},
            {'3', ". . . _ _"},
            {'4', ". . . . _"},
            {'5', ". . . . ."},
            {'6', "_ . . . ."},
            {'7', "_ _ . . ."},
            {'8', "_ _ _ . ."},
            {'9', "_ _ _ _ ."},
            {'.', ". _ . _ . _"},
            {',', "_ _ . . _ _"},
            {'?', ". . _ _ . ."},
            {'!', "_ . _ . _ _"},
            {'-', "_ . . . . _"},
            {'/', "_ . . _ ."},
            {':', "_ _ _ . . ."},
            {'\'', ". _ _ _ _ ."},
            {'}', "_ . _ _ . _"},
            {';', "_ . _ . _"},
            {'{', "_ . _ _ ."},
            {'=', "_ . . . _"},
            {'@', ". _ _ . _ ."},
            {'&', ". _ . . ."}
        };
        public static string MorseResult;

        public ConvertToMorse()
        {
            InitializeComponent();
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {

        }

        public void ConvertText_Click(object sender, EventArgs e)
        {
            InputString = Input.Text;
            InputString = InputString.ToUpper();
            char[] UserInput = InputString.ToCharArray();

            foreach (char Character in UserInput)
            {
                MorseResult += ConvToMorse(Character);               
            }

            Output.Text = MorseResult;
            ConvertText.Enabled = false;
        }

        private string ConvToMorse(char X)
        {
            if (ToMorse.ContainsKey(X))
            {
                return ToMorse[X];                
            }

            else
            {
                return "";
            }             
        }

        private void Output_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConvertToMorse_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Input.Text = string.Empty;
            Output.Text = string.Empty;
            InputString = string.Empty;
            MorseResult = string.Empty;
            ConvertText.Enabled = true;
        }
    }
}
