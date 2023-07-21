// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='TIMECODE.xml' path='doc/member[@name="TIMECODE"]/*' />
[StructLayout(LayoutKind.Explicit)]
public partial struct TIMECODE
{
    /// <include file='TIMECODE.xml' path='doc/member[@name="TIMECODE.Anonymous"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_strmif_L14218_C4")]
    public _Anonymous_e__Struct Anonymous;

    /// <include file='TIMECODE.xml' path='doc/member[@name="TIMECODE.qw"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("DWORDLONG")]
    public ulong qw;

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.wFrameRate"]/*' />
    [UnscopedRef]
    public ref ushort wFrameRate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.wFrameRate;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.wFrameFract"]/*' />
    [UnscopedRef]
    public ref ushort wFrameFract
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.wFrameFract;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.dwFrames"]/*' />
    [UnscopedRef]
    public ref uint dwFrames
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.dwFrames;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
    public partial struct _Anonymous_e__Struct
    {
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.wFrameRate"]/*' />
        [NativeTypeName("WORD")]
        public ushort wFrameRate;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.wFrameFract"]/*' />
        [NativeTypeName("WORD")]
        public ushort wFrameFract;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.dwFrames"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwFrames;
    }
}
