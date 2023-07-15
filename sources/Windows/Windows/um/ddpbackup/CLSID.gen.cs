// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddpbackup.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class CLSID
{
    public static ref readonly Guid CLSID_DedupBackupSupport
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAD,
                0xB2,
                0xD6,
                0x73,
                0x84,
                0x29,
                0x15,
                0x47,
                0xB2,
                0xE3,
                0x92,
                0x4C,
                0x14,
                0x97,
                0x44,
                0xDD
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}