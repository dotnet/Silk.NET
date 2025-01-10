// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IPrintDialogCallback
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC3,
                0xA2,
                0x52,
                0x58,
                0x30,
                0x65,
                0xD1,
                0x11,
                0xB6,
                0xA3,
                0x00,
                0x00,
                0xF8,
                0x75,
                0x7B,
                0xF9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IPrintDialogServices
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDA,
                0xAE,
                0x9A,
                0x50,
                0x39,
                0x56,
                0xD1,
                0x11,
                0xB6,
                0xA1,
                0x00,
                0x00,
                0xF8,
                0x75,
                0x7B,
                0xF9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
