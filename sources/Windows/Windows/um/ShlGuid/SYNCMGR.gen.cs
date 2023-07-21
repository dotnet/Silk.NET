// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlGuid.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class SYNCMGR
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid SYNCMGR_OBJECTID_Icon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xC3, 0x85, 0xBC, 0x6D,
                0x07, 0x5D,
                0x72, 0x4C,
                0xA7,
                0x77,
                0x7F,
                0xEC,
                0x78,
                0x07,
                0x2C,
                0x06
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SYNCMGR_OBJECTID_EventStore
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xB9, 0x34, 0xEF, 0x4B,
                0x86, 0xA7,
                0x75, 0x40,
                0xBA,
                0x88,
                0x0C,
                0x2B,
                0x9D,
                0x89,
                0xA9,
                0x8F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SYNCMGR_OBJECTID_ConflictStore
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xF4, 0x81, 0x81, 0xD7,
                0x89, 0x23,
                0xE4, 0x47,
                0xA9,
                0x60,
                0x60,
                0xBC,
                0xC2,
                0xED,
                0x93,
                0x0B
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SYNCMGR_OBJECTID_BrowseContent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x84, 0xB5, 0xCB, 0x57,
                0xB4, 0xE9,
                0xAE, 0x47,
                0xA1,
                0x20,
                0xC4,
                0xDF,
                0x33,
                0x35,
                0xDE,
                0xE2
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SYNCMGR_OBJECTID_ShowSchedule
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xE3, 0xF3, 0xC6, 0xED,
                0x41, 0x84,
                0x09, 0x41,
                0xAD,
                0xF3,
                0x6C,
                0x1C,
                0xA0,
                0xB7,
                0xDE,
                0x47
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SYNCMGR_OBJECTID_QueryBeforeActivate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x0B, 0xD8, 0x82, 0xD8,
                0xAA, 0xE7,
                0xED, 0x49,
                0x86,
                0xB7,
                0xE6,
                0xE1,
                0xF7,
                0x14,
                0xCD,
                0xFE
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SYNCMGR_OBJECTID_QueryBeforeDeactivate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x82, 0xC2, 0xEF, 0xA0,
                0xE0, 0x60,
                0x0E, 0x46,
                0x93,
                0x74,
                0xEA,
                0x88,
                0x51,
                0x3C,
                0xFC,
                0x80
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SYNCMGR_OBJECTID_QueryBeforeEnable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xF0, 0xF7, 0xCB, 0x04,
                0xEB, 0x5B,
                0xE1, 0x4D,
                0xBC,
                0x90,
                0x90,
                0x83,
                0x45,
                0xC4,
                0x80,
                0xF6
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SYNCMGR_OBJECTID_QueryBeforeDisable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xAA, 0x64, 0x5F, 0xBB,
                0x04, 0xF0,
                0xB5, 0x4E,
                0x8E,
                0x4D,
                0x26,
                0x75,
                0x19,
                0x66,
                0x34,
                0x4C
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SYNCMGR_OBJECTID_QueryBeforeDelete
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x97, 0x33, 0x6C, 0xF7,
                0xB3, 0xAF,
                0xD7, 0x45,
                0xA5,
                0x9F,
                0x5A,
                0x49,
                0xE9,
                0x05,
                0x43,
                0x7E
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid SYNCMGR_OBJECTID_EventLinkClick
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xC1, 0xBD, 0x03, 0x22,
                0xF1, 0x1A,
                0x82, 0x40,
                0x8C,
                0x30,
                0x28,
                0x39,
                0x9F,
                0x41,
                0x38,
                0x4C
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
