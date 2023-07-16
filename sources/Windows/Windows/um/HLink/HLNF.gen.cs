// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/HLink.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='HLNF.xml' path='doc/member[@name="HLNF"]/*'/>
public enum HLNF
{
    /// <include file='HLNF.xml' path='doc/member[@name="HLNF.HLNF_INTERNALJUMP"]/*'/>
    HLNF_INTERNALJUMP = 0x1,
    /// <include file='HLNF.xml' path='doc/member[@name="HLNF.HLNF_OPENINNEWWINDOW"]/*'/>
    HLNF_OPENINNEWWINDOW = 0x2,
    /// <include file='HLNF.xml' path='doc/member[@name="HLNF.HLNF_NAVIGATINGBACK"]/*'/>
    HLNF_NAVIGATINGBACK = 0x4,
    /// <include file='HLNF.xml' path='doc/member[@name="HLNF.HLNF_NAVIGATINGFORWARD"]/*'/>
    HLNF_NAVIGATINGFORWARD = 0x8,
    /// <include file='HLNF.xml' path='doc/member[@name="HLNF.HLNF_NAVIGATINGTOSTACKITEM"]/*'/>
    HLNF_NAVIGATINGTOSTACKITEM = 0x10,
    /// <include file='HLNF.xml' path='doc/member[@name="HLNF.HLNF_CREATENOHISTORY"]/*'/>
    HLNF_CREATENOHISTORY = 0x20,
}