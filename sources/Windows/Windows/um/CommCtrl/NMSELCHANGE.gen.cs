// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NMSELCHANGE.xml' path='doc/member[@name="NMSELCHANGE"]/*' />
public partial struct NMSELCHANGE
{
    /// <include file='NMSELCHANGE.xml' path='doc/member[@name="NMSELCHANGE.nmhdr"]/*' />
    public NMHDR nmhdr;

    /// <include file='NMSELCHANGE.xml' path='doc/member[@name="NMSELCHANGE.stSelStart"]/*' />
    public SYSTEMTIME stSelStart;

    /// <include file='NMSELCHANGE.xml' path='doc/member[@name="NMSELCHANGE.stSelEnd"]/*' />
    public SYSTEMTIME stSelEnd;
}
