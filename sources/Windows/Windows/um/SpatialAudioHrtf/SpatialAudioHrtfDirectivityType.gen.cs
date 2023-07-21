// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioHrtf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SpatialAudioHrtfDirectivityType.xml' path='doc/member[@name="SpatialAudioHrtfDirectivityType"]/*' />
public enum SpatialAudioHrtfDirectivityType
{
    /// <include file='SpatialAudioHrtfDirectivityType.xml' path='doc/member[@name="SpatialAudioHrtfDirectivityType.SpatialAudioHrtfDirectivity_OmniDirectional"]/*' />
    SpatialAudioHrtfDirectivity_OmniDirectional = 0,

    /// <include file='SpatialAudioHrtfDirectivityType.xml' path='doc/member[@name="SpatialAudioHrtfDirectivityType.SpatialAudioHrtfDirectivity_Cardioid"]/*' />
    SpatialAudioHrtfDirectivity_Cardioid = (SpatialAudioHrtfDirectivity_OmniDirectional + 1),

    /// <include file='SpatialAudioHrtfDirectivityType.xml' path='doc/member[@name="SpatialAudioHrtfDirectivityType.SpatialAudioHrtfDirectivity_Cone"]/*' />
    SpatialAudioHrtfDirectivity_Cone = (SpatialAudioHrtfDirectivity_Cardioid + 1),
}
