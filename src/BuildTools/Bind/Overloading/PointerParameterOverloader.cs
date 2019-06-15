using System.Collections.Generic;
using System.Linq;
using System.Text;
using Generator.Common.Builders;
using Generator.Common.Functions;

namespace Generator.Bind.Overloading
{
    /// <summary>
    /// Creates generic type parameter overloads for functions taking a pointer.
    /// </summary>
    public class PointerParameterOverloader : IFunctionOverloader
    {
        /// <inheritdoc/>
        public bool IsApplicable(Function function)
        {
            return function.Parameters.Any(p => p.Type.ToString() == "IntPtr");
        }

        /// <inheritdoc/>
        public IEnumerable<Overload> CreateOverloads(Function function)
        {
            var baseParameters = function.Parameters;

            var newVoidPointerParameters = new List<Parameter>(baseParameters);
            var newGenericArray1DParameters = new List<Parameter>(baseParameters);
            var newGenericArray2DParameters = new List<Parameter>(baseParameters);
            var newGenericArray3DParameters = new List<Parameter>(baseParameters);
            var newGenericRefParameters = new List<Parameter>(baseParameters);

            var newGenericTypeParameters = new List<GenericTypeParameter>();
            for (int i = 0; i < baseParameters.Count; ++i)
            {
                var parameter = baseParameters[i];
                if (!parameter.Type.IsVoidPointer())
                {
                    continue;
                }

                string genericTypeParameterName;
                if (baseParameters.Count(p => p.Type.ToString() == "IntPtr") > 1)
                {
                    genericTypeParameterName = $"T{newGenericTypeParameters.Count + 1}";
                }
                else
                {
                    genericTypeParameterName = "T";
                }

                var genericTypeParameter = new GenericTypeParameter() {Name = genericTypeParameterName};

                newGenericTypeParameters.Add(genericTypeParameter);

                var newVoidPointerParameterType = new TypeSignatureBuilder(parameter.Type)
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

                var newGenericRefParameterType = new TypeSignatureBuilder(parameter.Type)
                    .WithIndirectionLevel(0)
                    .WithName(genericTypeParameterName)
                    .WithByRef(true)
                    .Build();

                newVoidPointerParameters[i] = new ParameterSignatureBuilder(parameter)
                    .WithType(newVoidPointerParameterType)
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

                newGenericRefParameters[i] = new ParameterSignatureBuilder(parameter)
                    .WithType(newGenericRefParameterType)
                    .Build();
            }

            yield return VoidPointer
            (
                new FunctionSignatureBuilder(function)
                    .WithParameters(newVoidPointerParameters)
                    .Build()
            );

            yield return Fixed(new FunctionSignatureBuilder(function)
                .WithParameters(newGenericArray1DParameters)
                .WithGenericTypeParameters(newGenericTypeParameters)
                .Build());

            yield return Fixed(new FunctionSignatureBuilder(function)
                .WithParameters(newGenericArray2DParameters)
                .WithGenericTypeParameters(newGenericTypeParameters)
                .Build());

            yield return Fixed(new FunctionSignatureBuilder(function)
                .WithParameters(newGenericArray3DParameters)
                .WithGenericTypeParameters(newGenericTypeParameters)
                .Build());

            yield return Fixed(new FunctionSignatureBuilder(function)
                .WithParameters(newGenericRefParameters)
                .WithGenericTypeParameters(newGenericTypeParameters)
                .Build());
        }

        private Overload VoidPointer(Function function)
        {
            var sb = new StringBuilder();
            sb.Append("return " + function.Name + "(");
            for (var index = 0; index < function.Parameters.Count; index++)
            {
                var parameter = function.Parameters[index];
                if (parameter.Type.IsVoidPointer())
                {
                    sb.Append("(IntPtr) " + parameter.Name);
                }
                else
                {
                    sb.Append(parameter.Name);
                }

                if (index != function.Parameters.Count)
                {
                    sb.Append(", ");
                }
            }

            sb.AppendLine(");");
            return new Overload(function, sb, true);
        }

        private Overload Fixed(Function function)
        {
            var sb = new StringBuilder();
            var parameters = new List<string>();
            var ind = string.Empty;
            foreach (var param in function.Parameters)
            {
                if (function.GenericTypeParameters.Any(x => x.Name == param.Type.Name))
                {
                    sb.AppendLine(ind + "fixed (" + param.Type.Name + "* " + param.Name + "Ptr = " + param.Name + ")");
                    sb.AppendLine(ind + "{");
                    ind += "    ";
                    parameters.Add("(IntPtr) " + param.Name + "Ptr");
                }
                else
                {
                    parameters.Add(param.Name);
                }
            }

            sb.AppendLine(ind + string.Join(", ", parameters));

            while (!string.IsNullOrEmpty(ind))
            {
                ind = ind.Remove(ind.Length - 4, 4);
                sb.AppendLine(ind + "}");
            }

            return new Overload(function, sb, true);
        }
    }
}
