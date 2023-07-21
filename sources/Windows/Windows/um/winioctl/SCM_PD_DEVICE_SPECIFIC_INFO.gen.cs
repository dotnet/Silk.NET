// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='SCM_PD_DEVICE_SPECIFIC_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_SPECIFIC_INFO"]/*' />
public partial struct SCM_PD_DEVICE_SPECIFIC_INFO
{
    /// <include file='SCM_PD_DEVICE_SPECIFIC_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_SPECIFIC_INFO.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='SCM_PD_DEVICE_SPECIFIC_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_SPECIFIC_INFO.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='SCM_PD_DEVICE_SPECIFIC_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_SPECIFIC_INFO.NumberOfProperties"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumberOfProperties;

    /// <include file='SCM_PD_DEVICE_SPECIFIC_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_SPECIFIC_INFO.DeviceSpecificProperties"]/*' />
    [NativeTypeName("SCM_PD_DEVICE_SPECIFIC_PROPERTY[1]")]
    public _DeviceSpecificProperties_e__FixedBuffer DeviceSpecificProperties;

    /// <include file='_DeviceSpecificProperties_e__FixedBuffer.xml' path='doc/member[@name="_DeviceSpecificProperties_e__FixedBuffer"]/*' />
    public partial struct _DeviceSpecificProperties_e__FixedBuffer
    {
        public SCM_PD_DEVICE_SPECIFIC_PROPERTY e0;

        [UnscopedRef]
        public ref SCM_PD_DEVICE_SPECIFIC_PROPERTY this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<SCM_PD_DEVICE_SPECIFIC_PROPERTY> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
