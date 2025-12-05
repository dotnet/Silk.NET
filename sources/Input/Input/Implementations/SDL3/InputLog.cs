// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Silk.NET.Input.SDL3;

internal static class InputLog
{
    [Conditional("DEBUG")]
    public static void Error(string? message = null,
        [CallerFilePath] string? path = null,
        [CallerLineNumber] int line = 0,
        [CallerMemberName] string? member = null)
    {
        var log = GenerateLog(message, path, line, member);
        Console.Error.WriteLine(log);
    }

    private static string GenerateLog(string? message, string? path, int line, string? member)
    {
        const string traceFmt = "{0} at {1}:{2}";
        return  $"{message} ({string.Format(traceFmt, member, path, line)})";
    }

    [Conditional("DEBUG")]
    public static void Debug(string? message = null,
        [CallerFilePath] string? path = null,
        [CallerLineNumber] int line = 0,
        [CallerMemberName] string? member = null)
    {
        var log = GenerateLog(message, path, line, member);
        Console.WriteLine(log);
    }
}
