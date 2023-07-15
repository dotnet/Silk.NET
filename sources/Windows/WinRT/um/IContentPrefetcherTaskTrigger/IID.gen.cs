// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IContentPrefetcherTaskTrigger.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IContentPrefetcherTaskTrigger
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x4A,
                0xA1,
                0x35,
                0x1B,
                0x94,
                0x60,
                0x99,
                0x47,
                0xA6,
                0x0E,
                0xE4,
                0x74,
                0xE1,
                0x5D,
                0x4D,
                0xC9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}