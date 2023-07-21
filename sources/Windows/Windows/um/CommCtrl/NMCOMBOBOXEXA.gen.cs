// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NMCOMBOBOXEXA.xml' path='doc/member[@name="NMCOMBOBOXEXA"]/*' />
public partial struct NMCOMBOBOXEXA
{
    /// <include file='NMCOMBOBOXEXA.xml' path='doc/member[@name="NMCOMBOBOXEXA.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMCOMBOBOXEXA.xml' path='doc/member[@name="NMCOMBOBOXEXA.ceItem"]/*' />
    public COMBOBOXEXITEMA ceItem;
}
