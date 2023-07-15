// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accountssettingspaneinterop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IAccountsSettingsPaneInterop
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xAD,
                0x12,
                0xEE,
                0xD3,
                0x65,
                0x38,
                0x62,
                0x43,
                0x97,
                0x46,
                0xB7,
                0x5A,
                0x68,
                0x2D,
                0xF0,
                0xE6
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}