// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/nldef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NL_ADDRESS_TYPE.xml' path='doc/member[@name="NL_ADDRESS_TYPE"]/*' />
public enum NL_ADDRESS_TYPE
{
    /// <include file='NL_ADDRESS_TYPE.xml' path='doc/member[@name="NL_ADDRESS_TYPE.NlatUnspecified"]/*' />
    NlatUnspecified,

    /// <include file='NL_ADDRESS_TYPE.xml' path='doc/member[@name="NL_ADDRESS_TYPE.NlatUnicast"]/*' />
    NlatUnicast,

    /// <include file='NL_ADDRESS_TYPE.xml' path='doc/member[@name="NL_ADDRESS_TYPE.NlatAnycast"]/*' />
    NlatAnycast,

    /// <include file='NL_ADDRESS_TYPE.xml' path='doc/member[@name="NL_ADDRESS_TYPE.NlatMulticast"]/*' />
    NlatMulticast,

    /// <include file='NL_ADDRESS_TYPE.xml' path='doc/member[@name="NL_ADDRESS_TYPE.NlatBroadcast"]/*' />
    NlatBroadcast,

    /// <include file='NL_ADDRESS_TYPE.xml' path='doc/member[@name="NL_ADDRESS_TYPE.NlatInvalid"]/*' />
    NlatInvalid,
}
