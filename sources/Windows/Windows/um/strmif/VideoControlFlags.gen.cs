// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='VideoControlFlags.xml' path='doc/member[@name="VideoControlFlags"]/*' />
public enum VideoControlFlags
{
    /// <include file='VideoControlFlags.xml' path='doc/member[@name="VideoControlFlags.VideoControlFlag_FlipHorizontal"]/*' />
    VideoControlFlag_FlipHorizontal = 0x1,

    /// <include file='VideoControlFlags.xml' path='doc/member[@name="VideoControlFlags.VideoControlFlag_FlipVertical"]/*' />
    VideoControlFlag_FlipVertical = 0x2,

    /// <include file='VideoControlFlags.xml' path='doc/member[@name="VideoControlFlags.VideoControlFlag_ExternalTriggerEnable"]/*' />
    VideoControlFlag_ExternalTriggerEnable = 0x4,

    /// <include file='VideoControlFlags.xml' path='doc/member[@name="VideoControlFlags.VideoControlFlag_Trigger"]/*' />
    VideoControlFlag_Trigger = 0x8,
}
