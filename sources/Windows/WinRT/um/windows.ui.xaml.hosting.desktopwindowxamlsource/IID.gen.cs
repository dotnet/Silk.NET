// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.ui.xaml.hosting.desktopwindowxamlsource.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_IDesktopWindowXamlSourceNative
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xBF,
                0xF1,
                0xBC,
                0x3C,
                0x76,
                0x2F,
                0x9C,
                0x4E,
                0x96,
                0xAB,
                0xE8,
                0x4B,
                0x37,
                0x97,
                0x25,
                0x54
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDesktopWindowXamlSourceNative2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0xC7,
                0xD8,
                0xDC,
                0xE3,
                0x57,
                0x30,
                0x92,
                0x46,
                0x99,
                0xC3,
                0x7B,
                0x77,
                0x20,
                0xAF,
                0xDA,
                0x31
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}