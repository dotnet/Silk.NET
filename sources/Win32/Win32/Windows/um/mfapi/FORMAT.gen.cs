// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class FORMAT
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid FORMAT_MFVideoFormat
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2D,
                0xAB,
                0xD4,
                0xAE,
                0x26,
                0x73,
                0xCB,
                0x43,
                0x94,
                0x64,
                0xC8,
                0x79,
                0xCA,
                0xB9,
                0xC4,
                0x3D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
