using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baloons;
public class Circle : IHelper
{
    double eps = 0.000001;
    private PointF _pos;
    private int _diameter;
    private Size _containerSize;
    public Thread? t;
    private Color _color;
    Random random = new Random();

    public bool IsAlive => t?.IsAlive == true;
    public Color Color => _color;

    public Circle(Size containerSize, Point location)
    {
        _pos = location;
        _color = Color.FromArgb(random.Next(50, 255), random.Next(1, 255), random.Next(1, 255), random.Next(1, 255));
        _diameter = random.Next(100, 200);
        _containerSize = containerSize;
        if (_pos.X < _diameter/2) _pos.X = _diameter / 2;
        else if (_pos.X > _containerSize.Width - _diameter/2) _pos.X = _containerSize.Width - _diameter/2;
        if (_pos.Y < _diameter / 2) _pos.Y = _diameter / 2;
        else if (_pos.Y > _containerSize.Height - _diameter / 2) _pos.Y = _containerSize.Height - _diameter / 2;
    }

    public bool IsBallInsidePanel()
    {
        Point center = new(_containerSize.Width / 2, _containerSize.Height / 2);
        if (Math.Abs(_pos.X - _diameter / 2 - center.X) + _diameter / 5 < _containerSize.Width / 2 &&
            Math.Abs(_pos.Y - _diameter / 2 - center.Y) + _diameter / 5 < _containerSize.Height / 2) return true;
        return false;
    }

    public void Paint(Graphics g)
    {
        var b = new SolidBrush(Color);
        g.FillEllipse(b, _pos.X - _diameter / 2, _pos.Y - _diameter / 2, _diameter, _diameter);
    }

    public void Update(Size cSize)
    {
        _containerSize = cSize;
    }

    public bool Move(bool constSpeed)
    {
        (var dx, var dy) = IHelper.direction[this];
        if ((_pos.X < (_containerSize.Width - _diameter / 2)) &&
            (_pos.X > (_diameter / 2) &&
            (_pos.Y < (_containerSize.Height - _diameter / 2)) &&
            (_pos.Y > (_diameter / 2))))
        {
            if (!constSpeed)
            {
                if ((int)dx == 0 && (int)dy == 0) return false;
                _pos.X += (dx * IHelper.speed * 0.99f);
                _pos.Y += (dy * IHelper.speed * 0.99f);
                IHelper.direction[this] = (dx * 0.99f, dy * 0.99f);
            }
            else
            {
                _pos.X += dx * IHelper.speed;
                _pos.Y += dy * IHelper.speed;
            }
            return true;
        }
        else if (IHelper.numberOfCollusions[this] < 20)
        {
            if (_pos.X >= (_containerSize.Width - _diameter / 2) || _pos.X <= _diameter / 2)
            {
                dx = -dx * 1.01f;
            }
            if (_pos.Y <= _diameter / 2 || _pos.Y >= (_containerSize.Height - _diameter / 2))
                dy = -dy * 1.01f;
            if (!constSpeed)
            {
                if ((int)dx == 0 && (int)dy == 0 || IHelper.numberOfCollusions[this] > 4) return false;
                _pos.X += (dx * IHelper.speed * 0.99f);
                _pos.Y += (dy * IHelper.speed * 0.99f);
                IHelper.direction[this] = (dx * 0.99f, dy * 0.99f);
            }
            else
            {
                _pos.X += dx * IHelper.speed;
                _pos.Y += dy * IHelper.speed;
                IHelper.direction[this] = (dx, dy);
            }
                ++IHelper.numberOfCollusions[this];
            return true;
        }
        return false;
    }

    public void Animate()
    {
        if (!t?.IsAlive ?? true)
        {
            t = new Thread(() =>
            {
                do
                {
                    if (!IsAlive)
                        break;
                    Thread.Sleep(5);
                } while (Move(IHelper.ConstSpeed));
            });
            t.IsBackground = true;
            t.Start();
        }
    }

    public void Clear(Graphics g)
    {
        var b = new SolidBrush(Color.White);
        g.FillEllipse(b, _pos.X, _pos.Y, _diameter, _diameter);
    }

    public void Stop()
    {
        this.t = null;
    }
}

