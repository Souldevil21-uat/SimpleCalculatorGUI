using System;
using System.Windows.Forms;

namespace SimpleCalculatorGUI
{
    public partial class SimpleCalculator : Form
    {
        // These variables store the two inputs and the result of the calculation (type: double for decimal math).
        private double firstNumber;
        private double secondNumber;
        private double result;

        // This int tracks how many operations have been performed (helps UX and meets the “display a variable” requirement).
        private int operationCount;

        // This string stores the last operation used (also improves UX and meets “different variable type” requirement).
        private string lastOperation;

        public SimpleCalculator()
        {
            // This loads the UI that you designed in the Windows Forms Designer.
            InitializeComponent();

            this.Text = "Simple Calculator";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // This configures the NumericUpDown so it can display decimal results and not clamp too tightly.
            nudResult.DecimalPlaces = 4;
            nudResult.Minimum = -1000000;
            nudResult.Maximum = 1000000;

            // Initialize tracking variables so the form starts in a known and clean state.
            operationCount = 0;
            lastOperation = "None";

            // UX: show the user instructions and current state.
            lblStatus.Text = "Status: Ready. Enter two numbers, then click an operation button.";
            lblOpCount.Text = "Operations: 0";
        }

        // This method reads the textbox values and validates they are numbers.
        private bool TryReadInputs()
        {
            // TryParse attempts to convert text to a number safely without crashing.
            bool input1Valid = double.TryParse(txtInput1.Text, out firstNumber);
            bool input2Valid = double.TryParse(txtInput2.Text, out secondNumber);

            if (input1Valid == false)
            {
                MessageBox.Show("Input 1 must be a valid number. Example: 12 or 12.5");
                txtInput1.Focus();
                txtInput1.SelectAll();
                lblStatus.Text = "Status: Error - Input 1 is not a valid number.";
                return false;
            }
            else
            {
                // Input 1 is valid, so continue.
            }

            if (input2Valid == false)
            {
                MessageBox.Show("Input 2 must be a valid number. Example: 7 or 7.25");
                txtInput2.Focus();
                txtInput2.SelectAll();
                lblStatus.Text = "Status: Error - Input 2 is not a valid number.";
                return false;
            }
            else
            {
                // Input 2 is valid, so both inputs are safe to use.
            }

            // UX: confirm input was accepted.
            lblStatus.Text = "Status: Inputs accepted. Choose an operation.";
            return true;
        }

        // This method displays the result on the form using the NumericUpDown.
        private void DisplayResult(double value)
        {
            // NumericUpDown uses decimal internally, so we convert the double to decimal.
            decimal decValue = (decimal)value;

            // Clamp to the NumericUpDown range so it never throws an out-of-range error.
            if (decValue < nudResult.Minimum)
            {
                decValue = nudResult.Minimum;
            }
            else if (decValue > nudResult.Maximum)
            {
                decValue = nudResult.Maximum;
            }
            else
            {
                // Value is already in range.
            }

            nudResult.Value = decValue;
        }

        // This method updates the UI to give the user feedback after each operation.
        private void UpdateUiAfterOperation(string operationSymbol)
        {
            // Increase the operation count each time the user completes an operation.
            operationCount++;

            // Store which operation was last used.
            lastOperation = operationSymbol;

            // Show the count on the form so the user sees activity and feedback.
            lblOpCount.Text = $"Operations: {operationCount}";

            // Show a clear status message so the user knows what happened.
            lblStatus.Text = $"Status: Completed {lastOperation}. Result updated below.";
        }


        // Adds two numbers and returns the sum.
        private double AddNumbers(double numberA, double numberB)
        {
            return numberA + numberB;
        }

        // Subtracts numberB from numberA and returns the difference.
        private double SubtractNumbers(double numberA, double numberB)
        {
            return numberA - numberB;
        }

        // Multiplies two numbers and returns the product.
        private double MultiplyNumbers(double numberA, double numberB)
        {
            return numberA * numberB;
        }

        // Divides numberA by numberB and returns the quotient.
        private double DivideNumbers(double numberA, double numberB)
        {
            if (numberB == 0)
            {
                // We return NaN (Not a Number) to signal an invalid division attempt.
                // The button click checks for NaN and shows a message instead of crashing.
                return double.NaN;
            }
            else
            {
                return numberA / numberB;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate inputs first; if invalid, stop immediately.
            if (TryReadInputs() == false) return;

            // Use the Week 4 custom function instead of doing math directly here.
            result = AddNumbers(firstNumber, secondNumber);

            // Display the result.
            DisplayResult(result);

            // Update feedback UI.
            UpdateUiAfterOperation("+");
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            // Validate inputs first; if invalid, stop immediately.
            if (TryReadInputs() == false) return;

            // Use the Week 4 custom function instead of doing math directly here.
            result = SubtractNumbers(firstNumber, secondNumber);

            // Display the result.
            DisplayResult(result);

            // Update feedback UI.
            UpdateUiAfterOperation("-");
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            // Validate inputs first; if invalid, stop immediately.
            if (TryReadInputs() == false) return;

            // Use the Week 4 custom function instead of doing math directly here.
            result = MultiplyNumbers(firstNumber, secondNumber);

            // Display the result.
            DisplayResult(result);

            // Update feedback UI.
            UpdateUiAfterOperation("*");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            // Validate inputs first; if invalid, stop immediately.
            if (TryReadInputs() == false) return;

            // Use the Week 4 custom function for division.
            result = DivideNumbers(firstNumber, secondNumber);

            // If the result is NaN, the user attempted division by 0.
            if (double.IsNaN(result))
            {
                MessageBox.Show("You cannot divide by 0. Please enter a non-zero number for Input 2.");
                txtInput2.Focus();
                txtInput2.SelectAll();
                lblStatus.Text = "Status: Division blocked because Input 2 was 0.";
                return;
            }
            else
            {
                // If we are here, dividing is safe.
                DisplayResult(result);

                // Update feedback UI.
                UpdateUiAfterOperation("÷");
            }
        }
    }
}



