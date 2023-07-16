// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.DirectX;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirectInputA
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x60,
                0x13,
                0x52,
                0x89,
                0x8A,
                0xAA,
                0xCF,
                0x11,
                0xBF,
                0xC7,
                0x44,
                0x45,
                0x53,
                0x54,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirectInputW
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x61,
                0x13,
                0x52,
                0x89,
                0x8A,
                0xAA,
                0xCF,
                0x11,
                0xBF,
                0xC7,
                0x44,
                0x45,
                0x53,
                0x54,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirectInput2A
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x62,
                0xE6,
                0x44,
                0x59,
                0x8A,
                0xAA,
                0xCF,
                0x11,
                0xBF,
                0xC7,
                0x44,
                0x45,
                0x53,
                0x54,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirectInput2W
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x63,
                0xE6,
                0x44,
                0x59,
                0x8A,
                0xAA,
                0xCF,
                0x11,
                0xBF,
                0xC7,
                0x44,
                0x45,
                0x53,
                0x54,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirectInput7A
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x84,
                0xB6,
                0x4C,
                0x9A,
                0x6D,
                0x23,
                0xD3,
                0x11,
                0x8E,
                0x9D,
                0x00,
                0xC0,
                0x4F,
                0x68,
                0x44,
                0xAE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirectInput7W
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x85,
                0xB6,
                0x4C,
                0x9A,
                0x6D,
                0x23,
                0xD3,
                0x11,
                0x8E,
                0x9D,
                0x00,
                0xC0,
                0x4F,
                0x68,
                0x44,
                0xAE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirectInput8A
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x30,
                0x80,
                0x79,
                0xBF,
                0x3A,
                0x48,
                0xA2,
                0x4D,
                0xAA,
                0x99,
                0x5D,
                0x64,
                0xED,
                0x36,
                0x97,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirectInput8W
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x31,
                0x80,
                0x79,
                0xBF,
                0x3A,
                0x48,
                0xA2,
                0x4D,
                0xAA,
                0x99,
                0x5D,
                0x64,
                0xED,
                0x36,
                0x97,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirectInputDeviceA
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x80,
                0xE6,
                0x44,
                0x59,
                0x2E,
                0xC9,
                0xCF,
                0x11,
                0xBF,
                0xC7,
                0x44,
                0x45,
                0x53,
                0x54,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirectInputDeviceW
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x81,
                0xE6,
                0x44,
                0x59,
                0x2E,
                0xC9,
                0xCF,
                0x11,
                0xBF,
                0xC7,
                0x44,
                0x45,
                0x53,
                0x54,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirectInputDevice2A
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x82,
                0xE6,
                0x44,
                0x59,
                0x2E,
                0xC9,
                0xCF,
                0x11,
                0xBF,
                0xC7,
                0x44,
                0x45,
                0x53,
                0x54,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirectInputDevice2W
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x83,
                0xE6,
                0x44,
                0x59,
                0x2E,
                0xC9,
                0xCF,
                0x11,
                0xBF,
                0xC7,
                0x44,
                0x45,
                0x53,
                0x54,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirectInputDevice7A
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBC,
                0xC6,
                0xD7,
                0x57,
                0x56,
                0x23,
                0xD3,
                0x11,
                0x8E,
                0x9D,
                0x00,
                0xC0,
                0x4F,
                0x68,
                0x44,
                0xAE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirectInputDevice7W
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBD,
                0xC6,
                0xD7,
                0x57,
                0x56,
                0x23,
                0xD3,
                0x11,
                0x8E,
                0x9D,
                0x00,
                0xC0,
                0x4F,
                0x68,
                0x44,
                0xAE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirectInputDevice8A
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x80,
                0x10,
                0xD4,
                0x54,
                0x15,
                0xDC,
                0x33,
                0x48,
                0xA4,
                0x1B,
                0x74,
                0x8F,
                0x73,
                0xA3,
                0x81,
                0x79
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirectInputDevice8W
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x81,
                0x10,
                0xD4,
                0x54,
                0x15,
                0xDC,
                0x33,
                0x48,
                0xA4,
                0x1B,
                0x74,
                0x8F,
                0x73,
                0xA3,
                0x81,
                0x79
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IDirectInputEffect
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC0,
                0xF7,
                0xE1,
                0xE7,
                0xD2,
                0x88,
                0xD0,
                0x11,
                0x9A,
                0xD0,
                0x00,
                0xA0,
                0xC9,
                0xA0,
                0x6E,
                0x35
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("#define IID_IDirectInputDevice IID_IDirectInputDeviceW")]
    public static ref readonly Guid IID_IDirectInputDevice => ref IID_IDirectInputDeviceW;

    [NativeTypeName("#define IID_IDirectInputDevice2 IID_IDirectInputDevice2W")]
    public static ref readonly Guid IID_IDirectInputDevice2 => ref IID_IDirectInputDevice2W;

    [NativeTypeName("#define IID_IDirectInputDevice7 IID_IDirectInputDevice7W")]
    public static ref readonly Guid IID_IDirectInputDevice7 => ref IID_IDirectInputDevice7W;

    [NativeTypeName("#define IID_IDirectInputDevice8 IID_IDirectInputDevice8W")]
    public static ref readonly Guid IID_IDirectInputDevice8 => ref IID_IDirectInputDevice8W;

    [NativeTypeName("#define IID_IDirectInput IID_IDirectInputW")]
    public static ref readonly Guid IID_IDirectInput => ref IID_IDirectInputW;

    [NativeTypeName("#define IID_IDirectInput2 IID_IDirectInput2W")]
    public static ref readonly Guid IID_IDirectInput2 => ref IID_IDirectInput2W;

    [NativeTypeName("#define IID_IDirectInput7 IID_IDirectInput7W")]
    public static ref readonly Guid IID_IDirectInput7 => ref IID_IDirectInput7W;

    [NativeTypeName("#define IID_IDirectInput8 IID_IDirectInput8W")]
    public static ref readonly Guid IID_IDirectInput8 => ref IID_IDirectInput8W;
}