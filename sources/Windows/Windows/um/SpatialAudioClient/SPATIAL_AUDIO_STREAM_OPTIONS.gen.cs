// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioClient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SPATIAL_AUDIO_STREAM_OPTIONS.xml' path='doc/member[@name="SPATIAL_AUDIO_STREAM_OPTIONS"]/*' />
public enum SPATIAL_AUDIO_STREAM_OPTIONS
{
    /// <include file='SPATIAL_AUDIO_STREAM_OPTIONS.xml' path='doc/member[@name="SPATIAL_AUDIO_STREAM_OPTIONS.SPATIAL_AUDIO_STREAM_OPTIONS_NONE"]/*' />
    SPATIAL_AUDIO_STREAM_OPTIONS_NONE = 0,

    /// <include file='SPATIAL_AUDIO_STREAM_OPTIONS.xml' path='doc/member[@name="SPATIAL_AUDIO_STREAM_OPTIONS.SPATIAL_AUDIO_STREAM_OPTIONS_OFFLOAD"]/*' />
    SPATIAL_AUDIO_STREAM_OPTIONS_OFFLOAD = 0x1,
}
