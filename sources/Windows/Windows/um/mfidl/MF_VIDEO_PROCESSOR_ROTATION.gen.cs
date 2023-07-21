// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='MF_VIDEO_PROCESSOR_ROTATION.xml' path='doc/member[@name="MF_VIDEO_PROCESSOR_ROTATION"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum MF_VIDEO_PROCESSOR_ROTATION
{
    /// <include file='MF_VIDEO_PROCESSOR_ROTATION.xml' path='doc/member[@name="MF_VIDEO_PROCESSOR_ROTATION.ROTATION_NONE"]/*' />
    ROTATION_NONE = 0,

    /// <include file='MF_VIDEO_PROCESSOR_ROTATION.xml' path='doc/member[@name="MF_VIDEO_PROCESSOR_ROTATION.ROTATION_NORMAL"]/*' />
    ROTATION_NORMAL = 1,
}
