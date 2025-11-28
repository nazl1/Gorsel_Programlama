namespace Nazli;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        button1 = new Button();
        button2 = new Button();
        label4 = new Label();
        SuspendLayout();
        
        label1.AutoSize = true;
        label1.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
        label1.Location = new Point(20, 18);
        label1.Name = "label1";
        label1.Size = new Size(172, 22);
        label1.TabIndex = 0;
        label1.Text = "User Login Form";
        
        label2.AutoSize = true;
        label2.Location = new Point(20, 70);
        label2.Name = "label2";
        label2.Size = new Size(44, 15);
        label2.TabIndex = 1;
        label2.Text = "User ID";
        
        label3.AutoSize = true;
        label3.Location = new Point(20, 103);
        label3.Name = "label3";
        label3.Size = new Size(57, 15);
        label3.TabIndex = 2;
        label3.Text = "Password";
        
        textBox1.Location = new Point(117, 100);
        textBox1.Name = "textBox1";
        textBox1.PasswordChar = '*';
        textBox1.Size = new Size(194, 23);
        textBox1.TabIndex = 3;
        
        textBox2.Location = new Point(117, 67);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(194, 23);
        textBox2.TabIndex = 4;
        
        button1.Location = new Point(190, 165);
        button1.Name = "button1";
        button1.Size = new Size(121, 47);
        button1.TabIndex = 5;
        button1.Text = "Login";
        button1.UseVisualStyleBackColor = true;
        
        button2.Location = new Point(26, 165);
        button2.Name = "button2";
        button2.Size = new Size(92, 47);
        button2.TabIndex = 6;
        button2.Text = "New User";
        button2.UseVisualStyleBackColor = true;
        
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 162);
        label4.Location = new Point(216, 136);
        label4.Name = "label4";
        label4.Size = new Size(95, 15);
        label4.TabIndex = 7;
        label4.Text = "Forgot Password";
        
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(358, 231);
        Controls.Add(label4);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "Form1";
        Text = "User Login Form";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox textBox1;
    private TextBox textBox2;
    private Button button1;
    private Button button2;
    private Label label4;
}