
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PictureBoxTest
{
   // Form to display different images when Button is clicked
   public partial class PictureBoxTestForm : Form
   {
      private int ImageNumber { get; set; } = -1; // image to display

      // default constructor
      public PictureBoxTestForm()
      {
         InitializeComponent();
      }

      // change image whenever Next Button is clicked
      private void nextButton_Click(object sender, EventArgs e)
      {
         ImageNumber = (ImageNumber + 1) % 3; // cycles from 0 to 2

         // retrieve image from resources and load into PictureBox
         imagePictureBox.Image =
            (Image)(Properties.Resources.ResourceManager.GetObject(    
            $"image{ImageNumber}"));
      }
   }
}
