// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='MF_VIDEO_PROCESSOR_ALGORITHM_TYPE.xml' path='doc/member[@name="MF_VIDEO_PROCESSOR_ALGORITHM_TYPE"]/*' />
[SupportedOSPlatform("windows6.3")]
public enum MF_VIDEO_PROCESSOR_ALGORITHM_TYPE
{
    /// <include file='MF_VIDEO_PROCESSOR_ALGORITHM_TYPE.xml' path='doc/member[@name="MF_VIDEO_PROCESSOR_ALGORITHM_TYPE.MF_VIDEO_PROCESSOR_ALGORITHM_DEFAULT"]/*' />
    MF_VIDEO_PROCESSOR_ALGORITHM_DEFAULT = 0,

    /// <include file='MF_VIDEO_PROCESSOR_ALGORITHM_TYPE.xml' path='doc/member[@name="MF_VIDEO_PROCESSOR_ALGORITHM_TYPE.MF_VIDEO_PROCESSOR_ALGORITHM_MRF_CRF_444"]/*' />
    MF_VIDEO_PROCESSOR_ALGORITHM_MRF_CRF_444 = 1,
}
