// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TCITEMA.xml' path='doc/member[@name="TCITEMA"]/*'/>
public unsafe partial struct TCITEMA
{
    /// <include file='TCITEMA.xml' path='doc/member[@name="TCITEMA.mask"]/*'/>
    public uint mask;
    /// <include file='TCITEMA.xml' path='doc/member[@name="TCITEMA.dwState"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwState;
    /// <include file='TCITEMA.xml' path='doc/member[@name="TCITEMA.dwStateMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwStateMask;
    /// <include file='TCITEMA.xml' path='doc/member[@name="TCITEMA.pszText"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* pszText;
    /// <include file='TCITEMA.xml' path='doc/member[@name="TCITEMA.cchTextMax"]/*'/>
    public int cchTextMax;
    /// <include file='TCITEMA.xml' path='doc/member[@name="TCITEMA.iImage"]/*'/>
    public int iImage;
    /// <include file='TCITEMA.xml' path='doc/member[@name="TCITEMA.lParam"]/*'/>
    public LPARAM lParam;
}