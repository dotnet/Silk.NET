// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.DirectX;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class GUID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_XAxis
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE0,
                0x02,
                0x6D,
                0xA3,
                0xF3,
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
    public static ref readonly Guid GUID_YAxis
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE1,
                0x02,
                0x6D,
                0xA3,
                0xF3,
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
    public static ref readonly Guid GUID_ZAxis
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE2,
                0x02,
                0x6D,
                0xA3,
                0xF3,
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
    public static ref readonly Guid GUID_RxAxis
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF4,
                0x02,
                0x6D,
                0xA3,
                0xF3,
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
    public static ref readonly Guid GUID_RyAxis
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF5,
                0x02,
                0x6D,
                0xA3,
                0xF3,
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
    public static ref readonly Guid GUID_RzAxis
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE3,
                0x02,
                0x6D,
                0xA3,
                0xF3,
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
    public static ref readonly Guid GUID_Slider
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE4,
                0x02,
                0x6D,
                0xA3,
                0xF3,
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
    public static ref readonly Guid GUID_Button
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF0,
                0x02,
                0x6D,
                0xA3,
                0xF3,
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
    public static ref readonly Guid GUID_Key
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x20,
                0x82,
                0x72,
                0x55,
                0x3C,
                0xD3,
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
    public static ref readonly Guid GUID_POV
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF2,
                0x02,
                0x6D,
                0xA3,
                0xF3,
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
    public static ref readonly Guid GUID_Unknown
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xF3,
                0x02,
                0x6D,
                0xA3,
                0xF3,
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
    public static ref readonly Guid GUID_SysMouse
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x60,
                0x2B,
                0x1D,
                0x6F,
                0xA0,
                0xD5,
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
    public static ref readonly Guid GUID_SysKeyboard
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x61,
                0x2B,
                0x1D,
                0x6F,
                0xA0,
                0xD5,
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
    public static ref readonly Guid GUID_Joystick
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x70,
                0x2B,
                0x1D,
                0x6F,
                0xA0,
                0xD5,
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
    public static ref readonly Guid GUID_SysMouseEm
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x80,
                0x2B,
                0x1D,
                0x6F,
                0xA0,
                0xD5,
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
    public static ref readonly Guid GUID_SysMouseEm2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x81,
                0x2B,
                0x1D,
                0x6F,
                0xA0,
                0xD5,
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
    public static ref readonly Guid GUID_SysKeyboardEm
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x82,
                0x2B,
                0x1D,
                0x6F,
                0xA0,
                0xD5,
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
    public static ref readonly Guid GUID_SysKeyboardEm2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x83,
                0x2B,
                0x1D,
                0x6F,
                0xA0,
                0xD5,
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
    public static ref readonly Guid GUID_ConstantForce
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x20,
                0x1C,
                0x54,
                0x13,
                0x33,
                0x8E,
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

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_RampForce
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x21,
                0x1C,
                0x54,
                0x13,
                0x33,
                0x8E,
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

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_Square
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x22,
                0x1C,
                0x54,
                0x13,
                0x33,
                0x8E,
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

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_Sine
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x23,
                0x1C,
                0x54,
                0x13,
                0x33,
                0x8E,
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

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_Triangle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x24,
                0x1C,
                0x54,
                0x13,
                0x33,
                0x8E,
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

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_SawtoothUp
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x25,
                0x1C,
                0x54,
                0x13,
                0x33,
                0x8E,
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

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_SawtoothDown
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x26,
                0x1C,
                0x54,
                0x13,
                0x33,
                0x8E,
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

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_Spring
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x27,
                0x1C,
                0x54,
                0x13,
                0x33,
                0x8E,
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

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_Damper
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x28,
                0x1C,
                0x54,
                0x13,
                0x33,
                0x8E,
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

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_Inertia
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x29,
                0x1C,
                0x54,
                0x13,
                0x33,
                0x8E,
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

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_Friction
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2A,
                0x1C,
                0x54,
                0x13,
                0x33,
                0x8E,
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

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_CustomForce
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2B,
                0x1C,
                0x54,
                0x13,
                0x33,
                0x8E,
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
}