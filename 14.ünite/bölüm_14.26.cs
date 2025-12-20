
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CheckBoxTest
{
   // Form contains CheckBoxes to allow the user to modify sample text
   public partial class CheckBoxTestForm : Form
   {
      // default constructor
      public CheckBoxTestForm()
      {
         InitializeComponent();
      }

      // toggle the font style between bold and        
      // not bold based on the  current setting        
      private void boldCheckBox_CheckedChanged(object sender, EventArgs e)
      {
         outputLabel.Font = new Font(outputLabel.Font,
            outputLabel.Font.Style ^ FontStyle.Bold);
      }

      // toggle the font style between italic and       
      // not italic based on the current setting        
      private void italicCheckBox_CheckedChanged(
         object sender, EventArgs e)
      {
         outputLabel.Font = new Font(outputLabel.Font,
            outputLabel.Font.Style ^ FontStyle.Italic);
      }
   }
} 