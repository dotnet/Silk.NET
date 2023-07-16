// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class MFPKEY
{
    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MFPKEY_CLSID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC0,
                0x84,
                0x7A,
                0xC5,
                0x80,
                0x1A,
                0xA3,
                0x40,
                0x97,
                0xB5,
                0x92,
                0x72,
                0xA4,
                0x03,
                0xC8,
                0xAE,
                0x01,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MFPKEY_CATEGORY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC0,
                0x84,
                0x7A,
                0xC5,
                0x80,
                0x1A,
                0xA3,
                0x40,
                0x97,
                0xB5,
                0x92,
                0x72,
                0xA4,
                0x03,
                0xC8,
                0xAE,
                0x02,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MFPKEY_EXATTRIBUTE_SUPPORTED
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x43,
                0xE8,
                0x6F,
                0x45,
                0x87,
                0x3C,
                0xC0,
                0x40,
                0x94,
                0x9D,
                0x14,
                0x09,
                0xC9,
                0x7D,
                0xAB,
                0x2C,
                0x01,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MFPKEY_MULTICHANNEL_CHANNEL_MASK
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8C,
                0xAF,
                0xBD,
                0x58,
                0x24,
                0x32,
                0x92,
                0x46,
                0x86,
                0xD0,
                0x44,
                0xD6,
                0x5C,
                0x5B,
                0xF8,
                0x2B,
                0x01,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }
}