// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='REGFILTER2.xml' path='doc/member[@name="REGFILTER2"]/*'/>
public unsafe partial struct REGFILTER2
{
    /// <include file='REGFILTER2.xml' path='doc/member[@name="REGFILTER2.dwVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVersion;
    /// <include file='REGFILTER2.xml' path='doc/member[@name="REGFILTER2.dwMerit"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMerit;
    /// <include file='REGFILTER2.xml' path='doc/member[@name="REGFILTER2.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_strmif_L5314_C36")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.cPins"]/*'/>
    [UnscopedRef]
    public ref uint cPins
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous1.cPins;
        }
    }

    /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.rgPins"]/*'/>
    [UnscopedRef]
    public ref REGFILTERPINS* rgPins
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous1.rgPins;
        }
    }

    /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.cPins2"]/*'/>
    [UnscopedRef]
    public ref uint cPins2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous2.cPins2;
        }
    }

    /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.rgPins2"]/*'/>
    [UnscopedRef]
    public ref REGFILTERPINS2* rgPins2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous2.rgPins2;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous1"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_strmif_L5316_C24")]
        public _Anonymous1_e__Struct Anonymous1;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous2"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_strmif_L5321_C24")]
        public _Anonymous2_e__Struct Anonymous2;
        /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct"]/*'/>
        public unsafe partial struct _Anonymous1_e__Struct
        {
            /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.cPins"]/*'/>
            [NativeTypeName("ULONG")]
            public uint cPins;
            /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.rgPins"]/*'/>
            [NativeTypeName("const REGFILTERPINS *")]
            public REGFILTERPINS* rgPins;
        }

        /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct"]/*'/>
        public unsafe partial struct _Anonymous2_e__Struct
        {
            /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.cPins2"]/*'/>
            [NativeTypeName("ULONG")]
            public uint cPins2;
            /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.rgPins2"]/*'/>
            [NativeTypeName("const REGFILTERPINS2 *")]
            public REGFILTERPINS2* rgPins2;
        }
    }
}