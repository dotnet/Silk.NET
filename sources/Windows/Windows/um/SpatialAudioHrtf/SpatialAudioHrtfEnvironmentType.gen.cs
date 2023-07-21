// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioHrtf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SpatialAudioHrtfEnvironmentType.xml' path='doc/member[@name="SpatialAudioHrtfEnvironmentType"]/*' />
public enum SpatialAudioHrtfEnvironmentType
{
    /// <include file='SpatialAudioHrtfEnvironmentType.xml' path='doc/member[@name="SpatialAudioHrtfEnvironmentType.SpatialAudioHrtfEnvironment_Small"]/*' />
    SpatialAudioHrtfEnvironment_Small = 0,

    /// <include file='SpatialAudioHrtfEnvironmentType.xml' path='doc/member[@name="SpatialAudioHrtfEnvironmentType.SpatialAudioHrtfEnvironment_Medium"]/*' />
    SpatialAudioHrtfEnvironment_Medium = (SpatialAudioHrtfEnvironment_Small + 1),

    /// <include file='SpatialAudioHrtfEnvironmentType.xml' path='doc/member[@name="SpatialAudioHrtfEnvironmentType.SpatialAudioHrtfEnvironment_Large"]/*' />
    SpatialAudioHrtfEnvironment_Large = (SpatialAudioHrtfEnvironment_Medium + 1),

    /// <include file='SpatialAudioHrtfEnvironmentType.xml' path='doc/member[@name="SpatialAudioHrtfEnvironmentType.SpatialAudioHrtfEnvironment_Outdoors"]/*' />
    SpatialAudioHrtfEnvironment_Outdoors = (SpatialAudioHrtfEnvironment_Large + 1),

    /// <include file='SpatialAudioHrtfEnvironmentType.xml' path='doc/member[@name="SpatialAudioHrtfEnvironmentType.SpatialAudioHrtfEnvironment_Average"]/*' />
    SpatialAudioHrtfEnvironment_Average = (SpatialAudioHrtfEnvironment_Outdoors + 1),
}
