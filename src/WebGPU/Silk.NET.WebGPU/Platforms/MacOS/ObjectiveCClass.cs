// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace Silk.NET.WebGPU.Platforms.MacOS;

internal unsafe struct ObjectiveCClass
{
    public readonly IntPtr NativePtr;
    public static implicit operator IntPtr(ObjectiveCClass c) => c.NativePtr;

    public ObjectiveCClass(string name)
    {
        int byteCount = Encoding.UTF8.GetMaxByteCount(name.Length);
        byte* utf8BytesPtr = stackalloc byte[byteCount];
        fixed (char* namePtr = name)
        {
            Encoding.UTF8.GetBytes(namePtr, name.Length, utf8BytesPtr, byteCount);
        }

        NativePtr = ObjectiveCRuntime.objc_getClass(utf8BytesPtr);
    }

    public T AllocInit<T>() where T : struct
    {
        IntPtr value = ObjectiveCRuntime.IntPtr_objc_msgSend(NativePtr, "alloc");
        ObjectiveCRuntime.objc_msgSend(value, "init");
        return Unsafe.AsRef<T>(&value);
    }
}
