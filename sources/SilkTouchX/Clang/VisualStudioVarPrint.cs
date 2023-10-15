// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace SilkTouchX.Clang;

internal static class VisualStudioVarPrint
{
    private static readonly string _varPrintScriptNamespace =
        $"{typeof(VisualStudioVarPrint).FullName}.bat";

    private static string? _cachedPath;

    public static bool TryExtractIfNeeded([NotNullWhen(true)] out string? scriptPath)
    {
        if (_cachedPath is not null)
        {
            scriptPath = _cachedPath;
            return true;
        }

        // extract the varprint script
        var varPrint = Path.Combine(Path.GetTempPath(), $"{Path.GetRandomFileName()}.bat");
        using var varPrintRes = typeof(VisualStudioResolver).Assembly.GetManifestResourceStream(
            _varPrintScriptNamespace
        );
        if (varPrintRes is null)
        {
            Console.WriteLine($"Couldn't extract \"{_varPrintScriptNamespace}\" from assembly.");
            scriptPath = null;
            return false;
        }

        using var varPrintOut = File.OpenWrite(varPrint);
        varPrintRes.CopyTo(varPrintOut);

        scriptPath = _cachedPath = varPrint;
        return true;
    }

    public static bool TryRun(
        string vsPath,
        [NotNullWhen(true)] out Dictionary<string, string>? vars
    )
    {
        if (!TryExtractIfNeeded(out var varPrint))
        {
            vars = null;
            return false;
        }

        using var varPrintProc = new Process();
        varPrintProc.StartInfo = new()
        {
            FileName = "cmd",
            Arguments = $"/c \"{varPrint}\"",
            WorkingDirectory = vsPath,
            UseShellExecute = false,
            RedirectStandardOutput = true,
            CreateNoWindow = true
        };

        vars = null;
        varPrintProc.Start();
        while (!varPrintProc.StandardOutput.EndOfStream)
        {
            var line = varPrintProc.StandardOutput.ReadLine();
            if (line is null)
            {
                continue;
            }

            Debug.WriteLine(line);

            switch (line)
            {
                case "***VARSTART***":
                {
                    vars = new();
                    continue;
                }
                case "***VAREND***":
                {
                    vars ??= new(); // CS8762
                    return true;
                }
                default:
                {
                    if (vars is not null)
                    {
                        var split = line.Split('=');
                        vars.TryAdd(split[0], split[1]);
                    }

                    break;
                }
            }
        }

        varPrintProc.WaitForExit();
        vars = null;
        return false;
    }
}
