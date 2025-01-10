// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ImageTranscode.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_ITranscodeImage
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDD,
                0x6D,
                0xE8,
                0xBA,
                0x11,
                0xDC,
                0x1C,
                0x42,
                0xB7,
                0xAB,
                0xCC,
                0x55,
                0xD1,
                0xD6,
                0x5C,
                0x44,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ImageTranscode
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x66,
                0x51,
                0xB7,
                0x17,
                0x8F,
                0x92,
                0x7D,
                0x41,
                0x96,
                0x85,
                0x64,
                0xAA,
                0x13,
                0x55,
                0x65,
                0xC1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
