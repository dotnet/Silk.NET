// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.IO;
using System.Linq;
using MoreLinq.Extensions;
using Silk.NET.BuildTools.Common;
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
        public static Lazy<string> LicenseText { get; } =
            new Lazy<string>(() => File.ReadAllText(Binder.CliOptions.License));

        /// <summary>
        /// Writes this enum to a file.
        /// </summary>
        /// <param name="enum">The enum to write.</param>
        /// <param name="file">The file to write to.</param>
        /// <param name="profile">The subsystem containing this enum.</param>
        /// <param name="project">The project containing this enum.</param>
        public static void WriteEnum(this Enum @enum, string file, Profile profile, Project project)
        {
            var sw = new StreamWriter(file);
            sw.WriteLine(LicenseText.Value);
            sw.WriteLine();
            var ns = project.IsRoot ? profile.Namespace : profile.ExtensionsNamespace;
            sw.WriteLine("using System;");
            sw.WriteLine();
            sw.WriteLine("#pragma warning disable 1591");
            sw.WriteLine();
            sw.WriteLine($"namespace {ns}{project.Namespace}");
            sw.WriteLine("{");
            foreach (var attr in @enum.Attributes)
            {
                sw.WriteLine($"    {attr}");
            }

            sw.WriteLine($"    public enum {@enum.Name}");
            sw.WriteLine("    {");
            for (var index = 0; index < @enum.Tokens.Count; index++)
            {
                var token = @enum.Tokens[index];

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
        public static void WriteStruct(this Struct @struct, string file, Profile profile, Project project)
        {
            var sw = new StreamWriter(file);
            sw.WriteLine(LicenseText.Value);
            sw.WriteLine();
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Runtime.InteropServices;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("using Silk.NET.Core.Native;");
            sw.WriteLine("using Ultz.SuperInvoke;");
            sw.WriteLine();
            sw.WriteLine("#pragma warning disable 1591");
            sw.WriteLine();
            var ns = project.IsRoot ? profile.Namespace : profile.ExtensionsNamespace;
            sw.WriteLine($"namespace {ns}{project.Namespace}");
            sw.WriteLine("{");
            foreach (var attr in @struct.Attributes)
            {
                sw.WriteLine($"    {attr}");
            }

            sw.WriteLine($"    public unsafe struct {@struct.Name}");
            sw.WriteLine("    {");
            if (@struct.Fields.Any(x => x.Count is null))
            {
                sw.WriteLine($"        public {@struct.Name}");
                sw.WriteLine("        (");
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
                                    profile.Constants
                                        .FirstOrDefault(x => x.NativeName == field.Count.ConstantName)
                                        ?
                                        .Value
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
                    sw.WriteLine($"           {field.Name} = {argName};");
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
                                profile.Constants
                                    .FirstOrDefault(x => x.NativeName == structField.Count.ConstantName)
                                    ?
                                    .Value
                            )
                            : structField.Count.IsStatic
                                ? structField.Count.StaticCount
                                : 1;
                        for (var i = 0; i < count; i++)
                        {
                            sw.WriteLine($"        {structField.Doc}");
                            foreach (var attr in structField.Attributes)
                            {
                                sw.WriteLine($"        {attr}");
                            }

                            sw.WriteLine
                            (
                                $"        public {structField.Type} {structField.Name}_{i};"
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
                                profile.Constants
                                    .FirstOrDefault(x => x.NativeName == structField.Count.ConstantName)
                                    ?
                                    .Value
                            )
                            : structField.Count.IsStatic
                                ? structField.Count.StaticCount
                                : 1;

                        foreach (var attr in structField.Attributes)
                        {
                            sw.WriteLine($"        {attr}");
                        }

                        sw.WriteLine
                        (
                            $"       public fixed {structField.Type} {structField.Name}[{count}];"
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
        public static void WriteNameContainer(this Project project, Profile profile, string file)
        {
            using var sw = new StreamWriter(file);

            sw.WriteLine(LicenseText.Value);
            sw.WriteLine("using Silk.NET.Core.Loader;");
            sw.WriteLine();
            sw.WriteLine($"namespace {profile.Namespace}{project.Namespace}");
            sw.WriteLine("{");
            sw.WriteLine("    /// <summary>");
            sw.WriteLine($"    /// Contains the library name of {profile.Name}.");
            sw.WriteLine("    /// </summary>");
            sw.WriteLine($"    internal class {profile.Names.ClassName} : SearchPathContainer");
            sw.WriteLine("    {");
            sw.WriteLine("        /// <inheritdoc />");
            sw.WriteLine($"        public override string Linux => \"{profile.Names.Linux}\";");
            sw.WriteLine();
            sw.WriteLine("        /// <inheritdoc />");
            sw.WriteLine($"        public override string MacOS => \"{profile.Names.MacOS}\";");
            sw.WriteLine();
            sw.WriteLine("        /// <inheritdoc />");
            sw.WriteLine($"        public override string Android => \"{profile.Names.Android}\";");
            sw.WriteLine();
            sw.WriteLine("        /// <inheritdoc />");
            sw.WriteLine($"        public override string IOS => \"{profile.Names.IOS}\";");
            sw.WriteLine();
            sw.WriteLine("        /// <inheritdoc />");
            sw.WriteLine($"        public override string Windows64 => \"{profile.Names.Windows}\";");
            sw.WriteLine();
            sw.WriteLine("        /// <inheritdoc />");
            sw.WriteLine($"        public override string Windows86 => \"{profile.Names.Windows}\";");
            sw.WriteLine("    }");
            sw.WriteLine("}");
        }

        /// <summary>
        /// Write mixed-mode (partial) classes.
        /// </summary>
        /// <param name="project">The current project.</param>
        /// <param name="profile">The profile to write mixed-mode classes for.</param>
        /// <param name="folder">The folder to store the generated classes in.</param>
        public static void WriteMixedModeClasses(this Project project, Profile profile, string folder)
        {
            // public abstract class MixedModeClass : IMixedModeClass
            // {
            // }
            if (project.IsRoot)
            {
                var sw = new StreamWriter(Path.Combine(folder, $"{profile.ClassName}.gen.cs"));
                sw.Write(LicenseText.Value);
                sw.WriteLine("using System;");
                sw.WriteLine("using System.Runtime.InteropServices;");
                sw.WriteLine("using System.Text;");
                sw.WriteLine("using Silk.NET.Core.Native;");
                sw.WriteLine("using Silk.NET.Core.Loader;");
                sw.WriteLine("using Ultz.SuperInvoke;");
                sw.WriteLine();
                sw.WriteLine("#pragma warning disable 1591");
                sw.WriteLine();
                sw.WriteLine($"namespace {profile.Namespace}{project.Namespace}");
                sw.WriteLine("{");
                sw.WriteLine
                    ($"    public abstract unsafe partial class {profile.ClassName} : NativeAPI");
                sw.WriteLine("    {");
                foreach (var constant in profile.Constants)
                {
                    sw.WriteLine($"        public const {constant.Type} {constant.Name} = {constant.Value};");
                }

                sw.WriteLine();

                var allFunctions = project.Interfaces.SelectMany(x => x.Value.Functions).RemoveDuplicates().ToArray();
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
                    using (var sr = new StringReader(function.ToString()))
                    {
                        string line;
                        var flPrefix = "public abstract ";
                        while ((line = sr.ReadLine()) != null)
                        {
                            sw.WriteLine($"        {flPrefix}{line}");
                            flPrefix = string.Empty;
                        }
                    }

                    sw.WriteLine();
                }

                foreach (var overload in Overloader.GetOverloads(allFunctions, profile.Projects["Core"]))
                {
                    using (var sr = new StringReader(overload.Signature.Doc))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            sw.WriteLine($"        {line}");
                        }
                    }

                    foreach (var attr in overload.Signature.Attributes)
                    {
                        sw.WriteLine($"        [{attr.Name}({string.Join(", ", attr.Arguments)})]");
                    }

                    sw.WriteLine($"        public {overload.Signature.ToString(overload.IsUnsafe).TrimEnd(';')}");
                    sw.WriteLine("        {");
                    foreach (var line in overload.Body)
                    {
                        sw.WriteLine($"            {line}");
                    }

                    sw.WriteLine("        }");
                    sw.WriteLine();
                }

                sw.WriteLine("        private SearchPathContainer _searchPaths;");
                sw.WriteLine
                (
                     "        public override SearchPathContainer SearchPaths => _searchPaths ??= " +
                    $"new {profile.Names.ClassName}();"
                );
                sw.WriteLine();
                sw.WriteLine($"        public {profile.ClassName}(ref NativeApiContext ctx)");
                sw.WriteLine("            : base(ref ctx)");
                sw.WriteLine("        {");
                sw.WriteLine("        }");
                if (profile.SymbolLoaderName != null)
                {
                    sw.WriteLine();
                    sw.WriteLine($"        static {profile.ClassName}()");
                    sw.WriteLine("        {");
                    sw.WriteLine
                        ($"            LibraryLoader.CreateBuilder<{profile.ClassName}>({profile.SymbolLoaderName});");
                    sw.WriteLine("        }");
                }

                sw.WriteLine("    }");
                sw.WriteLine("}");
                sw.WriteLine();
                sw.Flush();
                sw.Dispose();
                if (!File.Exists(Path.Combine(folder, $"{profile.ClassName}.cs")))
                {
                    sw = new StreamWriter(Path.Combine(folder, $"{profile.ClassName}.cs"));
                    sw.WriteLine("using System;");
                    sw.WriteLine("using Silk.NET.Core.Loader;");
                    sw.WriteLine("using Silk.NET.Core.Native;");
                    sw.WriteLine();
                    sw.WriteLine("#pragma warning disable 1591");
                    sw.WriteLine();
                    sw.WriteLine($"namespace {profile.Namespace}{project.Namespace}");
                    sw.WriteLine("{");
                    sw.WriteLine($"    public partial class {profile.ClassName}");
                    sw.WriteLine("    {");
                    sw.WriteLine($"        public static {profile.ClassName} GetApi()");
                    sw.WriteLine("        {");
                    sw.WriteLine
                    (
                        $"             return LibraryLoader<{profile.ClassName}>.Load(new {profile.Names.ClassName}());"
                    );
                    sw.WriteLine("        }");
                    sw.WriteLine();
                    sw.WriteLine("        public bool TryGetExtension<T>(out T ext)");
                    sw.WriteLine($"            where T:NativeExtension<{profile.ClassName}>");
                    sw.WriteLine("        {");
                    sw.WriteLine($"             ext = LibraryLoader<{profile.ClassName}>.Load<T>(this);");
                    sw.WriteLine("             return ext != null;");
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

                project.WriteNameContainer(profile, Path.Combine(folder, $"{profile.Names.ClassName}.cs"));
            }
            else
            {
                foreach (var (key, i) in project.Interfaces)
                {
                    var name = i.Name.Substring(1);
                    var sw = new StreamWriter(Path.Combine(folder, $"{name}.gen.cs"));
                    sw.Write(LicenseText.Value);
                    sw.WriteLine("using System;");
                    sw.WriteLine("using System.Runtime.InteropServices;");
                    sw.WriteLine("using System.Text;");
                    sw.WriteLine($"using {profile.Projects["Core"].GetNamespace(profile)};");
                    sw.WriteLine("using Silk.NET.Core.Loader;");
                    sw.WriteLine("using Silk.NET.Core.Native;");
                    sw.WriteLine("using Silk.NET.Core.Attributes;");
                    sw.WriteLine("using Ultz.SuperInvoke;");
                    sw.WriteLine();
                    sw.WriteLine("#pragma warning disable 1591");
                    sw.WriteLine();
                    sw.WriteLine($"namespace {profile.ExtensionsNamespace}{project.Namespace}");
                    sw.WriteLine("{");
                    sw.WriteLine($"    [Extension(\"{key}\")]");
                    sw.WriteLine
                    (
                        $"    public abstract unsafe partial class {name} : NativeExtension<{profile.ClassName}>"
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
                        using (var sr = new StringReader(function.ToString()))
                        {
                            string line;
                            var flPrefix = "public abstract ";
                            while ((line = sr.ReadLine()) != null)
                            {
                                sw.WriteLine($"        {flPrefix}{line}");
                                flPrefix = string.Empty;
                            }
                        }

                        sw.WriteLine();
                    }

                    foreach (var overload in Overloader.GetOverloads(i, profile.Projects["Core"]))
                    {
                        using (var sr = new StringReader(overload.Signature.Doc))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                sw.WriteLine($"        {line}");
                            }
                        }

                        foreach (var attr in overload.Signature.Attributes)
                        {
                            sw.WriteLine($"        [{attr.Name}({string.Join(", ", attr.Arguments)})]");
                        }

                        sw.WriteLine($"        public {overload.Signature.ToString(overload.IsUnsafe).TrimEnd(';')}");
                        sw.WriteLine("        {");
                        foreach (var line in overload.Body)
                        {
                            sw.WriteLine($"            {line}");
                        }

                        sw.WriteLine("        }");
                        sw.WriteLine();
                    }

                    sw.WriteLine($"        public {name}(ref NativeApiContext ctx)");
                    sw.WriteLine("            : base(ref ctx)");
                    sw.WriteLine("        {");
                    sw.WriteLine("        }");
                    sw.WriteLine("    }");
                    sw.WriteLine("}");
                    sw.WriteLine();
                    sw.Flush();
                }
            }
        }

        /// <summary>
        /// Writes this project in the given folder, with the given settings and parent subsystem.
        /// </summary>
        /// <param name="project">The project to write.</param>
        /// <param name="folder">The folder to write this project to.</param>
        /// <param name="profile">The parent subsystem.</param>
        public static void Write(this Project project, string folder, Profile profile)
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

            project.WriteProjectFile(folder, profile);

            project.Structs.ForEach
            (
                x => x.WriteStruct
                (
                    Path.Combine(folder, StructsSubfolder, $"{x.Name}.gen.cs"), profile, project
                )
            );

            project.Enums.ForEach
            (
                x => x.WriteEnum(Path.Combine(folder, EnumsSubfolder, $"{x.Name}.gen.cs"), profile, project)
            );

            project.WriteMixedModeClasses(profile, folder);
        }

        /// <summary>
        /// Writes the project file to the given folder.
        /// </summary>
        /// <param name="project">The project to write.</param>
        /// <param name="folder">The folder that should contain the project file.</param>
        /// <param name="prof">The parent profile.</param>
        private static void WriteProjectFile(this Project project, string folder, Profile prof)
        {
            if (File.Exists(Path.Combine(folder, $"{project.GetProjectName(prof)}.csproj")))
            {
                return;
            }

            var csproj = new StreamWriter(Path.Combine(folder, $"{project.GetProjectName(prof)}.csproj"));
            csproj.WriteLine("<Project Sdk=\"Microsoft.NET.Sdk\">");
            csproj.WriteLine();
            csproj.WriteLine("  <PropertyGroup>");
            csproj.WriteLine("    <TargetFramework>netstandard2.0</TargetFramework>");
            csproj.WriteLine("    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>");
            csproj.WriteLine("    <LangVersion>latest</LangVersion>");
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
                        Binder.CliOptions.OutputPath,
                        prof.OutputFolder,
                        prof.Projects["Core"].GetProjectName(prof),
                        $"{prof.Projects["Core"].GetProjectName(prof)}.csproj"
                    )
                );
                csproj.WriteLine($"    <ProjectReference Include=\"{core}\" />");
            }

            csproj.WriteLine("  </ItemGroup>");
            csproj.WriteLine();
            csproj.WriteLine($"  <Import Project=\"{Path.GetRelativePath(folder, Binder.CliOptions.Props)}\" />");
            csproj.WriteLine("</Project>");
            csproj.Flush();
            csproj.Dispose();
        }

        /// <summary>
        /// Writes all of the projects, interfaces, and enums to disk.
        /// </summary>
        /// <param name="profile">The profile containing the profiles, interfaces, and enums.</param>
        public static void Flush(this Profile profile)
        {
            var outFolder = profile.OutputFolder;
            var rootFolder = Path.Combine(Binder.CliOptions.OutputPath, outFolder);
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
                            ? Path.Combine(rootFolder, x.Value.GetProjectName(profile))
                            : Path.Combine(rootFolder, "Extensions", x.Value.GetProjectName(profile)),
                        profile
                    )
            );
            Console.WriteLine($"Successfully wrote \"{profile.Name}\" to disk.");
        }
    }
}
