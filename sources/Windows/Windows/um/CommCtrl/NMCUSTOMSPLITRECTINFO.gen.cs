// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='NMCUSTOMSPLITRECTINFO.xml' path='doc/member[@name="NMCUSTOMSPLITRECTINFO"]/*'/>
public partial struct NMCUSTOMSPLITRECTINFO
{
    /// <include file='NMCUSTOMSPLITRECTINFO.xml' path='doc/member[@name="NMCUSTOMSPLITRECTINFO.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMCUSTOMSPLITRECTINFO.xml' path='doc/member[@name="NMCUSTOMSPLITRECTINFO.rcClient"]/*'/>
    public RECT rcClient;
    /// <include file='NMCUSTOMSPLITRECTINFO.xml' path='doc/member[@name="NMCUSTOMSPLITRECTINFO.rcButton"]/*'/>
    public RECT rcButton;
    /// <include file='NMCUSTOMSPLITRECTINFO.xml' path='doc/member[@name="NMCUSTOMSPLITRECTINFO.rcSplit"]/*'/>
    public RECT rcSplit;
}