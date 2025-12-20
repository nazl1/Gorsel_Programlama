using System;
using System.Drawing;
using System.Windows.Forms;

public class SortedStringsForm : Form
{
    private TextBox txtInput;
    private Button btnAdd;
    private ListBox listStrings;
    private Label lblInfo;

    public SortedStringsForm()
    {
        Text = "Sorting Strings";
        Width = 400;
        Height = 300;

        lblInfo = new Label
        {
            Text = "Enter a string:",
            Left = 30,
            Top = 30,
            Width = 120
        };

        txtInput = new TextBox
        {
            Left = 150,
            Top = 30,
            Width = 180
        };

        btnAdd = new Button
        {
            Text = "Add",
            Left = 150,
            Top = 70,
            Width = 180
        };
        btnAdd.Click += AddString;

        listStrings = new ListBox
        {
            Left = 30,
            Top = 120,
            Width = 300,
            Height = 100,
            Sorted = true   // Ensures automatic sorting
        };

        Controls.Add(lblInfo);
        Controls.Add(txtInput);
        Controls.Add(btnAdd);
        Controls.Add(listStrings);
    }

    private void AddString(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(txtInput.Text))
        {
            listStrings.Items.Add(txtInput.Text);
            txtInput.Clear();
            txtInput.Focus();
        }
    }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new SortedStringsForm());
    }
}