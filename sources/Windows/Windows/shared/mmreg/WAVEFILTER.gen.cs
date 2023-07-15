// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='WAVEFILTER.xml' path='doc/member[@name="WAVEFILTER"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct WAVEFILTER
{
    /// <include file='WAVEFILTER.xml' path='doc/member[@name="WAVEFILTER.cbStruct"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbStruct;
    /// <include file='WAVEFILTER.xml' path='doc/member[@name="WAVEFILTER.dwFilterTag"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFilterTag;
    /// <include file='WAVEFILTER.xml' path='doc/member[@name="WAVEFILTER.fdwFilter"]/*'/>
    [NativeTypeName("DWORD")]
    public uint fdwFilter;
    /// <include file='WAVEFILTER.xml' path='doc/member[@name="WAVEFILTER.dwReserved"]/*'/>
    [NativeTypeName("DWORD[5]")]
    public fixed uint dwReserved[5];
}