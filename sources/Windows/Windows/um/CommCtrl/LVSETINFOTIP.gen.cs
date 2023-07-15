// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='LVSETINFOTIP.xml' path='doc/member[@name="LVSETINFOTIP"]/*'/>
public unsafe partial struct LVSETINFOTIP
{
    /// <include file='LVSETINFOTIP.xml' path='doc/member[@name="LVSETINFOTIP.cbSize"]/*'/>
    public uint cbSize;
    /// <include file='LVSETINFOTIP.xml' path='doc/member[@name="LVSETINFOTIP.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='LVSETINFOTIP.xml' path='doc/member[@name="LVSETINFOTIP.pszText"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszText;
    /// <include file='LVSETINFOTIP.xml' path='doc/member[@name="LVSETINFOTIP.iItem"]/*'/>
    public int iItem;
    /// <include file='LVSETINFOTIP.xml' path='doc/member[@name="LVSETINFOTIP.iSubItem"]/*'/>
    public int iSubItem;
}