// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MEASUREITEMSTRUCT.xml' path='doc/member[@name="MEASUREITEMSTRUCT"]/*'/>
public partial struct MEASUREITEMSTRUCT
{
    /// <include file='MEASUREITEMSTRUCT.xml' path='doc/member[@name="MEASUREITEMSTRUCT.CtlType"]/*'/>
    public uint CtlType;
    /// <include file='MEASUREITEMSTRUCT.xml' path='doc/member[@name="MEASUREITEMSTRUCT.CtlID"]/*'/>
    public uint CtlID;
    /// <include file='MEASUREITEMSTRUCT.xml' path='doc/member[@name="MEASUREITEMSTRUCT.itemID"]/*'/>
    public uint itemID;
    /// <include file='MEASUREITEMSTRUCT.xml' path='doc/member[@name="MEASUREITEMSTRUCT.itemWidth"]/*'/>
    public uint itemWidth;
    /// <include file='MEASUREITEMSTRUCT.xml' path='doc/member[@name="MEASUREITEMSTRUCT.itemHeight"]/*'/>
    public uint itemHeight;
    /// <include file='MEASUREITEMSTRUCT.xml' path='doc/member[@name="MEASUREITEMSTRUCT.itemData"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint itemData;
}