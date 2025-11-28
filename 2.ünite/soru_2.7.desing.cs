namespace Nazli
{
    partial class Stop_Watch_Form
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
            menuStrip1 = new MenuStrip();
            sTARTToolStripMenuItem = new ToolStripMenuItem();
            sTOPToolStripMenuItem = new ToolStripMenuItem();
            lAPToolStripMenuItem = new ToolStripMenuItem();
            rESETToolStripMenuItem = new ToolStripMenuItem();
            eXITToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            richTextBox1 = new RichTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            
            menuStrip1.Items.AddRange(new ToolStripItem[] { sTARTToolStripMenuItem, sTOPToolStripMenuItem, lAPToolStripMenuItem, rESETToolStripMenuItem, eXITToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(262, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            
            sTARTToolStripMenuItem.Name = "sTARTToolStripMenuItem";
            sTARTToolStripMenuItem.Size = new Size(52, 20);
            sTARTToolStripMenuItem.Text = "START";
            
            sTOPToolStripMenuItem.Name = "sTOPToolStripMenuItem";
            sTOPToolStripMenuItem.Size = new Size(47, 20);
            sTOPToolStripMenuItem.Text = "STOP";
            
            lAPToolStripMenuItem.Name = "lAPToolStripMenuItem";
            lAPToolStripMenuItem.Size = new Size(40, 20);
            lAPToolStripMenuItem.Text = "LAP";
            
            rESETToolStripMenuItem.Name = "rESETToolStripMenuItem";
            rESETToolStripMenuItem.Size = new Size(51, 20);
            rESETToolStripMenuItem.Text = "RESET";
            
            eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            eXITToolStripMenuItem.Size = new Size(42, 20);
            eXITToolStripMenuItem.Text = "EXIT";
            
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(52, 76);
            label1.Name = "label1";
            label1.Size = new Size(162, 32);
            label1.TabIndex = 1;
            label1.Text = "00 : 00 : 00 . 0";
            label1.Click += label1_Click;
            
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(148, 47);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 2;
            label2.Text = "00 : 00 : 00 . 0";
            
            button1.Location = new Point(12, 111);
            button1.Name = "button1";
            button1.Size = new Size(75, 33);
            button1.TabIndex = 3;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            
            button2.Location = new Point(93, 111);
            button2.Name = "button2";
            button2.Size = new Size(75, 33);
            button2.TabIndex = 4;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = true;
            
            button3.Location = new Point(171, 111);
            button3.Name = "button3";
            button3.Size = new Size(75, 33);
            button3.TabIndex = 5;
            button3.Text = "Lap";
            button3.UseVisualStyleBackColor = true;
            
            richTextBox1.Location = new Point(12, 150);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(234, 96);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "Lap Details ";
            
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 263);
            Controls.Add(richTextBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Stop_Watch_Form";
            Text = "Stop_Watch_Form";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sTARTToolStripMenuItem;
        private ToolStripMenuItem sTOPToolStripMenuItem;
        private ToolStripMenuItem lAPToolStripMenuItem;
        private ToolStripMenuItem rESETToolStripMenuItem;
        private ToolStripMenuItem eXITToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private RichTextBox richTextBox1;
    }
}