// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TCITEMW.xml' path='doc/member[@name="TCITEMW"]/*'/>
public unsafe partial struct TCITEMW
{
    /// <include file='TCITEMW.xml' path='doc/member[@name="TCITEMW.mask"]/*'/>
    public uint mask;
    /// <include file='TCITEMW.xml' path='doc/member[@name="TCITEMW.dwState"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwState;
    /// <include file='TCITEMW.xml' path='doc/member[@name="TCITEMW.dwStateMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwStateMask;
    /// <include file='TCITEMW.xml' path='doc/member[@name="TCITEMW.pszText"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszText;
    /// <include file='TCITEMW.xml' path='doc/member[@name="TCITEMW.cchTextMax"]/*'/>
    public int cchTextMax;
    /// <include file='TCITEMW.xml' path='doc/member[@name="TCITEMW.iImage"]/*'/>
    public int iImage;
    /// <include file='TCITEMW.xml' path='doc/member[@name="TCITEMW.lParam"]/*'/>
    public LPARAM lParam;
}