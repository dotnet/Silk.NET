// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='ASSOCDATA.xml' path='doc/member[@name="ASSOCDATA"]/*' />
public enum ASSOCDATA
{
    /// <include file='ASSOCDATA.xml' path='doc/member[@name="ASSOCDATA.ASSOCDATA_MSIDESCRIPTOR"]/*' />
    ASSOCDATA_MSIDESCRIPTOR = 1,

    /// <include file='ASSOCDATA.xml' path='doc/member[@name="ASSOCDATA.ASSOCDATA_NOACTIVATEHANDLER"]/*' />
    ASSOCDATA_NOACTIVATEHANDLER,

    /// <include file='ASSOCDATA.xml' path='doc/member[@name="ASSOCDATA.ASSOCDATA_UNUSED1"]/*' />
    ASSOCDATA_UNUSED1,

    /// <include file='ASSOCDATA.xml' path='doc/member[@name="ASSOCDATA.ASSOCDATA_HASPERUSERASSOC"]/*' />
    ASSOCDATA_HASPERUSERASSOC,

    /// <include file='ASSOCDATA.xml' path='doc/member[@name="ASSOCDATA.ASSOCDATA_EDITFLAGS"]/*' />
    ASSOCDATA_EDITFLAGS,

    /// <include file='ASSOCDATA.xml' path='doc/member[@name="ASSOCDATA.ASSOCDATA_VALUE"]/*' />
    ASSOCDATA_VALUE,

    /// <include file='ASSOCDATA.xml' path='doc/member[@name="ASSOCDATA.ASSOCDATA_MAX"]/*' />
    ASSOCDATA_MAX,
}
