// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.WebGPU.Platforms.MacOS;

internal class NSWindow
{
    public readonly nint NativePtr;

    public NSWindow(nint ptr)
    {
        NativePtr = ptr;
    }

    public NSView contentView => ObjectiveCRuntime.objc_msgSend<NSView>(NativePtr, "contentView");
}
