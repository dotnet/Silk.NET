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
    public class PointerParameterOverloader : IFunctionOverloader
    {
        /// <inheritdoc/>
        public IEnumerable<ImplementedFunction> CreateOverloads(Function function)
        {
            // we can't have the void pointer parameter overloader separate otherwise it'll run forever
            // i.e. PointerParameterOverloader will turn IntPtr to void*
            //      VoidPointerParameterOverloader will turn void* to IntPtr
            //      etc
            foreach (var overload in CreateOverloadsVoidPtr(function))
            {
                yield return overload;
            }

            if (!function.Parameters.Any(p => p.Type.IsIntPtr()))
            {
                yield break;
            }

            var baseParameters = function.Parameters;

            var newIntPtrParameters = new List<Parameter>(baseParameters);
            var newGenericArray1DParameters = new List<Parameter>(baseParameters);
            var newGenericArray2DParameters = new List<Parameter>(baseParameters);
            var newGenericArray3DParameters = new List<Parameter>(baseParameters);

            var newGenericTypeParameters = new List<GenericTypeParameter>();
            newGenericTypeParameters.AddRange(function.GenericTypeParameters);
            for (var i = 0; i < baseParameters.Count; ++i)
            {
                var parameter = baseParameters[i];
                if (!parameter.Type.IsIntPtr() || parameter.Type.IsOut)
                {
                    continue;
                }

                var genericTypeParameterName = baseParameters.Count(p => p.Type.IsIntPtr()) > 1
                    ? $"T{newGenericTypeParameters.Count + 1}" : "T";

                var genericTypeParameter = new GenericTypeParameter(
                    genericTypeParameterName,
                    new[] { "unmanaged" });

                newGenericTypeParameters.Add(genericTypeParameter);

                var newIntPtrParameterType = new TypeSignatureBuilder(parameter.Type)
                    .WithIndirectionLevel(1)
                    .WithName("void")
                    .Build();

                // TODO: Simplify and generalize this
                var newGenericArray1DParameterType = new TypeSignatureBuilder(parameter.Type)
                    .WithIndirectionLevel(0)
                    .WithArrayDimensions(1)
                    .WithName(genericTypeParameterName)
                    .Build();

                var newGenericArray2DParameterType = new TypeSignatureBuilder(parameter.Type)
                    .WithIndirectionLevel(0)
                    .WithArrayDimensions(2)
                    .WithName(genericTypeParameterName)
                    .Build();

                var newGenericArray3DParameterType = new TypeSignatureBuilder(parameter.Type)
                    .WithIndirectionLevel(0)
                    .WithArrayDimensions(3)
                    .WithName(genericTypeParameterName)
                    .Build();

                newIntPtrParameters[i] = new ParameterSignatureBuilder(parameter)
                    .WithType(newIntPtrParameterType)
                    .Build();

                newGenericArray1DParameters[i] = new ParameterSignatureBuilder(parameter)
                    .WithType(newGenericArray1DParameterType)
                    .Build();

                newGenericArray2DParameters[i] = new ParameterSignatureBuilder(parameter)
                    .WithType(newGenericArray2DParameterType)
                    .Build();

                newGenericArray3DParameters[i] = new ParameterSignatureBuilder(parameter)
                    .WithType(newGenericArray3DParameterType)
                    .Build();
            }

            yield return ToPointer
            (
                new FunctionSignatureBuilder(function)
                    .WithParameters(newIntPtrParameters)
                    .Build(),
                function
            );

            yield return Fixed
            (
                new FunctionSignatureBuilder(function)
                    .WithParameters(newGenericArray1DParameters)
                    .WithGenericTypeParameters(newGenericTypeParameters)
                    .Build()
            );

            yield return Fixed
            (
                new FunctionSignatureBuilder(function)
                    .WithParameters(newGenericArray2DParameters)
                    .WithGenericTypeParameters(newGenericTypeParameters)
                    .Build()
            );

            yield return Fixed
            (
                new FunctionSignatureBuilder(function)
                    .WithParameters(newGenericArray3DParameters)
                    .WithGenericTypeParameters(newGenericTypeParameters)
                    .Build()
            );
        }
        
        /// <inheritdoc/>
        public IEnumerable<ImplementedFunction> CreateOverloadsVoidPtr(Function function)
        {
            if (!function.Parameters.Any(p => p.Type.IsSingleVoidPointer()))
            {
                yield break;
            }

            var baseParameters = function.Parameters;

            var newIntPtrParameters = new List<Parameter>(baseParameters);
            var newGenericArray1DParameters = new List<Parameter>(baseParameters);
            var newGenericArray2DParameters = new List<Parameter>(baseParameters);
            var newGenericArray3DParameters = new List<Parameter>(baseParameters);

            var newGenericTypeParameters = new List<GenericTypeParameter>();
            newGenericTypeParameters.AddRange(function.GenericTypeParameters);
            for (var i = 0; i < baseParameters.Count; ++i)
            {
                var parameter = baseParameters[i];
                if (!parameter.Type.IsSingleVoidPointer() || parameter.Type.IsOut)
                {
                    continue;
                }

                var genericTypeParameterName = baseParameters.Count(p => p.Type.IsSingleVoidPointer()) > 1
                    ? $"T{newGenericTypeParameters.Count + 1}" : "T";

                var genericTypeParameter = new GenericTypeParameter(
                    genericTypeParameterName,
                    new[] { "unmanaged" });

                newGenericTypeParameters.Add(genericTypeParameter);

                var newIntPtrParameterType = new TypeSignatureBuilder(parameter.Type)
                    .WithIndirectionLevel(0)
                    .WithName("IntPtr")
                    .Build();

                // TODO: Simplify and generalize this
                var newGenericArray1DParameterType = new TypeSignatureBuilder(parameter.Type)
                    .WithIndirectionLevel(0)
                    .WithArrayDimensions(1)
                    .WithName(genericTypeParameterName)
                    .Build();

                var newGenericArray2DParameterType = new TypeSignatureBuilder(parameter.Type)
                    .WithIndirectionLevel(0)
                    .WithArrayDimensions(2)
                    .WithName(genericTypeParameterName)
                    .Build();

                var newGenericArray3DParameterType = new TypeSignatureBuilder(parameter.Type)
                    .WithIndirectionLevel(0)
                    .WithArrayDimensions(3)
                    .WithName(genericTypeParameterName)
                    .Build();

                newIntPtrParameters[i] = new ParameterSignatureBuilder(parameter)
                    .WithType(newIntPtrParameterType)
                    .Build();

                newGenericArray1DParameters[i] = new ParameterSignatureBuilder(parameter)
                    .WithType(newGenericArray1DParameterType)
                    .Build();

                newGenericArray2DParameters[i] = new ParameterSignatureBuilder(parameter)
                    .WithType(newGenericArray2DParameterType)
                    .Build();

                newGenericArray3DParameters[i] = new ParameterSignatureBuilder(parameter)
                    .WithType(newGenericArray3DParameterType)
                    .Build();
            }

            yield return ToIntPtr
            (
                new FunctionSignatureBuilder(function)
                    .WithParameters(newIntPtrParameters)
                    .Build(),
                function
            );

            yield return FixedVoidPtr
            (
                new FunctionSignatureBuilder(function)
                    .WithParameters(newGenericArray1DParameters)
                    .WithGenericTypeParameters(newGenericTypeParameters)
                    .Build()
            );

            yield return FixedVoidPtr
            (
                new FunctionSignatureBuilder(function)
                    .WithParameters(newGenericArray2DParameters)
                    .WithGenericTypeParameters(newGenericTypeParameters)
                    .Build()
            );

            yield return FixedVoidPtr
            (
                new FunctionSignatureBuilder(function)
                    .WithParameters(newGenericArray3DParameters)
                    .WithGenericTypeParameters(newGenericTypeParameters)
                    .Build()
            );
        }

        private static ImplementedFunction ToIntPtr(Function function, Function old)
        {
            var sb = new StringBuilder();
            sb.AppendLine("// PointerParameterOverloader");
            if (function.ReturnType.ToString() != "void")
            {
                sb.Append("return ");
            }

            sb.Append($"{function.Name}(");
            var list = new List<string>();
            foreach (var param in old.Parameters)
            {
                var nm = Utilities.CSharpKeywords.Contains(param.Name) ? $"@{param.Name}" : param.Name;
                if (param.Type.IsSingleVoidPointer())
                {
                    list.Add($"(void*) {nm}");
                }
                else
                {
                    var prefix = param.Type.IsOut ? "out " : param.Type.IsByRef ? "ref " : string.Empty;
                    list.Add(prefix + nm);
                }
            }

            sb.Append(string.Join(", ", list));
            sb.AppendLine(");");
            return new ImplementedFunction(function, sb, true);
        }

        private static ImplementedFunction FixedVoidPtr(Function function)
        {
            var sb = new StringBuilder();
            var parameters = new List<string>();
            var ind = string.Empty;
            sb.AppendLine("// PointerParameterOverloader");
            foreach (var param in function.Parameters)
            {
                var nm = Utilities.CSharpKeywords.Contains(param.Name) ? $"@{param.Name}" : param.Name;
                if (function.GenericTypeParameters.Any(x => x.Name == param.Type.Name))
                {
                    sb.AppendLine($"{ind}fixed ({param.Type.Name}* {param.Name}Ptr = {nm})");
                    sb.AppendLine($"{ind}{{");
                    ind += "    ";
                    parameters.Add($"(void*) {param.Name}Ptr");
                }
                else
                {
                    var prefix = param.Type.IsOut ? "out " : param.Type.IsByRef ? "ref " : string.Empty;
                    parameters.Add(prefix + nm);
                }
            }

            sb.Append(ind);
            if (function.ReturnType.ToString() != "void")
            {
                sb.Append("return ");
            }

            sb.AppendLine($"{function.Name}({string.Join(", ", parameters)});");

            while (!string.IsNullOrEmpty(ind))
            {
                ind = ind.Remove(ind.Length - 4, 4);
                sb.AppendLine($"{ind}}}");
            }

            return new ImplementedFunction(function, sb, true);
        }

        private static ImplementedFunction ToPointer(Function function, Function old)
        {
            var sb = new StringBuilder();
            sb.AppendLine("// PointerParameterOverloader");
            if (function.ReturnType.ToString() != "void")
            {
                sb.Append("return ");
            }

            sb.Append($"{function.Name}(");
            var list = new List<string>();
            foreach (var param in old.Parameters)
            {
                var nm = Utilities.CSharpKeywords.Contains(param.Name) ? $"@{param.Name}" : param.Name;
                if (param.Type.IsIntPtr())
                {
                    list.Add($"(IntPtr) {nm}");
                }
                else
                {
                    var prefix = param.Type.IsOut ? "out " : param.Type.IsByRef ? "ref " : string.Empty;
                    list.Add(prefix + nm);
                }
            }

            sb.Append(string.Join(", ", list));
            sb.AppendLine(");");
            return new ImplementedFunction(function, sb, true);
        }

        private static ImplementedFunction Fixed(Function function)
        {
            var sb = new StringBuilder();
            var parameters = new List<string>();
            var ind = string.Empty;
            sb.AppendLine("// PointerParameterOverloader");
            foreach (var param in function.Parameters)
            {
                var nm = Utilities.CSharpKeywords.Contains(param.Name) ? $"@{param.Name}" : param.Name;
                if (function.GenericTypeParameters.Any(x => x.Name == param.Type.Name))
                {
                    sb.AppendLine($"{ind}fixed ({param.Type.Name}* {param.Name}Ptr = {nm})");
                    sb.AppendLine($"{ind}{{");
                    ind += "    ";
                    parameters.Add($"(IntPtr) {param.Name}Ptr");
                }
                else
                {
                    var prefix = param.Type.IsOut ? "out " : param.Type.IsByRef ? "ref " : string.Empty;
                    parameters.Add(prefix + nm);
                }
            }

            sb.Append(ind);
            if (function.ReturnType.ToString() != "void")
            {
                sb.Append("return ");
            }

            sb.AppendLine($"{function.Name}({string.Join(", ", parameters)});");

            while (!string.IsNullOrEmpty(ind))
            {
                ind = ind.Remove(ind.Length - 4, 4);
                sb.AppendLine($"{ind}}}");
            }

            return new ImplementedFunction(function, sb, true);
}
    }
}
