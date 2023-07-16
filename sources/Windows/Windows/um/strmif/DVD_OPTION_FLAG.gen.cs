// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DVD_OPTION_FLAG.xml' path='doc/member[@name="DVD_OPTION_FLAG"]/*'/>
public enum DVD_OPTION_FLAG
{
    /// <include file='DVD_OPTION_FLAG.xml' path='doc/member[@name="DVD_OPTION_FLAG.DVD_ResetOnStop"]/*'/>
    DVD_ResetOnStop = 1,
    /// <include file='DVD_OPTION_FLAG.xml' path='doc/member[@name="DVD_OPTION_FLAG.DVD_NotifyParentalLevelChange"]/*'/>
    DVD_NotifyParentalLevelChange = 2,
    /// <include file='DVD_OPTION_FLAG.xml' path='doc/member[@name="DVD_OPTION_FLAG.DVD_HMSF_TimeCodeEvents"]/*'/>
    DVD_HMSF_TimeCodeEvents = 3,
    /// <include file='DVD_OPTION_FLAG.xml' path='doc/member[@name="DVD_OPTION_FLAG.DVD_AudioDuringFFwdRew"]/*'/>
    DVD_AudioDuringFFwdRew = 4,
    /// <include file='DVD_OPTION_FLAG.xml' path='doc/member[@name="DVD_OPTION_FLAG.DVD_EnableNonblockingAPIs"]/*'/>
    DVD_EnableNonblockingAPIs = 5,
    /// <include file='DVD_OPTION_FLAG.xml' path='doc/member[@name="DVD_OPTION_FLAG.DVD_CacheSizeInMB"]/*'/>
    DVD_CacheSizeInMB = 6,
    /// <include file='DVD_OPTION_FLAG.xml' path='doc/member[@name="DVD_OPTION_FLAG.DVD_EnablePortableBookmarks"]/*'/>
    DVD_EnablePortableBookmarks = 7,
    /// <include file='DVD_OPTION_FLAG.xml' path='doc/member[@name="DVD_OPTION_FLAG.DVD_EnableExtendedCopyProtectErrors"]/*'/>
    DVD_EnableExtendedCopyProtectErrors = 8,
    /// <include file='DVD_OPTION_FLAG.xml' path='doc/member[@name="DVD_OPTION_FLAG.DVD_NotifyPositionChange"]/*'/>
    DVD_NotifyPositionChange = 9,
    /// <include file='DVD_OPTION_FLAG.xml' path='doc/member[@name="DVD_OPTION_FLAG.DVD_IncreaseOutputControl"]/*'/>
    DVD_IncreaseOutputControl = 10,
    /// <include file='DVD_OPTION_FLAG.xml' path='doc/member[@name="DVD_OPTION_FLAG.DVD_EnableStreaming"]/*'/>
    DVD_EnableStreaming = 11,
    /// <include file='DVD_OPTION_FLAG.xml' path='doc/member[@name="DVD_OPTION_FLAG.DVD_EnableESOutput"]/*'/>
    DVD_EnableESOutput = 12,
    /// <include file='DVD_OPTION_FLAG.xml' path='doc/member[@name="DVD_OPTION_FLAG.DVD_EnableTitleLength"]/*'/>
    DVD_EnableTitleLength = 13,
    /// <include file='DVD_OPTION_FLAG.xml' path='doc/member[@name="DVD_OPTION_FLAG.DVD_DisableStillThrottle"]/*'/>
    DVD_DisableStillThrottle = 14,
    /// <include file='DVD_OPTION_FLAG.xml' path='doc/member[@name="DVD_OPTION_FLAG.DVD_EnableLoggingEvents"]/*'/>
    DVD_EnableLoggingEvents = 15,
    /// <include file='DVD_OPTION_FLAG.xml' path='doc/member[@name="DVD_OPTION_FLAG.DVD_MaxReadBurstInKB"]/*'/>
    DVD_MaxReadBurstInKB = 16,
    /// <include file='DVD_OPTION_FLAG.xml' path='doc/member[@name="DVD_OPTION_FLAG.DVD_ReadBurstPeriodInMS"]/*'/>
    DVD_ReadBurstPeriodInMS = 17,
    /// <include file='DVD_OPTION_FLAG.xml' path='doc/member[@name="DVD_OPTION_FLAG.DVD_RestartDisc"]/*'/>
    DVD_RestartDisc = 18,
    /// <include file='DVD_OPTION_FLAG.xml' path='doc/member[@name="DVD_OPTION_FLAG.DVD_EnableCC"]/*'/>
    DVD_EnableCC = 19,
}