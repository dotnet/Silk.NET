// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='DISPLAYCONFIG_PATH_SOURCE_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_PATH_SOURCE_INFO"]/*'/>
public partial struct DISPLAYCONFIG_PATH_SOURCE_INFO
{
    /// <include file='DISPLAYCONFIG_PATH_SOURCE_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_PATH_SOURCE_INFO.adapterId"]/*'/>
    public LUID adapterId;
    /// <include file='DISPLAYCONFIG_PATH_SOURCE_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_PATH_SOURCE_INFO.id"]/*'/>
    [NativeTypeName("UINT32")]
    public uint id;
    /// <include file='DISPLAYCONFIG_PATH_SOURCE_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_PATH_SOURCE_INFO.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_wingdi_L2954_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='DISPLAYCONFIG_PATH_SOURCE_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_PATH_SOURCE_INFO.statusFlags"]/*'/>
    [NativeTypeName("UINT32")]
    public uint statusFlags;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.modeInfoIdx"]/*'/>
    [UnscopedRef]
    public ref uint modeInfoIdx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.modeInfoIdx;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.cloneGroupId"]/*'/>
    public uint cloneGroupId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.cloneGroupId;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.cloneGroupId = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.sourceModeInfoIdx"]/*'/>
    public uint sourceModeInfoIdx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.sourceModeInfoIdx;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.sourceModeInfoIdx = value;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.modeInfoIdx"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("UINT32")]
        public uint modeInfoIdx;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_wingdi_L2957_C9")]
        public _Anonymous_e__Struct Anonymous;
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*'/>
        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.cloneGroupId"]/*'/>
            [NativeTypeName("UINT32 : 16")]
            public uint cloneGroupId
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return _bitfield & 0xFFFFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~0xFFFFu) | (value & 0xFFFFu);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.sourceModeInfoIdx"]/*'/>
            [NativeTypeName("UINT32 : 16")]
            public uint sourceModeInfoIdx
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 16) & 0xFFFFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0xFFFFu << 16)) | ((value & 0xFFFFu) << 16);
                }
            }
        }
    }
}