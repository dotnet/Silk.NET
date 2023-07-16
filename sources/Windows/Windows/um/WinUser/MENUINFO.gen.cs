// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MENUINFO.xml' path='doc/member[@name="MENUINFO"]/*'/>
public partial struct MENUINFO
{
    /// <include file='MENUINFO.xml' path='doc/member[@name="MENUINFO.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='MENUINFO.xml' path='doc/member[@name="MENUINFO.fMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint fMask;
    /// <include file='MENUINFO.xml' path='doc/member[@name="MENUINFO.dwStyle"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwStyle;
    /// <include file='MENUINFO.xml' path='doc/member[@name="MENUINFO.cyMax"]/*'/>
    public uint cyMax;
    /// <include file='MENUINFO.xml' path='doc/member[@name="MENUINFO.hbrBack"]/*'/>
    public HBRUSH hbrBack;
    /// <include file='MENUINFO.xml' path='doc/member[@name="MENUINFO.dwContextHelpID"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwContextHelpID;
    /// <include file='MENUINFO.xml' path='doc/member[@name="MENUINFO.dwMenuData"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint dwMenuData;
}