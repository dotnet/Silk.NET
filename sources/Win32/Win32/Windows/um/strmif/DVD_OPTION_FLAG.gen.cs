// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DVD_OPTION_FLAG
{
    DVD_ResetOnStop = 1,
    DVD_NotifyParentalLevelChange = 2,
    DVD_HMSF_TimeCodeEvents = 3,
    DVD_AudioDuringFFwdRew = 4,
    DVD_EnableNonblockingAPIs = 5,
    DVD_CacheSizeInMB = 6,
    DVD_EnablePortableBookmarks = 7,
    DVD_EnableExtendedCopyProtectErrors = 8,
    DVD_NotifyPositionChange = 9,
    DVD_IncreaseOutputControl = 10,
    DVD_EnableStreaming = 11,
    DVD_EnableESOutput = 12,
    DVD_EnableTitleLength = 13,
    DVD_DisableStillThrottle = 14,
    DVD_EnableLoggingEvents = 15,
    DVD_MaxReadBurstInKB = 16,
    DVD_ReadBurstPeriodInMS = 17,
    DVD_RestartDisc = 18,
    DVD_EnableCC = 19,
}
