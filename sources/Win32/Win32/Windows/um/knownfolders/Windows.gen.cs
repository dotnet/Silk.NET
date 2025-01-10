// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/knownfolders.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class Windows
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_NetworkFolder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC4,
                0xEE,
                0x0B,
                0xD2,
                0xA8,
                0x5C,
                0x05,
                0x49,
                0xAE,
                0x3B,
                0xBF,
                0x25,
                0x1E,
                0xA0,
                0x9B,
                0x53,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_ComputerFolder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7C,
                0x83,
                0xC0,
                0x0A,
                0xF8,
                0xBB,
                0x2A,
                0x45,
                0x85,
                0x0D,
                0x79,
                0xD0,
                0x8E,
                0x66,
                0x7C,
                0xA7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_InternetFolder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x74,
                0x78,
                0x9F,
                0x4D,
                0x0C,
                0x4E,
                0x04,
                0x49,
                0x96,
                0x7B,
                0x40,
                0xB0,
                0xD2,
                0x0C,
                0x3E,
                0x4B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_ControlPanelFolder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEB,
                0x4A,
                0xA7,
                0x82,
                0xB4,
                0xAE,
                0x5C,
                0x46,
                0xA0,
                0x14,
                0xD0,
                0x97,
                0xEE,
                0x34,
                0x6D,
                0x63,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_PrintersFolder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2D,
                0x4E,
                0xFC,
                0x76,
                0xAD,
                0xD6,
                0x19,
                0x45,
                0xA6,
                0x63,
                0x37,
                0xBD,
                0x56,
                0x06,
                0x81,
                0x85,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_SyncManagerFolder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF8,
                0x8B,
                0x66,
                0x43,
                0x4E,
                0xC1,
                0xB2,
                0x49,
                0x97,
                0xC9,
                0x74,
                0x77,
                0x84,
                0xD7,
                0x84,
                0xB7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_SyncSetupFolder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x38,
                0x41,
                0x21,
                0x0F,
                0xD3,
                0xB1,
                0x90,
                0x4A,
                0xBB,
                0xA9,
                0x27,
                0xCB,
                0xC0,
                0xC5,
                0x38,
                0x9A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_ConflictFolder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x45,
                0xFB,
                0xFE,
                0x4B,
                0x7D,
                0x34,
                0x06,
                0x40,
                0xA5,
                0xBE,
                0xAC,
                0x0C,
                0xB0,
                0x56,
                0x71,
                0x92,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_SyncResultsFolder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x43,
                0x9A,
                0x9A,
                0x28,
                0x44,
                0xBE,
                0x57,
                0x40,
                0xA4,
                0x1B,
                0x58,
                0x7A,
                0x76,
                0xD7,
                0xE7,
                0xF9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_RecycleBinFolder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x46,
                0x40,
                0x53,
                0xB7,
                0xCB,
                0x3E,
                0x18,
                0x4C,
                0xBE,
                0x4E,
                0x64,
                0xCD,
                0x4C,
                0xB7,
                0xD6,
                0xAC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_ConnectionsFolder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2B,
                0xD9,
                0x0C,
                0x6F,
                0x97,
                0x2E,
                0xD1,
                0x45,
                0x88,
                0xFF,
                0xB0,
                0xD1,
                0x86,
                0xB8,
                0xDE,
                0xDD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_Fonts
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB7,
                0x8C,
                0x22,
                0xFD,
                0x11,
                0xAE,
                0xE3,
                0x4A,
                0x86,
                0x4C,
                0x16,
                0xF3,
                0x91,
                0x0A,
                0xB8,
                0xFE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_Desktop
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3A,
                0xCC,
                0xBF,
                0xB4,
                0x2C,
                0xDB,
                0x4C,
                0x42,
                0xB0,
                0x29,
                0x7F,
                0xE9,
                0x9A,
                0x87,
                0xC6,
                0x41,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_Startup
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBB,
                0x20,
                0x7D,
                0xB9,
                0x6A,
                0xF4,
                0x97,
                0x4C,
                0xBA,
                0x10,
                0x5E,
                0x36,
                0x08,
                0x43,
                0x08,
                0x54,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_Programs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x77,
                0x5D,
                0x7F,
                0xA7,
                0x2B,
                0x2E,
                0xC3,
                0x44,
                0xA6,
                0xA2,
                0xAB,
                0xA6,
                0x01,
                0x05,
                0x4A,
                0x51,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_StartMenu
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC3,
                0x53,
                0x5B,
                0x62,
                0x48,
                0xAB,
                0xC1,
                0x4E,
                0xBA,
                0x1F,
                0xA1,
                0xEF,
                0x41,
                0x46,
                0xFC,
                0x19,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_Recent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x81,
                0xC0,
                0x50,
                0xAE,
                0xD2,
                0xEB,
                0x8A,
                0x43,
                0x86,
                0x55,
                0x8A,
                0x09,
                0x2E,
                0x34,
                0x98,
                0x7A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_SendTo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6C,
                0x03,
                0x83,
                0x89,
                0xC0,
                0x27,
                0x4B,
                0x40,
                0x8F,
                0x08,
                0x10,
                0x2D,
                0x10,
                0xDC,
                0xFD,
                0x74,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_Documents
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0x9A,
                0xD3,
                0xFD,
                0x8F,
                0x23,
                0xAF,
                0x46,
                0xAD,
                0xB4,
                0x6C,
                0x85,
                0x48,
                0x03,
                0x69,
                0xC7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_Favorites
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x61,
                0xF7,
                0x77,
                0x17,
                0xAD,
                0x68,
                0x8A,
                0x4D,
                0x87,
                0xBD,
                0x30,
                0xB7,
                0x59,
                0xFA,
                0x33,
                0xDD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_NetHood
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0xBF,
                0xAB,
                0xC5,
                0x7F,
                0xE1,
                0x21,
                0x41,
                0x89,
                0x00,
                0x86,
                0x62,
                0x6F,
                0xC2,
                0xC9,
                0x73,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_PrintHood
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8D,
                0xBD,
                0x74,
                0x92,
                0xD1,
                0xCF,
                0xC3,
                0x41,
                0xB3,
                0x5E,
                0xB1,
                0x3F,
                0x55,
                0xA7,
                0x58,
                0xF4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_Templates
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE8,
                0x93,
                0x32,
                0xA6,
                0x4E,
                0x66,
                0xDB,
                0x48,
                0xA0,
                0x79,
                0xDF,
                0x75,
                0x9E,
                0x05,
                0x09,
                0xF7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_CommonStartup
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x35,
                0xEA,
                0xA5,
                0x82,
                0xCD,
                0xD9,
                0xC5,
                0x47,
                0x96,
                0x29,
                0xE1,
                0x5D,
                0x2F,
                0x71,
                0x4E,
                0x6E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_CommonPrograms
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4E,
                0xD4,
                0x39,
                0x01,
                0xFE,
                0x6A,
                0xF2,
                0x49,
                0x86,
                0x90,
                0x3D,
                0xAF,
                0xCA,
                0xE6,
                0xFF,
                0xB8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_CommonStartMenu
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x19,
                0x57,
                0x11,
                0xA4,
                0x2E,
                0xD6,
                0x1D,
                0x49,
                0xAA,
                0x7C,
                0xE7,
                0x4B,
                0x8B,
                0xE3,
                0xB0,
                0x67,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_PublicDesktop
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0D,
                0x34,
                0xAA,
                0xC4,
                0x0F,
                0xF2,
                0x63,
                0x48,
                0xAF,
                0xEF,
                0xF8,
                0x7E,
                0xF2,
                0xE6,
                0xBA,
                0x25,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_ProgramData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x82,
                0x5D,
                0xAB,
                0x62,
                0xC1,
                0xFD,
                0xC3,
                0x4D,
                0xA9,
                0xDD,
                0x07,
                0x0D,
                0x1D,
                0x49,
                0x5D,
                0x97,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_CommonTemplates
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE7,
                0x37,
                0x42,
                0xB9,
                0xAC,
                0x57,
                0x47,
                0x43,
                0x91,
                0x51,
                0xB0,
                0x8C,
                0x6C,
                0x32,
                0xD1,
                0xF7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_PublicDocuments
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAF,
                0x24,
                0x48,
                0xED,
                0xE4,
                0xDC,
                0xA8,
                0x45,
                0x81,
                0xE2,
                0xFC,
                0x79,
                0x65,
                0x08,
                0x36,
                0x34,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_RoamingAppData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDB,
                0x85,
                0xB6,
                0x3E,
                0xF9,
                0x65,
                0xF6,
                0x4C,
                0xA0,
                0x3A,
                0xE3,
                0xEF,
                0x65,
                0x72,
                0x9F,
                0x3D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_LocalAppData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x85,
                0x27,
                0xB3,
                0xF1,
                0xBA,
                0x6F,
                0xCF,
                0x4F,
                0x9D,
                0x55,
                0x7B,
                0x8E,
                0x7F,
                0x15,
                0x70,
                0x91,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_LocalAppDataLow
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA4,
                0xA1,
                0x20,
                0xA5,
                0x80,
                0x17,
                0xF6,
                0x4F,
                0xBD,
                0x18,
                0x16,
                0x73,
                0x43,
                0xC5,
                0xAF,
                0x16,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_InternetCache
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE8,
                0x81,
                0x24,
                0x35,
                0xBE,
                0x33,
                0x51,
                0x42,
                0xBA,
                0x85,
                0x60,
                0x07,
                0xCA,
                0xED,
                0xCF,
                0x9D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_Cookies
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0x76,
                0x0F,
                0x2B,
                0xE9,
                0xC0,
                0x71,
                0x41,
                0x90,
                0x8E,
                0x08,
                0xA6,
                0x11,
                0xB8,
                0x4F,
                0xF6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_History
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3B,
                0x8A,
                0xDC,
                0xD9,
                0x84,
                0xB7,
                0x2E,
                0x43,
                0xA7,
                0x81,
                0x5A,
                0x11,
                0x30,
                0xA7,
                0x59,
                0x63,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_System
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x77,
                0x4E,
                0xC1,
                0x1A,
                0xE7,
                0x02,
                0x5D,
                0x4E,
                0xB7,
                0x44,
                0x2E,
                0xB1,
                0xAE,
                0x51,
                0x98,
                0xB7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_SystemX86
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB0,
                0x31,
                0x52,
                0xD6,
                0xF1,
                0xB2,
                0x57,
                0x48,
                0xA4,
                0xCE,
                0xA8,
                0xE7,
                0xC6,
                0xEA,
                0x7D,
                0x27,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_Windows
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x04,
                0xF4,
                0x8B,
                0xF3,
                0x43,
                0x1D,
                0xF2,
                0x42,
                0x93,
                0x05,
                0x67,
                0xDE,
                0x0B,
                0x28,
                0xFC,
                0x23,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_Profile
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8F,
                0x85,
                0x6C,
                0x5E,
                0x22,
                0x0E,
                0x60,
                0x47,
                0x9A,
                0xFE,
                0xEA,
                0x33,
                0x17,
                0xB6,
                0x71,
                0x73,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_Pictures
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0x81,
                0xE2,
                0x33,
                0x1E,
                0x4E,
                0x76,
                0x46,
                0x83,
                0x5A,
                0x98,
                0x39,
                0x5C,
                0x3B,
                0xC3,
                0xBB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_ProgramFilesX86
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEF,
                0x40,
                0x5A,
                0x7C,
                0xFB,
                0xA0,
                0xFC,
                0x4B,
                0x87,
                0x4A,
                0xC0,
                0xF2,
                0xE0,
                0xB9,
                0xFA,
                0x8E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_ProgramFilesCommonX86
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x24,
                0x4D,
                0x97,
                0xDE,
                0xC6,
                0xD9,
                0x3E,
                0x4D,
                0xBF,
                0x91,
                0xF4,
                0x45,
                0x51,
                0x20,
                0xB9,
                0x17,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_ProgramFilesX64
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x77,
                0x93,
                0x80,
                0x6D,
                0xF0,
                0x6A,
                0x4B,
                0x44,
                0x89,
                0x57,
                0xA3,
                0x77,
                0x3F,
                0x02,
                0x20,
                0x0E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_ProgramFilesCommonX64
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA7,
                0xD5,
                0x65,
                0x63,
                0x0D,
                0x0F,
                0xE5,
                0x45,
                0x87,
                0xF6,
                0x0D,
                0xA5,
                0x6B,
                0x6A,
                0x4F,
                0x7D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_ProgramFiles
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB6,
                0x63,
                0x5E,
                0x90,
                0xBF,
                0xC1,
                0x4E,
                0x49,
                0xB2,
                0x9C,
                0x65,
                0xB7,
                0x32,
                0xD3,
                0xD2,
                0x1A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_ProgramFilesCommon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x05,
                0xED,
                0xF1,
                0xF7,
                0x6D,
                0x9F,
                0xA2,
                0x47,
                0xAA,
                0xAE,
                0x29,
                0xD3,
                0x17,
                0xC6,
                0xF0,
                0x66,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_UserProgramFiles
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE2,
                0xAE,
                0xD7,
                0x5C,
                0x19,
                0x22,
                0x67,
                0x4A,
                0xB8,
                0x5D,
                0x6C,
                0x9C,
                0xE1,
                0x56,
                0x60,
                0xCB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_UserProgramFilesCommon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x57,
                0x30,
                0xBD,
                0xBC,
                0x5C,
                0xCA,
                0x22,
                0x46,
                0xB4,
                0x2D,
                0xBC,
                0x56,
                0xDB,
                0x0A,
                0xE5,
                0x16,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_AdminTools
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x70,
                0xF1,
                0x4E,
                0x72,
                0x2D,
                0xA4,
                0xEF,
                0x4F,
                0x9F,
                0x26,
                0xB6,
                0x0E,
                0x84,
                0x6F,
                0xBA,
                0x4F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_CommonAdminTools
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7D,
                0x4E,
                0x38,
                0xD0,
                0xC3,
                0xBA,
                0x97,
                0x47,
                0x8F,
                0x14,
                0xCB,
                0xA2,
                0x29,
                0xB3,
                0x92,
                0xB5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_Music
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x71,
                0xD5,
                0xD8,
                0x4B,
                0x19,
                0x6D,
                0xD3,
                0x48,
                0xBE,
                0x97,
                0x42,
                0x22,
                0x20,
                0x08,
                0x0E,
                0x43,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_Videos
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1D,
                0x9B,
                0x98,
                0x18,
                0xB5,
                0x99,
                0x5B,
                0x45,
                0x84,
                0x1C,
                0xAB,
                0x7C,
                0x74,
                0xE4,
                0xDD,
                0xFC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_Ringtones
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4B,
                0x04,
                0x70,
                0xC8,
                0x9E,
                0xF4,
                0x26,
                0x41,
                0xA9,
                0xC3,
                0xB5,
                0x2A,
                0x1F,
                0xF4,
                0x11,
                0xE8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_PublicPictures
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x86,
                0xFB,
                0xEB,
                0xB6,
                0x07,
                0x69,
                0x3C,
                0x41,
                0x9A,
                0xF7,
                0x4F,
                0xC2,
                0xAB,
                0xF0,
                0x7C,
                0xC5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_PublicMusic
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB5,
                0xFA,
                0x14,
                0x32,
                0x57,
                0x97,
                0x98,
                0x42,
                0xBB,
                0x61,
                0x92,
                0xA9,
                0xDE,
                0xAA,
                0x44,
                0xFF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_PublicVideos
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3A,
                0x18,
                0x00,
                0x24,
                0x85,
                0x61,
                0xFB,
                0x49,
                0xA2,
                0xD8,
                0x4A,
                0x39,
                0x2A,
                0x60,
                0x2B,
                0xA3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_PublicRingtones
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x60,
                0xAB,
                0x55,
                0xE5,
                0x3B,
                0x15,
                0x17,
                0x4D,
                0x9F,
                0x04,
                0xA5,
                0xFE,
                0x99,
                0xFC,
                0x15,
                0xEC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_ResourceDir
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x31,
                0x0C,
                0xD1,
                0x8A,
                0xDB,
                0x2A,
                0x96,
                0x42,
                0xA8,
                0xF7,
                0xE4,
                0x70,
                0x12,
                0x32,
                0xC9,
                0x72,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_LocalizedResourcesDir
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5E,
                0x37,
                0x00,
                0x2A,
                0x4C,
                0x22,
                0xDE,
                0x49,
                0xB8,
                0xD1,
                0x44,
                0x0D,
                0xF7,
                0xEF,
                0x3D,
                0xDC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_CommonOEMLinks
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0xE2,
                0xBA,
                0xC1,
                0xDF,
                0x10,
                0x34,
                0x43,
                0xBE,
                0xDD,
                0x7A,
                0xA2,
                0x0B,
                0x22,
                0x7A,
                0x9D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_CDBurning
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x10,
                0xAB,
                0x52,
                0x9E,
                0x0D,
                0xF8,
                0xDF,
                0x49,
                0xAC,
                0xB8,
                0x43,
                0x30,
                0xF5,
                0x68,
                0x78,
                0x55,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_UserProfiles
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x72,
                0xD2,
                0x62,
                0x07,
                0x0A,
                0xC5,
                0xB0,
                0x4B,
                0xA3,
                0x82,
                0x69,
                0x7D,
                0xCD,
                0x72,
                0x9B,
                0x80,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_Playlists
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC7,
                0xC1,
                0x92,
                0xDE,
                0x7F,
                0x83,
                0x69,
                0x4F,
                0xA3,
                0xBB,
                0x86,
                0xE6,
                0x31,
                0x20,
                0x4A,
                0x23,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_SamplePlaylists
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB3,
                0x69,
                0xCA,
                0x15,
                0xEE,
                0x30,
                0xC1,
                0x49,
                0xAC,
                0xE1,
                0x6B,
                0x5E,
                0xC3,
                0x72,
                0xAF,
                0xB5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_SampleMusic
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x68,
                0xC6,
                0x50,
                0xB2,
                0x7D,
                0xF5,
                0xE1,
                0x4E,
                0xA6,
                0x3C,
                0x29,
                0x0E,
                0xE7,
                0xD1,
                0xAA,
                0x1F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_SamplePictures
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x40,
                0x05,
                0x90,
                0xC4,
                0x79,
                0x23,
                0x75,
                0x4C,
                0x84,
                0x4B,
                0x64,
                0xE6,
                0xFA,
                0xF8,
                0x71,
                0x6B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_SampleVideos
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x94,
                0xAD,
                0x9E,
                0x85,
                0x85,
                0x2E,
                0xAD,
                0x48,
                0xA7,
                0x1A,
                0x09,
                0x69,
                0xCB,
                0x56,
                0xA6,
                0xCD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_PhotoAlbums
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x90,
                0xCF,
                0xD2,
                0x69,
                0x33,
                0xFC,
                0xB7,
                0x4F,
                0x9A,
                0x0C,
                0xEB,
                0xB0,
                0xF0,
                0xFC,
                0xB4,
                0x3C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_Public
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA2,
                0x76,
                0xDF,
                0xDF,
                0x2A,
                0xC8,
                0x63,
                0x4D,
                0x90,
                0x6A,
                0x56,
                0x44,
                0xAC,
                0x45,
                0x73,
                0x85,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_ChangeRemovePrograms
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAC,
                0x66,
                0x72,
                0xDF,
                0x74,
                0x92,
                0x67,
                0x48,
                0x8D,
                0x55,
                0x3B,
                0xD6,
                0x61,
                0xDE,
                0x87,
                0x2D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_AppUpdates
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x99,
                0xCE,
                0x05,
                0xA3,
                0x27,
                0xF5,
                0x2B,
                0x49,
                0x8B,
                0x1A,
                0x7E,
                0x76,
                0xFA,
                0x98,
                0xD6,
                0xE4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_AddNewPrograms
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x71,
                0xD9,
                0x61,
                0xDE,
                0xBC,
                0x5E,
                0x02,
                0x4F,
                0xA3,
                0xA9,
                0x6C,
                0x82,
                0x89,
                0x5E,
                0x5C,
                0x04,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_Downloads
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x90,
                0xE2,
                0x4D,
                0x37,
                0x3F,
                0x12,
                0x65,
                0x45,
                0x91,
                0x64,
                0x39,
                0xC4,
                0x92,
                0x5E,
                0x46,
                0x7B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_PublicDownloads
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9B,
                0x4C,
                0x64,
                0x3D,
                0xB8,
                0x1F,
                0x30,
                0x4F,
                0x9B,
                0x45,
                0xF6,
                0x70,
                0x23,
                0x5F,
                0x79,
                0xC0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_SavedSearches
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x04,
                0x3A,
                0x1D,
                0x7D,
                0xBB,
                0xDE,
                0x15,
                0x41,
                0x95,
                0xCF,
                0x2F,
                0x29,
                0xDA,
                0x29,
                0x20,
                0xDA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_QuickLaunch
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x21,
                0xF0,
                0xA4,
                0x52,
                0x75,
                0x7B,
                0xA9,
                0x48,
                0x9F,
                0x6B,
                0x4B,
                0x87,
                0xA2,
                0x10,
                0xBC,
                0x8F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_Contacts
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x54,
                0x48,
                0x78,
                0x56,
                0xCB,
                0xC6,
                0x2B,
                0x46,
                0x81,
                0x69,
                0x88,
                0xE3,
                0x50,
                0xAC,
                0xB8,
                0x82,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_SidebarParts
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2E,
                0x36,
                0x5D,
                0xA7,
                0xFC,
                0x50,
                0xB7,
                0x4F,
                0xAC,
                0x2C,
                0xA8,
                0xBE,
                0xAA,
                0x31,
                0x44,
                0x93,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_SidebarDefaultParts
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x54,
                0x6E,
                0x39,
                0x7B,
                0xC5,
                0x9E,
                0x00,
                0x43,
                0xBE,
                0x0A,
                0x24,
                0x82,
                0xEB,
                0xAE,
                0x1A,
                0x26,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_PublicGameTasks
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x36,
                0x25,
                0xBF,
                0xDE,
                0xA8,
                0xE1,
                0x59,
                0x4C,
                0xB6,
                0xA2,
                0x41,
                0x45,
                0x86,
                0x47,
                0x6A,
                0xEA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_GameTasks
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x61,
                0xAE,
                0x4F,
                0x05,
                0xD8,
                0x4D,
                0x87,
                0x47,
                0x80,
                0xB6,
                0x09,
                0x02,
                0x20,
                0xC4,
                0xB7,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_SavedGames
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFF,
                0x32,
                0x5C,
                0x4C,
                0x9D,
                0xBB,
                0xB0,
                0x43,
                0xB5,
                0xB4,
                0x2D,
                0x72,
                0xE5,
                0x4E,
                0xAA,
                0xA4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_Games
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1A,
                0x2C,
                0xC5,
                0xCA,
                0x3D,
                0xB5,
                0xDC,
                0x4E,
                0x92,
                0xD7,
                0x6B,
                0x2E,
                0x8A,
                0xC1,
                0x94,
                0x34,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_SEARCH_MAPI
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x18,
                0x0E,
                0xEC,
                0x98,
                0x98,
                0x20,
                0x44,
                0x4D,
                0x86,
                0x44,
                0x66,
                0x97,
                0x93,
                0x15,
                0xA2,
                0x81,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_SEARCH_CSC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x46,
                0xE4,
                0x32,
                0xEE,
                0xCA,
                0x31,
                0xBA,
                0x4A,
                0x81,
                0x4F,
                0xA5,
                0xEB,
                0xD2,
                0xFD,
                0x6D,
                0x5E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_Links
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0xD5,
                0xB9,
                0xBF,
                0xA9,
                0xC6,
                0x4C,
                0x40,
                0xB2,
                0xB2,
                0xAE,
                0x6D,
                0xB6,
                0xAF,
                0x49,
                0x68,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_UsersFiles
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7C,
                0x0F,
                0xCE,
                0xF3,
                0x01,
                0x49,
                0xCC,
                0x4A,
                0x86,
                0x48,
                0xD5,
                0xD4,
                0x4B,
                0x04,
                0xEF,
                0x8F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_UsersLibraries
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0x54,
                0x02,
                0xA3,
                0xFF,
                0xDE,
                0x4B,
                0x46,
                0xAB,
                0xE8,
                0x61,
                0xC8,
                0x64,
                0x8D,
                0x93,
                0x9B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_SearchHome
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0x37,
                0x03,
                0x19,
                0xCA,
                0xB8,
                0x21,
                0x41,
                0xA6,
                0x39,
                0x6D,
                0x47,
                0x2D,
                0x16,
                0x97,
                0x2A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_OriginalImages
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAA,
                0xC0,
                0x36,
                0x2C,
                0x12,
                0x58,
                0x87,
                0x4B,
                0xBF,
                0xD0,
                0x4C,
                0xD0,
                0xDF,
                0xB1,
                0x9B,
                0x39,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_DocumentsLibrary
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7D,
                0xB1,
                0x0D,
                0x7B,
                0xD2,
                0x9C,
                0x93,
                0x4A,
                0x97,
                0x33,
                0x46,
                0xCC,
                0x89,
                0x02,
                0x2E,
                0x7C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_MusicLibrary
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0A,
                0xAB,
                0x12,
                0x21,
                0x6A,
                0xC8,
                0xFE,
                0x4F,
                0xA3,
                0x68,
                0x0D,
                0xE9,
                0x6E,
                0x47,
                0x01,
                0x2E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_PicturesLibrary
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9F,
                0xAE,
                0x90,
                0xA9,
                0x3B,
                0xA0,
                0x80,
                0x4E,
                0x94,
                0xBC,
                0x99,
                0x12,
                0xD7,
                0x50,
                0x41,
                0x04,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_VideosLibrary
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2F,
                0x92,
                0x1E,
                0x49,
                0x43,
                0x56,
                0xF4,
                0x4A,
                0xA7,
                0xEB,
                0x4E,
                0x7A,
                0x13,
                0x8D,
                0x81,
                0x74,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_RecordedTVLibrary
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA2,
                0xDB,
                0x6F,
                0x1A,
                0x2D,
                0xF4,
                0x58,
                0x43,
                0xA7,
                0x98,
                0xB7,
                0x4D,
                0x74,
                0x59,
                0x26,
                0xC5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_HomeGroup
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6B,
                0x8A,
                0x52,
                0x52,
                0xE3,
                0xB9,
                0xDD,
                0x4A,
                0xB6,
                0x0D,
                0x58,
                0x8C,
                0x2D,
                0xBA,
                0x84,
                0x2D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_HomeGroupCurrentUser
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA3,
                0xB6,
                0x74,
                0x9B,
                0xFD,
                0x0D,
                0x11,
                0x4F,
                0x9E,
                0x78,
                0x5F,
                0x78,
                0x00,
                0xF2,
                0xE7,
                0x72,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_DeviceMetadataStore
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE9,
                0xA5,
                0xE4,
                0x5C,
                0xEB,
                0xE4,
                0x9D,
                0x47,
                0xB8,
                0x9F,
                0x13,
                0x0C,
                0x02,
                0x88,
                0x61,
                0x55,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_Libraries
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDC,
                0xA5,
                0x3E,
                0x1B,
                0x87,
                0xB5,
                0x86,
                0x47,
                0xB4,
                0xEF,
                0xBD,
                0x1D,
                0xC3,
                0x32,
                0xAE,
                0xAE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_PublicLibraries
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0B,
                0xF8,
                0xDA,
                0x48,
                0xCF,
                0xE6,
                0x4E,
                0x4F,
                0xB8,
                0x00,
                0x0E,
                0x69,
                0xD8,
                0x4E,
                0xE3,
                0x84,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_UserPinned
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0x95,
                0x39,
                0x9E,
                0x9C,
                0x1F,
                0x13,
                0x4F,
                0xB8,
                0x27,
                0x48,
                0xB2,
                0x4B,
                0x6C,
                0x71,
                0x74,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_ImplicitAppShortcuts
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6F,
                0x25,
                0xB5,
                0xBC,
                0xF6,
                0x79,
                0xEE,
                0x4C,
                0xB7,
                0x25,
                0xDC,
                0x34,
                0xE4,
                0x02,
                0xFD,
                0x46,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_AccountPictures
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB1,
                0xA0,
                0x8C,
                0x00,
                0xB4,
                0x55,
                0x56,
                0x4C,
                0xB8,
                0xA8,
                0x4D,
                0xE4,
                0xB2,
                0x99,
                0xD3,
                0xBE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_PublicUserTiles
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6C,
                0xAF,
                0x82,
                0x04,
                0xF1,
                0x08,
                0x34,
                0x4C,
                0x8C,
                0x90,
                0xE1,
                0x7E,
                0xC9,
                0x8B,
                0x1E,
                0x17,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_AppsFolder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8D,
                0x50,
                0x87,
                0x1E,
                0xC2,
                0x89,
                0xF0,
                0x42,
                0x8A,
                0x7E,
                0x64,
                0x5A,
                0x0F,
                0x50,
                0xCA,
                0x58,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_StartMenuAllPrograms
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEF,
                0x05,
                0x63,
                0xF2,
                0x48,
                0x69,
                0xB9,
                0x40,
                0xB2,
                0x55,
                0x81,
                0x45,
                0x3D,
                0x09,
                0xC7,
                0x85,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_CommonStartMenuPlaces
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9F,
                0x87,
                0x40,
                0xA4,
                0xA0,
                0x87,
                0x7D,
                0x4F,
                0xB7,
                0x00,
                0x02,
                0x07,
                0xB9,
                0x66,
                0x19,
                0x4A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_ApplicationShortcuts
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x81,
                0x87,
                0x91,
                0xA3,
                0xF2,
                0xE5,
                0x90,
                0x48,
                0xB3,
                0xD9,
                0xA7,
                0xE5,
                0x43,
                0x32,
                0x32,
                0x8C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_RoamingTiles
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5A,
                0xFC,
                0xBC,
                0x00,
                0x94,
                0xED,
                0x48,
                0x4E,
                0x96,
                0xA1,
                0x3F,
                0x62,
                0x17,
                0xF2,
                0x19,
                0x90,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_RoamedTileImages
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA5,
                0xD5,
                0xA8,
                0xAA,
                0xD6,
                0xF1,
                0x59,
                0x42,
                0xBA,
                0xA8,
                0x78,
                0xE7,
                0xEF,
                0x60,
                0x83,
                0x5E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_Screenshots
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x81,
                0xDE,
                0xBE,
                0xB7,
                0x94,
                0xDF,
                0x82,
                0x46,
                0xA7,
                0xD8,
                0x57,
                0xA5,
                0x26,
                0x20,
                0xB8,
                0x6F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_CameraRoll
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7B,
                0xB8,
                0x5F,
                0xAB,
                0xE2,
                0x7C,
                0x83,
                0x4F,
                0x91,
                0x5D,
                0x55,
                0x08,
                0x46,
                0xC9,
                0x53,
                0x7B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_SkyDrive
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x46,
                0xBA,
                0x2B,
                0xA5,
                0xE1,
                0xE9,
                0x5F,
                0x43,
                0xB3,
                0xD9,
                0x28,
                0xDA,
                0xA6,
                0x48,
                0xC0,
                0xF6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_OneDrive
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x46,
                0xBA,
                0x2B,
                0xA5,
                0xE1,
                0xE9,
                0x5F,
                0x43,
                0xB3,
                0xD9,
                0x28,
                0xDA,
                0xA6,
                0x48,
                0xC0,
                0xF6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_SkyDriveDocuments
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x24,
                0x9E,
                0xD8,
                0x24,
                0x19,
                0x2F,
                0x34,
                0x45,
                0x9D,
                0xDE,
                0x6A,
                0x66,
                0x71,
                0xFB,
                0xB8,
                0xFE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_SkyDrivePictures
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB5,
                0x19,
                0x97,
                0x33,
                0x47,
                0x8C,
                0x94,
                0x48,
                0x94,
                0xC2,
                0xD8,
                0xF7,
                0x7A,
                0xDD,
                0x44,
                0xA6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_SkyDriveMusic
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9E,
                0x45,
                0xF2,
                0xC3,
                0xD6,
                0x80,
                0xDC,
                0x45,
                0xBF,
                0xEF,
                0x1F,
                0x76,
                0x9F,
                0x2B,
                0xE7,
                0x30,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_SkyDriveCameraRoll
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x11,
                0x68,
                0x7E,
                0x76,
                0xCB,
                0x49,
                0x73,
                0x42,
                0x87,
                0xC2,
                0x20,
                0xF3,
                0x55,
                0xE1,
                0x08,
                0x5B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_SearchHistory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB6,
                0x3D,
                0x4C,
                0x0D,
                0xA3,
                0x03,
                0x2F,
                0x46,
                0xA0,
                0xE6,
                0x08,
                0x92,
                0x4C,
                0x41,
                0xB5,
                0xD4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_SearchTemplates
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFE,
                0x6B,
                0x63,
                0x7E,
                0xA9,
                0xDF,
                0x5E,
                0x4D,
                0xB4,
                0x56,
                0xD7,
                0xB3,
                0x98,
                0x51,
                0xD8,
                0xA9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_CameraRollLibrary
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x75,
                0xDF,
                0x20,
                0x2B,
                0xDA,
                0x1E,
                0x39,
                0x40,
                0x80,
                0x97,
                0x38,
                0x79,
                0x82,
                0x27,
                0xD5,
                0xB7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_SavedPictures
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x82,
                0x38,
                0x19,
                0x3B,
                0xAD,
                0xD3,
                0xAB,
                0x4E,
                0x96,
                0x5A,
                0x69,
                0x82,
                0x9D,
                0x1F,
                0xB5,
                0x9F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_SavedPicturesLibrary
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x12,
                0x58,
                0x5B,
                0xE2,
                0x88,
                0xBE,
                0xD9,
                0x4B,
                0x94,
                0xB0,
                0x29,
                0x23,
                0x34,
                0x77,
                0xB6,
                0xC3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_RetailDemo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9E,
                0xC6,
                0xD4,
                0x12,
                0xAD,
                0x24,
                0x23,
                0x49,
                0xBE,
                0x19,
                0x31,
                0x32,
                0x1C,
                0x43,
                0xA7,
                0x67,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_Device
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDC,
                0xC1,
                0x2A,
                0x1C,
                0x58,
                0x43,
                0x6C,
                0x4B,
                0x97,
                0x33,
                0xAF,
                0x21,
                0x15,
                0x65,
                0x76,
                0xF0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_DevelopmentFiles
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8E,
                0xE0,
                0xE8,
                0xDB,
                0x53,
                0x30,
                0xBC,
                0x4B,
                0xB1,
                0x83,
                0x2A,
                0x7B,
                0x2B,
                0x19,
                0x1E,
                0x59,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_Objects3D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x25,
                0xDD,
                0xC0,
                0x31,
                0x39,
                0x94,
                0x12,
                0x4F,
                0xBF,
                0x41,
                0x7F,
                0xF4,
                0xED,
                0xA3,
                0x87,
                0x22,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_AppCaptures
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x71,
                0xFE,
                0xC0,
                0xED,
                0xD8,
                0x98,
                0x4A,
                0x4F,
                0xB9,
                0x20,
                0xC8,
                0xDC,
                0x13,
                0x3C,
                0xB1,
                0x65,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_LocalDocuments
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD3,
                0xE2,
                0x2E,
                0xF4,
                0x9F,
                0x90,
                0x07,
                0x49,
                0x88,
                0x71,
                0x4C,
                0x22,
                0xFC,
                0x0B,
                0xF7,
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_LocalPictures
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0x01,
                0xDD,
                0x0D,
                0x6C,
                0xB0,
                0xD5,
                0x45,
                0x8C,
                0x4C,
                0xF5,
                0x97,
                0x13,
                0x85,
                0x46,
                0x39,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_LocalVideos
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x68,
                0x6A,
                0x28,
                0x35,
                0x57,
                0x3C,
                0xA1,
                0x41,
                0xBB,
                0xB1,
                0x0E,
                0xAE,
                0x73,
                0xD7,
                0x6C,
                0x95,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_LocalMusic
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x99,
                0x9A,
                0xC6,
                0xA0,
                0xC8,
                0x21,
                0x71,
                0x46,
                0x87,
                0x03,
                0x79,
                0x34,
                0x16,
                0x2F,
                0xCF,
                0x1D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_LocalDownloads
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9B,
                0xEE,
                0x83,
                0x7D,
                0x44,
                0x22,
                0x70,
                0x4E,
                0xB1,
                0xF5,
                0x53,
                0x93,
                0x04,
                0x2A,
                0xF1,
                0xE4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_RecordedCalls
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC2,
                0x40,
                0x8B,
                0x2F,
                0xED,
                0x83,
                0xEE,
                0x48,
                0xB3,
                0x83,
                0xA1,
                0xF1,
                0x57,
                0xEC,
                0x6F,
                0x9A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_AllAppMods
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x99,
                0x78,
                0xD6,
                0x7A,
                0xAF,
                0x66,
                0xBA,
                0x43,
                0x91,
                0x56,
                0x6A,
                0xAD,
                0x42,
                0xE6,
                0xC5,
                0x96,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_CurrentAppMods
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0x0B,
                0xB4,
                0x3D,
                0x30,
                0x2A,
                0xBE,
                0x4D,
                0x91,
                0x7E,
                0x77,
                0x1D,
                0xD2,
                0x1D,
                0xD0,
                0x99,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_AppDataDesktop
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x79,
                0xE2,
                0xC5,
                0xB2,
                0xDD,
                0x7A,
                0x9F,
                0x43,
                0xB2,
                0x8C,
                0xC4,
                0x1F,
                0xE1,
                0xBB,
                0xF6,
                0x72,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_AppDataDocuments
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x10,
                0x66,
                0xE1,
                0x7B,
                0x7F,
                0x1F,
                0xAC,
                0x44,
                0xBF,
                0xF0,
                0x83,
                0xE1,
                0x5F,
                0x2F,
                0xFC,
                0xA1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_AppDataFavorites
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBC,
                0xEF,
                0xFB,
                0x7C,
                0x1F,
                0xDE,
                0xAA,
                0x45,
                0xB8,
                0x43,
                0xA5,
                0x42,
                0xAC,
                0x53,
                0x6C,
                0xC9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_AppDataProgramData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA3,
                0x40,
                0x9D,
                0x55,
                0x36,
                0xA0,
                0xFA,
                0x40,
                0xAF,
                0x61,
                0x84,
                0xCB,
                0x43,
                0x0A,
                0x4D,
                0x34,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid FOLDERID_LocalStorage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD3,
                0x08,
                0xEB,
                0xB3,
                0xF3,
                0xA1,
                0x6B,
                0x49,
                0x86,
                0x5A,
                0x42,
                0xB5,
                0x36,
                0xCD,
                0xA0,
                0xEC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
