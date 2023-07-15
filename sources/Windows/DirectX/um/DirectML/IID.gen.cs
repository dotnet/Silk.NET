// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IDMLObject
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAC,
                0x3A,
                0x26,
                0xC8,
                0x0C,
                0x9E,
                0x2D,
                0x4A,
                0x9B,
                0x8E,
                0x00,
                0x75,
                0x21,
                0xA3,
                0x31,
                0x7C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDMLDevice
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x37,
                0x64,
                0xBD,
                0x6D,
                0xFD,
                0x96,
                0x3F,
                0x42,
                0xA9,
                0x8C,
                0xAE,
                0x5E,
                0x7C,
                0x2A,
                0x57,
                0x3F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDMLDeviceChild
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x42,
                0x31,
                0xE8,
                0x27,
                0x65,
                0x81,
                0xE3,
                0x49,
                0x97,
                0x4E,
                0x2F,
                0xD6,
                0x6E,
                0x4C,
                0xB6,
                0x9D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDMLPageable
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x25,
                0x08,
                0xAB,
                0xB1,
                0x42,
                0x45,
                0x4B,
                0x4A,
                0x86,
                0x17,
                0x6D,
                0xDE,
                0x6E,
                0x8F,
                0x62,
                0x01
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDMLOperator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7A,
                0xAE,
                0xCA,
                0x26,
                0x81,
                0x30,
                0x33,
                0x46,
                0x95,
                0x81,
                0x22,
                0x6F,
                0xBE,
                0x57,
                0x69,
                0x5D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDMLDispatchable
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA8,
                0x21,
                0xB8,
                0xDC,
                0x39,
                0x10,
                0x1E,
                0x44,
                0x9F,
                0x1C,
                0xB1,
                0x75,
                0x9C,
                0x2F,
                0x3C,
                0xEC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDMLCompiledOperator
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6A,
                0xE5,
                0x15,
                0x6B,
                0x5C,
                0xBF,
                0x02,
                0x49,
                0x92,
                0xD8,
                0xDA,
                0x3A,
                0x65,
                0x0A,
                0xFE,
                0xA4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDMLOperatorInitializer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x13,
                0x11,
                0x7C,
                0x42,
                0x5C,
                0x43,
                0x9C,
                0x46,
                0x86,
                0x76,
                0x4D,
                0x5D,
                0xD0,
                0x72,
                0xF8,
                0x13
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDMLBindingTable
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xDC,
                0x87,
                0xC6,
                0x29,
                0x74,
                0xDE,
                0x3B,
                0x4E,
                0xAB,
                0x00,
                0x11,
                0x68,
                0xF2,
                0xFC,
                0x3C,
                0xFC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDMLCommandRecorder
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x76,
                0x7A,
                0x85,
                0xE6,
                0x3E,
                0x2E,
                0xDD,
                0x4F,
                0xBF,
                0xF4,
                0x5D,
                0x2B,
                0xA1,
                0x0F,
                0xB4,
                0x53
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDMLDebugDevice
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC9,
                0x3A,
                0x6F,
                0x7D,
                0x4A,
                0x39,
                0xC3,
                0x4A,
                0x92,
                0xA7,
                0x39,
                0x0C,
                0xC5,
                0x7A,
                0x82,
                0x17
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDMLDevice1
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9A,
                0x4F,
                0x88,
                0xA0,
                0xBE,
                0xD2,
                0x55,
                0x43,
                0xAA,
                0x5D,
                0x59,
                0x01,
                0x28,
                0x1A,
                0xD1,
                0xD2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}