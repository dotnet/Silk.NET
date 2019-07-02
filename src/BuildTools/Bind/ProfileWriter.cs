// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Generator.Common;
using MoreLinq.Extensions;
using Enum = Generator.Common.Enums.Enum;

namespace Generator.Bind
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

            sw.WriteLine("    public enum " + @enum.Name + " : uint");
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
            sw.Write(LicenseText.Value);
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Runtime.InteropServices;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("using Silk.NET.Core;");
            sw.WriteLine("using AdvancedDLSupport;");
            sw.WriteLine();
            var ns = project.IsRoot ? profile.Namespace : profile.ExtensionsNamespace;
            sw.WriteLine("namespace " + ns + project.Namespace);
            sw.WriteLine("{");
            foreach (var attr in @interface.Attributes)
            {
                sw.WriteLine("    " + attr);
            }

            sw.WriteLine("    internal interface " + @interface.Name);
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
            sw.Write(LicenseText.Value);
            sw.WriteLine();
            sw.WriteLine("namespace " + profile.Namespace + project.Namespace);
            sw.WriteLine("{");
            var names = project.Interfaces.Select(x => x.Value.Name).ToArray();
            sw.Write("    internal interface I" + profile.ClassName + " : " + names[0]);
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

        public static void WriteMixedModeClass(this Project project, Profile profile, string file)
        {
            // public abstract class MixedModeClass : IMixedModeClass
            // {
            // }
            var sw = new StreamWriter(file);
            sw.Write(LicenseText.Value);
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Runtime.InteropServices;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("using Silk.NET.Core;");
            sw.WriteLine("using AdvancedDLSupport;");
            sw.WriteLine();
            var ns = project.IsRoot ? profile.Namespace : profile.ExtensionsNamespace;
            sw.WriteLine("namespace " + ns + project.Namespace);
            sw.WriteLine("{");
            var nm = project.IsRoot ? profile.ClassName : project.Namespace.Split('.').Last();
            if (project.IsRoot)
            {
                
            }
            sw.Flush();
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
                Path.Combine(folder, InterfacesSubfolder, x.Value.Name + ".cs"), profile, project)
            );

            project.Enums.ForEach
            (
                x => x.WriteEnum(Path.Combine(folder, EnumsSubfolder, x.Name + ".cs"), profile, project)
            );

            if (project.IsRoot)
            {
                project.WriteMetaInterface
                (
                    profile, Path.Combine(folder, InterfacesSubfolder, "I" + profile.FunctionPrefix.ToUpper() + ".cs")
                );
            }

            var nm = project.IsRoot ? profile.ClassName : project.Namespace.Split('.').Last();
            project.WriteMixedModeClass(profile, Path.Combine(folder, nm) + ".gen.cs");
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
            csproj.WriteLine("    <RootNamespace>" + project.GetNamespace(prof) + "</RootNamespace>");
            csproj.WriteLine("    <AssemblyName>" + project.GetNamespace(prof) + "</AssemblyName>");
            csproj.WriteLine("  </PropertyGroup>");
            csproj.WriteLine();
            csproj.WriteLine("  <ItemGroup>");
            if (!project.IsRoot)
            {
                csproj.WriteLine
                (
                    "    <ProjectReference Include=\"$(SilkSolutionRoot)\\src\\" +
                    prof.OutputFolder + "\\" + prof.Projects["Core"].GetProjectName(prof)
                    + "\\" + prof.Projects["Core"].GetProjectName(prof) + ".csproj\" />"
                );
            }
            else
            {
                csproj.WriteLine
                (
                    "    <ProjectReference Include=\"$(SilkSolutionRoot)\\src\\OpenTK.Core\\OpenTK.Core.csproj\" />"
                );
            }

            csproj.WriteLine("  </ItemGroup>");
            csproj.WriteLine();
            if (!project.IsRoot)
            {
                csproj.WriteLine("  <Import Project=\"..\\..\\..\\..\\props\\common.props\" />");
            }
            else
            {
                csproj.WriteLine("  <Import Project=\"..\\..\\..\\props\\common.props\" />");
            }

            csproj.WriteLine("  <Import Project=\"$(SilkSolutionRoot)\\props\\nuget-common.props\" />");
            csproj.WriteLine("  <Import Project=\"$(SilkSolutionRoot)\\props\\stylecop.props\" />");
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
