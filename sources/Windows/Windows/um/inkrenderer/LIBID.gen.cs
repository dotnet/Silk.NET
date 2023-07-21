// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/inkrenderer.h and um/inkrenderer_i.c in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class LIBID
{
    [NativeTypeName("const IID")]
    public static ref readonly Guid LIBID_InkD2DRendererLib
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xB0, 0x0A, 0x0D, 0x39,
                0xE2, 0x19,
                0xBB, 0x46,
                0x86,
                0x2E,
                0xB0,
                0x9F,
                0x3C,
                0xDC,
                0xF8,
                0xB9
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
