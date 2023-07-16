// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='ALTTABINFO.xml' path='doc/member[@name="ALTTABINFO"]/*'/>
public partial struct ALTTABINFO
{
    /// <include file='ALTTABINFO.xml' path='doc/member[@name="ALTTABINFO.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='ALTTABINFO.xml' path='doc/member[@name="ALTTABINFO.cItems"]/*'/>
    public int cItems;
    /// <include file='ALTTABINFO.xml' path='doc/member[@name="ALTTABINFO.cColumns"]/*'/>
    public int cColumns;
    /// <include file='ALTTABINFO.xml' path='doc/member[@name="ALTTABINFO.cRows"]/*'/>
    public int cRows;
    /// <include file='ALTTABINFO.xml' path='doc/member[@name="ALTTABINFO.iColFocus"]/*'/>
    public int iColFocus;
    /// <include file='ALTTABINFO.xml' path='doc/member[@name="ALTTABINFO.iRowFocus"]/*'/>
    public int iRowFocus;
    /// <include file='ALTTABINFO.xml' path='doc/member[@name="ALTTABINFO.cxItem"]/*'/>
    public int cxItem;
    /// <include file='ALTTABINFO.xml' path='doc/member[@name="ALTTABINFO.cyItem"]/*'/>
    public int cyItem;
    /// <include file='ALTTABINFO.xml' path='doc/member[@name="ALTTABINFO.ptStart"]/*'/>
    public POINT ptStart;
}