using System;
using System.Windows.Forms;

namespace WindowsForms;

public partial class Form2 : Form
{
    public Form2()
    {
        InitializeComponent();

        this.MouseClick += Form2_MouseClick;
        this.KeyDown += Form2_KeyDown;
        this.KeyPreview = true;
    }

    private void Form2_MouseClick(object? sender, MouseEventArgs e)
    {
        lblResult.Text = "Mouse Clicked!";
    }

    private void Form2_KeyDown(object? sender, KeyEventArgs e)
    {
        lblResult.Text = "Key Pressed: " + e.KeyCode;
    }
}
