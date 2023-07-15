// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/knownfolderpathscom.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IUserDataPathsInterop
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xB5,
                0xF0,
                0x2E,
                0xF1,
                0xFB,
                0xBE,
                0xC9,
                0x46,
                0x9E,
                0xE5,
                0x8A,
                0x06,
                0x81,
                0xF1,
                0x3F,
                0x8C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISystemDataPathsInterop
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x26,
                0x0B,
                0x4D,
                0x86,
                0x37,
                0x3A,
                0x51,
                0x42,
                0x9A,
                0x02,
                0xB2,
                0x31,
                0x19,
                0x8D,
                0xE0,
                0x60
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}