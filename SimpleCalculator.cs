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

        // Requirement: variables of different types.
        // This int tracks how many operations have been performed (helps UX and meets the “display a variable” requirement).
        private int operationCount;

        // This string stores the last operation used (also improves UX and meets “different variable type” requirement).
        private string lastOperation;

        public SimpleCalculator()
        {
            // This loads the UI that you designed in the Windows Forms Designer.
            InitializeComponent();

            // Requirement: customized form (does not count as a GUI component).
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
        // Requirement: conditional statements (if/else set #1) to ensure only numbers are entered.
        private bool TryReadInputs()
        {
            // TryParse attempts to convert text to a number safely without crashing.
            bool input1Valid = double.TryParse(txtInput1.Text, out firstNumber);
            bool input2Valid = double.TryParse(txtInput2.Text, out secondNumber);

            // If Input 1 is not valid, we stop the calculation and guide the user.
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
                // Input 1 is valid, so we continue to validate Input 2.
            }

            // If Input 2 is not valid, we stop the calculation and guide the user.
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
        // Requirement: display at least one variable’s value on the form (result is displayed here).
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
                // Value is already in range, so no changes are needed.
            }

            // Display the final value in the NumericUpDown control.
            nudResult.Value = decValue;
        }

        // This method updates the UI to give the user feedback after each operation.
        // Requirement: display variable values on the form (operationCount and lastOperation are shown here).
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate inputs first; if invalid, stop immediately.
            if (TryReadInputs() == false) return;

            // Perform addition (0 is allowed).
            result = firstNumber + secondNumber;

            // Display the result.
            DisplayResult(result);

            // Update feedback UI.
            UpdateUiAfterOperation("+");
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            // Validate inputs first; if invalid, stop immediately.
            if (TryReadInputs() == false) return;

            // Perform subtraction (0 is allowed).
            result = firstNumber - secondNumber;

            // Display the result.
            DisplayResult(result);

            // Update feedback UI.
            UpdateUiAfterOperation("-");
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            // Validate inputs first; if invalid, stop immediately.
            if (TryReadInputs() == false) return;

            // Perform multiplication (0 is allowed).
            result = firstNumber * secondNumber;

            // Display the result.
            DisplayResult(result);

            // Update feedback UI.
            UpdateUiAfterOperation("*");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            // Validate inputs first; if invalid, stop immediately.
            if (TryReadInputs() == false) return;

            // Requirement: conditional statements (if/else set #2) to prevent division by 0.
            // Note: user is allowed to add/subtract/multiply by 0, but division by 0 is blocked.
            if (secondNumber == 0)
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
                result = firstNumber / secondNumber;

                // Display the result.
                DisplayResult(result);

                // Update feedback UI.
                UpdateUiAfterOperation("÷");

                //Used ChatGPT to help format the code properly and troubleshoot issues.
            }
        }
    }
}


