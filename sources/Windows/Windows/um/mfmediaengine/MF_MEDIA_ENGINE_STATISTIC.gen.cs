// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='MF_MEDIA_ENGINE_STATISTIC.xml' path='doc/member[@name="MF_MEDIA_ENGINE_STATISTIC"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum MF_MEDIA_ENGINE_STATISTIC
{
    /// <include file='MF_MEDIA_ENGINE_STATISTIC.xml' path='doc/member[@name="MF_MEDIA_ENGINE_STATISTIC.MF_MEDIA_ENGINE_STATISTIC_FRAMES_RENDERED"]/*'/>
    MF_MEDIA_ENGINE_STATISTIC_FRAMES_RENDERED = 0,
    /// <include file='MF_MEDIA_ENGINE_STATISTIC.xml' path='doc/member[@name="MF_MEDIA_ENGINE_STATISTIC.MF_MEDIA_ENGINE_STATISTIC_FRAMES_DROPPED"]/*'/>
    MF_MEDIA_ENGINE_STATISTIC_FRAMES_DROPPED = 1,
    /// <include file='MF_MEDIA_ENGINE_STATISTIC.xml' path='doc/member[@name="MF_MEDIA_ENGINE_STATISTIC.MF_MEDIA_ENGINE_STATISTIC_BYTES_DOWNLOADED"]/*'/>
    MF_MEDIA_ENGINE_STATISTIC_BYTES_DOWNLOADED = 2,
    /// <include file='MF_MEDIA_ENGINE_STATISTIC.xml' path='doc/member[@name="MF_MEDIA_ENGINE_STATISTIC.MF_MEDIA_ENGINE_STATISTIC_BUFFER_PROGRESS"]/*'/>
    MF_MEDIA_ENGINE_STATISTIC_BUFFER_PROGRESS = 3,
    /// <include file='MF_MEDIA_ENGINE_STATISTIC.xml' path='doc/member[@name="MF_MEDIA_ENGINE_STATISTIC.MF_MEDIA_ENGINE_STATISTIC_FRAMES_PER_SECOND"]/*'/>
    MF_MEDIA_ENGINE_STATISTIC_FRAMES_PER_SECOND = 4,
    /// <include file='MF_MEDIA_ENGINE_STATISTIC.xml' path='doc/member[@name="MF_MEDIA_ENGINE_STATISTIC.MF_MEDIA_ENGINE_STATISTIC_PLAYBACK_JITTER"]/*'/>
    MF_MEDIA_ENGINE_STATISTIC_PLAYBACK_JITTER = 5,
    /// <include file='MF_MEDIA_ENGINE_STATISTIC.xml' path='doc/member[@name="MF_MEDIA_ENGINE_STATISTIC.MF_MEDIA_ENGINE_STATISTIC_FRAMES_CORRUPTED"]/*'/>
    MF_MEDIA_ENGINE_STATISTIC_FRAMES_CORRUPTED = 6,
    /// <include file='MF_MEDIA_ENGINE_STATISTIC.xml' path='doc/member[@name="MF_MEDIA_ENGINE_STATISTIC.MF_MEDIA_ENGINE_STATISTIC_TOTAL_FRAME_DELAY"]/*'/>
    MF_MEDIA_ENGINE_STATISTIC_TOTAL_FRAME_DELAY = 7,
}