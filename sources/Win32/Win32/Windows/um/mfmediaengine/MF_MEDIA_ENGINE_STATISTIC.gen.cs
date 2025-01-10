// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public enum MF_MEDIA_ENGINE_STATISTIC
{
    MF_MEDIA_ENGINE_STATISTIC_FRAMES_RENDERED = 0,
    MF_MEDIA_ENGINE_STATISTIC_FRAMES_DROPPED = 1,
    MF_MEDIA_ENGINE_STATISTIC_BYTES_DOWNLOADED = 2,
    MF_MEDIA_ENGINE_STATISTIC_BUFFER_PROGRESS = 3,
    MF_MEDIA_ENGINE_STATISTIC_FRAMES_PER_SECOND = 4,
    MF_MEDIA_ENGINE_STATISTIC_PLAYBACK_JITTER = 5,
    MF_MEDIA_ENGINE_STATISTIC_FRAMES_CORRUPTED = 6,
    MF_MEDIA_ENGINE_STATISTIC_TOTAL_FRAME_DELAY = 7,
}
