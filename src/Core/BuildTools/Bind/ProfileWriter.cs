// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using MoreLinq.Extensions;
using Silk.NET.BuildTools.Common;
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
        /// The name of the subfolder containing <see cref="Interface" />s.
        /// </summary>
        public const string InterfacesSubfolder = "Interfaces";

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
            sw.WriteLine("using System;");
            sw.WriteLine();
            var ns = project.IsRoot ? profile.Namespace : profile.ExtensionsNamespace;
            sw.WriteLine("namespace " + ns + project.Namespace);
            sw.WriteLine("{");
            foreach (var attr in @enum.Attributes)
            {
                sw.WriteLine("    " + attr);
            }

            sw.WriteLine("    public enum " + @enum.Name);
            sw.WriteLine("    {");
            for (var index = 0; index < @enum.Tokens.Count; index++)
            {
                var token = @enum.Tokens[index];

                sw.WriteLine
                (
                    "        " + token.Name + " = " + token.Value +
                    (index != @enum.Tokens.Count ? "," : string.Empty)
                );
            }

            sw.WriteLine("    }");
            sw.WriteLine("}");
            sw.Flush();
            sw.Dispose();
        }

        /// <summary>
        /// Writes this interface to a file.
        /// </summary>
        /// <param name="interface">The interface.</param>
        /// <param name="file">The file to write to.</param>
        /// <param name="profile">The subsystem containing this interface.</param>
        /// <param name="project">The project containing this interface.</param>
        public static void WriteInterface(this Interface @interface, string file, Profile profile, Project project)
        {
            var sw = new StreamWriter(file);
            sw.WriteLine(LicenseText.Value);
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Runtime.InteropServices;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("using Silk.NET.Core.Native;");
            sw.WriteLine("using AdvancedDLSupport;");
            sw.WriteLine();
            var ns = project.IsRoot ? profile.Namespace : profile.ExtensionsNamespace;
            sw.WriteLine("namespace " + ns + project.Namespace);
            sw.WriteLine("{");
            foreach (var attr in @interface.Attributes)
            {
                sw.WriteLine("    " + attr);
            }

            sw.WriteLine("    public interface " + @interface.Name);
            sw.Write("    {");
            for (var index = 0; index < @interface.Functions.Count; index++)
            {
                sw.WriteLine();
                var function = @interface.Functions[index];
                using (var sr = new StringReader(function.Doc))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        sw.WriteLine("        " + line);
                    }
                }

                foreach (var attr in function.Attributes)
                {
                    sw.WriteLine("        " + attr);
                }

                sw.WriteLine
                (
                    "        [NativeSymbol(\"" + profile.FunctionPrefix + function.NativeName + "\")]"
                );
                using (var sr = new StringReader(function.ToString()))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        sw.WriteLine("        " + line);
                    }
                }
            }

            sw.WriteLine("    }");
            sw.WriteLine("}");
            sw.Flush();
            sw.Dispose();
        }

        public static void WriteMetaInterface(this Project project, Profile profile, string file)
        {
            var sw = new StreamWriter(file);
            sw.WriteLine(LicenseText.Value);
            sw.WriteLine("namespace " + profile.Namespace + project.Namespace);
            sw.WriteLine("{");
            var names = project.Interfaces.Select(x => x.Value.Name).ToArray();
            sw.Write("    public interface I" + profile.ClassName + " : " + names[0]);
            for (var i = 1; i < names.Length; i++)
            {
                sw.WriteLine(",");
                sw.Write("        " + names[i]);
            }

            sw.WriteLine();
            sw.WriteLine("    {");
            sw.WriteLine("    }");
            sw.WriteLine("}");
            sw.Flush();
            sw.Close();
        }
        
        public static void WriteNameContainer(this Project project, Profile profile, string file)
        {
            using (var sw = new StreamWriter(file))
            {
                sw.WriteLine(LicenseText.Value);
                sw.WriteLine("using Silk.NET.Core.Loader;");
                sw.WriteLine();
                sw.WriteLine("namespace " + profile.Namespace + project.Namespace);
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
        }

        public static void WriteMixedModeClasses(this Project project, Profile profile, string folder)
        {
            // public abstract class MixedModeClass : IMixedModeClass
            // {
            // }
            if (project.IsRoot)
            {
                var sw = new StreamWriter(Path.Combine(folder, profile.ClassName + ".gen.cs"));
                sw.Write(LicenseText.Value);
                sw.WriteLine("using System;");
                sw.WriteLine("using System.Runtime.InteropServices;");
                sw.WriteLine("using System.Text;");
                sw.WriteLine("using Silk.NET.Core.Native;");
                sw.WriteLine("using Silk.NET.Core.Loader;");
                sw.WriteLine("using AdvancedDLSupport;");
                sw.WriteLine();
                sw.WriteLine("namespace " + profile.Namespace + project.Namespace);
                sw.WriteLine("{");
                sw.WriteLine($"    public abstract partial class {profile.ClassName} : NativeAPI, I{profile.ClassName}");
                sw.WriteLine("    {");
                var allFunctions = project.Interfaces.SelectMany(x => x.Value.Functions).RemoveDuplicates();
                foreach (var function in allFunctions)
                {
                    sw.WriteLine("        /// <inheritdoc />");
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
                sw.WriteLine
                (
                    "        public override SearchPathContainer SearchPaths { get; } = new "
                             + profile.Names.ClassName + "();"
                );
                sw.WriteLine();
                sw.WriteLine($"        public {profile.ClassName}(string path, ImplementationOptions opts)");
                sw.WriteLine("            : base(path, opts)");
                sw.WriteLine("        {");
                sw.WriteLine("        }");
                sw.WriteLine("    }");
                sw.WriteLine("}");
                sw.WriteLine();
                sw.Flush();
                sw.Dispose();
                if (!File.Exists(Path.Combine(folder, profile.ClassName + ".cs")))
                {
                    sw = new StreamWriter(Path.Combine(folder, profile.ClassName + ".cs"));
                    sw.WriteLine("using System;");
                    sw.WriteLine("using Silk.NET.Core.Loader;");
                    sw.WriteLine("using Silk.NET.Core.Native;");
                    sw.WriteLine();
                    sw.WriteLine("namespace " + profile.Namespace + project.Namespace);
                    sw.WriteLine("{");
                    sw.WriteLine("    partial class " + profile.ClassName);
                    sw.WriteLine("    {");
                    sw.WriteLine("        public static " + profile.ClassName + " GetApi()");
                    sw.WriteLine("        {");
                    sw.WriteLine($"             return LibraryLoader<{profile.ClassName}>.Load(new {profile.Names.ClassName}());");
                    sw.WriteLine("        }");
                    sw.WriteLine();
                    sw.WriteLine("        public bool TryGetExtension<T>(out T ext)");
                    sw.WriteLine("            where T:NativeExtension<" + profile.ClassName + ">");
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
                
                project.WriteNameContainer(profile, Path.Combine(folder, profile.Names.ClassName + ".cs"));
            }
            else
            {
                foreach (var (key, i) in project.Interfaces)
                {
                    var name = key.Substring(1);
                    var sw = new StreamWriter(Path.Combine(folder, name + ".gen.cs"));
                    sw.Write(LicenseText.Value);
                    sw.WriteLine("using System;");
                    sw.WriteLine("using System.Runtime.InteropServices;");
                    sw.WriteLine("using System.Text;");
                    sw.WriteLine("using " + profile.Projects["Core"].GetNamespace(profile) + ";");
                    sw.WriteLine("using Silk.NET.Core.Loader;");
                    sw.WriteLine("using Silk.NET.Core.Native;");
                    sw.WriteLine("using AdvancedDLSupport;");
                    sw.WriteLine();
                    sw.WriteLine("namespace " + profile.ExtensionsNamespace + project.Namespace);
                    sw.WriteLine("{");
                    sw.WriteLine($"    public abstract partial class {name} : NativeExtension<{profile.ClassName}>, I{name}");
                    sw.WriteLine("    {");
                    foreach (var function in i.Functions)
                    {
                        sw.WriteLine("        /// <inheritdoc />");
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
                    sw.WriteLine();
                    sw.WriteLine($"        public {name}(string path, ImplementationOptions opts)");
                    sw.WriteLine("            : base(path, opts)");
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

            if (!Directory.Exists(Path.Combine(folder, InterfacesSubfolder)))
            {
                Directory.CreateDirectory(Path.Combine(folder, InterfacesSubfolder));
            }

            project.WriteProjectFile(folder, profile);

            project.Interfaces.ForEach(x => x.Value.WriteInterface
            (
                Path.Combine(folder, InterfacesSubfolder, x.Value.Name + ".gen.cs"), profile, project)
            );

            project.Enums.ForEach
            (
                x => x.WriteEnum(Path.Combine(folder, EnumsSubfolder, x.Name + ".gen.cs"), profile, project)
            );

            if (project.IsRoot)
            {
                project.WriteMetaInterface
                (
                    profile,
                    Path.Combine(folder, InterfacesSubfolder, "I" + profile.FunctionPrefix.ToUpper() + ".gen.cs")
                );
            }

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
            if (File.Exists(Path.Combine(folder, project.GetProjectName(prof) + ".csproj")))
            {
                return;
            }

            Debug.WriteLine(folder + "/" + project.GetProjectName(prof) + ".csproj");
            var csproj = new StreamWriter(Path.Combine(folder, project.GetProjectName(prof) + ".csproj"));
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
                        prof.Projects["Core"].GetProjectName(prof) + ".csproj"
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

            Console.WriteLine("Loaded \"" + profile.Name + "\", writing " + profile.Projects.Count + " projects...");
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
            Console.WriteLine("Successfully wrote \"" + profile.Name + "\" to disk.");
        }
    }
}
