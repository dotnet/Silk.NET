// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace Silk.NET.Windows;

/// <include file='STORAGE_HW_ENDURANCE_INFO.xml' path='doc/member[@name="STORAGE_HW_ENDURANCE_INFO"]/*' />
public unsafe partial struct STORAGE_HW_ENDURANCE_INFO
{
    /// <include file='STORAGE_HW_ENDURANCE_INFO.xml' path='doc/member[@name="STORAGE_HW_ENDURANCE_INFO.ValidFields"]/*' />
    [NativeTypeName("DWORD")]
    public uint ValidFields;

    /// <include file='STORAGE_HW_ENDURANCE_INFO.xml' path='doc/member[@name="STORAGE_HW_ENDURANCE_INFO.GroupId"]/*' />
    [NativeTypeName("DWORD")]
    public uint GroupId;

    /// <include file='STORAGE_HW_ENDURANCE_INFO.xml' path='doc/member[@name="STORAGE_HW_ENDURANCE_INFO.Flags"]/*' />
    [NativeTypeName("__AnonymousRecord_winioctl_L2959_C5")]
    public _Flags_e__Struct Flags;

    /// <include file='STORAGE_HW_ENDURANCE_INFO.xml' path='doc/member[@name="STORAGE_HW_ENDURANCE_INFO.LifePercentage"]/*' />
    [NativeTypeName("DWORD")]
    public uint LifePercentage;

    /// <include file='STORAGE_HW_ENDURANCE_INFO.xml' path='doc/member[@name="STORAGE_HW_ENDURANCE_INFO.BytesReadCount"]/*' />
    [NativeTypeName("BYTE[16]")]
    public fixed byte BytesReadCount[16];

    /// <include file='STORAGE_HW_ENDURANCE_INFO.xml' path='doc/member[@name="STORAGE_HW_ENDURANCE_INFO.ByteWriteCount"]/*' />
    [NativeTypeName("BYTE[16]")]
    public fixed byte ByteWriteCount[16];

    /// <include file='_Flags_e__Struct.xml' path='doc/member[@name="_Flags_e__Struct"]/*' />
    public partial struct _Flags_e__Struct
    {
        public uint _bitfield;

        /// <include file='_Flags_e__Struct.xml' path='doc/member[@name="_Flags_e__Struct.Shared"]/*' />
        [NativeTypeName("DWORD : 1")]
        public uint Shared
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

        /// <include file='_Flags_e__Struct.xml' path='doc/member[@name="_Flags_e__Struct.Reserved"]/*' />
        [NativeTypeName("DWORD : 31")]
        public uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 1) & 0x7FFFFFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x7FFFFFFFu << 1)) | ((value & 0x7FFFFFFFu) << 1);
            }
        }
    }
}
