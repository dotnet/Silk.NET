// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlGuid.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class BHID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid BHID_SFObject
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x24,
                0xE2,
                0x81,
                0x39,
                0x59,
                0xF5,
                0xD3,
                0x11,
                0x8E,
                0x3A,
                0x00,
                0xC0,
                0x4F,
                0x68,
                0x37,
                0xD5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid BHID_SFUIObject
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x25,
                0xE2,
                0x81,
                0x39,
                0x59,
                0xF5,
                0xD3,
                0x11,
                0x8E,
                0x3A,
                0x00,
                0xC0,
                0x4F,
                0x68,
                0x37,
                0xD5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid BHID_SFViewObject
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x26,
                0xE2,
                0x81,
                0x39,
                0x59,
                0xF5,
                0xD3,
                0x11,
                0x8E,
                0x3A,
                0x00,
                0xC0,
                0x4F,
                0x68,
                0x37,
                0xD5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid BHID_Storage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x27,
                0xE2,
                0x81,
                0x39,
                0x59,
                0xF5,
                0xD3,
                0x11,
                0x8E,
                0x3A,
                0x00,
                0xC0,
                0x4F,
                0x68,
                0x37,
                0xD5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid BHID_Stream
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAB,
                0xB3,
                0xEB,
                0x1C,
                0x10,
                0x7C,
                0x9A,
                0x49,
                0xA4,
                0x17,
                0x92,
                0xCA,
                0x16,
                0xC4,
                0xCB,
                0x83
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid BHID_RandomAccessStream
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3B,
                0xC9,
                0x6F,
                0xF1,
                0xAE,
                0x77,
                0xFE,
                0x4C,
                0xBD,
                0xA7,
                0xA8,
                0x66,
                0xEE,
                0xA6,
                0x87,
                0x8D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid BHID_LinkTargetItem
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x28,
                0xE2,
                0x81,
                0x39,
                0x59,
                0xF5,
                0xD3,
                0x11,
                0x8E,
                0x3A,
                0x00,
                0xC0,
                0x4F,
                0x68,
                0x37,
                0xD5
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid BHID_StorageEnum
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xE3,
                0xA4,
                0x21,
                0x46,
                0xD6,
                0xF0,
                0x73,
                0x47,
                0x8A,
                0x9C,
                0x46,
                0xE7,
                0x7B,
                0x17,
                0x48,
                0x40
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid BHID_Transfer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA1,
                0x46,
                0xE3,
                0xD5,
                0x53,
                0xF7,
                0x32,
                0x49,
                0xB4,
                0x03,
                0x45,
                0x74,
                0x80,
                0x0E,
                0x24,
                0x98
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid BHID_PropertyStore
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xA4,
                0xE1,
                0x84,
                0x03,
                0x23,
                0x15,
                0x9C,
                0x43,
                0xA4,
                0xC8,
                0xAB,
                0x91,
                0x10,
                0x52,
                0xF5,
                0x86
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid BHID_ThumbnailHandler
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0A,
                0x65,
                0x2E,
                0x7B,
                0x20,
                0x8E,
                0x4A,
                0x4F,
                0xB0,
                0x9E,
                0x65,
                0x97,
                0xAF,
                0xC7,
                0x2F,
                0xB0
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid BHID_EnumItems
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x19,
                0x05,
                0xF6,
                0x94,
                0x50,
                0x28,
                0x24,
                0x49,
                0xAA,
                0x5A,
                0xD1,
                0x5E,
                0x84,
                0x86,
                0x80,
                0x39
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid BHID_DataObject
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9F,
                0xBD,
                0xC0,
                0xB8,
                0x24,
                0xED,
                0x5C,
                0x45,
                0x83,
                0xE6,
                0xD5,
                0x39,
                0x0C,
                0x4F,
                0xE8,
                0xC4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid BHID_AssociationArray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x17,
                0xEF,
                0xA9,
                0xBE,
                0xF1,
                0x82,
                0x60,
                0x4F,
                0x92,
                0x84,
                0x4F,
                0x8D,
                0xB7,
                0x5C,
                0x3B,
                0xE9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid BHID_Filter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x78,
                0x87,
                0xD0,
                0x38,
                0x57,
                0xF5,
                0x90,
                0x46,
                0x9E,
                0xBF,
                0xBA,
                0x54,
                0x70,
                0x6A,
                0xD8,
                0xF7
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid BHID_EnumAssocHandlers
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9C,
                0x0B,
                0xAB,
                0xB8,
                0xEC,
                0xC2,
                0x7A,
                0x4F,
                0x91,
                0x8D,
                0x31,
                0x49,
                0x00,
                0xE6,
                0x28,
                0x0A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid BHID_StorageItem
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x09,
                0x21,
                0x4E,
                0x40,
                0xD2,
                0x77,
                0x99,
                0x46,
                0xA5,
                0xA0,
                0x4F,
                0xDF,
                0x10,
                0xDB,
                0x98,
                0x37
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid BHID_FilePlaceholder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xEB,
                0xDC,
                0x77,
                0x86,
                0xE0,
                0xAA,
                0x05,
                0x40,
                0x8D,
                0x3D,
                0x54,
                0x7F,
                0xA8,
                0x52,
                0xF8,
                0x25
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}