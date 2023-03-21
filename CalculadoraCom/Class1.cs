using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCom
{
    public class Leaf : Component
    {
    private double value;

    public Leaf(double value)
    {
        this.value = value;
    }

    public double operate()
    {
        return value;
    }
}
}
