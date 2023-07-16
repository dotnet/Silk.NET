// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfspatialaudio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IMFSpatialAudioObjectBuffer
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x8C,
                0xEC,
                0x96,
                0xD3,
                0x5E,
                0x60,
                0x49,
                0x42,
                0x97,
                0x8D,
                0x72,
                0xAD,
                0x1C,
                0x31,
                0x28,
                0x72
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMFSpatialAudioSample
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9B,
                0x8A,
                0xF2,
                0xAB,
                0x93,
                0x33,
                0x90,
                0x42,
                0xBA,
                0x79,
                0x5F,
                0xFC,
                0x46,
                0xD9,
                0x86,
                0xB2
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}