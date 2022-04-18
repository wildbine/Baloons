using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baloons;

    public interface IHelper
{
    private protected static Dictionary<Circle, (float, float)> direction = new(); //направление шарика
    private protected static Dictionary<Circle, int> numberOfCollusions = new(); //кол-во ударов о стенку шарику
    private protected static List<Circle> circs = new(); //список шариков
    private protected static int speed = 1;
    private protected static Size containerSize = new();
    private protected static bool Resized = false;
    private protected static Graphics? graphics;
    private protected static bool ConstSpeed = true;
}

