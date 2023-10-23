// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core;

namespace Silk.NET.WebGPU.Platforms.MacOS;

internal struct NSView
{
    public readonly nint NativePtr;

    public static implicit operator nint(NSView nsView)
    {
        return nsView.NativePtr;
    }

    public NSView(nint ptr)
    {
        NativePtr = ptr;
    }

    public Bool8 wantsLayer
    {
        get => ObjectiveCRuntime.bool8_objc_msgSend(NativePtr, "wantsLayer");
        set => ObjectiveCRuntime.objc_msgSend(NativePtr, "setWantsLayer:", value);
    }

    public nint layer
    {
        get => ObjectiveCRuntime.ptr_objc_msgSend(NativePtr, "layer");
        set => ObjectiveCRuntime.ptr_objc_msgSend(NativePtr, "setLayer:", value);
    }
}
