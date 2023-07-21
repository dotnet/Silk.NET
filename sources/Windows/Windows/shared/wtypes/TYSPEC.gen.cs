// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TYSPEC.xml' path='doc/member[@name="TYSPEC"]/*' />
public enum TYSPEC
{
    /// <include file='TYSPEC.xml' path='doc/member[@name="TYSPEC.TYSPEC_CLSID"]/*' />
    TYSPEC_CLSID = 0,

    /// <include file='TYSPEC.xml' path='doc/member[@name="TYSPEC.TYSPEC_FILEEXT"]/*' />
    TYSPEC_FILEEXT = (TYSPEC_CLSID + 1),

    /// <include file='TYSPEC.xml' path='doc/member[@name="TYSPEC.TYSPEC_MIMETYPE"]/*' />
    TYSPEC_MIMETYPE = (TYSPEC_FILEEXT + 1),

    /// <include file='TYSPEC.xml' path='doc/member[@name="TYSPEC.TYSPEC_FILENAME"]/*' />
    TYSPEC_FILENAME = (TYSPEC_MIMETYPE + 1),

    /// <include file='TYSPEC.xml' path='doc/member[@name="TYSPEC.TYSPEC_PROGID"]/*' />
    TYSPEC_PROGID = (TYSPEC_FILENAME + 1),

    /// <include file='TYSPEC.xml' path='doc/member[@name="TYSPEC.TYSPEC_PACKAGENAME"]/*' />
    TYSPEC_PACKAGENAME = (TYSPEC_PROGID + 1),

    /// <include file='TYSPEC.xml' path='doc/member[@name="TYSPEC.TYSPEC_OBJECTID"]/*' />
    TYSPEC_OBJECTID = (TYSPEC_PACKAGENAME + 1),
}
