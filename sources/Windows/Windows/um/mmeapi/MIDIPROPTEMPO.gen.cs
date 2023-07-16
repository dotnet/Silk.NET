// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='MIDIPROPTEMPO.xml' path='doc/member[@name="MIDIPROPTEMPO"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MIDIPROPTEMPO
{
    /// <include file='MIDIPROPTEMPO.xml' path='doc/member[@name="MIDIPROPTEMPO.cbStruct"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbStruct;
    /// <include file='MIDIPROPTEMPO.xml' path='doc/member[@name="MIDIPROPTEMPO.dwTempo"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwTempo;
}