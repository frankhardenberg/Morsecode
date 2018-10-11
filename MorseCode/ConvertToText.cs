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
    public partial class ConvertToText : Form
    {
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
        Dictionary<string, Char> text = ToMorse.ToDictionary(e => e.Value, e => e.Key);

        public ConvertToText()
        {
            InitializeComponent();
        }        

        private void Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConvertText_Click(object sender, EventArgs e)
        {

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
