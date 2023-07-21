// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='MIXERLINEA.xml' path='doc/member[@name="MIXERLINEA"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct MIXERLINEA
{
    /// <include file='MIXERLINEA.xml' path='doc/member[@name="MIXERLINEA.cbStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    /// <include file='MIXERLINEA.xml' path='doc/member[@name="MIXERLINEA.dwDestination"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDestination;

    /// <include file='MIXERLINEA.xml' path='doc/member[@name="MIXERLINEA.dwSource"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSource;

    /// <include file='MIXERLINEA.xml' path='doc/member[@name="MIXERLINEA.dwLineID"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLineID;

    /// <include file='MIXERLINEA.xml' path='doc/member[@name="MIXERLINEA.fdwLine"]/*' />
    [NativeTypeName("DWORD")]
    public uint fdwLine;

    /// <include file='MIXERLINEA.xml' path='doc/member[@name="MIXERLINEA.dwUser"]/*' />
    [NativeTypeName("DWORD_PTR")]
    public nuint dwUser;

    /// <include file='MIXERLINEA.xml' path='doc/member[@name="MIXERLINEA.dwComponentType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwComponentType;

    /// <include file='MIXERLINEA.xml' path='doc/member[@name="MIXERLINEA.cChannels"]/*' />
    [NativeTypeName("DWORD")]
    public uint cChannels;

    /// <include file='MIXERLINEA.xml' path='doc/member[@name="MIXERLINEA.cConnections"]/*' />
    [NativeTypeName("DWORD")]
    public uint cConnections;

    /// <include file='MIXERLINEA.xml' path='doc/member[@name="MIXERLINEA.cControls"]/*' />
    [NativeTypeName("DWORD")]
    public uint cControls;

    /// <include file='MIXERLINEA.xml' path='doc/member[@name="MIXERLINEA.szShortName"]/*' />
    [NativeTypeName("CHAR[16]")]
    public fixed sbyte szShortName[16];

    /// <include file='MIXERLINEA.xml' path='doc/member[@name="MIXERLINEA.szName"]/*' />
    [NativeTypeName("CHAR[64]")]
    public fixed sbyte szName[64];

    /// <include file='MIXERLINEA.xml' path='doc/member[@name="MIXERLINEA.Target"]/*' />
    [NativeTypeName("__AnonymousRecord_mmeapi_L1879_C5")]
    public _Target_e__Struct Target;

    /// <include file='_Target_e__Struct.xml' path='doc/member[@name="_Target_e__Struct"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct _Target_e__Struct
    {
        /// <include file='_Target_e__Struct.xml' path='doc/member[@name="_Target_e__Struct.dwType"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwType;

        /// <include file='_Target_e__Struct.xml' path='doc/member[@name="_Target_e__Struct.dwDeviceID"]/*' />
        [NativeTypeName("DWORD")]
        public uint dwDeviceID;

        /// <include file='_Target_e__Struct.xml' path='doc/member[@name="_Target_e__Struct.wMid"]/*' />
        [NativeTypeName("WORD")]
        public ushort wMid;

        /// <include file='_Target_e__Struct.xml' path='doc/member[@name="_Target_e__Struct.wPid"]/*' />
        [NativeTypeName("WORD")]
        public ushort wPid;

        /// <include file='_Target_e__Struct.xml' path='doc/member[@name="_Target_e__Struct.vDriverVersion"]/*' />
        [NativeTypeName("MMVERSION")]
        public uint vDriverVersion;

        /// <include file='_Target_e__Struct.xml' path='doc/member[@name="_Target_e__Struct.szPname"]/*' />
        [NativeTypeName("CHAR[32]")]
        public fixed sbyte szPname[32];
    }
}
