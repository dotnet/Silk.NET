// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='COMPAREITEMSTRUCT.xml' path='doc/member[@name="COMPAREITEMSTRUCT"]/*' />
public partial struct COMPAREITEMSTRUCT
{
    /// <include file='COMPAREITEMSTRUCT.xml' path='doc/member[@name="COMPAREITEMSTRUCT.CtlType"]/*' />
    public uint CtlType;

    /// <include file='COMPAREITEMSTRUCT.xml' path='doc/member[@name="COMPAREITEMSTRUCT.CtlID"]/*' />
    public uint CtlID;

    /// <include file='COMPAREITEMSTRUCT.xml' path='doc/member[@name="COMPAREITEMSTRUCT.hwndItem"]/*' />
    public HWND hwndItem;

    /// <include file='COMPAREITEMSTRUCT.xml' path='doc/member[@name="COMPAREITEMSTRUCT.itemID1"]/*' />
    public uint itemID1;

    /// <include file='COMPAREITEMSTRUCT.xml' path='doc/member[@name="COMPAREITEMSTRUCT.itemData1"]/*' />
    [NativeTypeName("ULONG_PTR")]
    public nuint itemData1;

    /// <include file='COMPAREITEMSTRUCT.xml' path='doc/member[@name="COMPAREITEMSTRUCT.itemID2"]/*' />
    public uint itemID2;

    /// <include file='COMPAREITEMSTRUCT.xml' path='doc/member[@name="COMPAREITEMSTRUCT.itemData2"]/*' />
    [NativeTypeName("ULONG_PTR")]
    public nuint itemData2;

    /// <include file='COMPAREITEMSTRUCT.xml' path='doc/member[@name="COMPAREITEMSTRUCT.dwLocaleId"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLocaleId;
}
