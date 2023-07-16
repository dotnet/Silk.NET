// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='WAVEFORMATEX.xml' path='doc/member[@name="WAVEFORMATEX"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct WAVEFORMATEX
{
    /// <include file='WAVEFORMATEX.xml' path='doc/member[@name="WAVEFORMATEX.wFormatTag"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wFormatTag;
    /// <include file='WAVEFORMATEX.xml' path='doc/member[@name="WAVEFORMATEX.nChannels"]/*'/>
    [NativeTypeName("WORD")]
    public ushort nChannels;
    /// <include file='WAVEFORMATEX.xml' path='doc/member[@name="WAVEFORMATEX.nSamplesPerSec"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nSamplesPerSec;
    /// <include file='WAVEFORMATEX.xml' path='doc/member[@name="WAVEFORMATEX.nAvgBytesPerSec"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nAvgBytesPerSec;
    /// <include file='WAVEFORMATEX.xml' path='doc/member[@name="WAVEFORMATEX.nBlockAlign"]/*'/>
    [NativeTypeName("WORD")]
    public ushort nBlockAlign;
    /// <include file='WAVEFORMATEX.xml' path='doc/member[@name="WAVEFORMATEX.wBitsPerSample"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wBitsPerSample;
    /// <include file='WAVEFORMATEX.xml' path='doc/member[@name="WAVEFORMATEX.cbSize"]/*'/>
    [NativeTypeName("WORD")]
    public ushort cbSize;
}