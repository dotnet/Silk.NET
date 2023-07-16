// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MENUITEMTEMPLATE.xml' path='doc/member[@name="MENUITEMTEMPLATE"]/*'/>
public unsafe partial struct MENUITEMTEMPLATE
{
    /// <include file='MENUITEMTEMPLATE.xml' path='doc/member[@name="MENUITEMTEMPLATE.mtOption"]/*'/>
    [NativeTypeName("WORD")]
    public ushort mtOption;
    /// <include file='MENUITEMTEMPLATE.xml' path='doc/member[@name="MENUITEMTEMPLATE.mtID"]/*'/>
    [NativeTypeName("WORD")]
    public ushort mtID;
    /// <include file='MENUITEMTEMPLATE.xml' path='doc/member[@name="MENUITEMTEMPLATE.mtString"]/*'/>
    [NativeTypeName("WCHAR[1]")]
    public fixed ushort mtString[1];
}