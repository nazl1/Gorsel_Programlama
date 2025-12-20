
using System;
using System.Windows.Forms;

namespace BankLibrary
{
   public partial class BankUIForm : Form
   {
      protected int TextBoxCount { get; set; } = 4; // number of TextBoxes

      // enumeration constants specify TextBox indices
      public enum TextBoxIndices { Account, First, Last, Balance }

      // parameterless constructor
      public BankUIForm()
      {
         InitializeComponent();
      }

      // clear all TextBoxes
      public void ClearTextBoxes()
      {
         // iterate through every Control on form
         foreach (Control guiControl in Controls)
         {
            // if Control is TextBox, clear it
            (guiControl as TextBox)?.Clear();
         }
      }

      // set text box values to string-array values
      public void SetTextBoxValues(string[] values)
      {
         // determine whether string array has correct length
         if (values.Length != TextBoxCount)
         {
            // throw exception if not correct length
            throw (new ArgumentException(
               $"There must be {TextBoxCount} strings in the array",
               nameof(values)));
         }  
         else // set array values if array has correct length
         {
            // set array values to TextBox values
            accountTextBox.Text = values[(int)TextBoxIndices.Account];
            firstNameTextBox.Text = values[(int)TextBoxIndices.First];
            lastNameTextBox.Text = values[(int)TextBoxIndices.Last];
            balanceTextBox.Text = values[(int)TextBoxIndices.Balance];
         }
      }

      // return TextBox values as string array
      public string[] GetTextBoxValues()
      {
         return new string[] {
            accountTextBox.Text, firstNameTextBox.Text,
            lastNameTextBox.Text, balanceTextBox.Text};
      }
   }
}
