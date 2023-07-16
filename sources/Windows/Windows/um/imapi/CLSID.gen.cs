// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class CLSID
{
    public static ref readonly Guid CLSID_MSDiscRecorderObj
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x61,
                0xCA,
                0x0C,
                0x52,
                0xA5,
                0x51,
                0xD3,
                0x11,
                0x91,
                0x44,
                0x00,
                0x10,
                0x4B,
                0xA1,
                0x1C,
                0x5E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_MSDiscMasterObj
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x63,
                0xCA,
                0x0C,
                0x52,
                0xA5,
                0x51,
                0xD3,
                0x11,
                0x91,
                0x44,
                0x00,
                0x10,
                0x4B,
                0xA1,
                0x1C,
                0x5E
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_MSEnumDiscRecordersObj
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x7A,
                0x56,
                0x03,
                0x8A,
                0xCB,
                0x63,
                0xA8,
                0x4B,
                0xBA,
                0xF6,
                0x52,
                0x11,
                0x98,
                0x16,
                0xD1,
                0xEF
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}