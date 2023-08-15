// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.WebGPU.Platforms.MacOS;

internal static unsafe class ObjectiveCRuntime
{
    private const string ObjCLibrary = "/usr/lib/libobjc.A.dylib";

    [DllImport(ObjCLibrary)]
    public static extern IntPtr sel_registerName(byte* namePtr);

    [DllImport(ObjCLibrary)]
    public static extern byte* sel_getName(IntPtr selector);

    [DllImport(ObjCLibrary, EntryPoint = "objc_msgSend")]
    public static extern Bool8 bool8_objc_msgSend(IntPtr receiver, Selector selector);

    [DllImport(ObjCLibrary, EntryPoint = "objc_msgSend")]
    public static extern IntPtr IntPtr_objc_msgSend(IntPtr receiver, Selector selector);

    [DllImport(ObjCLibrary, EntryPoint = "objc_msgSend")]
    public static extern IntPtr IntPtr_objc_msgSend(IntPtr receiver, Selector selector, IntPtr a);

    [DllImport(ObjCLibrary, EntryPoint = "objc_msgSend")]
    public static extern void objc_msgSend(IntPtr receiver, Selector selector, byte b);

    [DllImport(ObjCLibrary, EntryPoint = "objc_msgSend")]
    public static extern void objc_msgSend(IntPtr receiver, Selector selector);

    [DllImport(ObjCLibrary)]
    public static extern IntPtr objc_getClass(byte* namePtr);

    public static T objc_msgSend<T>(IntPtr receiver, Selector selector) where T : struct
    {
        IntPtr value = IntPtr_objc_msgSend(receiver, selector);
        return Unsafe.AsRef<T>(&value);
    }
}
