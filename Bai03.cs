using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Lab02
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            using (var fs = new FileStream("input3.txt", FileMode.Open, FileAccess.Read))
            using (var reader = new StreamReader(fs))
            {
                txtFileContent.Text = reader.ReadToEnd();
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            using (var fs = new FileStream("output3.txt", FileMode.OpenOrCreate, FileAccess.Write))
            using (var writer = new StreamWriter(fs))
            {
                var fileContent = txtFileContent.Text;
                var lines = fileContent.Split('\n');

                foreach (var line in lines.Select(l => l.Trim()).Where(l => !string.IsNullOrEmpty(l)))
                {
                    var postfix = InfixToPostfix(line);
                    var result = EvaluatePostfix(postfix);
                    result = Math.Round(result, 2);
                    writer.WriteLine($"{line} = {result}");
                }
            }
        }

        internal static int Prec(char ch)
        {
            return ch switch
            {
                '(' => 0,
                '+' or '-' => 1,
                '*' or '/' => 2,
                _ => 3,
            };
        }

        public static string InfixToPostfix(string infix)
        {
            var result = "";
            var stack = new Stack<char>();

            foreach (var c in infix)
            {
                if (char.IsLetterOrDigit(c))
                {
                    result += c;
                }
                else if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        result += stack.Pop();
                    }
                    stack.Pop(); 
                }
                else
                {
                    while (stack.Count > 0 && Prec(c) <= Prec(stack.Peek()))
                    {
                        result += stack.Pop();
                    }
                    stack.Push(c);
                }
            }

            while (stack.Count > 0)
            {
                result += stack.Pop();
            }

            return result;
        }

        public static double EvaluatePostfix(string postfix)
        {
            var stack = new Stack<double>();
            var tokens = postfix.Split(' ');

            Dictionary<string, Func<double, double, double>> operations = new Dictionary<string, Func<double, double, double>>()
    {
        {"+", (val1, val2) => val2 + val1},
        {"-", (val1, val2) => val2 - val1},
        {"*", (val1, val2) => val2 * val1},
        {"/", (val1, val2) => {
            if (val1 == 0)
                throw new DivideByZeroException("Invalid postfix expression: Division by zero.");
            return val2 / val1;
        }},
    };

            foreach (var token in tokens)
            {
                if (string.IsNullOrEmpty(token))
                {
                    continue;
                }
                else if (char.IsDigit(token[0]))
                {
                    stack.Push(double.Parse(token));
                }
                else if (operations.ContainsKey(token))
                {
                    var val1 = stack.Pop();
                    var val2 = stack.Pop();
                    stack.Push(operations[token](val1, val2));
                }
               
            }

            return stack.Pop();
        }

    }
}
