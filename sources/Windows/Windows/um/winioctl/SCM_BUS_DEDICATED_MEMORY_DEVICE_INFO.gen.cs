// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;
/// <include file='SCM_BUS_DEDICATED_MEMORY_DEVICE_INFO.xml' path='doc/member[@name="SCM_BUS_DEDICATED_MEMORY_DEVICE_INFO"]/*'/>
public partial struct SCM_BUS_DEDICATED_MEMORY_DEVICE_INFO
{
    /// <include file='SCM_BUS_DEDICATED_MEMORY_DEVICE_INFO.xml' path='doc/member[@name="SCM_BUS_DEDICATED_MEMORY_DEVICE_INFO.DeviceGuid"]/*'/>
    public Guid DeviceGuid;
    /// <include file='SCM_BUS_DEDICATED_MEMORY_DEVICE_INFO.xml' path='doc/member[@name="SCM_BUS_DEDICATED_MEMORY_DEVICE_INFO.DeviceNumber"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DeviceNumber;
    /// <include file='SCM_BUS_DEDICATED_MEMORY_DEVICE_INFO.xml' path='doc/member[@name="SCM_BUS_DEDICATED_MEMORY_DEVICE_INFO.Flags"]/*'/>
    [NativeTypeName("__AnonymousRecord_winioctl_L7273_C5")]
    public _Flags_e__Struct Flags;
    /// <include file='SCM_BUS_DEDICATED_MEMORY_DEVICE_INFO.xml' path='doc/member[@name="SCM_BUS_DEDICATED_MEMORY_DEVICE_INFO.DeviceSize"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong DeviceSize;
    /// <include file='_Flags_e__Struct.xml' path='doc/member[@name="_Flags_e__Struct"]/*'/>
    public partial struct _Flags_e__Struct
    {
        public uint _bitfield;
        /// <include file='_Flags_e__Struct.xml' path='doc/member[@name="_Flags_e__Struct.ForcedByRegistry"]/*'/>
        [NativeTypeName("DWORD : 1")]
        public uint ForcedByRegistry
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
            }
        }

        /// <include file='_Flags_e__Struct.xml' path='doc/member[@name="_Flags_e__Struct.Initialized"]/*'/>
        [NativeTypeName("DWORD : 1")]
        public uint Initialized
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 1) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
            }
        }

        /// <include file='_Flags_e__Struct.xml' path='doc/member[@name="_Flags_e__Struct.Reserved"]/*'/>
        [NativeTypeName("DWORD : 30")]
        public uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 2) & 0x3FFFFFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x3FFFFFFFu << 2)) | ((value & 0x3FFFFFFFu) << 2);
            }
        }
    }
}