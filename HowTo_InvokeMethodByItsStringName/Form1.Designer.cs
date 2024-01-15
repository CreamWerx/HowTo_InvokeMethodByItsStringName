namespace HowTo_InvokeMethodByItsStringName;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        comboBox1 = new ComboBox();
        textBox1 = new TextBox();
        SuspendLayout();
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new Point(24, 24);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(121, 36);
        comboBox1.TabIndex = 0;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(207, 24);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(100, 34);
        textBox1.TabIndex = 1;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(11F, 28F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(textBox1);
        Controls.Add(comboBox1);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ComboBox comboBox1;
    private TextBox textBox1;
}
