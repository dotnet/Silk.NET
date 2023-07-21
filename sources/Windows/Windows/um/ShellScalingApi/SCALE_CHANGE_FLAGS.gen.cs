// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShellScalingApi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='SCALE_CHANGE_FLAGS.xml' path='doc/member[@name="SCALE_CHANGE_FLAGS"]/*' />
[Flags]
[SupportedOSPlatform("windows6.2")]
public enum SCALE_CHANGE_FLAGS
{
    /// <include file='SCALE_CHANGE_FLAGS.xml' path='doc/member[@name="SCALE_CHANGE_FLAGS.SCF_VALUE_NONE"]/*' />
    SCF_VALUE_NONE = 0x00,

    /// <include file='SCALE_CHANGE_FLAGS.xml' path='doc/member[@name="SCALE_CHANGE_FLAGS.SCF_SCALE"]/*' />
    SCF_SCALE = 0x01,

    /// <include file='SCALE_CHANGE_FLAGS.xml' path='doc/member[@name="SCALE_CHANGE_FLAGS.SCF_PHYSICAL"]/*' />
    SCF_PHYSICAL = 0x02,
}
