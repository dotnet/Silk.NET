// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmsyscom.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='MMTIME.xml' path='doc/member[@name="MMTIME"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MMTIME
{
    /// <include file='MMTIME.xml' path='doc/member[@name="MMTIME.wType"]/*'/>
    public uint wType;
    /// <include file='MMTIME.xml' path='doc/member[@name="MMTIME.u"]/*'/>
    [NativeTypeName("__AnonymousRecord_mmsyscom_L110_C5")]
    public _u_e__Union u;
    /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public partial struct _u_e__Union
    {
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.ms"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint ms;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.sample"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint sample;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.cb"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint cb;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.ticks"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint ticks;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.smpte"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_mmsyscom_L118_C9")]
        public _smpte_e__Struct smpte;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.midi"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_mmsyscom_L132_C9")]
        public _midi_e__Struct midi;
        /// <include file='_smpte_e__Struct.xml' path='doc/member[@name="_smpte_e__Struct"]/*'/>
        public unsafe partial struct _smpte_e__Struct
        {
            /// <include file='_smpte_e__Struct.xml' path='doc/member[@name="_smpte_e__Struct.hour"]/*'/>
            public byte hour;
            /// <include file='_smpte_e__Struct.xml' path='doc/member[@name="_smpte_e__Struct.min"]/*'/>
            public byte min;
            /// <include file='_smpte_e__Struct.xml' path='doc/member[@name="_smpte_e__Struct.sec"]/*'/>
            public byte sec;
            /// <include file='_smpte_e__Struct.xml' path='doc/member[@name="_smpte_e__Struct.frame"]/*'/>
            public byte frame;
            /// <include file='_smpte_e__Struct.xml' path='doc/member[@name="_smpte_e__Struct.fps"]/*'/>
            public byte fps;
            /// <include file='_smpte_e__Struct.xml' path='doc/member[@name="_smpte_e__Struct.dummy"]/*'/>
            public byte dummy;
            /// <include file='_smpte_e__Struct.xml' path='doc/member[@name="_smpte_e__Struct.pad"]/*'/>
            [NativeTypeName("BYTE[2]")]
            public fixed byte pad[2];
        }

        /// <include file='_midi_e__Struct.xml' path='doc/member[@name="_midi_e__Struct"]/*'/>
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public partial struct _midi_e__Struct
        {
            /// <include file='_midi_e__Struct.xml' path='doc/member[@name="_midi_e__Struct.songptrpos"]/*'/>
            [NativeTypeName("DWORD")]
            public uint songptrpos;
        }
    }
}