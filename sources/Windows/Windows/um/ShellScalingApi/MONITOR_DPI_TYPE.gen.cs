// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShellScalingApi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='MONITOR_DPI_TYPE.xml' path='doc/member[@name="MONITOR_DPI_TYPE"]/*' />
[SupportedOSPlatform("windows6.3")]
public enum MONITOR_DPI_TYPE
{
    /// <include file='MONITOR_DPI_TYPE.xml' path='doc/member[@name="MONITOR_DPI_TYPE.MDT_EFFECTIVE_DPI"]/*' />
    MDT_EFFECTIVE_DPI = 0,

    /// <include file='MONITOR_DPI_TYPE.xml' path='doc/member[@name="MONITOR_DPI_TYPE.MDT_ANGULAR_DPI"]/*' />
    MDT_ANGULAR_DPI = 1,

    /// <include file='MONITOR_DPI_TYPE.xml' path='doc/member[@name="MONITOR_DPI_TYPE.MDT_RAW_DPI"]/*' />
    MDT_RAW_DPI = 2,

    /// <include file='MONITOR_DPI_TYPE.xml' path='doc/member[@name="MONITOR_DPI_TYPE.MDT_DEFAULT"]/*' />
    MDT_DEFAULT = MDT_EFFECTIVE_DPI,
}
