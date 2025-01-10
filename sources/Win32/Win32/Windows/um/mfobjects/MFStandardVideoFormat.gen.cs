// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum MFStandardVideoFormat
{
    MFStdVideoFormat_reserved = 0,
    MFStdVideoFormat_NTSC = (MFStdVideoFormat_reserved + 1),
    MFStdVideoFormat_PAL = (MFStdVideoFormat_NTSC + 1),
    MFStdVideoFormat_DVD_NTSC = (MFStdVideoFormat_PAL + 1),
    MFStdVideoFormat_DVD_PAL = (MFStdVideoFormat_DVD_NTSC + 1),
    MFStdVideoFormat_DV_PAL = (MFStdVideoFormat_DVD_PAL + 1),
    MFStdVideoFormat_DV_NTSC = (MFStdVideoFormat_DV_PAL + 1),
    MFStdVideoFormat_ATSC_SD480i = (MFStdVideoFormat_DV_NTSC + 1),
    MFStdVideoFormat_ATSC_HD1080i = (MFStdVideoFormat_ATSC_SD480i + 1),
    MFStdVideoFormat_ATSC_HD720p = (MFStdVideoFormat_ATSC_HD1080i + 1),
}
