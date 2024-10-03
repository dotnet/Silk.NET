// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.SDL.ArrayOrder;
using static Silk.NET.SDL.BitmapOrder;
using static Silk.NET.SDL.ChromaLocation;
using static Silk.NET.SDL.ColorPrimaries;
using static Silk.NET.SDL.ColorRange;
using static Silk.NET.SDL.ColorType;
using static Silk.NET.SDL.MatrixCoefficients;
using static Silk.NET.SDL.PackedLayout;
using static Silk.NET.SDL.PackedOrder;
using static Silk.NET.SDL.PenAxis;
using static Silk.NET.SDL.PixelType;
using static Silk.NET.SDL.Scancode;
using static Silk.NET.SDL.TransferCharacteristics;

namespace Silk.NET.SDL;

[Transformed]
public readonly unsafe struct StorageInterfaceFunction2 : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, sbyte*, int> Handle =>
        (delegate* unmanaged<void*, sbyte*, int>)Pointer;

    public StorageInterfaceFunction2(delegate* unmanaged<void*, sbyte*, int> ptr) => Pointer = ptr;

    public StorageInterfaceFunction2(StorageInterfaceFunction2Delegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator StorageInterfaceFunction2(
        delegate* unmanaged<void*, sbyte*, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, sbyte*, int>(
        StorageInterfaceFunction2 pfn
    ) => (delegate* unmanaged<void*, sbyte*, int>)pfn.Pointer;
}
