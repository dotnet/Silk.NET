// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='PSS_DUPLICATE_FLAGS.xml' path='doc/member[@name="PSS_DUPLICATE_FLAGS"]/*'/>
[Flags]
[SupportedOSPlatform("windows6.3")]
public enum PSS_DUPLICATE_FLAGS
{
    /// <include file='PSS_DUPLICATE_FLAGS.xml' path='doc/member[@name="PSS_DUPLICATE_FLAGS.PSS_DUPLICATE_NONE"]/*'/>
    PSS_DUPLICATE_NONE = 0x00,
    /// <include file='PSS_DUPLICATE_FLAGS.xml' path='doc/member[@name="PSS_DUPLICATE_FLAGS.PSS_DUPLICATE_CLOSE_SOURCE"]/*'/>
    PSS_DUPLICATE_CLOSE_SOURCE = 0x01,
}