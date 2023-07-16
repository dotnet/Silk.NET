// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='JOB_OBJECT_NET_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="JOB_OBJECT_NET_RATE_CONTROL_FLAGS"]/*'/>
[Flags]
[SupportedOSPlatform("windows10.0")]
public enum JOB_OBJECT_NET_RATE_CONTROL_FLAGS
{
    /// <include file='JOB_OBJECT_NET_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="JOB_OBJECT_NET_RATE_CONTROL_FLAGS.JOB_OBJECT_NET_RATE_CONTROL_ENABLE"]/*'/>
    JOB_OBJECT_NET_RATE_CONTROL_ENABLE = 0x1,
    /// <include file='JOB_OBJECT_NET_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="JOB_OBJECT_NET_RATE_CONTROL_FLAGS.JOB_OBJECT_NET_RATE_CONTROL_MAX_BANDWIDTH"]/*'/>
    JOB_OBJECT_NET_RATE_CONTROL_MAX_BANDWIDTH = 0x2,
    /// <include file='JOB_OBJECT_NET_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="JOB_OBJECT_NET_RATE_CONTROL_FLAGS.JOB_OBJECT_NET_RATE_CONTROL_DSCP_TAG"]/*'/>
    JOB_OBJECT_NET_RATE_CONTROL_DSCP_TAG = 0x4,
    /// <include file='JOB_OBJECT_NET_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="JOB_OBJECT_NET_RATE_CONTROL_FLAGS.JOB_OBJECT_NET_RATE_CONTROL_VALID_FLAGS"]/*'/>
    JOB_OBJECT_NET_RATE_CONTROL_VALID_FLAGS = 0x7,
}