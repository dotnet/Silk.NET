// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_ITravelEntry
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3B,
                0xDB,
                0x6E,
                0xF4,
                0x2F,
                0xBC,
                0xD0,
                0x11,
                0x94,
                0x12,
                0x00,
                0xAA,
                0x00,
                0xA3,
                0xEB,
                0xD3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITravelLog
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x08,
                0xCB,
                0xA9,
                0x66,
                0x02,
                0x48,
                0xD2,
                0x11,
                0xA5,
                0x61,
                0x00,
                0xA0,
                0xC9,
                0x2D,
                0xBF,
                0xE8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_CIE4ConnectionPoint
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IExpDispSupportXP
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8C,
                0xD5,
                0x0D,
                0x2F,
                0x89,
                0xF7,
                0x14,
                0x4F,
                0x99,
                0xFB,
                0x92,
                0x93,
                0xB3,
                0xC9,
                0xC2,
                0x12
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IExpDispSupport
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x00,
                0x1D,
                0x7D,
                0x0D,
                0xC0,
                0x6F,
                0xD0,
                0x11,
                0xA9,
                0x74,
                0x00,
                0xC0,
                0x4F,
                0xD7,
                0x05,
                0xA2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IBrowserService
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x52,
                0x3B,
                0xBA,
                0x02,
                0x47,
                0x05,
                0xD1,
                0x11,
                0xB8,
                0x33,
                0x00,
                0xC0,
                0x4F,
                0xC9,
                0xB3,
                0x1F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IShellService
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x00,
                0xFB,
                0x36,
                0x58,
                0x87,
                0x81,
                0xCF,
                0x11,
                0xA1,
                0x2B,
                0x00,
                0xAA,
                0x00,
                0x4A,
                0xE8,
                0x37
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IBrowserService2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCC,
                0x21,
                0xBD,
                0x68,
                0x8B,
                0x43,
                0xD2,
                0x11,
                0xA5,
                0x60,
                0x00,
                0xA0,
                0xC9,
                0x2D,
                0xBF,
                0xE8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IBrowserService3
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x21,
                0xCE,
                0xD7,
                0x27,
                0x2D,
                0x76,
                0xF3,
                0x48,
                0x86,
                0xF3,
                0x40,
                0xE2,
                0xFD,
                0x37,
                0x49,
                0xC4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IBrowserService4
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFF,
                0x1B,
                0x9F,
                0x63,
                0x35,
                0xE1,
                0x96,
                0x40,
                0xAB,
                0xD8,
                0xE0,
                0xF5,
                0x04,
                0xD6,
                0x49,
                0xA4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ITrackShellMenu
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x32,
                0xF9,
                0x78,
                0x82,
                0x3E,
                0x2A,
                0xD2,
                0x11,
                0x83,
                0x8F,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x18,
                0xD0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_TrackShellMenu
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x31,
                0xF9,
                0x78,
                0x82,
                0x3E,
                0x2A,
                0xD2,
                0x11,
                0x83,
                0x8F,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x18,
                0xD0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}