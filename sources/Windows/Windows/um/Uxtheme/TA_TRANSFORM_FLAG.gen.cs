// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='TA_TRANSFORM_FLAG.xml' path='doc/member[@name="TA_TRANSFORM_FLAG"]/*' />
[Flags]
public enum TA_TRANSFORM_FLAG
{
    /// <include file='TA_TRANSFORM_FLAG.xml' path='doc/member[@name="TA_TRANSFORM_FLAG.TATF_NONE"]/*' />
    TATF_NONE = 0x0,

    /// <include file='TA_TRANSFORM_FLAG.xml' path='doc/member[@name="TA_TRANSFORM_FLAG.TATF_TARGETVALUES_USER"]/*' />
    TATF_TARGETVALUES_USER = 0x1,

    /// <include file='TA_TRANSFORM_FLAG.xml' path='doc/member[@name="TA_TRANSFORM_FLAG.TATF_HASINITIALVALUES"]/*' />
    TATF_HASINITIALVALUES = 0x2,

    /// <include file='TA_TRANSFORM_FLAG.xml' path='doc/member[@name="TA_TRANSFORM_FLAG.TATF_HASORIGINVALUES"]/*' />
    TATF_HASORIGINVALUES = 0x4,
}
