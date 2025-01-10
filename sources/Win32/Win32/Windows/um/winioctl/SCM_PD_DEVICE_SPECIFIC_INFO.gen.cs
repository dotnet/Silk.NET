// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SCM_PD_DEVICE_SPECIFIC_INFO
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Size;

    [NativeTypeName("DWORD")]
    public uint NumberOfProperties;

    [NativeTypeName("SCM_PD_DEVICE_SPECIFIC_PROPERTY[1]")]
    public _DeviceSpecificProperties_e__FixedBuffer DeviceSpecificProperties;

    public partial struct _DeviceSpecificProperties_e__FixedBuffer
    {
        public SCM_PD_DEVICE_SPECIFIC_PROPERTY e0;

        [UnscopedRef]
        public ref SCM_PD_DEVICE_SPECIFIC_PROPERTY this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<SCM_PD_DEVICE_SPECIFIC_PROPERTY> AsSpan(int length) =>
            MemoryMarshal.CreateSpan(ref e0, length);
    }
}
