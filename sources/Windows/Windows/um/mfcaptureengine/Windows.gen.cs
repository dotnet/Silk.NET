// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class Windows
{
    [NativeTypeName("const IID")]
    public static ref readonly Guid MFSampleExtension_DeviceReferenceSystemTime
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5A,
                0x77,
                0x23,
                0x65,
                0x2D,
                0xBA,
                0x5F,
                0x40,
                0xB2,
                0xC5,
                0x01,
                0xFF,
                0x88,
                0xE2,
                0xE8,
                0xF6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}