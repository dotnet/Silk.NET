// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='BOOT_AREA_INFO.xml' path='doc/member[@name="BOOT_AREA_INFO"]/*'/>
public partial struct BOOT_AREA_INFO
{
    /// <include file='BOOT_AREA_INFO.xml' path='doc/member[@name="BOOT_AREA_INFO.BootSectorCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BootSectorCount;
    /// <include file='BOOT_AREA_INFO.xml' path='doc/member[@name="BOOT_AREA_INFO.BootSectors"]/*'/>
    [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um/winioctl.h:13690:5)[2]")]
    public _BootSectors_e__FixedBuffer BootSectors;
    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*'/>
    public partial struct _Anonymous_e__Struct
    {
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Offset"]/*'/>
        public LARGE_INTEGER Offset;
    }

    /// <include file='_BootSectors_e__FixedBuffer.xml' path='doc/member[@name="_BootSectors_e__FixedBuffer"]/*'/>
    public partial struct _BootSectors_e__FixedBuffer
    {
        public _Anonymous_e__Struct e0;
        public _Anonymous_e__Struct e1;
        [UnscopedRef]
        public ref _Anonymous_e__Struct this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<_Anonymous_e__Struct> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 2);
    }
}