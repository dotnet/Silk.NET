// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TVITEMEXW.xml' path='doc/member[@name="TVITEMEXW"]/*'/>
public unsafe partial struct TVITEMEXW
{
    /// <include file='TVITEMEXW.xml' path='doc/member[@name="TVITEMEXW.mask"]/*'/>
    public uint mask;
    /// <include file='TVITEMEXW.xml' path='doc/member[@name="TVITEMEXW.hItem"]/*'/>
    public HTREEITEM hItem;
    /// <include file='TVITEMEXW.xml' path='doc/member[@name="TVITEMEXW.state"]/*'/>
    public uint state;
    /// <include file='TVITEMEXW.xml' path='doc/member[@name="TVITEMEXW.stateMask"]/*'/>
    public uint stateMask;
    /// <include file='TVITEMEXW.xml' path='doc/member[@name="TVITEMEXW.pszText"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszText;
    /// <include file='TVITEMEXW.xml' path='doc/member[@name="TVITEMEXW.cchTextMax"]/*'/>
    public int cchTextMax;
    /// <include file='TVITEMEXW.xml' path='doc/member[@name="TVITEMEXW.iImage"]/*'/>
    public int iImage;
    /// <include file='TVITEMEXW.xml' path='doc/member[@name="TVITEMEXW.iSelectedImage"]/*'/>
    public int iSelectedImage;
    /// <include file='TVITEMEXW.xml' path='doc/member[@name="TVITEMEXW.cChildren"]/*'/>
    public int cChildren;
    /// <include file='TVITEMEXW.xml' path='doc/member[@name="TVITEMEXW.lParam"]/*'/>
    public LPARAM lParam;
    /// <include file='TVITEMEXW.xml' path='doc/member[@name="TVITEMEXW.iIntegral"]/*'/>
    public int iIntegral;
    /// <include file='TVITEMEXW.xml' path='doc/member[@name="TVITEMEXW.uStateEx"]/*'/>
    public uint uStateEx;
    /// <include file='TVITEMEXW.xml' path='doc/member[@name="TVITEMEXW.hwnd"]/*'/>
    public HWND hwnd;
    /// <include file='TVITEMEXW.xml' path='doc/member[@name="TVITEMEXW.iExpandedImage"]/*'/>
    public int iExpandedImage;
    /// <include file='TVITEMEXW.xml' path='doc/member[@name="TVITEMEXW.iReserved"]/*'/>
    public int iReserved;
}