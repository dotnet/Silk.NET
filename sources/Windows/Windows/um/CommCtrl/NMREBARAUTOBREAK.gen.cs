// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NMREBARAUTOBREAK.xml' path='doc/member[@name="NMREBARAUTOBREAK"]/*' />
public partial struct NMREBARAUTOBREAK
{
    /// <include file='NMREBARAUTOBREAK.xml' path='doc/member[@name="NMREBARAUTOBREAK.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMREBARAUTOBREAK.xml' path='doc/member[@name="NMREBARAUTOBREAK.uBand"]/*' />
    public uint uBand;

    /// <include file='NMREBARAUTOBREAK.xml' path='doc/member[@name="NMREBARAUTOBREAK.wID"]/*' />
    public uint wID;

    /// <include file='NMREBARAUTOBREAK.xml' path='doc/member[@name="NMREBARAUTOBREAK.lParam"]/*' />
    public LPARAM lParam;

    /// <include file='NMREBARAUTOBREAK.xml' path='doc/member[@name="NMREBARAUTOBREAK.uMsg"]/*' />
    public uint uMsg;

    /// <include file='NMREBARAUTOBREAK.xml' path='doc/member[@name="NMREBARAUTOBREAK.fStyleCurrent"]/*' />
    public uint fStyleCurrent;

    /// <include file='NMREBARAUTOBREAK.xml' path='doc/member[@name="NMREBARAUTOBREAK.fAutoBreak"]/*' />
    public BOOL fAutoBreak;
}
