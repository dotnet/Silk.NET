// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

global using static Silk.NET.Windowing.Helper;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Silk.NET.SDL;

namespace Silk.NET.Windowing;

internal static class Helper
{
    private static long _start;

    [Conditional("DEBUG")]
    public static void DebugPrint(
        string msg = "reached",
        [CallerFilePath] string? path = null,
        [CallerLineNumber] int line = 0,
        [CallerMemberName] string? member = null
    ) =>
        Console.WriteLine(
            $"{GetSecs():0000.000000} {path?[(path.LastIndexOf('/') + 1)..]}:{line} {member}: {msg}"
        );

    private static float GetSecs()
    {
        if (_start == 0)
        {
            _start = Stopwatch.GetTimestamp();
        }

        return (float)Stopwatch.GetElapsedTime(_start).TotalSeconds;
    }

    [Conditional("DEBUG")]
    public static void DebugPrintWithError(
        string msg,
        [CallerFilePath] string? path = null,
        [CallerLineNumber] int line = 0,
        [CallerMemberName] string? member = null
    ) => DebugPrint($"{msg} ({Sdl.GetError().ReadToString()})");

#pragma warning disable CS8500 // This takes the address of, gets the size of, or declares a pointer to a managed type
    [Conditional("DEBUG")]
    public static unsafe void DebugPrintAllProps(
        uint props,
        [CallerArgumentExpression(nameof(props))] string expr = "props",
        [CallerFilePath] string? path = null,
        [CallerLineNumber] int line = 0,
        [CallerMemberName] string? member = null
    )
    {
        var state = (expr, path, line, member);
        if (Sdl.EnumerateProperties(props, new EnumeratePropertiesCallback(PrintProp), &state) == 1)
        {
            return;
        }

        DebugPrint($"{expr} {props} - failed to enumerate: {Sdl.GetError()}");
        Sdl.ClearError();
    }

    [SuppressMessage("ReSharper", "ExplicitCallerInfoArgument")]
    private static unsafe void PrintProp(void* state, uint props, sbyte* propname)
    {
        var (expr, path, line, member) = *((string?, string?, int, string?)*)state;
        DebugPrint(
            $"{expr} ({props}) {((Ref<sbyte>)propname).ReadToString()} {Sdl.GetPropertyType(props, propname) switch
            {
                PropertyType.Pointer =>
                    $"(pointer): {(Ptr)Sdl.GetPointerProperty(props, propname, nullptr)}",
                PropertyType.String =>
                    $"(string): {Sdl.GetStringProperty(props, propname, "(default)").ReadToString()}",
                PropertyType.Number =>
                    $"(number): {Sdl.GetNumberProperty(props, propname, 0)}",
                PropertyType.Float =>
                    $"(float): {Sdl.GetFloatProperty(props, propname, 0)}",
                PropertyType.Boolean =>
                    $"(bool): {(bool)Sdl.GetBooleanProperty(props, propname, false)}",
                _ => "invalid property",
            }}",
            path,
            line,
            member
        );
    }
#pragma warning restore CS8500 // This takes the address of, gets the size of, or declares a pointer to a managed type
}
