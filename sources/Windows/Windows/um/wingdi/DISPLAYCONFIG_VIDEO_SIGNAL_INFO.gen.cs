// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='DISPLAYCONFIG_VIDEO_SIGNAL_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_SIGNAL_INFO"]/*'/>
public partial struct DISPLAYCONFIG_VIDEO_SIGNAL_INFO
{
    /// <include file='DISPLAYCONFIG_VIDEO_SIGNAL_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_SIGNAL_INFO.pixelRate"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong pixelRate;
    /// <include file='DISPLAYCONFIG_VIDEO_SIGNAL_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_SIGNAL_INFO.hSyncFreq"]/*'/>
    public DISPLAYCONFIG_RATIONAL hSyncFreq;
    /// <include file='DISPLAYCONFIG_VIDEO_SIGNAL_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_SIGNAL_INFO.vSyncFreq"]/*'/>
    public DISPLAYCONFIG_RATIONAL vSyncFreq;
    /// <include file='DISPLAYCONFIG_VIDEO_SIGNAL_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_SIGNAL_INFO.activeSize"]/*'/>
    public DISPLAYCONFIG_2DREGION activeSize;
    /// <include file='DISPLAYCONFIG_VIDEO_SIGNAL_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_SIGNAL_INFO.totalSize"]/*'/>
    public DISPLAYCONFIG_2DREGION totalSize;
    /// <include file='DISPLAYCONFIG_VIDEO_SIGNAL_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_SIGNAL_INFO.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_wingdi_L2854_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='DISPLAYCONFIG_VIDEO_SIGNAL_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_SIGNAL_INFO.scanLineOrdering"]/*'/>
    public DISPLAYCONFIG_SCANLINE_ORDERING scanLineOrdering;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.AdditionalSignalInfo"]/*'/>
    [UnscopedRef]
    public ref _Anonymous_e__Union._AdditionalSignalInfo_e__Struct AdditionalSignalInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.AdditionalSignalInfo;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.videoStandard"]/*'/>
    [UnscopedRef]
    public ref uint videoStandard
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.videoStandard;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.AdditionalSignalInfo"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_wingdi_L2856_C9")]
        public _AdditionalSignalInfo_e__Struct AdditionalSignalInfo;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.videoStandard"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("UINT32")]
        public uint videoStandard;
        /// <include file='_AdditionalSignalInfo_e__Struct.xml' path='doc/member[@name="_AdditionalSignalInfo_e__Struct"]/*'/>
        public partial struct _AdditionalSignalInfo_e__Struct
        {
            public uint _bitfield;
            /// <include file='_AdditionalSignalInfo_e__Struct.xml' path='doc/member[@name="_AdditionalSignalInfo_e__Struct.videoStandard"]/*'/>
            [NativeTypeName("UINT32 : 16")]
            public uint videoStandard
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

            /// <include file='_AdditionalSignalInfo_e__Struct.xml' path='doc/member[@name="_AdditionalSignalInfo_e__Struct.vSyncFreqDivider"]/*'/>
            [NativeTypeName("UINT32 : 6")]
            public uint vSyncFreqDivider
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 16) & 0x3Fu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x3Fu << 16)) | ((value & 0x3Fu) << 16);
                }
            }

            /// <include file='_AdditionalSignalInfo_e__Struct.xml' path='doc/member[@name="_AdditionalSignalInfo_e__Struct.reserved"]/*'/>
            [NativeTypeName("UINT32 : 10")]
            public uint reserved
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 22) & 0x3FFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x3FFu << 22)) | ((value & 0x3FFu) << 22);
                }
            }
        }
    }
}