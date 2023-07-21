// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='AudioClient3ActivationParams.xml' path='doc/member[@name="AudioClient3ActivationParams"]/*' />
public partial struct AudioClient3ActivationParams
{
    /// <include file='AudioClient3ActivationParams.xml' path='doc/member[@name="AudioClient3ActivationParams.tracingContextId"]/*' />
    public Guid tracingContextId;
}
