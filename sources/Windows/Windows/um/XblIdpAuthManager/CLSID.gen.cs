// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/XblIdpAuthManager.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class CLSID
{
    public static ref readonly Guid CLSID_XblIdpAuthManager
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x4B, 0x53, 0x23, 0xCE,
                0xD8, 0x56,
                0x78, 0x49,
                0x86,
                0xA2,
                0x7E,
                0xE5,
                0x70,
                0x64,
                0x04,
                0x68
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid CLSID_XblIdpAuthTokenResult
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x41, 0x34, 0x49, 0x9F,
                0x4A, 0x74,
                0x0C, 0x41,
                0xAE,
                0x2B,
                0x9A,
                0x22,
                0xF7,
                0xC7,
                0x73,
                0x1F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
