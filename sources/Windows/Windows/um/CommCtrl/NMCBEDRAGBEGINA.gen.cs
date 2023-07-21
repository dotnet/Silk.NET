// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NMCBEDRAGBEGINA.xml' path='doc/member[@name="NMCBEDRAGBEGINA"]/*' />
public unsafe partial struct NMCBEDRAGBEGINA
{
    /// <include file='NMCBEDRAGBEGINA.xml' path='doc/member[@name="NMCBEDRAGBEGINA.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMCBEDRAGBEGINA.xml' path='doc/member[@name="NMCBEDRAGBEGINA.iItemid"]/*' />
    public int iItemid;

    /// <include file='NMCBEDRAGBEGINA.xml' path='doc/member[@name="NMCBEDRAGBEGINA.szText"]/*' />
    [NativeTypeName("char[260]")]
    public fixed sbyte szText[260];
}
