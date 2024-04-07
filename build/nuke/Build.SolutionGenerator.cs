// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.Build.Locator;
using NuGet.Packaging;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Utilities;
using Serilog;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.ProjectModel.ProjectModelTasks;

partial class Build
{
    [Parameter
    (
        "If specified, generates a solution including only the specified projects or group of projects. You can " +
        "provide individual project names or the name of the folder in which they're contained e.g. \"--projects " +
        "opengl examples/csharp vulkan microsoft core.win32extras silk.net.opencl\". The Silk.NET prefix for " +
        "individual projects is optional, but folder names will be preferred over project names so if you only want " +
        "\"Silk.NET.Vulkan\" and not everything in \"src/Vulkan\", use \"--projects silk.net.vulkan\". The solution " +
        "include project dependencies. The solution will be regenerated whenever you run a NUKE build with this " +
        "specified, but if you don't want to run a build just use \"nuke sln --projects ...\" to run a dummy target."
    )]
    readonly string[] Projects;

    [Parameter("If specified, ignores any generated solution present and builds the entire project.", Name = "All")]
    readonly bool BuildAll;

    Solution GeneratedSolution;

    Solution Solution => GeneratedSolution ?? (File.Exists(RootDirectory / "Silk.NET.gen.sln") && !BuildAll
        ? ParseSolution(RootDirectory / "Silk.NET.gen.sln")
        : OriginalSolution);

    void GenerateSolution()
    {
        if (Projects is not { Length: > 0 })
        {
            Log.Verbose("Nothing to do for GenerateSolution.");
            return;
        }

        if (File.Exists(RootDirectory / "Silk.NET.gen.sln"))
        {
            DeleteFile(RootDirectory / "Silk.NET.gen.sln");
        }

        AbsolutePath Concat(AbsolutePath path, string next)
        {
            if (!Directory.Exists(path))
            {
                return path / next;
            }

            foreach (var dir in Directory.EnumerateDirectories(path))
            {
                if (string.Equals(Path.GetFileName(dir), next, StringComparison.OrdinalIgnoreCase))
                {
                    return (AbsolutePath) dir;
                }
            }

            return path / next;
        }

        var include = OriginalSolution.GetProjects("*")
            .Where
            (
                project => Projects.Any
                (
                    x => string.Equals(project.Name, x, StringComparison.OrdinalIgnoreCase) ||
                         Concat(RootDirectory / "src", x).Contains(project.Path) ||
                         Concat(RootDirectory / "examples" / "CSharp", x).Contains(project.Path) ||
                         Concat(RootDirectory, x).Contains(project.Path) ||
                         string.Equals(project.Name, $"Silk.NET.{x}", StringComparison.OrdinalIgnoreCase)
                )
            )
            .Select(x => (string) x.Path)
            .ToList();

        // because this is a for loop and not a foreach loop, we don't need multiple passes because we'll naturally
        // carry on to go over the latest items added at the end!
        for (var i = 0; i < include.Count; i++)
        {
            var projPath = include[i];
            include.AddRange
            (
                OriginalSolution.GetProjects("*")
                    .First(x => x.Path == projPath)
                    .GetItems("ProjectReference")
                    .Select(x => Path.GetFullPath(x, ((AbsolutePath) projPath).Parent))
                    .Where(x => !include.Contains(x))
            );
        }

        // make a new Solution object to prevent us mutating the OriginalSolution
        var genSln = ParseSolution(OriginalSolution.Path);

        // remove irrelevant projects
        foreach (var project in genSln.GetProjects("*"))
        {
            if (!include.Contains(project.Path))
            {
                genSln.RemoveProject(project);
            }
        }

        genSln.SaveAs(RootDirectory / "Silk.NET.gen.sln");
        Log.Information($"Generated solution containing {genSln.AllProjects.Count} projects");
    }

    Target Sln => CommonTarget();
}
