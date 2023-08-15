// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Silk.NET.WebGPU.Platforms.MacOS;

internal struct CAMetalLayer
{
    public readonly IntPtr NativePtr;

    public CAMetalLayer(IntPtr ptr) => NativePtr = ptr;

    public static CAMetalLayer New() => s_class.AllocInit<CAMetalLayer>();

    private static readonly ObjectiveCClass s_class = new ObjectiveCClass(nameof(CAMetalLayer));
}
