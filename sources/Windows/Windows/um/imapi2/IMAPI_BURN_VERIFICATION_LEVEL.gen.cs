// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IMAPI_BURN_VERIFICATION_LEVEL.xml' path='doc/member[@name="IMAPI_BURN_VERIFICATION_LEVEL"]/*' />
public enum IMAPI_BURN_VERIFICATION_LEVEL
{
    /// <include file='IMAPI_BURN_VERIFICATION_LEVEL.xml' path='doc/member[@name="IMAPI_BURN_VERIFICATION_LEVEL.IMAPI_BURN_VERIFICATION_NONE"]/*' />
    IMAPI_BURN_VERIFICATION_NONE = 0,

    /// <include file='IMAPI_BURN_VERIFICATION_LEVEL.xml' path='doc/member[@name="IMAPI_BURN_VERIFICATION_LEVEL.IMAPI_BURN_VERIFICATION_QUICK"]/*' />
    IMAPI_BURN_VERIFICATION_QUICK = 1,

    /// <include file='IMAPI_BURN_VERIFICATION_LEVEL.xml' path='doc/member[@name="IMAPI_BURN_VERIFICATION_LEVEL.IMAPI_BURN_VERIFICATION_FULL"]/*' />
    IMAPI_BURN_VERIFICATION_FULL = 2,
}
