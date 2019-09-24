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
        public IEnumerable<Overload> CreateOverloads(Function function)
        {
            if (function.ReturnType.ToString() == "char*" || function.ReturnType.ToString() == "byte*")
            {
                var sb = new StringBuilder();
                sb.Append("return System.Runtime.InteropServices.Marshal.PtrToStringAnsi((IntPtr) ");
                sb.Append($"{function.Name}(");
                sb.Append(string.Join(", ", function.Parameters.Select(Convert)));
                sb.AppendLine("));");
                yield return new Overload
                (
                    new FunctionSignatureBuilder(function)
                        .WithReturnType(new Type {Name = "string"})
                        .WithName(function.Name + "Managed")
                        .Build(),
                    sb,
                    true
                );
            }

            string Convert(Parameter x)
            {
                var pre = x.Type.IsOut ? "out " : string.Empty;
                return pre + (Utilities.CSharpKeywords.Contains(x.Name) ? $"@{x.Name}" : x.Name);
            }
        }
    }
}
