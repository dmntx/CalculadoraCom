using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCom
{
    public interface Component
    {
        double operate();
    }
    public class Composite : Component
    {
    private char operation;
    private Component[] components;
    
    public Composite(char operation, Component[] components)
    {
        this.operation = operation;
            this.components = components;
    }

    public double operate()
    {
        switch (operation)
        {
            case '-':
                return components[0].operate() - components[1].operate();
            case '*':
                return components[0].operate() * components[1].operate();
            case '/':
                return components[0].operate() / components[1].operate();
            default:
                throw new Exception("Invalid operation: " + operation);
        }
    }
}
}
