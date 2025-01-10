// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IsolatedAppLauncher.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IIsolatedAppLauncher
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8F,
                0x87,
                0x86,
                0xF6,
                0x42,
                0x7B,
                0xC4,
                0x4C,
                0x96,
                0xFB,
                0xF4,
                0xF3,
                0xB6,
                0xE3,
                0xD2,
                0x4D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IIsolatedProcessLauncher
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x32,
                0x42,
                0xA2,
                0x1A,
                0x91,
                0x9A,
                0x01,
                0x42,
                0x88,
                0xCB,
                0x12,
                0x2F,
                0x9D,
                0x65,
                0x22,
                0xE0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IIsolatedProcessLauncher2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x16,
                0x44,
                0x0E,
                0x78,
                0x72,
                0x5E,
                0x23,
                0x41,
                0x80,
                0x8E,
                0x66,
                0xDC,
                0x64,
                0x79,
                0xFE,
                0xEF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
