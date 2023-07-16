// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Dimm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IEnumRegisterWordA
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x12,
                0x34,
                0xC0,
                0x08,
                0x6B,
                0xF9,
                0xD0,
                0x11,
                0xA4,
                0x75,
                0x00,
                0xAA,
                0x00,
                0x6B,
                0xCC,
                0x59
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumRegisterWordW
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x31,
                0xDD,
                0x55,
                0x49,
                0x59,
                0xB1,
                0xD0,
                0x11,
                0x8F,
                0xCF,
                0x00,
                0xAA,
                0x00,
                0x6B,
                0xCC,
                0x59
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumInputContext
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB0,
                0xEA,
                0xB5,
                0x09,
                0x97,
                0xF9,
                0xD1,
                0x11,
                0x93,
                0xD4,
                0x00,
                0x60,
                0xB0,
                0x67,
                0xB8,
                0x6E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IActiveIMMRegistrar
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x82,
                0x80,
                0x45,
                0xB3,
                0x00,
                0xBD,
                0xD1,
                0x11,
                0x93,
                0x9B,
                0x00,
                0x60,
                0xB0,
                0x67,
                0xB8,
                0x6E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IActiveIMMMessagePumpOwner
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFA,
                0x2C,
                0xCF,
                0xB5,
                0xEB,
                0x8A,
                0xD1,
                0x11,
                0x93,
                0x64,
                0x00,
                0x60,
                0xB0,
                0x67,
                0xB8,
                0x6E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IActiveIMMApp
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x40,
                0xE0,
                0xC0,
                0x08,
                0xD1,
                0x62,
                0xD1,
                0x11,
                0x93,
                0x26,
                0x00,
                0x60,
                0xB0,
                0x67,
                0xB8,
                0x6E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IActiveIMMIME
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x11,
                0x34,
                0xC0,
                0x08,
                0x6B,
                0xF9,
                0xD0,
                0x11,
                0xA4,
                0x75,
                0x00,
                0xAA,
                0x00,
                0x6B,
                0xCC,
                0x59
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IActiveIME
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x62,
                0x09,
                0xE2,
                0x6F,
                0x77,
                0xD0,
                0xD0,
                0x11,
                0x8F,
                0xE7,
                0x00,
                0xAA,
                0x00,
                0x6B,
                0xCC,
                0x59
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IActiveIME2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0E,
                0xBF,
                0xC4,
                0xE1,
                0x53,
                0x2D,
                0xD2,
                0x11,
                0x93,
                0xE1,
                0x00,
                0x60,
                0xB0,
                0x67,
                0xB8,
                0x6E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CActiveIMM
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x33,
                0xDD,
                0x55,
                0x49,
                0x59,
                0xB1,
                0xD0,
                0x11,
                0x8F,
                0xCF,
                0x00,
                0xAA,
                0x00,
                0x6B,
                0xCC,
                0x59
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}