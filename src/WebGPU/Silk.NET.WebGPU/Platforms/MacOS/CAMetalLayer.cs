// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.WebGPU.Platforms.MacOS;

internal struct CAMetalLayer
{
    public readonly nint NativePtr;

    public CAMetalLayer(nint ptr)
    {
        NativePtr = ptr;
    }

    public static CAMetalLayer New()
    {
        return s_class.AllocInit<CAMetalLayer>();
    }

    private static readonly ObjectiveCClass s_class = new(nameof(CAMetalLayer));
}
