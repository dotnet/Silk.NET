// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='MF_VIDEO_PROCESSOR_MIRROR.xml' path='doc/member[@name="MF_VIDEO_PROCESSOR_MIRROR"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum MF_VIDEO_PROCESSOR_MIRROR
{
    /// <include file='MF_VIDEO_PROCESSOR_MIRROR.xml' path='doc/member[@name="MF_VIDEO_PROCESSOR_MIRROR.MIRROR_NONE"]/*'/>
    MIRROR_NONE = 0,
    /// <include file='MF_VIDEO_PROCESSOR_MIRROR.xml' path='doc/member[@name="MF_VIDEO_PROCESSOR_MIRROR.MIRROR_HORIZONTAL"]/*'/>
    MIRROR_HORIZONTAL = 1,
    /// <include file='MF_VIDEO_PROCESSOR_MIRROR.xml' path='doc/member[@name="MF_VIDEO_PROCESSOR_MIRROR.MIRROR_VERTICAL"]/*'/>
    MIRROR_VERTICAL = 2,
}