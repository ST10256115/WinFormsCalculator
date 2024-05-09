namespace WinFormsCalculator
{
    public partial class Form1 : Form


    {

        private Calculator calculator = new Calculator();
        public Form1()
        {
            InitializeComponent();
            InitializeCalculator();
        }

        private void InitializeCalculator()
        {
            calculator.OperationPerformed += (operation, result) =>
            {
                MessageBox.Show($"Operation: {operation}, Result: {result}");
            };
        }
        private void PerformOperation(Func<double, double, double> operation, string operationName)
        {
            double num1 = double.Parse(textBox1.Text);
            double num2 = double.Parse(textBox2.Text);
            calculator.PerformOperation(num1, num2, operation, operationName);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PerformOperation((x, y) => x + y, "Addition");
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            PerformOperation((x, y) => x - y, "Subtraction");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            PerformOperation((x, y) => x * y, "Multiplication");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            PerformOperation((x, y) =>
            {
                if (y == 0)
                {
                    MessageBox.Show("Cannot divide by zero!");
                    return 0;
                }
                return x / y;
            }, "Division");

        }
    }
}
