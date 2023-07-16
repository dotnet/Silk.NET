// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/remotesystemadditionalinfo.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IRemoteSystemAdditionalInfoProvider
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5F,
                0x3D,
                0xAA,
                0xEE,
                0x63,
                0xEC,
                0x27,
                0x4D,
                0xAF,
                0x38,
                0xE8,
                0x6B,
                0x1D,
                0x72,
                0x92,
                0xCB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}