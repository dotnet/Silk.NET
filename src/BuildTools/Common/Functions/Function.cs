// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Linq;
using System.Text;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Generator.Common.Functions
{
    /// <summary>
    /// Represents a C# function.
    /// </summary>
    public class Function
    {
        /// <summary>
        /// Gets or sets the name of this function.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the return type of this function.
        /// </summary>
        public Type ReturnType { get; set; }

        /// <summary>
        /// Gets or sets the name of this function, as defined by the API specification.
        /// </summary>
        public string NativeName { get; set; }

        /// <summary>
        /// Gets or sets the parameters of the function.
        /// </summary>
        [NotNull]
        [ItemNotNull]
        public List<Parameter> Parameters { get; set; } = new List<Parameter>();

        /// <summary>
        /// Gets or sets the categories in which this function falls under.
        /// </summary>
        [NotNull]
        [ItemNotNull]
        [JsonIgnore]
        public string[] Categories { get; set; }

        /// <summary>
        /// Gets or sets the generic type parameters of the function.
        /// </summary>
        [NotNull]
        [ItemNotNull]
        public List<GenericTypeParameter> GenericTypeParameters { get; set; } =
            new List<GenericTypeParameter>();

        /// <summary>
        /// Gets or sets a list of attributes to be applied to this function.
        /// </summary>
        public List<Attribute> Attributes { get; set; } = new List<Attribute>();

        /// <summary>
        /// Gets or sets the formatted XML documentation for this function.
        /// </summary>
        public string Doc { get; set; }

        /// <summary>
        /// Gets or sets the name (vendor) of the given extension.
        /// </summary>
        public string ExtensionName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the new keyword is set.
        /// </summary>
        public bool New { get; set; } = false;

        /// <inheritdoc />
        public override string ToString()
        {
            return ToString(false);
        }

        /// <summary>
        /// Converts this instance to a string.
        /// </summary>
        /// <param name="ignoreStyleGuide">Whether to ignore the style guide.</param>
        /// <returns>This instance as a string.</returns>
        public string ToString(bool ignoreStyleGuide)
        {
            var sb = new StringBuilder();

            GetDeclarationString(sb);

            sb.Append("(");
            if (Parameters.Count > 0)
            {
                var parameterDeclarations = Parameters.Select(GetDeclarationString).ToList();
                for (var index = 0; index < parameterDeclarations.Count; index++)
                {
                    if (index != 0)
                    {
                        sb.Append(", ");
                    }

                    var parameterDeclaration = parameterDeclarations[index];
                    sb.Append(parameterDeclaration);
                }
            }

            sb.Append(")");

            if (GenericTypeParameters.Count != 0)
            {
                sb.Append(" ");
                for (var index = 0; index < GenericTypeParameters.Count; index++)
                {
                    var p = GenericTypeParameters[index];
                    var constraints = p.Constraints.Any()
                        ? string.Join(", ", p.Constraints)
                        : "struct";

                    sb.Append($"where {p.Name} : {constraints}");
                    if (index != GenericTypeParameters.Count - 1)
                    {
                        sb.Append(" ");
                    }
                }
            }

            sb.Append(";");
            if (sb.ToString().Length <= 90 || ignoreStyleGuide)
            {
                return sb.ToString();
            }

            sb = new StringBuilder();

            GetDeclarationString(sb);

            sb.AppendLine();
            sb.AppendLine("(");
            if (Parameters.Count > 0)
            {
                var parameterDeclarations = Parameters.Select(GetDeclarationString).ToList();
                for (var index = 0; index < parameterDeclarations.Count; index++)
                {
                    if (index != 0)
                    {
                        sb.AppendLine(",");
                    }

                    var parameterDeclaration = parameterDeclarations[index];
                    sb.Append("    " + parameterDeclaration);
                }
            }

            sb.AppendLine();
            sb.Append(")");

            if (GenericTypeParameters.Count != 0)
            {
                for (var index = 0; index < GenericTypeParameters.Count; index++)
                {
                    sb.AppendLine();
                    var p = GenericTypeParameters[index];
                    var constraints = p.Constraints.Any()
                        ? string.Join(", ", p.Constraints)
                        : "struct";

                    sb.Append($"where {p.Name} : {constraints}");
                }
            }

            sb.Append(";");

            return sb.ToString();
        }

        private void GetDeclarationString(StringBuilder sb)
        {
            if (Parameters.Any(p => p.Type.IsPointer) || ReturnType.IsPointer)
            {
                sb.Append("unsafe ");
            }

            sb.Append(ReturnType);
            sb.Append(" ");

            sb.Append(Name);
            if (GenericTypeParameters.Count != 0)
            {
                sb.Append("<");
                var genericParameterNames = GenericTypeParameters.Select(p => p.Name);
                var genericParameterList = string.Join(", ", genericParameterNames);
                sb.Append(genericParameterList);
                sb.Append(">");
            }
        }

        [NotNull]
        private string GetDeclarationString([NotNull] Parameter parameter)
        {
            var sb = new StringBuilder();

            var attributes = new List<string>();

            // if (parameter.Flow == FlowDirection.Out)
            // {
            //     attributes.Add("Out");
            // }
            // else if (parameter.Flow == FlowDirection.In)
            // {
            //     attributes.Add("In");
            // }
            // else if (parameter.Flow == FlowDirection.Undefined)
            // {
            //     attributes.Add("In");
            //     attributes.Add("Out");
            // }
            if (!(parameter.Count is null))
            {
                if (parameter.Count.IsStatic)
                {
                    attributes.Add($"Count(Count = {parameter.Count.StaticCount})");
                }
                else if (parameter.Count.IsComputed)
                {
                    var parameterList = string.Join(", ", parameter.Count.ComputedFromNames);
                    attributes.Add($"Count(Computed = \"{parameterList}\")");
                }
                else if (parameter.Count.IsReference)
                {
                    // ReSharper disable once PossibleNullReferenceException
                    attributes.Add($"Count(Parameter = \"{parameter.Count.ValueReference.Name}\")");
                }
            }

            if (attributes.Count != 0)
            {
                sb.Append("[");
                sb.Append(string.Join(", ", attributes));
                sb.Append("] ");
            }

            if (parameter.Type.IsOut)
            {
                sb.Append("out ");
            }

            if (parameter.Type.IsByRef)
            {
                sb.Append("ref ");
            }

            sb.Append(parameter.Type);

            sb.Append(" ");
            sb.Append(parameter.Name);

            return sb.ToString();
        }
    }
}
