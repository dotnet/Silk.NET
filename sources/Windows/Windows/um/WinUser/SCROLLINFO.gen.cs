// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SCROLLINFO.xml' path='doc/member[@name="SCROLLINFO"]/*'/>
public partial struct SCROLLINFO
{
    /// <include file='SCROLLINFO.xml' path='doc/member[@name="SCROLLINFO.cbSize"]/*'/>
    public uint cbSize;
    /// <include file='SCROLLINFO.xml' path='doc/member[@name="SCROLLINFO.fMask"]/*'/>
    public uint fMask;
    /// <include file='SCROLLINFO.xml' path='doc/member[@name="SCROLLINFO.nMin"]/*'/>
    public int nMin;
    /// <include file='SCROLLINFO.xml' path='doc/member[@name="SCROLLINFO.nMax"]/*'/>
    public int nMax;
    /// <include file='SCROLLINFO.xml' path='doc/member[@name="SCROLLINFO.nPage"]/*'/>
    public uint nPage;
    /// <include file='SCROLLINFO.xml' path='doc/member[@name="SCROLLINFO.nPos"]/*'/>
    public int nPos;
    /// <include file='SCROLLINFO.xml' path='doc/member[@name="SCROLLINFO.nTrackPos"]/*'/>
    public int nTrackPos;
}