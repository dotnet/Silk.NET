#region

using System;
using System.Text;

#endregion

namespace ConvertHelper
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine
                ("Hey! I'll try to convert any normal C# expression to a Silk.Net.Maths.Scalar using expression!");
            Console.WriteLine("Simply paste your code below, and I'll translate line-by-line. I'll try to keep `,`");
            Console.WriteLine("A single empty line will start translation");

            var tokenizer = new ArithmeticExpressionTokenizer();

            while (true)
            {
                var sb = new StringBuilder();
                while (true)
                {
                    var i = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(i))
                    {
                        break;
                    }

                    sb.AppendLine(i);
                }

                var result = tokenizer.TryTokenize(sb.ToString());
                if (!result.HasValue)
                {
                    Console.WriteLine(result.FormatErrorMessageFragment());
                    continue;
                }

                var transform = ArithmeticExpressionParser.Transform(result.Value);
                if (!transform.HasValue)
                {
                    Console.WriteLine(result.FormatErrorMessageFragment());
                    continue;
                }

                Console.WriteLine(transform.Value);
            }
        }
    }
}
