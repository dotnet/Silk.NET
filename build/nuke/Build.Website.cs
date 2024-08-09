// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.IO;
using System.Runtime.InteropServices;
using Nuke.Common;
using Nuke.Common.ProjectModel;
using Nuke.Common.Utilities.Collections;
using Nuke.Common.Tools.Npm;

partial class Build
{
    static string workingDirectory = "./website";

    Target Website => _ => _
        .Executes(() =>
        {
            Console.WriteLine("Verifying dependences:\n");

            Assert.True(VerifyDependences());

            if (Configuration == "Debug")
            {
                Console.WriteLine("Running website in debug mode (it may take a while)");
                NpmTasks.Npm("run docusaurus start", workingDirectory, null, null, false);
            }
            else
            {
                Console.WriteLine("Building website for production");
                NpmTasks.Npm("run docusaurus build", workingDirectory);
            }
        });

    static bool VerifyDependences()
    {
        Console.Write("Node.js ... ");

        var nodePath = GetExecutablePath("node");
        if (string.IsNullOrEmpty(nodePath))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\rNode.js not found!\n");
            Console.ResetColor();
            Console.WriteLine("Please, make sure node.js is installed on your machine!");
            Console.WriteLine("Dowload node here => https://nodejs.org/en/download");
            Console.WriteLine();
            return false;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("OK");
            Console.ResetColor();
        }

        Console.Write("Node Package Mananger ... ");

        var npmPath = GetExecutablePath("npm");
        if (string.IsNullOrEmpty(nodePath))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\rNode Package Mananger not found!\n");
            Console.ResetColor();
            Console.WriteLine("Please, make sure node.js is working and updated on your machine!");
            Console.WriteLine();
            return false;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("OK");
            Console.ResetColor();
        }

        Console.Write("Node Modules ... ");

        if (!Directory.Exists($"{workingDirectory}/node_modules"))
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\rNode modules not found. Installing modules...\n");
            Console.ResetColor();

            NpmTasks.Npm("install", workingDirectory);

            Console.Write("Node Modules ... ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("OK");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("OK");
            Console.ResetColor();
        }

        return true;
    }

    static string GetExecutablePath(string execName)
    {
        var paths = Environment.GetEnvironmentVariable("PATH").Split(Path.PathSeparator);

        string[] extensions = RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
        ? Environment.GetEnvironmentVariable("PATHEXT").Split(';')
        : [""];

        foreach (var path in paths)
        {
            foreach (var ext in extensions)
            {
                var fullPath = Path.Combine(path, execName + ext.ToLower());
                if (File.Exists(fullPath)) return fullPath;
            }
        }

        return null;
    }
}
