
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MenuTest
{
   // our Form contains a Menu that changes the font color
   // and style of the text displayed in Label
   public partial class MenuTestForm : Form
   {
      // constructor
      public MenuTestForm()
      {
         InitializeComponent();
      }

      // display MessageBox when About ToolStripMenuItem is selected
      private void aboutToolStripMenuItem_Click(
         object sender, EventArgs e)
      {
         MessageBox.Show("This is an example\nof using menus.", "About",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
      }

      // exit program when Exit ToolStripMenuItem is selected
      private void exitToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

      // reset checkmarks for Color ToolStripMenuItems
      private void ClearColor()
      {
         // clear all checkmarks
         blackToolStripMenuItem.Checked = false;
         blueToolStripMenuItem.Checked = false;
         redToolStripMenuItem.Checked = false;
         greenToolStripMenuItem.Checked = false;
      }

      // update Menu state and color display black
      private void blackToolStripMenuItem_Click(
         object sender, EventArgs e)
      {
         // reset checkmarks for Color ToolStripMenuItems
         ClearColor();

         // set color to Black
         displayLabel.ForeColor = Color.Black;
         blackToolStripMenuItem.Checked = true;
      }

      // update Menu state and color display blue
      private void blueToolStripMenuItem_Click(object sender, EventArgs e)
      {
         // reset checkmarks for Color ToolStripMenuItems
         ClearColor();

         // set color to Blue
         displayLabel.ForeColor = Color.Blue;
         blueToolStripMenuItem.Checked = true;
      }

      // update Menu state and color display red
      private void redToolStripMenuItem_Click(
         object sender, EventArgs e)
      {
         // reset checkmarks for Color ToolStripMenuItems
         ClearColor();

         // set color to Red
         displayLabel.ForeColor = Color.Red;
         redToolStripMenuItem.Checked = true;
      }

      // update Menu state and color display green
      private void greenToolStripMenuItem_Click(
         object sender, EventArgs e)
      {
         // reset checkmarks for Color ToolStripMenuItems
         ClearColor();

         // set color to Green
         displayLabel.ForeColor = Color.Green;
         greenToolStripMenuItem.Checked = true;
      }

      // reset checkmarks for Font ToolStripMenuItems
      private void ClearFont()
      {
         // clear all checkmarks
         timesToolStripMenuItem.Checked = false;
         courierToolStripMenuItem.Checked = false;
         comicToolStripMenuItem.Checked = false;
      }

      // update Menu state and set Font to Times New Roman
      private void timesToolStripMenuItem_Click(
         object sender, EventArgs e)
      {
         // reset checkmarks for Font ToolStripMenuItems
         ClearFont();

         // set Times New Roman font
         timesToolStripMenuItem.Checked = true;
         displayLabel.Font = new Font("Times New Roman", 14,
            displayLabel.Font.Style);
      }

      // update Menu state and set Font to Courier
      private void courierToolStripMenuItem_Click(
         object sender, EventArgs e)
      {
         // reset checkmarks for Font ToolStripMenuItems
         ClearFont();

         // set Courier font
         courierToolStripMenuItem.Checked = true;
         displayLabel.Font = new Font("Courier", 14,
            displayLabel.Font.Style);
      }

      // update Menu state and set Font to Comic Sans MS
      private void comicToolStripMenuItem_Click(
         object sender, EventArgs e)
      {
         // reset checkmarks for Font ToolStripMenuItems
         ClearFont();

         // set Comic Sans font
         comicToolStripMenuItem.Checked = true;
         displayLabel.Font = new Font("Comic Sans MS", 14,
            displayLabel.Font.Style);
      }

      // toggle checkmark and toggle bold style
      private void boldToolStripMenuItem_Click(object sender, EventArgs e)
      {
         // toggle checkmark
         boldToolStripMenuItem.Checked = !boldToolStripMenuItem.Checked;

         // use Xor to toggle bold, keep all other styles
         displayLabel.Font = new Font(displayLabel.Font,
            displayLabel.Font.Style ^ FontStyle.Bold);
      }

      // toggle checkmark and toggle italic style
      private void italicToolStripMenuItem_Click(
         object sender, EventArgs e)
      {
         // toggle checkmark
         italicToolStripMenuItem.Checked =
            !italicToolStripMenuItem.Checked;

         // use Xor to toggle italic, keep all other styles
         displayLabel.Font = new Font(displayLabel.Font,
            displayLabel.Font.Style ^ FontStyle.Italic);
      }
   }
}
