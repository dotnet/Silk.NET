// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class MFCONNECTOR
{
    [NativeTypeName("const IID")]
    public static ref readonly Guid MFCONNECTOR_SPDIF
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x12,
                0xA7,
                0x94,
                0x0B,
                0x3E,
                0xAD,
                0xEE,
                0x4C,
                0x83,
                0xCE,
                0xCE,
                0x32,
                0xE3,
                0xDB,
                0x65,
                0x22,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFCONNECTOR_UNKNOWN
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5C,
                0xEF,
                0x3A,
                0xAC,
                0x43,
                0xCE,
                0xD9,
                0x11,
                0x92,
                0xDB,
                0x00,
                0x0B,
                0xDB,
                0x28,
                0xFF,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFCONNECTOR_PCI
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0xEF,
                0x3A,
                0xAC,
                0x43,
                0xCE,
                0xD9,
                0x11,
                0x92,
                0xDB,
                0x00,
                0x0B,
                0xDB,
                0x28,
                0xFF,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFCONNECTOR_PCIX
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5E,
                0xEF,
                0x3A,
                0xAC,
                0x43,
                0xCE,
                0xD9,
                0x11,
                0x92,
                0xDB,
                0x00,
                0x0B,
                0xDB,
                0x28,
                0xFF,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFCONNECTOR_PCI_Express
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5F,
                0xEF,
                0x3A,
                0xAC,
                0x43,
                0xCE,
                0xD9,
                0x11,
                0x92,
                0xDB,
                0x00,
                0x0B,
                0xDB,
                0x28,
                0xFF,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFCONNECTOR_AGP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x60,
                0xEF,
                0x3A,
                0xAC,
                0x43,
                0xCE,
                0xD9,
                0x11,
                0x92,
                0xDB,
                0x00,
                0x0B,
                0xDB,
                0x28,
                0xFF,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFCONNECTOR_VGA
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x68,
                0x59,
                0xCD,
                0x57,
                0x47,
                0xCE,
                0xD9,
                0x11,
                0x92,
                0xDB,
                0x00,
                0x0B,
                0xDB,
                0x28,
                0xFF,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFCONNECTOR_SVIDEO
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x69,
                0x59,
                0xCD,
                0x57,
                0x47,
                0xCE,
                0xD9,
                0x11,
                0x92,
                0xDB,
                0x00,
                0x0B,
                0xDB,
                0x28,
                0xFF,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFCONNECTOR_COMPOSITE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6A,
                0x59,
                0xCD,
                0x57,
                0x47,
                0xCE,
                0xD9,
                0x11,
                0x92,
                0xDB,
                0x00,
                0x0B,
                0xDB,
                0x28,
                0xFF,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFCONNECTOR_COMPONENT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6B,
                0x59,
                0xCD,
                0x57,
                0x47,
                0xCE,
                0xD9,
                0x11,
                0x92,
                0xDB,
                0x00,
                0x0B,
                0xDB,
                0x28,
                0xFF,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFCONNECTOR_DVI
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6C,
                0x59,
                0xCD,
                0x57,
                0x47,
                0xCE,
                0xD9,
                0x11,
                0x92,
                0xDB,
                0x00,
                0x0B,
                0xDB,
                0x28,
                0xFF,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFCONNECTOR_HDMI
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6D,
                0x59,
                0xCD,
                0x57,
                0x47,
                0xCE,
                0xD9,
                0x11,
                0x92,
                0xDB,
                0x00,
                0x0B,
                0xDB,
                0x28,
                0xFF,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFCONNECTOR_LVDS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6E,
                0x59,
                0xCD,
                0x57,
                0x47,
                0xCE,
                0xD9,
                0x11,
                0x92,
                0xDB,
                0x00,
                0x0B,
                0xDB,
                0x28,
                0xFF,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFCONNECTOR_D_JPN
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x70,
                0x59,
                0xCD,
                0x57,
                0x47,
                0xCE,
                0xD9,
                0x11,
                0x92,
                0xDB,
                0x00,
                0x0B,
                0xDB,
                0x28,
                0xFF,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFCONNECTOR_SDI
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x71,
                0x59,
                0xCD,
                0x57,
                0x47,
                0xCE,
                0xD9,
                0x11,
                0x92,
                0xDB,
                0x00,
                0x0B,
                0xDB,
                0x28,
                0xFF,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFCONNECTOR_DISPLAYPORT_EXTERNAL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x72,
                0x59,
                0xCD,
                0x57,
                0x47,
                0xCE,
                0xD9,
                0x11,
                0x92,
                0xDB,
                0x00,
                0x0B,
                0xDB,
                0x28,
                0xFF,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFCONNECTOR_DISPLAYPORT_EMBEDDED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x73,
                0x59,
                0xCD,
                0x57,
                0x47,
                0xCE,
                0xD9,
                0x11,
                0x92,
                0xDB,
                0x00,
                0x0B,
                0xDB,
                0x28,
                0xFF,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFCONNECTOR_UDI_EXTERNAL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x74,
                0x59,
                0xCD,
                0x57,
                0x47,
                0xCE,
                0xD9,
                0x11,
                0x92,
                0xDB,
                0x00,
                0x0B,
                0xDB,
                0x28,
                0xFF,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFCONNECTOR_UDI_EMBEDDED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x75,
                0x59,
                0xCD,
                0x57,
                0x47,
                0xCE,
                0xD9,
                0x11,
                0x92,
                0xDB,
                0x00,
                0x0B,
                0xDB,
                0x28,
                0xFF,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFCONNECTOR_MIRACAST
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x77,
                0x59,
                0xCD,
                0x57,
                0x47,
                0xCE,
                0xD9,
                0x11,
                0x92,
                0xDB,
                0x00,
                0x0B,
                0xDB,
                0x28,
                0xFF,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFCONNECTOR_TRANSPORT_AGNOSTIC_DIGITAL_MODE_A
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x78,
                0x59,
                0xCD,
                0x57,
                0x47,
                0xCE,
                0xD9,
                0x11,
                0x92,
                0xDB,
                0x00,
                0x0B,
                0xDB,
                0x28,
                0xFF,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MFCONNECTOR_TRANSPORT_AGNOSTIC_DIGITAL_MODE_B
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x79,
                0x59,
                0xCD,
                0x57,
                0x47,
                0xCE,
                0xD9,
                0x11,
                0x92,
                0xDB,
                0x00,
                0x0B,
                0xDB,
                0x28,
                0xFF,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
