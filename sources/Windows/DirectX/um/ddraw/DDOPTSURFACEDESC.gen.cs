// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.DirectX;
/// <include file='DDOPTSURFACEDESC.xml' path='doc/member[@name="DDOPTSURFACEDESC"]/*'/>
public partial struct DDOPTSURFACEDESC
{
    /// <include file='DDOPTSURFACEDESC.xml' path='doc/member[@name="DDOPTSURFACEDESC.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='DDOPTSURFACEDESC.xml' path='doc/member[@name="DDOPTSURFACEDESC.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='DDOPTSURFACEDESC.xml' path='doc/member[@name="DDOPTSURFACEDESC.ddSCaps"]/*'/>
    public DDSCAPS2 ddSCaps;
    /// <include file='DDOPTSURFACEDESC.xml' path='doc/member[@name="DDOPTSURFACEDESC.ddOSCaps"]/*'/>
    public DDOSCAPS ddOSCaps;
    /// <include file='DDOPTSURFACEDESC.xml' path='doc/member[@name="DDOPTSURFACEDESC.guid"]/*'/>
    public Guid guid;
    /// <include file='DDOPTSURFACEDESC.xml' path='doc/member[@name="DDOPTSURFACEDESC.dwCompressionRatio"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCompressionRatio;
}