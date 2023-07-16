// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TOOLBARITEM.xml' path='doc/member[@name="TOOLBARITEM"]/*'/>
public unsafe partial struct TOOLBARITEM
{
    /// <include file='TOOLBARITEM.xml' path='doc/member[@name="TOOLBARITEM.ptbar"]/*'/>
    public IDockingWindow* ptbar;
    /// <include file='TOOLBARITEM.xml' path='doc/member[@name="TOOLBARITEM.rcBorderTool"]/*'/>
    [NativeTypeName("BORDERWIDTHS")]
    public RECT rcBorderTool;
    /// <include file='TOOLBARITEM.xml' path='doc/member[@name="TOOLBARITEM.pwszItem"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pwszItem;
    /// <include file='TOOLBARITEM.xml' path='doc/member[@name="TOOLBARITEM.fShow"]/*'/>
    public BOOL fShow;
    /// <include file='TOOLBARITEM.xml' path='doc/member[@name="TOOLBARITEM.hMon"]/*'/>
    public HMONITOR hMon;
}