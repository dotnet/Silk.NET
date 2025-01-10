// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/DocumentSource.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IPrintPreviewPageCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x62,
                0xCC,
                0x31,
                0x0B,
                0xEC,
                0xD7,
                0x47,
                0x47,
                0x9D,
                0x6E,
                0xF2,
                0x53,
                0x7D,
                0x87,
                0x0F,
                0x2B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrintDocumentPageSource
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDB,
                0xB1,
                0x6B,
                0xA9,
                0x2E,
                0x17,
                0x67,
                0x46,
                0x82,
                0xB5,
                0xAD,
                0x97,
                0xA2,
                0x52,
                0x31,
                0x8F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
