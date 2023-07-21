// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShellScalingApi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='DISPLAY_DEVICE_TYPE.xml' path='doc/member[@name="DISPLAY_DEVICE_TYPE"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum DISPLAY_DEVICE_TYPE
{
    /// <include file='DISPLAY_DEVICE_TYPE.xml' path='doc/member[@name="DISPLAY_DEVICE_TYPE.DEVICE_PRIMARY"]/*' />
    DEVICE_PRIMARY = 0,

    /// <include file='DISPLAY_DEVICE_TYPE.xml' path='doc/member[@name="DISPLAY_DEVICE_TYPE.DEVICE_IMMERSIVE"]/*' />
    DEVICE_IMMERSIVE = 1,
}
