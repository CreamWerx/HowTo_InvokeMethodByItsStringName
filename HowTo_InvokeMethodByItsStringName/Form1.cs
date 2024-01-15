using System.Reflection;

namespace HowTo_InvokeMethodByItsStringName;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        //The string names of 2 methods
        comboBox1.Items.Add("MyMethod");
        comboBox1.Items.Add("MyMethod2");
        comboBox1.SelectedValueChanged += ComboBox1_SelectedValueChanged;
    }


    private void ComboBox1_SelectedValueChanged(object? sender, EventArgs e)
    {
        MethodInfo methodInfo = typeof(MyMethods).GetMethod(comboBox1.Text);
        if (string.IsNullOrWhiteSpace(textBox1.Text))
        {
            try
            {
                methodInfo.Invoke(this, null);
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("MyMethod2 should only be selected when there is text to pass"); 
            }
        }

        try
        {
            methodInfo.Invoke(this, new object[] { textBox1.Text });
        }
        catch (Exception)
        {
            MessageBox.Show("MyMethod should only be selected when there are no arguments to pass");
        }
    }
}

public static class MyMethods
{
    public static void MyMethod()
    {
        MessageBox.Show("No args");
    }
    public static void MyMethod2(string message)
    {
        MessageBox.Show(message);
    }
}