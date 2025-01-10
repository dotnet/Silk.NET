// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xaudio2fx.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class CLSID
{
    public static ref readonly Guid CLSID_AudioVolumeMeter
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x66,
                0xB1,
                0xC3,
                0x4F,
                0x2A,
                0x97,
                0xCF,
                0x40,
                0xBC,
                0x37,
                0x7D,
                0xB0,
                0x3D,
                0xB2,
                0xFB,
                0xA3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid CLSID_AudioReverb
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x16,
                0x3B,
                0x63,
                0xC2,
                0x1B,
                0x47,
                0x98,
                0x44,
                0xB8,
                0xC5,
                0x4F,
                0x09,
                0x59,
                0xE2,
                0xEC,
                0x09,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
