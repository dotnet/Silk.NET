// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3;

internal static class SdlLog
{
    public static void Error(string? message = null,
        [CallerFilePath] string? path = null,
        [CallerLineNumber] int line = 0,
        [CallerMemberName] string? member = null)
    {
        var log = GenerateLog(message);
        InputLog.Error(log, path, line, member);
    }


    public static void Debug(string? message = null,
        [CallerFilePath] string? path = null,
        [CallerLineNumber] int line = 0,
        [CallerMemberName] string? member = null)
    {
        #if DEBUG
        var log = GenerateLog(message);
        InputLog.Debug(log, path, line, member);
        #else
        Sdl.ClearError();
        #endif
    }

    private static unsafe string GenerateLog(string? message)
    {
        var error = Sdl.GetError();
        if (error.Native != null)
        {
            var sdlError = error.ReadToString();
            Sdl.ClearError();
            return $"{message ?? "SDL Error: "} {sdlError}";
        }

        return message ?? "Error: ";
    }
}
