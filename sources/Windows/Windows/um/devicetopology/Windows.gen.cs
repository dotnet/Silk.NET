// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class Windows
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid EVENTCONTEXT_VOLUMESLIDER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xDE, 0xE9, 0xC2, 0xE2,
                0xB1, 0x09,
                0x04, 0x4B,
                0x84,
                0xE5,
                0x07,
                0x93,
                0x12,
                0x25,
                0xEE,
                0x04
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("#define DEVTOPO_HARDWARE_INITIATED_EVENTCONTEXT 'draH'")]
    public const int DEVTOPO_HARDWARE_INITIATED_EVENTCONTEXT = 0x64726148;
}
