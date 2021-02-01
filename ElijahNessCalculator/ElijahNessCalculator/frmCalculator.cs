// Author: Elijah Ness
// Purpose: CSC 260 Object-Oriented Design Assignment 1
// Institution: Dakota State University

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElijahNessCalculator
{
    public partial class frmCalculator : Form
    {

        // Create Lists to hold the input data
        List<double> NumsList = new List<double>();
        List<char> OpsList = new List<char>();



        string NumberBuilder = "0";     // A string to build the number with easy editing. Call Double.Parse() to put into number format.
        Boolean DecimalUsed = false;    // Flag to determine if the decimal point has already been used in the current number
        Boolean NumRequired = false;    // Flag to determine if a number is required (like if an operator was just entered)
        char QueuedOp = '\n';             // A Variable to hold the operator that should be added to the list

        int HistoryCounter = 0;     // The current history slot, 0 is the first slot, 19 max
        List<string> TotalsHistory = new List<string>();    // Create an list of lists to hold history

        public frmCalculator()
        {
            InitializeComponent();
        }
        #region Custom Function for building numbers with strings
        public void BuildNum(string Num)
        {
            if (Double.Parse(NumberBuilder) == 0.0 && Num != "." && DecimalUsed == false)
            {
                NumberBuilder = Num.ToString();     // Set the current NumberBuilder string equal to the inputted number

                if (tbxDisplay.TextLength == 1)     // If there is only one character in the box
                {
                    tbxDisplay.Text = Num.ToString();   // The character is replaced by the inputted number
                }
                else    // If there are more than one characters in the box
                {
                    tbxDisplay.Text = tbxDisplay.Text.Substring(0, tbxDisplay.Text.Length - 1) + Num.ToString();    // Replace the latest value (which is a zero from the line 41 IF statement) with the inputted Num
                    OpsList.Add(QueuedOp);  // Add the queued operator to the list of operations
                    QueuedOp = '\n';
                }
            }
            else
            {
                NumberBuilder = NumberBuilder + Num;
                tbxDisplay.AppendText(Num.ToString());  // Add to the display without replacing any characters
            }
            NumRequired = false;    // Allow operators to be inputted once again
        }
        #endregion
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            btnPower_Click(sender, e);  // Fire the Power function
            BuildNum("0.5");    // Build the number 0.5 b/c x^0.5 = sqrt
            btnAdd_Click(sender, e);    // Tack an addition operation (changeable) to the end to disallow editing the 0.5
        }

        private void btnSqr_Click(object sender, EventArgs e)
        {
            btnPower_Click(sender, e);
            btn2_Click(sender, e);
            btnAdd_Click(sender, e);
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            if (!NumRequired)   // If an operator can be input
            {
                NumsList.Add(Double.Parse(NumberBuilder));  // Parse the current number
                QueuedOp = '^';     // Queue the operator
                NumberBuilder = "0";    // Reset the NumBuilder
                DecimalUsed = false;
                tbxDisplay.AppendText("^0");    // Fix the display
                NumRequired = true;
            }
            else    // If an operator can't be input (to avoid multiple operators in a row)
            {
                QueuedOp = '^';     // Change the current queued operator
                tbxDisplay.Text = tbxDisplay.Text.Substring(0, tbxDisplay.Text.Length - 2) + "^0";  // Change the operator displayed on the screen
            }
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text.Substring(0, tbxDisplay.Text.Length - NumberBuilder.Length);  // Clear the current target number off the screen
            NumberBuilder = (1 / Double.Parse(NumberBuilder)).ToString();   // Calculate the Reciprocal
            tbxDisplay.Text = tbxDisplay.Text + NumberBuilder;  // Display the reciprocal
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text.Substring(0, tbxDisplay.Text.Length - NumberBuilder.Length);  // Cut the recent number from the display
            NumberBuilder = "0";
            DecimalUsed = false;
            tbxDisplay.AppendText(NumberBuilder);   // Add the zero to the screen
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Reset everything besides history
            NumberBuilder = "0";
            tbxDisplay.Text = "0";
            DecimalUsed = false;
            NumRequired = false;
            QueuedOp = '\n';
            NumsList.Clear();
            OpsList.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbxDisplay.Text.Length > 1)     // If the current text is long
            {
                if (NumberBuilder.Length > 1)   // If the NB string is more than one digit
                {
                    // The following code removes decimal points and minus signs when a digit holding them is deleted
                    // Otherwise, it deletes a single character from the screen and NB string
                    if (NumberBuilder.ElementAt(NumberBuilder.Length - 1) == '.')
                    {
                        DecimalUsed = false;
                    }
                    if (NumberBuilder.ElementAt(NumberBuilder.Length - 2) == '-')
                    {
                        NumberBuilder = "0";
                        tbxDisplay.Text = tbxDisplay.Text.Substring(0, tbxDisplay.Text.Length - 2) + 0;

                        if (tbxDisplay.Text == "")
                        {
                            tbxDisplay.Text = "0";
                        }
                    }
                    else
                    {
                        NumberBuilder = NumberBuilder.Substring(0, NumberBuilder.Length - 1);
                        tbxDisplay.Text = tbxDisplay.Text.Substring(0, tbxDisplay.Text.Length - 1);
                    }
                }
                else
                {
                    NumberBuilder = "0";
                    tbxDisplay.Text = tbxDisplay.Text.Substring(0, tbxDisplay.Text.Length - 1) + '0';
                }
            }
            else
            {
                NumberBuilder = "0";
                tbxDisplay.Text = "0";
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            // See btnPower_Click
            if (!NumRequired)
            {
                NumsList.Add(Double.Parse(NumberBuilder));
                QueuedOp = '/';
                NumberBuilder = "0";
                DecimalUsed = false;
                tbxDisplay.AppendText("/0");
                NumRequired = true;
            }
            else
            {
                QueuedOp = '/';
                tbxDisplay.Text = tbxDisplay.Text.Substring(0, tbxDisplay.Text.Length - 2) + "/0";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            BuildNum("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            BuildNum("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            BuildNum("9");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            // See btnPower_Click()
            if (!NumRequired)
            {
                NumsList.Add(Double.Parse(NumberBuilder));
                QueuedOp = '*';
                NumberBuilder = "0";
                DecimalUsed = false;
                tbxDisplay.AppendText("*0");
                NumRequired = true;
            }
            else
            {
                QueuedOp = '*';
                tbxDisplay.Text = tbxDisplay.Text.Substring(0, tbxDisplay.Text.Length - 2) + "*0";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            BuildNum("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            BuildNum("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            BuildNum("6");
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            // See btnPower_Click()
            if (!NumRequired)
            {
                NumsList.Add(Double.Parse(NumberBuilder));
                QueuedOp = '-';
                NumberBuilder = "0";
                DecimalUsed = false;
                tbxDisplay.AppendText("-0");
                NumRequired = true;
            }
            else
            {
                QueuedOp = '-';
                tbxDisplay.Text = tbxDisplay.Text.Substring(0, tbxDisplay.Text.Length - 2) + "-0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            BuildNum("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            BuildNum("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            BuildNum("3");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // See btnPower_Click()
            if (!NumRequired)
            {
                NumsList.Add(Double.Parse(NumberBuilder));
                QueuedOp = '+';
                NumberBuilder = "0";
                DecimalUsed = false;
                tbxDisplay.AppendText("+0");
                NumRequired = true;
            }
            else
            {
                QueuedOp = '+';
                tbxDisplay.Text = tbxDisplay.Text.Substring(0, tbxDisplay.Text.Length - 2) + "+0";
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (NumberBuilder.First() == '-')
            {
                tbxDisplay.Text = tbxDisplay.Text.Substring(0, tbxDisplay.Text.Length - NumberBuilder.Length);
                NumberBuilder = NumberBuilder.Substring(1, NumberBuilder.Length - 1);   // Flip Sign
                tbxDisplay.AppendText(NumberBuilder);   // Display the difference
            }
            else if (Double.Parse(NumberBuilder) != 0.0)
            {
                tbxDisplay.Text = tbxDisplay.Text.Substring(0, tbxDisplay.Text.Length - NumberBuilder.Length);  // Remove the latest number from the display
                NumberBuilder = "-" + NumberBuilder;
                tbxDisplay.AppendText(NumberBuilder);   // Display the negated number
            }

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            BuildNum("0");
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (NumRequired)    // The most recent input was an operator
            {
                OpsList.Add(QueuedOp);  // Queue the most recent operator
                BuildNum(".");
                DecimalUsed = true;     // Flag that the decimal was used
            }
            else
            {
                if (DecimalUsed == false)
                {
                    BuildNum(".");
                    DecimalUsed = true;
                }
            }

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (OpsList.Count == 0)
            {
                // Equals does nothing without operators
            }
            else
            {
                if (NumRequired)    // If a number is required
                {
                    NumsList.Add(0.0);  // Add Zero to the list
                    OpsList.Add(QueuedOp);  // Add the current operator to the list
                }
                else
                {
                    NumsList.Add(Double.Parse(NumberBuilder));
                    QueuedOp = '\n';
                }

                // Temporary Lists and Vars
                List<double> TempNums = new List<double>();
                List<char> TempOp = new List<char>();
                Boolean HasBeenUsed = false;
                double CurrentVal = 0.0;

                // Search for Exponnets
                for (int i = 0; i < OpsList.Count(); ++i)    // For each inputted operator
                {
                    if (OpsList.ElementAt(i) == '^')     // If the operator is an exponent symbol
                    {
                        if (HasBeenUsed == false)    // If an operation has not already occured in this group
                        {
                            CurrentVal = Math.Pow(NumsList.ElementAt(i), NumsList.ElementAt(i + 1));    // Calculate the power
                            HasBeenUsed = true;     // Change the flag because an operation occured
                        }
                        else
                        {
                            CurrentVal = Math.Pow(CurrentVal, NumsList.ElementAt(i + 1));   // Set the holder to the product
                        }
                        if (i == OpsList.Count() - 1)   // If the operator is the last
                        {
                            TempOp.Add(OpsList.ElementAt(i));

                            if (HasBeenUsed == false)
                            {
                                TempNums.Add(NumsList.ElementAt(i));
                                TempNums.Add(NumsList.ElementAt(i + 1));    // Get the number beyond the operator
                            }
                            else
                            {
                                TempNums.Add(CurrentVal);
                                TempNums.Add(NumsList.ElementAt(i + 1));    // Get the number beyond the operator
                            }

                            HasBeenUsed = false;    // Change the flag to show that the operator has been used
                        }
                    }

                    else
                    {
                        TempOp.Add(OpsList.ElementAt(i));

                        if (i == OpsList.Count() - 1)
                        {
                            if (HasBeenUsed == false)
                            {
                                TempNums.Add(NumsList.ElementAt(i));
                                TempNums.Add(NumsList.ElementAt(i + 1));
                            }
                            else
                            {
                                TempNums.Add(CurrentVal);
                                TempNums.Add(NumsList.ElementAt(i + 1));
                            }
                        }
                        else
                        {
                            if (HasBeenUsed == false)
                            {
                                TempNums.Add(NumsList.ElementAt(i));
                            }
                            else
                            {
                                TempNums.Add(CurrentVal);
                            }
                        }
                        HasBeenUsed = false;
                    }
                }

                List<double> TempNums2 = new List<double>();
                List<char> TempOp2 = new List<char>();

                // Search for Multiplication/Division
                for (int i = 0; i < TempOp.Count(); ++i)    // For each inputted operator
                {
                    if (TempOp.ElementAt(i) == '/')     // If the operator is an divides symbol
                    {
                        if (HasBeenUsed == false)    // If an operation has not already occured in this group
                        {
                            CurrentVal = TempNums.ElementAt(i) / TempNums.ElementAt(i + 1);    // Calculate the operation
                            HasBeenUsed = true;     // Change the flag because an operation occured
                        }
                        else
                        {
                            CurrentVal = CurrentVal / TempNums.ElementAt(i + 1);   // Set the holder to the quotient
                        }
                        if (i == TempOp.Count() - 1)
                        {
                            TempOp2.Add(TempOp.ElementAt(i));

                            if (HasBeenUsed == false)
                            {
                                TempNums2.Add(TempNums.ElementAt(i));
                                TempNums2.Add(TempNums.ElementAt(i + 1));
                            }
                            else
                            {
                                TempNums2.Add(CurrentVal);
                                TempNums2.Add(TempNums.ElementAt(i + 1));
                            }

                            HasBeenUsed = false;
                        }
                    }
                    else if (TempOp.ElementAt(i) == '*')     // If the operator is an * symbol
                    {
                        if (HasBeenUsed == false)    // If an operation has not already occured in this group
                        {
                            CurrentVal = TempNums.ElementAt(i) * TempNums.ElementAt(i + 1);    // Calculate the operation
                            HasBeenUsed = true;     // Change the flag because an operation occured
                        }
                        else
                        {
                            CurrentVal = CurrentVal * TempNums.ElementAt(i + 1);   // Set the holder to the product
                        }
                        if (i == TempOp.Count() - 1)
                        {
                            TempOp2.Add(TempOp.ElementAt(i));

                            if (HasBeenUsed == false)
                            {
                                TempNums2.Add(TempNums.ElementAt(i));
                                TempNums2.Add(TempNums.ElementAt(i + 1));
                            }
                            else
                            {
                                TempNums2.Add(CurrentVal);
                                TempNums2.Add(TempNums.ElementAt(i + 1));
                            }

                            HasBeenUsed = false;
                        }
                    }

                    else
                    {
                        TempOp2.Add(TempOp.ElementAt(i));

                        if (i == TempOp.Count() - 1)
                        {
                            if (HasBeenUsed == false)
                            {
                                TempNums2.Add(TempNums.ElementAt(i));
                                TempNums2.Add(TempNums.ElementAt(i + 1));
                            }
                            else
                            {
                                TempNums2.Add(CurrentVal);
                                TempNums2.Add(TempNums.ElementAt(i + 1));
                            }
                        }
                        else
                        {
                            if (HasBeenUsed == false)
                            {
                                TempNums2.Add(TempNums.ElementAt(i));
                            }
                            else
                            {
                                TempNums2.Add(CurrentVal);
                            }
                        }
                        HasBeenUsed = false;
                    }
                }

                List<double> TempNums3 = new List<double>();
                List<char> TempOp3 = new List<char>();

                // Search for Addition/Subtraction
                for (int i = 0; i < TempOp2.Count(); ++i)    // For each inputted operator
                {
                    if (TempOp2.ElementAt(i) == '-')     // If the operator is an subtract symbol
                    {
                        if (HasBeenUsed == false)    // If an operation has not already occured in this group
                        {
                            CurrentVal = TempNums2.ElementAt(i) - TempNums2.ElementAt(i + 1);    // Calculate the difference
                            HasBeenUsed = true;     // Change the flag because an operation occured
                        }
                        else
                        {
                            CurrentVal = CurrentVal - TempNums2.ElementAt(i + 1);   // Set the holder to the difference
                        }
                        if (i == TempOp2.Count() - 1)
                        {
                            TempOp3.Add(TempOp2.ElementAt(i));

                            if (HasBeenUsed == false)
                            {
                                TempNums3.Add(TempNums2.ElementAt(i));
                                TempNums3.Add(TempNums2.ElementAt(i + 1));
                            }
                            else
                            {
                                TempNums3.Add(CurrentVal);
                                TempNums3.Add(TempNums2.ElementAt(i + 1));
                            }

                            HasBeenUsed = false;
                        }
                    }
                    else if (TempOp2.ElementAt(i) == '+')     // If the operator is an + symbol
                    {
                        if (HasBeenUsed == false)    // If an operation has not already occured in this group
                        {
                            CurrentVal = TempNums2.ElementAt(i) + TempNums2.ElementAt(i + 1);    // Calculate the sum
                            HasBeenUsed = true;     // Change the flag because an operation occured
                        }
                        else
                        {
                            CurrentVal = CurrentVal + TempNums2.ElementAt(i + 1);   // Set the holder to the sum
                        }
                        if (i == TempOp2.Count() - 1)
                        {
                            TempOp3.Add(TempOp2.ElementAt(i));

                            if (HasBeenUsed == false)
                            {
                                TempNums3.Add(TempNums2.ElementAt(i));
                                TempNums3.Add(TempNums2.ElementAt(i + 1));
                            }
                            else
                            {
                                TempNums3.Add(CurrentVal);
                                TempNums3.Add(TempNums2.ElementAt(i + 1));
                            }

                            HasBeenUsed = false;
                        }
                    }

                    else
                    {
                        TempOp3.Add(TempOp2.ElementAt(i));

                        if (i == TempOp2.Count() - 1)
                        {
                            if (HasBeenUsed == false)
                            {
                                TempNums3.Add(TempNums2.ElementAt(i));
                                TempNums3.Add(TempNums2.ElementAt(i + 1));
                            }
                            else
                            {
                                TempNums3.Add(CurrentVal);
                                TempNums3.Add(TempNums2.ElementAt(i + 1));
                            }
                        }
                        else
                        {
                            if (HasBeenUsed == false)
                            {
                                TempNums3.Add(TempNums2.ElementAt(i));
                            }
                            else
                            {
                                TempNums3.Add(CurrentVal);
                            }
                        }
                        HasBeenUsed = false;
                    }
                }


                string HistoryOut = "";     // Declare a history display string holder
                for (int i = 0; i < OpsList.Count(); ++i)   // For each operator
                {
                    HistoryOut = HistoryOut + NumsList.ElementAt(i).ToString();     // Concatenate to the holder with the number string
                    HistoryOut = HistoryOut + OpsList.ElementAt(i).ToString();  // Update the holder with an operator character
                }
                HistoryOut = HistoryOut + NumsList.ElementAt(NumsList.Count() - 1).ToString() + " = " + TempNums3.ElementAt(0).ToString();  // Add the final number string to the holder
                rlbHistory.Items.Insert(0, HistoryOut);     // Insert the holder string into the history display ListBox

                TotalsHistory.Insert(0, TempNums3.ElementAt(0).ToString());     // Insert the operation result into the history record

                // Ensure that the record only can hold 24 values
                if (rlbHistory.Items.Count > 24)
                {
                    rlbHistory.Items.RemoveAt(rlbHistory.Items.Count - 1);
                }

                ++HistoryCounter;   // Increment the history count

                // Reset the History Count
                if (HistoryCounter > 24) 
                {
                    TotalsHistory.RemoveAt(TotalsHistory.Count - 1);
                    HistoryCounter = 0;
                }

                // Prepare for a new sequence
                NumberBuilder = TempNums3.ElementAt(0).ToString();
                tbxDisplay.Text = TempNums3.ElementAt(0).ToString();
                NumRequired = false;
                QueuedOp = '\n';
                NumsList.Clear();
                OpsList.Clear();
            }
        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {

        }

        private void frmCalculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Handle all keyboard input
            switch (e.KeyChar)
            {
                case '0':
                    btn0.Select();
                    btn0_Click(sender, e);
                    break;

                case '1':
                    btn1.Select();
                    btn1_Click(sender, e);
                    break;

                case '2':
                    btn2.Select();
                    btn2_Click(sender, e);
                    break;

                case '3':
                    btn3.Select();
                    btn3_Click(sender, e);
                    break;

                case '4':
                    btn4.Select();
                    btn4_Click(sender, e);
                    break;

                case '5':
                    btn5.Select();
                    btn5_Click(sender, e);
                    break;

                case '6':
                    btn6.Select();
                    btn6_Click(sender, e);
                    break;

                case '7':
                    btn7.Select();
                    btn7_Click(sender, e);
                    break;

                case '8':
                    btn8.Select();
                    btn8_Click(sender, e);
                    break;

                case '9':
                    btn9.Select();
                    btn9_Click(sender, e);
                    break;

                case '\b': // Backspace will effectively trigger the delete
                    btnDelete.Select();
                    btnDelete_Click(sender, e);
                    break;

                case '+':
                    btnAdd.Select();
                    btnAdd_Click(sender, e);
                    break;

                case '-':
                    btnSubtract.Select();
                    btnSubtract_Click(sender, e);
                    break;

                case '*':
                    btnMultiply.Select();
                    btnMultiply_Click(sender, e);
                    break;

                case '/':
                    btnDivide.Select();
                    btnDivide_Click(sender, e);
                    break;

                case '^':
                    btnPower.Select();
                    btnPower_Click(sender, e);
                    break;

                case '.':
                    btnDecimal.Select();
                    btnDecimal_Click(sender, e);
                    break;

                case '=':
                    btnEquals.Select();
                    btnEquals_Click(sender, e);
                    break;

                case 'c':
                case 'C':
                    btnClear.Select();
                    btnClear_Click(sender, e);
                    break;


                default:
                    break;
            }
        }

        private void rlbHistory_MouseClick(object sender, MouseEventArgs e)
        {
            //Reset everything besides history
            NumberBuilder = "0";
            tbxDisplay.Text = "0";
            DecimalUsed = false;
            NumRequired = false;
            QueuedOp = '\n';
            NumsList.Clear();
            OpsList.Clear();

            BuildNum(TotalsHistory[rlbHistory.SelectedIndex].ToString());   // Retrieve the historic value into memory
            tbxDisplay.Text = TotalsHistory[rlbHistory.SelectedIndex];  // Display the historic value

            if (TotalsHistory[rlbHistory.SelectedIndex].Contains("."))
            {
                DecimalUsed = true;
            }
            else
            {
                DecimalUsed = false;
            }
        }
    }
}
