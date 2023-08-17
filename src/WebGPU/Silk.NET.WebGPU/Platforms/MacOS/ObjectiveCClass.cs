// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;
using Silk.NET.Core.Native;

namespace Silk.NET.WebGPU.Platforms.MacOS;

internal unsafe struct ObjectiveCClass
{
    public readonly nint NativePtr;

    public static implicit operator nint(ObjectiveCClass c)
    {
        return c.NativePtr;
    }

    public ObjectiveCClass(string name)
    {
        var namePtr = SilkMarshal.StringToPtr(name);
        NativePtr = ObjectiveCRuntime.objc_getClass(namePtr);
        SilkMarshal.Free(namePtr);
    }

    public T AllocInit<T>() where T : struct
    {
        var value = ObjectiveCRuntime.ptr_objc_msgSend(NativePtr, "alloc");
        ObjectiveCRuntime.objc_msgSend(value, "init");
        return Unsafe.AsRef<T>(&value);
    }
}
