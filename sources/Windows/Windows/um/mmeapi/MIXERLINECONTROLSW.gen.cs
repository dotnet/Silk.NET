// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='MIXERLINECONTROLSW.xml' path='doc/member[@name="MIXERLINECONTROLSW"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct MIXERLINECONTROLSW
{
    /// <include file='MIXERLINECONTROLSW.xml' path='doc/member[@name="MIXERLINECONTROLSW.cbStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    /// <include file='MIXERLINECONTROLSW.xml' path='doc/member[@name="MIXERLINECONTROLSW.dwLineID"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLineID;

    /// <include file='MIXERLINECONTROLSW.xml' path='doc/member[@name="MIXERLINECONTROLSW.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_mmeapi_L2234_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='MIXERLINECONTROLSW.xml' path='doc/member[@name="MIXERLINECONTROLSW.cControls"]/*' />
    [NativeTypeName("DWORD")]
    public uint cControls;

    /// <include file='MIXERLINECONTROLSW.xml' path='doc/member[@name="MIXERLINECONTROLSW.cbmxctrl"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbmxctrl;

    /// <include file='MIXERLINECONTROLSW.xml' path='doc/member[@name="MIXERLINECONTROLSW.pamxctrl"]/*' />
    [NativeTypeName("LPMIXERCONTROLW")]
    public MIXERCONTROLW* pamxctrl;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwControlID"]/*' />
    [UnscopedRef]
    public ref uint dwControlID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.dwControlID;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwControlType"]/*' />
    [UnscopedRef]
    public ref uint dwControlType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.dwControlType;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwControlID"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwControlID;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwControlType"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwControlType;
    }
}
