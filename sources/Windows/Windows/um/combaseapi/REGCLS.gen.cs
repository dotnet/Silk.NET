// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/combaseapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='REGCLS.xml' path='doc/member[@name="REGCLS"]/*' />
[Flags]
public enum REGCLS
{
    /// <include file='REGCLS.xml' path='doc/member[@name="REGCLS.REGCLS_SINGLEUSE"]/*' />
    REGCLS_SINGLEUSE = 0,

    /// <include file='REGCLS.xml' path='doc/member[@name="REGCLS.REGCLS_MULTIPLEUSE"]/*' />
    REGCLS_MULTIPLEUSE = 1,

    /// <include file='REGCLS.xml' path='doc/member[@name="REGCLS.REGCLS_MULTI_SEPARATE"]/*' />
    REGCLS_MULTI_SEPARATE = 2,

    /// <include file='REGCLS.xml' path='doc/member[@name="REGCLS.REGCLS_SUSPENDED"]/*' />
    REGCLS_SUSPENDED = 4,

    /// <include file='REGCLS.xml' path='doc/member[@name="REGCLS.REGCLS_SURROGATE"]/*' />
    REGCLS_SURROGATE = 8,

    /// <include file='REGCLS.xml' path='doc/member[@name="REGCLS.REGCLS_AGILE"]/*' />
    REGCLS_AGILE = 0x10,
}
