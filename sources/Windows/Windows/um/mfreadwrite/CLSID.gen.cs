// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class CLSID
{
    [NativeTypeName("const IID")]
    public static ref readonly Guid CLSID_MFReadWriteClassFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0F,
                0xED,
                0xE2,
                0x48,
                0xC2,
                0x98,
                0x37,
                0x4A,
                0xBE,
                0xD5,
                0x16,
                0x63,
                0x12,
                0xDD,
                0xD8,
                0x3F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid CLSID_MFSourceReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3C,
                0x13,
                0x77,
                0x17,
                0x81,
                0x08,
                0x1B,
                0x41,
                0xA5,
                0x77,
                0xAD,
                0x54,
                0x5F,
                0x07,
                0x14,
                0xC4
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid CLSID_MFSinkWriter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x17,
                0xFB,
                0xBB,
                0xA3,
                0x73,
                0x82,
                0x52,
                0x4E,
                0x9E,
                0x0E,
                0x97,
                0x39,
                0xDC,
                0x88,
                0x79,
                0x90
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}