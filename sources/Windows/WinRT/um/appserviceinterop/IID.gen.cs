// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/appserviceinterop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IAppServiceConnectionExtendedExecution
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x84,
                0x95,
                0x21,
                0x65,
                0xCB,
                0xF9,
                0xE3,
                0x4A,
                0x81,
                0xF9,
                0xA2,
                0x8A,
                0x6C,
                0xA4,
                0x50,
                0xD9
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICorrelationVectorSource
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x3B,
                0x8A,
                0x2B,
                0x15,
                0xB9,
                0xB9,
                0x85,
                0x46,
                0xB5,
                0x6E,
                0x97,
                0x48,
                0x47,
                0xBC,
                0x75,
                0x45
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}