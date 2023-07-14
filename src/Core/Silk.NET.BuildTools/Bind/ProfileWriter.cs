// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using Humanizer;
using MoreLinq.Extensions;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;
using Silk.NET.BuildTools.Common.Structs;
using Silk.NET.BuildTools.Cpp;
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

        public static void WriteCoreUsings(this StreamWriter sw)
        {
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Runtime.InteropServices;");
            sw.WriteLine("using System.Runtime.CompilerServices;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("using Silk.NET.Core;");
            sw.WriteLine("using Silk.NET.Core.Native;");
            sw.WriteLine("using Silk.NET.Core.Attributes;");
            sw.WriteLine("using Silk.NET.Core.Contexts;");
            sw.WriteLine("using Silk.NET.Core.Loader;");
        }

        public static string LicenseText(this BindState task) => CachedLicenseTexts.TryGetValue
            (task.Task.OutputOpts.License, out var val)
            ? val
            : CachedLicenseTexts[task.Task.OutputOpts.License] = File.ReadAllText(task.Task.OutputOpts.License);

        /// <summary>
        /// Writes all of the projects, interfaces, and enums to disk.
        /// </summary>
        /// <param name="profile">The profile containing the profiles, interfaces, and enums.</param>
        public static void Flush(this Profile profile, BindTask originalTask, Config config)
        {
            var task = new BindState(originalTask);
            var rootFolder = task.Task.OutputOpts.Folder;
            if (!Directory.Exists(rootFolder))
            {
                Directory.CreateDirectory(rootFolder);
            }

            if (!Directory.Exists(Path.Combine(rootFolder, "Extensions")))
            {
                Directory.CreateDirectory(Path.Combine(rootFolder, "Extensions"));
            }

            Console.WriteLine($"Loaded \"{profile.Name}\", writing {profile.Projects.Count} projects...");
            foreach (var proj in profile.Projects)
            {
                var folder = !task.Task.Controls.Contains("no-extra-dir")
                    ? proj.Key == "Core"
                        ? Path.Combine(rootFolder, proj.Value.GetProjectName(task.Task))
                        : Path.Combine(rootFolder, "Extensions", proj.Value.GetProjectName(task.Task))
                    : proj.Key == "Core"
                        ? Path.Combine(rootFolder)
                        : Path.Combine(rootFolder, "Extensions");
                var tmpFolder = folder;
                var doCheck = Directory.Exists(folder) && !originalTask.Controls.Contains("no-temp-dirs");
                if (doCheck)
                {
                    tmpFolder = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
                    Directory.CreateDirectory(tmpFolder);
                }

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                proj.Value.WriteProjectFile(folder, profile, task);

                folder = originalTask.OutputOpts.Subfolder is null
                    ? folder
                    : Path.Combine(folder, originalTask.OutputOpts.Subfolder);
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                proj.Value.WriteGeneratedCode(tmpFolder, folder, profile, task);
                if (doCheck)
                {
                    var filesBefore = Directory.GetFiles(folder, "*", SearchOption.AllDirectories)
                        .Where(x => x.EndsWith(".cs"))
                        .Where
                        (
                            x => config.Tasks.All
                            (
                                y => y.OutputOpts.Folder == originalTask.OutputOpts.Folder ||
                                     !(Path.GetFullPath(x).StartsWith(Path.GetFullPath(y.OutputOpts.Folder)) && !Path.GetFullPath(originalTask.OutputOpts.Folder).StartsWith(Path.GetFullPath(y.OutputOpts.Folder)))
                            )
                        )
                        .ToDictionary(x => Path.GetRelativePath(folder, x), x => x);
                    
                    var filesAfter = Directory.GetFiles(tmpFolder, "*", SearchOption.AllDirectories)
                        .Where(x => x.EndsWith(".cs"))
                        .Where
                        (
                            x => config.Tasks.All
                            (
                                y => y.OutputOpts.Folder == originalTask.OutputOpts.Folder ||
                                     !(Path.GetFullPath(x).StartsWith(Path.GetFullPath(y.OutputOpts.Folder)) && !Path.GetFullPath(originalTask.OutputOpts.Folder).StartsWith(Path.GetFullPath(y.OutputOpts.Folder)))
                            )
                        )
                        .ToDictionary(x => Path.GetRelativePath(tmpFolder, x), x => x);

                    var added = 0;
                    var updated = 0;
                    var deleted = 0;
                    var upToDate = 0;
                    foreach (var (rel, fileAfter) in filesAfter)
                    {
                        if (!filesBefore.TryGetValue(rel, out var fileBefore))
                        {
                            added++;
                            var dir = Path.GetDirectoryName(Path.Combine(folder, rel));
                            if (!string.IsNullOrWhiteSpace(dir) && !Directory.Exists(dir))
                            {
                                Directory.CreateDirectory(dir);
                            }
                            
                            ResilientCopy(fileAfter, Path.Combine(folder, rel), true);
                        }
                        else if (File.ReadAllText(fileBefore) != File.ReadAllText(fileAfter) && rel.EndsWith(".gen.cs"))
                        {
                            updated++;
                            ResilientCopy(fileAfter, fileBefore, true);
                        }
                        else
                        {
                            upToDate++;
                        }
                    }

                    foreach (var (rel, fileBefore) in filesBefore)
                    {
                        if (rel.EndsWith(".gen.cs") && !filesAfter.ContainsKey(rel) && !originalTask.Controls.Contains("keep-unknown-gen-files"))
                        {
                            deleted++;
                            ResilientDelete(fileBefore);
                        }
                    }
                    
                    Console.WriteLine
                    (
                        $"{added} files added, {updated} files modified, {deleted} files deleted, and {upToDate} " +
                        "files already up-to-date."
                    );

                    Directory.Delete(tmpFolder, true);
                }
            }

            Console.WriteLine($"Successfully wrote \"{profile.Name}\" to disk.");
        }

        private static void ResilientCopy(string from, string to, bool overwrite = false)
        {
            for (var i = 1; i <= 4; i++)
            {
                try
                {
                    File.Copy(from, to, overwrite);
                }
                catch (IOException ex)
                {
                    if (i < 3)
                    {
                        Console.WriteLine
                        (
                            $"{i.Ordinalize()} attempt at writing to \"{to}\": {ex.Message}"
                        );
                        
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        throw;
                    }
                }
            }
        }
        
        private static void ResilientDelete(string file)
        {
            for (var i = 1; i <= 4; i++)
            {
                try
                {
                    File.Delete(file);
                }
                catch (IOException ex)
                {
                    if (i < 3)
                    {
                        Console.WriteLine
                        (
                            $"{i.Ordinalize()} attempt at deleting \"{file}\": {ex.Message}"
                        );
                        
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        throw;
                    }
                }
            }
        }
    }
}
