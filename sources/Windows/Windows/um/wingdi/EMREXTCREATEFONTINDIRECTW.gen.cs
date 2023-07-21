// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='EMREXTCREATEFONTINDIRECTW.xml' path='doc/member[@name="EMREXTCREATEFONTINDIRECTW"]/*' />
public partial struct EMREXTCREATEFONTINDIRECTW
{
    /// <include file='EMREXTCREATEFONTINDIRECTW.xml' path='doc/member[@name="EMREXTCREATEFONTINDIRECTW.emr"]/*' />
    public EMR emr;

    /// <include file='EMREXTCREATEFONTINDIRECTW.xml' path='doc/member[@name="EMREXTCREATEFONTINDIRECTW.ihFont"]/*' />
    [NativeTypeName("DWORD")]
    public uint ihFont;

    /// <include file='EMREXTCREATEFONTINDIRECTW.xml' path='doc/member[@name="EMREXTCREATEFONTINDIRECTW.elfw"]/*' />
    public EXTLOGFONTW elfw;
}
