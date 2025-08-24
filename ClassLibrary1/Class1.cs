using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        ClassLibrary2.MathEngine mathEngine = new ClassLibrary2.MathEngine();

        public int Calculate(int operand1, int operand2, string operation)
        {
            switch(operation)
            {
                case "+": return mathEngine.Add(operand1, operand2);
                case "-": return mathEngine.Subtract(operand1, operand2);
                case "*": return mathEngine.Multiply(operand1, operand2);
                case "/": return mathEngine.Divide(operand1, operand2);
                default: throw new NotImplementedException();
            }

        }
    }
}
