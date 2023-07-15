// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class CLSID
{
    [NativeTypeName("const IID")]
    public static ref readonly Guid CLSID_MFByteStreamProxyClassFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x77,
                0x8E,
                0x0E,
                0x77,
                0x16,
                0x49,
                0x1C,
                0x44,
                0xA9,
                0xA7,
                0xB3,
                0x42,
                0xD0,
                0xEE,
                0xBC,
                0x71
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}