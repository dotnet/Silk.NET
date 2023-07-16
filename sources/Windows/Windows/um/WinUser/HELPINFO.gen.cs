// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='HELPINFO.xml' path='doc/member[@name="HELPINFO"]/*'/>
public partial struct HELPINFO
{
    /// <include file='HELPINFO.xml' path='doc/member[@name="HELPINFO.cbSize"]/*'/>
    public uint cbSize;
    /// <include file='HELPINFO.xml' path='doc/member[@name="HELPINFO.iContextType"]/*'/>
    public int iContextType;
    /// <include file='HELPINFO.xml' path='doc/member[@name="HELPINFO.iCtrlId"]/*'/>
    public int iCtrlId;
    /// <include file='HELPINFO.xml' path='doc/member[@name="HELPINFO.hItemHandle"]/*'/>
    public HANDLE hItemHandle;
    /// <include file='HELPINFO.xml' path='doc/member[@name="HELPINFO.dwContextId"]/*'/>
    [NativeTypeName("DWORD_PTR")]
    public nuint dwContextId;
    /// <include file='HELPINFO.xml' path='doc/member[@name="HELPINFO.MousePos"]/*'/>
    public POINT MousePos;
}