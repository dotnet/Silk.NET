// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/NotificationActivationCallback.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_INotificationActivationCallback
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x37,
                0x18,
                0xE3,
                0x53,
                0x00,
                0x66,
                0x81,
                0x4A,
                0x93,
                0x95,
                0x75,
                0xCF,
                0xFE,
                0x74,
                0x6F,
                0x94
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}