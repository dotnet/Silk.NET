// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MENUITEMINFOA.xml' path='doc/member[@name="MENUITEMINFOA"]/*'/>
public unsafe partial struct MENUITEMINFOA
{
    /// <include file='MENUITEMINFOA.xml' path='doc/member[@name="MENUITEMINFOA.cbSize"]/*'/>
    public uint cbSize;
    /// <include file='MENUITEMINFOA.xml' path='doc/member[@name="MENUITEMINFOA.fMask"]/*'/>
    public uint fMask;
    /// <include file='MENUITEMINFOA.xml' path='doc/member[@name="MENUITEMINFOA.fType"]/*'/>
    public uint fType;
    /// <include file='MENUITEMINFOA.xml' path='doc/member[@name="MENUITEMINFOA.fState"]/*'/>
    public uint fState;
    /// <include file='MENUITEMINFOA.xml' path='doc/member[@name="MENUITEMINFOA.wID"]/*'/>
    public uint wID;
    /// <include file='MENUITEMINFOA.xml' path='doc/member[@name="MENUITEMINFOA.hSubMenu"]/*'/>
    public HMENU hSubMenu;
    /// <include file='MENUITEMINFOA.xml' path='doc/member[@name="MENUITEMINFOA.hbmpChecked"]/*'/>
    public HBITMAP hbmpChecked;
    /// <include file='MENUITEMINFOA.xml' path='doc/member[@name="MENUITEMINFOA.hbmpUnchecked"]/*'/>
    public HBITMAP hbmpUnchecked;
    /// <include file='MENUITEMINFOA.xml' path='doc/member[@name="MENUITEMINFOA.dwItemData"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint dwItemData;
    /// <include file='MENUITEMINFOA.xml' path='doc/member[@name="MENUITEMINFOA.dwTypeData"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* dwTypeData;
    /// <include file='MENUITEMINFOA.xml' path='doc/member[@name="MENUITEMINFOA.cch"]/*'/>
    public uint cch;
    /// <include file='MENUITEMINFOA.xml' path='doc/member[@name="MENUITEMINFOA.hbmpItem"]/*'/>
    public HBITMAP hbmpItem;
}