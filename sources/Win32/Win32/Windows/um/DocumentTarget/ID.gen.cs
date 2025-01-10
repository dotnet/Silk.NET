// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DocumentTarget.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class ID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid ID_DOCUMENTPACKAGETARGET_MSXPS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA8,
                0x40,
                0xAE,
                0x9C,
                0xD1,
                0xDE,
                0xC9,
                0x41,
                0xA9,
                0xFD,
                0xD7,
                0x35,
                0xEF,
                0x33,
                0xAE,
                0xDA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid ID_DOCUMENTPACKAGETARGET_OPENXPS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x72,
                0xBB,
                0x56,
                0x00,
                0x9C,
                0x8C,
                0x12,
                0x46,
                0xBD,
                0x0F,
                0x93,
                0x01,
                0x2A,
                0x87,
                0x09,
                0x9D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid ID_DOCUMENTPACKAGETARGET_OPENXPS_WITH_3D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0xD7,
                0xDB,
                0x63,
                0x14,
                0x8B,
                0x77,
                0x45,
                0xB0,
                0x74,
                0x7B,
                0xB1,
                0x1B,
                0x59,
                0x6D,
                0x28,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
