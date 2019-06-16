// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Generator.Bind.Overloading;
using Generator.Common;
using Generator.Common.Builders;
using Generator.Common.Functions;

namespace Bind.Overloaders
{
    /// <summary>
    /// Creates <see cref="IntPtr" /> return value overloads for functions returning a void pointer (of any depth).
    /// </summary>
    public class VoidPointerReturnValueOverloader : IFunctionOverloader
    {
        /// <inheritdoc />
        public IEnumerable<Overload> CreateOverloads(Function function)
        {
            if (!function.ReturnType.IsVoidPointer())
            {
                yield break;
            }

            var newReturnType = new TypeSignatureBuilder(function.ReturnType)
                .WithIndirectionLevel(0)
                .WithName(nameof(IntPtr))
                .Build();

            yield return Cast
            (
                new FunctionSignatureBuilder(function)
                    .WithReturnType(newReturnType)
                    .WithName(function.Name + "Ptr")
                    .Build(),
                function
            );
        }

        private static Overload Cast
        (
            Function function,
            Function oldFunction
        )
        {
            var sb = new StringBuilder();
            sb.Append("return (IntPtr) " + oldFunction.Name + "(");
            sb.Append(string.Join(", ", function.Parameters.Select(x => ConvertName(x.Name))));
            sb.AppendLine(");");
            return new Overload(function, sb);
        }

        private static string ConvertName(string argName)
        {
            return Utilities.CSharpKeywords.Contains(argName) ? "@" + argName : argName;
        }
    }
}
