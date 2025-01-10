// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MIXERLINEA
{
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    [NativeTypeName("DWORD")]
    public uint dwDestination;

    [NativeTypeName("DWORD")]
    public uint dwSource;

    [NativeTypeName("DWORD")]
    public uint dwLineID;

    [NativeTypeName("DWORD")]
    public uint fdwLine;

    [NativeTypeName("DWORD_PTR")]
    public nuint dwUser;

    [NativeTypeName("DWORD")]
    public uint dwComponentType;

    [NativeTypeName("DWORD")]
    public uint cChannels;

    [NativeTypeName("DWORD")]
    public uint cConnections;

    [NativeTypeName("DWORD")]
    public uint cControls;

    [NativeTypeName("CHAR[16]")]
    public _szShortName_e__FixedBuffer szShortName;

    [NativeTypeName("CHAR[64]")]
    public _szName_e__FixedBuffer szName;

    [NativeTypeName("__AnonymousRecord_mmeapi_L1879_C5")]
    public _Target_e__Struct Target;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _Target_e__Struct
    {
        [NativeTypeName("DWORD")]
        public uint dwType;

        [NativeTypeName("DWORD")]
        public uint dwDeviceID;

        [NativeTypeName("WORD")]
        public ushort wMid;

        [NativeTypeName("WORD")]
        public ushort wPid;

        [NativeTypeName("MMVERSION")]
        public uint vDriverVersion;

        [NativeTypeName("CHAR[32]")]
        public _szPname_e__FixedBuffer szPname;

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        [InlineArray(32)]
        public partial struct _szPname_e__FixedBuffer
        {
            public sbyte e0;
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(16)]
    public partial struct _szShortName_e__FixedBuffer
    {
        public sbyte e0;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(64)]
    public partial struct _szName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
