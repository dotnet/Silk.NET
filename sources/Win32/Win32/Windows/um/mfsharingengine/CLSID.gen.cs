// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class CLSID
{
    [NativeTypeName("const IID")]
    public static ref readonly Guid CLSID_MFMediaSharingEngineClassFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFB,
                0x07,
                0xE3,
                0xF8,
                0x45,
                0x6D,
                0xD3,
                0x4A,
                0x99,
                0x93,
                0x66,
                0xCD,
                0x5A,
                0x52,
                0x96,
                0x59,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid CLSID_MFImageSharingEngineClassFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x39,
                0x33,
                0x2C,
                0xB2,
                0xF3,
                0x87,
                0x59,
                0x40,
                0xA0,
                0xC5,
                0x03,
                0x7A,
                0xA9,
                0x70,
                0x7E,
                0xAF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid CLSID_PlayToSourceClassFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9A,
                0x53,
                0x17,
                0xDA,
                0xC3,
                0x3D,
                0xC1,
                0x42,
                0xA7,
                0x49,
                0xA1,
                0x83,
                0xB5,
                0x1F,
                0x08,
                0x5E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
