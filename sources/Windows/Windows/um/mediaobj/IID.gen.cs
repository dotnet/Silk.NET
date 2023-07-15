// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mediaobj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IMediaBuffer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB9,
                0xF8,
                0xEF,
                0x59,
                0x8C,
                0x93,
                0x26,
                0x4A,
                0x82,
                0xF2,
                0x95,
                0xCB,
                0x84,
                0xCD,
                0xC8,
                0x37
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMediaObject
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x58,
                0x0F,
                0xAD,
                0xD8,
                0x94,
                0x54,
                0x02,
                0x41,
                0x97,
                0xC5,
                0xEC,
                0x79,
                0x8E,
                0x59,
                0xBC,
                0xF4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumDMO
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8A,
                0xD9,
                0x3C,
                0x2C,
                0xFA,
                0x2B,
                0x53,
                0x4A,
                0x9C,
                0x27,
                0x52,
                0x49,
                0xBA,
                0x64,
                0xBA,
                0x0F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMediaObjectInPlace
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xD0,
                0x9A,
                0x1B,
                0x65,
                0xC7,
                0x0F,
                0xA9,
                0x4A,
                0x95,
                0x38,
                0xD8,
                0x99,
                0x31,
                0x01,
                0x07,
                0x41
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDMOQualityControl
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x96,
                0xEA,
                0xAB,
                0x65,
                0x36,
                0xCF,
                0x3F,
                0x45,
                0xAF,
                0x8A,
                0x70,
                0x5E,
                0x98,
                0xF1,
                0x62,
                0x60
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDMOVideoOutputOptimizations
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4E,
                0x4F,
                0x8F,
                0xBE,
                0x16,
                0x5B,
                0x29,
                0x4D,
                0xB3,
                0x50,
                0x7F,
                0x6B,
                0x5D,
                0x92,
                0x98,
                0xAC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}