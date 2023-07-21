// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class AM
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid AM_MEDIA_TYPE_REPRESENTATION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xD2, 0x2A, 0xE4, 0xE2,
                0x2C, 0x13,
                0x1E, 0x49,
                0xA2,
                0x68,
                0x3C,
                0x7C,
                0x2D,
                0xCA,
                0x18,
                0x1F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
