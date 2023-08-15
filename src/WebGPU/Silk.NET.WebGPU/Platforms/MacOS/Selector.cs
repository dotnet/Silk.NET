// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Text;

namespace Silk.NET.WebGPU.Platforms.MacOS;

internal unsafe struct Selector
{
    public readonly IntPtr NativePtr;

    public Selector(IntPtr ptr)
    {
        NativePtr = ptr;
    }

    public Selector(string name)
    {
        int byteCount = Encoding.UTF8.GetMaxByteCount(name.Length);
        byte* utf8BytesPtr = stackalloc byte[byteCount];
        fixed (char* namePtr = name)
        {
            Encoding.UTF8.GetBytes(namePtr, name.Length, utf8BytesPtr, byteCount);
        }

        NativePtr = ObjectiveCRuntime.sel_registerName(utf8BytesPtr);
    }

    public static implicit operator Selector(string s) => new Selector(s);
}
