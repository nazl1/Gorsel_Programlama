
using System;
using System.Windows.Forms;

namespace LabelTextBoxButtonTest
{
   // Form that creates a password TextBox and
   // a Label to display TextBox contents
   public partial class LabelTextBoxButtonTestForm : Form
   {
      // default constructor
      public LabelTextBoxButtonTestForm()
      {
         InitializeComponent();
      }

      // display user input in Label
      private void displayPasswordButton_Click(object sender, EventArgs e)
      {
         // display the text that the user typed
         displayPasswordLabel.Text = inputPasswordTextBox.Text;
      } 
   } 
} 
