// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class CLSID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_MFSourceResolver
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x0F,
                0xB6,
                0xEA,
                0x90,
                0x3A,
                0xE4,
                0x88,
                0x41,
                0xBC,
                0xC4,
                0xE4,
                0x7F,
                0xDF,
                0x04,
                0x86,
                0x8C
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}