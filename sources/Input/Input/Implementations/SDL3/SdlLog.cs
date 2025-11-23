// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Runtime.CompilerServices;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3;

internal class SdlLog
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


    [Conditional("DEBUG")]
    public static void Debug(string? message = null,
        [CallerFilePath] string? path = null,
        [CallerLineNumber] int line = 0,
        [CallerMemberName] string? member = null)
    {
        var log = GenerateLog(message, path, line, member);
        Console.Out.WriteLine(log);
    }

    private static unsafe string GenerateLog(string? message, string? path, int line, string? member)
    {
        var error = Sdl.GetError();
        string log;
        const string traceFmt = "{0} at {1}:{2}";
        if (error.Native != null)
        {
            var sdlError = error.ReadToString();
            Sdl.ClearError();
            message ??= "SDL Error: ";
            log = $"{message} {sdlError} ({string.Format(traceFmt, member, path, line)})";
        }
        else
        {
            message ??= "Error: ";
            log = $"{message} ({string.Format(traceFmt, member, path, line)})";
        }

        return log;
    }
}
