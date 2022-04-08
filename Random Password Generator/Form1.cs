using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

/* Copyright James Hatfield 2016
 * 
 *  Special thanks to PasswordsGenerator.net for inspiration to make this tool. That website also 
 *  has many other helpful online tools; I encourage you to check them out!
 * 
 *  THIS DOCUMENT IS PROVIDED "AS IS," AND COPYRIGHT HOLDERS MAKE NO REPRESENTATIONS OR WARRANTIES, 
 *  EXPRESS OR IMPLIED, INCLUDING, BUT NOT LIMITED TO, WARRANTIES OF MERCHANTABILITY, FITNESS FOR A 
 *  PARTICULAR PURPOSE, NON-INFRINGEMENT, OR TITLE; THAT THE CONTENTS OF THE DOCUMENT ARE SUITABLE 
 *  FOR ANY PURPOSE; NOR THAT THE IMPLEMENTATION OF SUCH CONTENTS WILL NOT INFRINGE ANY THIRD PARTY 
 *  PATENTS, COPYRIGHTS, TRADEMARKS OR OTHER RIGHTS.
 *  
 * COPYRIGHT HOLDERS WILL NOT BE LIABLE FOR ANY DIRECT, INDIRECT, SPECIAL OR CONSEQUENTIAL DAMAGES 
 * ARISING OUT OF ANY USE OF THE DOCUMENT OR THE PERFORMANCE OR IMPLEMENTATION OF THE CONTENTS THEREOF.
 
*/


namespace Random_Password_Generator
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private int getRandomInt()
        {
            using (RNGCryptoServiceProvider rg = new RNGCryptoServiceProvider())
            {
                byte[] rno = new byte[5];
                rg.GetBytes(rno);
                int randomvalue = BitConverter.ToInt32(rno, 0);
                return randomvalue;
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {

            //Define variables
            List<char> legalCharacters = new List<char>(); 
            int i = 0;
            int randomInt;
            int passwordLengthVar = int.Parse(passwordLength.Text);

            //Add legal alphabets
            if (numbersCheckbox.Checked) for (i = 48; i < 58; i++) legalCharacters.Add((char)i);

            if (lowerCaseCheckBox.Checked) for (i = 97; i < 123; i++) legalCharacters.Add((char)i);

            if (lowerCaseCheckBox.Checked) for (i = 65; i < 91; i++) legalCharacters.Add((char)i);

            //Add all special characters, then remove the ones to be excluded
            if (excludeSymbols.Checked)
            {
                for (i = 33; i < 48; i++) legalCharacters.Add((char)i);
                for (i = 58; i < 65; i++) legalCharacters.Add((char)i);
                for (i = 91; i < 97; i++) legalCharacters.Add((char)i);
                for (i = 123; i < 127; i++) legalCharacters.Add((char)i);

                if(tildeCheckbox.Checked) legalCharacters.Remove('~');
                if (tackCheckbox.Checked) legalCharacters.Remove('`');
                if (exclamationCheckBox.Checked) legalCharacters.Remove('!');
                if (atCheckBox.Checked) legalCharacters.Remove('@');
                if (hashCheckBox.Checked) legalCharacters.Remove('#');
                if (dollarCheckBox.Checked) legalCharacters.Remove('$');
                if (percentCheckBox.Checked) legalCharacters.Remove('%');
                if (caratCheckBox.Checked) legalCharacters.Remove('^');
                if (ampersandCheckBox.Checked) legalCharacters.Remove('&');
                if (splatCheckBox.Checked) legalCharacters.Remove('*');
                if (paranthesesCheckBox.Checked)
                {
                    legalCharacters.Remove('(');
                    legalCharacters.Remove(')');
                }
                if (dashCheckBox.Checked) legalCharacters.Remove('-');
                if (emDashCheckBox.Checked) legalCharacters.Remove('_');
                if (plusCheckBox.Checked) legalCharacters.Remove('+');
                if (equalsCheckBox.Checked) legalCharacters.Remove('=');
                if (bracesCheckBox.Checked)
                {
                    legalCharacters.Remove('{');
                    legalCharacters.Remove('}');
                }
                if (bracketsCheckBox.Checked)
                {
                    legalCharacters.Remove('[');
                    legalCharacters.Remove('}');
                }
                if (pipeCheckBox.Checked) legalCharacters.Remove('|');
                if (backslashCheckBox.Checked) legalCharacters.Remove('\\');
                if (colonCheckBox.Checked) legalCharacters.Remove(':');
                if (semicolonCheckBox.Checked) legalCharacters.Remove(';');
                if (angleBracketsCheckBox.Checked)
                {
                    legalCharacters.Remove('<');
                    legalCharacters.Remove('>');
                }
                if (doublequoteCheckBox.Checked) legalCharacters.Remove('"');
                if (commaCheckBox.Checked) legalCharacters.Remove(',');
                if (periodCheckBox.Checked) legalCharacters.Remove('.');
                if (questionMarkCheckBox.Checked) legalCharacters.Remove('?');
                if (forwardSlashCheckBox.Checked) legalCharacters.Remove('/');
            }

            //Add only the special symbols indicated
            if (includeSymbols.Checked)
            {

                if (tildeCheckbox.Checked) legalCharacters.Add('~');
                if (tackCheckbox.Checked) legalCharacters.Add('`');
                if (exclamationCheckBox.Checked) legalCharacters.Add('!');
                if (atCheckBox.Checked) legalCharacters.Add('@');
                if (hashCheckBox.Checked) legalCharacters.Add('#');
                if (dollarCheckBox.Checked) legalCharacters.Add('$');
                if (percentCheckBox.Checked) legalCharacters.Add('%');
                if (caratCheckBox.Checked) legalCharacters.Add('^');
                if (ampersandCheckBox.Checked) legalCharacters.Add('&');
                if (splatCheckBox.Checked) legalCharacters.Add('*');
                if (paranthesesCheckBox.Checked)
                {
                    legalCharacters.Add('(');
                    legalCharacters.Add(')');
                }
                if (dashCheckBox.Checked) legalCharacters.Add('-');
                if (emDashCheckBox.Checked) legalCharacters.Add('_');
                if (plusCheckBox.Checked) legalCharacters.Add('+');
                if (equalsCheckBox.Checked) legalCharacters.Add('=');
                if (bracesCheckBox.Checked)
                {
                    legalCharacters.Add('{');
                    legalCharacters.Add('}');
                }
                if (bracketsCheckBox.Checked)
                {
                    legalCharacters.Add('[');
                    legalCharacters.Add('}');
                }
                if (pipeCheckBox.Checked) legalCharacters.Add('|');
                if (backslashCheckBox.Checked) legalCharacters.Add('\\');
                if (colonCheckBox.Checked) legalCharacters.Add(':');
                if (semicolonCheckBox.Checked) legalCharacters.Add(';');
                if (angleBracketsCheckBox.Checked)
                {
                    legalCharacters.Add('<');
                    legalCharacters.Add('>');
                }
                if (doublequoteCheckBox.Checked) legalCharacters.Add('"');
                if (commaCheckBox.Checked) legalCharacters.Add(',');
                if (periodCheckBox.Checked) legalCharacters.Add('.');
                if (questionMarkCheckBox.Checked) legalCharacters.Add('?');
                if (forwardSlashCheckBox.Checked) legalCharacters.Add('/');
            }

            //Now we're almost ready to generate the password, but first we need to clear the text field
            passwordTextBox.Text = "";

            for (i = 0; i < passwordLengthVar; i++)
            {
                //Get a random integer for the index
                randomInt = getRandomInt();
                //Take the absolute value
                if (randomInt < 0) randomInt *= -1;
                //Take the modulus of the random number
                randomInt = randomInt % legalCharacters.Count;
                //Finally, we have our random index with which to take a random character from our list of legal characters
                //Now append the character to the text box to create our password
                passwordTextBox.Text += legalCharacters[randomInt];
            }

            //Now, for kicks and giggles, let's add the password to the clipboard            
            if (autoClipboardCheckBox.Checked) Clipboard.SetText(passwordTextBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            passwordTextBox.Text = getRandomInt().ToString();
        }

        private void includeSymbols_CheckedChanged(object sender, EventArgs e)
        {
            if (!includeSymbols.Checked) return;

            tackCheckbox.Checked = false;
            exclamationCheckBox.Checked = false;
            dollarCheckBox.Checked = false;
            percentCheckBox.Checked = false;
            caratCheckBox.Checked = false;
            ampersandCheckBox.Checked = false;
            bracketsCheckBox.Checked = false;
            pipeCheckBox.Checked = false;
            backslashCheckBox.Checked = false;
            colonCheckBox.Checked = false;
            angleBracketsCheckBox.Checked = false;

            tildeCheckbox.Checked = true;
            atCheckBox.Checked = true;
            hashCheckBox.Checked = true;
            splatCheckBox.Checked = true;
            paranthesesCheckBox.Checked = true;
            dashCheckBox.Checked = true;
            emDashCheckBox.Checked = true;
            plusCheckBox.Checked = true;
            equalsCheckBox.Checked = true;
            bracesCheckBox.Checked = true;
            semicolonCheckBox.Checked = true;
            commaCheckBox.Checked = true;
            periodCheckBox.Checked = true;
            questionMarkCheckBox.Checked = true;
            forwardSlashCheckBox.Checked = true;
        }

        private void excludeSymbols_CheckedChanged(object sender, EventArgs e)
        {
            if (!excludeSymbols.Checked) return;

            tackCheckbox.Checked = true;
            exclamationCheckBox.Checked = true;
            dollarCheckBox.Checked = true;
            percentCheckBox.Checked = true;
            caratCheckBox.Checked = true;
            ampersandCheckBox.Checked = true;
            bracketsCheckBox.Checked = true;
            pipeCheckBox.Checked = true;
            backslashCheckBox.Checked = true;
            colonCheckBox.Checked = true;
            angleBracketsCheckBox.Checked = true;

            tildeCheckbox.Checked = false;
            atCheckBox.Checked = false;
            hashCheckBox.Checked = false;
            splatCheckBox.Checked = false;
            paranthesesCheckBox.Checked = false;
            dashCheckBox.Checked = false;
            emDashCheckBox.Checked = false;
            plusCheckBox.Checked = false;
            equalsCheckBox.Checked = false;
            bracesCheckBox.Checked = false;
            semicolonCheckBox.Checked = false;
            commaCheckBox.Checked = false;
            periodCheckBox.Checked = false;
            questionMarkCheckBox.Checked = false;
            forwardSlashCheckBox.Checked = false;
        }

        private void includeAll_CheckedChanged(object sender, EventArgs e)
        {
            //if (!includeSymbols.Checked) return;

            tackCheckbox.Checked = true;
            exclamationCheckBox.Checked = true;
            dollarCheckBox.Checked = true;
            percentCheckBox.Checked = true;
            caratCheckBox.Checked = true;
            ampersandCheckBox.Checked = true;
            bracketsCheckBox.Checked = true;
            pipeCheckBox.Checked = true;
            backslashCheckBox.Checked = true;
            colonCheckBox.Checked = true;
            angleBracketsCheckBox.Checked = true;
            doublequoteCheckBox.Checked = true;
            tildeCheckbox.Checked = true;
            atCheckBox.Checked = true;
            hashCheckBox.Checked = true;
            splatCheckBox.Checked = true;
            paranthesesCheckBox.Checked = true;
            dashCheckBox.Checked = true;
            emDashCheckBox.Checked = true;
            plusCheckBox.Checked = true;
            equalsCheckBox.Checked = true;
            bracesCheckBox.Checked = true;
            semicolonCheckBox.Checked = true;
            commaCheckBox.Checked = true;
            periodCheckBox.Checked = true;
            questionMarkCheckBox.Checked = true;
            forwardSlashCheckBox.Checked = true;
        }

        private void exludeAll_CheckedChanged(object sender, EventArgs e)
        {
            //if (!excludeSymbols.Checked) return;

            tildeCheckbox.Checked = false;
            atCheckBox.Checked = false;
            hashCheckBox.Checked = false;
            splatCheckBox.Checked = false;
            paranthesesCheckBox.Checked = false;
            dashCheckBox.Checked = false;
            emDashCheckBox.Checked = false;
            plusCheckBox.Checked = false;
            equalsCheckBox.Checked = false;
            bracesCheckBox.Checked = false;
            semicolonCheckBox.Checked = false;
            commaCheckBox.Checked = false;
            periodCheckBox.Checked = false;
            questionMarkCheckBox.Checked = false;
            forwardSlashCheckBox.Checked = false;
            tackCheckbox.Checked = false;
            exclamationCheckBox.Checked = false;
            dollarCheckBox.Checked = false;
            percentCheckBox.Checked = false;
            caratCheckBox.Checked = false;
            ampersandCheckBox.Checked = false;
            bracketsCheckBox.Checked = false;
            pipeCheckBox.Checked = false;
            backslashCheckBox.Checked = false;
            colonCheckBox.Checked = false;
            angleBracketsCheckBox.Checked = false;
            doublequoteCheckBox.Checked = false;
        }  

    }
}
