// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='LITEM.xml' path='doc/member[@name="LITEM"]/*'/>
public unsafe partial struct LITEM
{
    /// <include file='LITEM.xml' path='doc/member[@name="LITEM.mask"]/*'/>
    public uint mask;
    /// <include file='LITEM.xml' path='doc/member[@name="LITEM.iLink"]/*'/>
    public int iLink;
    /// <include file='LITEM.xml' path='doc/member[@name="LITEM.state"]/*'/>
    public uint state;
    /// <include file='LITEM.xml' path='doc/member[@name="LITEM.stateMask"]/*'/>
    public uint stateMask;
    /// <include file='LITEM.xml' path='doc/member[@name="LITEM.szID"]/*'/>
    [NativeTypeName("WCHAR[48]")]
    public fixed ushort szID[48];
    /// <include file='LITEM.xml' path='doc/member[@name="LITEM.szUrl"]/*'/>
    [NativeTypeName("WCHAR[2084]")]
    public fixed ushort szUrl[2084];
}