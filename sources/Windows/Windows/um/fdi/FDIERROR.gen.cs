// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/fdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='FDIERROR.xml' path='doc/member[@name="FDIERROR"]/*' />
public enum FDIERROR
{
    /// <include file='FDIERROR.xml' path='doc/member[@name="FDIERROR.FDIERROR_NONE"]/*' />
    FDIERROR_NONE,

    /// <include file='FDIERROR.xml' path='doc/member[@name="FDIERROR.FDIERROR_CABINET_NOT_FOUND"]/*' />
    FDIERROR_CABINET_NOT_FOUND,

    /// <include file='FDIERROR.xml' path='doc/member[@name="FDIERROR.FDIERROR_NOT_A_CABINET"]/*' />
    FDIERROR_NOT_A_CABINET,

    /// <include file='FDIERROR.xml' path='doc/member[@name="FDIERROR.FDIERROR_UNKNOWN_CABINET_VERSION"]/*' />
    FDIERROR_UNKNOWN_CABINET_VERSION,

    /// <include file='FDIERROR.xml' path='doc/member[@name="FDIERROR.FDIERROR_CORRUPT_CABINET"]/*' />
    FDIERROR_CORRUPT_CABINET,

    /// <include file='FDIERROR.xml' path='doc/member[@name="FDIERROR.FDIERROR_ALLOC_FAIL"]/*' />
    FDIERROR_ALLOC_FAIL,

    /// <include file='FDIERROR.xml' path='doc/member[@name="FDIERROR.FDIERROR_BAD_COMPR_TYPE"]/*' />
    FDIERROR_BAD_COMPR_TYPE,

    /// <include file='FDIERROR.xml' path='doc/member[@name="FDIERROR.FDIERROR_MDI_FAIL"]/*' />
    FDIERROR_MDI_FAIL,

    /// <include file='FDIERROR.xml' path='doc/member[@name="FDIERROR.FDIERROR_TARGET_FILE"]/*' />
    FDIERROR_TARGET_FILE,

    /// <include file='FDIERROR.xml' path='doc/member[@name="FDIERROR.FDIERROR_RESERVE_MISMATCH"]/*' />
    FDIERROR_RESERVE_MISMATCH,

    /// <include file='FDIERROR.xml' path='doc/member[@name="FDIERROR.FDIERROR_WRONG_CABINET"]/*' />
    FDIERROR_WRONG_CABINET,

    /// <include file='FDIERROR.xml' path='doc/member[@name="FDIERROR.FDIERROR_USER_ABORT"]/*' />
    FDIERROR_USER_ABORT,

    /// <include file='FDIERROR.xml' path='doc/member[@name="FDIERROR.FDIERROR_EOF"]/*' />
    FDIERROR_EOF,
}
