
using System;
using System.Drawing;
using System.Windows.Forms;

namespace UsingTabs
{
   // Form uses Tabs and RadioButtons to display various font settings
   public partial class UsingTabsForm : Form
   {
      // constructor
      public UsingTabsForm()
      {
         InitializeComponent();
      }

      // event handler for Black RadioButton
      private void blackRadioButton_CheckedChanged(
         object sender, EventArgs e)
      {
         displayLabel.ForeColor = Color.Black; // change color to black 
      }

      // event handler for Red RadioButton
      private void redRadioButton_CheckedChanged(
         object sender, EventArgs e)
      {
         displayLabel.ForeColor = Color.Red; // change color to red
      }

      // event handler for Green RadioButton
      private void greenRadioButton_CheckedChanged(
         object sender, EventArgs e)
      {
         displayLabel.ForeColor = Color.Green; // change color to green
      }

      // event handler for 12 point RadioButton
      private void size12RadioButton_CheckedChanged(
         object sender, EventArgs e)
      {
         // change font size to 12
         displayLabel.Font = new Font(displayLabel.Font.Name, 12);
      }

      // event handler for 16 point RadioButton
      private void size16RadioButton_CheckedChanged(
         object sender, EventArgs e)
      {
         // change font size to 16
         displayLabel.Font = new Font(displayLabel.Font.Name, 16);
      }

      // event handler for 20 point RadioButton
      private void size20RadioButton_CheckedChanged(
         object sender, EventArgs e)
      {
         // change font size to 20
         displayLabel.Font = new Font(displayLabel.Font.Name, 20);
      }

      // event handler for Hello! RadioButton
      private void helloRadioButton_CheckedChanged(
         object sender, EventArgs e)
      {
         displayLabel.Text = "Hello!"; // change text to Hello!
      }

      // event handler for Goodbye! RadioButton
      private void goodbyeRadioButton_CheckedChanged(
         object sender, EventArgs e)
      {
         displayLabel.Text = "Goodbye!"; // change text to Goodbye!
      }
   }
}

