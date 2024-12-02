// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Windowing.SDL3;

// ReSharper disable once CheckNamespace
namespace Silk.NET.Windowing;

public partial interface IDetachedSurfaceLifecycle
{
    public static sealed partial bool TryCreate<T>(out IDetachedSurfaceLifecycle? lifecycle)
        where T : ISurfaceApplication
    {
        // TODO figure out if there's a way we can interrogate SDL to figure out the need for SDL_EnterAppMainCallbacks
        if (
            OperatingSystem.IsAndroid()
            || OperatingSystem.IsBrowser()
            || OperatingSystem.IsIOS()
            || OperatingSystem.IsMacCatalyst()
            || OperatingSystem.IsWasi()
            || OperatingSystem.IsTvOS()
            || OperatingSystem.IsWatchOS()
            || (
                !OperatingSystem.IsWindows()
                && !OperatingSystem.IsMacOS()
                && !OperatingSystem.IsLinux()
                && !OperatingSystem.IsFreeBSD()
            )
        )
        {
            lifecycle = null;
            return false;
        }

        lifecycle = new SdlSurfaceLifecycle(SdlSurfaceLifecycle.CoreInit<T>());
        return true;
    }
}
