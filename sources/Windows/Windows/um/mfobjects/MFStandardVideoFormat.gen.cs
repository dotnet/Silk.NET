// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MFStandardVideoFormat.xml' path='doc/member[@name="MFStandardVideoFormat"]/*' />
public enum MFStandardVideoFormat
{
    /// <include file='MFStandardVideoFormat.xml' path='doc/member[@name="MFStandardVideoFormat.MFStdVideoFormat_reserved"]/*' />
    MFStdVideoFormat_reserved = 0,

    /// <include file='MFStandardVideoFormat.xml' path='doc/member[@name="MFStandardVideoFormat.MFStdVideoFormat_NTSC"]/*' />
    MFStdVideoFormat_NTSC = (MFStdVideoFormat_reserved + 1),

    /// <include file='MFStandardVideoFormat.xml' path='doc/member[@name="MFStandardVideoFormat.MFStdVideoFormat_PAL"]/*' />
    MFStdVideoFormat_PAL = (MFStdVideoFormat_NTSC + 1),

    /// <include file='MFStandardVideoFormat.xml' path='doc/member[@name="MFStandardVideoFormat.MFStdVideoFormat_DVD_NTSC"]/*' />
    MFStdVideoFormat_DVD_NTSC = (MFStdVideoFormat_PAL + 1),

    /// <include file='MFStandardVideoFormat.xml' path='doc/member[@name="MFStandardVideoFormat.MFStdVideoFormat_DVD_PAL"]/*' />
    MFStdVideoFormat_DVD_PAL = (MFStdVideoFormat_DVD_NTSC + 1),

    /// <include file='MFStandardVideoFormat.xml' path='doc/member[@name="MFStandardVideoFormat.MFStdVideoFormat_DV_PAL"]/*' />
    MFStdVideoFormat_DV_PAL = (MFStdVideoFormat_DVD_PAL + 1),

    /// <include file='MFStandardVideoFormat.xml' path='doc/member[@name="MFStandardVideoFormat.MFStdVideoFormat_DV_NTSC"]/*' />
    MFStdVideoFormat_DV_NTSC = (MFStdVideoFormat_DV_PAL + 1),

    /// <include file='MFStandardVideoFormat.xml' path='doc/member[@name="MFStandardVideoFormat.MFStdVideoFormat_ATSC_SD480i"]/*' />
    MFStdVideoFormat_ATSC_SD480i = (MFStdVideoFormat_DV_NTSC + 1),

    /// <include file='MFStandardVideoFormat.xml' path='doc/member[@name="MFStandardVideoFormat.MFStdVideoFormat_ATSC_HD1080i"]/*' />
    MFStdVideoFormat_ATSC_HD1080i = (MFStdVideoFormat_ATSC_SD480i + 1),

    /// <include file='MFStandardVideoFormat.xml' path='doc/member[@name="MFStandardVideoFormat.MFStdVideoFormat_ATSC_HD720p"]/*' />
    MFStdVideoFormat_ATSC_HD720p = (MFStdVideoFormat_ATSC_HD1080i + 1),
}
