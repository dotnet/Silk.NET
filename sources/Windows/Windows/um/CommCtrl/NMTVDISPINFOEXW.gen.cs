// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NMTVDISPINFOEXW.xml' path='doc/member[@name="NMTVDISPINFOEXW"]/*'/>
public partial struct NMTVDISPINFOEXW
{
    /// <include file='NMTVDISPINFOEXW.xml' path='doc/member[@name="NMTVDISPINFOEXW.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMTVDISPINFOEXW.xml' path='doc/member[@name="NMTVDISPINFOEXW.item"]/*'/>
    public TVITEMEXW item;
}