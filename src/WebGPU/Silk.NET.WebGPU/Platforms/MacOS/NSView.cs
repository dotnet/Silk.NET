// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Silk.NET.WebGPU.Platforms.MacOS;

internal unsafe struct NSView
{
    public readonly IntPtr NativePtr;
    public static implicit operator IntPtr(NSView nsView) => nsView.NativePtr;

    public NSView(IntPtr ptr) => NativePtr = ptr;

    public Bool8 wantsLayer
    {
        get => ObjectiveCRuntime.bool8_objc_msgSend(NativePtr, "wantsLayer");
        set => ObjectiveCRuntime.objc_msgSend(NativePtr, "setWantsLayer:", value);
    }

    public IntPtr layer
    {
        get => ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, "layer");
        set => ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, "setLayer:", value);
    }
}
