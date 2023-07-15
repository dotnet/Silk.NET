// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/HLink.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='HLBWINFO.xml' path='doc/member[@name="HLBWINFO"]/*'/>
public partial struct HLBWINFO
{
    /// <include file='HLBWINFO.xml' path='doc/member[@name="HLBWINFO.cbSize"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cbSize;
    /// <include file='HLBWINFO.xml' path='doc/member[@name="HLBWINFO.grfHLBWIF"]/*'/>
    [NativeTypeName("DWORD")]
    public uint grfHLBWIF;
    /// <include file='HLBWINFO.xml' path='doc/member[@name="HLBWINFO.rcFramePos"]/*'/>
    public RECT rcFramePos;
    /// <include file='HLBWINFO.xml' path='doc/member[@name="HLBWINFO.rcDocPos"]/*'/>
    public RECT rcDocPos;
    /// <include file='HLBWINFO.xml' path='doc/member[@name="HLBWINFO.hltbinfo"]/*'/>
    public HLTBINFO hltbinfo;
}