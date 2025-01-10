// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/efswrtinterop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IProtectionPolicyManagerInterop
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1D,
                0x65,
                0x52,
                0x46,
                0xFE,
                0xC1,
                0xA1,
                0x4B,
                0x9F,
                0x0A,
                0xC0,
                0xF5,
                0x65,
                0x96,
                0xF7,
                0x21,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProtectionPolicyManagerInterop2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE4,
                0xFB,
                0x7C,
                0x15,
                0x8D,
                0xA7,
                0x56,
                0x41,
                0xB3,
                0x84,
                0x61,
                0xFD,
                0xAC,
                0x41,
                0xE6,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProtectionPolicyManagerInterop3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x33,
                0x39,
                0xC0,
                0xC1,
                0x98,
                0xB3,
                0x93,
                0x4D,
                0xB0,
                0xFD,
                0x29,
                0x72,
                0xAD,
                0xF8,
                0x02,
                0xC2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
