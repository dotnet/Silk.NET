// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.IO;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Enums;

namespace Silk.NET.BuildTools.Bind
{
    public static class EnumWriter
    {
        /// <summary>
        /// Writes this enum to a file.
        /// </summary>
        /// <param name="enum">The enum to write.</param>
        /// <param name="file">The file to write to.</param>
        /// <param name="profile">The subsystem containing this enum.</param>
        /// <param name="project">The project containing this enum.</param>
        public static void WriteEnum(this Enum @enum, string file, Profile profile, Project project, BindState task)
        {
            var sw = new StreamWriter(file);
            sw.WriteLine(task.LicenseText());
            sw.WriteLine();
            var ns = project.IsRoot ? task.Task.Namespace : task.Task.ExtensionsNamespace;
            sw.WriteLine("using System;");
            sw.WriteLine("using Silk.NET.Core.Attributes;");
            sw.WriteLine();
            sw.WriteLine("#pragma warning disable 1591");
            sw.WriteLine();
            sw.WriteLine($"namespace {ns}{project.Namespace}");
            sw.WriteLine("{");
            foreach (var attr in @enum.Attributes)
            {
                sw.WriteLine($"    {attr}");
            }

            sw.WriteLine($"    [NativeName(\"Name\", \"{@enum.NativeName}\")]");
            sw.WriteLine($"    public enum {@enum.Name}");
            sw.WriteLine("    {");
            for (var index = 0; index < @enum.Tokens.Count; index++)
            {
                var token = @enum.Tokens[index];

                sw.WriteLine($"        [NativeName(\"Name\", \"{token.NativeName}\")]");
                sw.WriteLine
                (
                    $"        {token.Name} = {token.Value}{(index != @enum.Tokens.Count ? "," : string.Empty)}"
                );
            }

            sw.WriteLine("    }");
            sw.WriteLine("}");
            sw.Flush();
            sw.Dispose();
        }
    }
}
