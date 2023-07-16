// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/manipulations.h and um/manipulations_i.c in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class CLSID
{
    [NativeTypeName("const CLSID")]
    public static ref readonly Guid CLSID_InertiaProcessor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x87,
                0x70,
                0xB2,
                0xAB,
                0xE0,
                0x4C,
                0x58,
                0x4E,
                0xA0,
                0xCB,
                0xE2,
                0x4D,
                0xF9,
                0x68,
                0x14,
                0xBE
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const CLSID")]
    public static ref readonly Guid CLSID_ManipulationProcessor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB0,
                0x4F,
                0x7D,
                0x59,
                0xFD,
                0x47,
                0xFF,
                0x4A,
                0x89,
                0xB9,
                0xC6,
                0xCF,
                0xAE,
                0x8C,
                0xF0,
                0x8E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}