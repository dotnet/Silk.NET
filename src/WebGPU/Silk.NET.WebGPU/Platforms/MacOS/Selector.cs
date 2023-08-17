// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Native;

namespace Silk.NET.WebGPU.Platforms.MacOS;

internal struct Selector
{
    public readonly nint NativePtr;

    public Selector(nint ptr)
    {
        NativePtr = ptr;
    }

    public Selector(string name)
    {
        NativePtr = ObjectiveCRuntime.sel_registerName(SilkMarshal.StringToPtr(name));
    }

    public static implicit operator Selector(string s)
    {
        return new Selector(s);
    }
}
