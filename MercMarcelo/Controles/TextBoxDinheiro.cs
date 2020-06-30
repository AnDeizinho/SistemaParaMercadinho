using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
namespace MercMarcelo.Controles
{
    public partial class TextBoxDinheiro : TextBox
    {
        string texto ="";
        public new string Text { get { return texto; } set { texto = value; } }
        public TextBoxDinheiro()
        {
            InitializeComponent();

            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
            
               
        }
        
    }
}
