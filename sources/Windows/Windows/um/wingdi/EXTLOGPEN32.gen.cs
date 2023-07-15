// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EXTLOGPEN32.xml' path='doc/member[@name="EXTLOGPEN32"]/*'/>
public unsafe partial struct EXTLOGPEN32
{
    /// <include file='EXTLOGPEN32.xml' path='doc/member[@name="EXTLOGPEN32.elpPenStyle"]/*'/>
    [NativeTypeName("DWORD")]
    public uint elpPenStyle;
    /// <include file='EXTLOGPEN32.xml' path='doc/member[@name="EXTLOGPEN32.elpWidth"]/*'/>
    [NativeTypeName("DWORD")]
    public uint elpWidth;
    /// <include file='EXTLOGPEN32.xml' path='doc/member[@name="EXTLOGPEN32.elpBrushStyle"]/*'/>
    public uint elpBrushStyle;
    /// <include file='EXTLOGPEN32.xml' path='doc/member[@name="EXTLOGPEN32.elpColor"]/*'/>
    public COLORREF elpColor;
    /// <include file='EXTLOGPEN32.xml' path='doc/member[@name="EXTLOGPEN32.elpHatch"]/*'/>
    [NativeTypeName("ULONG")]
    public uint elpHatch;
    /// <include file='EXTLOGPEN32.xml' path='doc/member[@name="EXTLOGPEN32.elpNumEntries"]/*'/>
    [NativeTypeName("DWORD")]
    public uint elpNumEntries;
    /// <include file='EXTLOGPEN32.xml' path='doc/member[@name="EXTLOGPEN32.elpStyleEntry"]/*'/>
    [NativeTypeName("DWORD[1]")]
    public fixed uint elpStyleEntry[1];
}