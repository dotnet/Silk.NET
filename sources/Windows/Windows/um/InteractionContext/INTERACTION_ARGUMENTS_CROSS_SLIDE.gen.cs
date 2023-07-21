// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='INTERACTION_ARGUMENTS_CROSS_SLIDE.xml' path='doc/member[@name="INTERACTION_ARGUMENTS_CROSS_SLIDE"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct INTERACTION_ARGUMENTS_CROSS_SLIDE
{
    /// <include file='INTERACTION_ARGUMENTS_CROSS_SLIDE.xml' path='doc/member[@name="INTERACTION_ARGUMENTS_CROSS_SLIDE.flags"]/*' />
    public CROSS_SLIDE_FLAGS flags;
}
