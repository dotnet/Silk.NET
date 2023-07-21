// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SPDISPLAYATTRIBUTES.xml' path='doc/member[@name="SPDISPLAYATTRIBUTES"]/*' />
public enum SPDISPLAYATTRIBUTES
{
    /// <include file='SPDISPLAYATTRIBUTES.xml' path='doc/member[@name="SPDISPLAYATTRIBUTES.SPAF_ONE_TRAILING_SPACE"]/*' />
    SPAF_ONE_TRAILING_SPACE = 0x2,

    /// <include file='SPDISPLAYATTRIBUTES.xml' path='doc/member[@name="SPDISPLAYATTRIBUTES.SPAF_TWO_TRAILING_SPACES"]/*' />
    SPAF_TWO_TRAILING_SPACES = 0x4,

    /// <include file='SPDISPLAYATTRIBUTES.xml' path='doc/member[@name="SPDISPLAYATTRIBUTES.SPAF_CONSUME_LEADING_SPACES"]/*' />
    SPAF_CONSUME_LEADING_SPACES = 0x8,

    /// <include file='SPDISPLAYATTRIBUTES.xml' path='doc/member[@name="SPDISPLAYATTRIBUTES.SPAF_BUFFER_POSITION"]/*' />
    SPAF_BUFFER_POSITION = 0x10,

    /// <include file='SPDISPLAYATTRIBUTES.xml' path='doc/member[@name="SPDISPLAYATTRIBUTES.SPAF_ALL"]/*' />
    SPAF_ALL = 0x1f,

    /// <include file='SPDISPLAYATTRIBUTES.xml' path='doc/member[@name="SPDISPLAYATTRIBUTES.SPAF_USER_SPECIFIED"]/*' />
    SPAF_USER_SPECIFIED = 0x80,
}
