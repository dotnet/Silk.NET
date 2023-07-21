// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DVASPECT.xml' path='doc/member[@name="DVASPECT"]/*' />
public enum DVASPECT
{
    /// <include file='DVASPECT.xml' path='doc/member[@name="DVASPECT.DVASPECT_CONTENT"]/*' />
    DVASPECT_CONTENT = 1,

    /// <include file='DVASPECT.xml' path='doc/member[@name="DVASPECT.DVASPECT_THUMBNAIL"]/*' />
    DVASPECT_THUMBNAIL = 2,

    /// <include file='DVASPECT.xml' path='doc/member[@name="DVASPECT.DVASPECT_ICON"]/*' />
    DVASPECT_ICON = 4,

    /// <include file='DVASPECT.xml' path='doc/member[@name="DVASPECT.DVASPECT_DOCPRINT"]/*' />
    DVASPECT_DOCPRINT = 8,
}
