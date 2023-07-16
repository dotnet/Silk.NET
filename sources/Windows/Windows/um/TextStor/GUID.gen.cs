// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/TextStor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class GUID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_TS_SERVICE_DATAOBJECT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB5,
                0xFB,
                0x86,
                0x60,
                0x25,
                0xE2,
                0xCE,
                0x46,
                0xA7,
                0x70,
                0xC1,
                0xBB,
                0xD3,
                0xE0,
                0x5D,
                0x7B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_TS_SERVICE_ACCESSIBLE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x00,
                0x62,
                0x78,
                0xF9,
                0xBF,
                0xA5,
                0x0F,
                0x4A,
                0x8C,
                0x24,
                0xFB,
                0x16,
                0xF5,
                0xD1,
                0xAA,
                0xBB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_TS_SERVICE_ACTIVEX
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x50,
                0x7A,
                0x93,
                0xEA,
                0xA6,
                0xC9,
                0x7D,
                0x4B,
                0x89,
                0x4A,
                0x49,
                0xD9,
                0x9B,
                0x78,
                0x48,
                0x34
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}