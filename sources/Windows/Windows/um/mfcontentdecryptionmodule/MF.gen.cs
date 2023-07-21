// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcontentdecryptionmodule.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class MF
{
    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MF_CONTENTDECRYPTIONMODULE_INPRIVATESTOREPATH
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xAC, 0xB3, 0x0C, 0x73,
                0xDC, 0x51,
                0xDA, 0x49,
                0xA5,
                0x78,
                0xB9,
                0x53,
                0x86,
                0xB6,
                0x2A,
                0xFE,
                0x01, 0x00, 0x00, 0x00
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MF_CONTENTDECRYPTIONMODULE_STOREPATH
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xB9, 0x93, 0xD9, 0x77,
                0x61, 0xBA,
                0xB7, 0x4B,
                0x92,
                0xC6,
                0x18,
                0xC8,
                0x6A,
                0x18,
                0x9C,
                0x06,
                0x02, 0x00, 0x00, 0x00
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MF_CONTENTDECRYPTIONMODULE_PMPSTORECONTEXT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x35, 0x28, 0x2A, 0x6D,
                0xA9, 0xC3,
                0x81, 0x46,
                0x97,
                0xF2,
                0x0A,
                0xF5,
                0x6B,
                0xE9,
                0x34,
                0x46,
                0x03, 0x00, 0x00, 0x00
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid MF_CONTENTDECRYPTIONMODULE_SERVICE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x45, 0x0C, 0x32, 0x15,
                0x80, 0xFF,
                0x4A, 0x48,
                0x9D,
                0xCB,
                0x0D,
                0xF8,
                0x94,
                0xE6,
                0x9A,
                0x01
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
