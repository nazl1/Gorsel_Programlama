
using System;
using System.Windows.Forms;

namespace SimpleEventExample
{
   // Form that shows a simple event handler
   public partial class SimpleEventExampleForm : Form
   {
      // default constructor
      public SimpleEventExampleForm()
      {
         InitializeComponent();
      } 

      // handles click event of Button clickButton
      private void clickButton_Click(object sender, EventArgs e)
      {
         MessageBox.Show("Button was clicked.");
      } 
   } 
} 