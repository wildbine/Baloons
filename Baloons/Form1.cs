namespace Baloons;
public partial class Form1 : Form, IHelper
{
    private Animator a;
    public Form1()
    {
        InitializeComponent();
        a = new Animator(panel1.Size, panel1.CreateGraphics());
        IHelper.graphics = panel1.CreateGraphics();
        IHelper.containerSize = panel1.Size;
        a.Start();
        a.OnBallsCountChanged += TextLableChanged;
    }

    private void panel1_MouseClick(object sender, MouseEventArgs e)
    {
        a.AddCircle(e.Location);
    }

    private void panel1_Resize(object sender, EventArgs e)
    {
        IHelper.containerSize = panel1.Size;
        IHelper.graphics = panel1.CreateGraphics();
        IHelper.Resized = true;
    }

    private void numericUpDown1_ValueChanged(object sender, EventArgs e)
    {
        IHelper.speed = (int)numericUpDown1.Value == 1 ? 1 : (int)numericUpDown1.Value * 2;
    }

    public void TextLableChanged()
    {
        if (ballsCount.InvokeRequired)
        {
            ballsCount.Invoke(TextLableChanged);
        }
        else
        {
            ballsCount.Text = IHelper.circs.Count.ToString();
        }
    }

    private void constSpeed_MouseClick(object sender, MouseEventArgs e)
    {
        IHelper.ConstSpeed = constSpeed.Checked;
    }

    private void diffSpeed_MouseClick(object sender, MouseEventArgs e)
    {
        IHelper.ConstSpeed = !diffSpeed.Checked;
    }

    private void clearAll_Click(object sender, EventArgs e)
    {
        a.Stop();
    }
}
