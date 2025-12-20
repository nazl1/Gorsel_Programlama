using System;
using System.Drawing;
using System.Windows.Forms;

public class LengthConversionForm : Form
{
    private TextBox txtMeters;
    private TextBox txtFeet;
    private TextBox txtInches;
    private TextBox txtCentimeters;

    private Label lblMeters;
    private Label lblFeet;
    private Label lblInches;
    private Label lblCentimeters;

    public LengthConversionForm()
    {
        Text = "Length Conversion";
        Width = 400;
        Height = 300;

        lblMeters = new Label
        {
            Text = "Meters:",
            Left = 30,
            Top = 30,
            Width = 100
        };

        txtMeters = new TextBox
        {
            Left = 150,
            Top = 30,
            Width = 150
        };
        txtMeters.TextChanged += ConvertLengths;

        lblFeet = new Label
        {
            Text = "Feet:",
            Left = 30,
            Top = 70,
            Width = 100
        };

        txtFeet = new TextBox
        {
            Left = 150,
            Top = 70,
            Width = 150,
            ReadOnly = true
        };

        lblInches = new Label
        {
            Text = "Inches:",
            Left = 30,
            Top = 110,
            Width = 100
        };

        txtInches = new TextBox
        {
            Left = 150,
            Top = 110,
            Width = 150,
            ReadOnly = true
        };

        lblCentimeters = new Label
        {
            Text = "Centimeters:",
            Left = 30,
            Top = 150,
            Width = 100
        };

        txtCentimeters = new TextBox
        {
            Left = 150,
            Top = 150,
            Width = 150,
            ReadOnly = true
        };

        Controls.Add(lblMeters);
        Controls.Add(txtMeters);
        Controls.Add(lblFeet);
        Controls.Add(txtFeet);
        Controls.Add(lblInches);
        Controls.Add(txtInches);
        Controls.Add(lblCentimeters);
        Controls.Add(txtCentimeters);
    }

    private void ConvertLengths(object sender, EventArgs e)
    {
        if (double.TryParse(txtMeters.Text, out double meters))
        {
            double feet = meters * 3.28084;
            double inches = meters * 39.37;
            double centimeters = meters * 100;

            txtFeet.Text = feet.ToString("F2");
            txtInches.Text = inches.ToString("F2");
            txtCentimeters.Text = centimeters.ToString("F2");
        }
        else
        {
            txtFeet.Clear();
            txtInches.Clear();
            txtCentimeters.Clear();
        }
    }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new LengthConversionForm());
    }
}