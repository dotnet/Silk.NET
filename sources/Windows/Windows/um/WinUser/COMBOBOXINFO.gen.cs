// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='COMBOBOXINFO.xml' path='doc/member[@name="COMBOBOXINFO"]/*'/>
public partial struct COMBOBOXINFO
{
    /// <include file='COMBOBOXINFO.xml' path='doc/member[@name="COMBOBOXINFO.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='COMBOBOXINFO.xml' path='doc/member[@name="COMBOBOXINFO.rcItem"]/*'/>
    public RECT rcItem;
    /// <include file='COMBOBOXINFO.xml' path='doc/member[@name="COMBOBOXINFO.rcButton"]/*'/>
    public RECT rcButton;
    /// <include file='COMBOBOXINFO.xml' path='doc/member[@name="COMBOBOXINFO.stateButton"]/*'/>
    [NativeTypeName("DWORD")]
    public uint stateButton;
    /// <include file='COMBOBOXINFO.xml' path='doc/member[@name="COMBOBOXINFO.hwndCombo"]/*'/>
    public HWND hwndCombo;
    /// <include file='COMBOBOXINFO.xml' path='doc/member[@name="COMBOBOXINFO.hwndItem"]/*'/>
    public HWND hwndItem;
    /// <include file='COMBOBOXINFO.xml' path='doc/member[@name="COMBOBOXINFO.hwndList"]/*'/>
    public HWND hwndList;
}