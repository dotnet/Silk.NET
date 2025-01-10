// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/RadialControllerInterop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IRadialControllerInterop
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC9,
                0x35,
                0x05,
                0x1B,
                0xAD,
                0x57,
                0xC1,
                0x45,
                0x9D,
                0x79,
                0xAD,
                0x5C,
                0x34,
                0x36,
                0x05,
                0x13,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRadialControllerConfigurationInterop
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAC,
                0xDA,
                0x7C,
                0x78,
                0x86,
                0x31,
                0x6D,
                0x47,
                0x87,
                0xE4,
                0xB9,
                0x37,
                0x4A,
                0x7B,
                0x99,
                0x70,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRadialControllerIndependentInputSourceInterop
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFF,
                0x7E,
                0x57,
                0x3D,
                0xEE,
                0x4C,
                0xE6,
                0x11,
                0xB5,
                0x35,
                0x00,
                0x1B,
                0xDC,
                0x06,
                0xAB,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
