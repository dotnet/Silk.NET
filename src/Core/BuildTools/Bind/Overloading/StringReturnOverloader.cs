// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Linq;
using System.Text;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Bind.Overloading
{
    public class StringReturnOverloader : IFunctionOverloader
    {
        public IEnumerable<ImplementedFunction> CreateOverloads(Function function)
        {
            if (function.ReturnType.ToString() == "char*" || function.ReturnType.ToString() == "byte*")
            {
                var sb = new StringBuilder();
                sb.Append($"return Marshal.PtrToStringAnsi((IntPtr) {function.Name}(");
                sb.Append(string.Join(", ", function.Parameters.Select(Convert)));
                sb.AppendLine("));");
                var sig = new FunctionSignatureBuilder(function).WithReturnType(new Type {Name = "string"}).WithName(function.Name + "S").Build();
                yield return new ImplementedFunction(sig, sb, true);
            }
        }

        private static string Convert(Parameter param)
        {
            return param.Type.IsOut ? $"out {ConvertName(param.Name)}" : ConvertName(param.Name);
        }

        private static string ConvertName(string argName)
        {
            return Utilities.CSharpKeywords.Contains(argName) ? $"@{argName}" : argName;
        }
    }
}
