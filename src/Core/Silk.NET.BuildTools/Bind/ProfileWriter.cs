// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
        public static void Flush(this Profile profile, BindTask originalTask)
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
            profile.Projects.ForEach
            (
                x =>
                    x.Value.Write
                    (
                        !task.Task.Controls.Contains("no-extra-dir") ?
                        x.Key == "Core"
                            ? Path.Combine(rootFolder, x.Value.GetProjectName(task.Task))
                            : Path.Combine(rootFolder, "Extensions", x.Value.GetProjectName(task.Task)) :
                        x.Key == "Core"
                            ? Path.Combine(rootFolder)
                            : Path.Combine(rootFolder, "Extensions"),
                        profile,
                        task
                    )
            );
            Console.WriteLine($"Successfully wrote \"{profile.Name}\" to disk.");
        }
    }
}
