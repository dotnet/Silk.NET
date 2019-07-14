// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Text;
using Generator.Common.Functions;
using Humanizer;

namespace Generator.Convert.Documentation
{
    /// <summary>
    /// Represents documentation for a function.
    /// </summary>
    public class FunctionDocumentation
    {
        /// <summary>
        /// Gets or sets this function's documentation summary.
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Gets or sets a dictionary where the parameter name is the key, and its documentation is the value.
        /// </summary>
        public Dictionary<string, ParameterDocumentation> Parameters { get; set; }

        /// <summary>
        /// Converts this documentation to string, and writes it to the function's <see cref="Function.Doc" /> property.
        /// </summary>
        /// <param name="function">The function to write documentation to.</param>
        public void Write(Function function)
        {
            var sb = new StringBuilder();
            sb.AppendLine("/// <summary>");
            sb.AppendLine("/// " + Summary.Replace("\n", "\n/// "));
            sb.AppendLine("/// </summary>");
            foreach (var parameter in function.Parameters)
            {
                sb.AppendLine("/// <param name=\"" + parameter.Name + "\">");
                if (Parameters.ContainsKey(parameter.Name))
                {
                    sb.AppendLine("/// " + Parameters[parameter.Name].Summary.Replace("\n", "\n/// "));
                }
                else
                {
                    sb.AppendLine("/// To be added.");
                }

                if (!(parameter.Count is null))
                {
                    if (parameter.Count.IsStatic)
                    {
                        sb.AppendLine($"/// This parameter contains {parameter.Count.StaticCount} elements.");
                        sb.AppendLine("///");
                    }

                    if (parameter.Count.IsComputed)
                    {
                        var parameterList = parameter.Count.ComputedFromNames.Humanize();
                        sb.AppendLine($"/// This parameter's element count is computed from {parameterList}.");
                        sb.AppendLine("///");
                    }

                    if (parameter.Count.IsReference)
                    {
                        // ReSharper disable once PossibleNullReferenceException
                        sb.AppendLine
                        (
                            $"/// This parameter's element count is taken from {parameter.Count.ValueReference.Name}."
                        );
                        sb.AppendLine("///");
                    }
                }

                sb.AppendLine("/// </param>");
            }

            if (function.ReturnType.ToString() != "void")
            {
                sb.AppendLine("/// <returns>See summary.</returns>");
            }

            function.Doc = sb.ToString();
        }
    }
}
