// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='DEVICE_DSM_REPORT_ZONES_DATA.xml' path='doc/member[@name="DEVICE_DSM_REPORT_ZONES_DATA"]/*'/>
public partial struct DEVICE_DSM_REPORT_ZONES_DATA
{
    /// <include file='DEVICE_DSM_REPORT_ZONES_DATA.xml' path='doc/member[@name="DEVICE_DSM_REPORT_ZONES_DATA.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='DEVICE_DSM_REPORT_ZONES_DATA.xml' path='doc/member[@name="DEVICE_DSM_REPORT_ZONES_DATA.ZoneCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ZoneCount;
    /// <include file='DEVICE_DSM_REPORT_ZONES_DATA.xml' path='doc/member[@name="DEVICE_DSM_REPORT_ZONES_DATA.Attributes"]/*'/>
    public STORAGE_ZONES_ATTRIBUTES Attributes;
    /// <include file='DEVICE_DSM_REPORT_ZONES_DATA.xml' path='doc/member[@name="DEVICE_DSM_REPORT_ZONES_DATA.Reserved0"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Reserved0;
    /// <include file='DEVICE_DSM_REPORT_ZONES_DATA.xml' path='doc/member[@name="DEVICE_DSM_REPORT_ZONES_DATA.ZoneDescriptors"]/*'/>
    [NativeTypeName("STORAGE_ZONE_DESCRIPTOR[1]")]
    public _ZoneDescriptors_e__FixedBuffer ZoneDescriptors;
    /// <include file='_ZoneDescriptors_e__FixedBuffer.xml' path='doc/member[@name="_ZoneDescriptors_e__FixedBuffer"]/*'/>
    public partial struct _ZoneDescriptors_e__FixedBuffer
    {
        public STORAGE_ZONE_DESCRIPTOR e0;
        [UnscopedRef]
        public ref STORAGE_ZONE_DESCRIPTOR this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<STORAGE_ZONE_DESCRIPTOR> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}