// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MoreLinq.Extensions;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;
using Silk.NET.BuildTools.Common.Structs;
using Silk.NET.BuildTools.Overloading;
using Enum = Silk.NET.BuildTools.Common.Enums.Enum;

namespace Silk.NET.BuildTools.Bind
{
    /// <summary>
    /// Contains methods for writing profiles to disk.
    /// </summary>
    public static class ProfileWriter
    {
        /// <summary>
        /// The name of the subfolder containing <see cref="Common.Enums.Enum" />s.
        /// </summary>
        public const string EnumsSubfolder = "Enums";

        /// <summary>
        /// The name of the subfolder containing <see cref="Struct" />s.
        /// </summary>
        public const string StructsSubfolder = "Structs";

        /// <summary>
        /// The license text for the project.
        /// </summary>
        public static Dictionary<string,string> CachedLicenseTexts { get; } = new Dictionary<string,string>();

        public static string LicenseText(this BindTask task) => CachedLicenseTexts.TryGetValue
            (task.OutputOpts.License, out var val)
            ? val
            : CachedLicenseTexts[task.OutputOpts.License] = File.ReadAllText(task.OutputOpts.License);

        /// <summary>
        /// Writes this enum to a file.
        /// </summary>
        /// <param name="enum">The enum to write.</param>
        /// <param name="file">The file to write to.</param>
        /// <param name="profile">The subsystem containing this enum.</param>
        /// <param name="project">The project containing this enum.</param>
        public static void WriteEnum(this Enum @enum, string file, Profile profile, Project project, BindTask task)
        {
            var sw = new StreamWriter(file);
            sw.WriteLine(task.LicenseText());
            sw.WriteLine();
            var ns = project.IsRoot ? task.Namespace : task.ExtensionsNamespace;
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

        /// <summary>
        /// Writes this struct to a file.
        /// </summary>
        /// <param name="struct">The enum to write.</param>
        /// <param name="file">The file to write to.</param>
        /// <param name="profile">The subsystem containing this enum.</param>
        /// <param name="project">The project containing this enum.</param>
        public static void WriteStruct(this Struct @struct, string file, Profile profile, Project project, BindTask task)
        {
            var sw = new StreamWriter(file);
            sw.WriteLine(task.LicenseText());
            sw.WriteLine();
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Runtime.InteropServices;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("using Silk.NET.Core.Native;");
            sw.WriteLine("using Silk.NET.Core.Attributes;");
            sw.WriteLine("using Silk.NET.Core.Contexts;");
            sw.WriteLine("using Silk.NET.Core.Loader;");
            sw.WriteLine();
            sw.WriteLine("#pragma warning disable 1591");
            sw.WriteLine();
            var ns = project.IsRoot ? task.Namespace : task.ExtensionsNamespace;
            sw.WriteLine($"namespace {ns}{project.Namespace}");
            sw.WriteLine("{");
            foreach (var attr in @struct.Attributes)
            {
                sw.WriteLine($"    {attr}");
            }

            sw.WriteLine($"    [NativeName(\"Name\", \"{@struct.NativeName}\")]");
            sw.WriteLine($"    public unsafe partial struct {@struct.Name}");
            sw.WriteLine("    {");
            if (@struct.Fields.Any(x => x.Count is null))
            {
                sw.WriteLine($"        public {@struct.Name}");
                sw.WriteLine( "        (");
                var first = true;
                foreach (var field in @struct.Fields)
                {
                    if (!(field.Count is null))
                        continue; // I've chosen not to initialize multi-count fields from ctors.
                    var argName = field.Name[0].ToString().ToLower() + field.Name.Substring(1);
                    argName = Utilities.CSharpKeywords.Contains(argName) ? $"@{argName}" : argName;
                    if (!first)
                    {
                        sw.WriteLine(",");
                    }
                    else
                    {
                        first = false;
                    }

                    sw.Write($"            {field.Type} {argName} = {field.DefaultAssignment ?? "default"}");
                }

                sw.WriteLine();
                sw.WriteLine("        )");
                sw.WriteLine("        {");
                foreach (var field in @struct.Fields)
                {
                    if (!(field.Count is null))
                    {
                        if (!Field.FixedCapableTypes.Contains(field.Type.Name))
                        {
                            var count = field.Count.IsConstant
                                ? int.Parse
                                (
                                    profile.Projects.SelectMany(x => x.Value.Classes.SelectMany(y => y.Constants))
                                        .FirstOrDefault(x => x.NativeName == field.Count.ConstantName)
                                        ?.Value ?? throw new InvalidDataException("Couldn't find constant referenced")
                                )
                                : field.Count.IsStatic
                                    ? field.Count.StaticCount
                                    : 1;
                            for (var i = 0; i < count; i++)
                            {
                                sw.WriteLine
                                (
                                    $"           {field.Name}_{i} = default;"
                                );
                            }
                        }

                        continue;
                    }

                    var argName = field.Name[0].ToString().ToLower() + field.Name.Substring(1);
                    argName = Utilities.CSharpKeywords.Contains(argName) ? $"@{argName}" : argName;
                    sw.WriteLine($"            {field.Name} = {argName};");
                }

                sw.WriteLine("        }");
                sw.WriteLine();
            }

            foreach (var structField in @struct.Fields)
            {
                if (!(structField.Count is null))
                {
                    if (!Field.FixedCapableTypes.Contains(structField.Type.Name))
                    {
                        var count = structField.Count.IsConstant
                            ? int.Parse
                            (
                                profile.Projects.SelectMany(x => x.Value.Classes.SelectMany(y => y.Constants))
                                    .FirstOrDefault(x => x.NativeName == structField.Count.ConstantName)
                                    ?
                                    .Value ?? throw new InvalidDataException("Couldn't find constant referenced")
                            )
                            : structField.Count.IsStatic
                                ? structField.Count.StaticCount
                                : 1;
                        var typeFixup09072020 = new TypeSignatureBuilder(structField.Type).WithIndirectionLevel
                            (structField.Type.IndirectionLevels - 1).Build();
                        for (var i = 0; i < count; i++)
                        {
                            sw.WriteLine($"        {structField.Doc}");
                            foreach (var attr in structField.Attributes)
                            {
                                sw.WriteLine($"        {attr}");
                            }

                            sw.WriteLine($"        [NativeName(\"Type\", \"{structField.NativeType}\")]");
                            sw.WriteLine($"        [NativeName(\"Type.Name\", \"{structField.Type.OriginalName}\")]");
                            sw.WriteLine($"        [NativeName(\"Name\", \"{structField.NativeName}\")]");
                            sw.WriteLine
                            (
                                $"        public {typeFixup09072020} {structField.Name}_{i};"
                            );
                        }
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(structField.Doc))
                        {
                            sw.WriteLine($"        {structField.Doc}");
                        }

                        var count = structField.Count.IsConstant
                            ? int.Parse
                            (
                                profile.Projects.SelectMany(x => x.Value.Classes.SelectMany(y => y.Constants))
                                    .FirstOrDefault(x => x.NativeName == structField.Count.ConstantName)
                                    ?
                                    .Value?? throw new InvalidDataException("Couldn't find constant referenced")
                            )
                            : structField.Count.IsStatic
                                ? structField.Count.StaticCount
                                : 1;
                        var typeFixup09072020 = new TypeSignatureBuilder(structField.Type).WithIndirectionLevel
                            (structField.Type.IndirectionLevels - 1).Build();

                        foreach (var attr in structField.Attributes)
                        {
                            sw.WriteLine($"        {attr}");
                        }

                        sw.WriteLine($"        [NativeName(\"Type\", \"{structField.NativeType}\")]");
                        sw.WriteLine($"        [NativeName(\"Type.Name\", \"{structField.Type.OriginalName}\")]");
                        sw.WriteLine($"        [NativeName(\"Name\", \"{structField.NativeName}\")]");
                        sw.WriteLine
                        (
                            $"        public fixed {typeFixup09072020} {structField.Name}[{count}];"
                        );
                    }
                }
                else
                {
                    sw.WriteLine(structField.Doc);
                    foreach (var attr in structField.Attributes)
                    {
                        sw.WriteLine($"        {attr}");
                    }

                    sw.WriteLine($"        [NativeName(\"Type\", \"{structField.NativeType}\")]");
                    sw.WriteLine($"        [NativeName(\"Type.Name\", \"{structField.Type.OriginalName}\")]");
                    sw.WriteLine($"        [NativeName(\"Name\", \"{structField.NativeName}\")]");
                    sw.WriteLine($"        public {structField.Type} {structField.Name};");
                }
            }

            sw.WriteLine("    }");
            sw.WriteLine("}");
            sw.Flush();
            sw.Dispose();
        }

        /// <summary>
        /// Create a class that extends SearchPathContainer.
        /// </summary>
        /// <param name="project">The current project.</param>
        /// <param name="profile">The profile to write the object for.</param>
        /// <param name="file">The file to write the class to.</param>
        public static void WriteNameContainer(this Project project, Profile profile, string file, BindTask task)
        {
            if (File.Exists(file))
            {
                return;
            }
            
            using var sw = new StreamWriter(file);
            
            sw.WriteLine(task.LicenseText());
            sw.WriteLine("using Silk.NET.Core.Loader;");
            sw.WriteLine();
            sw.WriteLine($"namespace {task.Namespace}{project.Namespace}");
            sw.WriteLine("{");
            sw.WriteLine("    /// <summary>");
            sw.WriteLine($"    /// Contains the library name of {profile.Name}.");
            sw.WriteLine("    /// </summary>");
            sw.WriteLine($"    internal class {task.NameContainer.ClassName} : SearchPathContainer");
            sw.WriteLine("    {");
            sw.WriteLine("        /// <inheritdoc />");
            sw.WriteLine($"        public override string Linux => \"{task.NameContainer.Linux}\";");
            sw.WriteLine();
            sw.WriteLine("        /// <inheritdoc />");
            sw.WriteLine($"        public override string MacOS => \"{task.NameContainer.MacOS}\";");
            sw.WriteLine();
            sw.WriteLine("        /// <inheritdoc />");
            sw.WriteLine($"        public override string Android => \"{task.NameContainer.Android}\";");
            sw.WriteLine();
            sw.WriteLine("        /// <inheritdoc />");
            sw.WriteLine($"        public override string IOS => \"{task.NameContainer.IOS}\";");
            sw.WriteLine();
            sw.WriteLine("        /// <inheritdoc />");
            sw.WriteLine($"        public override string Windows64 => \"{task.NameContainer.Windows64}\";");
            sw.WriteLine();
            sw.WriteLine("        /// <inheritdoc />");
            sw.WriteLine($"        public override string Windows86 => \"{task.NameContainer.Windows86}\";");
            sw.WriteLine("    }");
            sw.WriteLine("}");
        }

        /// <summary>
        /// Write mixed-mode (partial) classes.
        /// </summary>
        /// <param name="project">The current project.</param>
        /// <param name="profile">The profile to write mixed-mode classes for.</param>
        /// <param name="folder">The folder to store the generated classes in.</param>
        public static void WriteMixedModeClasses(this Project project, Profile profile, string folder, BindTask task)
        {
            // public abstract class MixedModeClass : IMixedModeClass
            // {
            // }
            foreach (var @class in project.Classes)
            {
                if (project.IsRoot)
                {
                    var sw = new StreamWriter(Path.Combine(folder, $"{@class.ClassName}.gen.cs"));
                    StreamWriter? swOverloads = null;
                    sw.Write(task.LicenseText());
                    sw.WriteLine("using System;");
                    sw.WriteLine("using System.Runtime.InteropServices;");
                    sw.WriteLine("using System.Text;");
                    sw.WriteLine("using Silk.NET.Core.Native;");
                    sw.WriteLine("using Silk.NET.Core.Attributes;");
                    sw.WriteLine("using Silk.NET.Core.Contexts;");
                    sw.WriteLine("using Silk.NET.Core.Loader;");
                    sw.WriteLine();
                    sw.WriteLine("#pragma warning disable 1591");
                    sw.WriteLine();
                    sw.WriteLine($"namespace {task.Namespace}{project.Namespace}");
                    sw.WriteLine("{");
                    sw.WriteLine
                        ($"    public unsafe partial class {@class.ClassName} : NativeAPI");
                    sw.WriteLine("    {");
                    foreach (var constant in @class.Constants)
                    {
                        sw.WriteLine($"        [NativeName(\"Type\", \"{constant.Type.OriginalName}\")]");
                        sw.WriteLine($"        [NativeName(\"Name\", \"{constant.NativeName}\")]");
                        sw.WriteLine($"        public const {constant.Type} {constant.Name} = {constant.Value};");
                    }

                    sw.WriteLine();

                    var allFunctions = @class.NativeApis.SelectMany
                            (x => x.Value.Functions)
                        .RemoveDuplicates()
                        .ToArray();
                    foreach (var function in allFunctions)
                    {
                        using (var sr = new StringReader(function.Doc))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                sw.WriteLine($"        {line}");
                            }
                        }

                        foreach (var attr in function.Attributes)
                        {
                            sw.WriteLine($"        [{attr.Name}({string.Join(", ", attr.Arguments)})]");
                        }

                        sw.WriteLine($"        [NativeApi(EntryPoint = \"{function.NativeName}\")]");
                        using (var sr = new StringReader(function.ToString(null, true, true)))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                sw.WriteLine($"        {line}");
                            }
                        }

                        sw.WriteLine();
                    }

                    foreach (var overload in Overloader.GetOverloads(allFunctions, profile.Projects["Core"]))
                    {
                        var sw2u = overload.Signature.Kind == SignatureKind.PotentiallyConflictingOverload
                            ? swOverloads ??= CreateOverloadsFile(folder, @class.ClassName, false)
                            : sw;
                        if (sw2u == swOverloads)
                        {
                            overload.Signature.Parameters.Insert
                            (
                                0,
                                new Parameter
                                {
                                    Name = "thisApi",
                                    Type = new Common.Functions.Type {Name = @class.ClassName, IsThis = true}
                                }
                            );
                        }

                        using (var sr = new StringReader(overload.Signature.Doc))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                sw2u.WriteLine($"        {line}");
                            }
                        }

                        foreach (var attr in overload.Signature.Attributes)
                        {
                            sw2u.WriteLine($"        [{attr.Name}({string.Join(", ", attr.Arguments)})]");
                        }

                        sw2u.WriteLine($"        public {overload.Signature.ToString(overload.IsUnsafe, @static: sw2u == swOverloads).TrimEnd(';')}");
                        sw2u.WriteLine("        {");
                        foreach (var line in overload.Body)
                        {
                            sw2u.WriteLine($"            {line}");
                        }

                        sw2u.WriteLine("        }");
                        sw2u.WriteLine();
                    }

                    sw.WriteLine();
                    sw.WriteLine($"        public {@class.ClassName}(INativeContext ctx)");
                    sw.WriteLine("            : base(ctx)");
                    sw.WriteLine("        {");
                    sw.WriteLine("        }");
                    sw.WriteLine("    }");
                    sw.WriteLine("}");
                    sw.WriteLine();
                    FinishOverloadsFile(swOverloads);
                    sw.Flush();
                    sw.Dispose();
                    if (!File.Exists(Path.Combine(folder, $"{@class.ClassName}.cs")))
                    {
                        sw = new StreamWriter(Path.Combine(folder, $"{@class.ClassName}.cs"));
                        sw.WriteLine("using System;");
                        sw.WriteLine("using Silk.NET.Core.Loader;");
                        sw.WriteLine("using Silk.NET.Core.Native;");
                        sw.WriteLine("using Silk.NET.Core.Attributes;");
                        sw.WriteLine();
                        sw.WriteLine("#pragma warning disable 1591");
                        sw.WriteLine();
                        sw.WriteLine($"namespace {task.Namespace}{project.Namespace}");
                        sw.WriteLine("{");
                        sw.WriteLine($"    public partial class {@class.ClassName}");
                        sw.WriteLine("    {");
                        sw.WriteLine($"        public static {@class.ClassName} GetApi()");
                        sw.WriteLine("        {");
                        if (!(task.NameContainer is null))
                        {
                            sw.WriteLine
                            (
                                $"             return new {@class.ClassName}(new DefaultNativeContext" +
                                $"(new {task.NameContainer.ClassName}().GetName()));"
                            );
                        }
                        else
                        {
                            sw.WriteLine("             throw new NotImplementedException();");
                        }
                        sw.WriteLine("        }");
                        sw.WriteLine();
                        sw.WriteLine("        public bool TryGetExtension<T>(out T ext)");
                        sw.WriteLine($"            where T:NativeExtension<{@class.ClassName}>");
                        sw.WriteLine("        {");
                        sw.WriteLine("             ext = IsExtensionPresent(" +
                                     "ExtensionAttribute.GetExtensionAttribute(typeof(T)).Name)");
                        sw.WriteLine("                 ? Activator.CreateInstance<T>(Context)");
                        sw.WriteLine("                 : null;");
                        sw.WriteLine("             return !(ext is null);");
                        sw.WriteLine("        }");
                        sw.WriteLine();
                        sw.WriteLine("        public override bool IsExtensionPresent(string extension)");
                        sw.WriteLine("        {");
                        sw.WriteLine("            throw new NotImplementedException();");
                        sw.WriteLine("        }");
                        sw.WriteLine("    }");
                        sw.WriteLine("}");
                        sw.WriteLine();
                        sw.Flush();
                        sw.Dispose();
                    }

                    if (!(task.NameContainer is null))
                    {
                        project.WriteNameContainer
                            (profile, Path.Combine(folder, $"{task.NameContainer.ClassName}.cs"), task);
                    }
                }
                else
                {
                    foreach (var (key, i) in @class.NativeApis)
                    {
                        var name = i.Name.Substring(1);
                        var sw = new StreamWriter(Path.Combine(folder, $"{name}.gen.cs"));
                        StreamWriter? swOverloads = null;
                        sw.Write(task.LicenseText());
                        sw.WriteLine("using System;");
                        sw.WriteLine("using System.Runtime.InteropServices;");
                        sw.WriteLine("using System.Text;");
                        sw.WriteLine($"using {profile.Projects["Core"].GetNamespace(task)};");
                        sw.WriteLine("using Silk.NET.Core.Native;");
                        sw.WriteLine("using Silk.NET.Core.Attributes;");
                        sw.WriteLine("using Silk.NET.Core.Contexts;");
                        sw.WriteLine("using Silk.NET.Core.Loader;");
                        sw.WriteLine();
                        sw.WriteLine("#pragma warning disable 1591");
                        sw.WriteLine();
                        sw.WriteLine($"namespace {task.ExtensionsNamespace}{project.Namespace}");
                        sw.WriteLine("{");
                        sw.WriteLine($"    [Extension(\"{key}\")]");
                        sw.WriteLine
                        (
                            $"    public unsafe partial class {name} : NativeExtension<{@class.ClassName}>"
                        );
                        sw.WriteLine("    {");
                        sw.WriteLine($"        public const string ExtensionName = \"{key}\";");
                        foreach (var function in i.Functions)
                        {
                            using (var sr = new StringReader(function.Doc))
                            {
                                string line;
                                while ((line = sr.ReadLine()) != null)
                                {
                                    sw.WriteLine($"        {line}");
                                }
                            }

                            foreach (var attr in function.Attributes)
                            {
                                sw.WriteLine($"        [{attr.Name}({string.Join(", ", attr.Arguments)})]");
                            }

                            sw.WriteLine($"        [NativeApi(EntryPoint = \"{function.NativeName}\")]");
                            using (var sr = new StringReader(function.ToString(null, true, true)))
                            {
                                string line;
                                while ((line = sr.ReadLine()) != null)
                                {
                                    sw.WriteLine($"        {line}");
                                }
                            }

                            sw.WriteLine();
                        }

                        foreach (var overload in Overloader.GetOverloads(i.Functions, profile.Projects["Core"]))
                        {
                            var sw2u = overload.Signature.Kind == SignatureKind.PotentiallyConflictingOverload
                                ? swOverloads ??= CreateOverloadsFile(folder, name, true)
                                : sw;
                            if (sw2u == swOverloads)
                            {
                                overload.Signature.Parameters.Insert
                                (
                                    0,
                                    new Parameter
                                    {
                                        Name = "thisApi",
                                        Type = new Common.Functions.Type {Name = name, IsThis = true}
                                    }
                                );
                            }

                            using (var sr = new StringReader(overload.Signature.Doc))
                            {
                                string line;
                                while ((line = sr.ReadLine()) != null)
                                {
                                    sw2u.WriteLine($"        {line}");
                                }
                            }

                            foreach (var attr in overload.Signature.Attributes)
                            {
                                sw2u.WriteLine($"        [{attr.Name}({string.Join(", ", attr.Arguments)})]");
                            }

                            sw2u.WriteLine($"        public {overload.Signature.ToString(overload.IsUnsafe, @static: sw2u == swOverloads).TrimEnd(';')}");
                            sw2u.WriteLine("        {");
                            foreach (var line in overload.Body)
                            {
                                sw2u.WriteLine($"            {line}");
                            }

                            sw2u.WriteLine("        }");
                            sw2u.WriteLine();
                        }

                        sw.WriteLine($"        public {name}(INativeContext ctx)");
                        sw.WriteLine("            : base(ctx)");
                        sw.WriteLine("        {");
                        sw.WriteLine("        }");
                        sw.WriteLine("    }");
                        sw.WriteLine("}");
                        sw.WriteLine();
                        sw.Flush();
                        FinishOverloadsFile(swOverloads);
                    }
                }
            }

            StreamWriter CreateOverloadsFile(string folder, string @class, bool isExtension)
            {
                var ns = isExtension ? task.ExtensionsNamespace : task.Namespace;
                var swOverloads = new StreamWriter(Path.Combine(folder, $"{@class}Overloads.gen.cs"));
                swOverloads.Write(task.LicenseText());
                swOverloads.WriteLine("using System;");
                swOverloads.WriteLine("using System.Runtime.InteropServices;");
                swOverloads.WriteLine("using System.Text;");
                swOverloads.WriteLine("using Silk.NET.Core.Native;");
                swOverloads.WriteLine("using Silk.NET.Core.Attributes;");
                swOverloads.WriteLine("using Silk.NET.Core.Contexts;");
                swOverloads.WriteLine("using Silk.NET.Core.Loader;");
                swOverloads.WriteLine();
                swOverloads.WriteLine("#pragma warning disable 1591");
                swOverloads.WriteLine();
                swOverloads.WriteLine($"namespace {ns}{project.Namespace}");
                swOverloads.WriteLine("{");
                swOverloads.WriteLine($"    public static class {@class}Overloads");
                swOverloads.WriteLine("    {");
                return swOverloads;
            }

            static void FinishOverloadsFile(StreamWriter? swOverloads)
            {
                swOverloads?.WriteLine("    }");
                swOverloads?.WriteLine("}");
                swOverloads?.WriteLine();
                swOverloads?.Flush();
                swOverloads?.Dispose();
            }
        }

        /// <summary>
        /// Writes this project in the given folder, with the given settings and parent subsystem.
        /// </summary>
        /// <param name="project">The project to write.</param>
        /// <param name="folder">The folder to write this project to.</param>
        /// <param name="profile">The parent subsystem.</param>
        public static void Write(this Project project, string folder, Profile profile, BindTask task)
        {
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            if (!Directory.Exists(Path.Combine(folder, EnumsSubfolder)))
            {
                Directory.CreateDirectory(Path.Combine(folder, EnumsSubfolder));
            }

            if (!Directory.Exists(Path.Combine(folder, StructsSubfolder)))
            {
                Directory.CreateDirectory(Path.Combine(folder, StructsSubfolder));
            }

            project.WriteProjectFile(folder, profile, task);

            project.Structs.ForEach
            (
                x => x.WriteStruct
                (
                    Path.Combine(folder, StructsSubfolder, $"{x.Name}.gen.cs"), profile, project, task
                )
            );

            project.Enums.ForEach
            (
                x => x.WriteEnum(Path.Combine(folder, EnumsSubfolder, $"{x.Name}.gen.cs"), profile, project, task)
            );

            project.WriteMixedModeClasses(profile, folder, task);
        }

        /// <summary>
        /// Writes the project file to the given folder.
        /// </summary>
        /// <param name="project">The project to write.</param>
        /// <param name="folder">The folder that should contain the project file.</param>
        /// <param name="prof">The parent profile.</param>
        private static void WriteProjectFile(this Project project, string folder, Profile prof, BindTask task)
        {
            if (File.Exists(Path.Combine(folder, $"{project.GetProjectName(task)}.csproj")))
            {
                return;
            }

            var csproj = new StreamWriter(Path.Combine(folder, $"{project.GetProjectName(task)}.csproj"));
            csproj.WriteLine("<Project Sdk=\"Microsoft.NET.Sdk\">");
            csproj.WriteLine();
            csproj.WriteLine("  <PropertyGroup>");
            csproj.WriteLine("    <TargetFrameworks>netstandard2.0;net5.0</TargetFrameworks>");
            csproj.WriteLine("    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>");
            csproj.WriteLine("    <LangVersion>preview</LangVersion>");
            csproj.WriteLine("  </PropertyGroup>");
            csproj.WriteLine();
            csproj.WriteLine("  <ItemGroup>");
            if (!project.IsRoot)
            {
                var core = Path.GetRelativePath
                (
                    folder,
                    Path.Combine
                    (
                        task.OutputOpts.Folder,
                        prof.Projects["Core"].GetProjectName(task),
                        $"{prof.Projects["Core"].GetProjectName(task)}.csproj"
                    )
                );
                csproj.WriteLine($"    <ProjectReference Include=\"{core}\" />");
            }

            csproj.WriteLine("  </ItemGroup>");
            csproj.WriteLine();
            csproj.WriteLine($"  <Import Project=\"{Path.GetRelativePath(folder, task.OutputOpts.Props)}\" />");
            csproj.WriteLine("</Project>");
            csproj.Flush();
            csproj.Dispose();
        }

        /// <summary>
        /// Writes all of the projects, interfaces, and enums to disk.
        /// </summary>
        /// <param name="profile">The profile containing the profiles, interfaces, and enums.</param>
        public static void Flush(this Profile profile, BindTask task)
        {
            var rootFolder = task.OutputOpts.Folder;
            if (!Directory.Exists(rootFolder))
            {
                Directory.CreateDirectory(rootFolder);
            }

            if (!Directory.Exists(Path.Combine(rootFolder, "Extensions")))
            {
                Directory.CreateDirectory(Path.Combine(rootFolder, "Extensions"));
            }

            Console.WriteLine($"Loaded \"{profile.Name}\", writing {profile.Projects.Count} projects...");
            profile.Projects.ForEach
            (
                x =>
                    x.Value.Write
                    (
                        x.Key == "Core"
                            ? Path.Combine(rootFolder, x.Value.GetProjectName(task))
                            : Path.Combine(rootFolder, "Extensions", x.Value.GetProjectName(task)),
                        profile,
                        task
                    )
            );
            Console.WriteLine($"Successfully wrote \"{profile.Name}\" to disk.");
        }
    }
}
