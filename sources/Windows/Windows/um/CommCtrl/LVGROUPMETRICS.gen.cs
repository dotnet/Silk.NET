// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='LVGROUPMETRICS.xml' path='doc/member[@name="LVGROUPMETRICS"]/*'/>
public partial struct LVGROUPMETRICS
{
    /// <include file='LVGROUPMETRICS.xml' path='doc/member[@name="LVGROUPMETRICS.cbSize"]/*'/>
    public uint cbSize;
    /// <include file='LVGROUPMETRICS.xml' path='doc/member[@name="LVGROUPMETRICS.mask"]/*'/>
    public uint mask;
    /// <include file='LVGROUPMETRICS.xml' path='doc/member[@name="LVGROUPMETRICS.Left"]/*'/>
    public uint Left;
    /// <include file='LVGROUPMETRICS.xml' path='doc/member[@name="LVGROUPMETRICS.Top"]/*'/>
    public uint Top;
    /// <include file='LVGROUPMETRICS.xml' path='doc/member[@name="LVGROUPMETRICS.Right"]/*'/>
    public uint Right;
    /// <include file='LVGROUPMETRICS.xml' path='doc/member[@name="LVGROUPMETRICS.Bottom"]/*'/>
    public uint Bottom;
    /// <include file='LVGROUPMETRICS.xml' path='doc/member[@name="LVGROUPMETRICS.crLeft"]/*'/>
    public COLORREF crLeft;
    /// <include file='LVGROUPMETRICS.xml' path='doc/member[@name="LVGROUPMETRICS.crTop"]/*'/>
    public COLORREF crTop;
    /// <include file='LVGROUPMETRICS.xml' path='doc/member[@name="LVGROUPMETRICS.crRight"]/*'/>
    public COLORREF crRight;
    /// <include file='LVGROUPMETRICS.xml' path='doc/member[@name="LVGROUPMETRICS.crBottom"]/*'/>
    public COLORREF crBottom;
    /// <include file='LVGROUPMETRICS.xml' path='doc/member[@name="LVGROUPMETRICS.crHeader"]/*'/>
    public COLORREF crHeader;
    /// <include file='LVGROUPMETRICS.xml' path='doc/member[@name="LVGROUPMETRICS.crFooter"]/*'/>
    public COLORREF crFooter;
}