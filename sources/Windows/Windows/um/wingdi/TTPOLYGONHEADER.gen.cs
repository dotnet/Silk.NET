// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TTPOLYGONHEADER.xml' path='doc/member[@name="TTPOLYGONHEADER"]/*'/>
public partial struct TTPOLYGONHEADER
{
    /// <include file='TTPOLYGONHEADER.xml' path='doc/member[@name="TTPOLYGONHEADER.cb"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cb;
    /// <include file='TTPOLYGONHEADER.xml' path='doc/member[@name="TTPOLYGONHEADER.dwType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwType;
    /// <include file='TTPOLYGONHEADER.xml' path='doc/member[@name="TTPOLYGONHEADER.pfxStart"]/*'/>
    public POINTFX pfxStart;
}