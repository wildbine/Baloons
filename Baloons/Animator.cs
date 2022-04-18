using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baloons;

public delegate void BallsCountChanged();
public class Animator : IHelper
{
    public event BallsCountChanged OnBallsCountChanged;
    private Size cSize;
    private BufferedGraphics bg;
    private Graphics tempg;
    private Graphics _g;
    private Thread? t;
    private object obj = new object();

    public Size CSize { get => cSize; set => cSize = value; }
    private Graphics? g
    {
        get => _g;
        set
        {
            _g = value;
            bg = BufferedGraphicsManager.Current.Allocate(
                g, Rectangle.Ceiling(g.VisibleClipBounds)
            );
            bg.Graphics.Clear(Color.White);
        }
    }

    public Animator(Size containerSize, Graphics g)
    {
        Rectangle rect = new(new Point(0, 0), new Size(containerSize.Width, containerSize.Height));
        Update(g, rect);
    }

    public void Update(Graphics? g, Rectangle rect)
    {
        this.g = g;
        cSize = rect.Size;
        Monitor.Enter(obj);
        bg = BufferedGraphicsManager.Current.Allocate(
            this.g,
            new Rectangle(new Point(0, 0), CSize));
        Monitor.Exit(obj);
        Monitor.Enter(IHelper.circs);
        foreach (var c in IHelper.circs)
        {
            c.Update(IHelper.containerSize);
        }
        Monitor.Exit(IHelper.circs);
    }

    public void AddCircle(Point location)
    {
        Random random = new Random();
        var c = new Circle(cSize, location);
        c.Animate();
        IHelper.circs.Add(c);
        int x, y; var del = IHelper.ConstSpeed == true ? 5 : 1;
        x = random.Next(-20 / del, 20 / del); y = random.Next(-20 / del, 20 / del);
        IHelper.direction.Add(c, (
        x == 0 ? (int)(Math.Pow(-1, random.Next(0, 1))) : x, //direction to X 
        y == 0 ? (int)(Math.Pow(-1, random.Next(0, 1))) : y)); //direction to Y
        IHelper.numberOfCollusions.Add(c, 0);
        OnBallsCountChanged();
    }

    public void Start()
    {
        if (t == null || !t.IsAlive)
        {
            t = new Thread(() =>
            {
                lock (bg)
                {
                    tempg = bg.Graphics;
                }
                do
                {
                    if (IHelper.Resized)
                        Resize();
                    tempg.Clear(Color.White);
                    for (int i = 0; i < IHelper.circs.Count; ++i)
                    {
                        if (!IHelper.circs[i].IsAlive)
                        {
                            IHelper.direction.Remove(IHelper.circs[i]);
                            IHelper.numberOfCollusions.Remove(IHelper.circs[i]);
                            IHelper.circs.Remove(IHelper.circs[i]);
                            OnBallsCountChanged();
                        }
                    }
                    for (int i = 0; i < IHelper.circs.Count; i++)
                    {
                        IHelper.circs[i].Paint(tempg);
                    }
                    bg.Render(g);
                    Thread.Sleep(5);
                } while (true);
            });
            t.IsBackground = true;
            t.Start();
        }
    }
    public void Resize()
    {
        Update(IHelper.graphics, new Rectangle(new Point(0, 0), IHelper.containerSize));
        lock (bg)
        {
            tempg = bg.Graphics;
        }
        IHelper.Resized = false;
    }

    public void Stop()
    {
        Monitor.Enter(IHelper.circs);
        foreach (var c in IHelper.circs)
            c.Stop();
        Monitor.Exit(IHelper.circs);
    }
}
