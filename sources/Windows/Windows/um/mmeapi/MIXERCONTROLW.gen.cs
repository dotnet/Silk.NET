// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='MIXERCONTROLW.xml' path='doc/member[@name="MIXERCONTROLW"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct MIXERCONTROLW
{
    /// <include file='MIXERCONTROLW.xml' path='doc/member[@name="MIXERCONTROLW.cbStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    /// <include file='MIXERCONTROLW.xml' path='doc/member[@name="MIXERCONTROLW.dwControlID"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwControlID;

    /// <include file='MIXERCONTROLW.xml' path='doc/member[@name="MIXERCONTROLW.dwControlType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwControlType;

    /// <include file='MIXERCONTROLW.xml' path='doc/member[@name="MIXERCONTROLW.fdwControl"]/*' />
    [NativeTypeName("DWORD")]
    public uint fdwControl;

    /// <include file='MIXERCONTROLW.xml' path='doc/member[@name="MIXERCONTROLW.cMultipleItems"]/*' />
    [NativeTypeName("DWORD")]
    public uint cMultipleItems;

    /// <include file='MIXERCONTROLW.xml' path='doc/member[@name="MIXERCONTROLW.szShortName"]/*' />
    [NativeTypeName("WCHAR[16]")]
    public fixed ushort szShortName[16];

    /// <include file='MIXERCONTROLW.xml' path='doc/member[@name="MIXERCONTROLW.szName"]/*' />
    [NativeTypeName("WCHAR[64]")]
    public fixed ushort szName[64];

    /// <include file='MIXERCONTROLW.xml' path='doc/member[@name="MIXERCONTROLW.Bounds"]/*' />
    [NativeTypeName("__AnonymousRecord_mmeapi_L2081_C5")]
    public _Bounds_e__Union Bounds;

    /// <include file='MIXERCONTROLW.xml' path='doc/member[@name="MIXERCONTROLW.Metrics"]/*' />
    [NativeTypeName("__AnonymousRecord_mmeapi_L2092_C5")]
    public _Metrics_e__Union Metrics;

    /// <include file='_Bounds_e__Union.xml' path='doc/member[@name="_Bounds_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public unsafe partial struct _Bounds_e__Union
    {
        /// <include file='_Bounds_e__Union.xml' path='doc/member[@name="_Bounds_e__Union.Anonymous1"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_mmeapi_L2082_C9")]
        public _Anonymous1_e__Struct Anonymous1;

        /// <include file='_Bounds_e__Union.xml' path='doc/member[@name="_Bounds_e__Union.Anonymous2"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_mmeapi_L2086_C9")]
        public _Anonymous2_e__Struct Anonymous2;

        /// <include file='_Bounds_e__Union.xml' path='doc/member[@name="_Bounds_e__Union.dwReserved"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD[6]")]
        public fixed uint dwReserved[6];

        /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.lMinimum"]/*' />
        [UnscopedRef]
        public ref int lMinimum
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.lMinimum;
            }
        }

        /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.lMaximum"]/*' />
        [UnscopedRef]
        public ref int lMaximum
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.lMaximum;
            }
        }

        /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.dwMinimum"]/*' />
        [UnscopedRef]
        public ref uint dwMinimum
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.dwMinimum;
            }
        }

        /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.dwMaximum"]/*' />
        [UnscopedRef]
        public ref uint dwMaximum
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.dwMaximum;
            }
        }

        /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct"]/*' />
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public partial struct _Anonymous1_e__Struct
        {
            /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.lMinimum"]/*' />
            [NativeTypeName("LONG")]
            public int lMinimum;

            /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.lMaximum"]/*' />
            [NativeTypeName("LONG")]
            public int lMaximum;
        }

        /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct"]/*' />
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public partial struct _Anonymous2_e__Struct
        {
            /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.dwMinimum"]/*' />
            [NativeTypeName("DWORD")]
            public uint dwMinimum;

            /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.dwMaximum"]/*' />
            [NativeTypeName("DWORD")]
            public uint dwMaximum;
        }
    }

    /// <include file='_Metrics_e__Union.xml' path='doc/member[@name="_Metrics_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public unsafe partial struct _Metrics_e__Union
    {
        /// <include file='_Metrics_e__Union.xml' path='doc/member[@name="_Metrics_e__Union.cSteps"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint cSteps;

        /// <include file='_Metrics_e__Union.xml' path='doc/member[@name="_Metrics_e__Union.cbCustomData"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint cbCustomData;

        /// <include file='_Metrics_e__Union.xml' path='doc/member[@name="_Metrics_e__Union.dwReserved"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD[6]")]
        public fixed uint dwReserved[6];
    }
}
