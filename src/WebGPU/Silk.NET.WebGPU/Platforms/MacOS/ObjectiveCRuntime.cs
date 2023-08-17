// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Core;

namespace Silk.NET.WebGPU.Platforms.MacOS;

internal static unsafe class ObjectiveCRuntime
{
    private const string ObjCLibrary = "/usr/lib/libobjc.A.dylib";

    [DllImport(ObjCLibrary)]
    public static extern nint sel_registerName(nint namePtr);

    [DllImport(ObjCLibrary)]
    public static extern byte* sel_getName(nint selector);

    [DllImport(ObjCLibrary, EntryPoint = "objc_msgSend")]
    public static extern Bool8 bool8_objc_msgSend(nint receiver, Selector selector);

    [DllImport(ObjCLibrary, EntryPoint = "objc_msgSend")]
    public static extern nint ptr_objc_msgSend(nint receiver, Selector selector);

    [DllImport(ObjCLibrary, EntryPoint = "objc_msgSend")]
    public static extern nint ptr_objc_msgSend(nint receiver, Selector selector, nint a);

    [DllImport(ObjCLibrary, EntryPoint = "objc_msgSend")]
    public static extern void objc_msgSend(nint receiver, Selector selector, byte b);

    [DllImport(ObjCLibrary, EntryPoint = "objc_msgSend")]
    public static extern void objc_msgSend(nint receiver, Selector selector);

    [DllImport(ObjCLibrary)]
    public static extern nint objc_getClass(nint namePtr);

    public static T objc_msgSend<T>(nint receiver, Selector selector) where T : struct
    {
        var value = ptr_objc_msgSend(receiver, selector);
        return Unsafe.AsRef<T>(&value);
    }
}
