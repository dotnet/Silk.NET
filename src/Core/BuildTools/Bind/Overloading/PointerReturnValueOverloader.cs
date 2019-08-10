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
    public class PointerReturnValueOverloader : IFunctionOverloader
    {
        /// <inheritdoc/>
        public IEnumerable<Overload> CreateOverloads(Function function)
        {
            if (!function.ReturnType.IsIntPtr())
            {
                yield break;
            }

            var newReturnType = new TypeSignatureBuilder(function.ReturnType)
                .WithIndirectionLevel(1)
                .WithName("void")
                .Build();

            yield return Cast(
                new FunctionSignatureBuilder(function)
                    .WithReturnType(newReturnType)
                    .WithName(function.Name + "AsPointer")
                    .Build(),
                function);
        }

        private static Overload Cast(
            Function function,
            Function oldFunction)
        {
            var sb = new StringBuilder();
            sb.AppendLine("// PointerReturnValueOverloader");
            sb.Append("return (void*) " + oldFunction.Name + "(");
            sb.Append(string.Join(", ", function.Parameters.Select(x => ConvertName(x.Name))));
            sb.AppendLine(");");
            return new Overload(function, sb, true);
        }

        private static string ConvertName(string argName)
        {
            return Utilities.CSharpKeywords.Contains(argName) ? "@" + argName : argName;
        }
    }
}
