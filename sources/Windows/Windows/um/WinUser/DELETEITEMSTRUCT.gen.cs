// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DELETEITEMSTRUCT.xml' path='doc/member[@name="DELETEITEMSTRUCT"]/*'/>
public partial struct DELETEITEMSTRUCT
{
    /// <include file='DELETEITEMSTRUCT.xml' path='doc/member[@name="DELETEITEMSTRUCT.CtlType"]/*'/>
    public uint CtlType;
    /// <include file='DELETEITEMSTRUCT.xml' path='doc/member[@name="DELETEITEMSTRUCT.CtlID"]/*'/>
    public uint CtlID;
    /// <include file='DELETEITEMSTRUCT.xml' path='doc/member[@name="DELETEITEMSTRUCT.itemID"]/*'/>
    public uint itemID;
    /// <include file='DELETEITEMSTRUCT.xml' path='doc/member[@name="DELETEITEMSTRUCT.hwndItem"]/*'/>
    public HWND hwndItem;
    /// <include file='DELETEITEMSTRUCT.xml' path='doc/member[@name="DELETEITEMSTRUCT.itemData"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint itemData;
}