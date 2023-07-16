// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_ID2D1GeometryRealization
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD7,
                0x07,
                0x69,
                0xA1,
                0x02,
                0xBC,
                0x01,
                0x48,
                0x99,
                0xE8,
                0x8C,
                0xF7,
                0xF4,
                0x85,
                0xF7,
                0x74
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ID2D1DeviceContext1
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE4,
                0x57,
                0x7F,
                0xD3,
                0x08,
                0x69,
                0x9F,
                0x45,
                0xA1,
                0x99,
                0xE7,
                0x2F,
                0x24,
                0xF7,
                0x99,
                0x87
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ID2D1Device1
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE1,
                0x68,
                0x17,
                0xD2,
                0xA4,
                0x23,
                0x23,
                0x48,
                0xA1,
                0x4B,
                0x7C,
                0x3E,
                0xBA,
                0x85,
                0xD6,
                0x58
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ID2D1Factory2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x73,
                0x1A,
                0xF8,
                0x94,
                0x12,
                0x92,
                0x76,
                0x43,
                0x9C,
                0x58,
                0xB1,
                0x6A,
                0x3A,
                0x0D,
                0x39,
                0x92
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ID2D1CommandSink1
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFD,
                0x67,
                0xB7,
                0x9E,
                0x69,
                0x42,
                0x67,
                0x44,
                0xB8,
                0xC2,
                0xEB,
                0x30,
                0xCB,
                0x30,
                0x57,
                0x43
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}