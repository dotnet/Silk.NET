// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddpbackup.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IDedupReadFileCallback
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x7A, 0xC6, 0xAC, 0x7B,
                0x1D, 0x2F,
                0xD0, 0x42,
                0x89,
                0x7E,
                0x6F,
                0xF6,
                0x2D,
                0xD5,
                0x33,
                0xBB
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDedupBackupSupport
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x63, 0xD9, 0x19, 0xC7,
                0x2D, 0x2B,
                0x5E, 0x41,
                0xAC,
                0xF7,
                0x7E,
                0xB7,
                0xCA,
                0x59,
                0x6F,
                0xF4
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
