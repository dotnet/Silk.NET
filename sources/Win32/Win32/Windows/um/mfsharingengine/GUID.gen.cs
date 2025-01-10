// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class GUID
{
    [NativeTypeName("const IID")]
    public static ref readonly Guid GUID_PlayToService
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9D,
                0xFF,
                0xA8,
                0xF6,
                0x14,
                0x9E,
                0xC9,
                0x41,
                0xBF,
                0x0F,
                0x12,
                0x0A,
                0x2B,
                0x3C,
                0xE1,
                0x20,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const IID")]
    public static ref readonly Guid GUID_NativeDeviceService
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0xE5,
                0x71,
                0xEF,
                0xF4,
                0x52,
                0xC5,
                0x43,
                0xB8,
                0x6A,
                0xAD,
                0x6C,
                0xB2,
                0x16,
                0xA6,
                0x1E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
