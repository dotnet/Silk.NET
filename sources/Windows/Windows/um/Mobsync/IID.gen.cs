// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static partial class IID
{
    public static ref readonly Guid IID_ISyncMgrSynchronizeCallback
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x41,
                0xDF,
                0x95,
                0x62,
                0xEE,
                0x35,
                0xD1,
                0x11,
                0x87,
                0x07,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x33,
                0x27
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISyncMgrEnumItems
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2A,
                0xDF,
                0x95,
                0x62,
                0xEE,
                0x35,
                0xD1,
                0x11,
                0x87,
                0x07,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x33,
                0x27
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISyncMgrSynchronize
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x40,
                0xDF,
                0x95,
                0x62,
                0xEE,
                0x35,
                0xD1,
                0x11,
                0x87,
                0x07,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x33,
                0x27
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISyncMgrSynchronizeInvoke
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2C,
                0xDF,
                0x95,
                0x62,
                0xEE,
                0x35,
                0xD1,
                0x11,
                0x87,
                0x07,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x33,
                0x27
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISyncMgrRegister
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x42,
                0xDF,
                0x95,
                0x62,
                0xEE,
                0x35,
                0xD1,
                0x11,
                0x87,
                0x07,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x33,
                0x27
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_SyncMgr
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x27,
                0xDF,
                0x95,
                0x62,
                0xEE,
                0x35,
                0xD1,
                0x11,
                0x87,
                0x07,
                0x00,
                0xC0,
                0x4F,
                0xD9,
                0x33,
                0x27
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}