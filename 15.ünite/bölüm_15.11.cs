
using System;
using System.Windows.Forms;

namespace DateTimePickerTest
{
   // Form lets user select a drop-off date using a DateTimePicker
   // and displays an estimated delivery date
   public partial class DateTimePickerForm : Form
   {
      // constructor
      public DateTimePickerForm()
      {
         InitializeComponent();
      }

      private void dropOffDateTimePicker_ValueChanged(
         object sender, EventArgs e)
      {
         DateTime dropOffDate = dropOffDateTimePicker.Value;

         // add extra time when items are dropped off Sunday
         if (dropOffDate.DayOfWeek == DayOfWeek.Friday ||
            dropOffDate.DayOfWeek == DayOfWeek.Saturday ||
            dropOffDate.DayOfWeek == DayOfWeek.Sunday)
         {
            //estimate three days for delivery
            outputLabel.Text = dropOffDate.AddDays(3).ToLongDateString();
         }
         else
         {
            // otherwise estimate only two days for delivery
            outputLabel.Text = dropOffDate.AddDays(2).ToLongDateString();
         }
      }

      private void DateTimePickerForm_Load(object sender, EventArgs e)
      {
         // user cannot select days before today
         dropOffDateTimePicker.MinDate = DateTime.Today;

         // user can only select days up to one year in the future
         dropOffDateTimePicker.MaxDate = DateTime.Today.AddYears(1);
      }
   }
}

