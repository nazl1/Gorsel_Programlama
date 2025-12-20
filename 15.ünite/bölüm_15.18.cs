
using System;
using System.Windows.Forms;

namespace ListBoxTest
{
   // Form uses a TextBox and Buttons to add,
   // remove, and clear ListBox items
   public partial class ListBoxTestForm : Form
   {
      // constructor
      public ListBoxTestForm()
      {
         InitializeComponent();
      }

      // add new item to ListBox (text from input TextBox)
      // and clear input TextBox
      private void addButton_Click(object sender, EventArgs e)
      {
         displayListBox.Items.Add(inputTextBox.Text);
         inputTextBox.Clear();
      }

      // remove item if one is selected
      private void removeButton_Click(object sender, EventArgs e)
      {
         // check whether item is selected; if so, remove
         if (displayListBox.SelectedIndex != -1)
         {
            displayListBox.Items.RemoveAt(displayListBox.SelectedIndex);
         }
      }

      // clear all items in ListBox
      private void clearButton_Click(object sender, EventArgs e)
      {
         displayListBox.Items.Clear();
      }

      // exit app
      private void exitButton_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }
   }
}
