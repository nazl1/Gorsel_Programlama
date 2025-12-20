using System;
using System.Drawing;
using System.Windows.Forms;

public class FontStyleCheckBoxForm : Form
{
    private Label displayLabel;

    private CheckBox boldCheckBox;
    private CheckBox italicCheckBox;
    private CheckBox underlineCheckBox;
    private CheckBox strikeoutCheckBox;

    private FontStyle currentStyle = FontStyle.Regular;

    public FontStyleCheckBoxForm()
    {
        Text = "Font Style CheckBox Demo";
        Width = 500;
        Height = 300;

        displayLabel = new Label
        {
            Text = "Object-Oriented Programming",
            AutoSize = false,
            Width = 450,
            Height = 50,
            Top = 30,
            Left = 20,
            TextAlign = ContentAlignment.MiddleCenter,
            Font = new Font("Arial", 16, currentStyle)
        };

        boldCheckBox = new CheckBox { Text = "Bold", Left = 50, Top = 120 };
        italicCheckBox = new CheckBox { Text = "Italic", Left = 150, Top = 120 };
        underlineCheckBox = new CheckBox { Text = "Underline", Left = 250, Top = 120 };
        strikeoutCheckBox = new CheckBox { Text = "Strikeout", Left = 360, Top = 120 };

        // Same event handler for all CheckBoxes
        boldCheckBox.CheckedChanged += FontStyleChanged;
        italicCheckBox.CheckedChanged += FontStyleChanged;
        underlineCheckBox.CheckedChanged += FontStyleChanged;
        strikeoutCheckBox.CheckedChanged += FontStyleChanged;

        Controls.Add(displayLabel);
        Controls.Add(boldCheckBox);
        Controls.Add(italicCheckBox);
        Controls.Add(underlineCheckBox);
        Controls.Add(strikeoutCheckBox);
    }

    private void FontStyleChanged(object sender, EventArgs e)
    {
        CheckBox cb = (CheckBox)sender;

        if (cb == boldCheckBox)
            currentStyle ^= FontStyle.Bold;
        else if (cb == italicCheckBox)
            currentStyle ^= FontStyle.Italic;
        else if (cb == underlineCheckBox)
            currentStyle ^= FontStyle.Underline;
        else if (cb == strikeoutCheckBox)
            currentStyle ^= FontStyle.Strikeout;

        displayLabel.Font = new Font(displayLabel.Font.FontFamily, 16, currentStyle);
    }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new FontStyleCheckBoxForm());
    }
}