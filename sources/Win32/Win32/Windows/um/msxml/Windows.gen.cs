// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msxml.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class Windows
{
    public static ref readonly Guid DIID_XMLDOMDocumentEvents
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x27,
                0xA4,
                0xFA,
                0x3E,
                0x2F,
                0x27,
                0xD2,
                0x11,
                0x83,
                0x6F,
                0x00,
                0x00,
                0xF8,
                0x7A,
                0x77,
                0x82,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
