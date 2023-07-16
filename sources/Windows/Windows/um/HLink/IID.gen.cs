// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/HLink.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    [NativeTypeName("#define IID_IHlinkSource IID_IHlinkTarget")]
    public static ref readonly Guid IID_IHlinkSource => ref IID_IHlinkTarget;

    public static ref readonly Guid IID_IHlink
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC3,
                0xC9,
                0xEA,
                0x79,
                0xF9,
                0xBA,
                0xCE,
                0x11,
                0x8C,
                0x82,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xA9,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHlinkSite
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC2,
                0xC9,
                0xEA,
                0x79,
                0xF9,
                0xBA,
                0xCE,
                0x11,
                0x8C,
                0x82,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xA9,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHlinkTarget
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC4,
                0xC9,
                0xEA,
                0x79,
                0xF9,
                0xBA,
                0xCE,
                0x11,
                0x8C,
                0x82,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xA9,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHlinkFrame
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC5,
                0xC9,
                0xEA,
                0x79,
                0xF9,
                0xBA,
                0xCE,
                0x11,
                0x8C,
                0x82,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xA9,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumHLITEM
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC6,
                0xC9,
                0xEA,
                0x79,
                0xF9,
                0xBA,
                0xCE,
                0x11,
                0x8C,
                0x82,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xA9,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IHlinkBrowseContext
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC7,
                0xC9,
                0xEA,
                0x79,
                0xF9,
                0xBA,
                0xCE,
                0x11,
                0x8C,
                0x82,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xA9,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IExtensionServices
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xCB,
                0xC9,
                0xEA,
                0x79,
                0xF9,
                0xBA,
                0xCE,
                0x11,
                0x8C,
                0x82,
                0x00,
                0xAA,
                0x00,
                0x4B,
                0xA9,
                0x0B
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}