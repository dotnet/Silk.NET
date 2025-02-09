// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using Silk.NET.SDL;
using Silk.NET.Windowing.SDL3;

// ReSharper disable once CheckNamespace
namespace Silk.NET.Windowing;

public partial interface ISurfaceApplication
{
    public static sealed partial void Run<T>()
        where T : ISurfaceApplication
    {
        Ref<sbyte> arg = (Utf8String)"Silk.NET"u8;
        Sdl.EnterAppMainCallbacks(
            1,
            arg.AsRef2D(),
            SdlSurfaceLifecycle.AppInit<T>(),
            SdlSurfaceLifecycle.AppIterate,
            SdlSurfaceLifecycle.AppEvent,
            SdlSurfaceLifecycle.AppQuit
        );
    }
}
