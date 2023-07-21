// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='BINDSPEED.xml' path='doc/member[@name="BINDSPEED"]/*' />
public enum BINDSPEED
{
    /// <include file='BINDSPEED.xml' path='doc/member[@name="BINDSPEED.BINDSPEED_INDEFINITE"]/*' />
    BINDSPEED_INDEFINITE = 1,

    /// <include file='BINDSPEED.xml' path='doc/member[@name="BINDSPEED.BINDSPEED_MODERATE"]/*' />
    BINDSPEED_MODERATE = 2,

    /// <include file='BINDSPEED.xml' path='doc/member[@name="BINDSPEED.BINDSPEED_IMMEDIATE"]/*' />
    BINDSPEED_IMMEDIATE = 3,
}
