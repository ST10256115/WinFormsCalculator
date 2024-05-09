using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCalculator
{
    internal class Calculator
    {
        public delegate void OperationPerformedEventHandler(string operation, double result);
        public event OperationPerformedEventHandler OperationPerformed;

        public void PerformOperation(double num1, double num2, Func<double, double, double> operation, string operationName)
        {
            double result = operation(num1, num2);
            OnOperationPerformed(operationName, result);
        }

        private void OnOperationPerformed(string operation, double result)
        {
            OperationPerformed?.Invoke(operation, result);
        }
    }
}
