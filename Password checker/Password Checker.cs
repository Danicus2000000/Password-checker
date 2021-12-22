using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_checker
{
    public partial class password_checker : Form
    {
        public password_checker()
        {
            InitializeComponent();
        }
        private void confirm_btn_Click(object sender, EventArgs e)//when you click the confirm button
        {
            if (usernamentry_txt.Text != "" && passwordentry_txt.Text!="")//if the boxes are not empty
            {
                advice_lbl.Text = "Advice:";//resets the advice label
                char[] password = passwordentry_txt.Text.ToArray();//converts the password to an array of the individual characters
                string[] username = usernamentry_txt.Text.Split(' ');//converts the username to an array of the individual words
                bool gotcap = false;//stores whether password has a capital
                bool gotnoncap = false;//stores whether the password has a lower case letter
                bool gotnumber = false;//stores whether the password has a number
                bool gotsymbol = false;//stores whether the password has a symbol
                bool uses_part_of_username = false;//checks whether the password uses a word in the username
                int score = 0;//tracks the score as a percentage for progress bar
                foreach (string element in username)//loops through each word in the username
                {
                    if (passwordentry_txt.Text.Contains(element))//checks whether the password contains the word
                    {
                        uses_part_of_username = true;//sets to true if it does
                    }
                }
                foreach (char element in password)//loops through each letter in the password
                {
                    if (char.IsUpper(element))//if the letter is uppercase
                    {
                        gotcap = true;//sets to true
                    }
                    if (char.IsLower(element))//if the letter is lower case
                    {
                        gotnoncap = true;//sets to true
                    }
                    if (char.IsNumber(element))//if the character is a number
                    {
                        gotnumber = true;//sets to true
                    }
                    if (char.IsSymbol(element))//if the character is a symbol
                    {
                        gotsymbol = true;//sets a true
                    }
                }
                if (gotcap == true)//if the word has got a capital
                {
                    score += 20; //adds 20% strength to password
                }
                else if (gotcap == false)//if the password has no capital
                {
                    advice_lbl.Text += "\n-Add a capital letter to your password.";//adds capital letter reuest to advice
                }
                if (gotnoncap == true)//if the word has a lower case
                {
                    score += 20;//adds 20% score
                }
                else if (gotnoncap == false)//if it doesn't have a lower case letter
                {
                    advice_lbl.Text += "\n-Add a lower case letter to your password.";//adds lower case letter to advice list
                }
                if (gotnumber == true)//if the word has a number
                {
                    score += 20;//adds 20% to score
                }
                else if (gotnumber == false)//if the password hasn't got a number
                {
                    advice_lbl.Text += "\n-Add a number to your password.";//adds add number to advice
                }
                if (gotsymbol == true)//if the password has a symbol
                {
                    score += 20;//adds 20% to score
                }
                else if (gotsymbol == false)//if password has no symbol
                {
                    advice_lbl.Text += "\n-Add a symbol to your password.";//adds symbol to advice
                }
                if (uses_part_of_username == false)//if the password doesn't use a word out of the username
                {
                    score += 20;//adds 20% to the score
                }
                else if (uses_part_of_username == true)//if the password uses a word from the username
                {
                    advice_lbl.Text += "\n-Don't use words from your username in your password";//adds to advice list
                }
                //shows the password stats aread
                passwordstrength_bar.Visible = true;
                passwordstrength_bar.Enabled = true;
                passwordstrength_bar.Value = score;
                description_lbl.Visible = true;
                description_lbl.Enabled = true;
                advice_lbl.Visible = true;
                advice_lbl.Enabled = true;
                if (passwordstrength_bar.Value == 100)//if the password is at 100% strength
                {
                    advice_lbl.Text = "You've got a great password!";//turns advice label into a congratulations.
                }
            }
            else//if one of the textboxes are empty
            {
                MessageBox.Show("One or more fields are empty!", "Empty field(s)");//display message to warn user
            }
        }
    }
}
