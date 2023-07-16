// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='TRUESPEECHWAVEFORMAT.xml' path='doc/member[@name="TRUESPEECHWAVEFORMAT"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct TRUESPEECHWAVEFORMAT
{
    /// <include file='TRUESPEECHWAVEFORMAT.xml' path='doc/member[@name="TRUESPEECHWAVEFORMAT.wfx"]/*'/>
    public WAVEFORMATEX wfx;
    /// <include file='TRUESPEECHWAVEFORMAT.xml' path='doc/member[@name="TRUESPEECHWAVEFORMAT.wRevision"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wRevision;
    /// <include file='TRUESPEECHWAVEFORMAT.xml' path='doc/member[@name="TRUESPEECHWAVEFORMAT.nSamplesPerBlock"]/*'/>
    [NativeTypeName("WORD")]
    public ushort nSamplesPerBlock;
    /// <include file='TRUESPEECHWAVEFORMAT.xml' path='doc/member[@name="TRUESPEECHWAVEFORMAT.abReserved"]/*'/>
    [NativeTypeName("BYTE[28]")]
    public fixed byte abReserved[28];
}