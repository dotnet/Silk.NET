// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SDL;

public partial class Sdl
{
    public static void ThrowError()
    {
        if (GetError().ReadToString() is { Length: > 0 } str)
        {
            static void Throw(string str) => throw new SdlException(str);
            Throw(str);
        }
    }
}

public static class Extensions
{
    public static void ThrowError(this ISdl sdl)
    {
        if (sdl.GetError().ReadToString() is { Length: > 0 } str)
        {
            static void Throw(string str) => throw new SdlException(str);
            Throw(str);
            sdl.ClearError();
        }
    }
}
