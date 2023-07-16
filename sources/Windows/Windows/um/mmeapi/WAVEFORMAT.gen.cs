// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='WAVEFORMAT.xml' path='doc/member[@name="WAVEFORMAT"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct WAVEFORMAT
{
    /// <include file='WAVEFORMAT.xml' path='doc/member[@name="WAVEFORMAT.wFormatTag"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wFormatTag;
    /// <include file='WAVEFORMAT.xml' path='doc/member[@name="WAVEFORMAT.nChannels"]/*'/>
    [NativeTypeName("WORD")]
    public ushort nChannels;
    /// <include file='WAVEFORMAT.xml' path='doc/member[@name="WAVEFORMAT.nSamplesPerSec"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nSamplesPerSec;
    /// <include file='WAVEFORMAT.xml' path='doc/member[@name="WAVEFORMAT.nAvgBytesPerSec"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nAvgBytesPerSec;
    /// <include file='WAVEFORMAT.xml' path='doc/member[@name="WAVEFORMAT.nBlockAlign"]/*'/>
    [NativeTypeName("WORD")]
    public ushort nBlockAlign;
}