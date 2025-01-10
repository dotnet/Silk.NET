// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InkPresenterDesktop.h and um/InkPresenterDesktop_i.c in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    [NativeTypeName("const IID")]
    public static ref readonly Guid IID_IInkCommitRequestHandler
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFC,
                0xA3,
                0xBE,
                0xFA,
                0x08,
                0xB1,
                0xB6,
                0x45,
                0xA9,
                0xFC,
                0x8D,
                0x08,
                0xFA,
                0x9F,
                0x85,
                0xCF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid IID_IInkPresenterDesktop
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD9,
                0xC0,
                0xF3,
                0x73,
                0x8B,
                0x2E,
                0xF3,
                0x48,
                0x89,
                0x5E,
                0x20,
                0xCB,
                0xD2,
                0x7B,
                0x72,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid IID_IInkHostWorkItem
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9A,
                0x0A,
                0xDA,
                0xCC,
                0x78,
                0x1B,
                0x32,
                0x46,
                0xBB,
                0x96,
                0x97,
                0x80,
                0x06,
                0x62,
                0xE2,
                0x6C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid IID_IInkDesktopHost
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x75,
                0xD8,
                0xE7,
                0x4C,
                0x81,
                0xA9,
                0x40,
                0x41,
                0xA1,
                0xFF,
                0xAD,
                0x93,
                0x25,
                0x8E,
                0x8D,
                0x59,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
