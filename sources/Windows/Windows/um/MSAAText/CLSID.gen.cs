// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class CLSID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_MSAAControl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3F,
                0x96,
                0xCD,
                0x08,
                0x3E,
                0x7A,
                0x5C,
                0x4F,
                0x9B,
                0xD8,
                0xD6,
                0x92,
                0xBB,
                0x04,
                0x3C,
                0x5B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_AccStore
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7F,
                0x83,
                0x40,
                0x54,
                0xFF,
                0x4B,
                0xE5,
                0x4A,
                0xA1,
                0xB1,
                0x77,
                0x22,
                0xEC,
                0xC6,
                0x33,
                0x2A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_AccDictionary
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x16,
                0xEE,
                0x72,
                0x65,
                0xE5,
                0x5F,
                0x31,
                0x43,
                0xBB,
                0x6D,
                0x76,
                0xA4,
                0x9C,
                0x56,
                0xE4,
                0x23
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_AccServerDocMgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7E,
                0xA3,
                0x89,
                0x60,
                0x8A,
                0xEB,
                0x2D,
                0x48,
                0xBD,
                0x6F,
                0xF9,
                0xF4,
                0x69,
                0x04,
                0xD1,
                0x6D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_AccClientDocMgr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x30,
                0xCC,
                0x48,
                0xFC,
                0x3E,
                0x4F,
                0xA1,
                0x4F,
                0x80,
                0x3B,
                0xAD,
                0x0E,
                0x19,
                0x6A,
                0x83,
                0xB1
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_DocWrap
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7E,
                0x6F,
                0x42,
                0xBF,
                0x5E,
                0x7A,
                0xD6,
                0x44,
                0x83,
                0x0C,
                0xA3,
                0x90,
                0xEA,
                0x94,
                0x62,
                0xA3
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}