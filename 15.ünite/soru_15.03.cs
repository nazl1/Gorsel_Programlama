using System;
using System.Drawing;
using System.Windows.Forms;

public class ComboBoxAddRemoveForm : Form
{
    private ComboBox comboProducts;
    private TextBox txtNewItem;
    private Button btnAdd;
    private Label lblCount;

    public ComboBoxAddRemoveForm()
    {
        Text = "Home Décor Products";
        Width = 400;
        Height = 300;

        comboProducts = new ComboBox
        {
            Left = 50,
            Top = 30,
            Width = 250,
            DropDownStyle = ComboBoxStyle.DropDownList
        };

        // Initial items
        comboProducts.Items.Add("Wall Clock");
        comboProducts.Items.Add("Table Lamp");
        comboProducts.Items.Add("Flower Vase");
        comboProducts.Items.Add("Photo Frame");

        comboProducts.SelectedIndexChanged += RemoveSelectedItem;

        txtNewItem = new TextBox
        {
            Left = 50,
            Top = 80,
            Width = 250
        };

        btnAdd = new Button
        {
            Text = "Add Item",
            Left = 50,
            Top = 120,
            Width = 250
        };
        btnAdd.Click += AddItem;

        lblCount = new Label
        {
            Left = 50,
            Top = 170,
            Width = 250,
            Text = $"Item Count: {comboProducts.Items.Count}"
        };

        Controls.Add(comboProducts);
        Controls.Add(txtNewItem);
        Controls.Add(btnAdd);
        Controls.Add(lblCount);
    }

    private void AddItem(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(txtNewItem.Text))
        {
            comboProducts.Items.Add(txtNewItem.Text);
            txtNewItem.Clear();
            UpdateCount();
        }
    }

    private void RemoveSelectedItem(object sender, EventArgs e)
    {
        if (comboProducts.SelectedIndex != -1)
        {
            comboProducts.Items.RemoveAt(comboProducts.SelectedIndex);
            UpdateCount();
        }
    }

    private void UpdateCount()
    {
        lblCount.Text = $"Item Count: {comboProducts.Items.Count}";
    }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new ComboBoxAddRemoveForm());
    }
}