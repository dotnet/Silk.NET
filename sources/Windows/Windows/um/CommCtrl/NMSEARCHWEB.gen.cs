// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NMSEARCHWEB.xml' path='doc/member[@name="NMSEARCHWEB"]/*' />
public partial struct NMSEARCHWEB
{
    /// <include file='NMSEARCHWEB.xml' path='doc/member[@name="NMSEARCHWEB.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMSEARCHWEB.xml' path='doc/member[@name="NMSEARCHWEB.entrypoint"]/*' />
    public EC_SEARCHWEB_ENTRYPOINT entrypoint;

    /// <include file='NMSEARCHWEB.xml' path='doc/member[@name="NMSEARCHWEB.hasQueryText"]/*' />
    public BOOL hasQueryText;

    /// <include file='NMSEARCHWEB.xml' path='doc/member[@name="NMSEARCHWEB.invokeSucceeded"]/*' />
    public BOOL invokeSucceeded;
}
