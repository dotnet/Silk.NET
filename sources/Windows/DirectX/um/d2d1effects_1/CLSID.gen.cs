// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effects_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.DirectX;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class CLSID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_D2D1YCbCr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC1,
                0x3C,
                0x50,
                0x99,
                0xC7,
                0x66,
                0xC9,
                0x45,
                0xA8,
                0x75,
                0x8A,
                0xD8,
                0xA7,
                0x91,
                0x44,
                0x01
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}