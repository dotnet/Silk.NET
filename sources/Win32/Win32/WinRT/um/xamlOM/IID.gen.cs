// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IVisualTreeServiceCallback
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x31,
                0x89,
                0x7A,
                0xAA,
                0xE4,
                0x80,
                0xEC,
                0x4F,
                0x8F,
                0x3B,
                0x55,
                0x3F,
                0x87,
                0xB4,
                0x96,
                0x6E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVisualTreeServiceCallback2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x88,
                0xEB,
                0xD9,
                0xBA,
                0x77,
                0xAE,
                0x97,
                0x43,
                0xB9,
                0x48,
                0x5F,
                0xA2,
                0xDB,
                0x0A,
                0x19,
                0xEA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVisualTreeService
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1A,
                0xB1,
                0x93,
                0xA5,
                0x7F,
                0xD1,
                0xBB,
                0x48,
                0x8F,
                0x66,
                0x83,
                0x91,
                0x07,
                0x31,
                0xC8,
                0xA5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IXamlDiagnostics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB6,
                0xE2,
                0xC9,
                0x18,
                0x43,
                0x3F,
                0x16,
                0x41,
                0x9F,
                0x2B,
                0xFF,
                0x93,
                0x5D,
                0x77,
                0x70,
                0xD2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBitmapData
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF2,
                0x4E,
                0xA3,
                0xD1,
                0xD8,
                0xCA,
                0x35,
                0x46,
                0xA3,
                0xD2,
                0xFC,
                0xDA,
                0x8D,
                0x3F,
                0x3C,
                0xAF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVisualTreeService2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x36,
                0x51,
                0x0F,
                0x13,
                0x43,
                0xEC,
                0x61,
                0x4F,
                0x89,
                0xC7,
                0x98,
                0x01,
                0xA3,
                0x6D,
                0x2E,
                0x95,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVisualTreeService3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0xC6,
                0x79,
                0x0E,
                0xA0,
                0x85,
                0xE8,
                0x4B,
                0xB4,
                0x1A,
                0x65,
                0x5C,
                0xF1,
                0xFD,
                0x19,
                0xBD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
