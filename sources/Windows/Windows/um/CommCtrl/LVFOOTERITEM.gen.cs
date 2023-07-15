// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='LVFOOTERITEM.xml' path='doc/member[@name="LVFOOTERITEM"]/*'/>
public unsafe partial struct LVFOOTERITEM
{
    /// <include file='LVFOOTERITEM.xml' path='doc/member[@name="LVFOOTERITEM.mask"]/*'/>
    public uint mask;
    /// <include file='LVFOOTERITEM.xml' path='doc/member[@name="LVFOOTERITEM.iItem"]/*'/>
    public int iItem;
    /// <include file='LVFOOTERITEM.xml' path='doc/member[@name="LVFOOTERITEM.pszText"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszText;
    /// <include file='LVFOOTERITEM.xml' path='doc/member[@name="LVFOOTERITEM.cchTextMax"]/*'/>
    public int cchTextMax;
    /// <include file='LVFOOTERITEM.xml' path='doc/member[@name="LVFOOTERITEM.state"]/*'/>
    public uint state;
    /// <include file='LVFOOTERITEM.xml' path='doc/member[@name="LVFOOTERITEM.stateMask"]/*'/>
    public uint stateMask;
}