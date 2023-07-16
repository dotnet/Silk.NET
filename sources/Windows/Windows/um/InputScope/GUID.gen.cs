// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InputScope.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class GUID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_PROP_INPUTSCOPE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5A,
                0xDD,
                0x13,
                0x17,
                0xE7,
                0x68,
                0x5B,
                0x4A,
                0x9A,
                0xF6,
                0x59,
                0x2A,
                0x59,
                0x5C,
                0x77,
                0x8D
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}