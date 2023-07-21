// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsiQuery.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MSIMODIFY.xml' path='doc/member[@name="MSIMODIFY"]/*' />
public enum MSIMODIFY
{
    /// <include file='MSIMODIFY.xml' path='doc/member[@name="MSIMODIFY.MSIMODIFY_SEEK"]/*' />
    MSIMODIFY_SEEK = -1,

    /// <include file='MSIMODIFY.xml' path='doc/member[@name="MSIMODIFY.MSIMODIFY_REFRESH"]/*' />
    MSIMODIFY_REFRESH = 0,

    /// <include file='MSIMODIFY.xml' path='doc/member[@name="MSIMODIFY.MSIMODIFY_INSERT"]/*' />
    MSIMODIFY_INSERT = 1,

    /// <include file='MSIMODIFY.xml' path='doc/member[@name="MSIMODIFY.MSIMODIFY_UPDATE"]/*' />
    MSIMODIFY_UPDATE = 2,

    /// <include file='MSIMODIFY.xml' path='doc/member[@name="MSIMODIFY.MSIMODIFY_ASSIGN"]/*' />
    MSIMODIFY_ASSIGN = 3,

    /// <include file='MSIMODIFY.xml' path='doc/member[@name="MSIMODIFY.MSIMODIFY_REPLACE"]/*' />
    MSIMODIFY_REPLACE = 4,

    /// <include file='MSIMODIFY.xml' path='doc/member[@name="MSIMODIFY.MSIMODIFY_MERGE"]/*' />
    MSIMODIFY_MERGE = 5,

    /// <include file='MSIMODIFY.xml' path='doc/member[@name="MSIMODIFY.MSIMODIFY_DELETE"]/*' />
    MSIMODIFY_DELETE = 6,

    /// <include file='MSIMODIFY.xml' path='doc/member[@name="MSIMODIFY.MSIMODIFY_INSERT_TEMPORARY"]/*' />
    MSIMODIFY_INSERT_TEMPORARY = 7,

    /// <include file='MSIMODIFY.xml' path='doc/member[@name="MSIMODIFY.MSIMODIFY_VALIDATE"]/*' />
    MSIMODIFY_VALIDATE = 8,

    /// <include file='MSIMODIFY.xml' path='doc/member[@name="MSIMODIFY.MSIMODIFY_VALIDATE_NEW"]/*' />
    MSIMODIFY_VALIDATE_NEW = 9,

    /// <include file='MSIMODIFY.xml' path='doc/member[@name="MSIMODIFY.MSIMODIFY_VALIDATE_FIELD"]/*' />
    MSIMODIFY_VALIDATE_FIELD = 10,

    /// <include file='MSIMODIFY.xml' path='doc/member[@name="MSIMODIFY.MSIMODIFY_VALIDATE_DELETE"]/*' />
    MSIMODIFY_VALIDATE_DELETE = 11,
}
