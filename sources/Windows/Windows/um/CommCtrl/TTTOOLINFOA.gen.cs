// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TTTOOLINFOA.xml' path='doc/member[@name="TTTOOLINFOA"]/*'/>
public unsafe partial struct TTTOOLINFOA
{
    /// <include file='TTTOOLINFOA.xml' path='doc/member[@name="TTTOOLINFOA.cbSize"]/*'/>
    public uint cbSize;
    /// <include file='TTTOOLINFOA.xml' path='doc/member[@name="TTTOOLINFOA.uFlags"]/*'/>
    public uint uFlags;
    /// <include file='TTTOOLINFOA.xml' path='doc/member[@name="TTTOOLINFOA.hwnd"]/*'/>
    public HWND hwnd;
    /// <include file='TTTOOLINFOA.xml' path='doc/member[@name="TTTOOLINFOA.uId"]/*'/>
    [NativeTypeName("UINT_PTR")]
    public nuint uId;
    /// <include file='TTTOOLINFOA.xml' path='doc/member[@name="TTTOOLINFOA.rect"]/*'/>
    public RECT rect;
    /// <include file='TTTOOLINFOA.xml' path='doc/member[@name="TTTOOLINFOA.hinst"]/*'/>
    public HINSTANCE hinst;
    /// <include file='TTTOOLINFOA.xml' path='doc/member[@name="TTTOOLINFOA.lpszText"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpszText;
    /// <include file='TTTOOLINFOA.xml' path='doc/member[@name="TTTOOLINFOA.lParam"]/*'/>
    public LPARAM lParam;
    /// <include file='TTTOOLINFOA.xml' path='doc/member[@name="TTTOOLINFOA.lpReserved"]/*'/>
    public void* lpReserved;
}