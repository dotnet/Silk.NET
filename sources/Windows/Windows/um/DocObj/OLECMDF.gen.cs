// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='OLECMDF.xml' path='doc/member[@name="OLECMDF"]/*' />
public enum OLECMDF
{
    /// <include file='OLECMDF.xml' path='doc/member[@name="OLECMDF.OLECMDF_SUPPORTED"]/*' />
    OLECMDF_SUPPORTED = 0x1,

    /// <include file='OLECMDF.xml' path='doc/member[@name="OLECMDF.OLECMDF_ENABLED"]/*' />
    OLECMDF_ENABLED = 0x2,

    /// <include file='OLECMDF.xml' path='doc/member[@name="OLECMDF.OLECMDF_LATCHED"]/*' />
    OLECMDF_LATCHED = 0x4,

    /// <include file='OLECMDF.xml' path='doc/member[@name="OLECMDF.OLECMDF_NINCHED"]/*' />
    OLECMDF_NINCHED = 0x8,

    /// <include file='OLECMDF.xml' path='doc/member[@name="OLECMDF.OLECMDF_INVISIBLE"]/*' />
    OLECMDF_INVISIBLE = 0x10,

    /// <include file='OLECMDF.xml' path='doc/member[@name="OLECMDF.OLECMDF_DEFHIDEONCTXTMENU"]/*' />
    OLECMDF_DEFHIDEONCTXTMENU = 0x20,
}
