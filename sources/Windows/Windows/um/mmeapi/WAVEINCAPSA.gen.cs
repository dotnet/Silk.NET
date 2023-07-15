// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='WAVEINCAPSA.xml' path='doc/member[@name="WAVEINCAPSA"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct WAVEINCAPSA
{
    /// <include file='WAVEINCAPSA.xml' path='doc/member[@name="WAVEINCAPSA.wMid"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wMid;
    /// <include file='WAVEINCAPSA.xml' path='doc/member[@name="WAVEINCAPSA.wPid"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wPid;
    /// <include file='WAVEINCAPSA.xml' path='doc/member[@name="WAVEINCAPSA.vDriverVersion"]/*'/>
    [NativeTypeName("MMVERSION")]
    public uint vDriverVersion;
    /// <include file='WAVEINCAPSA.xml' path='doc/member[@name="WAVEINCAPSA.szPname"]/*'/>
    [NativeTypeName("CHAR[32]")]
    public fixed sbyte szPname[32];
    /// <include file='WAVEINCAPSA.xml' path='doc/member[@name="WAVEINCAPSA.dwFormats"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFormats;
    /// <include file='WAVEINCAPSA.xml' path='doc/member[@name="WAVEINCAPSA.wChannels"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wChannels;
    /// <include file='WAVEINCAPSA.xml' path='doc/member[@name="WAVEINCAPSA.wReserved1"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wReserved1;
}