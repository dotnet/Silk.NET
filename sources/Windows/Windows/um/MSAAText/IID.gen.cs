// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ITfMSAAControl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3B,
                0xFB,
                0xF8,
                0xB5,
                0x3F,
                0x39,
                0x7C,
                0x4F,
                0x84,
                0xCB,
                0x50,
                0x49,
                0x24,
                0xC2,
                0x70,
                0x5A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IInternalDocWrap
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x66,
                0x64,
                0xAA,
                0xE1,
                0xB4,
                0x9D,
                0xBA,
                0x40,
                0xBE,
                0x03,
                0x77,
                0xC3,
                0x8E,
                0x8E,
                0x60,
                0xB2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ITextStoreACPEx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC2,
                0x3B,
                0xDE,
                0xA2,
                0x8E,
                0x3D,
                0xD3,
                0x11,
                0x81,
                0xA9,
                0xF7,
                0x53,
                0xFB,
                0xE6,
                0x1A,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ITextStoreAnchorEx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC1,
                0x3B,
                0xDE,
                0xA2,
                0x8E,
                0x3D,
                0xD3,
                0x11,
                0x81,
                0xA9,
                0xF7,
                0x53,
                0xFB,
                0xE6,
                0x1A,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ITextStoreACPSinkEx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x64,
                0x94,
                0xDF,
                0x2B,
                0xE2,
                0x41,
                0xE3,
                0x43,
                0x95,
                0x0C,
                0xA6,
                0x86,
                0x5B,
                0xA2,
                0x5C,
                0xD4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ITextStoreSinkAnchorEx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x26,
                0x24,
                0x64,
                0x25,
                0x8D,
                0x02,
                0x74,
                0x44,
                0x97,
                0x7B,
                0x11,
                0x1B,
                0xB1,
                0x14,
                0xFE,
                0x3E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IAccDictionary
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5F,
                0xCB,
                0xC4,
                0x1D,
                0x37,
                0xD7,
                0x4D,
                0x47,
                0xAD,
                0xE9,
                0x5C,
                0xCF,
                0xC9,
                0xBC,
                0x1C,
                0xC9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IVersionInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEC,
                0x18,
                0x15,
                0x40,
                0x00,
                0xDB,
                0x11,
                0x46,
                0x9B,
                0x29,
                0x2A,
                0x0E,
                0x4B,
                0x9A,
                0xFA,
                0x85
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ICoCreateLocally
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAA,
                0x00,
                0xDE,
                0x03,
                0x72,
                0xF2,
                0xE3,
                0x41,
                0x99,
                0xCB,
                0x03,
                0xC5,
                0xE8,
                0x11,
                0x4E,
                0xA0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ICoCreatedLocally
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x6C,
                0xEB,
                0x53,
                0x0A,
                0x08,
                0x19,
                0x42,
                0x47,
                0x8C,
                0xFF,
                0x2C,
                0xEE,
                0x2E,
                0x93,
                0xF9,
                0x4C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IAccStore
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x63,
                0x4A,
                0xCD,
                0xE2,
                0x72,
                0x2B,
                0x48,
                0x4D,
                0xB7,
                0x39,
                0x95,
                0xE4,
                0x76,
                0x51,
                0x95,
                0xBA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IAccServerDocMgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCF,
                0x73,
                0x7C,
                0xAD,
                0xD5,
                0x6D,
                0x55,
                0x48,
                0xAB,
                0xC2,
                0xB0,
                0x4B,
                0xAD,
                0x5B,
                0x91,
                0x53
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IAccClientDocMgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x39,
                0x60,
                0x89,
                0x4C,
                0x6D,
                0x7B,
                0xE6,
                0x49,
                0xA8,
                0xC1,
                0x45,
                0x11,
                0x6A,
                0x98,
                0x29,
                0x2B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDocWrap
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFE,
                0x85,
                0xD2,
                0xDC,
                0xE0,
                0x0B,
                0xBD,
                0x43,
                0x99,
                0xC9,
                0xAA,
                0xAE,
                0xC5,
                0x13,
                0xC5,
                0x55
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IClonableWrapper
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xFF,
                0x75,
                0x3E,
                0xB3,
                0x4C,
                0xE8,
                0xCA,
                0x4D,
                0xA2,
                0x5C,
                0x33,
                0xB8,
                0xDC,
                0x00,
                0x33,
                0x74
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_MSAAControl
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3F,
                0x96,
                0xCD,
                0x08,
                0x3E,
                0x7A,
                0x5C,
                0x4F,
                0x9B,
                0xD8,
                0xD6,
                0x92,
                0xBB,
                0x04,
                0x3C,
                0x5B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_AccStore
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7F,
                0x83,
                0x40,
                0x54,
                0xFF,
                0x4B,
                0xE5,
                0x4A,
                0xA1,
                0xB1,
                0x77,
                0x22,
                0xEC,
                0xC6,
                0x33,
                0x2A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_AccDictionary
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x16,
                0xEE,
                0x72,
                0x65,
                0xE5,
                0x5F,
                0x31,
                0x43,
                0xBB,
                0x6D,
                0x76,
                0xA4,
                0x9C,
                0x56,
                0xE4,
                0x23
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_AccServerDocMgr
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7E,
                0xA3,
                0x89,
                0x60,
                0x8A,
                0xEB,
                0x2D,
                0x48,
                0xBD,
                0x6F,
                0xF9,
                0xF4,
                0x69,
                0x04,
                0xD1,
                0x6D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_AccClientDocMgr
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x30,
                0xCC,
                0x48,
                0xFC,
                0x3E,
                0x4F,
                0xA1,
                0x4F,
                0x80,
                0x3B,
                0xAD,
                0x0E,
                0x19,
                0x6A,
                0x83,
                0xB1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_DocWrap
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7E,
                0x6F,
                0x42,
                0xBF,
                0x5E,
                0x7A,
                0xD6,
                0x44,
                0x83,
                0x0C,
                0xA3,
                0x90,
                0xEA,
                0x94,
                0x62,
                0xA3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}