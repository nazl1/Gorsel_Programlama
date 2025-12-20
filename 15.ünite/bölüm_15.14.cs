
using System;
using System.Windows.Forms;

namespace LinkLabelTest
{
   // Form using LinkLabels to browse the C:\ drive,
   // load a web page and run Notepad
   public partial class LinkLabelTestForm : Form
   {
      // constructor
      public LinkLabelTestForm()
      {
         InitializeComponent();
      } 
   
      // browse C:\ drive
      private void cDriveLinkLabel_LinkClicked(object sender,
         LinkLabelLinkClickedEventArgs e)
      {
         // change LinkColor after it has been clicked
         cDriveLinkLabel.LinkVisited = true;         
                                                    
         System.Diagnostics.Process.Start(@"C:\");
      } 
   
      // load www.deitel.com in web browser
      private void deitelLinkLabel_LinkClicked(object sender,
         LinkLabelLinkClickedEventArgs e)
      {
         // change LinkColor after it has been clicked
         deitelLinkLabel.LinkVisited = true;                         
                                                                     
         System.Diagnostics.Process.Start("http://www.deitel.com");
      } 
   
      // run app Notepad
      private void notepadLinkLabel_LinkClicked(object sender,
         LinkLabelLinkClickedEventArgs e)
      {
         // change LinkColor after it has been clicked
         notepadLinkLabel.LinkVisited = true;          
                                                       
         // program called as if in run                
         // menu and full path not needed              
         System.Diagnostics.Process.Start("notepad");
      } 
   } 
} 