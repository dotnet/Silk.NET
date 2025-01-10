// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/thumbnailstreamcache.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IThumbnailStreamCache
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0x14,
                0xE1,
                0x90,
                0x69,
                0x95,
                0xD8,
                0x41,
                0xAE,
                0x75,
                0x6D,
                0x4D,
                0x2A,
                0xE7,
                0xCC,
                0xA0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ThumbnailStreamCache
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD3,
                0xFE,
                0xE0,
                0xCB,
                0x91,
                0x4B,
                0x90,
                0x4E,
                0x83,
                0x54,
                0x8A,
                0x8C,
                0x84,
                0xEC,
                0x68,
                0x72,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
