// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IsolatedAppLauncher.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class CLSID
{
    public static ref readonly Guid CLSID_IsolatedAppLauncher
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x30, 0x24, 0x81, 0xBC,
                0x5E, 0xE7,
                0xD1, 0x4F,
                0x96,
                0x41,
                0x1F,
                0x9F,
                0x1E,
                0x2D,
                0x9A,
                0x1F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
