// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generator.Common;
using Humanizer;

namespace Generator.Convert.Documentation
{
    /// <summary>
    /// Contains methods for writing documentation to profiles.
    /// </summary>
    public static class DocumentationWriter
    {
        /// <summary>
        /// Reads documentation from the root of the given docs.gl clone, and writes it to all functions in a profile
        /// at once.
        /// </summary>
        /// <param name="profile">The profile to write to.</param>
        /// <param name="docsDotGl">The root directory of a docs.gl clone.</param>
        public static void Write(Profile profile, string docsDotGl)
        {
            Write(profile, GetDocumentation(profile, docsDotGl));
        }

        /// <summary>
        /// Writes documentation to all functions in a profile at once.
        /// </summary>
        /// <param name="profile">The profile to write to.</param>
        /// <param name="doc">The documentation to write.</param>
        public static void Write(Profile profile, ProfileDocumentation doc)
        {
            Task.WhenAll(profile.Projects.Select(x => WriteAsync(x.Value, doc)));
        }

        /// <summary>
        /// Writes documentation to all functions in a project at once.
        /// </summary>
        /// <param name="project">The project to write to.</param>
        /// <param name="doc">The documentation to write.</param>
        /// <returns>An asynchronous task.</returns>
        public static async Task WriteAsync(Project project, ProfileDocumentation doc)
        {
            await Task.WhenAll(project.Interfaces.Select(x => WriteAsync(x.Value, doc)));
        }

        /// <summary>
        /// Writes documentation to all functions in an interface at once.
        /// </summary>
        /// <param name="interface">The interface to write to.</param>
        /// <param name="doc">The documentation to write.</param>
        /// <returns>An asynchronous task.</returns>
        public static Task WriteAsync(Interface @interface, ProfileDocumentation doc)
        {
            foreach (var function in @interface.Functions)
            {
                if (doc.Functions.ContainsKey(function.Name))
                {
                    doc.Functions[function.Name].Write(function);
                }
                else
                {
                    var sb = new StringBuilder();
                    sb.AppendLine("/// <summary>");
                    sb.AppendLine("/// To be added.");
                    sb.AppendLine("/// </summary>");
                    foreach (var parameter in function.Parameters)
                    {
                        sb.AppendLine("/// <param name=\"" + parameter.Name + "\">");
                        sb.AppendLine("/// To be added.");
                        if (!(parameter.Count is null))
                        {
                            if (parameter.Count.IsStatic)
                            {
                                sb.AppendLine($"/// This parameter contains {parameter.Count.StaticCount} elements.");
                            }

                            if (parameter.Count.IsComputed)
                            {
                                var parameterList = parameter.Count.ComputedFromNames.Humanize();
                                sb.AppendLine($"/// This parameter's element count is computed from {parameterList}.");
                            }

                            if (parameter.Count.IsReference)
                            {
                                // ReSharper disable once PossibleNullReferenceException
                                sb.AppendLine
                                (
                                    $"/// This parameter's element count is taken from {parameter.Count.ValueReference.Name}."
                                );
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

            return Task.CompletedTask;
        }

        /// <summary>
        /// Gets the documentation for a baked profile - a raw profile should not be used.
        /// </summary>
        /// <param name="profile">The baked profile.</param>
        /// <param name="docsDotGl">The root of a docs.gl clone.</param>
        /// <returns>The documentation for this baked profile.</returns>
        public static ProfileDocumentation GetDocumentation(Profile profile, string docsDotGl)
        {
            if (profile.Name.StartsWith("OpenGL"))
            {
                var doc = new Dictionary<int, ProfileDocumentation>
                {
                    {2, DocumentationReader.ReadProfileDocumentation(Path.Combine(docsDotGl, "gl2"), "gl")},
                    {3, DocumentationReader.ReadProfileDocumentation(Path.Combine(docsDotGl, "gl3"), "gl")},
                    {4, DocumentationReader.ReadProfileDocumentation(Path.Combine(docsDotGl, "gl4"), "gl")}
                };
                return GetOnlyNewest(doc);
            }

            if (profile.Name == "GLES")
            {
                var doc = new Dictionary<int, ProfileDocumentation>
                {
                    {1, DocumentationReader.ReadProfileDocumentation(Path.Combine(docsDotGl, "es1"), "gl")},
                    {2, DocumentationReader.ReadProfileDocumentation(Path.Combine(docsDotGl, "es2"), "gl")},
                    {3, DocumentationReader.ReadProfileDocumentation(Path.Combine(docsDotGl, "es3"), "gl")}
                };
                return GetOnlyNewest(doc);
            }

            if (profile.Name == "GLSC")
            {
                return DocumentationReader.ReadProfileDocumentation(Path.Combine(docsDotGl, "es2"), "gl");
            }

            // no documentation entry found, return dummy documentation
            return new ProfileDocumentation {Functions = new Dictionary<string, FunctionDocumentation>()};
        }

        private static ProfileDocumentation GetOnlyNewest(Dictionary<int, ProfileDocumentation> documentations)
        {
            var functions = new Dictionary<string, FunctionDocumentation>();
            foreach (var doc in documentations)
            {
                foreach (var function in doc.Value.Functions)
                {
                    functions[function.Key] = function.Value;
                }
            }

            return new ProfileDocumentation {Functions = functions};
        }
    }
}
