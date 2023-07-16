// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='NMCUSTOMDRAW.xml' path='doc/member[@name="NMCUSTOMDRAW"]/*'/>
public partial struct NMCUSTOMDRAW
{
    /// <include file='NMCUSTOMDRAW.xml' path='doc/member[@name="NMCUSTOMDRAW.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMCUSTOMDRAW.xml' path='doc/member[@name="NMCUSTOMDRAW.dwDrawStage"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDrawStage;
    /// <include file='NMCUSTOMDRAW.xml' path='doc/member[@name="NMCUSTOMDRAW.hdc"]/*'/>
    public HDC hdc;
    /// <include file='NMCUSTOMDRAW.xml' path='doc/member[@name="NMCUSTOMDRAW.rc"]/*'/>
    public RECT rc;
    /// <include file='NMCUSTOMDRAW.xml' path='doc/member[@name="NMCUSTOMDRAW.dwItemSpec"]/*'/>
    [NativeTypeName("DWORD_PTR")]
    public nuint dwItemSpec;
    /// <include file='NMCUSTOMDRAW.xml' path='doc/member[@name="NMCUSTOMDRAW.uItemState"]/*'/>
    public uint uItemState;
    /// <include file='NMCUSTOMDRAW.xml' path='doc/member[@name="NMCUSTOMDRAW.lItemlParam"]/*'/>
    public LPARAM lItemlParam;
}