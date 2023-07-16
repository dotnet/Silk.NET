// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class GUID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid GUID_INTEGRATIONSTYLE_SEARCHBOX
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x11,
                0xBD,
                0xD1,
                0xE6,
                0xF7,
                0x82,
                0x03,
                0x49,
                0xAE,
                0x21,
                0x1A,
                0x63,
                0x97,
                0xCD,
                0xE2,
                0xEB
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}