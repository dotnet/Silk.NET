// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlGuid.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class FMTID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid FMTID_Intshcut
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA0,
                0x14,
                0x02,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0xC0,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FMTID_InternetSite
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA1,
                0x14,
                0x02,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0xC0,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x46
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FMTID_ShellDetails
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA6,
                0x6A,
                0x63,
                0x28,
                0x3D,
                0x95,
                0xD2,
                0x11,
                0xB5,
                0xD6,
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

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FMTID_Storage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x30,
                0xF1,
                0x25,
                0xB7,
                0xEF,
                0x47,
                0x1A,
                0x10,
                0xA5,
                0xF1,
                0x02,
                0x60,
                0x8C,
                0x9E,
                0xEB,
                0xAC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FMTID_ImageProperties
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA1,
                0x1D,
                0xB8,
                0x14,
                0x35,
                0x01,
                0x31,
                0x4D,
                0x96,
                0xD9,
                0x6C,
                0xBF,
                0xC9,
                0x67,
                0x1A,
                0x99
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FMTID_CustomImageProperties
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0E,
                0x8B,
                0xCD,
                0x7E,
                0x36,
                0xC1,
                0x9B,
                0x4A,
                0x94,
                0x11,
                0x4E,
                0xBD,
                0x66,
                0x73,
                0xCC,
                0xC3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FMTID_LibraryProperties
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7F,
                0xB6,
                0x76,
                0x5D,
                0x3D,
                0x9B,
                0xBB,
                0x44,
                0xB6,
                0xAE,
                0x25,
                0xDA,
                0x4F,
                0x63,
                0x8A,
                0x67
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FMTID_Displaced
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x33,
                0x4B,
                0x17,
                0x9B,
                0xFF,
                0x40,
                0xD2,
                0x11,
                0xA2,
                0x7E,
                0x00,
                0xC0,
                0x4F,
                0xC3,
                0x08,
                0x71
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FMTID_Briefcase
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x21,
                0x8B,
                0x8D,
                0x32,
                0x29,
                0x77,
                0xFC,
                0x4B,
                0x95,
                0x4C,
                0x90,
                0x2B,
                0x32,
                0x9D,
                0x56,
                0xB0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FMTID_Misc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x34,
                0x4B,
                0x17,
                0x9B,
                0xFF,
                0x40,
                0xD2,
                0x11,
                0xA2,
                0x7E,
                0x00,
                0xC0,
                0x4F,
                0xC3,
                0x08,
                0x71
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FMTID_WebView
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x80,
                0x54,
                0x27,
                0xF2,
                0x82,
                0xF7,
                0x91,
                0x42,
                0xBD,
                0x94,
                0xF1,
                0x36,
                0x93,
                0x51,
                0x3A,
                0xEC
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FMTID_MUSIC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2E,
                0x37,
                0xA3,
                0x56,
                0x9C,
                0xCE,
                0xD2,
                0x11,
                0x9F,
                0x0E,
                0x00,
                0x60,
                0x97,
                0xC6,
                0x86,
                0xF6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FMTID_DRM
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE4,
                0x19,
                0xAC,
                0xAE,
                0xAE,
                0x89,
                0x08,
                0x45,
                0xB9,
                0xB7,
                0xBB,
                0x86,
                0x7A,
                0xBE,
                0xE2,
                0xED
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FMTID_Volume
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x35,
                0x4B,
                0x17,
                0x9B,
                0xFF,
                0x40,
                0xD2,
                0x11,
                0xA2,
                0x7E,
                0x00,
                0xC0,
                0x4F,
                0xC3,
                0x08,
                0x71
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FMTID_Query
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x90,
                0x1C,
                0x69,
                0x49,
                0x17,
                0x7E,
                0x1A,
                0x10,
                0xA9,
                0x1C,
                0x08,
                0x00,
                0x2B,
                0x2E,
                0xCD,
                0xA9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}