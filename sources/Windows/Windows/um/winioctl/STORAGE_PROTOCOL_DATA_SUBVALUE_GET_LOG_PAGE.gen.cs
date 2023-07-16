// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='STORAGE_PROTOCOL_DATA_SUBVALUE_GET_LOG_PAGE.xml' path='doc/member[@name="STORAGE_PROTOCOL_DATA_SUBVALUE_GET_LOG_PAGE"]/*'/>
[StructLayout(LayoutKind.Explicit)]
public partial struct STORAGE_PROTOCOL_DATA_SUBVALUE_GET_LOG_PAGE
{
    /// <include file='STORAGE_PROTOCOL_DATA_SUBVALUE_GET_LOG_PAGE.xml' path='doc/member[@name="STORAGE_PROTOCOL_DATA_SUBVALUE_GET_LOG_PAGE.Anonymous"]/*'/>
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winioctl_L2183_C5")]
    public _Anonymous_e__Struct Anonymous;
    /// <include file='STORAGE_PROTOCOL_DATA_SUBVALUE_GET_LOG_PAGE.xml' path='doc/member[@name="STORAGE_PROTOCOL_DATA_SUBVALUE_GET_LOG_PAGE.AsUlong"]/*'/>
    [FieldOffset(0)]
    [NativeTypeName("DWORD")]
    public uint AsUlong;
    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.RetainAsynEvent"]/*'/>
    public uint RetainAsynEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.RetainAsynEvent;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.RetainAsynEvent = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.LogSpecificField"]/*'/>
    public uint LogSpecificField
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.LogSpecificField;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.LogSpecificField = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved"]/*'/>
    public uint Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Reserved;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Reserved = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*'/>
    public partial struct _Anonymous_e__Struct
    {
        public uint _bitfield;
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.RetainAsynEvent"]/*'/>
        [NativeTypeName("DWORD : 1")]
        public uint RetainAsynEvent
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

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.LogSpecificField"]/*'/>
        [NativeTypeName("DWORD : 4")]
        public uint LogSpecificField
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 1) & 0xFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0xFu << 1)) | ((value & 0xFu) << 1);
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved"]/*'/>
        [NativeTypeName("DWORD : 27")]
        public uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 5) & 0x7FFFFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x7FFFFFFu << 5)) | ((value & 0x7FFFFFFu) << 5);
            }
        }
    }
}