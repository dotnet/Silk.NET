// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/davclnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='AUTHNEXTSTEP.xml' path='doc/member[@name="AUTHNEXTSTEP"]/*' />
public enum AUTHNEXTSTEP
{
    /// <include file='AUTHNEXTSTEP.xml' path='doc/member[@name="AUTHNEXTSTEP.DefaultBehavior"]/*' />
    DefaultBehavior,

    /// <include file='AUTHNEXTSTEP.xml' path='doc/member[@name="AUTHNEXTSTEP.RetryRequest"]/*' />
    RetryRequest,

    /// <include file='AUTHNEXTSTEP.xml' path='doc/member[@name="AUTHNEXTSTEP.CancelRequest"]/*' />
    CancelRequest,
}
