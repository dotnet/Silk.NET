// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// ReSharper disable CheckNamespace

using Silk.NET.Input.SDL3;
using Silk.NET.SDL;

namespace Silk.NET.Input;

/// <summary>
/// Contains extensions for creating input backends and contexts from <see cref="INativeWindow"/>s.
/// </summary>
public static partial class InputWindowExtensions
{
    public static partial IInputBackend CreateInputBackend(this INativeWindow window)
    {
        if (!window.TryGetPlatformInfo(out SdlPlatformInfo info))
        {
            throw new ArgumentException(
                "When using the Silk.NET.Input reference implementation, a native window compatible with that "
                    + "implementation (such as those sourced from Silk.NET.Windowing) must be used."
            );
        }

        return new SdlInputBackend(info);
    }
}
