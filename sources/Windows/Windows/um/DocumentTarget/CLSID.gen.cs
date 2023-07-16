// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DocumentTarget.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class CLSID
{
    public static ref readonly Guid CLSID_PrintDocumentPackageTarget
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x9E,
                0x66,
                0x42,
                0x48,
                0x47,
                0x99,
                0xEA,
                0x46,
                0x8B,
                0xA2,
                0xD8,
                0xCC,
                0xE4,
                0x32,
                0xC2,
                0xCA
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_PrintDocumentPackageTargetFactory
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7D,
                0xF1,
                0x8E,
                0x34,
                0x81,
                0x6C,
                0x82,
                0x49,
                0x92,
                0xB4,
                0xEE,
                0x18,
                0x8A,
                0x43,
                0x86,
                0x7A
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}