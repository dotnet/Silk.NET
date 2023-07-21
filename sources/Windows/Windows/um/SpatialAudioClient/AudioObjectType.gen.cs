// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioClient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='AudioObjectType.xml' path='doc/member[@name="AudioObjectType"]/*' />
[Flags]
public enum AudioObjectType
{
    /// <include file='AudioObjectType.xml' path='doc/member[@name="AudioObjectType.AudioObjectType_None"]/*' />
    AudioObjectType_None = 0,

    /// <include file='AudioObjectType.xml' path='doc/member[@name="AudioObjectType.AudioObjectType_Dynamic"]/*' />
    AudioObjectType_Dynamic = (1 << 0),

    /// <include file='AudioObjectType.xml' path='doc/member[@name="AudioObjectType.AudioObjectType_FrontLeft"]/*' />
    AudioObjectType_FrontLeft = (1 << 1),

    /// <include file='AudioObjectType.xml' path='doc/member[@name="AudioObjectType.AudioObjectType_FrontRight"]/*' />
    AudioObjectType_FrontRight = (1 << 2),

    /// <include file='AudioObjectType.xml' path='doc/member[@name="AudioObjectType.AudioObjectType_FrontCenter"]/*' />
    AudioObjectType_FrontCenter = (1 << 3),

    /// <include file='AudioObjectType.xml' path='doc/member[@name="AudioObjectType.AudioObjectType_LowFrequency"]/*' />
    AudioObjectType_LowFrequency = (1 << 4),

    /// <include file='AudioObjectType.xml' path='doc/member[@name="AudioObjectType.AudioObjectType_SideLeft"]/*' />
    AudioObjectType_SideLeft = (1 << 5),

    /// <include file='AudioObjectType.xml' path='doc/member[@name="AudioObjectType.AudioObjectType_SideRight"]/*' />
    AudioObjectType_SideRight = (1 << 6),

    /// <include file='AudioObjectType.xml' path='doc/member[@name="AudioObjectType.AudioObjectType_BackLeft"]/*' />
    AudioObjectType_BackLeft = (1 << 7),

    /// <include file='AudioObjectType.xml' path='doc/member[@name="AudioObjectType.AudioObjectType_BackRight"]/*' />
    AudioObjectType_BackRight = (1 << 8),

    /// <include file='AudioObjectType.xml' path='doc/member[@name="AudioObjectType.AudioObjectType_TopFrontLeft"]/*' />
    AudioObjectType_TopFrontLeft = (1 << 9),

    /// <include file='AudioObjectType.xml' path='doc/member[@name="AudioObjectType.AudioObjectType_TopFrontRight"]/*' />
    AudioObjectType_TopFrontRight = (1 << 10),

    /// <include file='AudioObjectType.xml' path='doc/member[@name="AudioObjectType.AudioObjectType_TopBackLeft"]/*' />
    AudioObjectType_TopBackLeft = (1 << 11),

    /// <include file='AudioObjectType.xml' path='doc/member[@name="AudioObjectType.AudioObjectType_TopBackRight"]/*' />
    AudioObjectType_TopBackRight = (1 << 12),

    /// <include file='AudioObjectType.xml' path='doc/member[@name="AudioObjectType.AudioObjectType_BottomFrontLeft"]/*' />
    AudioObjectType_BottomFrontLeft = (1 << 13),

    /// <include file='AudioObjectType.xml' path='doc/member[@name="AudioObjectType.AudioObjectType_BottomFrontRight"]/*' />
    AudioObjectType_BottomFrontRight = (1 << 14),

    /// <include file='AudioObjectType.xml' path='doc/member[@name="AudioObjectType.AudioObjectType_BottomBackLeft"]/*' />
    AudioObjectType_BottomBackLeft = (1 << 15),

    /// <include file='AudioObjectType.xml' path='doc/member[@name="AudioObjectType.AudioObjectType_BottomBackRight"]/*' />
    AudioObjectType_BottomBackRight = (1 << 16),

    /// <include file='AudioObjectType.xml' path='doc/member[@name="AudioObjectType.AudioObjectType_BackCenter"]/*' />
    AudioObjectType_BackCenter = (1 << 17),
}
