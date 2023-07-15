// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='CROSS_SLIDE_FLAGS.xml' path='doc/member[@name="CROSS_SLIDE_FLAGS"]/*'/>
[Flags]
[SupportedOSPlatform("windows6.2")]
public enum CROSS_SLIDE_FLAGS
{
    /// <include file='CROSS_SLIDE_FLAGS.xml' path='doc/member[@name="CROSS_SLIDE_FLAGS.CROSS_SLIDE_FLAGS_NONE"]/*'/>
    CROSS_SLIDE_FLAGS_NONE = 0x00000000,
    /// <include file='CROSS_SLIDE_FLAGS.xml' path='doc/member[@name="CROSS_SLIDE_FLAGS.CROSS_SLIDE_FLAGS_SELECT"]/*'/>
    CROSS_SLIDE_FLAGS_SELECT = 0x00000001,
    /// <include file='CROSS_SLIDE_FLAGS.xml' path='doc/member[@name="CROSS_SLIDE_FLAGS.CROSS_SLIDE_FLAGS_SPEED_BUMP"]/*'/>
    CROSS_SLIDE_FLAGS_SPEED_BUMP = 0x00000002,
    /// <include file='CROSS_SLIDE_FLAGS.xml' path='doc/member[@name="CROSS_SLIDE_FLAGS.CROSS_SLIDE_FLAGS_REARRANGE"]/*'/>
    CROSS_SLIDE_FLAGS_REARRANGE = 0x00000004,
    /// <include file='CROSS_SLIDE_FLAGS.xml' path='doc/member[@name="CROSS_SLIDE_FLAGS.CROSS_SLIDE_FLAGS_MAX"]/*'/>
    CROSS_SLIDE_FLAGS_MAX = unchecked((int)(0xffffffff)),
}