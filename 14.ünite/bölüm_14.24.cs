
using System;
using System.Windows.Forms;

namespace GroupBoxPanelExample
{
   // Form that displays a GroupBox and a Panel
   public partial class GroupBoxPanelExampleForm : Form
   {
      // default constructor
      public GroupBoxPanelExampleForm()
      {
         InitializeComponent();
      }

      // event handler for Hi Button
      private void hiButton_Click(object sender, EventArgs e)
      {
         messageLabel.Text = "Hi pressed"; // change text in Label
      }

      // event handler for Bye Button
      private void byeButton_Click(object sender, EventArgs e)
      {
         messageLabel.Text = "Bye pressed"; // change text in Label
      }

      // event handler for Far Left Button
      private void leftButton_Click(object sender, EventArgs e)
      {
         messageLabel.Text = "Far Left pressed"; // change text in Label
      }

      // event handler for Far Right Button
      private void rightButton_Click(object sender, EventArgs e)
      {
         messageLabel.Text = "Far Right pressed"; // change text in Label
      }
   }
}
