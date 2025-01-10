// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SCM_LOGICAL_DEVICES
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Size;

    [NativeTypeName("DWORD")]
    public uint DeviceCount;

    [NativeTypeName("SCM_LOGICAL_DEVICE_INSTANCE[1]")]
    public _Devices_e__FixedBuffer Devices;

    public partial struct _Devices_e__FixedBuffer
    {
        public SCM_LOGICAL_DEVICE_INSTANCE e0;

        [UnscopedRef]
        public ref SCM_LOGICAL_DEVICE_INSTANCE this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<SCM_LOGICAL_DEVICE_INSTANCE> AsSpan(int length) =>
            MemoryMarshal.CreateSpan(ref e0, length);
    }
}
