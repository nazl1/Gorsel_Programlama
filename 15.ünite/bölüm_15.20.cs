

using System.Windows.Forms;

namespace CheckedListBoxTest
{
   // Form uses a checked ListBox to add items to a display ListBox
   public partial class CheckedListBoxTestForm : Form
   {
      // constructor
      public CheckedListBoxTestForm()
      {
         InitializeComponent();
      }

      // item checked or unchecked
      // add or remove from display ListBox
      private void itemCheckedListBox_ItemCheck(
         object sender, ItemCheckEventArgs e)
      {
         // obtain reference of selected item
         string item = itemCheckedListBox.SelectedItem.ToString();

         // if item checked, add to ListBox
         // otherwise remove from ListBox
         if (e.NewValue == CheckState.Checked)
         {
            displayListBox.Items.Add(item);
         }
         else
         {
            displayListBox.Items.Remove(item);
         }
      }
   }
} 
