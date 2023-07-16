// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='MPEG1WAVEFORMAT.xml' path='doc/member[@name="MPEG1WAVEFORMAT"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MPEG1WAVEFORMAT
{
    /// <include file='MPEG1WAVEFORMAT.xml' path='doc/member[@name="MPEG1WAVEFORMAT.wfx"]/*'/>
    public WAVEFORMATEX wfx;
    /// <include file='MPEG1WAVEFORMAT.xml' path='doc/member[@name="MPEG1WAVEFORMAT.fwHeadLayer"]/*'/>
    [NativeTypeName("WORD")]
    public ushort fwHeadLayer;
    /// <include file='MPEG1WAVEFORMAT.xml' path='doc/member[@name="MPEG1WAVEFORMAT.dwHeadBitrate"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwHeadBitrate;
    /// <include file='MPEG1WAVEFORMAT.xml' path='doc/member[@name="MPEG1WAVEFORMAT.fwHeadMode"]/*'/>
    [NativeTypeName("WORD")]
    public ushort fwHeadMode;
    /// <include file='MPEG1WAVEFORMAT.xml' path='doc/member[@name="MPEG1WAVEFORMAT.fwHeadModeExt"]/*'/>
    [NativeTypeName("WORD")]
    public ushort fwHeadModeExt;
    /// <include file='MPEG1WAVEFORMAT.xml' path='doc/member[@name="MPEG1WAVEFORMAT.wHeadEmphasis"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wHeadEmphasis;
    /// <include file='MPEG1WAVEFORMAT.xml' path='doc/member[@name="MPEG1WAVEFORMAT.fwHeadFlags"]/*'/>
    [NativeTypeName("WORD")]
    public ushort fwHeadFlags;
    /// <include file='MPEG1WAVEFORMAT.xml' path='doc/member[@name="MPEG1WAVEFORMAT.dwPTSLow"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwPTSLow;
    /// <include file='MPEG1WAVEFORMAT.xml' path='doc/member[@name="MPEG1WAVEFORMAT.dwPTSHigh"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwPTSHigh;
}