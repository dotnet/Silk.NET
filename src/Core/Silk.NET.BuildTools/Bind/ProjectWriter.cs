// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Silk.NET.BuildTools.Common;

namespace Silk.NET.BuildTools.Bind
{
    public static class ProjectWriter
    {
        /// <summary>
        /// Creates a unique file name (that doesn't already exist), preventing clashes of names with different cases on
        /// case insensitive filesystems.
        /// </summary>
        /// <param name="name">The name (goes before any disambiguator)</param>
        /// <param name="ext">The extension (goes after any disambiguator)</param>
        /// <param name="directories">Any number of directory segements</param>
        /// <returns>A unique filename.</returns>
        private static string GetFileName(string name, string ext, params string[] directories)
        {
            var count = 1;
            string filename;
            Array.Resize(ref directories, directories.Length + 1);
            var nameIndex = directories.Length - 1;
            do
            {
                directories[nameIndex] = $"{name}{(count > 1 ? count.ToString() : "")}{ext}";
                filename = Path.Combine(directories);
                count++;
            } while (File.Exists(filename));

            return filename;
        }

        /// <summary>
        /// Writes this project in the given folder, with the given settings and parent subsystem.
        /// </summary>
        /// <param name="project">The project to write.</param>
        /// <param name="folder">The folder to write this project to.</param>
        /// <param name="profile">The parent subsystem.</param>
        public static void Write(this Project project, string folder, Profile profile, BindState task)
        {
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            if (!Directory.Exists(Path.Combine(folder, ProfileWriter.EnumsSubfolder)))
            {
                Directory.CreateDirectory(Path.Combine(folder, ProfileWriter.EnumsSubfolder));
            }

            if (!Directory.Exists(Path.Combine(folder, ProfileWriter.StructsSubfolder)))
            {
                Directory.CreateDirectory(Path.Combine(folder, ProfileWriter.StructsSubfolder));
            }

            project.WriteProjectFile(folder, profile, task);

            project.Structs.ForEach
            (
                x => x.WriteStruct
                (
                    GetFileName(x.Name, ".gen.cs", folder, ProfileWriter.StructsSubfolder), profile, project, task
                )
            );

            project.Enums.ForEach
            (
                x => x.WriteEnum
                (
                    GetFileName(x.Name, ".gen.cs", folder, ProfileWriter.EnumsSubfolder), profile, project, task
                )
            );

            project.WriteMixedModeClasses(profile, folder, task);
        }

        /// <summary>
        /// Writes the project file to the given folder.
        /// </summary>
        /// <param name="project">The project to write.</param>
        /// <param name="folder">The folder that should contain the project file.</param>
        /// <param name="prof">The parent profile.</param>
        private static void WriteProjectFile(this Project project, string folder, Profile prof, BindState task)
        {
            if (File.Exists(Path.Combine(folder, $"{project.GetProjectName(task.Task)}.csproj")) ||
                task.Task.Controls.Contains("no-csproj"))
            {
                return;
            }

            var csproj = new StreamWriter(Path.Combine(folder, $"{project.GetProjectName(task.Task)}.csproj"))
                {NewLine = "\n"};
            csproj.WriteLine("<Project Sdk=\"Microsoft.NET.Sdk\">");
            csproj.WriteLine();
            csproj.WriteLine("  <PropertyGroup>");
            csproj.WriteLine
                ("    <TargetFrameworks>netstandard2.0;netstandard2.1;netcoreapp3.1;net5.0</TargetFrameworks>");
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
                        task.Task.OutputOpts.Folder,
                        prof.Projects["Core"].GetProjectName(task.Task),
                        $"{prof.Projects["Core"].GetProjectName(task.Task)}.csproj"
                    )
                );
                csproj.WriteLine($"    <ProjectReference Include=\"{core}\" />");
            }

            csproj.WriteLine("  </ItemGroup>");
            csproj.WriteLine();
            csproj.WriteLine($"  <Import Project=\"{Path.GetRelativePath(folder, task.Task.OutputOpts.Props)}\" />");
            csproj.WriteLine("</Project>");
            csproj.Flush();
            csproj.Dispose();
        }
    }
}
