// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DISPLAYCONFIG_VIDEO_SIGNAL_INFO
{
    [NativeTypeName("UINT64")]
    public ulong pixelRate;
    public DISPLAYCONFIG_RATIONAL hSyncFreq;
    public DISPLAYCONFIG_RATIONAL vSyncFreq;
    public DISPLAYCONFIG_2DREGION activeSize;
    public DISPLAYCONFIG_2DREGION totalSize;

    [NativeTypeName("__AnonymousRecord_wingdi_L2854_C5")]
    public _Anonymous_e__Union Anonymous;
    public DISPLAYCONFIG_SCANLINE_ORDERING scanLineOrdering;

    [UnscopedRef]
    public ref _Anonymous_e__Union._AdditionalSignalInfo_e__Struct AdditionalSignalInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.AdditionalSignalInfo; }
    }

    [UnscopedRef]
    public ref uint videoStandard
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.videoStandard; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_wingdi_L2856_C9")]
        public _AdditionalSignalInfo_e__Struct AdditionalSignalInfo;

        [FieldOffset(0)]
        [NativeTypeName("UINT32")]
        public uint videoStandard;

        public partial struct _AdditionalSignalInfo_e__Struct
        {
            public uint _bitfield;

            [NativeTypeName("UINT32 : 16")]
            public uint videoStandard
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return _bitfield & 0xFFFFu; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~0xFFFFu) | (value & 0xFFFFu); }
            }

            [NativeTypeName("UINT32 : 6")]
            public uint vSyncFreqDivider
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 16) & 0x3Fu; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x3Fu << 16)) | ((value & 0x3Fu) << 16); }
            }

            [NativeTypeName("UINT32 : 10")]
            public uint reserved
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 22) & 0x3FFu; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0x3FFu << 22)) | ((value & 0x3FFu) << 22); }
            }
        }
    }
}
